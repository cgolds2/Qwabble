using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;

public class RestService
{
    //HttpClient client;


    //public RestService()
    //{
    //    var authData = string.Format("{0}:{1}", "test", "pswd");
    //    var authHeaderValue = Convert.ToBase64String(Encoding.UTF8.GetBytes(authData));

    //    client = new HttpClient();
    //    client.MaxResponseContentBufferSize = 256000;
    //    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", authHeaderValue);
    //}

    public static async Task<string> GetCall(string url)
    {

        try
        {
            HttpClient client;
            var authData = string.Format("{0}:{1}", "test", "pswd");
            var authHeaderValue = Convert.ToBase64String(Encoding.UTF8.GetBytes(authData));

            client = new HttpClient();
            client.MaxResponseContentBufferSize = 256000;
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", authHeaderValue);

            string html = string.Empty;

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.AutomaticDecompression = DecompressionMethods.GZip;

            using (HttpWebResponse response2 = (HttpWebResponse)request.GetResponse())
            using (Stream stream = response2.GetResponseStream())
            using (StreamReader reader = new StreamReader(stream))
            {
                html = reader.ReadToEnd();
            }

            Console.WriteLine(html);
            return html;
        }

        catch (Exception e)
        {
            return "";
        }
    }




    public static async Task<string> PostCall(string body, string url)
    {
        try
        {
            HttpClient client;
            var authData = string.Format("{0}:{1}", "test", "pswd");
            var authHeaderValue = Convert.ToBase64String(Encoding.UTF8.GetBytes(authData));

            client = new HttpClient();
            client.MaxResponseContentBufferSize = 256000;
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", authHeaderValue);

            var content = new StringContent(body, Encoding.UTF8, "application/json");

            HttpResponseMessage response = null;
            response = await client.PostAsync(url, content);

            var responseString = await response.Content.ReadAsStringAsync();

            Debug.WriteLine(responseString);
            return responseString;

        }
        catch (Exception ex)
        {

            return ex.Message;
        }

    }

}


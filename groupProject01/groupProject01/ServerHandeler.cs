using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace groupProject01
{
    class ServerHandeler
    {
        public static void pingServer()
        {

        }
        public static void postRequest()
        {
            try
            {
                string url = "http://mydomain...";
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
                request.Method = "GET/POST";
                //using GET - request.Headers.Add ("Authorization","Authorizaation value");
                request.ContentType = "application/json";
                HttpWebResponse myResp = (HttpWebResponse)request.GetResponse();
                string responseText;

                using (var response = request.GetResponse())
                {
                    using (var reader = new StreamReader(response.GetResponseStream()))
                    {
                        responseText = reader.ReadToEnd();
                        Console.WriteLine(responseText);
                        var forth = new Intent(this, typeof(SecondActivity));
                        forth.PutExtra("responseText2", responseText);
                        StartActivity(forth);
                    }
                }
            }

            catch (WebException exception)
            {
                string responseText;
                using (var reader = new StreamReader(exception.Response.GetResponseStream()))
                {
                    responseText = reader.ReadToEnd();
                    Console.WriteLine(responseText);
                }
            }
        }
    }
}

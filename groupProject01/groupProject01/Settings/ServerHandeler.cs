//using Android.Content;
//using Android.Content;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Threading;
using System.Text;
using Newtonsoft.Json;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using Newtonsoft.Json.Linq;

using groupProject01.Other;

namespace groupProject01
{
    class ServerHandeler
    {

        public static string baseuri = "http://192.168.3.3/";
        public static Boolean pingServer()
        {
            throw new NotImplementedException();
        }




        //LIST
        //createList(username, userID, apartmentID, noteName, listType, data, )
        public async static Task<string> sendList(ListItemObject ldata, GlobalData gd)
        {
            //createList(username, userID, apartmentID, noteName, listType, data)
            string jsonString = JsonConvert.SerializeObject(ldata);
            JObject ob = JObject.Parse(jsonString);
            ob["username"] = gd.CurrentUser.username;
            ob["apartmentID"] = gd.CurrentUser.ApartmentID;
            ob["userID"] = gd.CurrentUser.UserID;
            string result = await (RestService.PostCall(ob.ToString(), baseuri + "createNote.php"));
            return result;

        }
        //getNotes(apartmentID)
        async public static Task<List<ListItemObject>> getList(GlobalData gd, int listid)
        {
            Other.UserObject u = gd.CurrentUser;
            int ApartmentID = u.ApartmentID;
            string get = baseuri + "getNotes.php?apartmentID=" + ApartmentID;

            string text = await (RestService.GetCall(get));
            List<ListItemObject> ret = new List<ListItemObject>();
            string[] result = Regex.Split(text, "\r\n|\r|\n");
            foreach (string s in result)
            {
                if (s.Equals("")) { continue; }
                ListItemObject deserializedProduct = JsonConvert.DeserializeObject<ListItemObject>(s);
                ret.Add(deserializedProduct);
            }
            //  ListItemObject deserializedProduct = JsonConvert.DeserializeObject<ListItemObject>(output);
            return ret;
        }

        //CAL
        //createEvent(username, startDate, endDate, name, userID, apartmentID)
        public async static Task<string> sendEvent(EventObject edata, GlobalData gd)
        {
            //createList(username, userID, apartmentID, noteName, listType, data)
            string jsonString = JsonConvert.SerializeObject(edata);
            JObject ob = JObject.Parse(jsonString);
            ob["username"] = gd.CurrentUser.username;
            ob["userID"] = gd.CurrentUser.UserID;
            ob["apartmentID"] = gd.CurrentUser.ApartmentID;
            string result = await (RestService.PostCall(ob.ToString(), baseuri + "createEvent.php"));
            return result;

        }

        //getEvents(apartmentID)
        async public static Task<List<EventObject>> getCalendar(GlobalData gd)
        {
            Other.UserObject u = gd.CurrentUser;
            int ApartmentID = u.ApartmentID;
            string get = baseuri + "getEvents.php?apartmentID=" + ApartmentID;
            string text = await (RestService.GetCall(get));
            List<EventObject> ret = new List<EventObject>();
            string[] result = Regex.Split(text, "\r\n|\r|\n");
            foreach (string s in result)
            {
                if (s.Equals("")) { continue; }
                EventObject deserializedProduct = JsonConvert.DeserializeObject<EventObject>(s);
                ret.Add(deserializedProduct);
            }
            //  ListItemObject deserializedProduct = JsonConvert.DeserializeObject<ListItemObject>(output);
            return ret;
        }

        //MESSAGE
        //createGroupMessage(userID, MSGText,apartmentID) //adds group message
        public async static Task<string> sendMessage(MessageObject mdata, GlobalData gd)
        {
            //createList(username, userID, apartmentID, noteName, listType, data)
            string jsonString = JsonConvert.SerializeObject(mdata);
            JObject ob = JObject.Parse(jsonString);
            ob["apartmentID"] = gd.CurrentUser.ApartmentID;
            ob["userID"] = gd.CurrentUser.UserID;
            string result = await (RestService.PostCall(ob.ToString(), baseuri + "createGroupMessage.php"));
            return result;

        }
        //getMessages(apartmentID)
        async public static Task<List<MessageObject>> getMessages(GlobalData gd)
        {
            Other.UserObject u = gd.CurrentUser;
            int ApartmentID = u.ApartmentID;
            string get = baseuri + "getMessages.php?apartmentID=" + ApartmentID;
            string text = await (RestService.GetCall(get));
            List<MessageObject> ret = new List<MessageObject>();
            string[] result = Regex.Split(text, "\r\n|\r|\n");
            foreach (string s in result)
            {
                if (s.Equals("")) { continue; }
                MessageObject deserializedProduct = JsonConvert.DeserializeObject<MessageObject>(s);
                deserializedProduct.SenderName = await (getUsername(deserializedProduct.SenderID));
                ret.Add(deserializedProduct);
            }
            //  ListItemObject deserializedProduct = JsonConvert.DeserializeObject<ListItemObject>(output);
            return ret;
        }

        //USER - NOT IMPLEMENTED
        //createUser(username,password) // returns user id
        public async static Task<int> createUser(UserObject u, string password)
        {
            string jsonString = JsonConvert.SerializeObject(u);
            JObject ob = JObject.Parse(jsonString);
            ob["password"] = password;
            string result = await (RestService.PostCall(ob.ToString(), baseuri + "createUserSEC.php"));
            try
            {
                return Int32.Parse(result);
            }
            catch (Exception)
            {
                return -1;
            }

        }


        //getUserInfo(username / userID) //2 different statments for either I guess
        async public static Task<UserObject> getUserInfo(int userID)
        {
            string get = baseuri + "getUserInfo.php?userID=" + userID;
            string text = await (RestService.GetCall(get));
            UserObject ret = JsonConvert.DeserializeObject<UserObject>(text);
            return ret;
        }

        async public static Task<string> getUsername(int userID)
        {
                UserObject u = await (getUserInfo(userID));
                return u.username;
        }

        //addUserToApartment(userID,apartmentID
        async public static Task<int> addUserToApartment(int userID, int apartmentID)
        {
            string get = baseuri + "addUserToApartment.php?userID=" + userID + "&apartmentID=" + apartmentID;
            string text = await (RestService.GetCall(get));
            int test = -1;
            try
            {
                test = Int32.Parse(text);
            }
            catch (Exception ex)
            {

            }
            return test;
        }

        async public static Task<List<ApartmentObject>> getApartments()
        {
            string get = baseuri + "getApartments.php";
            string text = await (RestService.GetCall(get));
            List<ApartmentObject> ret = new List<ApartmentObject>();
            string[] result = Regex.Split(text, "\r\n|\r|\n");
            foreach (string s in result)
            {
                if (s.Equals("")) { continue; }
                ApartmentObject deserializedProduct = JsonConvert.DeserializeObject<ApartmentObject>(s);
                ret.Add(deserializedProduct);
            }
            return ret;
        }

        async public static Task<List<UserObject>> getAllUsers(int apartmentID)
        {
            string get = baseuri + "getAllUsers.php?&apartmentID=" + apartmentID;
            string text = await (RestService.GetCall(get));
            List<UserObject> ret = new List<UserObject>();
            string[] result = Regex.Split(text, "\r\n|\r|\n");
            foreach (string s in result)
            {
                if (s.Equals("")) { continue; }
                UserObject deserializedProduct = JsonConvert.DeserializeObject<UserObject>(s);
                ret.Add(deserializedProduct);
            }
            return ret;
        }

        public async static Task<string> createApartment(ApartmentObject apmt, GlobalData gd)
        {
            //createList(username, userID, apartmentID, noteName, listType, data)
            string jsonString = JsonConvert.SerializeObject(apmt);
            JObject ob = JObject.Parse(jsonString);
            ob["owner"] = gd.CurrentUser.UserID;
            string result = await (RestService.PostCall(ob.ToString(), baseuri + "createApartment.php"));
            return result;




            /*
			 * createApartment(userID (creator/owner), name, location) //return apartment ID
			 */
        }

        //LOGIN
        //createList(username, userID, apartmentID, noteName, listType, data, )
        public async static Task<string> login(string email, string password)
        {
            //createList(username, userID, apartmentID, noteName, listType, data)
            JObject ob = new JObject();
            //JObject ob = JObject.Parse(jsonString);
            ob["email"] = email;
            ob["password"] = password;
            string result = await (RestService.PostCall(ob.ToString(), baseuri + "login.php"));
            return result;

        }
    }
}

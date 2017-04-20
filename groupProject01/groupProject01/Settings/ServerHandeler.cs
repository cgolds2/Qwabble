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

        /*
         * requestToJoinApartment(userID, ApartmentID)
         * createPersonalMessage(senderID, ReceiverID, MSGText) //adds message for DMing someone
         */

        /*
         * getAllUsers(apartmentID)
         * addUserToApartment(userID) //returns apartment # of the user, could be post
         * createApartment(userID (creator/owner), name, location) //return apartment ID
         * getApartments(location)
         */

        //LIST
        //createList(username, userID, apartmentID, listName, listType, listText, )
        public async static Task<string> sendList(ListItemObject ldata, GlobalData gd)
        {
            //createList(username, userID, apartmentID, listName, listType, listText)
            string jsonString = JsonConvert.SerializeObject(ldata);
            JObject ob = JObject.Parse(jsonString);
            ob["username"] = gd.CurrentUser.Username;
            ob["apartmentID"] = gd.CurrentUser.ApartmentID;
            ob["userID"] = gd.CurrentUser.UserID;
            string result = await (RestService.PostCall(ob.ToString(), baseuri + "createNote.php"));
            return result;

        }
        //getNotes(apartmentID)
        async public static Task<List<ListItemObject>> getList(GlobalData gd)
        {
            Other.UserObject u = gd.CurrentUser;
            int ApartmentID = u.ApartmentID;
            string get = baseuri + "getNotes.php?apartmentID=" + ApartmentID;
            string text = await (RestService.GetCall(get));
            List<ListItemObject> ret = new List<ListItemObject>();
            string[] result = Regex.Split(text, "\r\n|\r|\n");
            foreach (string s in result)
            {
                ListItemObject deserializedProduct = JsonConvert.DeserializeObject<ListItemObject>(s);
                ret.Add(deserializedProduct);
            }
            //  ListItemObject deserializedProduct = JsonConvert.DeserializeObject<ListItemObject>(output);
            return ret;
        }

        //CAL
        //createEvent(username, startDate, endDate, eventName, userID, apartmentID)
        public async static Task<string> sendEvent(EventObject edata, GlobalData gd)
        {
            //createList(username, userID, apartmentID, listName, listType, listText)
            string jsonString = JsonConvert.SerializeObject(edata);
            JObject ob = JObject.Parse(jsonString);
            ob["username"] = gd.CurrentUser.Username;
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
                EventObject deserializedProduct = JsonConvert.DeserializeObject<EventObject>(s);
                ret.Add(deserializedProduct);
            }
            //  ListItemObject deserializedProduct = JsonConvert.DeserializeObject<ListItemObject>(output);
            return ret;
        }

        //MESSAGE
        //createGroupMessage(userID, MSGText,apartmentID) //adds group message
        public async static Task<string> sendMessage(MessageObject mdata, GlobalData gd, int calID)
        {
            //createList(username, userID, apartmentID, listName, listType, listText)
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
                MessageObject deserializedProduct = JsonConvert.DeserializeObject<MessageObject>(s);
                ret.Add(deserializedProduct);
            }
            //  ListItemObject deserializedProduct = JsonConvert.DeserializeObject<ListItemObject>(output);
            return ret;
        }

        //USER - NOT IMPLEMENTED
        //createUser(username,password) // returns user id
        public async static Task<string> createUser(UserObject u)
        {
            //createList(username, userID, apartmentID, listName, listType, listText)
            string jsonString = JsonConvert.SerializeObject(u);
            JObject ob = JObject.Parse(jsonString);
            string result = await (RestService.PostCall(ob.ToString(), baseuri + "createUser.php"));
            return result;

        }


        //getUserInfo(username / userID) //2 different statments for either I guess
        async public static Task<UserObject> getUserInfo(int userID)
        {
            string get = baseuri + "getNotes.php?username=" + userID;
            string text = await (RestService.GetCall(get));
            UserObject ret = new UserObject();
            UserObject deserializedProduct = JsonConvert.DeserializeObject<UserObject>(text);
            return ret;
        }

    }
}

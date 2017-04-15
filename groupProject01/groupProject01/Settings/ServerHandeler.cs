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


namespace groupProject01
{
    class ServerHandeler
    {
        public static string baseuri = "http://172.16.42.4/";
        public static Boolean pingServer()
        {
            throw new NotImplementedException();
        }


         public async static Task<string> sendList(ListItemObject ldata, GlobalData gd)
        {
            string jsonString = JsonConvert.SerializeObject(ldata);
            string result = await (RestService.PostCall(jsonString, baseuri+ "createNote.php"));
           return result;
            
        }

        async public static Task<List<ListItemObject>> getList(int ID,GlobalData gd)
        {
            Other.UserObject u = gd.CurrentUser;
            int ApartmentID = u.ApartmentID;
            string get = baseuri + "getNotes.php?apartmentID=" + ApartmentID;
            string text = await(RestService.GetCall(get));
            List<ListItemObject> ret = new List<ListItemObject>();
            string[] result = Regex.Split(text, "\r\n|\r|\n");
            foreach(string s in result){
                ListItemObject deserializedProduct = JsonConvert.DeserializeObject<ListItemObject>(s);
                ret.Add(deserializedProduct);
            }
          //  ListItemObject deserializedProduct = JsonConvert.DeserializeObject<ListItemObject>(output);
            return ret;
        }

        #region HTTP POST
        public static void requestToJoinApartment(string userID, string ApartmentID)
        {

        }

        public static void editMessage(int MessageID)
        {

        }

        public static void editNote(int NoteID)
        {

        }

        public static void editUser(int UserID)
        {

        }

        public static void editEvent(int EventID)
        {

        }

        #endregion

        #region HTTP GET
        /// <summary>
        /// Returns the new note id
        /// </summary>
        public static int createNote(string name, string userID, string apartmentID, string notesTextInBody)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Returns the new event id
        /// </summary>
        public static int createEvent(string date, string name, string userID, string apartmentID)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// Returns the new message id
        /// </summary>
        public static int createPersonalMessage(string senderID, string ReceiverID, string MSGText)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Returns the new message id
        /// </summary>
        public static int createGroupMessage(string userID, string MSGText)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Returns the new user id
        /// </summary>
        public static int createUser(string username, string password)
        {
            throw new NotImplementedException();
        }

        public static string getUsername(string userID)
        {

            throw new NotImplementedException();
        }

        public static int getUserID(string username)
        {
            throw new NotImplementedException();
        }

        public static List<String> getAllUsers(string apartmentID)
        {
            throw new NotImplementedException();
        }

        public static List<String> getNotes(string userID)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Returns the new roomate-number (ex: owner is 1)
        /// </summary>
        public static int addUserToApartment(string userID)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Returns the new apartment id
        /// </summary>
        public static int createApartment(string userID, string name, string location)
        {
            throw new NotImplementedException();
        }

        public static List<String> getApartments(string location)
        {
            throw new NotImplementedException();
        }

        public static List<String> getMessages(string userID)
        {
            throw new NotImplementedException();
        }

        public static List<String> getEvents(string userID)
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}

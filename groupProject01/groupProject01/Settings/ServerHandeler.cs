//using Android.Content;
//using Android.Content;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;

namespace groupProject01
{
    class ServerHandeler
    {
        public static Boolean pingServer()
        {
            throw new NotImplementedException();
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

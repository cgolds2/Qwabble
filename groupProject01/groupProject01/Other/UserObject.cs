using System;
using System.Collections.Generic;
using System.Text;

namespace groupProject01.Other
{
    public class UserObject
    {
        private string _username = "";
        private int _userID = 0;
        private int _apartmentID = 0;

        public string Username
        {
            get
            {
                return _username;
            }

            set
            {
                _username = value;
            }
        }

        public int UserID
        {
            get
            {
                return _userID;
            }

            set
            {
                _userID = value;
            }
        }

        public int ApartmentID
        {
            get
            {
                return _apartmentID;
            }

            set
            {
                _apartmentID = value;
            }
        }

        public UserObject()
        {

        }
    }
}

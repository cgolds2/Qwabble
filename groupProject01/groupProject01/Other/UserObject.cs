using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

using Xamarin.Forms;

namespace groupProject01.Other
{

    public class UserObject
    {

        private string _username = "testuser";
        private int _userID = -1;
        private int _apartmentID = -1;
        private string _email = "";

        public string username
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

        public string email
        {
            get
            {
                return _email;
            }

            set
            {
                _email = value;
            }
        }

        public UserObject()
        {

        }
    }
}


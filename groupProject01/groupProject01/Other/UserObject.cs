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

        private string _username = "";
        private int _userID = 0;
        private int _apartmentID = 1;

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


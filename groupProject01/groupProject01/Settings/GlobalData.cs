using groupProject01;
using groupProject01.Other;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace groupProject01
{
    public class GlobalData
    {
        #region DataPagesVars
        private SettingsData settingsDataInstance = new SettingsData();
        private HomeData homeDataInstance;
        private MessagingData messagingDataInstance = new MessagingData();
        private ListsData listsDataInstance = new ListsData();
        private CalendarData calendarDataInstance = new CalendarData();
        private Other.UserObject currentUser=new Other.UserObject();
        private ApartmentObject currentApartment = new ApartmentObject();
        
        #endregion

        #region GlobalVariables
        public string serverURI = "72.ojfbgkabergiw";

        public ListsData ListsDataInstance
        {
            get
            {
                return listsDataInstance;
            }

            set
            {
                listsDataInstance = value;
            }
        }

        public MessagingData MessagingDataInstance
        {
            get
            {
                return messagingDataInstance;
            }

            set
            {
                messagingDataInstance = value;
            }
        }

        public CalendarData CalendarDataInstance
        {
            get
            {
                return calendarDataInstance;
            }

            set
            {
                calendarDataInstance = value;
            }
        }

        public Other.UserObject CurrentUser
        {
            get
            {
                return currentUser;
            }

            set
            {
                currentUser = value;
            }
        }

        public ApartmentObject CurrentApartment
        {
            get
            {
                return currentApartment;
            }

            set
            {
                currentApartment = value;
            }
        }

        public SettingsData SettingsDataInstance
        {
            get
            {
                return settingsDataInstance;
            }

            set
            {
                settingsDataInstance = value;
            }
        }
        #endregion

        public GlobalData()
        {
            //currentUser.Username = settingsDataInstance.getUserName();

        }
      
    }

}

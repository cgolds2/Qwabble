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
        private SettingsData settingsDataInstance;
        private HomeData homeDataInstance;
        private MessagingData messagingDataInstance = new MessagingData();
        private ListsData listsDataInstance = new ListsData();
        private CalendarData calendarDataInstance = new CalendarData();
        private Other.UserObject currentUser;
        
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
        #endregion

        public GlobalData()
        {
            //currentUser.Username = settingsDataInstance.getUserName();

        }
      
    }

}

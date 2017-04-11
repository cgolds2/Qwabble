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
        public SettingsData settingsDataInstance;
        public HomeData homeDataInstance;
        public MessagingData messagingDataInstance = new MessagingData();
        public ListsData listsDataInstance = new ListsData();
        public CalendarData calendarDataInstance = new CalendarData();
        public Other.UserObject currentUser;
        
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
           // ListsDataInstance.lists.Add(new ListsViewModel { Name = "Repairs", On = true, ID = 3 });
            //currentUser.Username = settingsDataInstance.getUserName();

        }
      
    }

}

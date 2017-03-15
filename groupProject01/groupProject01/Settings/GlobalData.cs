using groupProject01;
using groupProject01.Other;
using System;
using System.Collections.Generic;
using System.Text;

namespace groupProject01
{
    public class GlobalData
    {
        #region DataPagesVars
        public SettingsData settingsDataInstance;
        public HomeData homeDataInstance;
        public MessagingData messagingDataInstance;
        public ListsData listsDataInstance;
        public CalendarData calendarDataInstance;
        public Other.test;
        public Other.UserObject currentUser;
        
        #endregion

        #region GlobalVariables
        public string serverURI = "72.ojfbgkabergiw";
        #endregion

        public GlobalData()
        {
            instantiateDataPages();
            currentUser.Username = settingsDataInstance.getUserName();
            HomePage hp = new HomePage();
        }
        public void instantiateDataPages()
        {
            SettingsData settingsDataInstance = new SettingsData();
            HomeData homeDataInstance = new HomeData();
            MessagingData messagingDataInstance = new MessagingData();
            ListsData listsDataInstance = new ListsData();
            CalendarData calendarDataInstance = new CalendarData();
            currentUser = new UserObject();
        }
    }

}

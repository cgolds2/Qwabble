using System;
using System.Collections.Generic;
using System.Text;

namespace groupProject01
{
    class GlobalData
    {
        #region DataPagesVars
        public SettingsData settingsDataInstance;
        public HomeData homeDataInstance;
        public MessagingData messagingDataInstance;
        public ListsData listsDataInstance;
        public CalendarData calendarDataInstance;
        #endregion

        #region GlobalVariables
        public string Username = "";
        public int UserID = 0;
        public int apartmentID = 0;
        public string serverURI = "72.ojfbgkabergiw";
        #endregion

        public GlobalData()
        {
            Username = settingsDataInstance.getUserName();
            instantiateDataPages();
            HomePage hp = new HomePage();
        }
        public void instantiateDataPages()
        {
         SettingsData settingsDataInstance = new SettingsData();
         HomeData homeDataInstance = new HomeData();
         MessagingData messagingDataInstance= new MessagingData();
         ListsData listsDataInstance = new ListsData();
         CalendarData calendarDataInstance = new CalendarData();
    }
    }
}

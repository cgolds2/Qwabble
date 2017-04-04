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
        public MessagingData messagingDataInstance;
        public ListsData listsDataInstance = new ListsData();
        public CalendarData calendarDataInstance;
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
        #endregion

        public GlobalData()
        {
           // ListsDataInstance.lists.Add(new ListsViewModel { Name = "Repairs", On = true, ID = 3 });
            //currentUser.Username = settingsDataInstance.getUserName();

        }
      
    }

}

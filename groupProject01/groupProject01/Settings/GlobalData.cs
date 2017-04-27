using groupProject01;
using groupProject01.Other;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using System.Threading.Tasks;

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
            //currentUser.username = settingsDataInstance.getUserName();

        }
        public async Task refreshUser(int ID)
        {
            currentUser = await(ServerHandeler.getUserInfo(ID));
            await(refreshApartment());
        }
        public async Task refreshApartment()
        {
            //public static ApartmentObject findApartment(List<ApartmentObject> apt, int apartmentID)        //finds the apartment specified
            List<ApartmentObject> l = await(ServerHandeler.getApartments());
            currentApartment =  PrevApartmentPage.findApartment(l, CurrentUser.ApartmentID);
        }

}

}

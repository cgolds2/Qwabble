using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace groupProject01
{
	public partial class SettingsPage : ContentPage
	{
        GlobalData _gd;
		public SettingsPage (GlobalData gd)         //constructor for settings page
		{
            _gd = gd;           //sets a local instance of global data
			NavigationPage.SetHasNavigationBar(this, false);    //hides the default navigation bar 
            InitializeComponent();      //initializes the UI
		}

        #region BottomBarButtons

        async public void OnHome(object sender, EventArgs e)                          //if home button is pressed
        {
            Application.Current.MainPage = new NavigationPage(new groupProject01.HomePage(_gd));       //direct to home page
         //direct to home page
        }
        async public void OnMessaging(object sender, EventArgs e)                      //if messaging button is pressed
        {
            Application.Current.MainPage = new NavigationPage(new groupProject01.MessagingPage(_gd));        //direct to messaging page
        }
        async public void OnList(object sender, EventArgs e)                          //if lists button is pressed
        {
            Application.Current.MainPage = new NavigationPage(new groupProject01.ListsPage(_gd));           //if lists button is pressed
        }
        async public void OnCalendar(object sender, EventArgs e)                       //if setting button is pressed
        {
            Application.Current.MainPage = new NavigationPage(new groupProject01.CalendarPage(_gd));          //if setting button is pressed
        }
        async public void OnSetting(object sender, EventArgs e)                       //if setting button is pressed
        {
            // Application.Current.MainPage = new NavigationPage(new groupProject01.SettingsPage(_gd)    //if setting button is pressed
        }
        #endregion



       async void OnLogout(object sender, EventArgs e)

        {
            _gd.SettingsDataInstance.setCredentials(keysInt.userName, "");
            _gd.SettingsDataInstance.setCredentials(keysInt.password, "");
            Application.Current.MainPage = new NavigationPage(new groupProject01.InitialPage(_gd));
        }

        void OnCurApartment(object sender, EventArgs e)         //when the apartment id info is clicked on
        {
            DisplayAlert("Apartment ID", "Your apartment ID is " + _gd.CurrentApartment.id + ".", "OK");    //displays an alert with the current apartment id
        }

    }
}

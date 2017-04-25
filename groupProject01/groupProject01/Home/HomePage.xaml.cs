using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace groupProject01
{
	public partial class HomePage : ContentPage
	{

        #region BottomBarButtons

        async public void OnCalendar(object sender, EventArgs e)                          //if home button is pressed
        {
            await Navigation.PushAsync(new groupProject01.CalendarPage(_gd),false);             //direct to home page
        }
        async public void OnMessaging(object sender, EventArgs e)                      //if messaging button is pressed
        {
            await Navigation.PushAsync(new groupProject01.MessagingPage(_gd),false);         //direct to messaging page
        }
        async public void OnList(object sender, EventArgs e)                          //if lists button is pressed
        {
            await Navigation.PushAsync(new groupProject01.ListsPage(_gd),false);            //if lists button is pressed
        }
        async public void OnSetting(object sender, EventArgs e)                       //if setting button is pressed
        {
            await Navigation.PushAsync(new groupProject01.SettingsPage(_gd),false);            //if setting button is pressed
        }

        async public void OnHome(object sender, EventArgs e)                       //if setting button is pressed
        {
            //await Navigation.PushAsync(new groupProject01.HomePage(_gd),false);            //if setting button is pressed
        }

        #endregion
        private GlobalData _gd;                                             //instantiates global variable GlobalData to store the global data

        public HomePage (GlobalData gd)
		{
            NavigationPage.SetHasNavigationBar(this, false);
            InitializeComponent();                                      //initializes UI objects with values provided, initializes elements
            _gd = gd;                                                   //sets private instance of global data
        }
    }
}

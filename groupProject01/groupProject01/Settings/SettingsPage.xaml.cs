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
		public SettingsPage (GlobalData gd)
		{
            _gd = gd;
			NavigationPage.SetHasNavigationBar(this, false);
            InitializeComponent();
		}

        #region BottomBarButtons

        async public void OnHome(object sender, EventArgs e)                          //if home button is pressed
        {
            await Navigation.PushAsync(new groupProject01.HomePage(_gd),false);             //direct to home page
        }
        async public void OnMessaging(object sender, EventArgs e)                      //if messaging button is pressed
        {
            await Navigation.PushAsync(new groupProject01.MessagingPage(_gd),false);         //direct to messaging page
        }
        async public void OnList(object sender, EventArgs e)                          //if lists button is pressed
        {
            await Navigation.PushAsync(new groupProject01.ListsPage(_gd),false);            //if lists button is pressed
        }
        async public void OnCalendar(object sender, EventArgs e)                       //if setting button is pressed
        {
            await Navigation.PushAsync(new groupProject01.CalendarPage(),false);            //if setting button is pressed
        }
        async public void OnSetting(object sender, EventArgs e)                       //if setting button is pressed
        {
            //await Navigation.PushAsync(new groupProject01.SettingsPage(_gd),false);   //if setting button is pressed
        }
        #endregion


        void OnLogout(object sender, EventArgs e)
        {
            //TODO logout user
        }

        void OnCurApartment(object sender, EventArgs e)
        {
            DisplayAlert("Apartment ID", "Your apartment ID is " + _gd.CurrentApartment.id + ".", "OK");
        }
    }
}

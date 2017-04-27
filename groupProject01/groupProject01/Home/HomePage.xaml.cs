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

        async public void OnHome(object sender, EventArgs e)                          //if home button is pressed
        {
          //  Application.Current.MainPage = new NavigationPage(new groupProject01.HomePage(_gd);      //direct to home page
        }
        async public void OnCalendar(object sender, EventArgs e)                      //if calendar button is pressed
        {
            Application.Current.MainPage = new NavigationPage(new groupProject01.CalendarPage(_gd));  //direct to calendar page
        }
        async public void OnMessaging(object sender, EventArgs e)                     //if messaging button is pressed
        {
            Application.Current.MainPage = new NavigationPage(new groupProject01.MessagingPage(_gd)); //if messaging button is pressed
        }
        async public void OnSetting(object sender, EventArgs e)                       //if setting button is pressed
        {
            Application.Current.MainPage = new NavigationPage(new groupProject01.SettingsPage(_gd));    //if setting button is pressed
        }
        async public void OnList(object sender, EventArgs e)                          //if lists button is pressed
        {
            Application.Current.MainPage = new NavigationPage(new groupProject01.ListsPage(_gd));            //if lists button is pressed
        }

        #endregion
        private GlobalData _gd;                                             //instantiates global variable GlobalData to store the global data

        public HomePage(GlobalData gd)
        {
            NavigationPage.SetHasNavigationBar(this, false);
            InitializeComponent();                                      //initializes UI objects with values provided, initializes elements

            var existingPages = this.Navigation.NavigationStack.ToList();
            foreach (var page in existingPages)
            {
                Navigation.RemovePage(page);
            }
            _gd = gd;                                                   //sets private instance of global data
        }
        async void OnBack(object sender, EventArgs e)               //when the back button is pushed
        {
            await Navigation.PopAsync();
        }

    }
}

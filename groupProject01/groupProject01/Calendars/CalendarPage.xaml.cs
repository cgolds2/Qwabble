using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

using Xamarin.Forms;

namespace groupProject01
{

    public partial class CalendarPage : ContentPage                           //begins the CalendarPage class
    {

        public CalendarPage()               //calendar page constructor
        {
            NavigationPage.SetHasNavigationBar(this, false);        //hides the default navigation bar          
            InitializeComponent();          //intializes the UI components
        }
       
            public ObservableCollection<CalendarOptionObject> calendar { get; set; } //declares calendars ObservableCollection that will notify when calendars are added, removed, and refreshed
            private GlobalData _gd;                                              //declares global variable GlobalData to store the global data

            public CalendarPage(GlobalData gd)                                  //CalendarPage constructor
            {
            NavigationPage.SetHasNavigationBar(this, false);

            InitializeComponent();                                          //initializes UI objects with values provided, initializes elements
                _gd = gd;                                                        //sets private instance of global data
                calendar = _gd.CalendarDataInstance.options;                    //gets the calendar data from the data file
                calView.ItemsSource = calendar;                                  //sets the source of items to template and display
            }

        #region BottomBarButtons

        async public void OnHome(object sender, EventArgs e)                          //if home button is pressed
        {
            // Application.Current.MainPage = new NavigationPage(new groupProject01.HomePage(_gd);
            Application.Current.MainPage = new NavigationPage(new groupProject01.HomePage(_gd));           //direct to home page
        }
        async public void OnMessaging(object sender, EventArgs e)                      //if messaging button is pressed
        {
            Application.Current.MainPage = new NavigationPage(new groupProject01.MessagingPage(_gd));        //direct to messaging page
        }
        async public void OnList(object sender, EventArgs e)                          //if lists button is pressed
        {
            Application.Current.MainPage = new NavigationPage(new groupProject01.ListsPage(_gd));          //if lists button is pressed
        }
        async public void OnSetting(object sender, EventArgs e)                       //if setting button is pressed
        {
            Application.Current.MainPage = new NavigationPage(new groupProject01.SettingsPage(_gd));           //if setting button is pressed
        }
        async public void OnCalendar(object sender, EventArgs e)                          //if home button is pressed
        {
            // Application.Current.MainPage = new NavigationPage(new groupProject01.CalendarPage(_gd)             //direct to home page
        }

        #endregion

        async void OnTap(object sender, ItemTappedEventArgs e)                    //Lister that fires when a calendar item is tapped
            {
                int index = ((CalendarOptionObject)e.Item).ID;                           //gets the ID of the calendar item
                await Navigation.PushAsync(new groupProject01.EventPage(index, _gd),false); //opens the event page as current page continues to run
            }
        

    }
}

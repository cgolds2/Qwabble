using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace groupProject01
{
    public partial class ListsPage : ContentPage                                   //class that controls the list of lists page
    {
        public ObservableCollection<ListOfListsObject> lists { get; set; }         //initializes a collection that notifies when items are added, removed, or refreshed
        private GlobalData _gd;                                                    //instantiates global variable GlobalData to store the global data


        #region BottomBarButtons

        async public void OnHome(object sender, EventArgs e)                          //if home button is pressed
        {
            Application.Current.MainPage = new groupProject01.HomePage(_gd);      //direct to home page
        }
        async public void OnCalendar(object sender, EventArgs e)                      //if calendar button is pressed
        {
            Application.Current.MainPage = new groupProject01.CalendarPage(_gd);  //direct to calendar page
        }
        async public void OnMessaging(object sender, EventArgs e)                     //if messaging button is pressed
        {
            Application.Current.MainPage = new groupProject01.MessagingPage(_gd); //if messaging button is pressed
        }
        async public void OnSetting(object sender, EventArgs e)                       //if setting button is pressed
        {
            Application.Current.MainPage = new groupProject01.SettingsPage(_gd);    //if setting button is pressed
        }
        async public void OnList(object sender, EventArgs e)                          //if lists button is pressed
        {
           //  Application.Current.MainPage = new groupProject01.ListsPage(_gd)            //if lists button is pressed
        }

        #endregion


        public ListsPage(GlobalData gd)                                             //ListsPage constructor
        {
            NavigationPage.SetHasNavigationBar(this, false);
            InitializeComponent();                                                  //initializes UI objects with values provided, initializes elements
            _gd = gd;                                                               //sets private instance of global data
            lists =  _gd.ListsDataInstance.lists;                                   //gets the lists data from data file
            lstView.ItemsSource = lists;                                            //sets the source of items to template and display
        }

       async void OnTap(object sender, ItemTappedEventArgs e)                       //Listener that fires when a list is tapped
        {
            int index = ((ListOfListsObject)e.Item).ListOfListID;                    //gets the ID of the list item 
            await Navigation.PushAsync(new groupProject01.ListItemPage(index, _gd),false); //viewing the list item page even while other things occur
        }
    }
}

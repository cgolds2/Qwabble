using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace groupProject01
{
	public partial class MessagingPage : ContentPage        //MessagingPage class
	{
        public List<MessageObject> groups { get; set; }       //creates an instance of messages
        private GlobalData _gd;                             //global variable GlobalData initialzed
        
        public MessagingPage (GlobalData gd)                //MessagingPage constructor
		{
            NavigationPage.SetHasNavigationBar(this, false);
            InitializeComponent();                          //loads the UI elements
            _gd = gd;
            _gd.MessagingDataInstance.getItemsInMessage(_gd); //sets private instance of global data
            groups = _gd.MessagingDataInstance.messages;       //gets the messaging data from the data file
            msgView.ItemsSource = groups;                    //sets the messaging UI
            var target = groups[groups.Count - 1];
            msgView.ScrollTo(target,ScrollToPosition.Start,false);
		}

        #region BottomBarButtons

        async public void OnHome(object sender, EventArgs e)                          //if home button is pressed
        {
            Application.Current.MainPage = new NavigationPage(new groupProject01.HomePage(_gd));            //direct to home page
        }
        async public void OnCalendar(object sender, EventArgs e)                      //if calendar button is pressed
        {
            Application.Current.MainPage = new NavigationPage(new groupProject01.CalendarPage(_gd));        //direct to calendar page
        }
        async public void OnList(object sender, EventArgs e)                          //if lists button is pressed
        {
            Application.Current.MainPage = new NavigationPage(new groupProject01.ListsPage(_gd));         //if lists button is pressed
        }
        async public void OnSetting(object sender, EventArgs e)                       //if setting button is pressed
        {
            Application.Current.MainPage = new NavigationPage(new groupProject01.SettingsPage(_gd));          //if setting button is pressed
        }
        async public void OnMessaging(object sender, EventArgs e)                      //if messaging button is pressed
        {
           // Application.Current.MainPage = new NavigationPage(new groupProject01.MessagingPage(_gd)         //direct to messaging page
        }

        #endregion

        async void OnSend(object sender, EventArgs e)
        {
            string message = messageField.Text;
            messageField.Text = "";
            MessageObject m = new MessageObject();
            m.MSGText = message;
            await(ServerHandeler.sendMessage(m, _gd));
            await(_gd.MessagingDataInstance.getItemsInMessage(_gd));
            groups = _gd.MessagingDataInstance.messages;       //gets the messaging data from the data file
            msgView.ItemsSource = groups;                    //sets the messaging UI
            //;MessagingPage(_gd);
           Application.Current.MainPage = new NavigationPage(new groupProject01.MessagingPage(_gd));
        }
    }
}

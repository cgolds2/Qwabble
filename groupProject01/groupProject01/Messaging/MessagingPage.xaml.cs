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
        public ObservableCollection<MessagingViewModel> messages { get; set; } //creates an instance of messages
        private GlobalData _gd;                 //global variable GlobalData initialzed
        
        public MessagingPage (GlobalData gd)            //MessagingPage constructor
		{
			InitializeComponent ();                     //loads the UI elements
            _gd = gd;                                   //sets private instance of global data
            messages = _gd.messagingDataInstance.messages;   //gets the messaging data from the data file
            msgView.ItemsSource = messages;             //sets the messaging UI
		}

        /// <summary>
        /// Listener that fires when a message is tapped.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        async void OnTap(object sender, ItemTappedEventArgs e)
        {
            int index = ((MessagingViewModel)e.Item).ID;    //gets the ID of the messaging item (sender=row)
            await Navigation.PushAsync(new groupProject01.Messaging.MessagingItemPage()); //viewing the messaging item page even while other things occur
            //DisplayAlert("Item Tapped", ((ListsViewModel)e.Item).ID.ToString(), "Ok"); TESTING
        }







        /// <summary>
        /// This will bring up a menu which will allow the sender to put in info about guest they are bringing over and will push this info to all roommates.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void onGuestClicked(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
	}
}

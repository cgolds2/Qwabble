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
        public ObservableCollection<MessagingObject> messages { get; set; } //creates an instance of messages
        private GlobalData _gd;                             //global variable GlobalData initialzed
        
        public MessagingPage (GlobalData gd)                //MessagingPage constructor
		{
			InitializeComponent ();                          //loads the UI elements
            _gd = gd;                                        //sets private instance of global data
            messages = _gd.MessagingDataInstance.messages;   //gets the messaging data from the data file
            msgView.ItemsSource = messages;                  //sets the messaging UI
		}

        async void OnTap(object sender, ItemTappedEventArgs e)      //a listener that fires when a message is tapped
        {
            //int index = ((MessagingObject)e.Item).ID;    //gets the ID of the messaging item (sender=row)
            //await Navigation.PushAsync(new groupProject01.Messaging.MessagingItemPage(index,_gd)); //viewing the messaging item page even while other things occur
            DisplayAlert("Item Tapped", ((MessagingObject)e.Item).messageID.ToString(), "Ok"); //TESTING
        }
	}
}

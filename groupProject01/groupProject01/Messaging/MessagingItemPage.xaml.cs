using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace groupProject01.Messaging
{
	public partial class MessagingItemPage : ContentPage
	{

        public ObservableCollection<MessageObject> msgItems { get; set; }

        private GlobalData _gd;

		public MessagingItemPage (int ListID, GlobalData gd)
		{
			InitializeComponent ();
            _gd = gd;
            _gd.MessagingDataInstance.getItemsInMessage(ListID);
            msgItems = _gd.MessagingDataInstance.msgItems;
            msgView.ItemsSource = msgItems;
		}
        
	}
}

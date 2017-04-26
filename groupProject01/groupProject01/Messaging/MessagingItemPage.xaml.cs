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
        public List<MessageObject> messages { get; set; }
        private GlobalData _gd;

		public MessagingItemPage (int ListID, GlobalData gd)
		{
			//InitializeComponent ();
   //         _gd = gd;
   //         _gd.MessagingDataInstance.getItemsInMessage(_gd, ListID);
   //         messages = _gd.MessagingDataInstance.messages;
   //         msgView.ItemsSource = messages;
		}
        
	}
}

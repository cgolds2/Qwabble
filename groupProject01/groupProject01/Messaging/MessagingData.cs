using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

using Xamarin.Forms;

namespace groupProject01
{
	public class MessagingData
	{
        public ObservableCollection<MessagingViewModel> messages { get; set; } //creates an instance of messages
        public ObservableCollection<MessagingViewModel> msgItems { get; set; } //creates an instance of msgItems

		public MessagingData ()
		{
            refreshAll();
		}

        /// <summary>
        /// Refreshes all lists by creating a new instance and adding the necessary things.
        /// </summary>
        public void refreshAll()
        {
            messages = new ObservableCollection<MessagingViewModel>();

            messages.Add(new MessagingViewModel { Name = "General", ID = messages.Count });
            messages.Add(new MessagingViewModel { Name = "Guest Alert", ID = messages.Count });
        }

        /// <summary>
        /// Fills the Message with the necessary data.
        /// </summary>
        /// <param name="MessageID"></param>
        public void getItemsInMessage(int MessageID)
        {
            msgItems = new ObservableCollection<MessagingViewModel>();
            msgItems.Add(new MessagingViewModel { Name = "Message1", ID = msgItems.Count });
            msgItems.Add(new MessagingViewModel { Name = "Message2", ID = msgItems.Count });
            if (MessageID == 1)
            {
                msgItems.Add(new MessagingViewModel { Name = "Custom", ID = msgItems.Count });
            }
        }
    }
    public class MessageObject {
        private string _text = "";
        private int _senderID = 0;
        private int _recieverID = 0;
        private int _messageID = 0;

        public string Text
        {
            get
            {
                return _text;
            }

            set
            {
                _text = value;
            }
        }

        public int SenderID
        {
            get
            {
                return _senderID;
            }

            set
            {
                _senderID = value;
            }
        }

        public int RecieverID
        {
            get
            {
                return _recieverID;
            }

            set
            {
                _recieverID = value;
            }
        }

        public int MessageID
        {
            get
            {
                return _messageID;
            }

            set
            {
                _messageID = value;
            }
        }

        public MessageObject()
        {
            
        }

        public void sendToServer(GlobalData gdFile)
        {

        }

    }
    public class MessagingViewModel
    {
        public string Name { get; set; }
        public int ID { get; set; }
    }
}

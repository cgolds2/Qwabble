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
        public ObservableCollection<MessagingObject> messages { get; set; } //creates an instance of messages
        public ObservableCollection<MessagingObject> msgItems { get; set; } //creates an instance of msgItems

		public MessagingData ()
		{
            refreshAll();
		}

        /// <summary>
        /// Refreshes all lists by creating a new instance and adding the necessary things.
        /// </summary>
        public void refreshAll()
        {
            messages = new ObservableCollection<MessagingObject>();

            messages.Add(new MessagingObject { messageName = "General", messageID = messages.Count });
            messages.Add(new MessagingObject { messageName = "Guest Alert", messageID = messages.Count });
        }

        /// <summary>
        /// Fills the Message with the necessary data.
        /// </summary>
        /// <param name="MessageID"></param>
        public void getItemsInMessage(int MessageID)
        {
            msgItems = new ObservableCollection<MessagingObject>();
            msgItems.Add(new MessagingObject { messageName = "Message1", messageID = msgItems.Count });
            msgItems.Add(new MessagingObject { messageName = "Message2", messageID = msgItems.Count });
            if (MessageID == 1)
            {
                msgItems.Add(new MessagingObject { messageName = "Custom", messageID = msgItems.Count });
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
    public class MessagingObject
    {
        public string messageName { get; set; }
        public int messageID { get; set; }
        public string messageText { get; set; }
    }
}

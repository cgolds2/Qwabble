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

        public ObservableCollection<MessageObject> messages { get; set; } //creates an instance of messages
        public ObservableCollection<MessageObject> msgItems { get; set; } //creates an instance of msgItems


		public MessagingData ()
		{
            refreshAll();
		}

        /// <summary>
        /// Refreshes all lists by creating a new instance and adding the necessary things.
        /// </summary>
        public void refreshAll()
        {

            messages = new ObservableCollection<MessageObject>();

            //messages.Add(new MessageObject { MessageName = "General", ID = messages.Count });
            //messages.Add(new MessageObject { MessageName = "Guest Alert", ID = messages.Count });

        }

        /// <summary>
        /// Fills the Message with the necessary data.
        /// </summary>
        /// <param name="MessageID"></param>
        public void getItemsInMessage(int MessageID)
        {

            msgItems = new ObservableCollection<MessageObject>();
            msgItems.Add(new MessageObject { MessageName = "Message1", MessageID = msgItems.Count });
            msgItems.Add(new MessageObject { MessageName = "Message2", MessageID = msgItems.Count });
            if (MessageID == 1)
            {
                msgItems.Add(new MessageObject { MessageName = "Custom", MessageID = msgItems.Count });
            }
        }
    }
    public class MessageObject {
        private int iD = 0;
        private string _text = "";
        private int _senderID = 0;
        private int _recieverID = 0;
        private int _messageID = 0;
        private string _name = "";

        public string MessageText
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

        public string MessageName
        {
            get
            {
                return _name;
            }

            set
            {
                _name = value;
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
        public string Name { get; set; }
        public int ID { get; set; }
    }
}

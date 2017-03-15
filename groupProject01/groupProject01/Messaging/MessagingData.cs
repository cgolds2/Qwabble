using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

using Xamarin.Forms;

namespace groupProject01
{
	public class MessagingData
	{
		public MessagingData ()
		{
            refreshAll();
		}

        public void refreshAll()
        {
            throw new NotImplementedException();
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

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace groupProject01.Settings
{
	public partial class ServerTester : ContentPage
	{
		public ServerTester ()
		{
			InitializeComponent ();
		}

        async void onSendList(object sender, EventArgs e)
        {
            try
            {
                Other.GlobalData g = new GlobalDate();
                g.CurrentUser = new UserObject();
                g.CurrentUser.Username = "MyTestName";
                g.CurrentUser.UserID = 1;
                g.CurrentUser.ApartmentID = 1;
                g.CurrentUser.ListName = "List Name";
                g.CurrentUser.ListType = 0;
                g.CurrentUser.ListText = "THIS IS THE TEXT OF OUR LIST, NOT NOTE";

                ListItemObject l = new ListItemObject();
                l.listName = "MyTestNote";
                //l.listName = g.CurrentUser.ListName;
                l.listID = 1;
                l.On = 1;
                l.IsSwitchVisible = 1;
                l.listType = 1;
                l.listText = "THIS IS THE TEXT OF OUR LIST";

                Output.Text = ServerHandeler.sendList(l, g);
            }catch(Exception e)
            {
                Output.Text = e.Message;
            }
        }

        async void onGetList(object sender, EventArgs e)
        {
            try
            {
                Other.GlobalData g = new GlobalDate();
                g.CurrentUser = new UserObject();
                g.CurrentUser.ApartmentID = 1;
             

                List<ListItemObject> l = ServerHandeler.getList(g);
                string outputString = "";
                foreach (ListItemObject li in l)
                {
                    outputString += li.ListText;
                }

                Output.Text = outputString;
            }
            catch (Exception e)
            {
                Output.Text = e.Message;
            }
        }

        async void onSendEvent(object sender, EventArgs e)
        {
            try
            {
                Other.GlobalData g = new GlobalDate();
                g.CurrentUser = new UserObject();
                g.CurrentUser.Username = "MyTestName";
                g.CurrentUser.UserID = 1;
                g.CurrentUser.ApartmentID = 1;

                EventObject e = new EventObject();
                //e

                Output.Text = ServerHandeler.sendList(l, g);
            }
            catch (Exception e)
            {
                Output.Text = e.Message;
            }
        }

        async void onGetEvent(object sender, EventArgs e)
        {
            try
            {
                Other.GlobalData g = new GlobalDate();
                g.CurrentUser = new UserObject();
                g.CurrentUser.ApartmentID = 1;


                List<EventObject> e = ServerHandeler.getList(g);
                string outputString = "";
                foreach (ListItemObject ev in e)
                {
                    outputString += ev.EventText;
                }

                Output.Text = outputString;
            }
            catch (Exception e)
            {
                Output.Text = e.Message;
            }
        }

        async void onSendMessage(object sender, EventArgs e)
        {
            try
            {
                Other.GlobalData g = new GlobalDate();
                g.CurrentUser = new UserObject();
                g.CurrentUser.Username = "MyTestName";
                g.CurrentUser.UserID = 1;
                g.CurrentUser.ApartmentID = 1;

                MessagingObject m = new MessagingObject();
                m.messageName = "MessageName";
                m.messageID = 1;
                m.messageText = "THIS IS THE TEXT OF OUR MESSAGE";

                Output.Text = ServerHandeler.sendList(l, g);
            }
            catch (Exception e)
            {
                Output.Text = e.Message;
            }
        }

    }
}

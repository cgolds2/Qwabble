using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using groupProject01;
using groupProject01.Settings;
using Xamarin.Forms;
using groupProject01.Other;

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

                GlobalData g = new GlobalData();
                g.CurrentUser = new Other.UserObject();
                g.CurrentUser.Username = "MyTestName";
                g.CurrentUser.UserID = 1;
                g.CurrentUser.ApartmentID = 1;


                ListItemObject l = new ListItemObject();
                l.listName = "MyTestNote";
                l.listName = "List Name";
                l.listText = "THIS IS THE TEXT OF OUR LIST, NOT NOTE";
                //l.listName = g.CurrentUser.ListName;
                l.ListID = 1;
                l.listType = 1;
                string test = await (ServerHandeler.sendList(l, g));
                Output.Text = test;
            }catch(Exception ex)
            {
                Output.Text = ex.Message;
            }
        }

        async void onGetList(object sender, EventArgs e)
        {
            try
            {
                GlobalData g = new GlobalData();
                g.CurrentUser = new UserObject();
                g.CurrentUser.ApartmentID = 1;
             

                List<ListItemObject> l = await(ServerHandeler.getList(g));
                string outputString = "";
                foreach (ListItemObject li in l)
                {
                    outputString += li.listText;
                }
            
                Output.Text = outputString;
            }
            catch (Exception ex)
            {
                Output.Text = ex.Message;
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
                e.eventID = 1;
                e.senderID = 1;
                e.eventName = "PARTTYYYYY";
                //startDate and endDate not done
                e.AdditionalInfo = "its at lsu";

                Output.Text = ServerHandeler.sendEvent(e, g);
            }
            catch (Exception e)
            {
                Output.Text = e.Message;
            }
        }

        //THIS IS listed as get calendar in serverhandler.cs
        async void onGetEvent(object sender, EventArgs e)
        {
            try
            {
                Other.GlobalData g = new GlobalDate();
                g.CurrentUser = new UserObject();
                g.CurrentUser.ApartmentID = 1;


                List<EventObject> e = await(ServerHandeler.getCalendar(g));
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

        //TODO Connor go over this with Sarah, have questions about messages
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

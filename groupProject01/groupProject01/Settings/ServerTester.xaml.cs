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
			            NavigationPage.SetHasNavigationBar(this, false); InitializeComponent();
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
             

                List<ListItemObject> l = await(ServerHandeler.getList(g,1));
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
                GlobalData g = new GlobalData();
                g.CurrentUser = new UserObject();
                g.CurrentUser.Username = "MyTestName";
                g.CurrentUser.UserID = 1;
                g.CurrentUser.ApartmentID = 1;

                EventObject eve = new EventObject();
                eve.eventID = 1;
                eve.senderID = 1;
                eve.eventName = "PARTTYYYYY";
                //startDate and endDate not done
                eve.AdditionalInfo = "its at lsu";

                string text = await(ServerHandeler.sendEvent(eve, g));
                Output.Text = text;
            }
            catch (Exception except)
            {
                Output.Text = except.Message;
            }
        }

        //THIS IS listed as get calendar in serverhandler.cs
        async void onGetEvent(object sender, EventArgs e)
        {
            //NOT IMPLEMENTED SERVER SIDE
            try
            {
                GlobalData g = new GlobalData();
                g.CurrentUser = new UserObject();
                g.CurrentUser.ApartmentID = 1;


                List<EventObject> eve = await(ServerHandeler.getCalendar(g));
                string outputString = "";
                foreach (EventObject ev in eve)
                {
                    outputString += ev.eventName;
                }

                Output.Text = outputString;
            }
            catch (Exception except)
            {
                Output.Text = except.Message;
            }
        }

        async void onSendMessage(object sender, EventArgs e)
        {
            try
            {
                GlobalData g = new GlobalData();
                g.CurrentUser = new UserObject();
                g.CurrentUser.Username = "MyTestName";
                g.CurrentUser.UserID = 1;
                g.CurrentUser.ApartmentID = 1;

                MessageObject m = new MessageObject();
                m.MessageName = "MessageName";
                m.SenderID = 1;
                m.RecieverID = 2;
                m.MessageID = 3;
                m.MessageText = "THIS IS THE TEXT OF OUR MESSAGE";

                string text = await(ServerHandeler.sendMessage(m, g));
                Output.Text = text;
            }
            catch (Exception except)
            {
                Output.Text = except.Message;
            }
        }

        async void onGetMessage(object sender, EventArgs e)
        {
            try
            {
                GlobalData g = new GlobalData();
                g.CurrentUser = new UserObject();
                g.CurrentUser.ApartmentID = 1;


                List<MessageObject> msg = await (ServerHandeler.getMessages(g));
                string outputString = "";
                foreach (MessageObject m in msg)
                {
                    outputString += m.MessageName;
                }

                Output.Text = outputString;
            }
            catch (Exception except)
            {
                Output.Text = except.Message;
            }
        }

        async void onCreateUser(object sender, EventArgs e)
        {
            try
            {
                GlobalData g = new GlobalData();
                g.CurrentUser = new UserObject();
                g.CurrentUser.Username = "MyTestName";
                g.CurrentUser.UserID = 1;
                g.CurrentUser.ApartmentID = 1;
                string p = "password...hehehe";
                
                string text = await (ServerHandeler.createUser(g.CurrentUser, p));
                Output.Text = text;
            }
            catch (Exception except)
            {
                Output.Text = except.Message;
            }
        }
        
        async void onGetUser(object sender, EventArgs e)
        {
            try
            {
                GlobalData g = new GlobalData();
                g.CurrentUser = new UserObject();
                g.CurrentUser.Username = "pandassuck";
                g.CurrentUser.UserID = 1;
                g.CurrentUser.ApartmentID = 1;


                UserObject u = await (ServerHandeler.getUserInfo(g.CurrentUser.UserID));

                string outputString = "";

                outputString += u.Username;
                Output.Text = outputString;
            }
            catch (Exception except)
            {
                Output.Text = except.Message;
            }
        }

        async void onAddToApartment(object sender, EventArgs e)
        {
            try
            {
                GlobalData g = new GlobalData();
                g.CurrentUser = new UserObject();
                g.CurrentUser.Username = "MyTestName";
                g.CurrentUser.UserID = 1;
                g.CurrentUser.ApartmentID = 1;

                int text = await (ServerHandeler.addUserToApartment(g.CurrentUser.UserID, g.CurrentUser.ApartmentID));

                Output.Text = text.ToString();
            }
            catch (Exception except)
            {
                Output.Text = except.Message;
            }
        }

        async void onGetApartments(object sender, EventArgs e)
        {
            try
            {
                GlobalData g = new GlobalData();
                g.CurrentUser = new UserObject();
                g.CurrentUser.Username = "pandassuck";
                g.CurrentUser.UserID = 1;
                g.CurrentUser.ApartmentID = 1;
                g.CurrentApartment = new ApartmentObject();
                g.CurrentApartment.id = 1;
                g.CurrentApartment.address = "142 SmileyFace Lane";
                g.CurrentApartment.owner = 1;


                List<ApartmentObject> ap = await (ServerHandeler.getApartments(g.CurrentUser.UserID, g.CurrentUser.ApartmentID));

                string outputString = "";
                foreach (ApartmentObject apt in ap)
                {
                    outputString += apt.id;
                }
                Output.Text = outputString;
            }
            catch (Exception except)
            {
                Output.Text = except.Message;
            }
        }

        //not sure if tested correctly
        async void onGetAllUsers(object sender, EventArgs e)
        {
            try
            {
                GlobalData g = new GlobalData();
                g.CurrentUser = new UserObject();
                g.CurrentUser.Username = "pandassuck";
                g.CurrentUser.UserID = 1;
                g.CurrentUser.ApartmentID = 1;
                g.CurrentApartment = new ApartmentObject();
                g.CurrentApartment.id = 1;
                g.CurrentApartment.address = "142 SmileyFace Lane";
                g.CurrentApartment.owner = 1;


                List<UserObject> u = await (ServerHandeler.getAllUsers(g.CurrentApartment.id));
                string text="";
                foreach (UserObject use in u)
                {
                    text = use.Username;
                }
                Output.Text = text;
            }
            catch (Exception except)
            {
                Output.Text = except.Message;
            }
        }

        async void onCreateApartment(object sender, EventArgs e)
        {
            try
            {
                GlobalData g = new GlobalData();
                g.CurrentApartment = new ApartmentObject();
                g.CurrentApartment.id = 1;
                g.CurrentApartment.address = "142 SmileyFace Lane";
                g.CurrentApartment.owner = 1;


                string text = await (ServerHandeler.createApartment(g.CurrentApartment, g));

                Output.Text = text;
            }
            catch (Exception except)
            {
                Output.Text = except.Message;
            }
        }
    }
}

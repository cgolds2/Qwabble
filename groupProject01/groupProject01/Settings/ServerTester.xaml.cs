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

        async Task onSendList(object sender, EventArgs e)
        {
            try
            {

                GlobalData g = new GlobalData();
                g.CurrentUser = new Other.UserObject();
                g.CurrentUser.username = "MyTestName";
                g.CurrentUser.UserID = 1;
                g.CurrentUser.ApartmentID = 1;


                ListItemObject l = new ListItemObject();
                l.noteName = "MyTestNote";
                l.noteName = "List Name";
                l.data = "THIS IS THE TEXT OF OUR LIST, NOT NOTE";
                //l.noteName = g.CurrentUser.noteName;
                l.ListID = 1;
                l.listType = 1;
                string test = await (ServerHandeler.sendList(l, g));
                Output.Text = test;
            }catch(Exception ex)
            {
                Output.Text = ex.Message;
            }
        }

        async Task onGetList(object sender, EventArgs e)
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
                    outputString += li.data;
                }
            
                Output.Text = outputString;
            }
            catch (Exception ex)
            {
                Output.Text = ex.Message;
            }
        }

        async Task onSendEvent(object sender, EventArgs e)
        {

            try
            {
                GlobalData g = new GlobalData();
                g.CurrentUser = new UserObject();
                g.CurrentUser.username = "MyTestName";
                g.CurrentUser.UserID = 1;
                g.CurrentUser.ApartmentID = 1;

                EventObject eve = new EventObject();
                eve.eventID = 1;
                eve.userid = 1;
                eve.name = "PARTTYYYYY";
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
        async Task onGetEvent(object sender, EventArgs e)
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
                    outputString += ev.name;
                }

                Output.Text = outputString;
            }
            catch (Exception except)
            {
                Output.Text = except.Message;
            }
        }

        async Task onSendMessage(object sender, EventArgs e)
        {
            try
            {
                GlobalData g = new GlobalData();
                g.CurrentUser = new UserObject();
                g.CurrentUser.username = "MyTestName";
                g.CurrentUser.UserID = 2;
                g.CurrentUser.ApartmentID = 3;

                MessageObject m = new MessageObject();
                m.MessageName = "MessageName";
                m.SenderID = 1;
                m.RecieverID = 2;
                m.apartmentID = 3;
                m.MSGText = "THIS IS THE TEXT OF OUR MESSAGE";

                string text = await(ServerHandeler.sendMessage(m, g));
                Output.Text = text;
            }
            catch (Exception except)
            {
                Output.Text = except.Message;
            }
        }

        async Task onGetMessage(object sender, EventArgs e)
        {
            try
            {
                GlobalData g = new GlobalData();
                g.CurrentUser = new UserObject();
                g.CurrentUser.ApartmentID = 3;


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

        async Task onCreateUser(object sender, EventArgs e)
        {
            try
            {
                GlobalData g = new GlobalData();
                g.CurrentUser = new UserObject();
                g.CurrentUser.username = "MyTestName";
                g.CurrentUser.UserID = 1;
                g.CurrentUser.ApartmentID = 1;
                g.CurrentUser.email = "mymail@hotmail.gov";
                string p = "password...hehehe";
                
                int text = await (ServerHandeler.createUser(g.CurrentUser, p));
                Output.Text = text.ToString() ;
            }
            catch (Exception except)
            {
                Output.Text = except.Message;
            }
        }
        
        async Task onGetUser(object sender, EventArgs e)
        {
            try
            {
                GlobalData g = new GlobalData();
                g.CurrentUser = new UserObject();
                g.CurrentUser.username = "pandassuck";
                g.CurrentUser.UserID = 1;
                g.CurrentUser.ApartmentID = 1;


                UserObject u = await (ServerHandeler.getUserInfo(g.CurrentUser.UserID));

                string outputString = "";

                outputString += u.username;
                Output.Text = outputString;
            }
            catch (Exception except)
            {
                Output.Text = except.Message;
            }
        }

        async Task onAddToApartment(object sender, EventArgs e)
        {
            try
            {
                GlobalData g = new GlobalData();
                g.CurrentUser = new UserObject();
                g.CurrentUser.username = "MyTestName";
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

        async Task onGetApartments(object sender, EventArgs e)
        {
            try
            {

                List<ApartmentObject> ap = await (ServerHandeler.getApartments());

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
        async Task onGetAllUsers(object sender, EventArgs e)
        {
            try
            {
                GlobalData g = new GlobalData();
                g.CurrentUser = new UserObject();
                g.CurrentUser.username = "pandassuck";
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
                    text = use.username;
                }
                Output.Text = text;
            }
            catch (Exception except)
            {
                Output.Text = except.Message;
            }
        }

        async Task onCreateApartment(object sender, EventArgs e)
        {
            try
            {
                GlobalData g = new GlobalData();
                g.CurrentApartment = new ApartmentObject();
                g.CurrentApartment.address = "142 SmileyFace Lane";
                g.CurrentApartment.AptName = "AHHHHHHHHHHHHGHFHAWREHYGHUYAGHUYEWRHJG";
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

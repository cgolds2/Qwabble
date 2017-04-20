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

        }
    }
}

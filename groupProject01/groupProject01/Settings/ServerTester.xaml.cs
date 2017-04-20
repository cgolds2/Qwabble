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
            ListItemObject l = new ListItemObject();
            l.noteName = "MyTestNote";
            WHATEVERTEXTBOX.text = ServerHandeler.sendList(l, g);
            }catch(Exception e)
            {
                WHATEVERTEXTBOX.text = e.Message;

            }

        }
    }
}

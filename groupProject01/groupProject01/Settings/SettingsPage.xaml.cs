using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace groupProject01
{
	public partial class SettingsPage : ContentPage
	{
		public SettingsPage ()
		{
			            NavigationPage.SetHasNavigationBar(this, false); InitializeComponent();
		}
        #region BottomBarStuff

        public void OnHome(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
        public void OnList(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
        public void OnCalendar(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
        public void OnMessaging(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
        public void OnSetting(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion
        public void onPushNotificationClicked(object Sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        public void onThemeClicked(object Sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
        public void onLogOutClicked(object Sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
        public void onChangeAptClicked(object Sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// Redirects to current apartment selection.
        /// </summary>
        /// <param name="Sender"></param>
        /// <param name="e"></param>
        public void onCurrentAptClicked(object Sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}

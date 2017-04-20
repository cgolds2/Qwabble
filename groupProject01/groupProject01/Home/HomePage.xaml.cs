using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace groupProject01
{
	public partial class HomePage : ContentPage
	{
		private GlobalData _gd;                                             //instantiates global variable GlobalData to store the global data

		public HomePage(GlobalData gd)
		{

			InitializeComponent();
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
        public void onRoomateClicked(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}

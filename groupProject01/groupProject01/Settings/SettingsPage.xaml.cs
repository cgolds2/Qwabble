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

        void OnLogout(object sender, EventArgs e)
        {
            //TODO logout user
        }

        void OnCurApartment(object sender, EventArgs e)
        {
            //TODO show current apartment
        }
    }
}

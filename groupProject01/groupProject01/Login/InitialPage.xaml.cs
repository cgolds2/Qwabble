using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace groupProject01
{
	public partial class InitialPage : ContentPage
	{
        GlobalData _gd;

        public InitialPage (GlobalData gd)
		{
            _gd = gd;
			InitializeComponent ();
		}

        async void OnLogin(object sender, EventArgs e)
        {

            await Navigation.PushAsync(new groupProject01.LoginPage(_gd));

        }
        async void OnCreateUser(object sender, EventArgs e)
        {

            await Navigation.PushAsync(new groupProject01.CreationPage(_gd));

        }
    }
}

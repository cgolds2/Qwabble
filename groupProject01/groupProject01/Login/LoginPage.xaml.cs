using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace groupProject01
{
	public partial class LoginPage : ContentPage
	{
        GlobalData _gd;

		public LoginPage (GlobalData gd)
		{
			            NavigationPage.SetHasNavigationBar(this, false); InitializeComponent();
            _gd = gd;
		}

        async void OnSubmit(object sender, EventArgs e)
        {

            //await Navigation.PushAsync(new groupProject01.HomePage(_gd));


        }
    }
}

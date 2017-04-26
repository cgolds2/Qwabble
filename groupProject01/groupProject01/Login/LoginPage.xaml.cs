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
			NavigationPage.SetHasNavigationBar(this, false);
            InitializeComponent();
            _gd = gd;
		}

        async void OnSubmit(object sender, EventArgs e)
        {
            //TODO something to check username and password
            string x = await(ServerHandeler.sendList(usernameTextField.Text, passwordTextField.Text));
            x.Replace("\n", "");
            try
            {
                int ID = Int32.Parse(x);
                _gd.CurrentUser.ApartmentID = ID;
                await Navigation.PushAsync(new groupProject01.MainPage(_gd), false);
            }
            catch (Exception)
            {

                throw;
            }
            //await Navigation.PushAsync(new groupProject01.HomePage(_gd),false);


        }
    }
}

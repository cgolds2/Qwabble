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
            string username = _gd.SettingsDataInstance.getCredentials(keysInt.userName);
            string password = _gd.SettingsDataInstance.getCredentials(keysInt.password);
            if(!( username==null || password==null))
            {
                if (!(username.Equals("") || password.Equals("")))
                {
                    usernameTextField.Text = username;
                    passwordTextField.Text = password;
                    submit();
                }
            }
        }

        async void OnSubmit(object sender, EventArgs e)
        {
            submit();

        }
        async private void submit()
        {
            //TODO something to check username and password
            string x = await(ServerHandeler.login(usernameTextField.Text, passwordTextField.Text));
            x.Replace("\n", "");
            try
            {
                int ID = Int32.Parse(x);
                _gd.CurrentUser.ApartmentID = ID;
                _gd.SettingsDataInstance.setCredentials(keysInt.userName, usernameTextField.Text);
                _gd.SettingsDataInstance.setCredentials(keysInt.password, passwordTextField.Text);
                await Navigation.PushAsync(new groupProject01.HomePage(_gd), false);
            }
            catch (Exception)
            {


            }
        }
    }
}

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
            if(!( username==null || password==null ||username.Equals("")  || password.Equals("")))
            {
                
                    usernameTextField.Text = username;
                    passwordTextField.Text = password;
                    submit();
                
            }
        }

        async void OnSubmit(object sender, EventArgs e)
        {
           await(submit());

        }
 
        async void OnBack(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
        async private Task submit()
        {
            string x = await(ServerHandeler.login(usernameTextField.Text, passwordTextField.Text));
            x.Replace("\n", "");
            try
            {
                int ID = Int32.Parse(x);
                if(ID == -1)
                {
                    await DisplayAlert("Login Failed", "Email or Password Incorrect", "OK");   //shows error message
                    return;
                }
               
                _gd.SettingsDataInstance.setCredentials(keysInt.userName, usernameTextField.Text);
                _gd.SettingsDataInstance.setCredentials(keysInt.password, passwordTextField.Text);
               // gd.SettingsDataInstance.setCredentials("UserID", ID);
                await(_gd.refreshUser(ID));
                Application.Current.MainPage = new NavigationPage(new groupProject01.HomePage(_gd));
                
               // await Navigation.PushAsync(new groupProject01.HomePage(_gd));
            
               //new NavigationPage(new groupProject01.HomePage(_gd));
            }
            catch (Exception)
            {
                await DisplayAlert("Login Failed", "Email or Password Incorrect", "OK");   //shows error message


            }
        }
    }
}

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
            InitializeComponent();      //draws the UI components of the page
            _gd = gd;                   //sets local instance of global data
		}

        async void OnSubmit(object sender, EventArgs e)     //when the submit button is clicked
        {
            //TODO something to check username and password
            //if valid
            await Navigation.PushAsync(new groupProject01.HomePage(_gd),false);     //sends the user to home page
            //if not valid
            //DisplayAlert("Wrong Username/Password", "Your username or password is incorrect. Reenter.", "Ok");
        }
    }
}

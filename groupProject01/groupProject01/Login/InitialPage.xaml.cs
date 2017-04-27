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
        GlobalData _gd;                     //declares local instance of global data

        public InitialPage (GlobalData gd)  //constructor for initial page
        {
            NavigationPage.SetHasNavigationBar(this, false);    //hides the default navigation bar
            _gd = gd;                       //sets local instance of global data
			InitializeComponent ();         //initializes ui elements of the page
		}

        async void OnLogin(object sender, EventArgs e)      //when the login button is pressed
        {
            await Navigation.PushAsync(new groupProject01.LoginPage(_gd),false);    //push to the login page

        }
        async void OnCreateUser(object sender, EventArgs e)     //when the create user button is pressed
        {

            await Navigation.PushAsync(new groupProject01.CreationPage(_gd), false);     //push to the create user page

        }
    }
}

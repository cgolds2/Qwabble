using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using groupProject01;
using groupProject01.Other;
using Xamarin.Forms;

namespace groupProject01
{
	public partial class CreationPage : ContentPage
	{
        GlobalData _gd;
		public CreationPage (GlobalData gd)
		{
            _gd = gd;
			InitializeComponent ();
		}

        async void OnNewApartment(object sender, EventArgs e)
        {
            createUser();
            //TODO generate apartment id
            //TODO make sure finding apartment id is findable in settings
            await Navigation.PushAsync(new groupProject01.MainPage(_gd));

        }

        async void OnPrevApartment(object sender, EventArgs e)
        {
            createUser();
            await Navigation.PushAsync(new groupProject01.PrevApartmentPage(_gd));
        }

        async public void createUser()
        {
            _gd.CurrentUser = new UserObject();
            _gd.CurrentUser.Username = usernameTextField.Text;
            _gd.CurrentUser.email = emailTextField.Text;
            await(ServerHandeler.createUser(_gd.CurrentUser, passwordTextField.Text));
        }
    }
}

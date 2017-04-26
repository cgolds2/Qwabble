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
            createApartment();
            await Navigation.PushAsync(new groupProject01.MainPage(_gd),false);

        }

        async void OnPrevApartment(object sender, EventArgs e)
        {
            createUser();
            await Navigation.PushAsync(new groupProject01.PrevApartmentPage(_gd),false);
        }

        async void createUser()
        {
            _gd.CurrentUser = new UserObject();
            _gd.CurrentUser.Username = usernameTextField.Text;
            _gd.CurrentUser.email = emailTextField.Text;
            int id = int.Parse(await(ServerHandeler.createUser(_gd.CurrentUser, passwordTextField.Text)));
            _gd.CurrentUser.UserID = id;
        }

        async void createApartment()
        {
            _gd.CurrentApartment = new ApartmentObject();
            int apmtid = int.Parse(await (ServerHandeler.createApartment(_gd.CurrentApartment, _gd)));
            _gd.CurrentApartment.id = apmtid;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

            //TODO generate apartment id
            //TODO make sure finding apartment id is findable in settings
            await Navigation.PushAsync(new groupProject01.MainPage(_gd));

        }

        async void OnPrevApartment(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new groupProject01.PrevApartmentPage(_gd));


        }
    }
}

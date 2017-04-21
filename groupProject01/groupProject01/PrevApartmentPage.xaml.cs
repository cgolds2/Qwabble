using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace groupProject01
{
	public partial class PrevApartmentPage : ContentPage
	{
        GlobalData _gd;
		public PrevApartmentPage (GlobalData gd)
		{
            _gd = gd;
			InitializeComponent ();
		}

        async void OnSubmit(object sender, EventArgs e)
        {
            //check for apartment
            await Navigation.PushAsync(new groupProject01.MainPage(_gd));
            //await Navigation.PushAsync(new groupProject01.HomePage(_gd));


        }
    }
}

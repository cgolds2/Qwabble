using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using groupProject01;
using groupProject01.Other;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace groupProject01
{
	public partial class CreateNewApartmentPage : ContentPage
	{
        GlobalData _gd;   //instantiates global variable GlobalDatat to store the global data

		public CreateNewApartmentPage (GlobalData gd)       //constructor for CreateNewApartmentPage
		{
            _gd = gd;   //sets the private instance of global variable
            NavigationPage.SetHasNavigationBar(this, false); //hides the default navigation bar
            InitializeComponent();                                     //initialize the UI
        }

        async void OnSubmit(object sender, EventArgs e)                 //when submit button is pressed
        {
            await createApartment();
            Application.Current.MainPage = new groupProject01.HomePage(_gd);       //direct to home page
        }

        async void OnBack(object sender, EventArgs e)               //when the back button is pushed
        {
            await Navigation.PopAsync();
        }

        async Task createApartment()        //creates a new apartment
        {
            _gd.CurrentApartment = new ApartmentObject();       //sets global data current apartment to a new apartment object
            _gd.CurrentApartment.address = addressTextField.Text;       //sets the address
            _gd.CurrentApartment.AptName = aptNameTextField.Text;       //sets the name
            int apmtid = int.Parse(await (ServerHandeler.createApartment(_gd.CurrentApartment, _gd)));  //cretes a new apartment in the database and recieves the apartment id back
            _gd.CurrentApartment.id = apmtid;       //sets the apartment id
        }
    }
}

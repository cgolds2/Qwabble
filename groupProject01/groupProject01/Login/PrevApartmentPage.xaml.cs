using System;
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
	public partial class PrevApartmentPage : ContentPage
	{
        GlobalData _gd;                                                 //instantiates global variable GlobalData to store the global data

        public PrevApartmentPage (GlobalData gd)                        //constructor for PrevApartment page
		{
            _gd = gd;                                                   //sets the private instance of global variable
			InitializeComponent ();                                     //initialize the UI
		}

        async void OnSubmit(object sender, EventArgs e)                 //when submit button is pressed
        {
            int apartmentID = int.Parse(apartment.Text);
            List<ApartmentObject> aptLs = await(ServerHandeler.getApartments(_gd.CurrentUser.UserID, apartmentID)); //gets the apartment with the associated userid
            ApartmentObject aptObj = findApartment(aptLs, apartmentID);
            if(aptObj != null)                                                      //if apartmentid is not null
            {
                ServerHandeler.addUserToApartment(_gd.CurrentUser.UserID, apartmentID);
                await Navigation.PushAsync(new groupProject01.HomePage(_gd));       //direct to home page
            }
            else                                                                    //if apartmentid is null
            {
                await DisplayAlert("Invalid Apartment ID", "The apartment ID you input is not valid. Please try again.", "OK");   //shows error message
            }
        }

        public ApartmentObject findApartment(List<ApartmentObject> apt, int apartmentID)
        {
            foreach(ApartmentObject ap in apt)
            {
                if(ap.id == apartmentID)
                {
                    return ap;
                }
            }
            return null;
        }
    }
}

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
            NavigationPage.SetHasNavigationBar(this, false);    //hides the default navigation bar
            _gd = gd;                                                   //sets the private instance of global variable
			InitializeComponent ();                                     //initialize the UI
		}

        async void OnSubmit(object sender, EventArgs e)                 //when submit button is pressed
        {
            int apartmentID = int.Parse(apartment.Text);
            List<ApartmentObject> aptLs = await(ServerHandeler.getApartments()); //gets the apartment with the associated userid
            ApartmentObject aptObj = findApartment(aptLs, apartmentID);
            if(aptObj != null)                                                      //if apartmentid is not null
            {
                await ServerHandeler.addUserToApartment(_gd.CurrentUser.UserID, apartmentID);
                _gd.CurrentApartment = aptObj;
                Application.Current.MainPage = new NavigationPage(new groupProject01.HomePage(_gd));       //direct to home page
            }
            else                              //if apartmentid is null
            {
                await DisplayAlert("Invalid Apartment ID", "The apartment ID you input is not valid. Please try again.", "OK");   //shows error message
            }
        }

        async void OnBack(object sender, EventArgs e)               //when the back button is pushed
        {
            await Navigation.PopAsync();
        }

        public static ApartmentObject findApartment(List<ApartmentObject> apt, int apartmentID)        //finds the apartment specified
        {
            foreach(ApartmentObject ap in apt)  //searches every apartment that was returned
            {
                if(ap.id == apartmentID) //checks to see if given id matches the apartmentid of the current 
                {
                    return ap;          //returns the current apartment if true
                }
            }
            return null;                //if no apartment is found returns null
        }
    }
}

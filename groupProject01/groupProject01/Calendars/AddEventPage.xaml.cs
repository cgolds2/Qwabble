using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace groupProject01
{
	public partial class AddEventPage : ContentPage
	{
        GlobalData _gd;
		public AddEventPage (GlobalData gd)
		{
            NavigationPage.SetHasNavigationBar(this, false);                                        //hides the default naviagion bar

            _gd = gd;
            InitializeComponent();
		}

        async void OnAddEvent(object sender, EventArgs e)
        {
            EventObject eve = new EventObject();
            //eve.name = eventNameTextField.Text;
            ////set eventid
            ////how to do dates
            ////go over properties in event
       
            eve.name = eventNameTextField.Text;
            try
            {
                eve.startDate = DateTime.ParseExact(startDate.Text, "yyyy-MM-dd HH:mm:ss,fff",
                                       System.Globalization.CultureInfo.InvariantCulture);
                                       
                eve.endDate =  DateTime.ParseExact(endDate.Text, "yyyy-MM-dd HH:mm:ss,fff",
                                       System.Globalization.CultureInfo.InvariantCulture);
                
            }
            catch (Exception)
            {

                throw;
            }
           


            ServerHandeler.sendEvent(eve, _gd);
            Application.Current.MainPage = new NavigationPage(new groupProject01.CalendarPage(_gd));             //direct to home page

            //await Navigation.PushAsync(new groupProject01.CalendarPage(_gd));
        }
        async void OnBack(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
            // await Navigation.PushAsync(new groupProject01.ListsPage(_gd));
        }
    }
}

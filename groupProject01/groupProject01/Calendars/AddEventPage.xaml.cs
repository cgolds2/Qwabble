using System;
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
            _gd = gd;
			InitializeComponent ();
		}

        async void OnAddEvent(object sender, EventArgs e)
        {
            EventObject eve = new EventObject();
            eve.name = eventNameTextField.Text;
            //set eventid
            //how to do dates
            //go over properties in event
            eve.AdditionalInfo = eventDetailTextField.Text;
            
            ServerHandeler.sendEvent(eve, _gd);
            await Navigation.PushAsync(new groupProject01.CalendarPage(_gd));
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace groupProject01
{
	public partial class EventDetailPage : ContentPage
	{
		public EventDetailPage (EventObject currentEvent, GlobalData gd)
		{
            NavigationPage.SetHasNavigationBar(this, false);
			InitializeComponent ();

            lblLabel.Text = currentEvent.name;
		}
	}
}

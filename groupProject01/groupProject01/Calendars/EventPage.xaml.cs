using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace groupProject01
{
	public partial class EventPage : ContentPage
	{
        public List<EventObject> events { get; set; } //declares events ObservableCollection that will notify when events are added, removed, and refreshed
        private GlobalData _gd;                                             //instantiates global variable GlobalData to store the global data

        public EventPage(int ListID, GlobalData gd)                                 //EventsPage constructor
        {
            InitializeComponent();                                      //initializes UI objects with values provided, initializes elements
            _gd = gd;                                                   //sets private instance of global data
            _gd.CalendarDataInstance.getEventsInCalendar(_gd, ListID);       //fills the page with all the events in the specified calendar
            events = _gd.CalendarDataInstance.events;                      //gets the lists data from data file
            calView.ItemsSource = events;                               //sets the source of items to template and display
            NavigationPage.SetHasNavigationBar(this, false);            //hides the default navigation bar
        }


        async void OnTap(object sender, ItemTappedEventArgs e)          //when an event is tapped
        {
            int index = ((CalendarOptionObject)e.Item).ID;              //finds the index of the vent
            var eve = events[index];                                    //gets the specific event
            await Navigation.PushAsync(new groupProject01.EventDetailPage(eve, _gd), false);    //sends to that event's detail page
        }

        

        async void OnAddEvent(object sender, EventArgs e)               //when add event is pressed
        {
            await Navigation.PushAsync(new groupProject01.AddEventPage(_gd));       //sends to the add event page
        }
        async void OnBack(object sender, EventArgs e)                   //when the back button is pressed
        {
            await Navigation.PopAsync();
        }

    }
}

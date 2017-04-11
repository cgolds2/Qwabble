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
        public ObservableCollection<CalendarViewModel> events { get; set; } //declares events ObservableCollection that will notify when events are added, removed, and refreshed
        private GlobalData _gd;                                             //instantiates global variable GlobalData to store the global data

        public EventPage(int ListID, GlobalData gd)                                 //EventsPage constructor
        {
            InitializeComponent();                                      //initializes UI objects with values provided, initializes elements
            _gd = gd;                                                   //sets private instance of global data
            _gd.CalendarDataInstance.getEventsInCalendar(ListID);       //fills the page with all the events in the specified calendar
            events = _gd.ListsDataInstance.events;                      //gets the lists data from data file
            calView.ItemsSource = events;                               //sets the source of items to template and display
        }


        //ontap for events? shouldn't we just allow edit?
        async void OnTap(object sender, ItemTappedEventArgs e)
        {
            int index = ((CalendarViewModel)e.Item).ID;
            //do something
        }
    }
}

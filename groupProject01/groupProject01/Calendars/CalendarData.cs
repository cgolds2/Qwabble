using System;
using System.Collections.Generic;
using System.Text;

namespace groupProject01
{
    public class CalendarData
    {
        public ObservableCollection<CalendarViewModel> calendar { get; set; } //declares calendars ObservableCollection that will notify when calendars are added, removed, and refreshed
        public ObservableCollection<CalendarViewModel> events { get; set; }   //declares events ObservableCollection that will notify when events are added, removed, and refreshed

        public CalendarData()                                                 //constructor for the Calendar Data page
        {
            refreshAll();                                                     //refreshes all data on the page
        }

        public void refreshAll()                                             //refreshes all data on the page
        {
            calendar = new ObservableCollection<CalendarViewMode>();         //instantiates calendars ObservableCollection that will notify when calendars are added, removed, and refreshed

            //HARD-CODED, WILL CHANGE
            calendar.Add(new CalendarViewModel { Name = "View Calendar", ID = calendar.Count });              //adds the View Calendar option to the page
            calendar.Add(new CalendarViewModel { Name = "Create New Event", ID = calendar.Count });           //adds the Create New Event to the page
            calendar.Add(new CalendarViewModel { Name = "Schedule New Guests", ID = calendar.Count });        //adds the Schedule New Guests to the page
            calendar.Add(new CalendarViewModel { Name = "Schedule Chore", ID = calendar.Count });             //adds the Schedule Chore to the page
            calendar.Add(new CalendarViewModel { Name = "Reserve Laundry Machines", ID = calendar.Count });   //adds the Reserve Laundry Machines to the page
            calendar.Add(new CalendarViewModel { Name = "Reserve Quiet Time", ID = calendar.Count });         //adds the Reserve Quiet Time to the page
        }

        //make different objects for each type, be able to access all
        public void getEventsInCalendar(int CalendarID)                     //gets all events for a specific calendar
        {
            events = new ObservableCollection<CalendarViewModel>();        //instantiates events ObservableCollection that will notify when events are added, removed, and refreshed

            //HARD-CODED, WILL CHANGE
            events.Add(new CalendarViewModel { Name = "Event 1", ID = events.Count });     //adds the first event to the page
            events.Add(new CalendarViewModel { Name = "Event 2", ID = events.Count });     //adds the second event to the page
            if(CalendarID == 1)                                                            //tests if id is working correct and only need certain lists
            {
                events.Add(new CalendarViewModel { Name = "Custom Event", ID = events.Count });      //puts this on CalendarID == 1 page
            }
        }
    }
    public class EventObject
    {
        //sets dif events?
        //does individual events in a nice pretty way
        //like calendar view model, do messaging as well
        //CONNOR IN CHARGE OF LISTOBJECT
    }
    public class CalendarViewModel
    {
        public string Name { get; set; }
        public int ID { get; set; }
       //TODO public DateTime {get;set;} <- DEAL WITH THIS 
    }
}

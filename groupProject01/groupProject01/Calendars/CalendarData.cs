using System;
using System.Collections.Generic;
using System.Text;

namespace groupProject01
{
    public enum view
    {
        daily = 1,
        weekly = 2,
        monthly = 3,
    }
    public class CalendarData
    {
        public ObservableCollection<CalendarViewMode> calendar { get; set; } //declares calendars ObservableCollection that will notify when calendars are added, removed, and refreshed
        public ObservableCollection<CalendarViewModel> events { get; set; }  //declares events ObservableCollection that will notify when events are added, removed, and refreshed

        public CalendarData()                                               //constructor for the Calendar Data page
        {
            refreshAll();                                                   //refreshes all data on the page
        }

        public void refreshAll()                                            //refreshes all data on the page
        {
            calendar = new ObservableCollection<CalendarViewMode>();       //instantiates calendars ObservableCollection that will notify when calendars are added, removed, and refreshed

            //HARD-CODED, WILL CHANGE
            calendar.Add(new CalendarViewModel { Name = "Public", ID = calendar.Count });   //adds the public calendar to the page
            calendar.Add(new CalendarViewModel { Name = "Private", ID = calendar.Count });  //adds the private calendar to the page
        }

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

        public void loadCalendar()
        {
            throw new NotImplementedException();
        }
        public void changeView(view v)
        {
            throw new NotImplementedException();
        }
    }
    public class EventObject
    {

    }
    public class CalendarViewModel
    {
        public string Name { get; set; }
        public int ID { get; set; }
    }
}

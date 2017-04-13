using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace groupProject01
{
    public class CalendarData
    {

        DateTime todayWithTime;
        public ObservableCollection<CalendarOptionObject> options { get; set; } //declares options ObservableCollection that will notify when options are added, removed, and refreshed
        public ObservableCollection<EventObject> events { get; set; }   //declares calItems ObservableCollection that will notify when calendar items are added, removed, and refreshed

        public CalendarData()                                                 //constructor for the Calendar Data page
        {
            refreshAll();                                                     //refreshes all data on the page
            todayWithTime = DateTime.Today;                                   //sets date
        }

        public void refreshAll()                                             //refreshes all data on the page
        {
            options = new ObservableCollection<CalendarOptionObject>();         //instantiates calendar options ObservableCollection that will notify when calendar options are added, removed, and refreshed

            //HARD-CODED, WILL CHANGE
            options.Add(new CalendarOptionObject { Name = "View Calendar", ID = options.Count });              //adds the View Calendar option to the page
            options.Add(new CalendarOptionObject { Name = "Create New Event", ID = options.Count });           //adds the Create New Event to the page
        }

        //make different objects for each type, be able to access all
        public void getEventsInCalendar(int CalendarID)                     //gets all events for a specific calendar
        {
            events = new ObservableCollection<EventObject>();        //instantiates events ObservableCollection that will notify when events are added, removed, and refreshed

            //HARD-CODED, WILL CHANGE
            events.Add(new EventObject { Name = "AppearOnAll", ID = events.Count, senderID = 1, Start= todayWithTime, End= todayWithTime, AdditionalInfo = "HELLO I AM ADDITIONAL INFO WHO ARE YOU" });     //adds the first event to the page
            if(CalendarID == 0)                                 //adds the following events to the View Calendar page
            {
                events.Add(new EventObject { Name = "Party", ID = events.Count, senderID = 0, Start = todayWithTime, End = todayWithTime, AdditionalInfo = "haha. connor throwing a party." });     //adds the  event to the View Calendar page
            }
            if(CalendarID == 1)                                                            //adds the following options to the New Event page
            {
                events.Add(new EventObject { Name = "Schedule New Guests", ID = events.Count, senderID = 1, Start = todayWithTime, End = todayWithTime, AdditionalInfo = "" });        //adds the Schedule New Guests to the New Event page
                events.Add(new EventObject { Name = "Schedule Chore", ID = events.Count, senderID = 1, Start = todayWithTime, End = todayWithTime, AdditionalInfo = "" });             //adds the Schedule Chore to the New Event page
                events.Add(new EventObject { Name = "Reserve Laundry Machines", ID = events.Count, senderID = 0, Start = todayWithTime, End = todayWithTime, AdditionalInfo = "" });   //adds the Reserve Laundry Machines to the New Event page
                events.Add(new EventObject { Name = "Reserve Quiet Time", ID = events.Count, senderID = 1, Start = todayWithTime, End = todayWithTime, AdditionalInfo = "" });         //adds the Reserve Quiet Time to the New Event page
            }
        }
    }
    public class EventObject
    {
        public int ID { get; set; }
        public int senderID { get; set; }
        public string Name { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public string AdditionalInfo { get; set; }
    }
    public class CalendarOptionObject
    {
        public string Name { get; set; }
        public int ID { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text; 

using Xamarin.Forms;

namespace groupProject01
{
    public enum status
    {
        inApartment = 1,
        outApartment = 2,
        geofence = 3,
    }
	public class HomeData
	{
		public HomeData ()
		{
            refreshAll();
		}
        public void refreshAll()
        {
            loadRoomatesStatus();
            loadNotifications();
            throw new NotImplementedException();
        }
        public void loadRoomatesStatus()
        {
            throw new NotImplementedException();
        }

        public void loadNotifications()
        {
            throw new NotImplementedException();
        }
        public void changeStatus(status s)
        {
            throw new NotImplementedException();
        }

    }
}

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
    class CalendarData
    {
        public CalendarData()
        {
            refreshAll();
        }

        public void refreshAll()
        {
            loadCalendar();
            throw new NotImplementedException();
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
}

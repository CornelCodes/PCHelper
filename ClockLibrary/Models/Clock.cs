using ClockLibrary.Helpers;
using ClockLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClockLibrary
{
    public class Clock
    {
        private DateTime dateTime = new DateTime();
        public List<Alarm> Alarms { get; private set; }

        public Clock()
        {
            Alarms = new List<Alarm>();
            if(dateTime != null)
            {
                Logger.LogNormal("Clock started");
            }
        }

        /// <summary>
        /// Returns the current Date and Time
        /// <returns></returns>
        public DateTime GetDateTime()
        {
            dateTime = DateTime.UtcNow.ToLocalTime();
            return dateTime;
        }
        
        public void AddAlarm(int hour, int minutes, string description, List<string> days)
        {
            
            Alarms.Add(new Alarm(hour, minutes, description, days));
        }

        public void RemoveAlarm(Alarm alarm)
        {
            Alarms.Remove(alarm);
        }
    }
}

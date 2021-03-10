using ClockLibrary.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClockLibrary.Models
{
    public class Alarm
    {
        public DateTime AlarmTime { get; private set; }
        public string Description { get; set; }
        public List<string> RecurringDays { get; set; }

        public Alarm(int hour, int minutes, string description, List<string> recurringDays)
        {
            Description = description;
            RecurringDays = recurringDays;
            AlarmTime = CreateAlarm(hour, minutes);
            Logger.LogNormal($"Alarm set for {AlarmTime}");
        }

        private DateTime CreateAlarm(int hour, int minutes)
        {
            return new DateTime(1, 1, 1, hour, minutes, 0);
        }

    }
}

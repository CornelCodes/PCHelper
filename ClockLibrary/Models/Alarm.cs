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


        public string Description { get; private set; }

        public Alarm(int year, int month, int day, int hour, int minutes, string description)
        {
            AlarmTime = new DateTime(year, month, day, hour, minutes, 0);
            Description = description;
        }

    }
}

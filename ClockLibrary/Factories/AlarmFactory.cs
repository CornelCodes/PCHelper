using ClockLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClockLibrary.Factories
{
    public class AlarmFactory
    {

        public List<Alarm> AlarmRecurrences { get; private set; }

        public AlarmFactory()
        {
            AlarmRecurrences = new List<Alarm>();
        }

        public void CreateAlarms(int year, int month, int day, int hour, int minutes, string description)
        {
            //Logic to get day and the date time
            AlarmRecurrences.Add(new Alarm(year, month, day, hour, minutes, description));
        }

    }
}

using ClockLibrary.Factories;
using ClockLibrary.Helpers;
using ClockLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ClockLibrary
{
    public class Clock
    {
        private string _minuteValue;
        private string _hourValue;
        private static SoundPlayer player;
        private DateTime dateTime = new DateTime();
        private static AlarmFactory alarms;
        public Alarm activeAlarm;

        public string Hour
        {
            get { SetTime(); return _hourValue; }
            private set { }
        }
        public string Minute
        {
            get { SetTime(); return _minuteValue; }
            private set { }
        }

        public Clock()
        {
            player = new SoundPlayer();

            alarms = new AlarmFactory();
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
        
        public void AddAlarm(int year, int month, int day, int hour, int minutes, string description)
        {
            alarms.CreateAlarms(year, month, day, hour, minutes, description);
        }


        public bool CheckAlarms()
        {
            bool alarmActivated = false;
            activeAlarm = null;
            foreach (var alarm in alarms.AlarmRecurrences)
            {
                Logger.LogNormal("Checking for alarms");
                if (DateTime.Now == alarm.AlarmTime)
                {
                    //Logger.LogNormal($"Alarm activated at {DateTime.Now}");
                    //player.SoundLocation = @"C:\Windows\Media\Alarm01.wav";
                    //player.Play();
                    alarmActivated = true;
                    activeAlarm = alarm;
                    break;
                }
            }
            return alarmActivated;
        }

        public List<Alarm> GetAlarms()
        {
            return alarms.AlarmRecurrences;
        }

        private void SetTime()
        {
            if(DateTime.UtcNow.ToLocalTime().Minute < 10)
            {
                _minuteValue = $"0{DateTime.UtcNow.ToLocalTime().Minute.ToString()}";
            }
            else
            {
                _minuteValue = DateTime.UtcNow.ToLocalTime().Minute.ToString();
            }
            _hourValue = DateTime.UtcNow.ToLocalTime().Hour.ToString();
        }

    }
}

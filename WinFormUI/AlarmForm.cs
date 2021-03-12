using ClockLibrary.Models;
using MusicPlayerClassLibrary.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormUI
{
    public partial class AlarmForm : Form
    {
        private Alarm alarm;
        private PlayerSession player;
        public AlarmForm(Alarm alarm, PlayerSession player)
        {
            InitializeComponent();
            this.alarm = alarm;
            this.player = player;
            DisplayAlarm();
        }

        private void DisplayAlarm()
        {
            alarmTimeLabel.Text = $"{alarm.AlarmTime.Hour}:{alarm.AlarmTime.Minute}";
            player.PlaySong(@"C:\Personal\Music\Black Eyed Peas, Nicky Jam, Tyga - VIDA LOCA (Official Music Video).mp3");
        }
    }
}

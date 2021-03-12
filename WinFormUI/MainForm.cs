using MusicPlayerClassLibrary.ViewModels;
using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClockLibrary.Helpers;
using ClockLibrary;
using ClockLibrary.Models;
using System.Threading;

namespace WinFormUI
{
    public partial class PCAlarmDashboard : Form
    {
        private PlayerSession audioPlayer;
        private static Clock clock;
        private string audioFileLocation;
        List<string> audioFiles;
        static AlarmForm alarmForm;
        private string selectedAudioFile;
        private bool alarmNotActive = true;
        


        public PCAlarmDashboard(PlayerSession audioPlayer, Clock argclock)
        {
            clock = argclock;
            this.audioPlayer = audioPlayer;
            InitializeComponent();

            CheckForAlarms();
        }

        private void selectMusicButton_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1 = new FolderBrowserDialog();
            folderBrowserDialog1.ShowDialog();
            audioFileLocation = folderBrowserDialog1.SelectedPath;
            audioPlayer.SetDirectory(audioFileLocation);
            DisplayMusicFiles();

        }

        private void DisplayMusicFiles()
        {
            audioFiles = audioPlayer.GetAudioFiles();

            foreach (var file in audioFiles)
            {
                musicListBox.Items.Add(file);
            }
            Logger.LogNormal($"Loaded {audioFiles.Count} files");
        }

        private void playButton_Click(object sender, EventArgs e)
        {
            selectedAudioFile = musicListBox.SelectedItem.ToString();
            audioTrackLabel.Text = selectedAudioFile;
            audioPlayer.PlaySong(selectedAudioFile);
            Logger.LogNormal($"Playing {selectedAudioFile}");
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            audioPlayer.StopSong();
            Logger.LogNormal($"Stopped playing {selectedAudioFile}");
            selectedAudioFile = "";
        }

        private void CheckForAlarms()
        {
            Thread checkAlarmThread = new Thread(Check);
            Thread updateClockThread = new Thread(UpdateClock);
            updateClockThread.Start();
            checkAlarmThread.Start();
        }


        private void addAlarmButton_Click(object sender, EventArgs e)
        {
            AddAlarmForm addAlarmForm = new AddAlarmForm(clock, this);
            this.Hide();
            addAlarmForm.Show();
        }

        private void Check()
        {
            Alarm activeAlarm = null;
            while (alarmNotActive)
            {
                Logger.LogNormal("Checking for alarm");
                foreach (Alarm alarm in clock.GetAlarms())
                {
                    if(alarm.AlarmTime.Hour == DateTime.Now.Hour && alarm.AlarmTime.Minute == DateTime.Now.Minute)
                    {
                        Logger.LogNormal("Alarm activated");
                        activeAlarm = alarm;
                        alarmNotActive = false;
                        break;
                    }
                }
                Thread.Sleep(100);
            }
            alarmForm = new AlarmForm(activeAlarm, audioPlayer);
            alarmForm.ShowDialog();
            alarmForm.Focus();
        }

        private void UpdateClock()
        {
            while (true)
            {
                if (digitalClockValue.Text == "00:00")
                {
                    Logger.LogNormal("Clock updated");
                }

                digitalClockValue.Text = ($"{clock.Hour}:{clock.Minute}");

                if (clock.GetAlarms() != null)
                {
                    alarmsListBox.Items.Clear();
                    foreach (var alarm in clock.GetAlarms())
                    {
                        alarmsListBox.Items.Add(
                            $"{alarm.AlarmTime.DayOfWeek} {alarm.AlarmTime.Hour}:{alarm.AlarmTime.Minute}");
                    }
                }

                Thread.Sleep(1000);

            }
        }

    }
}

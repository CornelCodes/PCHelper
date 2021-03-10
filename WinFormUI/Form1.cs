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

namespace WinFormUI
{
    public partial class PCAlarmDashboard : Form
    {
        private PlayerSession audioPlayer;
        private Clock clock;
        private string audioFileLocation;
        List<string> audioFiles;
        private string selectedAudioFile;
        System.Timers.Timer t = new System.Timers.Timer(1000);


        public PCAlarmDashboard(PlayerSession audioPlayer, Clock clock)
        {
            this.clock = clock;
            this.audioPlayer = audioPlayer;
            InitializeComponent();
            t.Elapsed += UpdateClock;
            t.AutoReset = true;
            t.Enabled = true;
            t.Start();
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

        private void UpdateClock(object sender, EventArgs e)
        {
                if (digitalClockValue.Text == "00:00")
                {
                    Logger.LogNormal("Clock updated");
                }
                digitalClockValue.Text = ($"{clock.GetDateTime().Hour}:{clock.GetDateTime().Minute}");
        }

        private void PCAlarmDashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            t.Stop();
            t.Dispose();
        }

        private void addAlarmButton_Click(object sender, EventArgs e)
        {
            AddAlarmForm addAlarmForm = new AddAlarmForm(clock);
            this.Hide();
            addAlarmForm.Show();
        }
    }
}


namespace WinFormUI
{
    partial class PCAlarmDashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.musicPlayerMainPanel = new System.Windows.Forms.Panel();
            this.musicPanelHeader = new System.Windows.Forms.Panel();
            this.musicPanelList = new System.Windows.Forms.Panel();
            this.musicPanelSelect = new System.Windows.Forms.Panel();
            this.musicPanelHeaderLabel = new System.Windows.Forms.Label();
            this.musicListBox = new System.Windows.Forms.ListBox();
            this.clockDisplayPanel = new System.Windows.Forms.Panel();
            this.clockDigitalDisplayPanel = new System.Windows.Forms.Panel();
            this.musicControlPanel = new System.Windows.Forms.Panel();
            this.musicControlDisplayPanel = new System.Windows.Forms.Panel();
            this.musicControlButtonPanel = new System.Windows.Forms.Panel();
            this.clockAnalogDisplayPanel = new System.Windows.Forms.Panel();
            this.alarmControlPanel = new System.Windows.Forms.Panel();
            this.selectMusicButton = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.playButton = new System.Windows.Forms.Button();
            this.stopButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.audioTrackLabel = new System.Windows.Forms.Label();
            this.digitalClockValue = new System.Windows.Forms.Label();
            this.addAlarmButton = new System.Windows.Forms.Button();
            this.settingsButton = new System.Windows.Forms.Button();
            this.alarmsLabel = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.musicPlayerMainPanel.SuspendLayout();
            this.musicPanelHeader.SuspendLayout();
            this.musicPanelList.SuspendLayout();
            this.musicPanelSelect.SuspendLayout();
            this.clockDisplayPanel.SuspendLayout();
            this.clockDigitalDisplayPanel.SuspendLayout();
            this.musicControlPanel.SuspendLayout();
            this.musicControlDisplayPanel.SuspendLayout();
            this.musicControlButtonPanel.SuspendLayout();
            this.alarmControlPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // musicPlayerMainPanel
            // 
            this.musicPlayerMainPanel.BackColor = System.Drawing.Color.Black;
            this.musicPlayerMainPanel.Controls.Add(this.musicPanelSelect);
            this.musicPlayerMainPanel.Controls.Add(this.musicPanelList);
            this.musicPlayerMainPanel.Controls.Add(this.musicPanelHeader);
            this.musicPlayerMainPanel.Location = new System.Drawing.Point(12, 13);
            this.musicPlayerMainPanel.Name = "musicPlayerMainPanel";
            this.musicPlayerMainPanel.Size = new System.Drawing.Size(175, 369);
            this.musicPlayerMainPanel.TabIndex = 0;
            // 
            // musicPanelHeader
            // 
            this.musicPanelHeader.BackColor = System.Drawing.Color.White;
            this.musicPanelHeader.Controls.Add(this.musicPanelHeaderLabel);
            this.musicPanelHeader.Location = new System.Drawing.Point(3, 3);
            this.musicPanelHeader.Name = "musicPanelHeader";
            this.musicPanelHeader.Size = new System.Drawing.Size(169, 34);
            this.musicPanelHeader.TabIndex = 0;
            // 
            // musicPanelList
            // 
            this.musicPanelList.BackColor = System.Drawing.Color.White;
            this.musicPanelList.Controls.Add(this.musicListBox);
            this.musicPanelList.Location = new System.Drawing.Point(3, 40);
            this.musicPanelList.Name = "musicPanelList";
            this.musicPanelList.Size = new System.Drawing.Size(169, 285);
            this.musicPanelList.TabIndex = 1;
            // 
            // musicPanelSelect
            // 
            this.musicPanelSelect.BackColor = System.Drawing.Color.White;
            this.musicPanelSelect.Controls.Add(this.selectMusicButton);
            this.musicPanelSelect.Location = new System.Drawing.Point(3, 331);
            this.musicPanelSelect.Name = "musicPanelSelect";
            this.musicPanelSelect.Size = new System.Drawing.Size(169, 33);
            this.musicPanelSelect.TabIndex = 1;
            // 
            // musicPanelHeaderLabel
            // 
            this.musicPanelHeaderLabel.AutoSize = true;
            this.musicPanelHeaderLabel.Location = new System.Drawing.Point(3, 3);
            this.musicPanelHeaderLabel.Name = "musicPanelHeaderLabel";
            this.musicPanelHeaderLabel.Size = new System.Drawing.Size(68, 30);
            this.musicPanelHeaderLabel.TabIndex = 0;
            this.musicPanelHeaderLabel.Text = "Music";
            // 
            // musicListBox
            // 
            this.musicListBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.musicListBox.FormattingEnabled = true;
            this.musicListBox.ItemHeight = 17;
            this.musicListBox.Location = new System.Drawing.Point(3, 3);
            this.musicListBox.Name = "musicListBox";
            this.musicListBox.Size = new System.Drawing.Size(163, 259);
            this.musicListBox.TabIndex = 0;
            // 
            // clockDisplayPanel
            // 
            this.clockDisplayPanel.Controls.Add(this.clockAnalogDisplayPanel);
            this.clockDisplayPanel.Controls.Add(this.clockDigitalDisplayPanel);
            this.clockDisplayPanel.Location = new System.Drawing.Point(193, 12);
            this.clockDisplayPanel.Name = "clockDisplayPanel";
            this.clockDisplayPanel.Size = new System.Drawing.Size(399, 125);
            this.clockDisplayPanel.TabIndex = 1;
            // 
            // clockDigitalDisplayPanel
            // 
            this.clockDigitalDisplayPanel.Controls.Add(this.digitalClockValue);
            this.clockDigitalDisplayPanel.Location = new System.Drawing.Point(126, 4);
            this.clockDigitalDisplayPanel.Name = "clockDigitalDisplayPanel";
            this.clockDigitalDisplayPanel.Size = new System.Drawing.Size(270, 117);
            this.clockDigitalDisplayPanel.TabIndex = 2;
            // 
            // musicControlPanel
            // 
            this.musicControlPanel.Controls.Add(this.musicControlButtonPanel);
            this.musicControlPanel.Controls.Add(this.musicControlDisplayPanel);
            this.musicControlPanel.Location = new System.Drawing.Point(193, 143);
            this.musicControlPanel.Name = "musicControlPanel";
            this.musicControlPanel.Size = new System.Drawing.Size(399, 69);
            this.musicControlPanel.TabIndex = 3;
            // 
            // musicControlDisplayPanel
            // 
            this.musicControlDisplayPanel.Controls.Add(this.audioTrackLabel);
            this.musicControlDisplayPanel.Controls.Add(this.label1);
            this.musicControlDisplayPanel.Location = new System.Drawing.Point(60, 3);
            this.musicControlDisplayPanel.Name = "musicControlDisplayPanel";
            this.musicControlDisplayPanel.Size = new System.Drawing.Size(336, 63);
            this.musicControlDisplayPanel.TabIndex = 4;
            // 
            // musicControlButtonPanel
            // 
            this.musicControlButtonPanel.Controls.Add(this.stopButton);
            this.musicControlButtonPanel.Controls.Add(this.playButton);
            this.musicControlButtonPanel.Location = new System.Drawing.Point(3, 3);
            this.musicControlButtonPanel.Name = "musicControlButtonPanel";
            this.musicControlButtonPanel.Size = new System.Drawing.Size(51, 63);
            this.musicControlButtonPanel.TabIndex = 5;
            // 
            // clockAnalogDisplayPanel
            // 
            this.clockAnalogDisplayPanel.Location = new System.Drawing.Point(3, 3);
            this.clockAnalogDisplayPanel.Name = "clockAnalogDisplayPanel";
            this.clockAnalogDisplayPanel.Size = new System.Drawing.Size(117, 118);
            this.clockAnalogDisplayPanel.TabIndex = 3;
            // 
            // alarmControlPanel
            // 
            this.alarmControlPanel.Controls.Add(this.listBox1);
            this.alarmControlPanel.Controls.Add(this.alarmsLabel);
            this.alarmControlPanel.Controls.Add(this.settingsButton);
            this.alarmControlPanel.Controls.Add(this.addAlarmButton);
            this.alarmControlPanel.Location = new System.Drawing.Point(193, 218);
            this.alarmControlPanel.Name = "alarmControlPanel";
            this.alarmControlPanel.Size = new System.Drawing.Size(399, 164);
            this.alarmControlPanel.TabIndex = 6;
            // 
            // selectMusicButton
            // 
            this.selectMusicButton.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectMusicButton.Location = new System.Drawing.Point(3, 4);
            this.selectMusicButton.Name = "selectMusicButton";
            this.selectMusicButton.Size = new System.Drawing.Size(163, 26);
            this.selectMusicButton.TabIndex = 0;
            this.selectMusicButton.Text = "Select Music";
            this.selectMusicButton.UseVisualStyleBackColor = true;
            this.selectMusicButton.Click += new System.EventHandler(this.selectMusicButton_Click);
            // 
            // playButton
            // 
            this.playButton.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playButton.Location = new System.Drawing.Point(4, 4);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(42, 23);
            this.playButton.TabIndex = 0;
            this.playButton.Text = "Play";
            this.playButton.UseVisualStyleBackColor = true;
            this.playButton.Click += new System.EventHandler(this.playButton_Click);
            // 
            // stopButton
            // 
            this.stopButton.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stopButton.Location = new System.Drawing.Point(4, 33);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(42, 23);
            this.stopButton.TabIndex = 1;
            this.stopButton.Text = "Stop";
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Playing:";
            // 
            // audioTrackLabel
            // 
            this.audioTrackLabel.AutoSize = true;
            this.audioTrackLabel.Location = new System.Drawing.Point(94, 16);
            this.audioTrackLabel.Name = "audioTrackLabel";
            this.audioTrackLabel.Size = new System.Drawing.Size(182, 30);
            this.audioTrackLabel.TabIndex = 1;
            this.audioTrackLabel.Text = "SampleAudio.mp3";
            // 
            // digitalClockValue
            // 
            this.digitalClockValue.AutoSize = true;
            this.digitalClockValue.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.digitalClockValue.Location = new System.Drawing.Point(38, 14);
            this.digitalClockValue.Name = "digitalClockValue";
            this.digitalClockValue.Size = new System.Drawing.Size(191, 86);
            this.digitalClockValue.TabIndex = 0;
            this.digitalClockValue.Text = "00:00";
            // 
            // addAlarmButton
            // 
            this.addAlarmButton.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addAlarmButton.Location = new System.Drawing.Point(258, 37);
            this.addAlarmButton.Name = "addAlarmButton";
            this.addAlarmButton.Size = new System.Drawing.Size(126, 48);
            this.addAlarmButton.TabIndex = 1;
            this.addAlarmButton.Text = "Add alarm";
            this.addAlarmButton.UseVisualStyleBackColor = true;
            this.addAlarmButton.Click += new System.EventHandler(this.addAlarmButton_Click);
            // 
            // settingsButton
            // 
            this.settingsButton.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.settingsButton.Location = new System.Drawing.Point(258, 108);
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.Size = new System.Drawing.Size(126, 48);
            this.settingsButton.TabIndex = 2;
            this.settingsButton.Text = "Settings";
            this.settingsButton.UseVisualStyleBackColor = true;
            // 
            // alarmsLabel
            // 
            this.alarmsLabel.AutoSize = true;
            this.alarmsLabel.Location = new System.Drawing.Point(3, 4);
            this.alarmsLabel.Name = "alarmsLabel";
            this.alarmsLabel.Size = new System.Drawing.Size(77, 30);
            this.alarmsLabel.TabIndex = 1;
            this.alarmsLabel.Text = "Alarms";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 30;
            this.listBox1.Location = new System.Drawing.Point(7, 37);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(245, 124);
            this.listBox1.TabIndex = 3;
            // 
            // PCAlarmDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(604, 394);
            this.Controls.Add(this.alarmControlPanel);
            this.Controls.Add(this.musicControlPanel);
            this.Controls.Add(this.clockDisplayPanel);
            this.Controls.Add(this.musicPlayerMainPanel);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.MaximizeBox = false;
            this.Name = "PCAlarmDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PC Alarm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.PCAlarmDashboard_FormClosed);
            this.musicPlayerMainPanel.ResumeLayout(false);
            this.musicPanelHeader.ResumeLayout(false);
            this.musicPanelHeader.PerformLayout();
            this.musicPanelList.ResumeLayout(false);
            this.musicPanelSelect.ResumeLayout(false);
            this.clockDisplayPanel.ResumeLayout(false);
            this.clockDigitalDisplayPanel.ResumeLayout(false);
            this.clockDigitalDisplayPanel.PerformLayout();
            this.musicControlPanel.ResumeLayout(false);
            this.musicControlDisplayPanel.ResumeLayout(false);
            this.musicControlDisplayPanel.PerformLayout();
            this.musicControlButtonPanel.ResumeLayout(false);
            this.alarmControlPanel.ResumeLayout(false);
            this.alarmControlPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel musicPlayerMainPanel;
        private System.Windows.Forms.Panel musicPanelSelect;
        private System.Windows.Forms.Button selectMusicButton;
        private System.Windows.Forms.Panel musicPanelList;
        private System.Windows.Forms.ListBox musicListBox;
        private System.Windows.Forms.Panel musicPanelHeader;
        private System.Windows.Forms.Label musicPanelHeaderLabel;
        private System.Windows.Forms.Panel clockDisplayPanel;
        private System.Windows.Forms.Panel clockAnalogDisplayPanel;
        private System.Windows.Forms.Panel clockDigitalDisplayPanel;
        private System.Windows.Forms.Panel musicControlPanel;
        private System.Windows.Forms.Panel musicControlButtonPanel;
        private System.Windows.Forms.Panel musicControlDisplayPanel;
        private System.Windows.Forms.Panel alarmControlPanel;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.Button playButton;
        private System.Windows.Forms.Label audioTrackLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label digitalClockValue;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label alarmsLabel;
        private System.Windows.Forms.Button settingsButton;
        private System.Windows.Forms.Button addAlarmButton;
    }
}


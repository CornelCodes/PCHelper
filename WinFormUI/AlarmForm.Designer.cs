
namespace WinFormUI
{
    partial class AlarmForm
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
            this.alarmTextLabel = new System.Windows.Forms.Label();
            this.alarmTimeLabel = new System.Windows.Forms.Label();
            this.dismissButton = new System.Windows.Forms.Button();
            this.snoozeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // alarmTextLabel
            // 
            this.alarmTextLabel.AutoSize = true;
            this.alarmTextLabel.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alarmTextLabel.Location = new System.Drawing.Point(47, 9);
            this.alarmTextLabel.Name = "alarmTextLabel";
            this.alarmTextLabel.Size = new System.Drawing.Size(143, 50);
            this.alarmTextLabel.TabIndex = 0;
            this.alarmTextLabel.Text = "ALARM";
            // 
            // alarmTimeLabel
            // 
            this.alarmTimeLabel.AutoSize = true;
            this.alarmTimeLabel.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alarmTimeLabel.Location = new System.Drawing.Point(63, 70);
            this.alarmTimeLabel.Name = "alarmTimeLabel";
            this.alarmTimeLabel.Size = new System.Drawing.Size(110, 50);
            this.alarmTimeLabel.TabIndex = 1;
            this.alarmTimeLabel.Text = "00:00";
            // 
            // dismissButton
            // 
            this.dismissButton.Location = new System.Drawing.Point(16, 145);
            this.dismissButton.Name = "dismissButton";
            this.dismissButton.Size = new System.Drawing.Size(91, 40);
            this.dismissButton.TabIndex = 2;
            this.dismissButton.Text = "Dismiss";
            this.dismissButton.UseVisualStyleBackColor = true;
            // 
            // snoozeButton
            // 
            this.snoozeButton.Location = new System.Drawing.Point(130, 145);
            this.snoozeButton.Name = "snoozeButton";
            this.snoozeButton.Size = new System.Drawing.Size(91, 40);
            this.snoozeButton.TabIndex = 3;
            this.snoozeButton.Text = "Snooze";
            this.snoozeButton.UseVisualStyleBackColor = true;
            // 
            // AlarmForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(237, 200);
            this.Controls.Add(this.snoozeButton);
            this.Controls.Add(this.dismissButton);
            this.Controls.Add(this.alarmTimeLabel);
            this.Controls.Add(this.alarmTextLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "AlarmForm";
            this.Text = "Alarm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label alarmTextLabel;
        private System.Windows.Forms.Label alarmTimeLabel;
        private System.Windows.Forms.Button dismissButton;
        private System.Windows.Forms.Button snoozeButton;
    }
}
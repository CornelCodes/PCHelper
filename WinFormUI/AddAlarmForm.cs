using ClockLibrary;
using ClockLibrary.Helpers;
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
    public partial class AddAlarmForm : Form
    {
        Clock clock;
        Form parentForm;
        public AddAlarmForm(Clock clock, Form parentForm)
        {
            this.parentForm = parentForm;
            this.clock = clock;
            InitializeComponent();
        }

        private void createAlarmButton_Click(object sender, EventArgs e)
        {
            clock.AddAlarm(
                alarmDatePicker.Value.Year,
                alarmDatePicker.Value.Month,
                alarmDatePicker.Value.Day,
                Int32.Parse(hourTextBox.Text),
                Int32.Parse(minuteTextBox.Text),
                descriptionTextBox.Text);
            this.Close();
            parentForm.Show();

        }

        private void alarmDatePicker_ValueChanged(object sender, EventArgs e)
        {
            monthCalendar.SetDate(alarmDatePicker.Value);
        }
    }
}

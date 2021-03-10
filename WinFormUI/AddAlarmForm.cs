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
        public AddAlarmForm(Clock clock)
        {
            this.clock = clock;
            InitializeComponent();
        }

        private void createAlarmButton_Click(object sender, EventArgs e)
        {
            List<string> recurringDays = new List<string>();
            foreach (var item in daysListBox.CheckedItems)
            {
                recurringDays.Add(item.ToString());
                Logger.LogNormal($"{item.ToString()} added to recurring days");
            }

            clock.AddAlarm( 
                Int32.Parse(hourTextBox.Text),
                Int32.Parse(minuteTextBox.Text),
                descriptionTextBox.Text, recurringDays);
            Logger.LogNormal("Alarm added");
        }
    }
}

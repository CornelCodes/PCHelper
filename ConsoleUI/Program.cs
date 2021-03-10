using ClockLibrary;
using ClockLibrary.Models;
using MusicPlayerClassLibrary.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsoleUI
{
    public class Program
    {
        [STAThreadAttribute]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            PlayerSession audioPlayer = new PlayerSession();
            Clock clock = new Clock();
            Application.Run(new WinFormUI.PCAlarmDashboard(audioPlayer, clock));

        }
    }
}

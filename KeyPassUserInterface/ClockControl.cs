using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace KeyPassUserInterface
{
    public partial class ClockControl : UserControl
    {
        public ClockControl()
        {
            InitializeComponent();
        }

        private void OnTimerTick(object sender, EventArgs e)
        {
            UpdateTime();
        }

        private void OnLoad(object sender, EventArgs e)
        {
            UpdateTime();
        }

        private void UpdateTime()
        {
            this._clockLabel.Text = System.DateTime.Now.ToString("G");
        }

        private void OnClockClick(object sender, EventArgs e)
        {
            Process.Start("rundll32.exe", "shell32.dll,Control_RunDLL TimeDate.cpl");
        }
    }
}

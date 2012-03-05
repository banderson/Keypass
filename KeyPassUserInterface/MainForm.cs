using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace KeyPassUserInterface
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        //TODO: this should be moved into the maincontrol somehow
        private void OnLoad(object sender, EventArgs e)
        {
            this.FormClosing += OnExit;
        }

        private void OnExit(Object sender, FormClosingEventArgs e)
        {
            _mainControl.OnExit(sender, e);
        }
    }
}

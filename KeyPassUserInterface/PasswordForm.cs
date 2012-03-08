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
    public partial class PasswordForm : Form
    {
        private static string password = "FooBarMeow";

        public PasswordForm()
        {
            InitializeComponent();
        }

        private void OnLoad(object sender, EventArgs e)
        {
            _txtPassword.Text = password;
            ActiveControl = _txtPassword;
        }

        private void OnOkay(object sender, EventArgs e)
        {
            if (!TryValidate())
                return;

            this.Hide();
            using (var form = new MainForm())
            {
                form.ShowDialog(this);
            }

        }

        private void OnCancel(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private bool TryValidate()
        {
            if (_txtPassword.Text != password)
            {
                MessageBox.Show("Invalid Password", "My KeyPass", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void OnShowPassword(object sender, EventArgs e)
        {
            _txtPassword.UseSystemPasswordChar = !_cbxShowPass.Checked;
        }
    }
}

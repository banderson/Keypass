using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using KeyPassBusiness;
using KeyPassInfoModel;
using System.Threading;

namespace KeyPassUserInterface
{
    public partial class KeyPropertiesForm : Form
    {
        // determines if we should prefill data from currently selected key
        public bool IsEditMode { get; set; }

        public string Title { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Url { get; set; }
        public string Notes { get; set; }

        public KeyPropertiesForm()
        {
            InitializeComponent();
        }

        private void OnOK(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                this.Title = _txtTitle.Text;
                this.UserName = _txtUsername.Text;
                this.Notes = _txtComment.Text;
                this.Password = _txtPassword.Text;

                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void OnCancel(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        /// <summary>
        /// Validates user input for form
        /// </summary>
        /// <returns></returns>
        private bool ValidateInput()
        {
            if (string.IsNullOrEmpty(_txtTitle.Text))
            {
                MessageBox.Show("Title cannot be blank");
                return false;
            } else if (string.IsNullOrEmpty(_txtUsername.Text)) {
                MessageBox.Show("Username cannot be blank");
                return false;
            } else if (string.IsNullOrEmpty(_txtPassword.Text)) {
                MessageBox.Show("Password cannot be blank");
                return false;
            } else if (!_txtPassword.Text.Equals(_txtConfirm.Text)) {
                MessageBox.Show("Passwords do not match");
                return false;
            }
            
            return true;
        }

        private void OnTestClick(object sender, EventArgs e)
        {
            _txtPassword.Text = Util.GetRandomString(10);
            Thread.Sleep(25);
            _txtConfirm.Text = _txtPassword.Text;
            _txtTitle.Text = Util.GetRandomString(10); 
            Thread.Sleep(25);
            _txtURL.Text = Util.GetRandomString(10); 
            Thread.Sleep(25);
            _txtUsername.Text = Util.GetRandomString(10); 
            Thread.Sleep(25);
            _txtComment.Text = Util.GetRandomString(10);
        }

        private void OnLoad(object sender, EventArgs e)
        {
            List<Group> groups = GroupKeyMgr.GetGroups();
            _cbxGroups.DataSource = groups;
            _cbxGroups.SelectedItem = ContextMgr.CurrentGroup;

            if (IsEditMode && ContextMgr.CurrentKey != null)
            {
                preFillForm();
            }
        }

        private void preFillForm()
        {
            Key k = ContextMgr.CurrentKey;
            _txtComment.Text = k.Notes;
            _txtPassword.Text = k.Password;
            _txtConfirm.Text = k.Password;
            _txtTitle.Text = k.Title;
            _txtURL.Text = k.Url;
            _txtUsername.Text = k.UserName;
        }
    }
}

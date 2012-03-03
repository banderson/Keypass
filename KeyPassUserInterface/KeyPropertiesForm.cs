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
        private Key _key;
        public Key Key
        {
            get { return _key; }
            set { _key = value; }
        }

        private Group _group;
        public Group Group
        {
            get { return _group; }
            set { _group = value; }
        }

        public KeyPropertiesForm()
        {
            InitializeComponent();
        }

        public KeyPropertiesForm(Group group) 
            : this()
        {
            _group = group;
        }

        public KeyPropertiesForm(Group group, Key key)
            : this()
        {
            _group = group;
            _key = key;
        }

        private void OnOK(object sender, EventArgs e)
        {
            if (!ValidateInput())
                return;
            
            if (_key == null)
                _key = new Key();

            _key.Title = _txtTitle.Text;
            _key.UserName = _txtUsername.Text;
            _key.Notes = _txtComment.Text;
            _key.Password = _txtPassword.Text;

            _group = (Group)_cbxGroups.SelectedItem;

            DialogResult = DialogResult.OK;
            Close();
            
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

            if (_key != null)
            {
                _txtComment.Text = _key.Notes;
                _txtPassword.Text = _key.Password;
                _txtConfirm.Text = _key.Password;
                _txtTitle.Text = _key.Title;
                _txtURL.Text = _key.Url;
                _txtUsername.Text = _key.UserName;
            }
        }
    }
}

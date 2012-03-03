using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using KeyPassBusiness;

namespace KeyPassUserInterface
{
    public partial class GroupPropertiesForm : Form
    {

        public bool isEditMode = false;

        public GroupPropertiesForm()
        {
            InitializeComponent();
        }

        public string GroupName { get; set; }

        private void OnCancel(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void OnOK(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                this.GroupName = _txtGroupName.Text;
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        /// <summary>
        /// Validates user input for form
        /// </summary>
        /// <returns></returns>
        private bool ValidateInput()
        {
            if (string.IsNullOrEmpty(_txtGroupName.Text))
            {
                MessageBox.Show("Group Name cannot be blank");
                return false;
            }

            return true;
        }

        private void OnTestClick(object sender, EventArgs e)
        {
            this._txtGroupName.Text = Util.GetRandomString(10);
        }

        private void GroupPropertiesForm_Load(object sender, EventArgs e)
        {
            if (_txtGroupName.CanFocus)
            {
                _txtGroupName.Focus();
            }

            if (ContextMgr.CurrentGroup != null && isEditMode)
            {
                _txtGroupName.Text = ContextMgr.CurrentGroup.GroupName;
            }
        }
    }
}

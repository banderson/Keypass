using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using KeyPassBusiness;

namespace KeyPassUserInterface
{
    public partial class MainControl : UserControl
    {
        public MainControl()
        {
            InitializeComponent();

            Application.Idle += OnIdle;
        }

        public void OnIdle(object sender, EventArgs e)
        {
            _menuEditGroup.Enabled = !(ContextMgr.CurrentGroup == null);
            _menuDeleteGroup.Enabled = !(ContextMgr.CurrentGroup == null);
            _menuAddKey.Enabled = !(ContextMgr.CurrentGroup == null);

            _menuEditKey.Enabled = !(ContextMgr.CurrentKey == null) && !ContextMgr.MultipleKeysSelected;
            _menuDeleteKey.Enabled = !(ContextMgr.CurrentKey == null);
        }

        private void OnAboutForm(object sender, EventArgs e)
        {
            AboutForm _aboutForm = new AboutForm();
            _aboutForm.ShowDialog();
        }

        private void OnToolBarToggle(object sender, EventArgs e)
        {
            // toggle the tool bar
            _toolStrip.Visible = !_toolStrip.Visible;
        }

        private void OnStatusBarToggle(object sender, EventArgs e)
        {
            // toggle the status bar
            _statusStripControl.Visible = !_statusStripControl.Visible;
        }

        private void OnExitClick(object sender, EventArgs e)
        {
            // close the application when the exit menu item is clicked
            Application.Exit();
        }

        // these methods are just wrappers to the TreeView user control functionality
        private void OnAddGroupClick(object sender, EventArgs e)
        {
            _trvGroups.OnGroupNew(sender, e);
        }

        private void OnEditGroupClick(object sender, EventArgs e)
        {
            _trvGroups.OnGroupEditClick(sender, e);
        }

        private void OnDeleteGroupClick(object sender, EventArgs e)
        {
            _trvGroups.OnGroupDeleteClick(sender, e);
        }

        private void OnKeyAddMenuClick(object sender, EventArgs e)
        {
            _lvwKeys.OnKeyAdd(sender, e);
        }

        private void OnKeyEditMenuClick(object sender, EventArgs e)
        {
            _lvwKeys.OnKeyEdit(sender, e);
        }

        private void OnKeyDeleteMenuClick(object sender, EventArgs e)
        {
            _lvwKeys.OnDeleteClick(sender, e);
        }
    }
}

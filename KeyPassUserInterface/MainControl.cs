using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using KeyPassBusiness;
using KeyPassInfoModel;

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

        public void OnExit(object sender, EventArgs e)
        {
            if (ContinueAfterSave(sender, e) == false)
            {
                if (e is FormClosingEventArgs)
                    ((FormClosingEventArgs)e).Cancel = true;

                return;
            }

            // prevent double confirmation boxes when "No" is selected on save. This occurs
            //  because calling Application.Exit explicitly below fires the event a 2nd time
            //  TODO: better way to do this?
            KeyPassMgr.Document.IsModified = false;

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
            _lvwKeys.OnKeyDelete(sender, e);
        }

        private void OnLoad(object sender, EventArgs e)
        {
            ContextMgr.KeySelected += ShowKeyDetails;
        }

        private void ShowKeyDetails(List<Key> keys)
        {
            if (keys.Count == 1)
                _rtbKeyDisplay.Text = keys[0].ToString();
            else
                _rtbKeyDisplay.Text = "";
        }

        private void OnNewDocument(object sender, EventArgs e)
        {
            if (ContinueAfterSave(sender, e) == false)
                return;

            KeyPassMgr.NewDocument();
        }

        private void OnOpenClick(object sender, EventArgs e)
        {
            if (ContinueAfterSave(sender, e) == false)
                return;

            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "XML Files|*.xml";
            dlg.Title = "Open KeyPass Document";

            // If the file name is not an empty string open it for saving.
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                KeyPassMgr.OpenDocument(dlg.FileName);
            }
        }

        private bool ContinueAfterSave(object sender, EventArgs e)
        {
            if (KeyPassMgr.Document.IsModified)
            {
                var result = MessageBox.Show("You've made changes, would you like to save?", "What's this?", MessageBoxButtons.YesNoCancel);
                if (result == DialogResult.Yes)
                {
                    OnSaveClick(sender, e);
                }
                else if (result == DialogResult.Cancel)
                {
                    return false;
                }
            }

            return true;
        }

        private void OnSaveClick(object sender, EventArgs e)
        {
            string fileToSave = "";
            if (String.IsNullOrEmpty(KeyPassMgr.Document.FilePath))
            {
                SaveFileDialog dlg = new SaveFileDialog();
                dlg.Filter = "XML Files|*.xml";
                dlg.Title = "Save KeyPass Document";

                // If the file name is not an empty string open it for saving.
                var result = dlg.ShowDialog();
                if (result == DialogResult.OK)
                {
                    fileToSave = dlg.FileName;
                }
                else if (result == DialogResult.Cancel)
                {
                    return;
                }
            }
            else
            {
                fileToSave = KeyPassMgr.Document.FilePath;
            }

            KeyPassMgr.SaveDocument(fileToSave);
        }
    }
}

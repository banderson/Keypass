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
using System.Diagnostics;

namespace KeyPassUserInterface
{
    public partial class StatusStripControl : UserControl
    {
        public StatusStripControl()
        {
            InitializeComponent();
        }

        private void OnLoad(object sender, EventArgs e)
        {
            ContextMgr.GroupAdded += UpdateGroupCount;
            ContextMgr.KeySelected += UpdateKeysCount;

            KeyPassMgr.GroupAdded += AuditGroupAdded;
            KeyPassMgr.GroupModified += AuditGroupUpdated;
            KeyPassMgr.GroupDeleted += AuditGroupDeleted;

            KeyPassMgr.KeyAdded += AuditKeyAdded;
            KeyPassMgr.KeyModified += AuditKeyUpdated;
            KeyPassMgr.KeyDeleted += AuditKeyDeleted;
        }

        private void UpdateGroupCount(Group group)
        {
            _groupsLabel.Text = "Groups: "+ KeyPassMgr.GetGroups().Count;
        }

        private void UpdateKeysCount(List<Key> keys)
        {
            _keysLabel.Text = String.Format("{0} of {1} Keys Selected", keys.Count, KeyPassMgr.GetKeysForGroup(ContextMgr.CurrentGroup).Count);
        }

        private void AuditGroupAdded(Group currentGroup)
        {
            Audit("Add Group: " + currentGroup.ToString());
        }

        private void AuditGroupUpdated(Group currentGroup)
        {
            Audit("Modify Group: " + currentGroup.ToString());
        }

        private void AuditGroupDeleted(Group currentGroup)
        {
            Audit("Delete Group: " + currentGroup.ToString());
        }

        private void AuditKeyAdded(Key currentKey)
        {
            Audit("Add Key to Group "+ ContextMgr.CurrentGroup.ToString() +": " + currentKey.ToString());
        }

        private void AuditKeyUpdated(Key currentKey)
        {
            Audit("Key Modified: " + currentKey.ToString());
        }

        private void AuditKeyDeleted(Key currentKey)
        {
            Audit("Key Deleted: " + currentKey.ToString());
        }

        private void Audit(string text)
        {
            _comboBox.Items.Insert(0, DateTime.Now + ": "+ text);
            _comboBox.Text = DateTime.Now + ": " + text;
        }
    }
}

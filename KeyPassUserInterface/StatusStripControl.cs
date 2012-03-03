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
        }

        private void UpdateGroupCount(Group group)
        {
            _groupsLabel.Text = "Groups: "+ KeyPassMgr.GetGroups().Count;
        }

        private void UpdateKeysCount(List<Key> keys)
        {
            _keysLabel.Text = String.Format("{0} of {1} Keys Selected", keys.Count, KeyPassMgr.GetKeysForGroup(ContextMgr.CurrentGroup).Count);
        }
    }
}

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
    public partial class GroupTreeControl : UserControl
    {
        public GroupTreeControl()
        {
            InitializeComponent();
        }

        private void OnLoad(object sender, EventArgs e)
        {
            Application.Idle += OnIdle;
        }

        // TODO: here's where we would disable non-relevant buttons, etc.
        private void OnIdle(object sender, EventArgs e)
        {
            _btnDelete.Enabled = !(ContextMgr.CurrentGroup == null);
            _btnEdit.Enabled = !(ContextMgr.CurrentGroup == null);
        }

        public void OnGroupNew(object sender, EventArgs e)
        {
            GroupPropertiesForm f = new GroupPropertiesForm();
            using (f)
            {
                if (f.ShowDialog(this) == DialogResult.Cancel)
                    return;
            }

            Group g = new Group();
            g.GroupName = f.GroupName;
            KeyPassMgr.AddGroup(g);

            var node = _tvwGroups.Nodes.Add(g.GroupName);
            node.Tag = g;
            _tvwGroups.SelectedNode = node;

            ContextMgr.FireGroupAdded();
        }

        private void OnGroupSelected(object sender, TreeViewEventArgs e)
        {
            ContextMgr.CurrentGroup = (Group)_tvwGroups.SelectedNode.Tag;
            ContextMgr.FireGroupSelected();
        }

        public void OnGroupDeleteClick(object sender, EventArgs e)
        {
            var result = MessageBox.Show("This will delete the Group and all its associated keys. Are you sure?", "Confirm Delete Group", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                Group currentGroup = (Group)_tvwGroups.SelectedNode.Tag;
                KeyPassMgr.DeleteGroup(currentGroup);
                _tvwGroups.SelectedNode.Remove();
            }

            // if there are no more groups left, set the CurrentGroup to NULL
            //  it's needed because no other group can be autoselected
            if (_tvwGroups.SelectedNode == null)
                ContextMgr.CurrentGroup = null;
        }

        public void OnGroupEditClick(object sender, EventArgs e)
        {
            GroupPropertiesForm f = new GroupPropertiesForm();
            using (f)
            {
                f.isEditMode = true;
                if (f.ShowDialog(this) == DialogResult.Cancel)
                    return;
            }

            Group g = ContextMgr.CurrentGroup;
            g.GroupName = f.GroupName;
            _tvwGroups.SelectedNode.Text = f.GroupName;
        }
    }
}

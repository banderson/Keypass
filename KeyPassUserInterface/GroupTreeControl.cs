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
            KeyPassMgr.NewDocumentCreated += RedrawGroups;
            KeyPassMgr.DocumentOpened += RedrawGroups;
            KeyPassMgr.GroupAdded += AddGroupNode;
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

            ContextMgr.FireGroupAdded();
        }

        private void AddGroupNode(Group g)
        {
            var node = _tvwGroups.Nodes.Add(g.GroupName);
            node.Tag = g;
            _tvwGroups.SelectedNode = node;
        }

        private void OnGroupSelected(object sender, TreeViewEventArgs e)
        {
            SelectGroup();
        }

        private void SelectGroup()
        {
            if (_tvwGroups.SelectedNode != null)
            {
                ContextMgr.CurrentGroup = (Group)_tvwGroups.SelectedNode.Tag;
                ContextMgr.FireGroupSelected();
            }
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

            KeyPassMgr.ModifyGroup(g);
        }

        private void RedrawGroups()
        {
            _tvwGroups.Nodes.Clear();

            foreach (Group g in KeyPassMgr.GetGroups())
            {
                AddGroupNode(g);
            }
        }

        private void OnGroupMouseDown(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                _tvwGroups.SelectedNode = e.Node;
                _ctxtDeleteGroup.Enabled = _ctxtEditGroup.Enabled = _ctxtAddGroup.Enabled = _ctxtCopy.Enabled = true;
                _ctxtPaste.Enabled = HasGroupOnClipBoard();
                _contextMenuStrip.Show(_tvwGroups, e.X, e.Y);
            }
        }

        private void OnRightClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                _ctxtDeleteGroup.Enabled = _ctxtEditGroup.Enabled = _ctxtCopy.Enabled = _tvwGroups.SelectedNode != null;
                _ctxtPaste.Enabled = HasGroupOnClipBoard();
                _contextMenuStrip.Show(_tvwGroups, e.X, e.Y);
            }
        }

        private void OnGroupCopy(object sender, EventArgs e)
        {
            Group g = ContextMgr.CurrentGroup;
            DataObject dataObj = new DataObject();
            dataObj.SetData("KeyPass::Group", g);
            Clipboard.SetDataObject(dataObj, true);
        }

        private void OnGroupPaste(object sender, EventArgs e)
        {
            // First check if the clipboard contains our custom data
            IDataObject dataObj = Clipboard.GetDataObject();

            if (HasGroupOnClipBoard())
            {
                Group group = dataObj.GetData("KeyPass::Group") as Group;
                //MessageBox.Show(group.GroupName + " has been copied (" + group.Keys.Count + " total keys)");

                // TODO: clone the group object and add to the tree again
                KeyPassMgr.CloneGroup(group);
            }
        }

        private bool HasGroupOnClipBoard()
        {
            return Clipboard.GetDataObject().GetDataPresent("KeyPass::Group");
        }

        bool _controlKeyPressed = false;
        private void OnKeyDown(object sender, KeyEventArgs e)
        {
            if (_controlKeyPressed && e.KeyCode == Keys.C && _ctxtCopy.Enabled)
                OnGroupCopy(sender, e);
            else if (_controlKeyPressed && e.KeyCode == Keys.V && _ctxtPaste.Enabled)
                OnGroupPaste(sender, e);
            else if (e.Control)
                _controlKeyPressed = true;
        }

        private void OnKeyUp(object sender, KeyEventArgs e)
        {
            _controlKeyPressed = false;
        }
    }
}

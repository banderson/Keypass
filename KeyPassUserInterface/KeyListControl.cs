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
    public partial class KeyListControl : UserControl
    {
        public KeyListControl()
        {
            InitializeComponent();
        }

        public void OnKeyAdd(object sender, EventArgs e)
        {
            if (ContextMgr.CurrentGroup == null)
            {
                MessageBox.Show("Please Select a Group.");
                return;
            }

            KeyPropertiesForm f = new KeyPropertiesForm(ContextMgr.CurrentGroup);
            using (f)
            {
                if (f.ShowDialog(this) == DialogResult.Cancel)
                    return;
            }

            GroupKeyMgr.AddKeyToGroup(f.Group, f.Key);

            //UpdateGrid(f.Key);
            ContextMgr.FireGroupSelected();
        }

        public void OnKeyEdit(object sender, EventArgs e)
        {
            KeyPropertiesForm f = new KeyPropertiesForm(ContextMgr.CurrentGroup, ContextMgr.CurrentKey);

            using (f)
            {
                if (f.ShowDialog(this) == DialogResult.Cancel)
                    return;
            }

            // save entries
            GroupKeyMgr.ModifyKey(f.Group, f.Key);

           // UpdateGrid(f.Key, true);
            ContextMgr.FireGroupSelected();
        }

        public void OnKeyDelete(object sender, EventArgs e)
        {
            var result = MessageBox.Show("This will delete all selected Keys. Are you sure?", "Confirm Delete Key(s)", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                foreach (var key in _lvwKeys.SelectedItems)
                {
                    var kk = (ListViewItem)key;
                    Key k = (Key)kk.Tag;
                    _lvwKeys.Items.Remove(kk);
                    GroupKeyMgr.DeleteKeyFromGroup(ContextMgr.CurrentGroup, k);
                }
            }
        }

        private void UpdateGrid(Key k, bool editMode = false)
        {
            ListViewItem lvi;

            if (!editMode)
            {
                lvi = _lvwKeys.Items.Add(k.Title); // returns the "row" object
                lvi.SubItems.Add(k.UserName); // add items to subitems for subsequent column values
                lvi.SubItems.Add(k.Password);
                lvi.SubItems.Add(k.Notes);
            }
            else
            {
                lvi = _lvwKeys.SelectedItems[0];
                lvi.Text = k.Title;
                lvi.SubItems[0].Text = k.Title;
                lvi.SubItems[1].Text = k.UserName;
                lvi.SubItems[2].Text = k.Password;
                lvi.SubItems[3].Text = k.Notes;
            }

            lvi.Tag = k;

            // resize the
            _lvwKeys.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
        }

        private void OnLoad(object sender, EventArgs e)
        {
            _lvwKeys.Columns.Add("Title");
            _lvwKeys.Columns.Add("Username");
            _lvwKeys.Columns.Add("Password");
            _lvwKeys.Columns.Add("Details");
            _lvwKeys.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);

            ContextMgr.GroupSelected += OnGroupSelected;

            Application.Idle += OnIdle;
        }

        void OnIdle(object sender, EventArgs e)
        { 
            _btnEdit.Enabled = !(ContextMgr.CurrentKey == null) && !ContextMgr.MultipleKeysSelected;
            _btnDelete.Enabled = !(ContextMgr.CurrentKey == null);
        }

        void OnGroupSelected(Group g)
        {
            _lvwKeys.Items.Clear();
            foreach (var key in GroupKeyMgr.GetKeysForGroup(g))
            {
                UpdateGrid(key);
            }
        }

        private void OnSelectKey(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            ContextMgr.SelectedKeys.Clear();

            foreach (ListViewItem lvi in _lvwKeys.SelectedItems)
            {
                ContextMgr.SelectedKeys.Add((Key)lvi.Tag);
            }

            ContextMgr.FireKeySelected();
        }
    }
}

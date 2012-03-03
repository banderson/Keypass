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

            KeyPropertiesForm f = new KeyPropertiesForm();
            using (f)
            {
                if (f.ShowDialog(this) == DialogResult.Cancel)
                    return;
            }

            Key key = SaveForm(f);

            UpdateGrid(key);
        }

        private Key SaveForm(KeyPropertiesForm f)
        {
            Key k;
            if (!f.IsEditMode) 
            {
                k = new Key();
            } else {
                k = ContextMgr.CurrentKey;
            }

            k.Title = f.Title;
            k.UserName = f.UserName;
            k.Password = f.Password;
            k.Notes = f.Notes;
            k.Url = f.Url;

            // add key to the collection linked to the group
            if (!f.IsEditMode) 
            {
                GroupKeyMgr.AddKeyToGroup(ContextMgr.CurrentGroup, k);
            }

            return k;
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
            } else {
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

        public void OnKeyEdit(object sender, EventArgs e)
        {
            KeyPropertiesForm f = new KeyPropertiesForm();
            
            if (ContextMgr.CurrentKey != null)
                f.IsEditMode = true;

            using (f)
            {
                if (f.ShowDialog(this) == DialogResult.Cancel)
                    return;
            }

            // save entries
            Key key = SaveForm(f);

            UpdateGrid(key, true);
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
            // this means more than one was selected
            if (_lvwKeys.SelectedItems.Count > 1)
                ContextMgr.MultipleKeysSelected = true;
            else
                ContextMgr.MultipleKeysSelected = false;

            if (_lvwKeys.SelectedItems.Count == 0)
                ContextMgr.CurrentKey = null;

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
            if (e.IsSelected)
                ContextMgr.CurrentKey = (Key)e.Item.Tag;
            
        }

        public void OnDeleteClick(object sender, EventArgs e)
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
    }
}

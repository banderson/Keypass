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
        bool _controlKeyPressed;

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

            KeyPassMgr.AddKey(f.Group, f.Key);

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
            KeyPassMgr.ModifyKey(f.Group, f.Key);

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
                    KeyPassMgr.DeleteKey(ContextMgr.CurrentGroup, k);
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

            KeyPassMgr.NewDocumentCreated += OnNewDocument;
            
            Application.Idle += OnIdle;
        }

        void OnIdle(object sender, EventArgs e)
        { 
            _btnEdit.Enabled = _ctxtEditKey.Enabled = !(ContextMgr.CurrentKey == null) && !ContextMgr.MultipleKeysSelected;
            _btnDelete.Enabled = _ctxtDeleteKey.Enabled = _ctxtCopy.Enabled = !(ContextMgr.CurrentKey == null);
        }

        void OnGroupSelected(Group g)
        {
            _lvwKeys.Items.Clear();
            foreach (var key in KeyPassMgr.GetKeysForGroup(g))
            {
                UpdateGrid(key);
            }
        }

        void OnNewDocument()
        {
            _lvwKeys.Items.Clear();
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



        private void OnKeyCopy(object sender, EventArgs e)
        {
            List<Key> keys = ContextMgr.SelectedKeys;
            DataObject dataObj = new DataObject();
            dataObj.SetData("KeyPass::Keys", keys);
            Clipboard.SetDataObject(dataObj, true);
        }

        private void OnKeyPaste(object sender, EventArgs e)
        {
            // First check if the clipboard contains our custom data
            IDataObject dataObj = Clipboard.GetDataObject();

            if (HasKeyOnClipBoard())
            {
                List<Key> keys = dataObj.GetData("KeyPass::Keys") as List<Key>;
                //MessageBox.Show(keys.Count + " keys have been copied");

                // clone the key object and add to the list
                foreach (var key in keys)
                {
                    KeyPassMgr.CloneKey(key);
                }
            }

            ContextMgr.FireGroupSelected();
        }

        private bool HasKeyOnClipBoard()
        {
            return Clipboard.GetDataObject().GetDataPresent("KeyPass::Keys");
        }

        private void OnRightClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                _ctxtDeleteKey.Enabled = _ctxtEditKey.Enabled = _ctxtCopy.Enabled = _lvwKeys.SelectedItems.Count > 0;
                _ctxtPaste.Enabled = HasKeyOnClipBoard();
                _contextMenuStrip.Show(_lvwKeys, e.X, e.Y);
            }
        }

        private void OnKeyDown(object sender, KeyEventArgs e)
        {
            if (_controlKeyPressed && e.KeyCode == Keys.C && _ctxtCopy.Enabled)
                OnKeyCopy(sender, e);
            else if (_controlKeyPressed && e.KeyCode == Keys.V && _ctxtPaste.Enabled)
                OnKeyPaste(sender, e);
            else if (e.Control)
                _controlKeyPressed = true;
        }

        private void OnKeyUp(object sender, KeyEventArgs e)
        {
            _controlKeyPressed = false;
        }
    }
}

﻿namespace KeyPassUserInterface
{
    partial class KeyListControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KeyListControl));
            this._toolBar = new System.Windows.Forms.ToolStrip();
            this._btnAdd = new System.Windows.Forms.ToolStripButton();
            this._btnEdit = new System.Windows.Forms.ToolStripButton();
            this._btnDelete = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this._btnFind = new System.Windows.Forms.ToolStripButton();
            this._txtSearch = new System.Windows.Forms.ToolStripTextBox();
            this._lvwKeys = new System.Windows.Forms.ListView();
            this._contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this._ctxtAddKey = new System.Windows.Forms.ToolStripMenuItem();
            this._ctxtEditKey = new System.Windows.Forms.ToolStripMenuItem();
            this._ctxtDeleteKey = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this._ctxtCopy = new System.Windows.Forms.ToolStripMenuItem();
            this._ctxtPaste = new System.Windows.Forms.ToolStripMenuItem();
            this._toolBar.SuspendLayout();
            this._contextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // _toolBar
            // 
            this._toolBar.ImageScalingSize = new System.Drawing.Size(32, 32);
            this._toolBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._btnAdd,
            this._btnEdit,
            this._btnDelete,
            this.toolStripSeparator1,
            this._btnFind,
            this._txtSearch});
            this._toolBar.Location = new System.Drawing.Point(0, 0);
            this._toolBar.Name = "_toolBar";
            this._toolBar.Size = new System.Drawing.Size(668, 39);
            this._toolBar.TabIndex = 0;
            this._toolBar.Text = "toolStrip1";
            // 
            // _btnAdd
            // 
            this._btnAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this._btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("_btnAdd.Image")));
            this._btnAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._btnAdd.Name = "_btnAdd";
            this._btnAdd.Size = new System.Drawing.Size(36, 36);
            this._btnAdd.Text = "&New";
            this._btnAdd.Click += new System.EventHandler(this.OnKeyAdd);
            // 
            // _btnEdit
            // 
            this._btnEdit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this._btnEdit.Image = ((System.Drawing.Image)(resources.GetObject("_btnEdit.Image")));
            this._btnEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._btnEdit.Name = "_btnEdit";
            this._btnEdit.Size = new System.Drawing.Size(36, 36);
            this._btnEdit.Text = "&Open";
            this._btnEdit.Click += new System.EventHandler(this.OnKeyEdit);
            // 
            // _btnDelete
            // 
            this._btnDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this._btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("_btnDelete.Image")));
            this._btnDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._btnDelete.Name = "_btnDelete";
            this._btnDelete.Size = new System.Drawing.Size(36, 36);
            this._btnDelete.Text = "&Save";
            this._btnDelete.Click += new System.EventHandler(this.OnKeyDelete);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 39);
            // 
            // _btnFind
            // 
            this._btnFind.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this._btnFind.Image = ((System.Drawing.Image)(resources.GetObject("_btnFind.Image")));
            this._btnFind.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._btnFind.Name = "_btnFind";
            this._btnFind.Size = new System.Drawing.Size(36, 36);
            this._btnFind.Text = "toolStripButton1";
            // 
            // _txtSearch
            // 
            this._txtSearch.Name = "_txtSearch";
            this._txtSearch.Size = new System.Drawing.Size(150, 39);
            // 
            // _lvwKeys
            // 
            this._lvwKeys.Dock = System.Windows.Forms.DockStyle.Fill;
            this._lvwKeys.FullRowSelect = true;
            this._lvwKeys.GridLines = true;
            this._lvwKeys.HideSelection = false;
            this._lvwKeys.Location = new System.Drawing.Point(0, 39);
            this._lvwKeys.Name = "_lvwKeys";
            this._lvwKeys.Size = new System.Drawing.Size(668, 347);
            this._lvwKeys.TabIndex = 1;
            this._lvwKeys.UseCompatibleStateImageBehavior = false;
            this._lvwKeys.View = System.Windows.Forms.View.Details;
            this._lvwKeys.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.OnSelectKey);
            this._lvwKeys.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OnKeyDown);
            this._lvwKeys.KeyUp += new System.Windows.Forms.KeyEventHandler(this.OnKeyUp);
            this._lvwKeys.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OnRightClick);
            // 
            // _contextMenuStrip
            // 
            this._contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._ctxtAddKey,
            this._ctxtEditKey,
            this._ctxtDeleteKey,
            this.toolStripMenuItem1,
            this._ctxtCopy,
            this._ctxtPaste});
            this._contextMenuStrip.Name = "_contextMenuStrip";
            this._contextMenuStrip.Size = new System.Drawing.Size(147, 120);
            // 
            // _ctxtAddKey
            // 
            this._ctxtAddKey.Name = "_ctxtAddKey";
            this._ctxtAddKey.Size = new System.Drawing.Size(152, 22);
            this._ctxtAddKey.Text = "Add Entry...";
            this._ctxtAddKey.Click += new System.EventHandler(this.OnKeyAdd);
            // 
            // _ctxtEditKey
            // 
            this._ctxtEditKey.Name = "_ctxtEditKey";
            this._ctxtEditKey.Size = new System.Drawing.Size(152, 22);
            this._ctxtEditKey.Text = "Edit Entry...";
            this._ctxtEditKey.Click += new System.EventHandler(this.OnKeyEdit);
            // 
            // _ctxtDeleteKey
            // 
            this._ctxtDeleteKey.Name = "_ctxtDeleteKey";
            this._ctxtDeleteKey.Size = new System.Drawing.Size(152, 22);
            this._ctxtDeleteKey.Text = "Delete Entry...";
            this._ctxtDeleteKey.Click += new System.EventHandler(this.OnKeyDelete);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(149, 6);
            // 
            // _ctxtCopy
            // 
            this._ctxtCopy.Name = "_ctxtCopy";
            this._ctxtCopy.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this._ctxtCopy.Size = new System.Drawing.Size(152, 22);
            this._ctxtCopy.Text = "Copy";
            this._ctxtCopy.Click += new System.EventHandler(this.OnKeyCopy);
            // 
            // _ctxtPaste
            // 
            this._ctxtPaste.Name = "_ctxtPaste";
            this._ctxtPaste.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this._ctxtPaste.Size = new System.Drawing.Size(152, 22);
            this._ctxtPaste.Text = "Paste";
            this._ctxtPaste.Click += new System.EventHandler(this.OnKeyPaste);
            // 
            // KeyListControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this._lvwKeys);
            this.Controls.Add(this._toolBar);
            this.Name = "KeyListControl";
            this.Size = new System.Drawing.Size(668, 386);
            this.Load += new System.EventHandler(this.OnLoad);
            this._toolBar.ResumeLayout(false);
            this._toolBar.PerformLayout();
            this._contextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip _toolBar;
        private System.Windows.Forms.ToolStripButton _btnAdd;
        private System.Windows.Forms.ToolStripButton _btnEdit;
        private System.Windows.Forms.ToolStripButton _btnDelete;
        private System.Windows.Forms.ListView _lvwKeys;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton _btnFind;
        private System.Windows.Forms.ToolStripTextBox _txtSearch;
        private System.Windows.Forms.ContextMenuStrip _contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem _ctxtAddKey;
        private System.Windows.Forms.ToolStripMenuItem _ctxtEditKey;
        private System.Windows.Forms.ToolStripMenuItem _ctxtDeleteKey;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem _ctxtCopy;
        private System.Windows.Forms.ToolStripMenuItem _ctxtPaste;
    }
}

namespace KeyPassUserInterface
{
    partial class GroupTreeControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GroupTreeControl));
            this._toolBar = new System.Windows.Forms.ToolStrip();
            this._btnNew = new System.Windows.Forms.ToolStripButton();
            this._btnEdit = new System.Windows.Forms.ToolStripButton();
            this._btnDelete = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this._tvwGroups = new System.Windows.Forms.TreeView();
            this._imgListIcons = new System.Windows.Forms.ImageList(this.components);
            this._contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this._ctxtAddGroup = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this._ctxtEditGroup = new System.Windows.Forms.ToolStripMenuItem();
            this._ctxtDeleteGroup = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this._ctxtCopy = new System.Windows.Forms.ToolStripMenuItem();
            this._ctxtPaste = new System.Windows.Forms.ToolStripMenuItem();
            this._toolBar.SuspendLayout();
            this._contextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // _toolBar
            // 
            this._toolBar.Dock = System.Windows.Forms.DockStyle.Left;
            this._toolBar.ImageScalingSize = new System.Drawing.Size(32, 32);
            this._toolBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._btnNew,
            this._btnEdit,
            this._btnDelete,
            this.toolStripSeparator});
            this._toolBar.Location = new System.Drawing.Point(0, 0);
            this._toolBar.Name = "_toolBar";
            this._toolBar.Size = new System.Drawing.Size(37, 495);
            this._toolBar.TabIndex = 0;
            this._toolBar.Text = "toolStrip1";
            // 
            // _btnNew
            // 
            this._btnNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this._btnNew.Image = ((System.Drawing.Image)(resources.GetObject("_btnNew.Image")));
            this._btnNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._btnNew.Name = "_btnNew";
            this._btnNew.Size = new System.Drawing.Size(34, 36);
            this._btnNew.Text = "&New";
            this._btnNew.Click += new System.EventHandler(this.OnGroupNew);
            // 
            // _btnEdit
            // 
            this._btnEdit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this._btnEdit.Image = ((System.Drawing.Image)(resources.GetObject("_btnEdit.Image")));
            this._btnEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._btnEdit.Name = "_btnEdit";
            this._btnEdit.Size = new System.Drawing.Size(34, 36);
            this._btnEdit.Text = "&Open";
            this._btnEdit.Click += new System.EventHandler(this.OnGroupEditClick);
            // 
            // _btnDelete
            // 
            this._btnDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this._btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("_btnDelete.Image")));
            this._btnDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._btnDelete.Name = "_btnDelete";
            this._btnDelete.Size = new System.Drawing.Size(34, 36);
            this._btnDelete.Text = "&Save";
            this._btnDelete.Click += new System.EventHandler(this.OnGroupDeleteClick);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(34, 6);
            // 
            // _tvwGroups
            // 
            this._tvwGroups.Dock = System.Windows.Forms.DockStyle.Fill;
            this._tvwGroups.HideSelection = false;
            this._tvwGroups.ImageIndex = 0;
            this._tvwGroups.ImageList = this._imgListIcons;
            this._tvwGroups.Location = new System.Drawing.Point(37, 0);
            this._tvwGroups.Name = "_tvwGroups";
            this._tvwGroups.SelectedImageIndex = 0;
            this._tvwGroups.Size = new System.Drawing.Size(182, 495);
            this._tvwGroups.TabIndex = 1;
            this._tvwGroups.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.OnGroupSelected);
            this._tvwGroups.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.OnGroupMouseDown);
            this._tvwGroups.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OnKeyDown);
            this._tvwGroups.KeyUp += new System.Windows.Forms.KeyEventHandler(this.OnKeyUp);
            this._tvwGroups.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OnRightClick);
            // 
            // _imgListIcons
            // 
            this._imgListIcons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("_imgListIcons.ImageStream")));
            this._imgListIcons.TransparentColor = System.Drawing.Color.Transparent;
            this._imgListIcons.Images.SetKeyName(0, "Lock.ico");
            this._imgListIcons.Images.SetKeyName(1, "Lock2.ico");
            // 
            // _contextMenuStrip
            // 
            this._contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._ctxtAddGroup,
            this.toolStripMenuItem1,
            this._ctxtEditGroup,
            this._ctxtDeleteGroup,
            this.toolStripMenuItem2,
            this._ctxtCopy,
            this._ctxtPaste});
            this._contextMenuStrip.Name = "_contextMenuStrip";
            this._contextMenuStrip.Size = new System.Drawing.Size(153, 126);
            // 
            // _ctxtAddGroup
            // 
            this._ctxtAddGroup.Name = "_ctxtAddGroup";
            this._ctxtAddGroup.Size = new System.Drawing.Size(152, 22);
            this._ctxtAddGroup.Text = "Add Group...";
            this._ctxtAddGroup.Click += new System.EventHandler(this.OnGroupNew);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(149, 6);
            // 
            // _ctxtEditGroup
            // 
            this._ctxtEditGroup.Name = "_ctxtEditGroup";
            this._ctxtEditGroup.Size = new System.Drawing.Size(152, 22);
            this._ctxtEditGroup.Text = "Edit Group...";
            this._ctxtEditGroup.Click += new System.EventHandler(this.OnGroupEditClick);
            // 
            // _ctxtDeleteGroup
            // 
            this._ctxtDeleteGroup.Name = "_ctxtDeleteGroup";
            this._ctxtDeleteGroup.Size = new System.Drawing.Size(152, 22);
            this._ctxtDeleteGroup.Text = "Delete Group...";
            this._ctxtDeleteGroup.Click += new System.EventHandler(this.OnGroupDeleteClick);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(149, 6);
            // 
            // _ctxtCopy
            // 
            this._ctxtCopy.Name = "_ctxtCopy";
            this._ctxtCopy.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this._ctxtCopy.Size = new System.Drawing.Size(152, 22);
            this._ctxtCopy.Text = "Copy";
            this._ctxtCopy.Click += new System.EventHandler(this.OnGroupCopy);
            // 
            // _ctxtPaste
            // 
            this._ctxtPaste.Name = "_ctxtPaste";
            this._ctxtPaste.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this._ctxtPaste.Size = new System.Drawing.Size(152, 22);
            this._ctxtPaste.Text = "Paste";
            this._ctxtPaste.Click += new System.EventHandler(this.OnGroupPaste);
            // 
            // GroupTreeControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this._tvwGroups);
            this.Controls.Add(this._toolBar);
            this.Name = "GroupTreeControl";
            this.Size = new System.Drawing.Size(219, 495);
            this.Load += new System.EventHandler(this.OnLoad);
            this._toolBar.ResumeLayout(false);
            this._toolBar.PerformLayout();
            this._contextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip _toolBar;
        private System.Windows.Forms.ToolStripButton _btnNew;
        private System.Windows.Forms.ToolStripButton _btnEdit;
        private System.Windows.Forms.ToolStripButton _btnDelete;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.TreeView _tvwGroups;
        private System.Windows.Forms.ImageList _imgListIcons;
        private System.Windows.Forms.ContextMenuStrip _contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem _ctxtAddGroup;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem _ctxtEditGroup;
        private System.Windows.Forms.ToolStripMenuItem _ctxtDeleteGroup;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem _ctxtCopy;
        private System.Windows.Forms.ToolStripMenuItem _ctxtPaste;
    }
}

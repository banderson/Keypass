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
            this._toolBar.SuspendLayout();
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
            // 
            // _imgListIcons
            // 
            this._imgListIcons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("_imgListIcons.ImageStream")));
            this._imgListIcons.TransparentColor = System.Drawing.Color.Transparent;
            this._imgListIcons.Images.SetKeyName(0, "Lock.ico");
            this._imgListIcons.Images.SetKeyName(1, "Lock2.ico");
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
    }
}

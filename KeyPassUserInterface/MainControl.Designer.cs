namespace KeyPassUserInterface
{
    partial class MainControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainControl));
            this._tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this._menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printPreviewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._menuAddGroup = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this._menuEditGroup = new System.Windows.Forms.ToolStripMenuItem();
            this._menuDeleteGroup = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this._menuAddKey = new System.Windows.Forms.ToolStripMenuItem();
            this._menuEditKey = new System.Windows.Forms.ToolStripMenuItem();
            this._menuDeleteKey = new System.Windows.Forms.ToolStripMenuItem();
            this._menuDuplicateKey = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.selectAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolBarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusBarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._toolStrip = new System.Windows.Forms.ToolStrip();
            this.newToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.openToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.saveToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.printToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.helpToolStripButton = new System.Windows.Forms.ToolStripButton();
            this._splitContainerVertical = new System.Windows.Forms.SplitContainer();
            this._trvGroups = new KeyPassUserInterface.GroupTreeControl();
            this._splitContainerHorizontal = new System.Windows.Forms.SplitContainer();
            this._lvwKeys = new KeyPassUserInterface.KeyListControl();
            this._rtbKeyDisplay = new System.Windows.Forms.RichTextBox();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this._statusStripControl = new KeyPassUserInterface.StatusStripControl();
            this._menuStrip.SuspendLayout();
            this._toolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._splitContainerVertical)).BeginInit();
            this._splitContainerVertical.Panel1.SuspendLayout();
            this._splitContainerVertical.Panel2.SuspendLayout();
            this._splitContainerVertical.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._splitContainerHorizontal)).BeginInit();
            this._splitContainerHorizontal.Panel1.SuspendLayout();
            this._splitContainerHorizontal.Panel2.SuspendLayout();
            this._splitContainerHorizontal.SuspendLayout();
            this.SuspendLayout();
            // 
            // _tableLayoutPanel
            // 
            this._tableLayoutPanel.ColumnCount = 2;
            this._tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this._tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this._tableLayoutPanel.Location = new System.Drawing.Point(163, 289);
            this._tableLayoutPanel.Name = "_tableLayoutPanel";
            this._tableLayoutPanel.RowCount = 2;
            this._tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this._tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this._tableLayoutPanel.Size = new System.Drawing.Size(0, 0);
            this._tableLayoutPanel.TabIndex = 0;
            // 
            // _menuStrip
            // 
            this._menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this._menuStrip.Location = new System.Drawing.Point(0, 0);
            this._menuStrip.Name = "_menuStrip";
            this._menuStrip.Size = new System.Drawing.Size(883, 24);
            this._menuStrip.TabIndex = 1;
            this._menuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.toolStripSeparator,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.toolStripSeparator1,
            this.printToolStripMenuItem,
            this.printPreviewToolStripMenuItem,
            this.toolStripSeparator2,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("newToolStripMenuItem.Image")));
            this.newToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.newToolStripMenuItem.Text = "New";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripMenuItem.Image")));
            this.openToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.openToolStripMenuItem.Text = "Open...";
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(140, 6);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripMenuItem.Image")));
            this.saveToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.saveAsToolStripMenuItem.Text = "Save As...";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(140, 6);
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("printToolStripMenuItem.Image")));
            this.printToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.printToolStripMenuItem.Text = "Print...";
            // 
            // printPreviewToolStripMenuItem
            // 
            this.printPreviewToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("printPreviewToolStripMenuItem.Image")));
            this.printPreviewToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.printPreviewToolStripMenuItem.Name = "printPreviewToolStripMenuItem";
            this.printPreviewToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.printPreviewToolStripMenuItem.Text = "Print Preview";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(140, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.OnExitClick);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._menuAddGroup,
            this.toolStripSeparator7,
            this._menuEditGroup,
            this._menuDeleteGroup,
            this.toolStripSeparator3,
            this._menuAddKey,
            this._menuEditKey,
            this._menuDeleteKey,
            this._menuDuplicateKey,
            this.toolStripSeparator4,
            this.selectAllToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "&Edit";
            // 
            // _menuAddGroup
            // 
            this._menuAddGroup.Image = ((System.Drawing.Image)(resources.GetObject("_menuAddGroup.Image")));
            this._menuAddGroup.Name = "_menuAddGroup";
            this._menuAddGroup.Size = new System.Drawing.Size(163, 22);
            this._menuAddGroup.Text = "Add Group...";
            this._menuAddGroup.Click += new System.EventHandler(this.OnAddGroupClick);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(160, 6);
            // 
            // _menuEditGroup
            // 
            this._menuEditGroup.Name = "_menuEditGroup";
            this._menuEditGroup.Size = new System.Drawing.Size(163, 22);
            this._menuEditGroup.Text = "Edit Group...";
            this._menuEditGroup.Click += new System.EventHandler(this.OnEditGroupClick);
            // 
            // _menuDeleteGroup
            // 
            this._menuDeleteGroup.Image = ((System.Drawing.Image)(resources.GetObject("_menuDeleteGroup.Image")));
            this._menuDeleteGroup.Name = "_menuDeleteGroup";
            this._menuDeleteGroup.Size = new System.Drawing.Size(163, 22);
            this._menuDeleteGroup.Text = "Delete Group...";
            this._menuDeleteGroup.Click += new System.EventHandler(this.OnDeleteGroupClick);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(160, 6);
            // 
            // _menuAddKey
            // 
            this._menuAddKey.Image = ((System.Drawing.Image)(resources.GetObject("_menuAddKey.Image")));
            this._menuAddKey.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._menuAddKey.Name = "_menuAddKey";
            this._menuAddKey.Size = new System.Drawing.Size(163, 22);
            this._menuAddKey.Text = "Add Entry...";
            this._menuAddKey.Click += new System.EventHandler(this.OnKeyAddMenuClick);
            // 
            // _menuEditKey
            // 
            this._menuEditKey.Image = ((System.Drawing.Image)(resources.GetObject("_menuEditKey.Image")));
            this._menuEditKey.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._menuEditKey.Name = "_menuEditKey";
            this._menuEditKey.Size = new System.Drawing.Size(163, 22);
            this._menuEditKey.Text = "Edit Entry...";
            this._menuEditKey.Click += new System.EventHandler(this.OnKeyEditMenuClick);
            // 
            // _menuDeleteKey
            // 
            this._menuDeleteKey.Image = ((System.Drawing.Image)(resources.GetObject("_menuDeleteKey.Image")));
            this._menuDeleteKey.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._menuDeleteKey.Name = "_menuDeleteKey";
            this._menuDeleteKey.Size = new System.Drawing.Size(163, 22);
            this._menuDeleteKey.Text = "Delete Entry...";
            this._menuDeleteKey.Click += new System.EventHandler(this.OnKeyDeleteMenuClick);
            // 
            // _menuDuplicateKey
            // 
            this._menuDuplicateKey.Image = ((System.Drawing.Image)(resources.GetObject("_menuDuplicateKey.Image")));
            this._menuDuplicateKey.Name = "_menuDuplicateKey";
            this._menuDuplicateKey.Size = new System.Drawing.Size(163, 22);
            this._menuDuplicateKey.Text = "Duplicate Entry...";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(160, 6);
            // 
            // selectAllToolStripMenuItem
            // 
            this.selectAllToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("selectAllToolStripMenuItem.Image")));
            this.selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
            this.selectAllToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.selectAllToolStripMenuItem.Text = "Find...";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolBarToolStripMenuItem,
            this.statusBarToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // toolBarToolStripMenuItem
            // 
            this.toolBarToolStripMenuItem.Checked = true;
            this.toolBarToolStripMenuItem.CheckOnClick = true;
            this.toolBarToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toolBarToolStripMenuItem.Name = "toolBarToolStripMenuItem";
            this.toolBarToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.toolBarToolStripMenuItem.Text = "Tool Bar";
            this.toolBarToolStripMenuItem.CheckedChanged += new System.EventHandler(this.OnToolBarToggle);
            // 
            // statusBarToolStripMenuItem
            // 
            this.statusBarToolStripMenuItem.Checked = true;
            this.statusBarToolStripMenuItem.CheckOnClick = true;
            this.statusBarToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.statusBarToolStripMenuItem.Name = "statusBarToolStripMenuItem";
            this.statusBarToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.statusBarToolStripMenuItem.Text = "Status Bar";
            this.statusBarToolStripMenuItem.CheckedChanged += new System.EventHandler(this.OnStatusBarToggle);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.customizeToolStripMenuItem,
            this.optionsToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.toolsToolStripMenuItem.Text = "&Tools";
            // 
            // customizeToolStripMenuItem
            // 
            this.customizeToolStripMenuItem.Name = "customizeToolStripMenuItem";
            this.customizeToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.customizeToolStripMenuItem.Text = "Customize...";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("optionsToolStripMenuItem.Image")));
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.optionsToolStripMenuItem.Text = "Options...";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contentsToolStripMenuItem,
            this.toolStripSeparator5,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // contentsToolStripMenuItem
            // 
            this.contentsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("contentsToolStripMenuItem.Image")));
            this.contentsToolStripMenuItem.Name = "contentsToolStripMenuItem";
            this.contentsToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.contentsToolStripMenuItem.Text = "&Contents";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(119, 6);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("aboutToolStripMenuItem.Image")));
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.aboutToolStripMenuItem.Text = "&About...";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.OnAboutForm);
            // 
            // _toolStrip
            // 
            this._toolStrip.ImageScalingSize = new System.Drawing.Size(32, 32);
            this._toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripButton,
            this.openToolStripButton,
            this.saveToolStripButton,
            this.printToolStripButton,
            this.toolStripSeparator6,
            this.helpToolStripButton});
            this._toolStrip.Location = new System.Drawing.Point(0, 24);
            this._toolStrip.Name = "_toolStrip";
            this._toolStrip.Size = new System.Drawing.Size(883, 39);
            this._toolStrip.TabIndex = 2;
            this._toolStrip.Text = "toolStrip1";
            // 
            // newToolStripButton
            // 
            this.newToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.newToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("newToolStripButton.Image")));
            this.newToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newToolStripButton.Name = "newToolStripButton";
            this.newToolStripButton.Size = new System.Drawing.Size(36, 36);
            this.newToolStripButton.Text = "&New";
            this.newToolStripButton.Click += new System.EventHandler(this.OnNewDocument);
            // 
            // openToolStripButton
            // 
            this.openToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.openToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripButton.Image")));
            this.openToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openToolStripButton.Name = "openToolStripButton";
            this.openToolStripButton.Size = new System.Drawing.Size(36, 36);
            this.openToolStripButton.Text = "&Open";
            // 
            // saveToolStripButton
            // 
            this.saveToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.saveToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripButton.Image")));
            this.saveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripButton.Name = "saveToolStripButton";
            this.saveToolStripButton.Size = new System.Drawing.Size(36, 36);
            this.saveToolStripButton.Text = "&Save";
            // 
            // printToolStripButton
            // 
            this.printToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.printToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("printToolStripButton.Image")));
            this.printToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.printToolStripButton.Name = "printToolStripButton";
            this.printToolStripButton.Size = new System.Drawing.Size(36, 36);
            this.printToolStripButton.Text = "&Print";
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 39);
            // 
            // helpToolStripButton
            // 
            this.helpToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.helpToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("helpToolStripButton.Image")));
            this.helpToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.helpToolStripButton.Name = "helpToolStripButton";
            this.helpToolStripButton.Size = new System.Drawing.Size(36, 36);
            this.helpToolStripButton.Text = "He&lp";
            this.helpToolStripButton.Click += new System.EventHandler(this.OnAboutForm);
            // 
            // _splitContainerVertical
            // 
            this._splitContainerVertical.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this._splitContainerVertical.Dock = System.Windows.Forms.DockStyle.Fill;
            this._splitContainerVertical.Location = new System.Drawing.Point(0, 63);
            this._splitContainerVertical.Name = "_splitContainerVertical";
            // 
            // _splitContainerVertical.Panel1
            // 
            this._splitContainerVertical.Panel1.Controls.Add(this._trvGroups);
            // 
            // _splitContainerVertical.Panel2
            // 
            this._splitContainerVertical.Panel2.Controls.Add(this._splitContainerHorizontal);
            this._splitContainerVertical.Size = new System.Drawing.Size(883, 457);
            this._splitContainerVertical.SplitterDistance = 293;
            this._splitContainerVertical.TabIndex = 5;
            // 
            // _trvGroups
            // 
            this._trvGroups.Dock = System.Windows.Forms.DockStyle.Fill;
            this._trvGroups.Location = new System.Drawing.Point(0, 0);
            this._trvGroups.Name = "_trvGroups";
            this._trvGroups.Size = new System.Drawing.Size(289, 453);
            this._trvGroups.TabIndex = 0;
            // 
            // _splitContainerHorizontal
            // 
            this._splitContainerHorizontal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this._splitContainerHorizontal.Dock = System.Windows.Forms.DockStyle.Fill;
            this._splitContainerHorizontal.Location = new System.Drawing.Point(0, 0);
            this._splitContainerHorizontal.Name = "_splitContainerHorizontal";
            this._splitContainerHorizontal.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // _splitContainerHorizontal.Panel1
            // 
            this._splitContainerHorizontal.Panel1.Controls.Add(this._lvwKeys);
            // 
            // _splitContainerHorizontal.Panel2
            // 
            this._splitContainerHorizontal.Panel2.Controls.Add(this._rtbKeyDisplay);
            this._splitContainerHorizontal.Size = new System.Drawing.Size(586, 457);
            this._splitContainerHorizontal.SplitterDistance = 322;
            this._splitContainerHorizontal.TabIndex = 0;
            // 
            // _lvwKeys
            // 
            this._lvwKeys.Dock = System.Windows.Forms.DockStyle.Fill;
            this._lvwKeys.Location = new System.Drawing.Point(0, 0);
            this._lvwKeys.Name = "_lvwKeys";
            this._lvwKeys.Size = new System.Drawing.Size(582, 318);
            this._lvwKeys.TabIndex = 0;
            this._lvwKeys.Load += new System.EventHandler(this.OnLoad);
            // 
            // _rtbKeyDisplay
            // 
            this._rtbKeyDisplay.Dock = System.Windows.Forms.DockStyle.Fill;
            this._rtbKeyDisplay.Location = new System.Drawing.Point(0, 0);
            this._rtbKeyDisplay.Name = "_rtbKeyDisplay";
            this._rtbKeyDisplay.Size = new System.Drawing.Size(582, 127);
            this._rtbKeyDisplay.TabIndex = 0;
            this._rtbKeyDisplay.Text = "";
            // 
            // _statusStripControl
            // 
            this._statusStripControl.BackColor = System.Drawing.SystemColors.Control;
            this._statusStripControl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this._statusStripControl.Location = new System.Drawing.Point(0, 520);
            this._statusStripControl.Name = "_statusStripControl";
            this._statusStripControl.Size = new System.Drawing.Size(883, 25);
            this._statusStripControl.TabIndex = 4;
            // 
            // MainControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this._splitContainerVertical);
            this.Controls.Add(this._statusStripControl);
            this.Controls.Add(this._toolStrip);
            this.Controls.Add(this._tableLayoutPanel);
            this.Controls.Add(this._menuStrip);
            this.Name = "MainControl";
            this.Size = new System.Drawing.Size(883, 545);
            this._menuStrip.ResumeLayout(false);
            this._menuStrip.PerformLayout();
            this._toolStrip.ResumeLayout(false);
            this._toolStrip.PerformLayout();
            this._splitContainerVertical.Panel1.ResumeLayout(false);
            this._splitContainerVertical.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._splitContainerVertical)).EndInit();
            this._splitContainerVertical.ResumeLayout(false);
            this._splitContainerHorizontal.Panel1.ResumeLayout(false);
            this._splitContainerHorizontal.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._splitContainerHorizontal)).EndInit();
            this._splitContainerHorizontal.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel _tableLayoutPanel;
        private System.Windows.Forms.MenuStrip _menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printPreviewToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem _menuEditGroup;
        private System.Windows.Forms.ToolStripMenuItem _menuDeleteGroup;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem _menuAddKey;
        private System.Windows.Forms.ToolStripMenuItem _menuEditKey;
        private System.Windows.Forms.ToolStripMenuItem _menuDeleteKey;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem selectAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customizeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStrip _toolStrip;
        private System.Windows.Forms.ToolStripButton newToolStripButton;
        private System.Windows.Forms.ToolStripButton openToolStripButton;
        private System.Windows.Forms.ToolStripButton saveToolStripButton;
        private System.Windows.Forms.ToolStripButton printToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripButton helpToolStripButton;
        private System.Windows.Forms.SplitContainer _splitContainerVertical;
        private System.Windows.Forms.SplitContainer _splitContainerHorizontal;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolBarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem statusBarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem _menuAddGroup;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripMenuItem _menuDuplicateKey;
        private StatusStripControl _statusStripControl;
        private GroupTreeControl _trvGroups;
        private KeyListControl _lvwKeys;
        private System.Windows.Forms.HelpProvider helpProvider1;
        private System.Windows.Forms.RichTextBox _rtbKeyDisplay;
    }
}

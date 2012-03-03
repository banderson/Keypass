namespace KeyPassUserInterface
{
    partial class StatusStripControl
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
            this._keysLabel = new System.Windows.Forms.Label();
            this._groupsLabel = new System.Windows.Forms.Label();
            this._comboBox = new System.Windows.Forms.ComboBox();
            this._tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this._clock = new KeyPassUserInterface.ClockControl();
            this._tableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this._keysLabel.AutoSize = true;
            this._keysLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._keysLabel.Location = new System.Drawing.Point(439, 0);
            this._keysLabel.Name = "label1";
            this._keysLabel.Size = new System.Drawing.Size(103, 27);
            this._keysLabel.TabIndex = 0;
            this._keysLabel.Text = "X of Y selected keys.";
            this._keysLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this._groupsLabel.AutoSize = true;
            this._groupsLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._groupsLabel.Location = new System.Drawing.Point(367, 0);
            this._groupsLabel.Name = "label2";
            this._groupsLabel.Size = new System.Drawing.Size(66, 27);
            this._groupsLabel.TabIndex = 1;
            this._groupsLabel.Text = "Total Groups";
            this._groupsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBox1
            // 
            this._comboBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this._comboBox.FormattingEnabled = true;
            this._comboBox.ItemHeight = 13;
            this._comboBox.Items.AddRange(new object[] {
            "Test"});
            this._comboBox.Location = new System.Drawing.Point(3, 3);
            this._comboBox.Name = "comboBox1";
            this._comboBox.Size = new System.Drawing.Size(358, 21);
            this._comboBox.TabIndex = 2;
            // 
            // tableLayoutPanel1
            // 
            this._tableLayoutPanel.ColumnCount = 4;
            this._tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this._tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this._tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this._tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this._tableLayoutPanel.Controls.Add(this._keysLabel, 2, 0);
            this._tableLayoutPanel.Controls.Add(this._groupsLabel, 1, 0);
            this._tableLayoutPanel.Controls.Add(this._clock, 3, 0);
            this._tableLayoutPanel.Controls.Add(this._comboBox, 0, 0);
            this._tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this._tableLayoutPanel.Name = "tableLayoutPanel1";
            this._tableLayoutPanel.RowCount = 1;
            this._tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this._tableLayoutPanel.Size = new System.Drawing.Size(728, 25);
            this._tableLayoutPanel.TabIndex = 3;
            // 
            // clockControl1
            // 
            this._clock.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this._clock.AutoSize = true;
            this._clock.Location = new System.Drawing.Point(548, 3);
            this._clock.Name = "clockControl1";
            this._clock.Size = new System.Drawing.Size(177, 21);
            this._clock.TabIndex = 3;
            // 
            // StatusStripControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this._tableLayoutPanel);
            this.Name = "StatusStripControl";
            this.Size = new System.Drawing.Size(728, 25);
            this._tableLayoutPanel.ResumeLayout(false);
            this._tableLayoutPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label _keysLabel;
        private System.Windows.Forms.Label _groupsLabel;
        private System.Windows.Forms.ComboBox _comboBox;
        private System.Windows.Forms.TableLayoutPanel _tableLayoutPanel;
        private ClockControl _clock;
    }
}

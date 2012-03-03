namespace KeyPassUserInterface
{
    partial class ClockControl
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
            this._clockLabel = new System.Windows.Forms.Label();
            this._timer = new System.Windows.Forms.Timer(this.components);
            this._tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this._tableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this._clockLabel.AutoSize = true;
            this._clockLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._clockLabel.Location = new System.Drawing.Point(3, 0);
            this._clockLabel.Name = "label1";
            this._clockLabel.Size = new System.Drawing.Size(235, 58);
            this._clockLabel.TabIndex = 0;
            this._clockLabel.Text = "[current date/time]";
            this._clockLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this._timer.Enabled = true;
            this._timer.Interval = 1000;
            this._timer.Tick += new System.EventHandler(this.OnTimerTick);
            // 
            // tableLayoutPanel1
            // 
            this._tableLayoutPanel.AutoSize = true;
            this._tableLayoutPanel.ColumnCount = 1;
            this._tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this._tableLayoutPanel.Controls.Add(this._clockLabel, 0, 0);
            this._tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this._tableLayoutPanel.Name = "tableLayoutPanel1";
            this._tableLayoutPanel.RowCount = 1;
            this._tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this._tableLayoutPanel.Size = new System.Drawing.Size(241, 58);
            this._tableLayoutPanel.TabIndex = 1;
            // 
            // ClockControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this._tableLayoutPanel);
            this.Name = "ClockControl";
            this.Size = new System.Drawing.Size(241, 58);
            this.Load += new System.EventHandler(this.OnLoad);
            this._tableLayoutPanel.ResumeLayout(false);
            this._tableLayoutPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label _clockLabel;
        private System.Windows.Forms.Timer _timer;
        private System.Windows.Forms.TableLayoutPanel _tableLayoutPanel;
    }
}

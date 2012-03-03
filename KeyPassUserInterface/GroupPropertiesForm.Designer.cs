namespace KeyPassUserInterface
{
    partial class GroupPropertiesForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this._tblLytForm = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this._btnCancel = new System.Windows.Forms.Button();
            this._btnOkay = new System.Windows.Forms.Button();
            this._btnGenRandom = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this._txtGroupName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this._tblLytForm.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // _tblLytForm
            // 
            this._tblLytForm.ColumnCount = 1;
            this._tblLytForm.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this._tblLytForm.Controls.Add(this.tableLayoutPanel1, 0, 1);
            this._tblLytForm.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this._tblLytForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this._tblLytForm.Location = new System.Drawing.Point(0, 0);
            this._tblLytForm.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this._tblLytForm.Name = "_tblLytForm";
            this._tblLytForm.RowCount = 2;
            this._tblLytForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this._tblLytForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 58F));
            this._tblLytForm.Size = new System.Drawing.Size(506, 98);
            this._tblLytForm.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tableLayoutPanel1.Controls.Add(this._btnCancel, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this._btnOkay, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this._btnGenRandom, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 44);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(500, 50);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // _btnCancel
            // 
            this._btnCancel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._btnCancel.Location = new System.Drawing.Point(338, 4);
            this._btnCancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this._btnCancel.Name = "_btnCancel";
            this._btnCancel.Size = new System.Drawing.Size(159, 42);
            this._btnCancel.TabIndex = 0;
            this._btnCancel.Text = "Cancel";
            this._btnCancel.UseVisualStyleBackColor = true;
            this._btnCancel.Click += new System.EventHandler(this.OnCancel);
            // 
            // _btnOkay
            // 
            this._btnOkay.Dock = System.Windows.Forms.DockStyle.Fill;
            this._btnOkay.Location = new System.Drawing.Point(168, 4);
            this._btnOkay.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this._btnOkay.Name = "_btnOkay";
            this._btnOkay.Size = new System.Drawing.Size(164, 42);
            this._btnOkay.TabIndex = 1;
            this._btnOkay.Text = "OK";
            this._btnOkay.UseVisualStyleBackColor = true;
            this._btnOkay.Click += new System.EventHandler(this.OnOK);
            // 
            // _btnGenRandom
            // 
            this._btnGenRandom.Dock = System.Windows.Forms.DockStyle.Fill;
            this._btnGenRandom.Location = new System.Drawing.Point(3, 3);
            this._btnGenRandom.Name = "_btnGenRandom";
            this._btnGenRandom.Size = new System.Drawing.Size(159, 44);
            this._btnGenRandom.TabIndex = 2;
            this._btnGenRandom.Text = "Test";
            this._btnGenRandom.UseVisualStyleBackColor = true;
            this._btnGenRandom.Click += new System.EventHandler(this.OnTestClick);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.05343F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 76.94656F));
            this.tableLayoutPanel2.Controls.Add(this._txtGroupName, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(500, 34);
            this.tableLayoutPanel2.TabIndex = 4;
            // 
            // _txtGroupName
            // 
            this._txtGroupName.Dock = System.Windows.Forms.DockStyle.Fill;
            this._txtGroupName.Location = new System.Drawing.Point(118, 3);
            this._txtGroupName.Name = "_txtGroupName";
            this._txtGroupName.Size = new System.Drawing.Size(379, 25);
            this._txtGroupName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 34);
            this.label1.TabIndex = 1;
            this.label1.Text = "Group Name:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GroupPropertiesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 98);
            this.Controls.Add(this._tblLytForm);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "GroupPropertiesForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Group";
            this.Load += new System.EventHandler(this.GroupPropertiesForm_Load);
            this._tblLytForm.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel _tblLytForm;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button _btnCancel;
        private System.Windows.Forms.Button _btnOkay;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TextBox _txtGroupName;
        private System.Windows.Forms.Button _btnGenRandom;
        private System.Windows.Forms.Label label1;
    }
}
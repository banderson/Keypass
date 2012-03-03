namespace KeyPassUserInterface
{
    partial class AboutForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutForm));
            this._logoImage = new System.Windows.Forms.PictureBox();
            this._aboutProductText = new System.Windows.Forms.TextBox();
            this._productNameLabel = new System.Windows.Forms.Label();
            this._productVersionLabel = new System.Windows.Forms.Label();
            this._companyNameLabel = new System.Windows.Forms.Label();
            this._aboutProductLabel = new System.Windows.Forms.Label();
            this._copyrightLabel = new System.Windows.Forms.Label();
            this._okButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this._logoImage)).BeginInit();
            this.SuspendLayout();
            // 
            // _logoImage
            // 
            this._logoImage.Image = ((System.Drawing.Image)(resources.GetObject("_logoImage.Image")));
            this._logoImage.Location = new System.Drawing.Point(12, 12);
            this._logoImage.Name = "_logoImage";
            this._logoImage.Size = new System.Drawing.Size(110, 317);
            this._logoImage.TabIndex = 0;
            this._logoImage.TabStop = false;
            // 
            // _aboutProductText
            // 
            this._aboutProductText.Enabled = false;
            this._aboutProductText.Location = new System.Drawing.Point(145, 139);
            this._aboutProductText.Multiline = true;
            this._aboutProductText.Name = "_aboutProductText";
            this._aboutProductText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this._aboutProductText.Size = new System.Drawing.Size(251, 149);
            this._aboutProductText.TabIndex = 1;
            // 
            // _productNameLabel
            // 
            this._productNameLabel.AutoSize = true;
            this._productNameLabel.Location = new System.Drawing.Point(142, 12);
            this._productNameLabel.Name = "_productNameLabel";
            this._productNameLabel.Size = new System.Drawing.Size(75, 13);
            this._productNameLabel.TabIndex = 2;
            this._productNameLabel.Text = "Product Name";
            // 
            // _productVersionLabel
            // 
            this._productVersionLabel.AutoSize = true;
            this._productVersionLabel.Location = new System.Drawing.Point(142, 35);
            this._productVersionLabel.Name = "_productVersionLabel";
            this._productVersionLabel.Size = new System.Drawing.Size(82, 13);
            this._productVersionLabel.TabIndex = 3;
            this._productVersionLabel.Text = "Product Version";
            // 
            // _companyNameLabel
            // 
            this._companyNameLabel.AutoSize = true;
            this._companyNameLabel.Location = new System.Drawing.Point(142, 87);
            this._companyNameLabel.Name = "_companyNameLabel";
            this._companyNameLabel.Size = new System.Drawing.Size(82, 13);
            this._companyNameLabel.TabIndex = 4;
            this._companyNameLabel.Text = "Company Name";
            // 
            // _aboutProductLabel
            // 
            this._aboutProductLabel.AutoSize = true;
            this._aboutProductLabel.Location = new System.Drawing.Point(142, 123);
            this._aboutProductLabel.Name = "_aboutProductLabel";
            this._aboutProductLabel.Size = new System.Drawing.Size(78, 13);
            this._aboutProductLabel.TabIndex = 5;
            this._aboutProductLabel.Text = "About Product:";
            // 
            // _copyrightLabel
            // 
            this._copyrightLabel.AutoSize = true;
            this._copyrightLabel.Location = new System.Drawing.Point(142, 65);
            this._copyrightLabel.Name = "_copyrightLabel";
            this._copyrightLabel.Size = new System.Drawing.Size(51, 13);
            this._copyrightLabel.TabIndex = 6;
            this._copyrightLabel.Text = "Copyright";
            // 
            // _okButton
            // 
            this._okButton.Location = new System.Drawing.Point(321, 304);
            this._okButton.Name = "_okButton";
            this._okButton.Size = new System.Drawing.Size(75, 23);
            this._okButton.TabIndex = 7;
            this._okButton.Text = "OK";
            this._okButton.UseVisualStyleBackColor = true;
            this._okButton.Click += new System.EventHandler(this.OnOkButtonClick);
            // 
            // AboutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 339);
            this.Controls.Add(this._okButton);
            this.Controls.Add(this._copyrightLabel);
            this.Controls.Add(this._aboutProductLabel);
            this.Controls.Add(this._companyNameLabel);
            this.Controls.Add(this._productVersionLabel);
            this.Controls.Add(this._productNameLabel);
            this.Controls.Add(this._aboutProductText);
            this.Controls.Add(this._logoImage);
            this.Name = "AboutForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "My Key Pass";
            this.Load += new System.EventHandler(this.OnAboutFormLoad);
            ((System.ComponentModel.ISupportInitialize)(this._logoImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox _logoImage;
        private System.Windows.Forms.TextBox _aboutProductText;
        private System.Windows.Forms.Label _productNameLabel;
        private System.Windows.Forms.Label _productVersionLabel;
        private System.Windows.Forms.Label _companyNameLabel;
        private System.Windows.Forms.Label _aboutProductLabel;
        private System.Windows.Forms.Label _copyrightLabel;
        private System.Windows.Forms.Button _okButton;
    }
}
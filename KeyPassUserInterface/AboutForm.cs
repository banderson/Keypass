using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using KeyPassBusiness;

namespace KeyPassUserInterface
{
    public partial class AboutForm : Form
    {
        public AboutForm()
        {
            InitializeComponent();
        }

        private void OnAboutFormLoad(object sender, EventArgs e)
        {
            _productNameLabel.Text = MyCompany.ProductName;
            _productVersionLabel.Text = "Version: " + MyCompany.ProductVersion;
            _copyrightLabel.Text = "© " + MyCompany.ProductAuthor;
            _companyNameLabel.Text = MyCompany.Name;
            _aboutProductLabel.Text = "About " + MyCompany.ProductName;
            _aboutProductText.Text = MyCompany.ProductDescription;
            _aboutProductText.ReadOnly = true;
        }

        private void OnOkButtonClick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

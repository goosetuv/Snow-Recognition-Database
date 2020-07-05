using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace SRD.Forms
{
    public partial class FrmAbout : Form
    {
        public FrmAbout()
        {
            InitializeComponent();
        }

        private void FrmAbout_Load(object sender, EventArgs e)
        {
            lblAppName.Text = Application.ProductName;
            lblAppVersion.Text = string.Format("Version: {0}", Application.ProductVersion);
            lblAppCopyright.Text = "Copyright © Laim McKenzie 2020";
        }

        private void linkDeveloperLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://laim.scot");
        }
    }
}

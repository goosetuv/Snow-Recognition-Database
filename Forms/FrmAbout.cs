#region Dependencies
using System;
using System.Windows.Forms;
#endregion

namespace SRD.Forms
{
    public partial class FrmAbout : Form
    {
        #region Constructor
        public FrmAbout()
        {
            InitializeComponent();
        }
        #endregion

        #region Events
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
        #endregion
    }
}

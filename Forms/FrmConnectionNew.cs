using Laim;
using System;
using System.IO;
using System.Drawing;
using System.Windows.Forms;

namespace SRD.Forms
{
    public partial class FrmConnectionNew : Form
    {
        private string SqlConnectionString = "";
        public FrmConnectionNew()
        {
            InitializeComponent();
        }

        private void rbWindowsAuth_CheckedChanged(object sender, EventArgs e)
        {
            AuthenticationMethod();
        }

        private void AuthenticationMethod()
        {
            if (rbWindowsAuth.Checked == true)
            {
                txtSqlPassword.Visible = false;
                txtSqlUsername.Visible = false;
                lblSqlUsername.Visible = false;
                lblSqlPassword.Visible = false;
                Size = new Size(239, 275);
            }
            else
            {
                txtSqlPassword.Visible = true;
                txtSqlUsername.Visible = true;
                lblSqlUsername.Visible = true;
                lblSqlPassword.Visible = true;
                Size = new Size(239, 353);
            }
            this.CenterToParent(); //really ghetto but it works
        }

        private void FrmConnectionNew_Load(object sender, EventArgs e)
        {
            AuthenticationMethod();
            
            try
            {
                foreach (var i in MSSqlServer.GetServerList())
                {
                    cbSqlServer.Items.Add(i);
                }
            } catch
            {
                // do nothing
            }
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            try
            {
                if(cbSqlServer.Text.Length > 0 || txtSqlPassword.Text.Length > 0 || txtSqlUsername.Text.Length > 0)
                {
                    bool ConnectionStatus = false;

                    if (rbWindowsAuth.Checked == true)
                    { SqlConnectionString = "Data Source=" + cbSqlServer.Text + ";Application Name=SRD;Integrated Security=SSPI" + txtSqlParameters.Text; }
                    else
                    { SqlConnectionString = "Data Source=" + cbSqlServer.Text + ";Application Name=SRD;User=" + txtSqlUsername.Text + ";Password=" + txtSqlPassword.Text + txtSqlParameters.Text; }

                    if (MSSqlServer.CheckConnnection(SqlConnectionString) == true)
                    { MessageBox.Show("Connection Successful", "Connection Test", MessageBoxButtons.OK, MessageBoxIcon.Information); ConnectionStatus = true; }
                    else
                    { MessageBox.Show("Connection Unsuccessful", "Connection Test", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); ConnectionStatus = false; }

                    if (ConnectionStatus == true) { btnSave.Enabled = true; }
                } else
                {
                    MessageBox.Show("One of the required fields are empty.", "New Connection", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                string[] nl = { "SqlConnectionString", "CreatedBy", "CreatedDate"};
                string[] vl = { Kryptos.Encrypt(SqlConnectionString, Kryptos.GetHardwareID()), Environment.UserName, DateTime.Now.ToString("F")};

                XmlConfigurator.Write("Connections\\" + txtConnectionName.Text + ".config", nl, vl);
                if(File.Exists("Connections\\" + txtConnectionName.Text + ".config"))
                {
                    MessageBox.Show("Connection Saved", "New Connection", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

using Laim;
using System;
using System.IO;
using System.Windows.Forms;

namespace SRD.Forms
{
    public partial class FrmStartup : Form
    {

        public FrmStartup()
        {
            InitializeComponent();
        }

        private void FrmStartup_Load(object sender, EventArgs e)
        {
            try
            {
                CreateDirectories();
                if (cbConnectionList.SelectedIndex < 0)
                {
                    btnStartProgram.Enabled = false;
                }
                RefreshConnectionList();
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void CreateDirectories()
        {
            string[] directories = { "Connections", "Data\\Exports" };

            foreach(var i in directories)
            {
                if (Directory.Exists(i) == false)
                {
                    Directory.CreateDirectory(i);
                }
            }
        }

        void RefreshConnectionList()
        {
            foreach (var i in Directory.GetFiles("Connections"))
            {
                string FileName = Path.GetFileNameWithoutExtension(i);
                if (cbConnectionList.Items.Contains(FileName) == false)
                {
                    cbConnectionList.Items.Add(Path.GetFileNameWithoutExtension(i));
                }
            }
        }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Code Quality", "IDE0067:Dispose objects before losing scope", Justification = "<Pending>")]
        private void btnStartProgram_Click(object sender, EventArgs e)
        {
            try
            {
                if(File.Exists(Local.AppConfig))
                {
                    FrmMain frm = new FrmMain
                    {
                        SqlConnection = Kryptos.Decrypt(XmlConfigurator.Read("Connections\\" + cbConnectionList.Text + ".config", "SqlConnectionString"), Kryptos.GetHardwareID())
                    };
                    frm.Show();
                    Hide();
                } else
                {
                    FrmSettings frm = new FrmSettings();
                    using (frm)
                    {
                        frm.FirstStart = true;
                        frm.ShowDialog();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Uncaught Exception", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void cbConnectionList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbConnectionList.SelectedIndex > -1)
            {
                btnStartProgram.Enabled = true;
            }
        }

        private void btnNewConnection_Click(object sender, EventArgs e)
        {
            Form newConnection = new FrmConnectionNew();
            using (newConnection)
            {
                newConnection.ShowDialog(this);
            }
        }

        private void FrmStartup_Closing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void pbLogo_Click(object sender, EventArgs e)
        {
            RefreshConnectionList();
            MessageBox.Show("Connection List refreshed", "Connection List", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}

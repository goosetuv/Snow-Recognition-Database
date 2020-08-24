using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;
using Laim;
using System.Linq;
using OfficeOpenXml.Table;

namespace SRD
{

    public partial class FrmMain : Form
    {

        // this is disgusting and i really need to change it to a better method
        public string SqlConnection { get; set;  }
        private readonly List<string> HiddenColumnsAppList = XmlConfigurator.Read(Local.AppConfig, "HiddenColumnsAppList").Split(',').ToList();
        private readonly List<string> HiddenColumnsAppListRules = XmlConfigurator.Read(Local.AppConfig, "HiddenColumnsAppListRules").Split(',').ToList();
        private readonly List<string> HiddenColumnsAppUnassignedList = XmlConfigurator.Read(Local.AppConfig, "HiddenColumnsAppUnassignedList").Split(',').ToList();
        /* Reporting */
        private readonly TableStyles ReportingTableDesign = Extensions.ToEnum<TableStyles>(XmlConfigurator.Read(Local.AppConfig, "ReportingTableDesign"));
        private readonly string ReportingWorkbookTitle = XmlConfigurator.Read(Local.AppConfig, "ReportingWorkbookTitle");
        private readonly string ReportingWorkbookCompany = XmlConfigurator.Read(Local.AppConfig, "ReportingWorkbookCompany");
        private readonly string ReportingWorksheetName = XmlConfigurator.Read(Local.AppConfig, "ReportingWorksheetName");
        /* Reporting */
        private readonly int DatabaseCommandTimeout = Convert.ToInt32(XmlConfigurator.Read(Local.AppConfig, "DatabaseCommandTimeout"));
        private readonly List<string> MemorySavingDoubleBuffer = XmlConfigurator.Read(Local.AppConfig, "MemorySavingDoubleBuffer").Split(',').ToList();

        private readonly int ExportRowWarning = 150000;

        public FrmMain() => InitializeComponent();

        private void FrmMain_Load(object sender, EventArgs e)
        {
            /* Enable Double Buffer to stop weird grid lag */
            foreach(string v in MemorySavingDoubleBuffer) // checks for all datagridviews that should have doublebuffer enabled
            {
                if(!string.IsNullOrEmpty(v)) // checks if the value is empty
                {
                    if(Controls.Find(v, true).Length > 0) // checks if the control exists
                    {
                        Utility.SetDoubleBuffered(this.Controls.Find(v, true)[0]);
                    }
                }
            }

            /* Populate the DataGridViews with default columns */
            Local.DgvOnLoadPopulator(dgvAppList, MSSqlServer.ExecuteReadDataTable(SqlConnection, Properties.Sql.GetApplicationListEmpty, cmdTimeout: DatabaseCommandTimeout), HiddenColumnsAppList);
            Local.DgvOnLoadPopulator(dgvUnassignedList, MSSqlServer.ExecuteReadDataTable(SqlConnection, Properties.Sql.GetUnassignedApplicationListEmpty, cmdTimeout: DatabaseCommandTimeout), HiddenColumnsAppUnassignedList);

            /* Populate the column selector with the first view columns (App List)*/
            Local.ColumnPopulator(dgvAppList, cSearchColumns);

            /* Populate the customer selector */
            foreach(string i in MSSqlServer.ExecuteReadList(SqlConnection, Properties.Sql.GetCustomers))
            {
                cbCustomerPicker.Items.Add(i);
            }

            cbCustomerPicker.SelectedIndex = 0;

            /* Enable Column Selectors for the DataGridViews */
            _ = new ColumnSelector.DataGridViewColumnSelector() { DataGridView = dgvAppList, MaxHeight = 200, Width = 110 };
            _ = new ColumnSelector.DataGridViewColumnSelector() { DataGridView = dgvAppListRules, MaxHeight = 200, Width = 110 };
            _ = new ColumnSelector.DataGridViewColumnSelector() { DataGridView = dgvUnassignedList, MaxHeight = 200, Width = 110 };

            /* Design thing */
            aboutApplicationToolStripMenuItem.Text = string.Format("About {0}", ProductName);
        }

        private void btnAppListLoadAll_Click(object sender, EventArgs e)
        {

            bool proceedWithRun = true;
            DialogResult dr = MessageBox.Show("Show Data loads all data available in the database for your choosen tab which may take a long time and use a large amount of your System Memory.  If you proceed, the application will freeze until the data load is completed.  Do you wish to continue?",
               "Show Data Notice", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (dr == DialogResult.Yes)
            {
                proceedWithRun = true;
            }
            else
            {
                proceedWithRun = false;
            }

            if(proceedWithRun == true)
            {
                switch (tcMain.SelectedTab.Name)
                {
                    case "tabApplicationList":
                        dgvAppList.DataSource = MSSqlServer.ExecuteReadDataTable(SqlConnection, Properties.Sql.GetApplicationListAll, cmdTimeout: DatabaseCommandTimeout);
                        lblReturnedRows.Text = string.Format("Rows: {0:N0}", dgvAppList.RowCount);
                        break;
                    case "tabUnassignedList":
                        dgvUnassignedList.DataSource = MSSqlServer.ExecuteReadDataTable(SqlConnection, Properties.Sql.GetUnassignedApplicationListAll, cmdTimeout: DatabaseCommandTimeout);
                        lblReturnedRows.Text = string.Format("Rows: {0:N0}", dgvUnassignedList.RowCount);
                        break;
                }
            }
        }

        private void btnAppListSearch_Click(object sender, EventArgs e)
        {
            try
            {
                if (cSearchColumns.Text.Length > 0 || cSearchOperator.Text.Length > 0 || txtSearchCriteria.Text.Length > 0)
                {
                    List<SqlParameter> SqlParameters = new List<SqlParameter> { new SqlParameter("@SearchTerm", txtSearchCriteria.Text) };
                    string column = cSearchColumns.Text;
                    switch (tcMain.SelectedTab.Name)
                    {
                        case "tabApplicationList":
                            switch (column)
                            {
                                case "Application": column = "A.Name"; break;
                                case "Manufacturer": column = "M.Name"; break;
                                case "Family Name": column = "AF.Name"; break;
                                default: column = cSearchColumns.Text; break;
                            }
                            dgvAppList.DataSource = MSSqlServer.ExecuteReadDataTable(SqlConnection, Properties.Sql.GetApplicationSearch.Replace("{ColumnName}", column).Replace("{Operator}", cSearchOperator.Text), SqlParameters, DatabaseCommandTimeout);
                            lblReturnedRows.Text = string.Format("Rows: {0:N0}", dgvAppList.RowCount);
                            break;
                        case "tabUnassignedList":
                            dgvUnassignedList.DataSource = MSSqlServer.ExecuteReadDataTable(SqlConnection, Properties.Sql.GetUnassignedApplicationListSearch.Replace("{ColumnName}", column).Replace("{Operator}", cSearchOperator.Text), SqlParameters, DatabaseCommandTimeout);
                            lblReturnedRows.Text = string.Format("Rows: {0:N0}", dgvUnassignedList.RowCount);
                            break;
                        default:
                            break;
                    }
                }
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Uncaught Exception", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        /// <summary>
        /// Restarts the Application for any reason
        /// </summary>
        private void restartApplicationToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Application.Restart();
        }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Code Quality", "IDE0067:Dispose objects before losing scope", Justification = "Disposed when the form closes, when doing 'using' it causes an infinite close loop.")]
        private void FrmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Forms.FrmStartup frm = new Forms.FrmStartup();
            frm.Show();
        }

        /// <summary>
        /// Due to the FormClosed sending the user to the connection form, 
        /// we just do a close here and it'll let you change the connection
        /// </summary>
        private void changeConnectionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// If the user clicks on the App List DataGridView
        /// </summary>
        private void dgvAppList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 1 && e.RowIndex >= 0)
            {
                scAppList.Panel2Collapsed = false;
                dgvAppList.Size = new Size(tabApplicationList.Width - 161, tabApplicationList.Height - 130);
                string sql = Properties.Sql.GetApplicationRules;
                List<SqlParameter> SqlParameters = new List<SqlParameter>
                {
                    new SqlParameter("@AppID", dgvAppList.Rows[e.RowIndex].Cells[0].Value)
                };
                dgvAppListRules.DataSource = MSSqlServer.ExecuteReadDataTable(SqlConnection, sql, SqlParameters, DatabaseCommandTimeout);

                /* Hides the columns */
                foreach (DataGridViewColumn col in dgvAppListRules.Columns)
                {
                    if (HiddenColumnsAppListRules.Contains(col.Name)) { col.Visible = false; }
                }
            }
        }
        
        /// <summary>
        /// If the tab changes on the tab control, update the search information on the left hand side
        /// </summary>
        private void tcMain_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (tcMain.SelectedTab.Name)
            {
                case "tabApplicationList":
                    Local.ColumnPopulator(dgvAppList, cSearchColumns);
                    break;
                case "tabUnassignedList":
                    Local.ColumnPopulator(dgvUnassignedList, cSearchColumns);
                    break;
                default:
                    break;
            }
        }

        private void ViewHelpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/goosetuv/snow-recognition-database");
        }

        private void ExportDirectoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Data\\Exports");
        }

        private void ExportAsXlsxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool proceedWithExport = true;
            if(dgvAppList.RowCount > ExportRowWarning || dgvUnassignedList.RowCount > ExportRowWarning)
            {
                DialogResult dr = MessageBox.Show("Exporting " + string.Format("{0:#,0}", ExportRowWarning) + " or more rows at a time may result in long export times.  If you proceed, the application will freeze until the export is completed.  Do you wish to continue?",
                    "Export Notice", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if(dr == DialogResult.Yes)
                {
                    proceedWithExport = true;
                } else
                {
                    proceedWithExport = false;
                }
            }

            if(proceedWithExport == true)
            {
                switch (tcMain.SelectedTab.Name)
                {
                    case "tabApplicationList":
                        if (dgvAppList.RowCount > 0)
                        {
                            if(dgvAppList.RowCount < 1048576)
                            {
                                Local.ExportXlsx(dgvAppList, "Data\\Exports", ReportingTableDesign, ReportingWorkbookTitle, ReportingWorkbookCompany, ReportingWorksheetName);
                            } else
                            {
                                MessageBox.Show("Too many rows to export to xlsx, please export to CSV", "Export", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                        else
                        {
                            MessageBox.Show("No data to export", "Export", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        break;
                    case "tabUnassignedList":
                        if (dgvUnassignedList.RowCount > 0)
                        {
                            if (dgvUnassignedList.RowCount < 1048576)
                            {
                                Local.ExportXlsx(dgvUnassignedList, "Data\\Exports", ReportingTableDesign, ReportingWorkbookTitle, ReportingWorkbookCompany, ReportingWorksheetName);
                            }
                            else
                            {
                                MessageBox.Show("Too many rows to export to xlsx, please export to CSV", "Export", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                        else
                        {
                            MessageBox.Show("No data to export", "Export", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        break;
                }
            }
            
        }

        private void AboutApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forms.FrmAbout b = new Forms.FrmAbout();
            using (b)
            {
                b.ShowDialog();
            }
        }

        private void applicationSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forms.FrmSettings s = new Forms.FrmSettings();
            using (s)
            {
                s.ShowDialog();
                s.FirstStart = false;
            }
        }

        private void ExportAsCSVToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool proceedWithExport = true;

            if (dgvAppList.RowCount > ExportRowWarning || dgvUnassignedList.RowCount > ExportRowWarning)
            {
                DialogResult dr = MessageBox.Show("Exporting 100,000 or more rows at a time may result in long export times.  If you proceed, the application will freeze until the export is completed.  Do you wish to continue?",
                    "Export Notice", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (dr == DialogResult.Yes)
                {
                    proceedWithExport = true;
                }
                else
                {
                    proceedWithExport = false;
                }
            }

            if (proceedWithExport == true)
            {
                switch (tcMain.SelectedTab.Name)
                {
                    case "tabApplicationList":
                        if (dgvAppList.RowCount > 0)
                        {
                            Local.ExportCsv(dgvAppList, "Data\\Exports");
                        }
                        else
                        {
                            MessageBox.Show("No data to export", "Export", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        break;
                    case "tabUnassignedList":
                        if (dgvUnassignedList.RowCount > 0)
                        {
                            Local.ExportCsv(dgvUnassignedList, "Data\\Exports");
                        }
                        else
                        {
                            MessageBox.Show("No data to export", "Export", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        break;
                }
            }
        }

        private void dgvUnassignedList_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex >= 0 && e.RowIndex >= 0)
            {
                string SearchString;
                int SearchIndex = 8;

                foreach (DataGridViewColumn col in dgvUnassignedList.Columns)
                {
                    if (col.Name == "ExecutablePath")
                    {
                        SearchIndex = col.Index;
                    }
                }

                SearchString = dgvUnassignedList.Rows[e.RowIndex].Cells[SearchIndex].Value.ToString();
                Forms.FrmDgvPopup frmDgv = new Forms.FrmDgvPopup();
                using (frmDgv)
                {
                    frmDgv.SearchString = SearchString;
                    frmDgv.PopupType = "UnassignedCompSearch";
                    frmDgv.SqlConnection = SqlConnection;
                    frmDgv.ReportingTableDesign = ReportingTableDesign;
                    frmDgv.ReportingWorkbookTitle = ReportingWorkbookTitle;
                    frmDgv.ReportingWorkbookCompany = ReportingWorkbookCompany;
                    frmDgv.ReportingWorksheetName = ReportingWorksheetName;
                    frmDgv.DatabaseCommandTimeout = DatabaseCommandTimeout;
                    frmDgv.ShowDialog();
                }
            }
        }

        private void dgvRowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            using (SolidBrush b = new SolidBrush(((DataGridView)sender).RowHeadersDefaultCellStyle.ForeColor))
            {
                e.Graphics.DrawString((e.RowIndex + 1).ToString(), e.InheritedRowStyle.Font, b, e.RowBounds.Location.X + 10, e.RowBounds.Location.Y + 4);
            }
        }
    }
}

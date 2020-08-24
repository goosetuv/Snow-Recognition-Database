using Laim;
using OfficeOpenXml.Table;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SRD.Forms
{
    public partial class FrmDgvPopup : Form
    {
        public string SearchString { get; set; }
        public string PopupType { get; set; }
        public string SqlConnection { get; set; }
        public TableStyles ReportingTableDesign { get; set; }
        public string ReportingWorkbookTitle { get; set; }
        public string ReportingWorkbookCompany { get; set; }
        public string ReportingWorksheetName { get; set; }
        public int DatabaseCommandTimeout { get; set; }

        public FrmDgvPopup()
        {
            InitializeComponent();
        }

        private void FrmDgvPopup_Load(object sender, EventArgs e)
        {
            try
            {
                switch (PopupType)
                {
                    case "UnassignedCompSearch":
                        Text = "Computers with Unassigned Application";
                        List<SqlParameter> SqlParameters = new List<SqlParameter> { new SqlParameter("@SearchTerm", SearchString) };
                        dgvPopup.DataSource = MSSqlServer.ExecuteReadDataTable(SqlConnection, Properties.Sql.GetUnassignedApplicationListComp.Replace("{ColumnName}", "FS.SwPathName"), SqlParameters, DatabaseCommandTimeout);
                        break;
                    default:
                        Text = "Data Popup";
                        break;
                }
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Uncaught Exception", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnDgvPopupExportCsv_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvPopup.RowCount > 0)
                {
                    Local.ExportCsv(dgvPopup, "Data\\Exports");
                }
                else
                {
                    MessageBox.Show("No data to export", "Export", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Uncaught Exception", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnDgvPopupExportXlsx_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvPopup.RowCount > 0)
                {
                    if (dgvPopup.RowCount < 1048576)
                    {
                        Local.ExportXlsx(dgvPopup, "Data\\Exports", ReportingTableDesign, ReportingWorkbookTitle, ReportingWorkbookCompany, ReportingWorksheetName);
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
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Uncaught Exception", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}

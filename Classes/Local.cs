using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

namespace SRD
{
    public class Local
    {

        public static readonly string AppConfig = "app.config";

        /// <summary>
        /// Populate a datagridview
        /// </summary>
        /// <param name="dgv">The datagridview</param>
        /// <param name="dt">The datatable you want to populate the dgv with</param>
        /// <param name="vs">A list of columns to hide</param>
        public static void DgvOnLoadPopulator(DataGridView dgv, System.Data.DataTable dt, List<string> vs = null)
        {
            dgv.DataSource = dt;
            foreach (DataGridViewColumn col in dgv.Columns)
            {
                if (vs.Contains(col.Name))
                {
                    col.Visible = false;
                }
            }
        }

        /// <summary>
        /// Populate the search column selector
        /// </summary>
        /// <param name="dgv">Your datagridview with columns</param>
        /// <param name="combo">The combo box you want to populate </param>
        public static void ColumnPopulator(DataGridView dgv, ComboBox combo)
        {
            if (combo.Items.Count > 0)
            {
                combo.Items.Clear();
            }
            foreach (DataGridViewColumn col in dgv.Columns)
            {
                combo.Items.Add(col.Name);
            }
        }

        /// <summary>
        /// Export a datagridview to xlsx using EPPlus
        /// </summary>
        /// <param name="dgv">Datagridview</param>
        /// <param name="Directory">Save Directory</param>
        /// <param name="ReportingTableDesign">Table Style</param>
        /// <param name="ReportingWorksheetName">Name of the workbook</param>
        public static void ExportXlsx(
            DataGridView dgv, 
            string Directory, 
            OfficeOpenXml.Table.TableStyles ReportingTableDesign, 
            string ReportingWorkbookTitle, 
            string ReportingWorkbookCompany,
            string ReportingWorksheetName)
        {
            FileInfo file = new FileInfo(Directory + "\\" + dgv.Name + DateTime.Now.ToString("ddMMyyyy-HHmmss") + ".xlsx");
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            using (ExcelPackage ep = new ExcelPackage(file))
            {
                ExcelWorksheet ew = ep.Workbook.Worksheets.Add(ReportingWorksheetName);
                ew.Cells["A1"].LoadFromDataTable((DataTable)dgv.DataSource, true, ReportingTableDesign);
                ew.Cells.AutoFitColumns(40);
                ep.Workbook.Properties.Application = Application.ProductName;
                ep.Workbook.Properties.AppVersion = Application.ProductVersion;
                ep.Workbook.Properties.Author = Environment.UserName;
                ep.Workbook.Properties.Title = ReportingWorkbookTitle + " Export";
                ep.Workbook.Properties.Company = ReportingWorkbookCompany;
                ep.Workbook.Properties.Comments = "https://laim.scot";
                ep.Save();
            }
        }

        public static void ExportCsv(DataGridView dgv, string Directory)
        {
            int columnCount = dgv.ColumnCount;
            string columnNames = "";
            string[] output = new string[dgv.RowCount + 1];
            for (int i = 0; i < columnCount; i++)
            {
                columnNames += dgv.Columns[i].Name.ToString().Replace(",","") + ",";
            }
            output[0] += columnNames;
            for (int i = 1; (i - 1) < dgv.RowCount; i++)
            {
                for (int j = 0; j < columnCount; j++)
                {
                    output[i] += dgv.Rows[i - 1].Cells[j].Value.ToString().Replace(",", "") + ",";
                }
            }
            File.WriteAllLines(Directory + "\\" + dgv.Name + DateTime.Now.ToString("ddMMyyyy-HHmmss") + ".csv", output, Encoding.UTF8);
        }
    }
}

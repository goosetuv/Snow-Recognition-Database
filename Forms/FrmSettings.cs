#region Dependencies
using Laim;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Windows.Forms;
#endregion

namespace SRD.Forms
{
    public partial class FrmSettings : Form
    {
        #region Fields
        public bool FirstStart { get; set; }
        #endregion

        #region Constructor
        public FrmSettings()
        {
            InitializeComponent();
        }
        #endregion

        #region Events
        private void FrmSettings_Load(object sender, EventArgs e)
        {
            if (FirstStart == false)
            {
                try
                {
                    int etd = 0;
                    foreach (string c in cblReportingTableDesign.Items)
                    {
                        if (c == XmlConfigurator.Read(Local.AppConfig, "ReportingTableDesign"))
                        {
                            cblReportingTableDesign.SelectedIndex = etd;
                        }
                        etd += 1;
                    }

                    List<string> MemorySavingDoubleBuffer = XmlConfigurator.Read(Local.AppConfig, "MemorySavingDoubleBuffer").Split(',').ToList();
                    foreach (string i in MemorySavingDoubleBuffer)
                    {
                        if (i == "dgvAppList") { cbMemoryAppList.Checked = true; }
                        if (i == "dgvAppListRules") { cbMemoryAppListRules.Checked = true; }
                        if (i == "dgvUnassignedList") { cbMemoryUnassignedAppList.Checked = true; }
                    }

                    txtAppListColumns.Text = XmlConfigurator.Read(Local.AppConfig, "HiddenColumnsAppList");
                    txtAppListRulesColumns.Text = XmlConfigurator.Read(Local.AppConfig, "HiddenColumnsAppListRules");
                    txtUnassignedAppListColumns.Text = XmlConfigurator.Read(Local.AppConfig, "HiddenColumnsAppUnassignedList");
                    txtReportingWorkbookTitle.Text = XmlConfigurator.Read(Local.AppConfig, "ReportingWorkbookTitle");
                    txtReportingWorkbookCompany.Text = XmlConfigurator.Read(Local.AppConfig, "ReportingWorkbookCompany");
                    txtReportingWorksheetName.Text = XmlConfigurator.Read(Local.AppConfig, "ReportingWorksheetName");
                    numDatabaseCommandTimeout.Value = Convert.ToDecimal(XmlConfigurator.Read(Local.AppConfig, "DatabaseCommandTimeout"));
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Uncaught Exception", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void btnColumnsDefault_Click(object sender, EventArgs e)
        {
            txtAppListColumns.Text = "ApplicationID,LanguageID,OSType,OverridesApplicationID,GloballyGeneratedApplication,FamilyIndex,EditionIndex,VersionIndex,CompatibleWithID,DowngradeInstance,LicenseForm,DowngradePaths,UpgradePaths,ProductMajorVersion,ProductMinorVersion,PreferredMetric,MinimumRequirement,CoreFactorDefinitionID,CreatedDate,UpdatedDate,LicensingForm,ApplicationTypes,ApplicationBundles,NoLicenseRequired,NoMetering,ApplicationType,IsWebApplication,CreatedBy,UpdatedBy";
            txtAppListRulesColumns.Text = "RuleID,RuleHitRate,CreatedDate,CreatedBy,UpdatedDate,UpdatedBy";
            txtUnassignedAppListColumns.Text = "CID,SoftwareCheckSum,ExecutablePathReversed,IsOS,IsHidden,IsRegistry,ValidatedDate,ValidatedBy,CIDCount,IsTS,IsVT";
        }

        private void btnReportingDefaults_Click(object sender, EventArgs e)
        {
            cblReportingTableDesign.SelectedIndex = 0;
            txtReportingWorkbookTitle.Text = Application.ProductName;
            txtReportingWorkbookCompany.Text = "Laim McKenzie";
            txtReportingWorksheetName.Text = "Report";
        }

        private void btnSaveSettings_Click(object sender, EventArgs e)
        {
            try
            {
                if (cblReportingTableDesign.SelectedIndex < 0 || txtReportingWorkbookCompany.Text.Length < 0 || txtReportingWorkbookTitle.Text.Length < 0 || txtReportingWorksheetName.Text.Length < 0)
                {
                    MessageBox.Show("One or more required entries are empty.", "Save Settings", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    tcAppSettings.SelectedIndex = 1;
                }
                else
                {

                    // memory saving check boxes
                    string[] NodeList = {
                        "HiddenColumnsAppList",
                        "HiddenColumnsAppListRules",
                        "HiddenColumnsAppUnassignedList",
                        "ReportingTableDesign",
                        "ReportingWorkbookTitle",
                        "ReportingWorkbookCompany",
                        "ReportingWorksheetName",
                        "DatabaseCommandTimeout",
                        "MemorySavingDoubleBuffer"
                    };

                    string[] ValueList = {
                        txtAppListColumns.Text,
                        txtAppListRulesColumns.Text,
                        txtUnassignedAppListColumns.Text,
                        cblReportingTableDesign.Text,
                        txtReportingWorkbookTitle.Text,
                        txtReportingWorkbookCompany.Text,
                        txtReportingWorksheetName.Text,
                        Convert.ToString(numDatabaseCommandTimeout.Value),
                        Convert.ToString(MemorySavingDoubleBufferCheck())
                    };

                    XmlConfigurator.Write(Local.AppConfig, NodeList, ValueList);
                    if (FirstStart == false)
                    {
                        MessageBox.Show("Application Restart required for changes to take affect.", "Save Settings", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Configuration Complete", "First Run", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Uncaught Exception", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnDatabaseDefault_Click(object sender, EventArgs e)
        {
            numDatabaseCommandTimeout.Value = 30;
        }

        private void btnMemorySavingDefault_Click(object sender, EventArgs e)
        {
            cbMemoryAppList.Checked = true;
            cbMemoryAppListRules.Checked = true;
            cbMemoryUnassignedAppList.Checked = true;
        }
        #endregion

        #region Methods
        private CommaDelimitedStringCollection MemorySavingDoubleBufferCheck()
        {
            CommaDelimitedStringCollection memSaving = new CommaDelimitedStringCollection();
            if (cbMemoryAppList.Checked) { memSaving.Add("dgvAppList"); }
            if (cbMemoryAppListRules.Checked) { memSaving.Add("dgvAppListRules"); }
            if (cbMemoryUnassignedAppList.Checked) { memSaving.Add("dgvUnassignedList"); }
            return memSaving;
        }
        #endregion

    }
}

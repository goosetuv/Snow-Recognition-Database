namespace SRD.Forms
{
    partial class FrmSettings
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSettings));
            this.tcAppSettings = new System.Windows.Forms.TabControl();
            this.tabColumns = new System.Windows.Forms.TabPage();
            this.btnColumnsDefault = new System.Windows.Forms.Button();
            this.lblColumnsNotice = new System.Windows.Forms.Label();
            this.txtUnassignedAppListColumns = new System.Windows.Forms.TextBox();
            this.lblUnassignedAppList = new System.Windows.Forms.Label();
            this.txtAppListRulesColumns = new System.Windows.Forms.TextBox();
            this.lblAppListRules = new System.Windows.Forms.Label();
            this.txtAppListColumns = new System.Windows.Forms.TextBox();
            this.lblAppListColumns = new System.Windows.Forms.Label();
            this.tabReporting = new System.Windows.Forms.TabPage();
            this.txtReportingWorksheetName = new System.Windows.Forms.TextBox();
            this.lblReportingWorksheetName = new System.Windows.Forms.Label();
            this.lblReportingWorkbookCompany = new System.Windows.Forms.Label();
            this.txtReportingWorkbookCompany = new System.Windows.Forms.TextBox();
            this.txtReportingWorkbookTitle = new System.Windows.Forms.TextBox();
            this.lblReportingWorkbookTitle = new System.Windows.Forms.Label();
            this.btnReportingDefaults = new System.Windows.Forms.Button();
            this.lblReportingNotice = new System.Windows.Forms.Label();
            this.cblReportingTableDesign = new System.Windows.Forms.ComboBox();
            this.lblReportingTableDesign = new System.Windows.Forms.Label();
            this.tabDatabaseSettings = new System.Windows.Forms.TabPage();
            this.btnDatabaseDefault = new System.Windows.Forms.Button();
            this.lblDatabaseNotice = new System.Windows.Forms.Label();
            this.numDatabaseCommandTimeout = new System.Windows.Forms.NumericUpDown();
            this.lblDatabaseCommandTimeout = new System.Windows.Forms.Label();
            this.tabMemorySaving = new System.Windows.Forms.TabPage();
            this.btnMemorySavingDefault = new System.Windows.Forms.Button();
            this.lblMemorySavingNotice = new System.Windows.Forms.Label();
            this.lblMemoryUnassignedAppList = new System.Windows.Forms.Label();
            this.cbMemoryUnassignedAppList = new System.Windows.Forms.CheckBox();
            this.lblMemoryAppListRules = new System.Windows.Forms.Label();
            this.cbMemoryAppListRules = new System.Windows.Forms.CheckBox();
            this.cbMemoryAppList = new System.Windows.Forms.CheckBox();
            this.lblMemoryAppList = new System.Windows.Forms.Label();
            this.btnSaveSettings = new System.Windows.Forms.Button();
            this.ttAppSettings = new System.Windows.Forms.ToolTip(this.components);
            this.tcAppSettings.SuspendLayout();
            this.tabColumns.SuspendLayout();
            this.tabReporting.SuspendLayout();
            this.tabDatabaseSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDatabaseCommandTimeout)).BeginInit();
            this.tabMemorySaving.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcAppSettings
            // 
            this.tcAppSettings.Controls.Add(this.tabColumns);
            this.tcAppSettings.Controls.Add(this.tabReporting);
            this.tcAppSettings.Controls.Add(this.tabDatabaseSettings);
            this.tcAppSettings.Controls.Add(this.tabMemorySaving);
            this.tcAppSettings.Location = new System.Drawing.Point(12, 12);
            this.tcAppSettings.Name = "tcAppSettings";
            this.tcAppSettings.SelectedIndex = 0;
            this.tcAppSettings.Size = new System.Drawing.Size(352, 199);
            this.tcAppSettings.TabIndex = 0;
            // 
            // tabColumns
            // 
            this.tabColumns.Controls.Add(this.btnColumnsDefault);
            this.tabColumns.Controls.Add(this.lblColumnsNotice);
            this.tabColumns.Controls.Add(this.txtUnassignedAppListColumns);
            this.tabColumns.Controls.Add(this.lblUnassignedAppList);
            this.tabColumns.Controls.Add(this.txtAppListRulesColumns);
            this.tabColumns.Controls.Add(this.lblAppListRules);
            this.tabColumns.Controls.Add(this.txtAppListColumns);
            this.tabColumns.Controls.Add(this.lblAppListColumns);
            this.tabColumns.Location = new System.Drawing.Point(4, 22);
            this.tabColumns.Name = "tabColumns";
            this.tabColumns.Padding = new System.Windows.Forms.Padding(3);
            this.tabColumns.Size = new System.Drawing.Size(344, 173);
            this.tabColumns.TabIndex = 0;
            this.tabColumns.Text = "Columns";
            this.tabColumns.UseVisualStyleBackColor = true;
            // 
            // btnColumnsDefault
            // 
            this.btnColumnsDefault.Location = new System.Drawing.Point(260, 141);
            this.btnColumnsDefault.Name = "btnColumnsDefault";
            this.btnColumnsDefault.Size = new System.Drawing.Size(75, 23);
            this.btnColumnsDefault.TabIndex = 7;
            this.btnColumnsDefault.Text = "Defaults";
            this.btnColumnsDefault.UseVisualStyleBackColor = true;
            this.btnColumnsDefault.Click += new System.EventHandler(this.btnColumnsDefault_Click);
            // 
            // lblColumnsNotice
            // 
            this.lblColumnsNotice.AutoSize = true;
            this.lblColumnsNotice.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColumnsNotice.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblColumnsNotice.Location = new System.Drawing.Point(6, 145);
            this.lblColumnsNotice.Name = "lblColumnsNotice";
            this.lblColumnsNotice.Size = new System.Drawing.Size(210, 16);
            this.lblColumnsNotice.TabIndex = 6;
            this.lblColumnsNotice.Text = "These are the columns you want to hide.";
            // 
            // txtUnassignedAppListColumns
            // 
            this.txtUnassignedAppListColumns.Location = new System.Drawing.Point(9, 113);
            this.txtUnassignedAppListColumns.Name = "txtUnassignedAppListColumns";
            this.txtUnassignedAppListColumns.Size = new System.Drawing.Size(326, 20);
            this.txtUnassignedAppListColumns.TabIndex = 5;
            // 
            // lblUnassignedAppList
            // 
            this.lblUnassignedAppList.AutoSize = true;
            this.lblUnassignedAppList.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnassignedAppList.Location = new System.Drawing.Point(6, 94);
            this.lblUnassignedAppList.Name = "lblUnassignedAppList";
            this.lblUnassignedAppList.Size = new System.Drawing.Size(143, 16);
            this.lblUnassignedAppList.TabIndex = 4;
            this.lblUnassignedAppList.Text = "Unassigned Application List";
            // 
            // txtAppListRulesColumns
            // 
            this.txtAppListRulesColumns.Location = new System.Drawing.Point(9, 71);
            this.txtAppListRulesColumns.Name = "txtAppListRulesColumns";
            this.txtAppListRulesColumns.Size = new System.Drawing.Size(326, 20);
            this.txtAppListRulesColumns.TabIndex = 3;
            // 
            // lblAppListRules
            // 
            this.lblAppListRules.AutoSize = true;
            this.lblAppListRules.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppListRules.Location = new System.Drawing.Point(6, 52);
            this.lblAppListRules.Name = "lblAppListRules";
            this.lblAppListRules.Size = new System.Drawing.Size(113, 16);
            this.lblAppListRules.TabIndex = 2;
            this.lblAppListRules.Text = "Application List Rules";
            // 
            // txtAppListColumns
            // 
            this.txtAppListColumns.Location = new System.Drawing.Point(9, 29);
            this.txtAppListColumns.Name = "txtAppListColumns";
            this.txtAppListColumns.Size = new System.Drawing.Size(326, 20);
            this.txtAppListColumns.TabIndex = 1;
            // 
            // lblAppListColumns
            // 
            this.lblAppListColumns.AutoSize = true;
            this.lblAppListColumns.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppListColumns.Location = new System.Drawing.Point(6, 10);
            this.lblAppListColumns.Name = "lblAppListColumns";
            this.lblAppListColumns.Size = new System.Drawing.Size(85, 16);
            this.lblAppListColumns.TabIndex = 0;
            this.lblAppListColumns.Text = "Application List";
            // 
            // tabReporting
            // 
            this.tabReporting.Controls.Add(this.txtReportingWorksheetName);
            this.tabReporting.Controls.Add(this.lblReportingWorksheetName);
            this.tabReporting.Controls.Add(this.lblReportingWorkbookCompany);
            this.tabReporting.Controls.Add(this.txtReportingWorkbookCompany);
            this.tabReporting.Controls.Add(this.txtReportingWorkbookTitle);
            this.tabReporting.Controls.Add(this.lblReportingWorkbookTitle);
            this.tabReporting.Controls.Add(this.btnReportingDefaults);
            this.tabReporting.Controls.Add(this.lblReportingNotice);
            this.tabReporting.Controls.Add(this.cblReportingTableDesign);
            this.tabReporting.Controls.Add(this.lblReportingTableDesign);
            this.tabReporting.Location = new System.Drawing.Point(4, 22);
            this.tabReporting.Name = "tabReporting";
            this.tabReporting.Padding = new System.Windows.Forms.Padding(3);
            this.tabReporting.Size = new System.Drawing.Size(344, 173);
            this.tabReporting.TabIndex = 1;
            this.tabReporting.Text = "Reporting";
            this.tabReporting.UseVisualStyleBackColor = true;
            // 
            // txtReportingWorksheetName
            // 
            this.txtReportingWorksheetName.Location = new System.Drawing.Point(9, 114);
            this.txtReportingWorksheetName.Name = "txtReportingWorksheetName";
            this.txtReportingWorksheetName.Size = new System.Drawing.Size(155, 20);
            this.txtReportingWorksheetName.TabIndex = 15;
            // 
            // lblReportingWorksheetName
            // 
            this.lblReportingWorksheetName.AutoSize = true;
            this.lblReportingWorksheetName.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReportingWorksheetName.Location = new System.Drawing.Point(6, 95);
            this.lblReportingWorksheetName.Name = "lblReportingWorksheetName";
            this.lblReportingWorksheetName.Size = new System.Drawing.Size(129, 16);
            this.lblReportingWorksheetName.TabIndex = 14;
            this.lblReportingWorksheetName.Text = "Export Worksheet Name";
            // 
            // lblReportingWorkbookCompany
            // 
            this.lblReportingWorkbookCompany.AutoSize = true;
            this.lblReportingWorkbookCompany.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReportingWorkbookCompany.Location = new System.Drawing.Point(177, 53);
            this.lblReportingWorkbookCompany.Name = "lblReportingWorkbookCompany";
            this.lblReportingWorkbookCompany.Size = new System.Drawing.Size(143, 16);
            this.lblReportingWorkbookCompany.TabIndex = 13;
            this.lblReportingWorkbookCompany.Text = "Export Workbook Company";
            // 
            // txtReportingWorkbookCompany
            // 
            this.txtReportingWorkbookCompany.Location = new System.Drawing.Point(180, 72);
            this.txtReportingWorkbookCompany.Name = "txtReportingWorkbookCompany";
            this.txtReportingWorkbookCompany.Size = new System.Drawing.Size(155, 20);
            this.txtReportingWorkbookCompany.TabIndex = 12;
            // 
            // txtReportingWorkbookTitle
            // 
            this.txtReportingWorkbookTitle.Location = new System.Drawing.Point(9, 72);
            this.txtReportingWorkbookTitle.Name = "txtReportingWorkbookTitle";
            this.txtReportingWorkbookTitle.Size = new System.Drawing.Size(155, 20);
            this.txtReportingWorkbookTitle.TabIndex = 11;
            // 
            // lblReportingWorkbookTitle
            // 
            this.lblReportingWorkbookTitle.AutoSize = true;
            this.lblReportingWorkbookTitle.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReportingWorkbookTitle.Location = new System.Drawing.Point(6, 53);
            this.lblReportingWorkbookTitle.Name = "lblReportingWorkbookTitle";
            this.lblReportingWorkbookTitle.Size = new System.Drawing.Size(120, 16);
            this.lblReportingWorkbookTitle.TabIndex = 10;
            this.lblReportingWorkbookTitle.Text = "Export Workbook Title";
            this.ttAppSettings.SetToolTip(this.lblReportingWorkbookTitle, "The application automatically adds \'Export\' to the end of the title. ");
            // 
            // btnReportingDefaults
            // 
            this.btnReportingDefaults.Location = new System.Drawing.Point(260, 141);
            this.btnReportingDefaults.Name = "btnReportingDefaults";
            this.btnReportingDefaults.Size = new System.Drawing.Size(75, 23);
            this.btnReportingDefaults.TabIndex = 9;
            this.btnReportingDefaults.Text = "Defaults";
            this.btnReportingDefaults.UseVisualStyleBackColor = true;
            this.btnReportingDefaults.Click += new System.EventHandler(this.btnReportingDefaults_Click);
            // 
            // lblReportingNotice
            // 
            this.lblReportingNotice.AutoSize = true;
            this.lblReportingNotice.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReportingNotice.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblReportingNotice.Location = new System.Drawing.Point(6, 145);
            this.lblReportingNotice.Name = "lblReportingNotice";
            this.lblReportingNotice.Size = new System.Drawing.Size(215, 16);
            this.lblReportingNotice.TabIndex = 8;
            this.lblReportingNotice.Text = "These settings only apply to xlsx exports.";
            // 
            // cblReportingTableDesign
            // 
            this.cblReportingTableDesign.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cblReportingTableDesign.FormattingEnabled = true;
            this.cblReportingTableDesign.Items.AddRange(new object[] {
            "None",
            "Light1",
            "Light2",
            "Light3",
            "Light4",
            "Light5",
            "Light6",
            "Light7",
            "Light8",
            "Light9",
            "Light10",
            "Light11",
            "Light12",
            "Light13",
            "Light14",
            "Light15",
            "Light16",
            "Light17",
            "Light18",
            "Light19",
            "Light20",
            "Light21",
            "Medium1",
            "Medium2",
            "Medium3",
            "Medium4",
            "Medium5",
            "Medium6",
            "Medium7",
            "Medium8",
            "Medium9",
            "Medium10",
            "Medium11",
            "Medium12",
            "Medium13",
            "Medium14",
            "Medium15",
            "Medium16",
            "Medium17",
            "Medium18",
            "Medium19",
            "Medium20",
            "Medium21",
            "Medium22",
            "Medium23",
            "Medium24",
            "Medium25",
            "Medium26",
            "Medium27",
            "Medium28",
            "Dark1",
            "Dark2",
            "Dark3",
            "Dark4",
            "Dark5",
            "Dark6",
            "Dark7",
            "Dark8",
            "Dark9",
            "Dark10",
            "Dark11"});
            this.cblReportingTableDesign.Location = new System.Drawing.Point(9, 29);
            this.cblReportingTableDesign.MaxDropDownItems = 50;
            this.cblReportingTableDesign.Name = "cblReportingTableDesign";
            this.cblReportingTableDesign.Size = new System.Drawing.Size(326, 21);
            this.cblReportingTableDesign.TabIndex = 2;
            // 
            // lblReportingTableDesign
            // 
            this.lblReportingTableDesign.AutoSize = true;
            this.lblReportingTableDesign.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReportingTableDesign.Location = new System.Drawing.Point(6, 10);
            this.lblReportingTableDesign.Name = "lblReportingTableDesign";
            this.lblReportingTableDesign.Size = new System.Drawing.Size(106, 16);
            this.lblReportingTableDesign.TabIndex = 1;
            this.lblReportingTableDesign.Text = "Export Table Design";
            // 
            // tabDatabaseSettings
            // 
            this.tabDatabaseSettings.Controls.Add(this.btnDatabaseDefault);
            this.tabDatabaseSettings.Controls.Add(this.lblDatabaseNotice);
            this.tabDatabaseSettings.Controls.Add(this.numDatabaseCommandTimeout);
            this.tabDatabaseSettings.Controls.Add(this.lblDatabaseCommandTimeout);
            this.tabDatabaseSettings.Location = new System.Drawing.Point(4, 22);
            this.tabDatabaseSettings.Name = "tabDatabaseSettings";
            this.tabDatabaseSettings.Padding = new System.Windows.Forms.Padding(3);
            this.tabDatabaseSettings.Size = new System.Drawing.Size(344, 173);
            this.tabDatabaseSettings.TabIndex = 2;
            this.tabDatabaseSettings.Text = "Database";
            this.tabDatabaseSettings.UseVisualStyleBackColor = true;
            // 
            // btnDatabaseDefault
            // 
            this.btnDatabaseDefault.Location = new System.Drawing.Point(260, 141);
            this.btnDatabaseDefault.Name = "btnDatabaseDefault";
            this.btnDatabaseDefault.Size = new System.Drawing.Size(75, 23);
            this.btnDatabaseDefault.TabIndex = 10;
            this.btnDatabaseDefault.Text = "Defaults";
            this.btnDatabaseDefault.UseVisualStyleBackColor = true;
            this.btnDatabaseDefault.Click += new System.EventHandler(this.btnDatabaseDefault_Click);
            // 
            // lblDatabaseNotice
            // 
            this.lblDatabaseNotice.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatabaseNotice.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblDatabaseNotice.Location = new System.Drawing.Point(6, 52);
            this.lblDatabaseNotice.Name = "lblDatabaseNotice";
            this.lblDatabaseNotice.Size = new System.Drawing.Size(329, 64);
            this.lblDatabaseNotice.TabIndex = 9;
            this.lblDatabaseNotice.Text = resources.GetString("lblDatabaseNotice.Text");
            this.lblDatabaseNotice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // numDatabaseCommandTimeout
            // 
            this.numDatabaseCommandTimeout.Location = new System.Drawing.Point(9, 29);
            this.numDatabaseCommandTimeout.Name = "numDatabaseCommandTimeout";
            this.numDatabaseCommandTimeout.Size = new System.Drawing.Size(326, 20);
            this.numDatabaseCommandTimeout.TabIndex = 3;
            this.numDatabaseCommandTimeout.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // lblDatabaseCommandTimeout
            // 
            this.lblDatabaseCommandTimeout.AutoSize = true;
            this.lblDatabaseCommandTimeout.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatabaseCommandTimeout.Location = new System.Drawing.Point(6, 10);
            this.lblDatabaseCommandTimeout.Name = "lblDatabaseCommandTimeout";
            this.lblDatabaseCommandTimeout.Size = new System.Drawing.Size(98, 16);
            this.lblDatabaseCommandTimeout.TabIndex = 2;
            this.lblDatabaseCommandTimeout.Text = "Command Timeout";
            // 
            // tabMemorySaving
            // 
            this.tabMemorySaving.Controls.Add(this.btnMemorySavingDefault);
            this.tabMemorySaving.Controls.Add(this.lblMemorySavingNotice);
            this.tabMemorySaving.Controls.Add(this.lblMemoryUnassignedAppList);
            this.tabMemorySaving.Controls.Add(this.cbMemoryUnassignedAppList);
            this.tabMemorySaving.Controls.Add(this.lblMemoryAppListRules);
            this.tabMemorySaving.Controls.Add(this.cbMemoryAppListRules);
            this.tabMemorySaving.Controls.Add(this.cbMemoryAppList);
            this.tabMemorySaving.Controls.Add(this.lblMemoryAppList);
            this.tabMemorySaving.Location = new System.Drawing.Point(4, 22);
            this.tabMemorySaving.Name = "tabMemorySaving";
            this.tabMemorySaving.Padding = new System.Windows.Forms.Padding(3);
            this.tabMemorySaving.Size = new System.Drawing.Size(344, 173);
            this.tabMemorySaving.TabIndex = 3;
            this.tabMemorySaving.Text = "Memory Saving";
            this.tabMemorySaving.UseVisualStyleBackColor = true;
            // 
            // btnMemorySavingDefault
            // 
            this.btnMemorySavingDefault.Location = new System.Drawing.Point(260, 141);
            this.btnMemorySavingDefault.Name = "btnMemorySavingDefault";
            this.btnMemorySavingDefault.Size = new System.Drawing.Size(75, 23);
            this.btnMemorySavingDefault.TabIndex = 11;
            this.btnMemorySavingDefault.Text = "Defaults";
            this.btnMemorySavingDefault.UseVisualStyleBackColor = true;
            this.btnMemorySavingDefault.Click += new System.EventHandler(this.btnMemorySavingDefault_Click);
            // 
            // lblMemorySavingNotice
            // 
            this.lblMemorySavingNotice.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMemorySavingNotice.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblMemorySavingNotice.Location = new System.Drawing.Point(6, 91);
            this.lblMemorySavingNotice.Name = "lblMemorySavingNotice";
            this.lblMemorySavingNotice.Size = new System.Drawing.Size(332, 68);
            this.lblMemorySavingNotice.TabIndex = 9;
            this.lblMemorySavingNotice.Text = "Double Buffer makes the Grid Views in this app less-laggy and easier to review, h" +
    "owever this does come with a performance impact.";
            // 
            // lblMemoryUnassignedAppList
            // 
            this.lblMemoryUnassignedAppList.AutoSize = true;
            this.lblMemoryUnassignedAppList.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMemoryUnassignedAppList.Location = new System.Drawing.Point(170, 10);
            this.lblMemoryUnassignedAppList.Name = "lblMemoryUnassignedAppList";
            this.lblMemoryUnassignedAppList.Size = new System.Drawing.Size(143, 16);
            this.lblMemoryUnassignedAppList.TabIndex = 8;
            this.lblMemoryUnassignedAppList.Text = "Unassigned Application List";
            // 
            // cbMemoryUnassignedAppList
            // 
            this.cbMemoryUnassignedAppList.AutoSize = true;
            this.cbMemoryUnassignedAppList.Location = new System.Drawing.Point(173, 29);
            this.cbMemoryUnassignedAppList.Name = "cbMemoryUnassignedAppList";
            this.cbMemoryUnassignedAppList.Size = new System.Drawing.Size(133, 17);
            this.cbMemoryUnassignedAppList.TabIndex = 7;
            this.cbMemoryUnassignedAppList.Text = "Double Buffer Enabled";
            this.cbMemoryUnassignedAppList.UseVisualStyleBackColor = true;
            // 
            // lblMemoryAppListRules
            // 
            this.lblMemoryAppListRules.AutoSize = true;
            this.lblMemoryAppListRules.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMemoryAppListRules.Location = new System.Drawing.Point(6, 52);
            this.lblMemoryAppListRules.Name = "lblMemoryAppListRules";
            this.lblMemoryAppListRules.Size = new System.Drawing.Size(113, 16);
            this.lblMemoryAppListRules.TabIndex = 6;
            this.lblMemoryAppListRules.Text = "Application List Rules";
            // 
            // cbMemoryAppListRules
            // 
            this.cbMemoryAppListRules.AutoSize = true;
            this.cbMemoryAppListRules.Location = new System.Drawing.Point(9, 71);
            this.cbMemoryAppListRules.Name = "cbMemoryAppListRules";
            this.cbMemoryAppListRules.Size = new System.Drawing.Size(133, 17);
            this.cbMemoryAppListRules.TabIndex = 5;
            this.cbMemoryAppListRules.Text = "Double Buffer Enabled";
            this.cbMemoryAppListRules.UseVisualStyleBackColor = true;
            // 
            // cbMemoryAppList
            // 
            this.cbMemoryAppList.AutoSize = true;
            this.cbMemoryAppList.Location = new System.Drawing.Point(9, 29);
            this.cbMemoryAppList.Name = "cbMemoryAppList";
            this.cbMemoryAppList.Size = new System.Drawing.Size(133, 17);
            this.cbMemoryAppList.TabIndex = 4;
            this.cbMemoryAppList.Text = "Double Buffer Enabled";
            this.cbMemoryAppList.UseVisualStyleBackColor = true;
            // 
            // lblMemoryAppList
            // 
            this.lblMemoryAppList.AutoSize = true;
            this.lblMemoryAppList.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMemoryAppList.Location = new System.Drawing.Point(6, 10);
            this.lblMemoryAppList.Name = "lblMemoryAppList";
            this.lblMemoryAppList.Size = new System.Drawing.Size(85, 16);
            this.lblMemoryAppList.TabIndex = 3;
            this.lblMemoryAppList.Text = "Application List";
            // 
            // btnSaveSettings
            // 
            this.btnSaveSettings.Location = new System.Drawing.Point(289, 217);
            this.btnSaveSettings.Name = "btnSaveSettings";
            this.btnSaveSettings.Size = new System.Drawing.Size(75, 23);
            this.btnSaveSettings.TabIndex = 1;
            this.btnSaveSettings.Text = "Save";
            this.btnSaveSettings.UseVisualStyleBackColor = true;
            this.btnSaveSettings.Click += new System.EventHandler(this.btnSaveSettings_Click);
            // 
            // ttAppSettings
            // 
            this.ttAppSettings.IsBalloon = true;
            this.ttAppSettings.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.ttAppSettings.ToolTipTitle = "Application Settings";
            // 
            // FrmSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 247);
            this.Controls.Add(this.btnSaveSettings);
            this.Controls.Add(this.tcAppSettings);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Snow Recognition Database Settings";
            this.Load += new System.EventHandler(this.FrmSettings_Load);
            this.tcAppSettings.ResumeLayout(false);
            this.tabColumns.ResumeLayout(false);
            this.tabColumns.PerformLayout();
            this.tabReporting.ResumeLayout(false);
            this.tabReporting.PerformLayout();
            this.tabDatabaseSettings.ResumeLayout(false);
            this.tabDatabaseSettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDatabaseCommandTimeout)).EndInit();
            this.tabMemorySaving.ResumeLayout(false);
            this.tabMemorySaving.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcAppSettings;
        private System.Windows.Forms.TabPage tabColumns;
        private System.Windows.Forms.TabPage tabReporting;
        private System.Windows.Forms.Button btnSaveSettings;
        private System.Windows.Forms.Label lblAppListColumns;
        private System.Windows.Forms.TextBox txtAppListColumns;
        private System.Windows.Forms.Label lblAppListRules;
        private System.Windows.Forms.TextBox txtAppListRulesColumns;
        private System.Windows.Forms.Label lblUnassignedAppList;
        private System.Windows.Forms.TextBox txtUnassignedAppListColumns;
        private System.Windows.Forms.Label lblColumnsNotice;
        private System.Windows.Forms.Button btnColumnsDefault;
        private System.Windows.Forms.Label lblReportingTableDesign;
        private System.Windows.Forms.ComboBox cblReportingTableDesign;
        private System.Windows.Forms.Button btnReportingDefaults;
        private System.Windows.Forms.Label lblReportingNotice;
        private System.Windows.Forms.Label lblReportingWorkbookTitle;
        private System.Windows.Forms.TextBox txtReportingWorkbookTitle;
        private System.Windows.Forms.TextBox txtReportingWorkbookCompany;
        private System.Windows.Forms.Label lblReportingWorkbookCompany;
        private System.Windows.Forms.Label lblReportingWorksheetName;
        private System.Windows.Forms.TextBox txtReportingWorksheetName;
        private System.Windows.Forms.ToolTip ttAppSettings;
        private System.Windows.Forms.TabPage tabDatabaseSettings;
        private System.Windows.Forms.Label lblDatabaseCommandTimeout;
        private System.Windows.Forms.NumericUpDown numDatabaseCommandTimeout;
        private System.Windows.Forms.Label lblDatabaseNotice;
        private System.Windows.Forms.Button btnDatabaseDefault;
        private System.Windows.Forms.TabPage tabMemorySaving;
        private System.Windows.Forms.Label lblMemoryAppList;
        private System.Windows.Forms.CheckBox cbMemoryAppList;
        private System.Windows.Forms.Label lblMemoryAppListRules;
        private System.Windows.Forms.CheckBox cbMemoryAppListRules;
        private System.Windows.Forms.CheckBox cbMemoryUnassignedAppList;
        private System.Windows.Forms.Label lblMemoryUnassignedAppList;
        private System.Windows.Forms.Label lblMemorySavingNotice;
        private System.Windows.Forms.Button btnMemorySavingDefault;
    }
}
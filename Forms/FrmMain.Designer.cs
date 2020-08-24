namespace SRD
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeConnectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.applicationSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.restartApplicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportDirectoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportAsXlsxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportAsCSVToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewHelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutApplicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabUnassignedList = new System.Windows.Forms.TabPage();
            this.dgvUnassignedList = new System.Windows.Forms.DataGridView();
            this.tabApplicationList = new System.Windows.Forms.TabPage();
            this.scAppList = new System.Windows.Forms.SplitContainer();
            this.dgvAppList = new System.Windows.Forms.DataGridView();
            this.dgvAppListRules = new System.Windows.Forms.DataGridView();
            this.gbSearchResults = new System.Windows.Forms.GroupBox();
            this.lblReturnedRows = new System.Windows.Forms.Label();
            this.gbSearch = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearchCriteria = new System.Windows.Forms.TextBox();
            this.lblSearchCriteria = new System.Windows.Forms.Label();
            this.lblSearchOperator = new System.Windows.Forms.Label();
            this.cSearchOperator = new System.Windows.Forms.ComboBox();
            this.lblSearchColumn = new System.Windows.Forms.Label();
            this.cSearchColumns = new System.Windows.Forms.ComboBox();
            this.btnAppListLoadAll = new System.Windows.Forms.Button();
            this.tcMain = new System.Windows.Forms.TabControl();
            this.cbCustomerPicker = new System.Windows.Forms.ComboBox();
            this.menuStrip1.SuspendLayout();
            this.tabUnassignedList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUnassignedList)).BeginInit();
            this.tabApplicationList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scAppList)).BeginInit();
            this.scAppList.Panel1.SuspendLayout();
            this.scAppList.Panel2.SuspendLayout();
            this.scAppList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppListRules)).BeginInit();
            this.gbSearchResults.SuspendLayout();
            this.gbSearch.SuspendLayout();
            this.tcMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.exportToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(825, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changeConnectionToolStripMenuItem,
            this.toolStripSeparator1,
            this.applicationSettingsToolStripMenuItem,
            this.toolStripSeparator2,
            this.restartApplicationToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // changeConnectionToolStripMenuItem
            // 
            this.changeConnectionToolStripMenuItem.Name = "changeConnectionToolStripMenuItem";
            this.changeConnectionToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.changeConnectionToolStripMenuItem.Text = "Change Connection";
            this.changeConnectionToolStripMenuItem.Click += new System.EventHandler(this.changeConnectionToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // applicationSettingsToolStripMenuItem
            // 
            this.applicationSettingsToolStripMenuItem.Name = "applicationSettingsToolStripMenuItem";
            this.applicationSettingsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.applicationSettingsToolStripMenuItem.Text = "Application Settings";
            this.applicationSettingsToolStripMenuItem.Click += new System.EventHandler(this.applicationSettingsToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(177, 6);
            // 
            // restartApplicationToolStripMenuItem
            // 
            this.restartApplicationToolStripMenuItem.Name = "restartApplicationToolStripMenuItem";
            this.restartApplicationToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.restartApplicationToolStripMenuItem.Text = "Restart Application";
            this.restartApplicationToolStripMenuItem.Click += new System.EventHandler(this.restartApplicationToolStripMenuItem_Click_1);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportDirectoryToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // exportDirectoryToolStripMenuItem
            // 
            this.exportDirectoryToolStripMenuItem.Name = "exportDirectoryToolStripMenuItem";
            this.exportDirectoryToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.exportDirectoryToolStripMenuItem.Text = "Export Directory";
            this.exportDirectoryToolStripMenuItem.Click += new System.EventHandler(this.ExportDirectoryToolStripMenuItem_Click);
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportAsXlsxToolStripMenuItem,
            this.exportAsCSVToolStripMenuItem});
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.exportToolStripMenuItem.Text = "Export (Beta)";
            // 
            // exportAsXlsxToolStripMenuItem
            // 
            this.exportAsXlsxToolStripMenuItem.Name = "exportAsXlsxToolStripMenuItem";
            this.exportAsXlsxToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.exportAsXlsxToolStripMenuItem.Text = "Export as XLSX";
            this.exportAsXlsxToolStripMenuItem.Click += new System.EventHandler(this.ExportAsXlsxToolStripMenuItem_Click);
            // 
            // exportAsCSVToolStripMenuItem
            // 
            this.exportAsCSVToolStripMenuItem.Name = "exportAsCSVToolStripMenuItem";
            this.exportAsCSVToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.exportAsCSVToolStripMenuItem.Text = "Export as CSV";
            this.exportAsCSVToolStripMenuItem.Click += new System.EventHandler(this.ExportAsCSVToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewHelpToolStripMenuItem,
            this.toolStripSeparator3,
            this.aboutApplicationToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // viewHelpToolStripMenuItem
            // 
            this.viewHelpToolStripMenuItem.Name = "viewHelpToolStripMenuItem";
            this.viewHelpToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.viewHelpToolStripMenuItem.Text = "View Help";
            this.viewHelpToolStripMenuItem.Click += new System.EventHandler(this.ViewHelpToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(168, 6);
            // 
            // aboutApplicationToolStripMenuItem
            // 
            this.aboutApplicationToolStripMenuItem.Name = "aboutApplicationToolStripMenuItem";
            this.aboutApplicationToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.aboutApplicationToolStripMenuItem.Text = "About Application";
            this.aboutApplicationToolStripMenuItem.Click += new System.EventHandler(this.AboutApplicationToolStripMenuItem_Click);
            // 
            // tabUnassignedList
            // 
            this.tabUnassignedList.Controls.Add(this.dgvUnassignedList);
            this.tabUnassignedList.Location = new System.Drawing.Point(4, 22);
            this.tabUnassignedList.Name = "tabUnassignedList";
            this.tabUnassignedList.Padding = new System.Windows.Forms.Padding(3);
            this.tabUnassignedList.Size = new System.Drawing.Size(655, 451);
            this.tabUnassignedList.TabIndex = 1;
            this.tabUnassignedList.Text = "Unassiged Applications";
            this.tabUnassignedList.UseVisualStyleBackColor = true;
            // 
            // dgvUnassignedList
            // 
            this.dgvUnassignedList.AllowUserToAddRows = false;
            this.dgvUnassignedList.AllowUserToDeleteRows = false;
            this.dgvUnassignedList.AllowUserToResizeRows = false;
            this.dgvUnassignedList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvUnassignedList.BackgroundColor = System.Drawing.Color.LightGray;
            this.dgvUnassignedList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUnassignedList.Location = new System.Drawing.Point(0, 0);
            this.dgvUnassignedList.MultiSelect = false;
            this.dgvUnassignedList.Name = "dgvUnassignedList";
            this.dgvUnassignedList.ReadOnly = true;
            this.dgvUnassignedList.Size = new System.Drawing.Size(655, 451);
            this.dgvUnassignedList.TabIndex = 6;
            this.dgvUnassignedList.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUnassignedList_CellContentDoubleClick);
            this.dgvUnassignedList.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dgvRowPostPaint);
            // 
            // tabApplicationList
            // 
            this.tabApplicationList.Controls.Add(this.scAppList);
            this.tabApplicationList.Location = new System.Drawing.Point(4, 22);
            this.tabApplicationList.Name = "tabApplicationList";
            this.tabApplicationList.Padding = new System.Windows.Forms.Padding(3);
            this.tabApplicationList.Size = new System.Drawing.Size(655, 451);
            this.tabApplicationList.TabIndex = 0;
            this.tabApplicationList.Text = "Application List";
            this.tabApplicationList.UseVisualStyleBackColor = true;
            // 
            // scAppList
            // 
            this.scAppList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.scAppList.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.scAppList.Location = new System.Drawing.Point(0, 0);
            this.scAppList.Name = "scAppList";
            this.scAppList.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // scAppList.Panel1
            // 
            this.scAppList.Panel1.Controls.Add(this.dgvAppList);
            // 
            // scAppList.Panel2
            // 
            this.scAppList.Panel2.Controls.Add(this.dgvAppListRules);
            this.scAppList.Panel2Collapsed = true;
            this.scAppList.Size = new System.Drawing.Size(655, 451);
            this.scAppList.SplitterDistance = 302;
            this.scAppList.TabIndex = 5;
            // 
            // dgvAppList
            // 
            this.dgvAppList.AllowUserToAddRows = false;
            this.dgvAppList.AllowUserToDeleteRows = false;
            this.dgvAppList.AllowUserToResizeRows = false;
            this.dgvAppList.BackgroundColor = System.Drawing.Color.LightGray;
            this.dgvAppList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAppList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAppList.Location = new System.Drawing.Point(0, 0);
            this.dgvAppList.MultiSelect = false;
            this.dgvAppList.Name = "dgvAppList";
            this.dgvAppList.ReadOnly = true;
            this.dgvAppList.Size = new System.Drawing.Size(655, 451);
            this.dgvAppList.TabIndex = 8;
            this.dgvAppList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAppList_CellContentClick);
            this.dgvAppList.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dgvRowPostPaint);
            // 
            // dgvAppListRules
            // 
            this.dgvAppListRules.AllowUserToAddRows = false;
            this.dgvAppListRules.AllowUserToDeleteRows = false;
            this.dgvAppListRules.AllowUserToResizeRows = false;
            this.dgvAppListRules.BackgroundColor = System.Drawing.Color.LightGray;
            this.dgvAppListRules.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAppListRules.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAppListRules.Location = new System.Drawing.Point(0, 0);
            this.dgvAppListRules.MultiSelect = false;
            this.dgvAppListRules.Name = "dgvAppListRules";
            this.dgvAppListRules.ReadOnly = true;
            this.dgvAppListRules.Size = new System.Drawing.Size(150, 46);
            this.dgvAppListRules.TabIndex = 7;
            this.dgvAppListRules.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dgvRowPostPaint);
            // 
            // gbSearchResults
            // 
            this.gbSearchResults.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.gbSearchResults.Controls.Add(this.lblReturnedRows);
            this.gbSearchResults.Location = new System.Drawing.Point(7, 448);
            this.gbSearchResults.Name = "gbSearchResults";
            this.gbSearchResults.Size = new System.Drawing.Size(149, 49);
            this.gbSearchResults.TabIndex = 4;
            this.gbSearchResults.TabStop = false;
            this.gbSearchResults.Text = "Search Results";
            // 
            // lblReturnedRows
            // 
            this.lblReturnedRows.AutoSize = true;
            this.lblReturnedRows.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReturnedRows.Location = new System.Drawing.Point(6, 22);
            this.lblReturnedRows.Name = "lblReturnedRows";
            this.lblReturnedRows.Size = new System.Drawing.Size(0, 16);
            this.lblReturnedRows.TabIndex = 0;
            // 
            // gbSearch
            // 
            this.gbSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.gbSearch.Controls.Add(this.btnSearch);
            this.gbSearch.Controls.Add(this.txtSearchCriteria);
            this.gbSearch.Controls.Add(this.lblSearchCriteria);
            this.gbSearch.Controls.Add(this.lblSearchOperator);
            this.gbSearch.Controls.Add(this.cSearchOperator);
            this.gbSearch.Controls.Add(this.lblSearchColumn);
            this.gbSearch.Controls.Add(this.cSearchColumns);
            this.gbSearch.Location = new System.Drawing.Point(7, 83);
            this.gbSearch.Name = "gbSearch";
            this.gbSearch.Size = new System.Drawing.Size(149, 359);
            this.gbSearch.TabIndex = 2;
            this.gbSearch.TabStop = false;
            this.gbSearch.Text = "Search Criteria (Optional)";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(5, 150);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(139, 23);
            this.btnSearch.TabIndex = 14;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnAppListSearch_Click);
            // 
            // txtSearchCriteria
            // 
            this.txtSearchCriteria.Location = new System.Drawing.Point(5, 124);
            this.txtSearchCriteria.Name = "txtSearchCriteria";
            this.txtSearchCriteria.Size = new System.Drawing.Size(139, 20);
            this.txtSearchCriteria.TabIndex = 13;
            // 
            // lblSearchCriteria
            // 
            this.lblSearchCriteria.AutoSize = true;
            this.lblSearchCriteria.Location = new System.Drawing.Point(4, 108);
            this.lblSearchCriteria.Name = "lblSearchCriteria";
            this.lblSearchCriteria.Size = new System.Drawing.Size(39, 13);
            this.lblSearchCriteria.TabIndex = 12;
            this.lblSearchCriteria.Text = "Criteria";
            // 
            // lblSearchOperator
            // 
            this.lblSearchOperator.AutoSize = true;
            this.lblSearchOperator.Location = new System.Drawing.Point(4, 65);
            this.lblSearchOperator.Name = "lblSearchOperator";
            this.lblSearchOperator.Size = new System.Drawing.Size(48, 13);
            this.lblSearchOperator.TabIndex = 9;
            this.lblSearchOperator.Text = "Operator";
            // 
            // cSearchOperator
            // 
            this.cSearchOperator.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cSearchOperator.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cSearchOperator.FormattingEnabled = true;
            this.cSearchOperator.Items.AddRange(new object[] {
            "=",
            "LIKE",
            "NOT LIKE"});
            this.cSearchOperator.Location = new System.Drawing.Point(5, 81);
            this.cSearchOperator.Margin = new System.Windows.Forms.Padding(2);
            this.cSearchOperator.Name = "cSearchOperator";
            this.cSearchOperator.Size = new System.Drawing.Size(139, 21);
            this.cSearchOperator.TabIndex = 8;
            // 
            // lblSearchColumn
            // 
            this.lblSearchColumn.AutoSize = true;
            this.lblSearchColumn.Location = new System.Drawing.Point(4, 21);
            this.lblSearchColumn.Name = "lblSearchColumn";
            this.lblSearchColumn.Size = new System.Drawing.Size(42, 13);
            this.lblSearchColumn.TabIndex = 7;
            this.lblSearchColumn.Text = "Column";
            // 
            // cSearchColumns
            // 
            this.cSearchColumns.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cSearchColumns.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cSearchColumns.FormattingEnabled = true;
            this.cSearchColumns.Location = new System.Drawing.Point(5, 37);
            this.cSearchColumns.Margin = new System.Windows.Forms.Padding(2);
            this.cSearchColumns.Name = "cSearchColumns";
            this.cSearchColumns.Size = new System.Drawing.Size(139, 21);
            this.cSearchColumns.TabIndex = 6;
            // 
            // btnAppListLoadAll
            // 
            this.btnAppListLoadAll.Location = new System.Drawing.Point(7, 27);
            this.btnAppListLoadAll.Name = "btnAppListLoadAll";
            this.btnAppListLoadAll.Size = new System.Drawing.Size(149, 23);
            this.btnAppListLoadAll.TabIndex = 1;
            this.btnAppListLoadAll.Text = "Show Data";
            this.btnAppListLoadAll.UseVisualStyleBackColor = true;
            this.btnAppListLoadAll.Click += new System.EventHandler(this.btnAppListLoadAll_Click);
            // 
            // tcMain
            // 
            this.tcMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tcMain.Controls.Add(this.tabApplicationList);
            this.tcMain.Controls.Add(this.tabUnassignedList);
            this.tcMain.Location = new System.Drawing.Point(162, 27);
            this.tcMain.Name = "tcMain";
            this.tcMain.SelectedIndex = 0;
            this.tcMain.Size = new System.Drawing.Size(663, 477);
            this.tcMain.TabIndex = 0;
            this.tcMain.SelectedIndexChanged += new System.EventHandler(this.tcMain_SelectedIndexChanged);
            // 
            // cbCustomerPicker
            // 
            this.cbCustomerPicker.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCustomerPicker.FormattingEnabled = true;
            this.cbCustomerPicker.Location = new System.Drawing.Point(7, 56);
            this.cbCustomerPicker.Name = "cbCustomerPicker";
            this.cbCustomerPicker.Size = new System.Drawing.Size(149, 21);
            this.cbCustomerPicker.TabIndex = 5;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(825, 501);
            this.Controls.Add(this.cbCustomerPicker);
            this.Controls.Add(this.tcMain);
            this.Controls.Add(this.btnAppListLoadAll);
            this.Controls.Add(this.gbSearchResults);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.gbSearch);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(841, 540);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Snow Recognition Database";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmMain_FormClosed);
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabUnassignedList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUnassignedList)).EndInit();
            this.tabApplicationList.ResumeLayout(false);
            this.scAppList.Panel1.ResumeLayout(false);
            this.scAppList.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scAppList)).EndInit();
            this.scAppList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppListRules)).EndInit();
            this.gbSearchResults.ResumeLayout(false);
            this.gbSearchResults.PerformLayout();
            this.gbSearch.ResumeLayout(false);
            this.gbSearch.PerformLayout();
            this.tcMain.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeConnectionToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem applicationSettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem viewHelpToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem aboutApplicationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem restartApplicationToolStripMenuItem;
        private System.Windows.Forms.TabPage tabUnassignedList;
        private System.Windows.Forms.DataGridView dgvUnassignedList;
        private System.Windows.Forms.TabPage tabApplicationList;
        private System.Windows.Forms.GroupBox gbSearchResults;
        private System.Windows.Forms.Label lblReturnedRows;
        private System.Windows.Forms.GroupBox gbSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearchCriteria;
        private System.Windows.Forms.Label lblSearchCriteria;
        private System.Windows.Forms.Label lblSearchOperator;
        internal System.Windows.Forms.ComboBox cSearchOperator;
        private System.Windows.Forms.Label lblSearchColumn;
        internal System.Windows.Forms.ComboBox cSearchColumns;
        private System.Windows.Forms.Button btnAppListLoadAll;
        private System.Windows.Forms.TabControl tcMain;
        private System.Windows.Forms.SplitContainer scAppList;
        private System.Windows.Forms.DataGridView dgvAppList;
        private System.Windows.Forms.DataGridView dgvAppListRules;
        private System.Windows.Forms.ToolStripMenuItem exportDirectoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportAsXlsxToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportAsCSVToolStripMenuItem;
        private System.Windows.Forms.ComboBox cbCustomerPicker;
    }
}


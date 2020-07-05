namespace SRD.Forms
{
    partial class FrmDgvPopup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDgvPopup));
            this.dgvPopup = new System.Windows.Forms.DataGridView();
            this.btnDgvPopupExportCsv = new System.Windows.Forms.Button();
            this.btnDgvPopupExportXlsx = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPopup)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPopup
            // 
            this.dgvPopup.AllowUserToAddRows = false;
            this.dgvPopup.AllowUserToDeleteRows = false;
            this.dgvPopup.AllowUserToResizeRows = false;
            this.dgvPopup.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPopup.BackgroundColor = System.Drawing.Color.LightGray;
            this.dgvPopup.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPopup.Location = new System.Drawing.Point(0, 0);
            this.dgvPopup.MultiSelect = false;
            this.dgvPopup.Name = "dgvPopup";
            this.dgvPopup.ReadOnly = true;
            this.dgvPopup.Size = new System.Drawing.Size(694, 303);
            this.dgvPopup.TabIndex = 7;
            // 
            // btnDgvPopupExportCsv
            // 
            this.btnDgvPopupExportCsv.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDgvPopupExportCsv.Location = new System.Drawing.Point(583, 309);
            this.btnDgvPopupExportCsv.Name = "btnDgvPopupExportCsv";
            this.btnDgvPopupExportCsv.Size = new System.Drawing.Size(99, 23);
            this.btnDgvPopupExportCsv.TabIndex = 8;
            this.btnDgvPopupExportCsv.Text = "Export as CSV";
            this.btnDgvPopupExportCsv.UseVisualStyleBackColor = true;
            this.btnDgvPopupExportCsv.Click += new System.EventHandler(this.btnDgvPopupExportCsv_Click);
            // 
            // btnDgvPopupExportXlsx
            // 
            this.btnDgvPopupExportXlsx.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDgvPopupExportXlsx.Location = new System.Drawing.Point(478, 309);
            this.btnDgvPopupExportXlsx.Name = "btnDgvPopupExportXlsx";
            this.btnDgvPopupExportXlsx.Size = new System.Drawing.Size(99, 23);
            this.btnDgvPopupExportXlsx.TabIndex = 9;
            this.btnDgvPopupExportXlsx.Text = "Export as XLSX";
            this.btnDgvPopupExportXlsx.UseVisualStyleBackColor = true;
            this.btnDgvPopupExportXlsx.Click += new System.EventHandler(this.btnDgvPopupExportXlsx_Click);
            // 
            // FrmDgvPopup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 339);
            this.Controls.Add(this.btnDgvPopupExportXlsx);
            this.Controls.Add(this.btnDgvPopupExportCsv);
            this.Controls.Add(this.dgvPopup);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(710, 378);
            this.Name = "FrmDgvPopup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Data Popup";
            this.Load += new System.EventHandler(this.FrmDgvPopup_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPopup)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPopup;
        private System.Windows.Forms.Button btnDgvPopupExportCsv;
        private System.Windows.Forms.Button btnDgvPopupExportXlsx;
    }
}
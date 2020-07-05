namespace SRD.Forms
{
    partial class FrmStartup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmStartup));
            this.lblAppName = new System.Windows.Forms.Label();
            this.cbConnectionList = new System.Windows.Forms.ComboBox();
            this.btnStartProgram = new System.Windows.Forms.Button();
            this.btnNewConnection = new System.Windows.Forms.Button();
            this.lblNotice = new System.Windows.Forms.Label();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAppName
            // 
            this.lblAppName.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppName.Location = new System.Drawing.Point(-1, 124);
            this.lblAppName.Name = "lblAppName";
            this.lblAppName.Size = new System.Drawing.Size(348, 29);
            this.lblAppName.TabIndex = 1;
            this.lblAppName.Text = "Snow Recognition Database";
            this.lblAppName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbConnectionList
            // 
            this.cbConnectionList.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbConnectionList.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbConnectionList.BackColor = System.Drawing.Color.White;
            this.cbConnectionList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbConnectionList.FormattingEnabled = true;
            this.cbConnectionList.Location = new System.Drawing.Point(38, 156);
            this.cbConnectionList.MaxDropDownItems = 100;
            this.cbConnectionList.Name = "cbConnectionList";
            this.cbConnectionList.Size = new System.Drawing.Size(270, 21);
            this.cbConnectionList.TabIndex = 2;
            this.cbConnectionList.SelectedIndexChanged += new System.EventHandler(this.cbConnectionList_SelectedIndexChanged);
            // 
            // btnStartProgram
            // 
            this.btnStartProgram.Location = new System.Drawing.Point(38, 231);
            this.btnStartProgram.Name = "btnStartProgram";
            this.btnStartProgram.Size = new System.Drawing.Size(102, 23);
            this.btnStartProgram.TabIndex = 3;
            this.btnStartProgram.Text = "Start Program";
            this.btnStartProgram.UseVisualStyleBackColor = true;
            this.btnStartProgram.Click += new System.EventHandler(this.btnStartProgram_Click);
            // 
            // btnNewConnection
            // 
            this.btnNewConnection.Location = new System.Drawing.Point(206, 231);
            this.btnNewConnection.Name = "btnNewConnection";
            this.btnNewConnection.Size = new System.Drawing.Size(102, 23);
            this.btnNewConnection.TabIndex = 4;
            this.btnNewConnection.Text = "New Connection";
            this.btnNewConnection.UseVisualStyleBackColor = true;
            this.btnNewConnection.Click += new System.EventHandler(this.btnNewConnection_Click);
            // 
            // lblNotice
            // 
            this.lblNotice.Location = new System.Drawing.Point(4, 180);
            this.lblNotice.Name = "lblNotice";
            this.lblNotice.Size = new System.Drawing.Size(343, 48);
            this.lblNotice.TabIndex = 5;
            this.lblNotice.Text = "You can change the connection you are using\r\nafter the program loads. Click the L" +
    "ogo to refresh\r\nthe connection list if required.";
            this.lblNotice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbLogo
            // 
            this.pbLogo.Image = global::SRD.Properties.Resources.cold;
            this.pbLogo.Location = new System.Drawing.Point(118, 11);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(110, 110);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLogo.TabIndex = 0;
            this.pbLogo.TabStop = false;
            this.pbLogo.Click += new System.EventHandler(this.pbLogo_Click);
            // 
            // FrmStartup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(347, 266);
            this.Controls.Add(this.lblNotice);
            this.Controls.Add(this.btnNewConnection);
            this.Controls.Add(this.btnStartProgram);
            this.Controls.Add(this.cbConnectionList);
            this.Controls.Add(this.lblAppName);
            this.Controls.Add(this.pbLogo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmStartup";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Snow Recognition Database";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmStartup_Closing);
            this.Load += new System.EventHandler(this.FrmStartup_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Label lblAppName;
        private System.Windows.Forms.ComboBox cbConnectionList;
        private System.Windows.Forms.Button btnStartProgram;
        private System.Windows.Forms.Button btnNewConnection;
        private System.Windows.Forms.Label lblNotice;
    }
}
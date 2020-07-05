namespace SRD.Forms
{
    partial class FrmAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAbout));
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.lblAppName = new System.Windows.Forms.Label();
            this.lblAppVersion = new System.Windows.Forms.Label();
            this.lblAppCopyright = new System.Windows.Forms.Label();
            this.linkDeveloperLink = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pbLogo
            // 
            this.pbLogo.Image = global::SRD.Properties.Resources.cold;
            this.pbLogo.Location = new System.Drawing.Point(12, 12);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Padding = new System.Windows.Forms.Padding(0, 0, 55, 0);
            this.pbLogo.Size = new System.Drawing.Size(136, 180);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLogo.TabIndex = 0;
            this.pbLogo.TabStop = false;
            // 
            // lblAppName
            // 
            this.lblAppName.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppName.Location = new System.Drawing.Point(150, 54);
            this.lblAppName.Name = "lblAppName";
            this.lblAppName.Size = new System.Drawing.Size(315, 28);
            this.lblAppName.TabIndex = 1;
            this.lblAppName.Text = "{AppName}";
            this.lblAppName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblAppVersion
            // 
            this.lblAppVersion.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppVersion.Location = new System.Drawing.Point(152, 82);
            this.lblAppVersion.Name = "lblAppVersion";
            this.lblAppVersion.Size = new System.Drawing.Size(315, 28);
            this.lblAppVersion.TabIndex = 2;
            this.lblAppVersion.Text = "{AppVersion}";
            this.lblAppVersion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblAppCopyright
            // 
            this.lblAppCopyright.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppCopyright.Location = new System.Drawing.Point(154, 110);
            this.lblAppCopyright.Name = "lblAppCopyright";
            this.lblAppCopyright.Size = new System.Drawing.Size(315, 28);
            this.lblAppCopyright.TabIndex = 3;
            this.lblAppCopyright.Text = "{Copyright}";
            this.lblAppCopyright.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // linkDeveloperLink
            // 
            this.linkDeveloperLink.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(101)))), ((int)(((byte)(191)))));
            this.linkDeveloperLink.AutoSize = true;
            this.linkDeveloperLink.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkDeveloperLink.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(101)))), ((int)(((byte)(191)))));
            this.linkDeveloperLink.Location = new System.Drawing.Point(154, 138);
            this.linkDeveloperLink.Name = "linkDeveloperLink";
            this.linkDeveloperLink.Size = new System.Drawing.Size(96, 16);
            this.linkDeveloperLink.TabIndex = 4;
            this.linkDeveloperLink.TabStop = true;
            this.linkDeveloperLink.Text = "https://laim.scot";
            this.linkDeveloperLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkDeveloperLink_LinkClicked);
            // 
            // FrmAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(467, 209);
            this.Controls.Add(this.linkDeveloperLink);
            this.Controls.Add(this.lblAppCopyright);
            this.Controls.Add(this.lblAppVersion);
            this.Controls.Add(this.pbLogo);
            this.Controls.Add(this.lblAppName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmAbout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "About Snow Recognition Database";
            this.Load += new System.EventHandler(this.FrmAbout_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Label lblAppName;
        private System.Windows.Forms.Label lblAppVersion;
        private System.Windows.Forms.Label lblAppCopyright;
        private System.Windows.Forms.LinkLabel linkDeveloperLink;
    }
}
namespace SRD.Forms
{
    partial class FrmConnectionNew
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConnectionNew));
            this.cbSqlServer = new System.Windows.Forms.ComboBox();
            this.lblSqlServer = new System.Windows.Forms.Label();
            this.gbAuthenticationMethod = new System.Windows.Forms.GroupBox();
            this.rbWindowsAuth = new System.Windows.Forms.RadioButton();
            this.rbSqlAuth = new System.Windows.Forms.RadioButton();
            this.lblSqlUsername = new System.Windows.Forms.Label();
            this.txtSqlUsername = new System.Windows.Forms.TextBox();
            this.lblSqlPassword = new System.Windows.Forms.Label();
            this.txtSqlPassword = new System.Windows.Forms.TextBox();
            this.btnTest = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblConnectionParameters = new System.Windows.Forms.Label();
            this.txtSqlParameters = new System.Windows.Forms.TextBox();
            this.txtConnectionName = new System.Windows.Forms.TextBox();
            this.lblConnectionName = new System.Windows.Forms.Label();
            this.ttNewConnection = new System.Windows.Forms.ToolTip(this.components);
            this.gbAuthenticationMethod.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbSqlServer
            // 
            this.cbSqlServer.FormattingEnabled = true;
            this.cbSqlServer.Location = new System.Drawing.Point(12, 60);
            this.cbSqlServer.Name = "cbSqlServer";
            this.cbSqlServer.Size = new System.Drawing.Size(196, 21);
            this.cbSqlServer.TabIndex = 2;
            // 
            // lblSqlServer
            // 
            this.lblSqlServer.AutoSize = true;
            this.lblSqlServer.Location = new System.Drawing.Point(9, 44);
            this.lblSqlServer.Name = "lblSqlServer";
            this.lblSqlServer.Size = new System.Drawing.Size(62, 13);
            this.lblSqlServer.TabIndex = 1;
            this.lblSqlServer.Text = "SQL Server";
            // 
            // gbAuthenticationMethod
            // 
            this.gbAuthenticationMethod.Controls.Add(this.rbWindowsAuth);
            this.gbAuthenticationMethod.Controls.Add(this.rbSqlAuth);
            this.gbAuthenticationMethod.Location = new System.Drawing.Point(12, 87);
            this.gbAuthenticationMethod.Name = "gbAuthenticationMethod";
            this.gbAuthenticationMethod.Size = new System.Drawing.Size(196, 72);
            this.gbAuthenticationMethod.TabIndex = 3;
            this.gbAuthenticationMethod.TabStop = false;
            this.gbAuthenticationMethod.Text = "Authentication Method";
            // 
            // rbWindowsAuth
            // 
            this.rbWindowsAuth.AutoSize = true;
            this.rbWindowsAuth.Checked = true;
            this.rbWindowsAuth.Location = new System.Drawing.Point(6, 42);
            this.rbWindowsAuth.Name = "rbWindowsAuth";
            this.rbWindowsAuth.Size = new System.Drawing.Size(140, 17);
            this.rbWindowsAuth.TabIndex = 5;
            this.rbWindowsAuth.TabStop = true;
            this.rbWindowsAuth.Text = "Windows Authentication";
            this.rbWindowsAuth.UseVisualStyleBackColor = true;
            this.rbWindowsAuth.CheckedChanged += new System.EventHandler(this.rbWindowsAuth_CheckedChanged);
            // 
            // rbSqlAuth
            // 
            this.rbSqlAuth.AutoSize = true;
            this.rbSqlAuth.Location = new System.Drawing.Point(6, 19);
            this.rbSqlAuth.Name = "rbSqlAuth";
            this.rbSqlAuth.Size = new System.Drawing.Size(151, 17);
            this.rbSqlAuth.TabIndex = 4;
            this.rbSqlAuth.TabStop = true;
            this.rbSqlAuth.Text = "SQL Server Authentication";
            this.rbSqlAuth.UseVisualStyleBackColor = true;
            // 
            // lblSqlUsername
            // 
            this.lblSqlUsername.AutoSize = true;
            this.lblSqlUsername.Location = new System.Drawing.Point(9, 162);
            this.lblSqlUsername.Name = "lblSqlUsername";
            this.lblSqlUsername.Size = new System.Drawing.Size(53, 13);
            this.lblSqlUsername.TabIndex = 3;
            this.lblSqlUsername.Text = "SQL User";
            // 
            // txtSqlUsername
            // 
            this.txtSqlUsername.Location = new System.Drawing.Point(12, 178);
            this.txtSqlUsername.Name = "txtSqlUsername";
            this.txtSqlUsername.Size = new System.Drawing.Size(196, 20);
            this.txtSqlUsername.TabIndex = 6;
            // 
            // lblSqlPassword
            // 
            this.lblSqlPassword.AutoSize = true;
            this.lblSqlPassword.Location = new System.Drawing.Point(9, 201);
            this.lblSqlPassword.Name = "lblSqlPassword";
            this.lblSqlPassword.Size = new System.Drawing.Size(77, 13);
            this.lblSqlPassword.TabIndex = 5;
            this.lblSqlPassword.Text = "SQL Password";
            // 
            // txtSqlPassword
            // 
            this.txtSqlPassword.Location = new System.Drawing.Point(12, 217);
            this.txtSqlPassword.Name = "txtSqlPassword";
            this.txtSqlPassword.PasswordChar = '*';
            this.txtSqlPassword.Size = new System.Drawing.Size(196, 20);
            this.txtSqlPassword.TabIndex = 7;
            // 
            // btnTest
            // 
            this.btnTest.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTest.Location = new System.Drawing.Point(12, 282);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(95, 23);
            this.btnTest.TabIndex = 10;
            this.btnTest.Text = "Test Connection";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Enabled = false;
            this.btnSave.Location = new System.Drawing.Point(133, 282);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblConnectionParameters
            // 
            this.lblConnectionParameters.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblConnectionParameters.AutoSize = true;
            this.lblConnectionParameters.Location = new System.Drawing.Point(9, 240);
            this.lblConnectionParameters.Name = "lblConnectionParameters";
            this.lblConnectionParameters.Size = new System.Drawing.Size(166, 13);
            this.lblConnectionParameters.TabIndex = 9;
            this.lblConnectionParameters.Text = "Additional Connection Parameters";
            this.ttNewConnection.SetToolTip(this.lblConnectionParameters, "If you need to add additional parameters, start the string with a \r\nsemicolon and" +
        " seperate each parameter with a semi colon.");
            // 
            // txtSqlParameters
            // 
            this.txtSqlParameters.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSqlParameters.Location = new System.Drawing.Point(12, 256);
            this.txtSqlParameters.Name = "txtSqlParameters";
            this.txtSqlParameters.Size = new System.Drawing.Size(196, 20);
            this.txtSqlParameters.TabIndex = 9;
            // 
            // txtConnectionName
            // 
            this.txtConnectionName.Location = new System.Drawing.Point(12, 21);
            this.txtConnectionName.Name = "txtConnectionName";
            this.txtConnectionName.Size = new System.Drawing.Size(196, 20);
            this.txtConnectionName.TabIndex = 1;
            // 
            // lblConnectionName
            // 
            this.lblConnectionName.AutoSize = true;
            this.lblConnectionName.Location = new System.Drawing.Point(9, 5);
            this.lblConnectionName.Name = "lblConnectionName";
            this.lblConnectionName.Size = new System.Drawing.Size(92, 13);
            this.lblConnectionName.TabIndex = 12;
            this.lblConnectionName.Text = "Connection Name";
            // 
            // ttNewConnection
            // 
            this.ttNewConnection.IsBalloon = true;
            this.ttNewConnection.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.ttNewConnection.ToolTipTitle = "New Connection";
            // 
            // FrmConnectionNew
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(223, 314);
            this.Controls.Add(this.lblConnectionName);
            this.Controls.Add(this.txtConnectionName);
            this.Controls.Add(this.txtSqlParameters);
            this.Controls.Add(this.lblConnectionParameters);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnTest);
            this.Controls.Add(this.txtSqlPassword);
            this.Controls.Add(this.lblSqlPassword);
            this.Controls.Add(this.txtSqlUsername);
            this.Controls.Add(this.lblSqlUsername);
            this.Controls.Add(this.gbAuthenticationMethod);
            this.Controls.Add(this.lblSqlServer);
            this.Controls.Add(this.cbSqlServer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmConnectionNew";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "New Connection";
            this.Load += new System.EventHandler(this.FrmConnectionNew_Load);
            this.gbAuthenticationMethod.ResumeLayout(false);
            this.gbAuthenticationMethod.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbSqlServer;
        private System.Windows.Forms.Label lblSqlServer;
        private System.Windows.Forms.GroupBox gbAuthenticationMethod;
        private System.Windows.Forms.RadioButton rbWindowsAuth;
        private System.Windows.Forms.RadioButton rbSqlAuth;
        private System.Windows.Forms.Label lblSqlUsername;
        private System.Windows.Forms.TextBox txtSqlUsername;
        private System.Windows.Forms.Label lblSqlPassword;
        private System.Windows.Forms.TextBox txtSqlPassword;
        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblConnectionParameters;
        private System.Windows.Forms.TextBox txtSqlParameters;
        private System.Windows.Forms.TextBox txtConnectionName;
        private System.Windows.Forms.Label lblConnectionName;
        private System.Windows.Forms.ToolTip ttNewConnection;
    }
}
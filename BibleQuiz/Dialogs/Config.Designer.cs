namespace BibleQuiz.Dialogs
{
    partial class Config
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
            this.tlpMain = new System.Windows.Forms.TableLayoutPanel();
            this.btnClose = new System.Windows.Forms.Button();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtDatabase = new System.Windows.Forms.TextBox();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtServer = new System.Windows.Forms.TextBox();
            this.lblDatabase = new System.Windows.Forms.Label();
            this.lblPort = new System.Windows.Forms.Label();
            this.lblConnectionStatus = new System.Windows.Forms.Label();
            this.lblServer = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.btnUpdateConfig = new System.Windows.Forms.Button();
            this.lblConnection = new System.Windows.Forms.Label();
            this.tlpMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpMain
            // 
            this.tlpMain.BackColor = System.Drawing.Color.Gold;
            this.tlpMain.ColumnCount = 2;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.Controls.Add(this.btnClose, 0, 7);
            this.tlpMain.Controls.Add(this.txtUser, 1, 5);
            this.tlpMain.Controls.Add(this.txtDatabase, 1, 4);
            this.tlpMain.Controls.Add(this.txtPort, 1, 3);
            this.tlpMain.Controls.Add(this.txtPassword, 1, 6);
            this.tlpMain.Controls.Add(this.lblPassword, 0, 6);
            this.tlpMain.Controls.Add(this.txtServer, 1, 2);
            this.tlpMain.Controls.Add(this.lblDatabase, 0, 4);
            this.tlpMain.Controls.Add(this.lblPort, 0, 3);
            this.tlpMain.Controls.Add(this.lblConnectionStatus, 0, 0);
            this.tlpMain.Controls.Add(this.lblServer, 0, 2);
            this.tlpMain.Controls.Add(this.lblUser, 0, 5);
            this.tlpMain.Controls.Add(this.btnUpdateConfig, 1, 7);
            this.tlpMain.Controls.Add(this.lblConnection, 0, 1);
            this.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMain.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.tlpMain.Location = new System.Drawing.Point(5, 5);
            this.tlpMain.Margin = new System.Windows.Forms.Padding(0);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.RowCount = 8;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpMain.Size = new System.Drawing.Size(214, 251);
            this.tlpMain.TabIndex = 3;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnClose.AutoSize = true;
            this.btnClose.BackColor = System.Drawing.Color.DarkGreen;
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.Gold;
            this.btnClose.Location = new System.Drawing.Point(5, 213);
            this.btnClose.Margin = new System.Windows.Forms.Padding(5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(56, 33);
            this.btnClose.TabIndex = 19;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // txtUser
            // 
            this.txtUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUser.BackColor = System.Drawing.Color.Snow;
            this.txtUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUser.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold);
            this.txtUser.ForeColor = System.Drawing.Color.Black;
            this.txtUser.Location = new System.Drawing.Point(104, 156);
            this.txtUser.Margin = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(105, 26);
            this.txtUser.TabIndex = 18;
            this.txtUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtDatabase
            // 
            this.txtDatabase.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDatabase.BackColor = System.Drawing.Color.Snow;
            this.txtDatabase.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDatabase.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold);
            this.txtDatabase.ForeColor = System.Drawing.Color.Black;
            this.txtDatabase.Location = new System.Drawing.Point(104, 130);
            this.txtDatabase.Margin = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.txtDatabase.Name = "txtDatabase";
            this.txtDatabase.Size = new System.Drawing.Size(105, 26);
            this.txtDatabase.TabIndex = 17;
            this.txtDatabase.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtPort
            // 
            this.txtPort.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPort.BackColor = System.Drawing.Color.Snow;
            this.txtPort.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPort.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold);
            this.txtPort.ForeColor = System.Drawing.Color.Black;
            this.txtPort.Location = new System.Drawing.Point(104, 104);
            this.txtPort.Margin = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(105, 26);
            this.txtPort.TabIndex = 16;
            this.txtPort.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtPassword
            // 
            this.txtPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPassword.BackColor = System.Drawing.Color.Snow;
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPassword.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold);
            this.txtPassword.ForeColor = System.Drawing.Color.Black;
            this.txtPassword.Location = new System.Drawing.Point(104, 182);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(105, 26);
            this.txtPassword.TabIndex = 15;
            this.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblPassword
            // 
            this.lblPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPassword.AutoSize = true;
            this.lblPassword.BackColor = System.Drawing.Color.Black;
            this.lblPassword.Font = new System.Drawing.Font("Copperplate Gothic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.ForeColor = System.Drawing.Color.Gold;
            this.lblPassword.Location = new System.Drawing.Point(5, 182);
            this.lblPassword.Margin = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(99, 26);
            this.lblPassword.TabIndex = 14;
            this.lblPassword.Text = "Password";
            this.lblPassword.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtServer
            // 
            this.txtServer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtServer.BackColor = System.Drawing.Color.Snow;
            this.txtServer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtServer.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold);
            this.txtServer.ForeColor = System.Drawing.Color.Black;
            this.txtServer.Location = new System.Drawing.Point(104, 78);
            this.txtServer.Margin = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.txtServer.Name = "txtServer";
            this.txtServer.Size = new System.Drawing.Size(105, 26);
            this.txtServer.TabIndex = 13;
            this.txtServer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblDatabase
            // 
            this.lblDatabase.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDatabase.AutoSize = true;
            this.lblDatabase.BackColor = System.Drawing.Color.Black;
            this.lblDatabase.Font = new System.Drawing.Font("Copperplate Gothic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatabase.ForeColor = System.Drawing.Color.Gold;
            this.lblDatabase.Location = new System.Drawing.Point(5, 130);
            this.lblDatabase.Margin = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.lblDatabase.Name = "lblDatabase";
            this.lblDatabase.Size = new System.Drawing.Size(99, 26);
            this.lblDatabase.TabIndex = 6;
            this.lblDatabase.Text = "Database";
            this.lblDatabase.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPort
            // 
            this.lblPort.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPort.AutoSize = true;
            this.lblPort.BackColor = System.Drawing.Color.Black;
            this.lblPort.Font = new System.Drawing.Font("Copperplate Gothic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPort.ForeColor = System.Drawing.Color.Gold;
            this.lblPort.Location = new System.Drawing.Point(5, 104);
            this.lblPort.Margin = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.lblPort.Name = "lblPort";
            this.lblPort.Size = new System.Drawing.Size(99, 26);
            this.lblPort.TabIndex = 4;
            this.lblPort.Text = "Port";
            this.lblPort.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblConnectionStatus
            // 
            this.lblConnectionStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblConnectionStatus.AutoSize = true;
            this.lblConnectionStatus.BackColor = System.Drawing.Color.Black;
            this.tlpMain.SetColumnSpan(this.lblConnectionStatus, 2);
            this.lblConnectionStatus.Font = new System.Drawing.Font("Copperplate Gothic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConnectionStatus.ForeColor = System.Drawing.Color.Gold;
            this.lblConnectionStatus.Location = new System.Drawing.Point(5, 5);
            this.lblConnectionStatus.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblConnectionStatus.Name = "lblConnectionStatus";
            this.lblConnectionStatus.Padding = new System.Windows.Forms.Padding(5);
            this.lblConnectionStatus.Size = new System.Drawing.Size(204, 28);
            this.lblConnectionStatus.TabIndex = 0;
            this.lblConnectionStatus.Text = "Connection Status";
            this.lblConnectionStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblServer
            // 
            this.lblServer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblServer.AutoSize = true;
            this.lblServer.BackColor = System.Drawing.Color.Black;
            this.lblServer.Font = new System.Drawing.Font("Copperplate Gothic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServer.ForeColor = System.Drawing.Color.Gold;
            this.lblServer.Location = new System.Drawing.Point(5, 78);
            this.lblServer.Margin = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.lblServer.Name = "lblServer";
            this.lblServer.Size = new System.Drawing.Size(99, 26);
            this.lblServer.TabIndex = 2;
            this.lblServer.Text = "Server";
            this.lblServer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblUser
            // 
            this.lblUser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUser.AutoSize = true;
            this.lblUser.BackColor = System.Drawing.Color.Black;
            this.lblUser.Font = new System.Drawing.Font("Copperplate Gothic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.ForeColor = System.Drawing.Color.Gold;
            this.lblUser.Location = new System.Drawing.Point(5, 156);
            this.lblUser.Margin = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(99, 26);
            this.lblUser.TabIndex = 7;
            this.lblUser.Text = "User";
            this.lblUser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnUpdateConfig
            // 
            this.btnUpdateConfig.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnUpdateConfig.AutoSize = true;
            this.btnUpdateConfig.BackColor = System.Drawing.Color.DarkGreen;
            this.btnUpdateConfig.FlatAppearance.BorderSize = 0;
            this.btnUpdateConfig.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateConfig.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateConfig.ForeColor = System.Drawing.Color.Gold;
            this.btnUpdateConfig.Location = new System.Drawing.Point(158, 213);
            this.btnUpdateConfig.Margin = new System.Windows.Forms.Padding(5);
            this.btnUpdateConfig.Name = "btnUpdateConfig";
            this.btnUpdateConfig.Size = new System.Drawing.Size(51, 33);
            this.btnUpdateConfig.TabIndex = 11;
            this.btnUpdateConfig.Text = "Save";
            this.btnUpdateConfig.UseVisualStyleBackColor = false;
            this.btnUpdateConfig.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblConnection
            // 
            this.lblConnection.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblConnection.AutoSize = true;
            this.lblConnection.BackColor = System.Drawing.Color.Transparent;
            this.tlpMain.SetColumnSpan(this.lblConnection, 2);
            this.lblConnection.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold);
            this.lblConnection.ForeColor = System.Drawing.Color.Black;
            this.lblConnection.Location = new System.Drawing.Point(5, 38);
            this.lblConnection.Margin = new System.Windows.Forms.Padding(5);
            this.lblConnection.Name = "lblConnection";
            this.lblConnection.Padding = new System.Windows.Forms.Padding(5);
            this.lblConnection.Size = new System.Drawing.Size(204, 35);
            this.lblConnection.TabIndex = 1;
            this.lblConnection.Text = "Status";
            this.lblConnection.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Config
            // 
            this.AcceptButton = this.btnUpdateConfig;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(224, 261);
            this.ControlBox = false;
            this.Controls.Add(this.tlpMain);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = global::BibleQuiz.Properties.Resources.logo;
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Config";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Connection";
            this.TopMost = true;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmConfig_FormClosed);
            this.Load += new System.EventHandler(this.frmConfig_Load);
            this.tlpMain.ResumeLayout(false);
            this.tlpMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpMain;
        private System.Windows.Forms.Label lblDatabase;
        private System.Windows.Forms.Label lblPort;
        private System.Windows.Forms.Label lblConnection;
        private System.Windows.Forms.Label lblConnectionStatus;
        private System.Windows.Forms.Label lblServer;
        private System.Windows.Forms.Button btnUpdateConfig;
        private System.Windows.Forms.TextBox txtServer;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.TextBox txtDatabase;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Button btnClose;
    }
}
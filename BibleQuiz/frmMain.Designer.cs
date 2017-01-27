namespace BibleQuiz
{
    partial class frmMain
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
            this.lblManagement = new System.Windows.Forms.Label();
            this.lblGame = new System.Windows.Forms.Label();
            this.pbxLogo = new System.Windows.Forms.PictureBox();
            this.tlpGeneral = new System.Windows.Forms.TableLayoutPanel();
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnRecords = new System.Windows.Forms.Button();
            this.lblLogo = new System.Windows.Forms.Label();
            this.tlpMaintenance = new System.Windows.Forms.TableLayoutPanel();
            this.btnManageDifficulties = new System.Windows.Forms.Button();
            this.btnManageGames = new System.Windows.Forms.Button();
            this.btnManageGroups = new System.Windows.Forms.Button();
            this.btnManageQuestions = new System.Windows.Forms.Button();
            this.btnConnection = new System.Windows.Forms.Button();
            this.tlpMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).BeginInit();
            this.tlpGeneral.SuspendLayout();
            this.tlpMaintenance.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpMain
            // 
            this.tlpMain.AutoSize = true;
            this.tlpMain.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tlpMain.BackColor = System.Drawing.Color.Gold;
            this.tlpMain.ColumnCount = 1;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpMain.Controls.Add(this.lblManagement, 0, 4);
            this.tlpMain.Controls.Add(this.lblGame, 0, 2);
            this.tlpMain.Controls.Add(this.pbxLogo, 0, 0);
            this.tlpMain.Controls.Add(this.tlpGeneral, 0, 3);
            this.tlpMain.Controls.Add(this.lblLogo, 0, 1);
            this.tlpMain.Controls.Add(this.tlpMaintenance, 0, 5);
            this.tlpMain.Controls.Add(this.btnConnection, 0, 6);
            this.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMain.ForeColor = System.Drawing.Color.Black;
            this.tlpMain.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.tlpMain.Location = new System.Drawing.Point(5, 5);
            this.tlpMain.Margin = new System.Windows.Forms.Padding(0);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.RowCount = 7;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpMain.Size = new System.Drawing.Size(274, 404);
            this.tlpMain.TabIndex = 7;
            // 
            // lblManagement
            // 
            this.lblManagement.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblManagement.AutoSize = true;
            this.lblManagement.BackColor = System.Drawing.Color.Black;
            this.lblManagement.Font = new System.Drawing.Font("Copperplate Gothic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblManagement.ForeColor = System.Drawing.Color.Gold;
            this.lblManagement.Location = new System.Drawing.Point(0, 197);
            this.lblManagement.Margin = new System.Windows.Forms.Padding(0);
            this.lblManagement.Name = "lblManagement";
            this.lblManagement.Padding = new System.Windows.Forms.Padding(10);
            this.lblManagement.Size = new System.Drawing.Size(274, 38);
            this.lblManagement.TabIndex = 7;
            this.lblManagement.Text = "Management";
            this.lblManagement.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblGame
            // 
            this.lblGame.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblGame.AutoSize = true;
            this.lblGame.BackColor = System.Drawing.Color.Black;
            this.lblGame.Font = new System.Drawing.Font("Copperplate Gothic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGame.ForeColor = System.Drawing.Color.Gold;
            this.lblGame.Location = new System.Drawing.Point(0, 85);
            this.lblGame.Margin = new System.Windows.Forms.Padding(0);
            this.lblGame.Name = "lblGame";
            this.lblGame.Padding = new System.Windows.Forms.Padding(10);
            this.lblGame.Size = new System.Drawing.Size(274, 38);
            this.lblGame.TabIndex = 6;
            this.lblGame.Text = "Game";
            this.lblGame.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbxLogo
            // 
            this.pbxLogo.BackColor = System.Drawing.Color.Transparent;
            this.pbxLogo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbxLogo.Image = global::BibleQuiz.Properties.Resources.sda;
            this.pbxLogo.Location = new System.Drawing.Point(0, 5);
            this.pbxLogo.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.pbxLogo.Name = "pbxLogo";
            this.pbxLogo.Size = new System.Drawing.Size(274, 55);
            this.pbxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxLogo.TabIndex = 3;
            this.pbxLogo.TabStop = false;
            // 
            // tlpGeneral
            // 
            this.tlpGeneral.BackColor = System.Drawing.Color.Gold;
            this.tlpGeneral.ColumnCount = 2;
            this.tlpGeneral.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpGeneral.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpGeneral.Controls.Add(this.btnPlay, 0, 0);
            this.tlpGeneral.Controls.Add(this.btnRecords, 1, 0);
            this.tlpGeneral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpGeneral.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.tlpGeneral.Location = new System.Drawing.Point(0, 123);
            this.tlpGeneral.Margin = new System.Windows.Forms.Padding(0);
            this.tlpGeneral.Name = "tlpGeneral";
            this.tlpGeneral.RowCount = 1;
            this.tlpGeneral.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpGeneral.Size = new System.Drawing.Size(274, 74);
            this.tlpGeneral.TabIndex = 1;
            // 
            // btnPlay
            // 
            this.btnPlay.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPlay.AutoSize = true;
            this.btnPlay.BackColor = System.Drawing.Color.DarkGreen;
            this.btnPlay.FlatAppearance.BorderSize = 0;
            this.btnPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlay.Font = new System.Drawing.Font("Copperplate Gothic Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlay.ForeColor = System.Drawing.Color.Gold;
            this.btnPlay.Image = global::BibleQuiz.Properties.Resources.play;
            this.btnPlay.Location = new System.Drawing.Point(10, 10);
            this.btnPlay.Margin = new System.Windows.Forms.Padding(10, 10, 5, 10);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Padding = new System.Windows.Forms.Padding(5);
            this.btnPlay.Size = new System.Drawing.Size(122, 54);
            this.btnPlay.TabIndex = 1;
            this.btnPlay.Text = "Play";
            this.btnPlay.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPlay.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPlay.UseVisualStyleBackColor = false;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnRecords
            // 
            this.btnRecords.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRecords.AutoSize = true;
            this.btnRecords.BackColor = System.Drawing.Color.DarkGreen;
            this.btnRecords.Enabled = false;
            this.btnRecords.FlatAppearance.BorderSize = 0;
            this.btnRecords.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRecords.Font = new System.Drawing.Font("Copperplate Gothic Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecords.ForeColor = System.Drawing.Color.Gold;
            this.btnRecords.Image = global::BibleQuiz.Properties.Resources.rank;
            this.btnRecords.Location = new System.Drawing.Point(142, 10);
            this.btnRecords.Margin = new System.Windows.Forms.Padding(5, 10, 10, 10);
            this.btnRecords.Name = "btnRecords";
            this.btnRecords.Padding = new System.Windows.Forms.Padding(5);
            this.btnRecords.Size = new System.Drawing.Size(122, 54);
            this.btnRecords.TabIndex = 2;
            this.btnRecords.Text = "Records";
            this.btnRecords.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRecords.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRecords.UseVisualStyleBackColor = false;
            // 
            // lblLogo
            // 
            this.lblLogo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLogo.AutoSize = true;
            this.lblLogo.Font = new System.Drawing.Font("Copperplate Gothic Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogo.ForeColor = System.Drawing.Color.Black;
            this.lblLogo.Location = new System.Drawing.Point(0, 60);
            this.lblLogo.Margin = new System.Windows.Forms.Padding(0);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Padding = new System.Windows.Forms.Padding(5);
            this.lblLogo.Size = new System.Drawing.Size(274, 25);
            this.lblLogo.TabIndex = 4;
            this.lblLogo.Text = "San Juan de Valdez Bible Quiz";
            this.lblLogo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tlpMaintenance
            // 
            this.tlpMaintenance.BackColor = System.Drawing.Color.Gold;
            this.tlpMaintenance.ColumnCount = 2;
            this.tlpMaintenance.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpMaintenance.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpMaintenance.Controls.Add(this.btnManageDifficulties, 1, 0);
            this.tlpMaintenance.Controls.Add(this.btnManageGames, 0, 0);
            this.tlpMaintenance.Controls.Add(this.btnManageGroups, 1, 1);
            this.tlpMaintenance.Controls.Add(this.btnManageQuestions, 0, 1);
            this.tlpMaintenance.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMaintenance.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.tlpMaintenance.Location = new System.Drawing.Point(0, 235);
            this.tlpMaintenance.Margin = new System.Windows.Forms.Padding(0);
            this.tlpMaintenance.Name = "tlpMaintenance";
            this.tlpMaintenance.RowCount = 2;
            this.tlpMaintenance.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpMaintenance.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpMaintenance.Size = new System.Drawing.Size(274, 138);
            this.tlpMaintenance.TabIndex = 0;
            // 
            // btnManageDifficulties
            // 
            this.btnManageDifficulties.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnManageDifficulties.AutoSize = true;
            this.btnManageDifficulties.BackColor = System.Drawing.Color.DarkGreen;
            this.btnManageDifficulties.FlatAppearance.BorderSize = 0;
            this.btnManageDifficulties.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManageDifficulties.Font = new System.Drawing.Font("Copperplate Gothic Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageDifficulties.ForeColor = System.Drawing.Color.Gold;
            this.btnManageDifficulties.Image = global::BibleQuiz.Properties.Resources.rank;
            this.btnManageDifficulties.Location = new System.Drawing.Point(142, 10);
            this.btnManageDifficulties.Margin = new System.Windows.Forms.Padding(5, 10, 10, 5);
            this.btnManageDifficulties.Name = "btnManageDifficulties";
            this.btnManageDifficulties.Padding = new System.Windows.Forms.Padding(5);
            this.btnManageDifficulties.Size = new System.Drawing.Size(122, 54);
            this.btnManageDifficulties.TabIndex = 1;
            this.btnManageDifficulties.Text = "Levels";
            this.btnManageDifficulties.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnManageDifficulties.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnManageDifficulties.UseVisualStyleBackColor = false;
            this.btnManageDifficulties.Click += new System.EventHandler(this.btnManageDifficulties_Click);
            // 
            // btnManageGames
            // 
            this.btnManageGames.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnManageGames.AutoSize = true;
            this.btnManageGames.BackColor = System.Drawing.Color.DarkGreen;
            this.btnManageGames.FlatAppearance.BorderSize = 0;
            this.btnManageGames.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManageGames.Font = new System.Drawing.Font("Copperplate Gothic Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageGames.ForeColor = System.Drawing.Color.Gold;
            this.btnManageGames.Image = global::BibleQuiz.Properties.Resources.play;
            this.btnManageGames.Location = new System.Drawing.Point(10, 10);
            this.btnManageGames.Margin = new System.Windows.Forms.Padding(10, 10, 5, 5);
            this.btnManageGames.Name = "btnManageGames";
            this.btnManageGames.Padding = new System.Windows.Forms.Padding(5);
            this.btnManageGames.Size = new System.Drawing.Size(122, 54);
            this.btnManageGames.TabIndex = 0;
            this.btnManageGames.Text = "Games";
            this.btnManageGames.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnManageGames.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnManageGames.UseVisualStyleBackColor = false;
            this.btnManageGames.Click += new System.EventHandler(this.btnManageGames_Click);
            // 
            // btnManageGroups
            // 
            this.btnManageGroups.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnManageGroups.AutoSize = true;
            this.btnManageGroups.BackColor = System.Drawing.Color.DarkGreen;
            this.btnManageGroups.FlatAppearance.BorderSize = 0;
            this.btnManageGroups.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManageGroups.Font = new System.Drawing.Font("Copperplate Gothic Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageGroups.ForeColor = System.Drawing.Color.Gold;
            this.btnManageGroups.Image = global::BibleQuiz.Properties.Resources.group;
            this.btnManageGroups.Location = new System.Drawing.Point(142, 74);
            this.btnManageGroups.Margin = new System.Windows.Forms.Padding(5, 5, 10, 10);
            this.btnManageGroups.Name = "btnManageGroups";
            this.btnManageGroups.Padding = new System.Windows.Forms.Padding(5);
            this.btnManageGroups.Size = new System.Drawing.Size(122, 54);
            this.btnManageGroups.TabIndex = 3;
            this.btnManageGroups.Text = "Groups";
            this.btnManageGroups.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnManageGroups.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnManageGroups.UseVisualStyleBackColor = false;
            this.btnManageGroups.Click += new System.EventHandler(this.btnManageGroups_Click);
            // 
            // btnManageQuestions
            // 
            this.btnManageQuestions.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnManageQuestions.AutoSize = true;
            this.btnManageQuestions.BackColor = System.Drawing.Color.DarkGreen;
            this.btnManageQuestions.FlatAppearance.BorderSize = 0;
            this.btnManageQuestions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManageQuestions.Font = new System.Drawing.Font("Copperplate Gothic Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageQuestions.ForeColor = System.Drawing.Color.Gold;
            this.btnManageQuestions.Image = global::BibleQuiz.Properties.Resources.question;
            this.btnManageQuestions.Location = new System.Drawing.Point(10, 74);
            this.btnManageQuestions.Margin = new System.Windows.Forms.Padding(10, 5, 5, 10);
            this.btnManageQuestions.Name = "btnManageQuestions";
            this.btnManageQuestions.Padding = new System.Windows.Forms.Padding(5);
            this.btnManageQuestions.Size = new System.Drawing.Size(122, 54);
            this.btnManageQuestions.TabIndex = 2;
            this.btnManageQuestions.Text = "Questions";
            this.btnManageQuestions.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnManageQuestions.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnManageQuestions.UseVisualStyleBackColor = false;
            this.btnManageQuestions.Click += new System.EventHandler(this.btnManageQuestions_Click);
            // 
            // btnConnection
            // 
            this.btnConnection.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConnection.BackColor = System.Drawing.Color.Black;
            this.btnConnection.FlatAppearance.BorderSize = 0;
            this.btnConnection.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConnection.Font = new System.Drawing.Font("Copperplate Gothic Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConnection.ForeColor = System.Drawing.Color.Gold;
            this.btnConnection.Location = new System.Drawing.Point(0, 373);
            this.btnConnection.Margin = new System.Windows.Forms.Padding(0);
            this.btnConnection.Name = "btnConnection";
            this.btnConnection.Size = new System.Drawing.Size(274, 31);
            this.btnConnection.TabIndex = 10;
            this.btnConnection.Text = "Server Status";
            this.btnConnection.UseVisualStyleBackColor = false;
            this.btnConnection.Click += new System.EventHandler(this.btnConnection_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(284, 414);
            this.Controls.Add(this.tlpMain);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(88)))), ((int)(((byte)(81)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = global::BibleQuiz.Properties.Resources.logo;
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(300, 256);
            this.Name = "frmMain";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bible Quiz";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMain_FormClosed);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.tlpMain.ResumeLayout(false);
            this.tlpMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).EndInit();
            this.tlpGeneral.ResumeLayout(false);
            this.tlpGeneral.PerformLayout();
            this.tlpMaintenance.ResumeLayout(false);
            this.tlpMaintenance.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpMain;
        private System.Windows.Forms.PictureBox pbxLogo;
        private System.Windows.Forms.TableLayoutPanel tlpMaintenance;
        private System.Windows.Forms.Button btnManageGames;
        private System.Windows.Forms.Button btnManageGroups;
        private System.Windows.Forms.Button btnManageQuestions;
        private System.Windows.Forms.Button btnManageDifficulties;
        private System.Windows.Forms.TableLayoutPanel tlpGeneral;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnRecords;
        private System.Windows.Forms.Label lblLogo;
        private System.Windows.Forms.Label lblManagement;
        private System.Windows.Forms.Label lblGame;
        private System.Windows.Forms.Button btnConnection;

    }
}
namespace BibleQuiz.Play
{
    partial class frmScoreBoard
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
            this.tlpLogoAndScores = new System.Windows.Forms.TableLayoutPanel();
            this.tlpLogo = new System.Windows.Forms.TableLayoutPanel();
            this.lblGame = new System.Windows.Forms.Label();
            this.lblScores = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.pbxLogo = new System.Windows.Forms.PictureBox();
            this.lblLogo = new System.Windows.Forms.Label();
            this.tlpScores = new System.Windows.Forms.TableLayoutPanel();
            this.tlpMain.SuspendLayout();
            this.tlpLogoAndScores.SuspendLayout();
            this.tlpLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // tlpMain
            // 
            this.tlpMain.AutoSize = true;
            this.tlpMain.BackColor = System.Drawing.Color.Transparent;
            this.tlpMain.ColumnCount = 3;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.99999F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.00001F));
            this.tlpMain.Controls.Add(this.tlpLogoAndScores, 1, 0);
            this.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMain.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.tlpMain.Location = new System.Drawing.Point(10, 10);
            this.tlpMain.Margin = new System.Windows.Forms.Padding(12, 17, 12, 17);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.RowCount = 1;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.Size = new System.Drawing.Size(992, 568);
            this.tlpMain.TabIndex = 0;
            // 
            // tlpLogoAndScores
            // 
            this.tlpLogoAndScores.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.tlpLogoAndScores.BackColor = System.Drawing.Color.White;
            this.tlpLogoAndScores.ColumnCount = 2;
            this.tlpLogoAndScores.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpLogoAndScores.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpLogoAndScores.Controls.Add(this.tlpLogo, 0, 0);
            this.tlpLogoAndScores.Controls.Add(this.tlpScores, 1, 0);
            this.tlpLogoAndScores.ForeColor = System.Drawing.Color.Black;
            this.tlpLogoAndScores.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.tlpLogoAndScores.Location = new System.Drawing.Point(-15, 0);
            this.tlpLogoAndScores.Margin = new System.Windows.Forms.Padding(0);
            this.tlpLogoAndScores.MinimumSize = new System.Drawing.Size(1024, 0);
            this.tlpLogoAndScores.Name = "tlpLogoAndScores";
            this.tlpLogoAndScores.RowCount = 1;
            this.tlpLogoAndScores.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpLogoAndScores.Size = new System.Drawing.Size(1024, 568);
            this.tlpLogoAndScores.TabIndex = 0;
            // 
            // tlpLogo
            // 
            this.tlpLogo.BackColor = System.Drawing.Color.Gold;
            this.tlpLogo.ColumnCount = 1;
            this.tlpLogo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpLogo.Controls.Add(this.lblGame, 0, 3);
            this.tlpLogo.Controls.Add(this.lblScores, 0, 4);
            this.tlpLogo.Controls.Add(this.lblName, 0, 2);
            this.tlpLogo.Controls.Add(this.pbxLogo, 0, 0);
            this.tlpLogo.Controls.Add(this.lblLogo, 0, 1);
            this.tlpLogo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpLogo.Location = new System.Drawing.Point(15, 15);
            this.tlpLogo.Margin = new System.Windows.Forms.Padding(15);
            this.tlpLogo.Name = "tlpLogo";
            this.tlpLogo.RowCount = 5;
            this.tlpLogo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpLogo.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpLogo.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpLogo.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpLogo.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpLogo.Size = new System.Drawing.Size(679, 538);
            this.tlpLogo.TabIndex = 1;
            // 
            // lblGame
            // 
            this.lblGame.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblGame.AutoSize = true;
            this.lblGame.BackColor = System.Drawing.Color.Transparent;
            this.lblGame.Font = new System.Drawing.Font("Impact", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGame.ForeColor = System.Drawing.Color.Black;
            this.lblGame.Location = new System.Drawing.Point(0, 393);
            this.lblGame.Margin = new System.Windows.Forms.Padding(0);
            this.lblGame.Name = "lblGame";
            this.lblGame.Padding = new System.Windows.Forms.Padding(10, 5, 10, 0);
            this.lblGame.Size = new System.Drawing.Size(679, 65);
            this.lblGame.TabIndex = 3;
            this.lblGame.Text = "GAME";
            this.lblGame.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblScores
            // 
            this.lblScores.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblScores.AutoSize = true;
            this.lblScores.BackColor = System.Drawing.Color.Transparent;
            this.lblScores.Font = new System.Drawing.Font("OCR A Extended", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScores.ForeColor = System.Drawing.Color.Black;
            this.lblScores.Location = new System.Drawing.Point(0, 458);
            this.lblScores.Margin = new System.Windows.Forms.Padding(0, 0, 0, 25);
            this.lblScores.Name = "lblScores";
            this.lblScores.Padding = new System.Windows.Forms.Padding(10, 5, 10, 0);
            this.lblScores.Size = new System.Drawing.Size(679, 55);
            this.lblScores.TabIndex = 0;
            this.lblScores.Text = "S C O R E S";
            this.lblScores.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblName
            // 
            this.lblName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.Black;
            this.lblName.Font = new System.Drawing.Font("Copperplate Gothic Bold", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.Gold;
            this.lblName.Location = new System.Drawing.Point(0, 269);
            this.lblName.Margin = new System.Windows.Forms.Padding(0, 0, 0, 25);
            this.lblName.Name = "lblName";
            this.lblName.Padding = new System.Windows.Forms.Padding(5);
            this.lblName.Size = new System.Drawing.Size(679, 99);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Bible Quiz";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pbxLogo
            // 
            this.pbxLogo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbxLogo.BackColor = System.Drawing.Color.Transparent;
            this.pbxLogo.Image = Properties.Resources.sda_big;
            this.pbxLogo.Location = new System.Drawing.Point(25, 25);
            this.pbxLogo.Margin = new System.Windows.Forms.Padding(25, 25, 25, 0);
            this.pbxLogo.Name = "pbxLogo";
            this.pbxLogo.Size = new System.Drawing.Size(629, 165);
            this.pbxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxLogo.TabIndex = 0;
            this.pbxLogo.TabStop = false;
            // 
            // lblLogo
            // 
            this.lblLogo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLogo.AutoSize = true;
            this.lblLogo.BackColor = System.Drawing.Color.Black;
            this.lblLogo.Font = new System.Drawing.Font("Copperplate Gothic Bold", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogo.ForeColor = System.Drawing.Color.Gold;
            this.lblLogo.Location = new System.Drawing.Point(0, 215);
            this.lblLogo.Margin = new System.Windows.Forms.Padding(0, 25, 0, 0);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Padding = new System.Windows.Forms.Padding(5);
            this.lblLogo.Size = new System.Drawing.Size(679, 54);
            this.lblLogo.TabIndex = 1;
            this.lblLogo.Text = "San Juan de Valdez";
            this.lblLogo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tlpScores
            // 
            this.tlpScores.AutoSize = true;
            this.tlpScores.BackColor = System.Drawing.Color.Black;
            this.tlpScores.ColumnCount = 1;
            this.tlpScores.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpScores.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpScores.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.tlpScores.Location = new System.Drawing.Point(709, 15);
            this.tlpScores.Margin = new System.Windows.Forms.Padding(0, 15, 15, 15);
            this.tlpScores.MinimumSize = new System.Drawing.Size(300, 0);
            this.tlpScores.Name = "tlpScores";
            this.tlpScores.RowCount = 1;
            this.tlpScores.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpScores.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 538F));
            this.tlpScores.Size = new System.Drawing.Size(300, 538);
            this.tlpScores.TabIndex = 2;
            // 
            // frmScoreBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(29F, 77F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1012, 588);
            this.ControlBox = false;
            this.Controls.Add(this.tlpMain);
            this.Font = new System.Drawing.Font("Advent", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = Properties.Resources.logo;
            this.Margin = new System.Windows.Forms.Padding(12, 17, 12, 17);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmScoreBoard";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Score Board";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmScoreBoard_FormClosed);
            this.Load += new System.EventHandler(this.frmScoreBoard_Load);
            this.tlpMain.ResumeLayout(false);
            this.tlpLogoAndScores.ResumeLayout(false);
            this.tlpLogoAndScores.PerformLayout();
            this.tlpLogo.ResumeLayout(false);
            this.tlpLogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpMain;
        private System.Windows.Forms.TableLayoutPanel tlpLogoAndScores;
        private System.Windows.Forms.TableLayoutPanel tlpLogo;
        private System.Windows.Forms.PictureBox pbxLogo;
        private System.Windows.Forms.Label lblLogo;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TableLayoutPanel tlpScores;
        private System.Windows.Forms.Label lblScores;
        private System.Windows.Forms.Label lblGame;
    }
}
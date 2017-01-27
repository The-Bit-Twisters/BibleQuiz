namespace BibleQuiz
{
    partial class frmSplashScreen
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
            this.tlpMain = new System.Windows.Forms.TableLayoutPanel();
            this.pbxLogo = new System.Windows.Forms.PictureBox();
            this.lblLogo = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.tlpMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // tlpMain
            // 
            this.tlpMain.BackColor = System.Drawing.Color.Gold;
            this.tlpMain.ColumnCount = 1;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpMain.Controls.Add(this.pbxLogo, 0, 0);
            this.tlpMain.Controls.Add(this.lblLogo, 0, 1);
            this.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMain.Location = new System.Drawing.Point(5, 5);
            this.tlpMain.Margin = new System.Windows.Forms.Padding(0);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.RowCount = 2;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70.58823F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 29.41176F));
            this.tlpMain.Size = new System.Drawing.Size(630, 230);
            this.tlpMain.TabIndex = 0;
            // 
            // pbxLogo
            // 
            this.pbxLogo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbxLogo.Image = global::BibleQuiz.Properties.Resources.sda;
            this.pbxLogo.Location = new System.Drawing.Point(15, 15);
            this.pbxLogo.Margin = new System.Windows.Forms.Padding(15, 15, 15, 0);
            this.pbxLogo.Name = "pbxLogo";
            this.pbxLogo.Size = new System.Drawing.Size(600, 147);
            this.pbxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxLogo.TabIndex = 3;
            this.pbxLogo.TabStop = false;
            // 
            // lblLogo
            // 
            this.lblLogo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLogo.AutoSize = true;
            this.lblLogo.BackColor = System.Drawing.Color.Black;
            this.lblLogo.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.lblLogo.Font = new System.Drawing.Font("Copperplate Gothic Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogo.ForeColor = System.Drawing.Color.Gold;
            this.lblLogo.Location = new System.Drawing.Point(0, 178);
            this.lblLogo.Margin = new System.Windows.Forms.Padding(0);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Padding = new System.Windows.Forms.Padding(5);
            this.lblLogo.Size = new System.Drawing.Size(630, 36);
            this.lblLogo.TabIndex = 1;
            this.lblLogo.Text = "San Juan de Valdez Bible Quiz";
            this.lblLogo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 3000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // frmSplashScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(640, 240);
            this.ControlBox = false;
            this.Controls.Add(this.tlpMain);
            this.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = Properties.Resources.logo;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSplashScreen";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SplashScreen";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frmSplashScreen_Load);
            this.tlpMain.ResumeLayout(false);
            this.tlpMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpMain;
        private System.Windows.Forms.Label lblLogo;
        private System.Windows.Forms.PictureBox pbxLogo;
        private System.Windows.Forms.Timer timer;
    }
}
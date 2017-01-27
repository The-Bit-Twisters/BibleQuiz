namespace BibleQuiz.Play
{
    partial class frmPassOrPlay
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
            this.tlpLogoAndGroups = new System.Windows.Forms.TableLayoutPanel();
            this.tlpLogo = new System.Windows.Forms.TableLayoutPanel();
            this.lblWrong = new System.Windows.Forms.Label();
            this.lblQuestion = new System.Windows.Forms.Label();
            this.lblCorrectScore = new System.Windows.Forms.Label();
            this.lblWrongScore = new System.Windows.Forms.Label();
            this.lblCorrect = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.tlpGroups = new System.Windows.Forms.TableLayoutPanel();
            this.tlpMain.SuspendLayout();
            this.tlpLogoAndGroups.SuspendLayout();
            this.tlpLogo.SuspendLayout();
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
            this.tlpMain.Controls.Add(this.tlpLogoAndGroups, 1, 0);
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
            // tlpLogoAndGroups
            // 
            this.tlpLogoAndGroups.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.tlpLogoAndGroups.BackColor = System.Drawing.Color.White;
            this.tlpLogoAndGroups.ColumnCount = 2;
            this.tlpLogoAndGroups.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpLogoAndGroups.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpLogoAndGroups.Controls.Add(this.tlpLogo, 0, 0);
            this.tlpLogoAndGroups.Controls.Add(this.tlpGroups, 1, 0);
            this.tlpLogoAndGroups.ForeColor = System.Drawing.Color.Black;
            this.tlpLogoAndGroups.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.tlpLogoAndGroups.Location = new System.Drawing.Point(-15, 0);
            this.tlpLogoAndGroups.Margin = new System.Windows.Forms.Padding(0);
            this.tlpLogoAndGroups.MinimumSize = new System.Drawing.Size(1024, 0);
            this.tlpLogoAndGroups.Name = "tlpLogoAndGroups";
            this.tlpLogoAndGroups.RowCount = 1;
            this.tlpLogoAndGroups.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpLogoAndGroups.Size = new System.Drawing.Size(1024, 568);
            this.tlpLogoAndGroups.TabIndex = 0;
            // 
            // tlpLogo
            // 
            this.tlpLogo.BackColor = System.Drawing.Color.Gold;
            this.tlpLogo.ColumnCount = 2;
            this.tlpLogo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpLogo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpLogo.Controls.Add(this.lblWrong, 0, 3);
            this.tlpLogo.Controls.Add(this.lblQuestion, 0, 1);
            this.tlpLogo.Controls.Add(this.lblCorrectScore, 1, 2);
            this.tlpLogo.Controls.Add(this.lblWrongScore, 1, 3);
            this.tlpLogo.Controls.Add(this.lblCorrect, 0, 2);
            this.tlpLogo.Controls.Add(this.lblTitle, 0, 0);
            this.tlpLogo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpLogo.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.tlpLogo.Location = new System.Drawing.Point(15, 15);
            this.tlpLogo.Margin = new System.Windows.Forms.Padding(15);
            this.tlpLogo.Name = "tlpLogo";
            this.tlpLogo.RowCount = 4;
            this.tlpLogo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpLogo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpLogo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpLogo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpLogo.Size = new System.Drawing.Size(679, 538);
            this.tlpLogo.TabIndex = 1;
            // 
            // lblWrong
            // 
            this.lblWrong.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblWrong.AutoSize = true;
            this.lblWrong.BackColor = System.Drawing.Color.Transparent;
            this.lblWrong.Font = new System.Drawing.Font("Impact", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWrong.ForeColor = System.Drawing.Color.Black;
            this.lblWrong.Image = global::BibleQuiz.Properties.Resources.wrong;
            this.lblWrong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblWrong.Location = new System.Drawing.Point(226, 440);
            this.lblWrong.Margin = new System.Windows.Forms.Padding(0);
            this.lblWrong.MinimumSize = new System.Drawing.Size(250, 0);
            this.lblWrong.Name = "lblWrong";
            this.lblWrong.Size = new System.Drawing.Size(250, 60);
            this.lblWrong.TabIndex = 5;
            this.lblWrong.Text = "WRONG";
            this.lblWrong.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblQuestion
            // 
            this.lblQuestion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblQuestion.AutoSize = true;
            this.lblQuestion.BackColor = System.Drawing.Color.Black;
            this.tlpLogo.SetColumnSpan(this.lblQuestion, 2);
            this.lblQuestion.Font = new System.Drawing.Font("Copperplate Gothic Bold", 39.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestion.ForeColor = System.Drawing.Color.Gold;
            this.lblQuestion.Location = new System.Drawing.Point(0, 134);
            this.lblQuestion.Margin = new System.Windows.Forms.Padding(0);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Padding = new System.Windows.Forms.Padding(5);
            this.lblQuestion.Size = new System.Drawing.Size(679, 128);
            this.lblQuestion.TabIndex = 2;
            this.lblQuestion.Text = "Question #0\r\nLEVEL";
            this.lblQuestion.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblCorrectScore
            // 
            this.lblCorrectScore.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCorrectScore.AutoSize = true;
            this.lblCorrectScore.BackColor = System.Drawing.Color.Transparent;
            this.lblCorrectScore.Font = new System.Drawing.Font("Impact", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorrectScore.ForeColor = System.Drawing.Color.Black;
            this.lblCorrectScore.Location = new System.Drawing.Point(476, 276);
            this.lblCorrectScore.Margin = new System.Windows.Forms.Padding(0);
            this.lblCorrectScore.Name = "lblCorrectScore";
            this.lblCorrectScore.Size = new System.Drawing.Size(203, 117);
            this.lblCorrectScore.TabIndex = 3;
            this.lblCorrectScore.Text = "+30";
            this.lblCorrectScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblWrongScore
            // 
            this.lblWrongScore.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblWrongScore.AutoSize = true;
            this.lblWrongScore.BackColor = System.Drawing.Color.Transparent;
            this.lblWrongScore.Font = new System.Drawing.Font("Impact", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWrongScore.ForeColor = System.Drawing.Color.Black;
            this.lblWrongScore.Location = new System.Drawing.Point(476, 409);
            this.lblWrongScore.Margin = new System.Windows.Forms.Padding(0);
            this.lblWrongScore.Name = "lblWrongScore";
            this.lblWrongScore.Padding = new System.Windows.Forms.Padding(10, 5, 10, 0);
            this.lblWrongScore.Size = new System.Drawing.Size(203, 122);
            this.lblWrongScore.TabIndex = 4;
            this.lblWrongScore.Text = "-20";
            this.lblWrongScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCorrect
            // 
            this.lblCorrect.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblCorrect.AutoSize = true;
            this.lblCorrect.BackColor = System.Drawing.Color.Transparent;
            this.lblCorrect.Font = new System.Drawing.Font("Impact", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorrect.ForeColor = System.Drawing.Color.Black;
            this.lblCorrect.Image = global::BibleQuiz.Properties.Resources.correct;
            this.lblCorrect.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblCorrect.Location = new System.Drawing.Point(186, 305);
            this.lblCorrect.Margin = new System.Windows.Forms.Padding(0);
            this.lblCorrect.MinimumSize = new System.Drawing.Size(290, 0);
            this.lblCorrect.Name = "lblCorrect";
            this.lblCorrect.Size = new System.Drawing.Size(290, 60);
            this.lblCorrect.TabIndex = 0;
            this.lblCorrect.Text = "CORRECT";
            this.lblCorrect.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.tlpLogo.SetColumnSpan(this.lblTitle, 2);
            this.lblTitle.Font = new System.Drawing.Font("Arial Black", 39.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Black;
            this.lblTitle.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblTitle.Location = new System.Drawing.Point(112, 37);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(0, 25, 0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Padding = new System.Windows.Forms.Padding(5);
            this.lblTitle.Size = new System.Drawing.Size(455, 84);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Pass Or Play ?";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tlpGroups
            // 
            this.tlpGroups.AutoSize = true;
            this.tlpGroups.BackColor = System.Drawing.Color.Black;
            this.tlpGroups.ColumnCount = 1;
            this.tlpGroups.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpGroups.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpGroups.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.tlpGroups.Location = new System.Drawing.Point(709, 15);
            this.tlpGroups.Margin = new System.Windows.Forms.Padding(0, 15, 15, 15);
            this.tlpGroups.MinimumSize = new System.Drawing.Size(300, 0);
            this.tlpGroups.Name = "tlpGroups";
            this.tlpGroups.RowCount = 1;
            this.tlpGroups.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpGroups.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 538F));
            this.tlpGroups.Size = new System.Drawing.Size(300, 538);
            this.tlpGroups.TabIndex = 2;
            // 
            // frmPassOrPlay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(37F, 73F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1012, 588);
            this.ControlBox = false;
            this.Controls.Add(this.tlpMain);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = Properties.Resources.logo;
            this.Margin = new System.Windows.Forms.Padding(12, 17, 12, 17);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPassOrPlay";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Score Board";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmScoreBoard_Load);
            this.tlpMain.ResumeLayout(false);
            this.tlpLogoAndGroups.ResumeLayout(false);
            this.tlpLogoAndGroups.PerformLayout();
            this.tlpLogo.ResumeLayout(false);
            this.tlpLogo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpMain;
        private System.Windows.Forms.TableLayoutPanel tlpLogoAndGroups;
        private System.Windows.Forms.TableLayoutPanel tlpLogo;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.TableLayoutPanel tlpGroups;
        private System.Windows.Forms.Label lblCorrect;
        private System.Windows.Forms.Label lblCorrectScore;
        private System.Windows.Forms.Label lblWrongScore;
        private System.Windows.Forms.Label lblWrong;
    }
}
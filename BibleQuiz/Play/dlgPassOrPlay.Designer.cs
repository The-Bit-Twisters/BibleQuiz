namespace BibleQuiz.Play
{
    partial class dlgPassOrPlay
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
            this.lblCorrectPoints = new System.Windows.Forms.Label();
            this.lblIncorrectPoints = new System.Windows.Forms.Label();
            this.lblPassPlay = new System.Windows.Forms.Label();
            this.lblQuestion = new System.Windows.Forms.Label();
            this.btnContinue = new System.Windows.Forms.Button();
            this.pnlContainer = new System.Windows.Forms.TableLayoutPanel();
            this.tlpMain.SuspendLayout();
            this.pnlContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpMain
            // 
            this.tlpMain.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tlpMain.BackColor = System.Drawing.Color.Gold;
            this.tlpMain.ColumnCount = 3;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpMain.Controls.Add(this.lblCorrectPoints, 0, 2);
            this.tlpMain.Controls.Add(this.lblIncorrectPoints, 1, 2);
            this.tlpMain.Controls.Add(this.lblPassPlay, 0, 0);
            this.tlpMain.Controls.Add(this.lblQuestion, 1, 0);
            this.tlpMain.Controls.Add(this.btnContinue, 2, 2);
            this.tlpMain.Location = new System.Drawing.Point(227, 175);
            this.tlpMain.Margin = new System.Windows.Forms.Padding(0);
            this.tlpMain.MaximumSize = new System.Drawing.Size(560, 280);
            this.tlpMain.MinimumSize = new System.Drawing.Size(560, 280);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.RowCount = 3;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpMain.Size = new System.Drawing.Size(560, 280);
            this.tlpMain.TabIndex = 0;
            // 
            // lblCorrectPoints
            // 
            this.lblCorrectPoints.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCorrectPoints.AutoSize = true;
            this.lblCorrectPoints.BackColor = System.Drawing.Color.Black;
            this.lblCorrectPoints.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorrectPoints.ForeColor = System.Drawing.Color.White;
            this.lblCorrectPoints.Location = new System.Drawing.Point(5, 225);
            this.lblCorrectPoints.Margin = new System.Windows.Forms.Padding(5, 5, 0, 5);
            this.lblCorrectPoints.Name = "lblCorrectPoints";
            this.lblCorrectPoints.Padding = new System.Windows.Forms.Padding(5);
            this.lblCorrectPoints.Size = new System.Drawing.Size(224, 50);
            this.lblCorrectPoints.TabIndex = 4;
            this.lblCorrectPoints.Text = "Correct";
            this.lblCorrectPoints.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblIncorrectPoints
            // 
            this.lblIncorrectPoints.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblIncorrectPoints.AutoSize = true;
            this.lblIncorrectPoints.BackColor = System.Drawing.Color.Black;
            this.lblIncorrectPoints.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIncorrectPoints.ForeColor = System.Drawing.Color.White;
            this.lblIncorrectPoints.Location = new System.Drawing.Point(229, 225);
            this.lblIncorrectPoints.Margin = new System.Windows.Forms.Padding(0, 5, 5, 5);
            this.lblIncorrectPoints.Name = "lblIncorrectPoints";
            this.lblIncorrectPoints.Padding = new System.Windows.Forms.Padding(5);
            this.lblIncorrectPoints.Size = new System.Drawing.Size(224, 50);
            this.lblIncorrectPoints.TabIndex = 3;
            this.lblIncorrectPoints.Text = "Wrong";
            this.lblIncorrectPoints.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPassPlay
            // 
            this.lblPassPlay.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPassPlay.AutoSize = true;
            this.lblPassPlay.BackColor = System.Drawing.Color.Black;
            this.lblPassPlay.Font = new System.Drawing.Font("Copperplate Gothic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassPlay.ForeColor = System.Drawing.Color.Gold;
            this.lblPassPlay.Location = new System.Drawing.Point(5, 5);
            this.lblPassPlay.Margin = new System.Windows.Forms.Padding(5, 5, 0, 0);
            this.lblPassPlay.Name = "lblPassPlay";
            this.lblPassPlay.Padding = new System.Windows.Forms.Padding(5);
            this.lblPassPlay.Size = new System.Drawing.Size(224, 28);
            this.lblPassPlay.TabIndex = 2;
            this.lblPassPlay.Text = "Pass or Play ?";
            this.lblPassPlay.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblQuestion
            // 
            this.lblQuestion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblQuestion.AutoSize = true;
            this.lblQuestion.BackColor = System.Drawing.Color.Black;
            this.tlpMain.SetColumnSpan(this.lblQuestion, 2);
            this.lblQuestion.Font = new System.Drawing.Font("Copperplate Gothic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestion.ForeColor = System.Drawing.Color.Gold;
            this.lblQuestion.Location = new System.Drawing.Point(229, 5);
            this.lblQuestion.Margin = new System.Windows.Forms.Padding(0, 5, 5, 0);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Padding = new System.Windows.Forms.Padding(5);
            this.lblQuestion.Size = new System.Drawing.Size(326, 28);
            this.lblQuestion.TabIndex = 0;
            this.lblQuestion.Text = "Question";
            this.lblQuestion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnContinue
            // 
            this.btnContinue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnContinue.AutoSize = true;
            this.btnContinue.BackColor = System.Drawing.Color.DarkGreen;
            this.btnContinue.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnContinue.FlatAppearance.BorderSize = 0;
            this.btnContinue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnContinue.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContinue.ForeColor = System.Drawing.Color.Gold;
            this.btnContinue.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnContinue.Location = new System.Drawing.Point(458, 225);
            this.btnContinue.Margin = new System.Windows.Forms.Padding(0, 5, 5, 5);
            this.btnContinue.Name = "btnContinue";
            this.btnContinue.Padding = new System.Windows.Forms.Padding(10);
            this.btnContinue.Size = new System.Drawing.Size(97, 50);
            this.btnContinue.TabIndex = 1;
            this.btnContinue.Text = "Continue";
            this.btnContinue.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnContinue.UseVisualStyleBackColor = false;
            this.btnContinue.Click += new System.EventHandler(this.btnContinue_Click);
            // 
            // pnlContainer
            // 
            this.pnlContainer.ColumnCount = 1;
            this.pnlContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pnlContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            this.pnlContainer.Controls.Add(this.tlpMain, 0, 0);
            this.pnlContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContainer.Location = new System.Drawing.Point(5, 5);
            this.pnlContainer.Margin = new System.Windows.Forms.Padding(0);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.RowCount = 1;
            this.pnlContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pnlContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 413F));
            this.pnlContainer.Size = new System.Drawing.Size(1014, 630);
            this.pnlContainer.TabIndex = 1;
            // 
            // dlgPassOrPlay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1024, 640);
            this.ControlBox = false;
            this.Controls.Add(this.pnlContainer);
            this.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = Properties.Resources.logo;
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "dlgPassOrPlay";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Attendance";
            this.Load += new System.EventHandler(this.frmPassOrPlay_Load);
            this.tlpMain.ResumeLayout(false);
            this.tlpMain.PerformLayout();
            this.pnlContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpMain;
        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.Button btnContinue;
        private System.Windows.Forms.Label lblPassPlay;
        private System.Windows.Forms.TableLayoutPanel pnlContainer;
        private System.Windows.Forms.Label lblIncorrectPoints;
        private System.Windows.Forms.Label lblCorrectPoints;
    }
}
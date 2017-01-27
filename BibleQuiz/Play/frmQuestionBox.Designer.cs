namespace BibleQuiz.Play
{
    partial class frmQuestionBox
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
            this.tlpQuestion = new System.Windows.Forms.TableLayoutPanel();
            this.lblDifficulty = new System.Windows.Forms.Label();
            this.lblSequence = new System.Windows.Forms.Label();
            this.lblPoints = new System.Windows.Forms.Label();
            this.lblQuestionStatement = new System.Windows.Forms.Label();
            this.tlpMain = new System.Windows.Forms.TableLayoutPanel();
            this.tlpQuestion.SuspendLayout();
            this.tlpMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpQuestion
            // 
            this.tlpQuestion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpQuestion.AutoSize = true;
            this.tlpQuestion.BackColor = System.Drawing.Color.Gold;
            this.tlpQuestion.ColumnCount = 3;
            this.tlpQuestion.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpQuestion.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpQuestion.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpQuestion.Controls.Add(this.lblDifficulty, 1, 0);
            this.tlpQuestion.Controls.Add(this.lblSequence, 0, 0);
            this.tlpQuestion.Controls.Add(this.lblPoints, 2, 0);
            this.tlpQuestion.Controls.Add(this.lblQuestionStatement, 0, 1);
            this.tlpQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tlpQuestion.Location = new System.Drawing.Point(-14, 0);
            this.tlpQuestion.Margin = new System.Windows.Forms.Padding(0);
            this.tlpQuestion.MaximumSize = new System.Drawing.Size(1024, 0);
            this.tlpQuestion.MinimumSize = new System.Drawing.Size(1024, 0);
            this.tlpQuestion.Name = "tlpQuestion";
            this.tlpQuestion.RowCount = 3;
            this.tlpQuestion.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpQuestion.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpQuestion.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpQuestion.Size = new System.Drawing.Size(1024, 570);
            this.tlpQuestion.TabIndex = 0;
            // 
            // lblDifficulty
            // 
            this.lblDifficulty.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDifficulty.AutoSize = true;
            this.lblDifficulty.BackColor = System.Drawing.Color.Black;
            this.lblDifficulty.Font = new System.Drawing.Font("Copperplate Gothic Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDifficulty.ForeColor = System.Drawing.Color.Gold;
            this.lblDifficulty.Location = new System.Drawing.Point(627, 15);
            this.lblDifficulty.Margin = new System.Windows.Forms.Padding(0, 15, 0, 15);
            this.lblDifficulty.Name = "lblDifficulty";
            this.lblDifficulty.Padding = new System.Windows.Forms.Padding(25, 10, 25, 10);
            this.lblDifficulty.Size = new System.Drawing.Size(219, 50);
            this.lblDifficulty.TabIndex = 3;
            this.lblDifficulty.Text = "Difficulty";
            this.lblDifficulty.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSequence
            // 
            this.lblSequence.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSequence.AutoSize = true;
            this.lblSequence.BackColor = System.Drawing.Color.Black;
            this.lblSequence.Font = new System.Drawing.Font("Copperplate Gothic Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSequence.ForeColor = System.Drawing.Color.Gold;
            this.lblSequence.Location = new System.Drawing.Point(15, 15);
            this.lblSequence.Margin = new System.Windows.Forms.Padding(15, 15, 0, 15);
            this.lblSequence.Name = "lblSequence";
            this.lblSequence.Padding = new System.Windows.Forms.Padding(25, 10, 25, 10);
            this.lblSequence.Size = new System.Drawing.Size(612, 50);
            this.lblSequence.TabIndex = 2;
            this.lblSequence.Text = "Sequence";
            this.lblSequence.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblPoints
            // 
            this.lblPoints.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPoints.AutoSize = true;
            this.lblPoints.BackColor = System.Drawing.Color.Black;
            this.lblPoints.Font = new System.Drawing.Font("Copperplate Gothic Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPoints.ForeColor = System.Drawing.Color.Gold;
            this.lblPoints.Location = new System.Drawing.Point(846, 15);
            this.lblPoints.Margin = new System.Windows.Forms.Padding(0, 15, 15, 15);
            this.lblPoints.Name = "lblPoints";
            this.lblPoints.Padding = new System.Windows.Forms.Padding(25, 10, 25, 10);
            this.lblPoints.Size = new System.Drawing.Size(163, 50);
            this.lblPoints.TabIndex = 4;
            this.lblPoints.Text = "Points";
            this.lblPoints.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblQuestionStatement
            // 
            this.lblQuestionStatement.AutoSize = true;
            this.lblQuestionStatement.BackColor = System.Drawing.Color.White;
            this.lblQuestionStatement.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tlpQuestion.SetColumnSpan(this.lblQuestionStatement, 3);
            this.lblQuestionStatement.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblQuestionStatement.Font = new System.Drawing.Font("Arial", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestionStatement.ForeColor = System.Drawing.Color.Black;
            this.lblQuestionStatement.Location = new System.Drawing.Point(15, 80);
            this.lblQuestionStatement.Margin = new System.Windows.Forms.Padding(15, 0, 15, 15);
            this.lblQuestionStatement.Name = "lblQuestionStatement";
            this.lblQuestionStatement.Padding = new System.Windows.Forms.Padding(5);
            this.lblQuestionStatement.Size = new System.Drawing.Size(994, 475);
            this.lblQuestionStatement.TabIndex = 1;
            this.lblQuestionStatement.Text = "Question Statement";
            this.lblQuestionStatement.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tlpMain
            // 
            this.tlpMain.ColumnCount = 3;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.99999F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpMain.Controls.Add(this.tlpQuestion, 1, 0);
            this.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMain.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.tlpMain.Location = new System.Drawing.Point(15, 15);
            this.tlpMain.Margin = new System.Windows.Forms.Padding(0);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.RowCount = 1;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.Size = new System.Drawing.Size(994, 570);
            this.tlpMain.TabIndex = 1;
            // 
            // frmQuestionBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1024, 600);
            this.ControlBox = false;
            this.Controls.Add(this.tlpMain);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = global::BibleQuiz.Properties.Resources.logo;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmQuestionBox";
            this.Padding = new System.Windows.Forms.Padding(15);
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Question Box";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmQuestionBox_FormClosed);
            this.Load += new System.EventHandler(this.frmQuestionBox_Load);
            this.tlpQuestion.ResumeLayout(false);
            this.tlpQuestion.PerformLayout();
            this.tlpMain.ResumeLayout(false);
            this.tlpMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpQuestion;
        private System.Windows.Forms.Label lblDifficulty;
        private System.Windows.Forms.Label lblQuestionStatement;
        private System.Windows.Forms.Label lblSequence;
        private System.Windows.Forms.Label lblPoints;
        private System.Windows.Forms.TableLayoutPanel tlpMain;
    }
}
namespace BibleQuiz.Play
{
    partial class frmGroupAnswersBoard
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
            this.tlpGroupAnswers = new System.Windows.Forms.TableLayoutPanel();
            this.tlpMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpMain
            // 
            this.tlpMain.ColumnCount = 1;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpMain.Controls.Add(this.tlpGroupAnswers, 0, 0);
            this.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMain.Location = new System.Drawing.Point(15, 15);
            this.tlpMain.Margin = new System.Windows.Forms.Padding(15);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.RowCount = 1;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 480F));
            this.tlpMain.Size = new System.Drawing.Size(690, 450);
            this.tlpMain.TabIndex = 0;
            // 
            // tlpGroupAnswers
            // 
            this.tlpGroupAnswers.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tlpGroupAnswers.AutoSize = true;
            this.tlpGroupAnswers.BackColor = System.Drawing.Color.White;
            this.tlpGroupAnswers.ColumnCount = 1;
            this.tlpGroupAnswers.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpGroupAnswers.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpGroupAnswers.Location = new System.Drawing.Point(225, 105);
            this.tlpGroupAnswers.Margin = new System.Windows.Forms.Padding(0);
            this.tlpGroupAnswers.MinimumSize = new System.Drawing.Size(240, 240);
            this.tlpGroupAnswers.Name = "tlpGroupAnswers";
            this.tlpGroupAnswers.RowCount = 1;
            this.tlpGroupAnswers.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpGroupAnswers.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tlpGroupAnswers.Size = new System.Drawing.Size(240, 240);
            this.tlpGroupAnswers.TabIndex = 0;
            // 
            // frmGroupAnswersBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(720, 480);
            this.ControlBox = false;
            this.Controls.Add(this.tlpMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmGroupAnswersBoard";
            this.Padding = new System.Windows.Forms.Padding(15);
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmShowAnswers";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmGroupAnswersBoard_FormClosed);
            this.Load += new System.EventHandler(this.frmShowAnswers_Load);
            this.tlpMain.ResumeLayout(false);
            this.tlpMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpMain;
        private System.Windows.Forms.TableLayoutPanel tlpGroupAnswers;

    }
}
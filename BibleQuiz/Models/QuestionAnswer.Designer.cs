using System;
using System.Windows.Forms;
using System.Drawing;

namespace BibleQuiz.Models
{
    partial class QuestionAnswer
    {

        private void InitializeComponent()
        {
            SuspendLayout();
            // 
            // GroupScore
            // 
            AutoSize = true;
            BackColor = Color.Black;
            ColumnCount = 1;
            ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            Dock = DockStyle.Fill;
            RowCount = 2;
            RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            RowStyles.Add(new RowStyle());
            Margin = new Padding(15, 0, 15, 15);
            ResumeLayout(false);
            PerformLayout();
        }
        
        /**************************************************
         ********** LABEL ANSWER **************************
         **************************************************/

        private class LabelAnswer : Label
        {
            internal LabelAnswer(string answer)
            {
                this.answer = answer;
                InitializeComponent();
            }

            //components
            private string answer;

            private void InitializeComponent()
            {
                AutoSize = true;
                BackColor = Color.Lime;
                Dock = DockStyle.Fill;
                Font = new Font("Impact", 40F, FontStyle.Regular, GraphicsUnit.Point);
                ForeColor = Color.Black;
                Margin = new Padding(10);
                Text = answer;
                TextAlign = ContentAlignment.MiddleCenter;
            }
        }

        /**************************************************
         ********** LABEL BIBLE REFERENCE *****************
         **************************************************/

        private class LabelBibleReference : Label
        {
            internal LabelBibleReference(string bible_reference)
            {
                this.bible_reference = bible_reference;
                InitializeComponent();
            }

            //components
            private string bible_reference;

            private void InitializeComponent()
            {
                AutoSize = true;
                BackColor = Color.White;
                Dock = DockStyle.Fill;
                Font = new Font("Arial Narrow", 25F, FontStyle.Bold, GraphicsUnit.Point);
                ForeColor = Color.Black;
                Margin = new Padding(0);
                Text = bible_reference;
                TextAlign = ContentAlignment.MiddleRight;
            }
        }

    }
}

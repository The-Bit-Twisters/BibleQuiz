using System;
using System.Windows.Forms;
using System.Drawing;

namespace BibleQuiz.Models
{
    partial class GroupAnswer
    {

        private void InitializeComponent()
        {
            SuspendLayout();
            // 
            // GroupScore
            // 
            Anchor = AnchorStyles.None;
            AutoSize = true;
            BackColor = Color.Black;
            ColumnCount = 2;
            ColumnStyles.Add(new ColumnStyle());
            ColumnStyles.Add(new ColumnStyle());
            GrowStyle = TableLayoutPanelGrowStyle.FixedSize;
            Margin = new Padding(25);
            ResumeLayout(false);
            PerformLayout();
        }
        
        /**************************************************
         ********** LABEL GROUP NAME **********************
         **************************************************/

        private class LabelGroup : Label
        {
            internal LabelGroup(string groupName)
            {
                this.groupName = groupName;
                InitializeComponent();
            }

            //components
            private string groupName;
            //layouts
            private float fontsize = 30F;
            private int margin = 8;
            private int padding = 5;

            private void InitializeComponent()
            {
                AutoSize = true;
                BackColor = Color.Lime;
                Dock = DockStyle.Fill;
                Font = new Font("Copperplate Gothic Bold", fontsize, FontStyle.Bold, GraphicsUnit.Point);
                ForeColor = Color.Black;
                Margin = new Padding(margin, margin, 0, margin);
                Padding = new Padding(padding, 0, padding, 0);
                Text = groupName;
                TextAlign = ContentAlignment.MiddleCenter;
            }
        }

        /**************************************************
         ********** LABEL GROUP SCORE *********************
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
            //layouts
            private float fontsize = 30F;
            private int margin = 8;

            private void InitializeComponent()
            {
                AutoSize = true;
                BackColor = Color.Gold;
                Dock = DockStyle.Fill;
                Font = new Font("Impact", fontsize, FontStyle.Regular, GraphicsUnit.Point);
                ForeColor = Color.Black;
                Margin = new Padding(margin / 2, margin, margin, margin);
                Padding = new Padding(10);
                Text = answer;
                TextAlign = ContentAlignment.MiddleCenter;
            }

        }

    }
}

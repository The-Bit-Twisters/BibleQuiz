using System;
using System.Windows.Forms;
using System.Drawing;

namespace BibleQuiz.Models
{
    partial class GroupScore
    {

        private void InitializeComponent()
        {
            SuspendLayout();
            // 
            // GroupScore
            // 
            AutoSize = true;
            BackColor = Color.Black;
            ColumnCount = 2;
            ColumnStyles.Add(new ColumnStyle());
            ColumnStyles.Add(new ColumnStyle());
            Dock = DockStyle.Fill;
            GrowStyle = TableLayoutPanelGrowStyle.FixedSize;
            Margin = new Padding(0);
            ResumeLayout(false);
            PerformLayout();
        }
        
        /**************************************************
         ********** LABEL GROUP NAME **********************
         **************************************************/

        private class LabelGroup : Label
        {
            internal LabelGroup(string groupName, Models.Layout.View layout)
            {
                this.groupName = groupName;
                this.layout = layout;
                InitializeLayout();
                InitializeComponent();
            }

            //components
            private Models.Layout.View layout;
            private string groupName;
            //layouts
            private float fontsize;
            private int margin;
            private int padding;

            private void InitializeLayout()
            {
                switch (layout)
                {
                    case Models.Layout.View.BigScreen:
                        fontsize = 40F;
                        margin = 8;
                        padding = 5;
                        break;
                    case Models.Layout.View.ControllerEmbed:
                        fontsize = 12F;
                        margin = 5;
                        padding = 5;
                        break;
                }
            }

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

        private class LabelScore : Label
        {
            internal LabelScore(short score, Models.Layout.View layout)
            {
                this.groupScore = score.ToString();
                this.layout = layout;
                InitializeLayout();
                InitializeComponent();
            }

            //components
            private Models.Layout.View layout;
            private string groupScore;
            //layouts
            private float fontsize;
            private int margin;

            private void InitializeLayout()
            {
                switch (layout)
                {
                    case Models.Layout.View.BigScreen:
                        fontsize = 40F;
                        margin = 8;
                        break;
                    case Models.Layout.View.ControllerEmbed:
                        fontsize = 16F;
                        margin = 5;
                        break;
                }
            }

            private void InitializeComponent()
            {
                AutoSize = true;
                BackColor = Color.Gold;
                Dock = DockStyle.Fill;
                Font = new Font("Impact", fontsize, FontStyle.Regular, GraphicsUnit.Point);
                ForeColor = Color.Black;
                Margin = new Padding(margin / 2, margin, margin, margin);
                Text = groupScore;
                TextAlign = ContentAlignment.MiddleCenter;
            }

        }

    }
}

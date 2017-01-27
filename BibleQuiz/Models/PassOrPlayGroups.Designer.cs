using System;
using System.Windows.Forms;
using System.Drawing;

namespace BibleQuiz.Models
{
    partial class PassOrPlayGroups
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
            ColumnCount = 1;
            ColumnStyles.Add(new ColumnStyle());
            Margin = new Padding(5);
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

            private void InitializeComponent()
            {
                Anchor = (AnchorStyles)(AnchorStyles.Left | AnchorStyles.Right);
                AutoSize = true;
                BackColor = Color.White;
                Font = new Font("Copperplate Gothic Bold", 40F, FontStyle.Bold, GraphicsUnit.Point);
                ForeColor = Color.Black;
                Margin = new Padding(5);
                Padding = new Padding(5, 0, 5, 0);
                Text = groupName;
                TextAlign = ContentAlignment.MiddleCenter;
            }
        }

    }
}

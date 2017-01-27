using System;
using System.Windows.Forms;
using System.Drawing;

namespace BibleQuiz.Models
{
    partial class GroupPoints
    {

        private void InitializeComponent()
        {
            SuspendLayout();
            // 
            // GroupPoint
            // 
            AutoSize = true;
            BackColor = Color.Black;
            Dock = DockStyle.Fill;
            GrowStyle = TableLayoutPanelGrowStyle.FixedSize;
            Margin = new Padding(0, 0, 5, 0);
            RowCount = 1;
            RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            ResumeLayout(false);
            PerformLayout();
        }
        
        /**************************************************
         ********** CHECKBOX GROUP ************************
         **************************************************/

        private class CheckBoxGroup : CheckBox
        {
            internal CheckBoxGroup(long groupID, string groupName)
            {
                this.groupID = groupID;
                this.groupName = groupName;
                InitializeComponent();
            }

            //components
            private long groupID;
            private string groupName;

            private void InitializeComponent()
            {
                Appearance = Appearance.Button;
                AutoSize = true;
                BackColor = Color.Silver;
                CheckState = CheckState.Unchecked;
                Dock = DockStyle.Fill;
                FlatStyle = FlatStyle.Flat;
                Font = new Font("Copperplate Gothic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
                ForeColor = Color.Black;
                Image = Properties.Resources.wrong;
                Margin = new Padding(5);
                Tag = groupID;
                Text = groupName;
                TextAlign = ContentAlignment.MiddleCenter;
                UseVisualStyleBackColor = false;
                CheckStateChanged += new System.EventHandler(this.checkbox_CheckStateChanged);
            }

            private void checkbox_CheckStateChanged(object sender, EventArgs e)
            {
                if (CheckState == CheckState.Checked)
                {
                    Enabled = true;
                    BackColor = Color.Silver;
                    ForeColor = Color.Black;
                    Image = Properties.Resources.correct;
                }
                if (CheckState == CheckState.Unchecked)
                {
                    Enabled = true;
                    BackColor = Color.Silver;
                    ForeColor = Color.Black;
                    Image = Properties.Resources.wrong;
                }
                if (CheckState == CheckState.Indeterminate)
                {
                    Enabled = false;
                    BackColor = Color.FromArgb(64, 64, 64);
                    ForeColor = Color.Black;
                    Image = null;
                }
            }
        }

    }
}

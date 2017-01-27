using BibleQuiz.Components;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BibleQuiz.Models
{
    internal partial class PresentGroups : TableLayoutPanel
    {
        internal PresentGroups(Question question)
        {
            InitializeComponent();
            this.question = question;
            Render();
        }

        private Question question;
        private List<CheckBoxGroup> checkboxGroups;

        internal static PassOrPlayGroups passorplayGroups
        {
            get;
            set;
        }

        internal List<long> GetChecked()
        {
            List<long> groups = new List<long>();
            foreach (CheckBoxGroup checkboxGroup in checkboxGroups)
            {
                if (checkboxGroup.Checked)
                {
                    groups.Add(Convert.ToInt64(checkboxGroup.Tag));
                }
            }
            return groups;
        }

        private void Render()
        {
            SuspendLayout();
            checkboxGroups = new List<CheckBoxGroup>();
            List<Group> presentGroups = Attendance.GetPresent(question.Game);
            RowCount = 2;
            RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            ColumnCount = 4;
            ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            int row = 0, col = 0;
            foreach (Group group in presentGroups)
            {
                if (col == 4)
                {
                    row = 1;
                    col = 0;
                }
                CheckBoxGroup checkboxGroup = new CheckBoxGroup(group.ID, group.Name);
                checkboxGroups.Add(checkboxGroup);
                Controls.Add(checkboxGroup, col, row);
                col++;
            }
            ResumeLayout(false);
            PerformLayout();
        }

    }
}

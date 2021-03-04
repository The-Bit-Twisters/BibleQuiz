using BibleQuiz.Components;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BibleQuiz.Models
{
    internal partial class GroupAttendance : TableLayoutPanel
    {
        internal GroupAttendance(long gameID)
        {
            InitializeComponent();
            this.gameID = gameID;
            Render();
        }

        private long gameID;
        private List<CheckBoxGroup> checkboxGroups;

        internal void Save()
        {
            List<long> presentGroups = new List<long>();
            List<long> absentGroups = new List<long>();
            foreach (CheckBoxGroup checkboxGroup in checkboxGroups)
            {
                if (checkboxGroup.Checked)
                {
                    presentGroups.Add(Convert.ToInt64(checkboxGroup.Tag));
                }
                else
                {
                    absentGroups.Add(Convert.ToInt64(checkboxGroup.Tag));
                }
            }
            Attendance.Save(gameID, presentGroups, absentGroups);
        }

        private void Render()
        {
            SuspendLayout();
            checkboxGroups = new List<CheckBoxGroup>();
            List<Group> groups = Group.GetAll();
            List<Group> presentGroups = Attendance.GetPresent(gameID);

            RowCount = groups.Count / 4; 
            if (groups.Count % 4 > 0)
            {
                RowCount++;
            }
            for (int ctr=0; ctr<RowCount; ctr++)
            {
                RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            }
            ColumnCount = 4;
            ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));

            int row = 0, col = 0;
            foreach (Group group in groups)
            {
                if (col == 4)
                {
                    row = 1;
                    col = 0;
                }
                CheckBoxGroup checkboxGroup = new CheckBoxGroup(group.ID, group.Name);
                if (presentGroups.Contains(group))
                {
                    checkboxGroup.Checked = true;
                }
                checkboxGroups.Add(checkboxGroup);
                Controls.Add(checkboxGroup, col, row);
                col++;
            }
            ResumeLayout(false);
            PerformLayout();
        }

    }
}

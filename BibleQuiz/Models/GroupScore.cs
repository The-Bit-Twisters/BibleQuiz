using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Drawing;
using BibleQuiz.Components;

namespace BibleQuiz.Models
{
    internal partial class GroupScore : TableLayoutPanel
    {

        internal GroupScore(long gameID, Models.Layout.View layout)
        {
            this.layout = layout;
            this.gameID = gameID;
            InitializeComponent();
            InitializeLayout();
            Render();
        }

        //components
        private Models.Layout.View layout;
        private long gameID;

        private void InitializeLayout()
        {
            switch (layout)
            {
                case Models.Layout.View.BigScreen:
                    Margin = new Padding(5);
                    break;
                case Models.Layout.View.ControllerEmbed:
                    Margin = new Padding(0);
                    break;
            }
        }

        private void Render()
        {
            SuspendLayout();
            List<Group> groups = new List<Group>();
            if (gameID > 0)
            {
                groups = Attendance.GetPresent(gameID);
                groups.Sort((x, y) => Score.GetGame(gameID, y.ID).CompareTo(Score.GetGame(gameID, x.ID)));
            }
            else
            {
                groups = Group.GetAll();
                groups.Sort((x, y) => Score.GetTotal(y.ID).CompareTo(Score.GetTotal(x.ID)));
            }
            foreach (Group group in groups)
            {
                RowCount += 1;
                RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
                LabelGroup lblGroup = new LabelGroup(group.Name, layout);
                short score = (gameID > 0) ? Score.GetGame(gameID, group.ID) : Score.GetTotal(group.ID);
                LabelScore lblScore = new LabelScore(score, layout);
                Controls.Add(lblGroup, 0, RowCount - 1);
                Controls.Add(lblScore, 1, RowCount - 1);
            }
            ResumeLayout(false);
            PerformLayout();
        }

    }
}

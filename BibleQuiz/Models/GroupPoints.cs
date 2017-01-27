using BibleQuiz.Components;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BibleQuiz.Models
{
    internal partial class GroupPoints : TableLayoutPanel
    {

        internal GroupPoints(Play.frmControls controls, long gameID)
        {
            this.gameID = gameID;
            this.controls = controls;
            InitializeComponent();
            Render();
        }

        private Play.frmControls controls;
        private List<CheckBoxGroup> checkboxGroups;
        private long gameID;

        internal void SetPlay(List<long> groups)
        {
            foreach (CheckBoxGroup checkboxGroup in checkboxGroups)
            {
                if (groups.Contains(Convert.ToInt64(checkboxGroup.Tag)))
                {
                    checkboxGroup.CheckState = CheckState.Unchecked;
                }
                else
                {
                    checkboxGroup.CheckState = CheckState.Indeterminate;
                }
            }
        }

        internal void UpdateCheckBoxes(Question question)
        {
            SuspendLayout();
            foreach (CheckBoxGroup checkboxGroup in checkboxGroups)
            {
                Group group = Group.GetByID(Convert.ToInt64(checkboxGroup.Tag));
                if (Score.CheckScore(group.ID, question.ID) > 0)
                {
                    checkboxGroup.CheckState = CheckState.Checked;
                }
                else if (Score.CheckScore(group.ID, question.ID) < 0)
                {
                    checkboxGroup.CheckState = CheckState.Unchecked;
                }
                else
                {
                    if (question.PassPlay)
                    {
                        checkboxGroup.CheckState = CheckState.Indeterminate;
                    }
                    else
                    {
                        checkboxGroup.CheckState = CheckState.Unchecked;
                    }
                }
                if (Game.GetByID(gameID).Finished || question.ID < Settings.Current.Question.ID)
                {
                    checkboxGroup.AutoCheck = false;
                    controls.btnPointsSave.Enabled = false;
                }
                else
                {
                    checkboxGroup.AutoCheck = true;
                    controls.btnPointsSave.Enabled = true;
                }
            }
            ResumeLayout(false);
            PerformLayout();
        }

        internal void SaveGroupPoints(Question question)
        {
            List<long> correctGroups = new List<long>();
            List<long> incorrectGroups = new List<long>();
            foreach (CheckBoxGroup checkboxGroup in checkboxGroups)
            {
                switch (checkboxGroup.CheckState) 
                {
                    case CheckState.Checked:
                        correctGroups.Add(Convert.ToInt64(checkboxGroup.Tag));
                        break;
                    case CheckState.Unchecked:
                        incorrectGroups.Add(Convert.ToInt64(checkboxGroup.Tag));
                        break;
                }
            }
            Score.QuestionSave(question, correctGroups, incorrectGroups);
        }

        private void Render()
        {
            SuspendLayout();
            checkboxGroups = new List<CheckBoxGroup>();
            List<Group> groups = Attendance.GetPresent(gameID);
            foreach(Group group in groups) 
            {
                ColumnCount += 1;
                ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
                CheckBoxGroup checkboxGroup = new CheckBoxGroup(group.ID, group.Name);
                checkboxGroups.Add(checkboxGroup);
                Controls.Add(checkboxGroup, ColumnCount - 1, 0);
            }
            ResumeLayout(false);
            PerformLayout();
        }

    }
}

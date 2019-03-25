using System.Windows.Forms;
using System.Collections.Generic;
using BibleQuiz.Components;
using System.Globalization;

namespace BibleQuiz.Models
{
    internal partial class GroupAnswer : TableLayoutPanel
    {

        internal GroupAnswer(long questionID, Models.Layout.View layout)
        {
            this.layout = layout;
            this.questionID = questionID;
            InitializeComponent();
            InitializeLayout();
            Render();
        }

        //components
        private Models.Layout.View layout;
        private long questionID;

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
            groups = Attendance.GetPresent(Question.GetByID(questionID).Game);
            foreach (Group group in groups)
            {
                RowCount += 1;
                RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
                LabelGroup lblGroup = new LabelGroup(group.Name);
                LabelAnswer lblAnswer = new LabelAnswer(group.GetQuestionAnswer(questionID).ToUpper(CultureInfo.CurrentCulture));
                Controls.Add(lblGroup, 0, RowCount - 1);
                Controls.Add(lblAnswer, 1, RowCount - 1);
            }
            ResumeLayout(false);
            PerformLayout();
        }

    }
}

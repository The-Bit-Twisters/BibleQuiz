using System;
using System.Windows.Forms;

namespace BibleQuiz.Play
{
    internal partial class frmGroupAnswersBoard : Form
    {
        internal frmGroupAnswersBoard(frmControls controls, long questionID)
        {
            InitializeComponent();
            this.controls = controls;
            this.questionID = questionID;
            Settings.Display.Project(this);
        }

        private long questionID;
        private frmControls controls;
        private Models.GroupAnswer answers;

        private void frmShowAnswers_Load(object sender, EventArgs e)
        {
            SuspendLayout();
            if (answers != null)
            {
                tlpGroupAnswers.Controls.Remove(answers);
                answers.Dispose();
            }
            answers = new Models.GroupAnswer(questionID, Models.Layout.View.BigScreen);
            tlpGroupAnswers.Controls.Add(answers, 0, 0);
            ResumeLayout(false);
            PerformLayout();
        }

        private void frmGroupAnswersBoard_FormClosed(object sender, FormClosedEventArgs e)
        {
            controls.chkGroupAnswers.Checked = false;
        }
    }
}

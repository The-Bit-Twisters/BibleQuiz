using BibleQuiz.Components;
using System;
using System.Windows.Forms;

namespace BibleQuiz.Play
{
    internal partial class frmQuestionBox : Form
    {
        internal frmQuestionBox(frmControls controls, Question question)
        {
            InitializeComponent();
            this.controls = controls;
            this.question = question;
            Settings.Display.Project(this);
        }

        private frmControls controls;
        private Question question;
        private Models.QuestionChoices choices;
        private Models.QuestionAnswer answer;

        internal void RevealAnswer()
        {
            SuspendLayout();
            string answervalue = "";
            int index = 0;
            for (int i=0; i<question.Choices.Count; i++)
            {
                if (question.Choices[i].Answer)
                {
                    answervalue = question.Choices[i].Value;
                    index = i;
                    break;
                }
            }
            if (question.Choices.Count == 4)
            {
                if (index == 0)
                {
                    answervalue = "A. " + answervalue;
                }
                else if (index == 1)
                {
                    answervalue = "B. " + answervalue;
                }
                else if (index == 2)
                {
                    answervalue = "C. " + answervalue;
                }
                else if (index == 3)
                {
                    answervalue = "D. " + answervalue;
                }
            }
            answer = new Models.QuestionAnswer(answervalue, question.BibleReference);
            tlpQuestion.Controls.Remove(choices);
            tlpQuestion.Controls.Add(answer, 0, 2);
            tlpQuestion.SetColumnSpan(answer, 3);
            ResumeLayout(false);
            PerformLayout();
        }

        internal void ShowChoices()
        {
            SuspendLayout();
            choices = new Models.QuestionChoices(question, Models.Layout.View.BigScreen);
            tlpQuestion.Controls.Add(choices, 0, 2);
            tlpQuestion.SetColumnSpan(choices, 3);
            ResumeLayout(false);
            PerformLayout();
        }

        private void Render()
        {
            SuspendLayout();
            Level level = Level.GetByID(question.Level);
            lblSequence.Text = "Question No. " + question.Sequence;
            lblDifficulty.Text = level.Name.ToUpper();
            lblPoints.Text = level.Score + " Points";
            lblQuestionStatement.Text = question.QuestionStatement;
            ResumeLayout(false);
            PerformLayout();
        }

        private void frmQuestionBox_Load(object sender, EventArgs e)
        {
            Render();
        }

        private void frmQuestionBox_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (controls != null)
            {
                controls.chkQuestionBox.Checked = false;
                controls.chkShowChoices.Checked = false;
                controls.chkRevealAnswer.Checked = false;
            }
        }
    }
}

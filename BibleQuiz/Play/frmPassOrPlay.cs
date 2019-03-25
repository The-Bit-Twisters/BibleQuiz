using BibleQuiz.Components;
using System;
using System.Windows.Forms;

namespace BibleQuiz.Play
{
    internal partial class frmPassOrPlay : Form
    {
        internal frmPassOrPlay(Question question)
        {
            InitializeComponent();
            this.question = question;
            passorplayGroups = new Models.PassOrPlayGroups();
            Settings.Display.Project(this);
        }

        private Question question;

        internal Models.PassOrPlayGroups passorplayGroups;

        private void Render()
        {
            SuspendLayout();
            tlpGroups.Controls.Add(passorplayGroups, 0, 0);
            ResumeLayout(false);
            PerformLayout();
        }

        private void frmScoreBoard_Load(object sender, EventArgs e)
        {
            Level level = Level.GetByID(question.Level);
            lblQuestion.Text = "Question #" + question.Sequence + "\n" + level.Name;
            lblCorrectScore.Text = "+ " + (level.Special * 3);
            lblWrongScore.Text = "- " + (level.Special * 2);
            Render();
        }

    }
}

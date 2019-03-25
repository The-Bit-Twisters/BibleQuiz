using BibleQuiz.Components;
using System;
using System.Windows.Forms;

namespace BibleQuiz.Play
{
    internal partial class frmScoreBoard : Form
    {
        internal frmScoreBoard(frmControls controls, long gameID)
        {
            InitializeComponent();
            this.gameID = gameID;
            this.controls = controls;
            Settings.Display.Project(this);
        }

        private frmControls controls;
        private long gameID;
        private Models.GroupScore groupscore;

        internal void UpdateScores()
        {
            SuspendLayout();
            if (groupscore != null)
            {
                tlpScores.Controls.Remove(groupscore);
                groupscore.Dispose();
            }
            groupscore = new Models.GroupScore(gameID, Models.Layout.View.BigScreen);
            tlpScores.Controls.Add(groupscore, 0, 0);
            ResumeLayout(false);
            PerformLayout();
        }

        private void Render()
        {
            if (gameID > 0)
            {
                Game game = Game.GetByID(gameID);
                lblGame.Text = game.Date.ToString("MMMM dd, yyyy");
            }
            else
            {
                lblGame.Text = "T O T A L";
            }
        }

        private void frmScoreBoard_Load(object sender, EventArgs e)
        {
            Render();
            UpdateScores();
        }

        private void frmScoreBoard_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (gameID > 0)
            {
                controls.chkCurrentGameScoreBoard.Checked = false;
            }
            else
            {
                controls.chkTotalScoreBoard.Checked = false;
            }
        }
    }
}

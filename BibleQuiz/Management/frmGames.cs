using BibleQuiz.Components;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BibleQuiz.Management
{
    internal partial class frmGames : Form
    {
        internal frmGames(frmMain main)
        {
            InitializeComponent();
            game = new Game();
            mainform = main;
        }

        private Game game;
        private frmMain mainform;

        private void Render()
        {
            List<Game> games = Game.GetAll(Game.Filter.All);
            dgvGames.Rows.Clear();
            foreach (Game game in games)
            {
                string fin = (game.Finished) ? "Yes" : "No";
                dgvGames.Rows.Add(game.ID, game.Sequence, game.Date.ToString("MMMM dd, yyyy"), fin);
            }
            dgvGames.ClearSelection();
        }

        private void LoadData(Game game)
        {
            txtSequence.Text = game.Sequence.ToString();
            txtSequence.Enabled = true;
            dtpDate.Value = game.Date;
            dtpDate.Enabled = true;
            txtFinished.Text = (game.Finished) ? "Yes" : "No";
            txtFinished.Enabled = true;
        }

        private void ClearData()
        {
            game = new Game();
            txtSequence.Text = "";
            txtSequence.Enabled = false;
            dtpDate.Value = DateTime.Today;
            dtpDate.Enabled = false;
            txtFinished.Text = "";
            txtFinished.Enabled = false;
        }

        private void frmGames_Load(object sender, EventArgs e)
        {
            Render();
        }


        private void dgvGames_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvGames.SelectedRows.Count > 0)
            {
                game = Game.GetByID(Convert.ToInt64(dgvGames.SelectedRows[0].Cells["colGameID"].Value));
                LoadData(game);
            }
            else
            {
                ClearData();
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            game = new Game();
            game.Sequence = (short)(Game.GetLastSequence() + 1);
            game.Finished = false;
            LoadData(game);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            game.Date = dtpDate.Value;
            if (game.Save())
            {
                MessageBox.Show("Data has been saved successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Render();
            }
        }

        private void frmGames_FormClosed(object sender, FormClosedEventArgs e)
        {
            mainform.Focus();
        }

    }
}

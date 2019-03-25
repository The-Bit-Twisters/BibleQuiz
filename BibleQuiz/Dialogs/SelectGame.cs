using BibleQuiz.Components;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BibleQuiz.Dialogs
{
    internal partial class SelectGame : Form
    {
        internal SelectGame(Game.Filter filter)
        {
            InitializeComponent();
            this.filter = filter;
        }

        private Game.Filter filter;

        internal Game SelectedGame { get; set; }

        private void Render()
        {
            List<Game> games = Game.GetAll(filter);
            dgvGames.Rows.Clear();
            foreach (Game game in games)
            {
                dgvGames.Rows.Add(game.ID, game.Sequence, game.Date.ToString("MMMM dd, yyyy"));
            }
            dgvGames.ClearSelection();
        }

        private void SelectGame_Load(object sender, EventArgs e)
        {
            switch (filter)
            {
                case Game.Filter.All:
                    cbxFilter.SelectedIndex = 0;
                    break;
                case Game.Filter.Finished:
                    cbxFilter.SelectedIndex = 1;
                    break;
                case Game.Filter.Unfinished:
                    cbxFilter.SelectedIndex = 2;
                    break;
            }
        }

        private void cbxFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbxFilter.SelectedIndex)
            {
                case 0:
                    filter = Game.Filter.All;
                    break;
                case 1:
                    filter = Game.Filter.Finished;
                    break;
                case 2:
                    filter = Game.Filter.Unfinished;
                    break;
            }
            Render();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            SelectedGame = Game.GetByID(Convert.ToInt64(dgvGames.SelectedRows[0].Cells["colGameID"].Value));
        }

        private void dgvGames_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvGames.SelectedRows.Count > 0)
            {
                btnSelect.Enabled = true;
            }
            else
            {
                btnSelect.Enabled = false;
            }
        }

    }
}

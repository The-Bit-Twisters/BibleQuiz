using System;
using System.Drawing;
using System.Windows.Forms;
using MySql.Connection;
using System.Data;
using BibleQuiz.Components;

namespace BibleQuiz
{
    internal partial class frmMain : Form
    {
        internal frmMain()
        {
            InitializeComponent();
        }

        //play
        private Play.frmControls playgame;

        //management
        private Management.frmGames manageGames;
        private Management.frmLevels manageDifficulties;
        private Management.frmQuestions manageQuestions;
        private Management.frmGroups manageGroups;

        internal void ConnectionTest()
        {
            if (Builder.ConnectionState == ConnectionState.Open)
            {
                btnConnection.Text = "Server Online";
            }
            else
            {
                btnConnection.Text = "Server Offline";
            }
        }

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnManageGames_Click(object sender, EventArgs e)
        {
            if (!Builder.Connected)
            {
                return;
            }
            if (manageGames == null || manageGames.IsDisposed)
            {
                manageGames = new Management.frmGames(this);
            }
            manageGames.Show();
            manageGames.Focus();
        }

        private void btnManageDifficulties_Click(object sender, EventArgs e)
        {
            if (!Builder.Connected)
            {
                return;
            }
            if (manageDifficulties == null || manageDifficulties.IsDisposed)
            {
                manageDifficulties = new Management.frmLevels(this);
            }
            manageDifficulties.Show();
            manageDifficulties.Focus();
        }

        private void btnManageQuestions_Click(object sender, EventArgs e)
        {
            if (!Builder.Connected)
            {
                return;
            }
            if (manageQuestions != null)
            {
                manageQuestions.Dispose();
            }
            Dialogs.SelectGame selectgame = new Dialogs.SelectGame(Game.Filter.Unfinished);
            if (selectgame.ShowDialog() == DialogResult.OK)
            {
                manageQuestions = new Management.frmQuestions(this, selectgame.SelectedGame);
                manageQuestions.Show();
                manageQuestions.Focus();
            }
        }

        private void btnManageGroups_Click(object sender, EventArgs e)
        {
            if (!Builder.Connected)
            {
                return;
            }
            if (manageGroups == null || manageGroups.IsDisposed)
            {
                manageGroups = new Management.frmGroups(this);
            }
            manageGroups.Show();
            manageGroups.Focus();
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            if (!Builder.Connected)
            {
                return;
            }
            Dialogs.SelectGame selectgame = new Dialogs.SelectGame(Game.Filter.Unfinished);
            if (selectgame.ShowDialog() == DialogResult.OK)
            {
                playgame = new Play.frmControls(selectgame.SelectedGame, this);
                playgame.Show();
                this.Hide();
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            ConnectionTest();
        }

        private void btnConnection_Click(object sender, EventArgs e)
        {
            Dialogs.Config config = new Dialogs.Config(this);
            config.ShowDialog();
            config.Dispose();
        }

    }
}

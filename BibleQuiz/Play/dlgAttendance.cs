using BibleQuiz.Components;
using System;
using System.Windows.Forms;

namespace BibleQuiz.Play
{
    internal partial class dlgAttendance : Form
    {
        internal dlgAttendance(Game game)
        {
            InitializeComponent();
            this.game = game;
        }

        private Game game;

        private Models.GroupAttendance attendance;

        private void Render()
        {
            SuspendLayout();
            attendance = new Models.GroupAttendance(game.ID);
            tlpMain.Controls.Add(attendance, 0, 0);
            tlpMain.SetColumnSpan(attendance, 2);
            ResumeLayout(false);
            PerformLayout();
        }

        private void frmAttendance_Load(object sender, EventArgs e)
        {
            Render();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            attendance.Save();
        }

    }
}

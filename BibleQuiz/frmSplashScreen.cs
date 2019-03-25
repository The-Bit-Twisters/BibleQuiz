using System;
using System.Windows.Forms;
using MySql.Connection;

namespace BibleQuiz
{
    internal partial class frmSplashScreen : Form
    {
        internal frmSplashScreen()
        {
            InitializeComponent();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            timer.Enabled = false;
            frmMain main = new frmMain();
            main.Show();
            this.Close();
        }

        private void frmSplashScreen_Load(object sender, EventArgs e)
        {
            Builder.UserID = Properties.Settings.Default.UserID;
            Builder.Password = Properties.Settings.Default.Password;
            Builder.Server = Properties.Settings.Default.Server;
            Builder.Port = Properties.Settings.Default.Port;
            Builder.Database = Properties.Settings.Default.Database;
            Builder.SqlServerMode = true;
        }

    }
}

using System;
using System.Windows.Forms;
using MySql.Connection;
using System.Data;

namespace BibleQuiz.Dialogs
{
    internal partial class Config : Form
    {
        internal Config(frmMain main)
        {
            InitializeComponent();
            mainform = main;
        }

        private frmMain mainform;

        private void ConnectionTest()
        {
            lblConnection.Text = "Checking ...";
            if (Builder.ConnectionState == ConnectionState.Open)
            {
                lblConnection.Text = "ONLINE";
            }
            else
            {
                lblConnection.Text = "OFFLINE";
            }
        }

        private void frmConfig_Load(object sender, EventArgs e)
        {
            txtServer.Text = Properties.Settings.Default.Server;
            txtPort.Text = Properties.Settings.Default.Port.ToString();
            txtDatabase.Text = Properties.Settings.Default.Database;
            txtUser.Text = Properties.Settings.Default.UserID;
            txtPassword.Text = Properties.Settings.Default.Password;
            ConnectionTest();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Builder.UserID = Properties.Settings.Default.UserID = txtUser.Text;
            Builder.Password = Properties.Settings.Default.Password = txtPassword.Text;
            Builder.Server = Properties.Settings.Default.Server = txtServer.Text;
            Builder.Port = Properties.Settings.Default.Port = Convert.ToUInt32(txtPort.Text);
            Builder.Database = Properties.Settings.Default.Database = txtDatabase.Text;
            Builder.SqlServerMode = true;
            Properties.Settings.Default.Save();
            ConnectionTest();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmConfig_FormClosed(object sender, FormClosedEventArgs e)
        {
            mainform.ConnectionTest();
        }

    }
}

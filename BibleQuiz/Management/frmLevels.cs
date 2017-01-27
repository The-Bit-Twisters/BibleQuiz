using BibleQuiz.Components;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BibleQuiz.Management
{
    internal partial class frmLevels : Form
    {
        internal frmLevels(frmMain main)
        {
            InitializeComponent();
            level = new Level();
            mainform = main;
        }

        private Level level;
        private frmMain mainform;

        private void Render()
        {
            List<Level> levels = Level.GetAll();
            dgvLevels.Rows.Clear();
            foreach (Level level in levels)
            {
                dgvLevels.Rows.Add(level.ID, level.Name, level.Score.ToString());
            }
            dgvLevels.ClearSelection();
        }

        private void LoadData(Level level)
        {
            txtName.Text = level.Name;
            txtName.Enabled = true;
            nudScore.Value = level.Score;
            nudScore.Enabled = true;
        }

        private void ClearData()
        {
            level = new Level();
            txtName.Text = "";
            txtName.Enabled = false;
            nudScore.Value = 0;
            nudScore.Enabled = false;
        }

        private void frmLevels_Load(object sender, EventArgs e)
        {
            Render();
        }

        private void dgvLevels_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvLevels.SelectedRows.Count > 0)
            {
                level = Level.GetByID(Convert.ToInt64(dgvLevels.SelectedRows[0].Cells["colLevelID"].Value));
                LoadData(level);
            }
            else
            {
                ClearData();
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            dgvLevels.ClearSelection();
            level = new Level();
            LoadData(level);
            txtName.Focus();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            level.Name = txtName.Text;
            level.Score = Convert.ToInt16(nudScore.Value);
            if (level.Save())
            {
                MessageBox.Show("Data has been saved successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Render();
            }
        }

        private void frmLevels_FormClosed(object sender, FormClosedEventArgs e)
        {
            mainform.Focus();
        }

    }
}

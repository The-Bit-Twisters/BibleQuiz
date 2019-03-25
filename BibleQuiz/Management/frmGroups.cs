using BibleQuiz.Components;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BibleQuiz.Management
{
    internal partial class frmGroups : Form
    {
        internal frmGroups(frmMain main)
        {
            InitializeComponent();
            group = new Group();
            mainform = main;
        }

        private Group group;
        private frmMain mainform;

        private void Render()
        {
            List<Group> groups = Group.GetAll();
            dgvGroups.Rows.Clear();
            foreach (Group group in groups)
            {
                dgvGroups.Rows.Add(group.ID, group.Name);
            }
            dgvGroups.ClearSelection();
        }

        private void LoadData(Group group)
        {
            txtName.Enabled = true;
            txtName.Text = group.Name;
            dgvMembers.Rows.Clear();
            foreach (Member member in group.Members)
            {
                dgvMembers.Rows.Add(member.ID, member.Name);
            }
            dgvMembers.ClearSelection();
            btnAddMember.Enabled = true;
            btnEditMember.Enabled = true;
            btnRemoveMember.Enabled = true;
        }

        private void ClearData()
        {
            group = new Group();
            txtName.Text = "";
            txtName.Enabled = false;
            dgvMembers.Rows.Clear();
            btnAddMember.Enabled = false;
            btnEditMember.Enabled = false;
            btnRemoveMember.Enabled = false;
        }

        private void frmGroups_Load(object sender, EventArgs e)
        {
            Render();
        }

        private void dgvGroups_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvGroups.SelectedRows.Count > 0)
            {
                group = Group.GetByID(Convert.ToInt64(dgvGroups.SelectedRows[0].Cells["colGroupID"].Value));
                LoadData(group);
            }
            else
            {
                ClearData();
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            dgvGroups.ClearSelection();
            group = new Group();
            LoadData(group);
            txtName.Focus();
        }

        private void btnAddMember_Click(object sender, EventArgs e)
        {
            Dialogs.GroupMember groupmember = new Dialogs.GroupMember();
            if (groupmember.ShowDialog() == DialogResult.OK)
            {
                dgvMembers.Rows.Add(groupmember.Member.ID, groupmember.Member.Name);
                dgvMembers.ClearSelection();
            }
        }

        private void btnEditMember_Click(object sender, EventArgs e)
        {
            if (dgvMembers.SelectedRows.Count > 0)
            {
                Member member = Member.GetByID(Convert.ToInt64(dgvMembers.SelectedRows[0].Cells["colMemberID"].Value));
                Dialogs.GroupMember groupmember = new Dialogs.GroupMember();
                groupmember.Member = member;
                if (groupmember.ShowDialog() == DialogResult.OK)
                {
                    dgvMembers.SelectedRows[0].Cells["colMemberID"].Value = groupmember.Member.ID;
                    dgvMembers.SelectedRows[0].Cells["colMemberName"].Value = groupmember.Member.Name;
                    dgvMembers.ClearSelection();
                }
            }
        }

        private void btnRemoveMember_Click(object sender, EventArgs e)
        {
            if (dgvMembers.SelectedRows.Count > 0)
            {
                dgvMembers.Rows.Remove(dgvMembers.SelectedRows[0]);
                dgvMembers.ClearSelection();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtName.TextLength > 0)
            {
                group.Name = txtName.Text;
                group.Members.Clear();
                foreach (DataGridViewRow row in dgvMembers.Rows)
                {
                    Member member = new Member();
                    member.ID = Convert.ToInt64(row.Cells["colMemberID"].Value);
                    member.Name = row.Cells["colMemberName"].Value.ToString();
                    group.Members.Add(member);
                }
                if (group.Save())
                {
                    MessageBox.Show("Data has been saved successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Render();
                }
            }
        }

        private void frmGroups_FormClosed(object sender, FormClosedEventArgs e)
        {
            mainform.Focus();
        }

    }
}

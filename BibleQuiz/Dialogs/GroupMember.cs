using BibleQuiz.Components;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BibleQuiz.Dialogs
{
    internal partial class GroupMember : Form
    {
        internal GroupMember()
        {
            InitializeComponent();
            member = new Member();
        }

        private Member member;

        internal Member Member
        {
            get { return member; }
            set { member = value; }
        }

        private void GroupMember_Load(object sender, EventArgs e)
        {
            txtName.Focus();
            txtName.Text = member.Name;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            member.Name = txtName.Text;
        }

    }
}

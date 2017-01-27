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

namespace BibleQuiz.Play
{
    internal partial class dlgPassOrPlay : Form
    {
        internal dlgPassOrPlay(frmControls controls, Question question)
        {
            InitializeComponent();
            this.controls = controls;
            this.question = question;
            passorplayForm = new frmPassOrPlay(question);
        }

        private frmControls controls;
        private frmPassOrPlay passorplayForm;

        private Models.PresentGroups presentGroups;

        private Question question;

        private void Render()
        {
            SuspendLayout();
            presentGroups = new Models.PresentGroups(question);
            Models.PresentGroups.passorplayGroups = passorplayForm.passorplayGroups;
            tlpMain.Controls.Add(presentGroups, 0, 1);
            tlpMain.SetColumnSpan(presentGroups, 3);
            ResumeLayout(false);
            PerformLayout();
        }

        private void frmPassOrPlay_Load(object sender, EventArgs e)
        {
            SetBounds(controls.Location.X, controls.Location.Y, controls.Size.Width, controls.Size.Height);
            Level level = Level.GetByID(question.Level);
            lblQuestion.Text = "Question #" + question.Sequence + " " + level.Name;
            lblCorrectPoints.Text = "Correct +" + (level.Special * 3) + " Points";
            lblIncorrectPoints.Text = "Wrong -" + (level.Special * 2) + " Points";
            Render();
            passorplayForm.Show();
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            controls.grouppoints.SetPlay(presentGroups.GetChecked());
            passorplayForm.Close();
        }

    }
}

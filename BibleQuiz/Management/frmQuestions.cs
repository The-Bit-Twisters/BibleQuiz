using BibleQuiz.Components;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace BibleQuiz.Management
{
    internal partial class frmQuestions : Form
    {
        internal frmQuestions(frmMain main, Game game)
        {
            InitializeComponent();
            this.game = game;
            question = new Question();
            mainform = main;
        }

        private Game game;
        private Question question;
        private frmMain mainform;

        private Play.frmQuestionBox questionBox;

        private void PrepareQuestion()
        {
            question.Game = game.ID;
            question.Level = cbxLevels.SelectedIndex + 1;
            question.PassPlay = chkPassOrPlay.Checked;
            question.QuestionStatement = txtQuestionStatement.Text;
            question.BibleReference = txtBibleReference.Text;
            question.Choices.Clear();
            switch(cbxChoicesTypes.SelectedIndex) 
            {
                case 0:
                    // Multiple Choice #A
                    Choice choice1 = new Choice();
                    choice1.ID = Convert.ToInt64(txtMultipleChoiceA.Tag);
                    choice1.Value = txtMultipleChoiceA.Text;
                    choice1.Answer = rdoMultipleChoiceA.Checked;
                    question.Choices.Add(choice1);
                    // Multiple Choice #B
                    Choice choice2 = new Choice();
                    choice2.ID = Convert.ToInt64(txtMultipleChoiceB.Tag);
                    choice2.Value = txtMultipleChoiceB.Text;
                    choice2.Answer = rdoMultipleChoiceB.Checked;
                    question.Choices.Add(choice2);
                    // Multiple Choice #C
                    Choice choice3 = new Choice();
                    choice3.ID = Convert.ToInt64(txtMultipleChoiceC.Tag);
                    choice3.Value = txtMultipleChoiceC.Text;
                    choice3.Answer = rdoMultipleChoiceC.Checked;
                    question.Choices.Add(choice3);
                    // Multiple Choice #D
                    Choice choice4 = new Choice();
                    choice4.ID = Convert.ToInt64(txtMultipleChoiceD.Tag);
                    choice4.Value = txtMultipleChoiceD.Text;
                    choice4.Answer = rdoMultipleChoiceD.Checked;
                    question.Choices.Add(choice4);
                    if (rdoLayout1x4.Checked)
                    {
                        // Layout #1x4
                        question.ChoicesLayout = Models.Layout.Choices.OneByFour;
                    }
                    if (rdoLayout2x2.Checked)
                    {
                        // Layout #2x2
                        question.ChoicesLayout = Models.Layout.Choices.TwoByTwo;
                    }
                    if (rdoLayout4x1.Checked)
                    {
                        // Layout #4x1
                        question.ChoicesLayout = Models.Layout.Choices.FourByOne;
                    }
                    break;
                case 1:
                    // True or False #True
                    Choice choiceTrue = new Choice();
                    choiceTrue.ID = Convert.ToInt64(rdoTrue.Tag);
                    choiceTrue.Value = rdoTrue.Text;
                    choiceTrue.Answer = rdoTrue.Checked;
                    question.Choices.Add(choiceTrue);
                    // True or False #False
                    Choice choiceFalse = new Choice();
                    choiceFalse.ID = Convert.ToInt64(rdoFalse.Tag);
                    choiceFalse.Value = rdoFalse.Text;
                    choiceFalse.Answer = rdoFalse.Checked;
                    question.Choices.Add(choiceFalse);
                    // Layout #1x2
                    question.ChoicesLayout = Models.Layout.Choices.OneByTwo;
                    break;
                case 2:
                    // Identification
                    Choice choice = new Choice();
                    choice.ID = Convert.ToInt64(txtIdentification.Tag);
                    choice.Value = txtIdentification.Text;
                    choice.Answer = true;
                    question.Choices.Add(choice);
                    // Layout #1x1
                    question.ChoicesLayout = Models.Layout.Choices.OneByOne;
                    break;
            }
        }

        private void ToggleOnOff(RadioButton radiobutton)
        {
            if (radiobutton.Checked)
            {
                radiobutton.BackColor = Color.DarkGreen;
                radiobutton.ForeColor = Color.Black;
            }
            else
            {
                radiobutton.BackColor = Color.DarkRed;
                radiobutton.ForeColor = Color.White;
            }
        }

        private void LoadGame()
        {
            lblGame.Text = game.Date.ToString("MMMM dd, yyyy");
            Render();
        }

        private void LoadLevels()
        {
            List<Level> levels = Level.GetAll();
            cbxLevels.Items.Clear();
            foreach (Level level in levels)
            {
                cbxLevels.Items.Add(level.Name);
            }
            cbxLevels.SelectedIndex = -1;
        }

        private void Render()
        {
            List<Question> questions = game.Questions;
            dgvQuestions.Rows.Clear();
            foreach (Question question in questions)
            {
                dgvQuestions.Rows.Add(question.ID, question.Sequence, question.QuestionStatement, Level.GetByID(question.Level).Name);
            }
            dgvQuestions.ClearSelection();
        }

        private void LoadData(Question question)
        {
            txtSequence.Text = question.Sequence.ToString();
            cbxLevels.SelectedIndex = (int)(question.Level - 1);
            chkPassOrPlay.Enabled = true;
            chkPassOrPlay.Checked = question.PassPlay;
            txtQuestionStatement.Text = question.QuestionStatement;
            txtBibleReference.Text = question.BibleReference;
            // enable all
            txtSequence.Enabled = true;
            cbxLevels.Enabled = true;
            txtQuestionStatement.Enabled = true;
            txtBibleReference.Enabled = true;
            cbxChoicesTypes.Enabled = true;
            txtMultipleChoiceA.Enabled = true;
            txtMultipleChoiceB.Enabled = true;
            txtMultipleChoiceC.Enabled = true;
            txtMultipleChoiceD.Enabled = true;
            rdoTrue.Enabled = true;
            rdoFalse.Enabled = true;
            txtIdentification.Enabled = true;
            if (question.Choices.Count == 0)
            {
                Choice choice = new Choice();
                choice.Answer = true;
                switch(question.Level) 
                {
                    case 1:
                        question.Choices.Add(choice);
                        question.Choices.Add(choice);
                        question.Choices.Add(choice);
                        question.Choices.Add(choice);
                        break;
                    case 2:
                        question.Choices.Add(choice);
                        question.Choices.Add(choice);
                        break;
                    case 3:
                        question.Choices.Add(choice);
                        break;
                }
            }
            switch (question.Choices.Count)
            {
                case 4:
                    cbxChoicesTypes.SelectedIndex = 0;
                    // Multiple Choice #A
                    txtMultipleChoiceA.Tag = question.Choices[0].ID;
                    txtMultipleChoiceA.Text = question.Choices[0].Value;
                    rdoMultipleChoiceA.Checked = question.Choices[0].Answer;
                    // Multiple Choice #B
                    txtMultipleChoiceB.Tag = question.Choices[1].ID;
                    txtMultipleChoiceB.Text = question.Choices[1].Value;
                    rdoMultipleChoiceB.Checked = question.Choices[1].Answer;
                    // Multiple Choice #C
                    txtMultipleChoiceC.Tag = question.Choices[2].ID;
                    txtMultipleChoiceC.Text = question.Choices[2].Value;
                    rdoMultipleChoiceC.Checked = question.Choices[2].Answer;
                    // Multiple Choice #D
                    txtMultipleChoiceD.Tag = question.Choices[3].ID;
                    txtMultipleChoiceD.Text = question.Choices[3].Value;
                    rdoMultipleChoiceD.Checked = question.Choices[3].Answer;
                    if (question.ChoicesLayout == Models.Layout.Choices.OneByFour)
                    {
                        // Layout #1x4
                        rdoLayout1x4.Checked = true;
                    }
                    else if (question.ChoicesLayout == Models.Layout.Choices.TwoByTwo)
                    {
                        // Layout #2x2
                        rdoLayout2x2.Checked = true;
                    }
                    else if (question.ChoicesLayout == Models.Layout.Choices.FourByOne)
                    {
                        // Layout #4x1
                        rdoLayout4x1.Checked = true;
                    }
                    else
                    {
                        // Layout #1x4
                        rdoLayout1x4.Checked = true;
                    }
                    break;
                case 2:
                    cbxChoicesTypes.SelectedIndex = 1;
                    // True or False #True
                    rdoTrue.Tag = question.Choices[0].ID;
                    rdoTrue.Checked = question.Choices[0].Answer;
                    // True or False #False
                    rdoFalse.Tag = question.Choices[1].ID;
                    rdoFalse.Checked = question.Choices[1].Answer;
                    break;
                case 1:
                    cbxChoicesTypes.SelectedIndex = 2;
                    // Identification
                    txtIdentification.Tag = question.Choices[0].ID;
                    txtIdentification.Text = question.Choices[0].Value;
                    break;
            }
        }

        private void ClearData()
        {
            question = new Question();
            txtSequence.Text = "0";
            txtSequence.Enabled = false;
            cbxLevels.SelectedIndex = -1;
            cbxLevels.Enabled = false;
            chkPassOrPlay.Enabled = false;
            chkPassOrPlay.Checked = false;
            txtQuestionStatement.Clear();
            txtQuestionStatement.Enabled = false;
            txtBibleReference.Clear();
            txtBibleReference.Enabled = false;
            cbxChoicesTypes.SelectedIndex = 0;
            cbxChoicesTypes.Enabled = false;
            // Multiple Choices
            rdoMultipleChoiceA.Checked = false;
            rdoMultipleChoiceB.Checked = false;
            rdoMultipleChoiceC.Checked = false;
            rdoMultipleChoiceD.Checked = false;
            txtMultipleChoiceA.Clear();
            txtMultipleChoiceA.Tag = 0;
            txtMultipleChoiceA.Enabled = false;
            txtMultipleChoiceB.Clear();
            txtMultipleChoiceB.Tag = 0;
            txtMultipleChoiceB.Enabled = false;
            txtMultipleChoiceC.Clear();
            txtMultipleChoiceC.Tag = 0;
            txtMultipleChoiceC.Enabled = false;
            txtMultipleChoiceD.Clear();
            txtMultipleChoiceD.Tag = 0;
            txtMultipleChoiceD.Enabled = false;
            // True or False
            rdoTrue.Tag = 0;
            rdoTrue.Enabled = false;
            rdoFalse.Tag = 0;
            rdoFalse.Enabled = false;
            // Identification
            txtIdentification.Clear();
            txtIdentification.Tag = 0;
            txtIdentification.Enabled = false;
            // Layouts
            rdoLayout1x4.Checked = false;
            rdoLayout2x2.Checked = false;
            rdoLayout4x1.Checked = false;
        }

        private void frmQuestions_Load(object sender, EventArgs e)
        {
            LoadLevels();
            ClearData();
            LoadGame();
        }

        private void btnSelectGame_Click(object sender, EventArgs e)
        {
            Dialogs.SelectGame selectgame = new Dialogs.SelectGame(Game.Filter.All);
            if (selectgame.ShowDialog() == DialogResult.OK)
            {
                game = selectgame.SelectedGame;
                LoadGame();
            }
        }

        private void dgvQuestions_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvQuestions.SelectedRows.Count > 0)
            {
                question = Question.GetByID(Convert.ToInt64(dgvQuestions.SelectedRows[0].Cells["colQuestionID"].Value));
                LoadData(question);
            }
            else
            {
                ClearData();
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            question = new Question();
            question.Sequence = Question.GetNextSequence(game.ID);
            if (question.Sequence <= 11)
            {
                question.Level = 1;
            }
            else if (question.Sequence <= 22)
            {
                question.Level = 2;
            }
            else if (question.Sequence <= 33)
            {
                question.Level = 3;
            }
            else
            {
                question.Level = 1;
            }
            LoadData(question);
            if (question.Sequence == 7 || question.Sequence == 18 || question.Sequence == 30)
            {
                chkPassOrPlay.Checked = true;
            }
            else
            {
                chkPassOrPlay.Checked = false;
            }
            txtQuestionStatement.Focus();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (questionBox != null)
            {
                questionBox.Dispose();
            }
            PrepareQuestion();
            if (question.Save())
            {
                MessageBox.Show("Data has been saved successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Render();
            }
        }

        private void cbxChoicesTypes_SelectedIndexChanged(object sender, EventArgs e)
        {
            SuspendLayout();
            switch (cbxChoicesTypes.SelectedIndex)
            {
                case 0:
                    rdoLayout1x4.Enabled = true;
                    rdoLayout1x4.Checked = true;
                    rdoLayout2x2.Enabled = true;
                    rdoLayout4x1.Enabled = true;
                    tlpTrueOrFalse.Hide();
                    tlpIdentification.Hide();
                    tlpMultipleChoice.Show();
                    break;
                case 1:
                    rdoLayout1x4.Enabled = false;
                    rdoLayout2x2.Enabled = false;
                    rdoLayout4x1.Enabled = false;
                    tlpMultipleChoice.Hide();
                    tlpIdentification.Hide();
                    tlpTrueOrFalse.Show();
                    break;
                case 2:
                    rdoLayout1x4.Enabled = false;
                    rdoLayout2x2.Enabled = false;
                    rdoLayout4x1.Enabled = false;
                    tlpMultipleChoice.Hide();
                    tlpTrueOrFalse.Hide();
                    tlpIdentification.Show();
                    break;
            }
            ResumeLayout(false);
            PerformLayout();
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            PrepareQuestion();
            if (questionBox != null)
            {
                questionBox.Dispose();
            }
            questionBox = new Play.frmQuestionBox(null, question);
            questionBox.ShowChoices();
            questionBox.Show();
        }

        private void rdoLayout1x4_CheckedChanged(object sender, EventArgs e)
        {
            ToggleOnOff(rdoLayout1x4);
        }

        private void rdoLayout2x2_CheckedChanged(object sender, EventArgs e)
        {
            ToggleOnOff(rdoLayout2x2);
        }

        private void rdoLayout4x1_CheckedChanged(object sender, EventArgs e)
        {
            ToggleOnOff(rdoLayout4x1);
        }

        private void rdoMultipleChoiceA_CheckedChanged(object sender, EventArgs e)
        {
            ToggleOnOff(rdoMultipleChoiceA);
        }

        private void rdoMultipleChoiceB_CheckedChanged(object sender, EventArgs e)
        {
            ToggleOnOff(rdoMultipleChoiceB);
        }

        private void rdoMultipleChoiceC_CheckedChanged(object sender, EventArgs e)
        {
            ToggleOnOff(rdoMultipleChoiceC);
        }

        private void rdoMultipleChoiceD_CheckedChanged(object sender, EventArgs e)
        {
            ToggleOnOff(rdoMultipleChoiceD);
        }

        private void rdoTrue_CheckedChanged(object sender, EventArgs e)
        {
            ToggleOnOff(rdoTrue);
        }

        private void rdoFalse_CheckedChanged(object sender, EventArgs e)
        {
            ToggleOnOff(rdoFalse);
        }

        private void frmQuestions_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (questionBox != null)
            {
                questionBox.Dispose();
            }
            mainform.Focus();
        }

        private void chkPassOrPlay_CheckedChanged(object sender, EventArgs e)
        {
            if (chkPassOrPlay.Checked)
            {
                chkPassOrPlay.Text = "Yes";
                chkPassOrPlay.BackColor = Color.DarkGreen;
                chkPassOrPlay.ForeColor = Color.Black;
            }
            else
            {
                chkPassOrPlay.Text = "No";
                chkPassOrPlay.BackColor = Color.DarkRed;
                chkPassOrPlay.ForeColor = Color.White;
            }
        }

    }
}

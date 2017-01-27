using BibleQuiz.Components;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace BibleQuiz.Play
{
    internal partial class frmControls : Form
    {
        internal frmControls(Game game, frmMain main)
        {
            InitializeComponent();
            this.mainform = main;
            //variables
            this.game = game;
        }

        //main form
        private frmMain mainform;
        //play forms
        private frmScoreBoard scoreBoard;
        private frmScoreBoard gamescoreBoard;
        private frmQuestionBox questionBox;
        private frmGroupAnswersBoard groupanswersBoard;

        //variables
        private short sequence;
        private Game game;
        private List<Question> questions;
        private Question previousQuestion;
        private Question currentQuestion;
        private Question nextQuestion;

        //layouts
        private Models.GroupScore groupscore;
        internal Models.GroupPoints grouppoints;
        private Models.QuestionChoices questionChoices;

        private void ToggleOnOff(CheckBox checkbox)
        {
            if (checkbox.Checked)
            {
                checkbox.BackColor = Color.DarkGreen;
                checkbox.ForeColor = Color.Black;
                checkbox.Text = "ON";
            }
            else
            {
                checkbox.BackColor = Color.DarkRed;
                checkbox.ForeColor = Color.White;
                checkbox.Text = "OFF";
            }
        }

        private void LoadGroups()
        {
            grouppoints = new Models.GroupPoints(this, game.ID);
            tlpPoints.Controls.Add(grouppoints, 0, 1);
            tlpPoints.SetColumnSpan(grouppoints, 2);
        }

        private void UpdateGame()
        {
            lblGame.Text = "Game #" + game.Sequence + " " + game.Date.ToString("MMMM dd, yyyy");
            if (game.Finished)
            {
                lblGameQuestionSequence.Text = "Finished";
            }
            else
            {
                if (Settings.Current.Question.ID > 0)
                {
                    lblGameQuestionSequence.Text = "Current Question #" + Settings.Current.Question.Sequence;
                }
                else
                {
                    lblGameQuestionSequence.Text = "Current Question #" + currentQuestion.Sequence;
                    Settings.Current.Question = currentQuestion;
                }
            }
        }

        private void UpdateScores()
        {
            if (scoreBoard != null)
            {
                scoreBoard.UpdateScores();
            }
            if (gamescoreBoard != null)
            {
                gamescoreBoard.UpdateScores();
            }
            SuspendLayout();
            if (groupscore != null)
            {
                tlpScores.Controls.Remove(groupscore);
                groupscore.Dispose();
            }
            groupscore = new Models.GroupScore(game.ID, Models.Layout.View.ControllerEmbed);
            tlpScores.Controls.Add(groupscore, 0, 1);
            ResumeLayout(false);
            PerformLayout();
        }

        private void LoadQuestions()
        {
            questions = game.Questions;
            if (questions.Count < 3)
            {
                btnNext.Enabled = false;
                btnPrevious.Enabled = false;
                return;
            }
            previousQuestion = new Question();
            currentQuestion = questions[0];
            nextQuestion = questions[1];
            LoadPreviousQuestion();
            LoadNextQuestion();
            LoadCurrentQuestion();
            UpdateGame();
        }

        private void LoadPreviousQuestion()
        {
            Level level = Level.GetByID(previousQuestion.Level);
            lblPreviousDetails.Text = "#" + previousQuestion.Sequence + "\n" + level.Name;
            lblPreviousQuestionStatement.Text = previousQuestion.QuestionStatement;
        }

        private void LoadNextQuestion()
        {
            Level level = Level.GetByID(nextQuestion.Level);
            lblNextDetails.Text = "#" + nextQuestion.Sequence + "\n" + level.Name;
            lblNextQuestionStatement.Text = nextQuestion.QuestionStatement;
        }

        private void LoadCurrentQuestion()
        {
            SuspendLayout();
            Level level = Level.GetByID(currentQuestion.Level);
            lblCurrentSequence.Text = "#" + currentQuestion.Sequence;
            lblCurrentDifficulty.Text = level.Name.ToUpper();
            if (currentQuestion.PassPlay)
            {
                lblCurrentPoints.Text = "+" + (level.Special * 3) + " or -" + (level.Special * 2) + " Points";
            }
            else
            {
                lblCurrentPoints.Text = "+" + level.Score + " Points";
            }
            lblCurrentQuestionStatement.Text = currentQuestion.QuestionStatement;
            if (questionChoices != null)
            {
                questionChoices.Dispose();
            }
            questionChoices = new Models.QuestionChoices(currentQuestion, Models.Layout.View.ControllerEmbed);
            tlpCurrentQuestion.Controls.Add(questionChoices, 0, 4);
            tlpCurrentQuestion.SetColumnSpan(questionChoices, 6);
            if (game.Finished || currentQuestion.ID < Settings.Current.Question.ID)
            {
                questionChoices.RevealAnswer();
            }
            grouppoints.UpdateCheckBoxes(currentQuestion);
            lblPointsTo.Text = "Points (Question #" + currentQuestion.Sequence + ")";
            ResumeLayout(false);
            PerformLayout();
            if (currentQuestion.PassPlay && Settings.Current.Question.ID == currentQuestion.ID)
            {
                dlgPassOrPlay passorplay = new dlgPassOrPlay(this, currentQuestion);
                passorplay.ShowDialog();
            }
        }

        private void frmControls_Load(object sender, EventArgs e)
        {
            if (!game.Finished)
            {
                dlgAttendance attendance = new dlgAttendance(game);
                attendance.ShowDialog();
            }
            LoadGroups();
            UpdateScores();
            LoadQuestions();
        }

        private void chkTotalScoreBoard_CheckedChanged(object sender, EventArgs e)
        {
            if (chkTotalScoreBoard.Checked)
            {
                if (scoreBoard != null)
                {
                    scoreBoard.Dispose();
                }
                scoreBoard = new frmScoreBoard(this, 0);
                scoreBoard.Show();
            }
            else
            {
                scoreBoard.Close();
                scoreBoard.Dispose();
            }
            ToggleOnOff(chkTotalScoreBoard);
        }

        private void chkGameScoreBoard_CheckedChanged(object sender, EventArgs e)
        {
            if (chkCurrentGameScoreBoard.Checked)
            {
                if (gamescoreBoard != null)
                {
                    gamescoreBoard.Dispose();
                }
                gamescoreBoard = new frmScoreBoard(this, game.ID);
                gamescoreBoard.Show();
            }
            else
            {
                gamescoreBoard.Close();
                gamescoreBoard.Dispose();
            }
            ToggleOnOff(chkCurrentGameScoreBoard);
        }

        private void chkGroupAnswers_CheckedChanged(object sender, EventArgs e)
        {
            if (chkGroupAnswers.Checked)
            {
                if (groupanswersBoard != null)
                {
                    groupanswersBoard.Dispose();
                }
                groupanswersBoard = new frmGroupAnswersBoard(this, currentQuestion.ID);
                groupanswersBoard.Show();
            }
            else
            {
                groupanswersBoard.Close();
                groupanswersBoard.Dispose();
            }
            ToggleOnOff(chkGroupAnswers);
        }

        private void chkQuestionBox_CheckedChanged(object sender, EventArgs e)
        {
            ToggleOnOff(chkQuestionBox);
            if (chkQuestionBox.Checked)
            {
                if (questionBox != null)
                {
                    questionBox.Dispose();
                }
                questionBox = new frmQuestionBox(this, currentQuestion);
                questionBox.Show();
                chkShowChoices.Enabled = true;
                chkQuestionBox.Enabled = false;
            }
            else
            {
                questionBox.Close();
                questionBox.Dispose();
                chkQuestionBox.Enabled = true;
                chkShowChoices.Enabled = false;
                chkRevealAnswer.Enabled = false;
            }
        }

        private void chkShowChoices_CheckedChanged(object sender, EventArgs e)
        {
            ToggleOnOff(chkShowChoices);
            if (chkShowChoices.Checked)
            {
                questionBox.ShowChoices();
                chkShowChoices.Enabled = false;
                chkRevealAnswer.Enabled = true;
            }
        }

        private void chkRevealAnswer_CheckedChanged(object sender, EventArgs e)
        {
            ToggleOnOff(chkRevealAnswer);
            if (chkRevealAnswer.Checked)
            {
                questionChoices.RevealAnswer();
                questionBox.RevealAnswer();
                chkRevealAnswer.Enabled = false;
                chkQuestionBox.Enabled = true;
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (sequence < questions.Count - 2)
            {
                sequence += 1;
                nextQuestion = questions[sequence + 1];
            }
            else
            {
                sequence = Convert.ToInt16(questions.Count - 1);
                nextQuestion = new Question();
            }
            previousQuestion = questions[sequence - 1];
            currentQuestion = questions[sequence];
            LoadPreviousQuestion();
            LoadNextQuestion();
            LoadCurrentQuestion();
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (sequence > 1)
            {
                sequence -= 1;
                previousQuestion = questions[sequence - 1];
            }
            else
            {
                sequence = 0;
                previousQuestion = new Question();
            }
            nextQuestion = questions[sequence + 1];
            currentQuestion = questions[sequence];
            LoadPreviousQuestion();
            LoadNextQuestion();
            LoadCurrentQuestion();
        }

        private void btnPointsSave_Click(object sender, EventArgs e)
        {
            if (Settings.Current.Question.ID > 0)
            {
                Question question = Settings.Current.Question;
                grouppoints.SaveGroupPoints(question);
                for (int i = 0; i < questions.Count; i++)
                {
                    if (questions[i].ID == Settings.Current.Question.ID && i < questions.Count - 1)
                    {
                        question = questions[i + 1];
                        break;
                    }
                    else
                    {
                        question = new Question();
                    }
                }
                Settings.Current.Question = question;
                if (question.ID == 0)
                {
                    game.Finished = true;
                    game.Save();
                }
                UpdateGame();
                chkGroupAnswers.Checked = false;
                chkQuestionBox.Checked = false;
                UpdateScores();
                grouppoints.UpdateCheckBoxes(currentQuestion);
            }
        }

        private void frmControls_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (scoreBoard != null)
            {
                scoreBoard.Dispose();
            }
            if (gamescoreBoard != null)
            {
                gamescoreBoard.Dispose();
            }
            if (questionBox != null)
            {
                questionBox.Dispose();
            }
            if (groupanswersBoard != null)
            {
                groupanswersBoard.Dispose();
            }
            mainform.Show();
        }

        private void frmControls_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialogresult = MessageBox.Show("Are you sure you want to exit?", "Prompt", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2, MessageBoxOptions.DefaultDesktopOnly);
            if (dialogresult == DialogResult.Yes)
            {
                mainform.Show();
            }
            else
            {
                e.Cancel = true;
            }
        }

    }
}

namespace BibleQuiz.Play
{
    partial class frmControls
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tlpHeader = new System.Windows.Forms.TableLayoutPanel();
            this.chkGroupAnswers = new System.Windows.Forms.CheckBox();
            this.lblGroupAnswers = new System.Windows.Forms.Label();
            this.lblTotalScore = new System.Windows.Forms.Label();
            this.lblGameQuestionSequence = new System.Windows.Forms.Label();
            this.lblScoreBoard = new System.Windows.Forms.Label();
            this.chkTotalScoreBoard = new System.Windows.Forms.CheckBox();
            this.chkCurrentGameScoreBoard = new System.Windows.Forms.CheckBox();
            this.lblGame = new System.Windows.Forms.Label();
            this.tlpScores = new System.Windows.Forms.TableLayoutPanel();
            this.lblScores = new System.Windows.Forms.Label();
            this.tlpQuestions = new System.Windows.Forms.TableLayoutPanel();
            this.lblPreviousDetails = new System.Windows.Forms.Label();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.lblQuestions = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.Button();
            this.lblPreviousQuestionStatement = new System.Windows.Forms.Label();
            this.lblNextQuestionStatement = new System.Windows.Forms.Label();
            this.tlpCurrentQuestion = new System.Windows.Forms.TableLayoutPanel();
            this.lblCurrentQuestionStatement = new System.Windows.Forms.Label();
            this.lblCurrentSequence = new System.Windows.Forms.Label();
            this.lblCurrentDifficulty = new System.Windows.Forms.Label();
            this.lblCurrentPoints = new System.Windows.Forms.Label();
            this.lblQuestionBox = new System.Windows.Forms.Label();
            this.chkQuestionBox = new System.Windows.Forms.CheckBox();
            this.lblShowChoices = new System.Windows.Forms.Label();
            this.chkShowChoices = new System.Windows.Forms.CheckBox();
            this.lblAnswer = new System.Windows.Forms.Label();
            this.chkRevealAnswer = new System.Windows.Forms.CheckBox();
            this.lblChoices = new System.Windows.Forms.Label();
            this.lblNextDetails = new System.Windows.Forms.Label();
            this.tlpPoints = new System.Windows.Forms.TableLayoutPanel();
            this.lblPointsTo = new System.Windows.Forms.Label();
            this.btnPointsSave = new System.Windows.Forms.Button();
            this.tlpMain = new System.Windows.Forms.TableLayoutPanel();
            this.tlpHeader.SuspendLayout();
            this.tlpScores.SuspendLayout();
            this.tlpQuestions.SuspendLayout();
            this.tlpCurrentQuestion.SuspendLayout();
            this.tlpPoints.SuspendLayout();
            this.tlpMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpHeader
            // 
            this.tlpHeader.AutoSize = true;
            this.tlpHeader.BackColor = System.Drawing.Color.Black;
            this.tlpHeader.ColumnCount = 7;
            this.tlpHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpHeader.Controls.Add(this.chkGroupAnswers, 5, 0);
            this.tlpHeader.Controls.Add(this.lblGroupAnswers, 4, 0);
            this.tlpHeader.Controls.Add(this.lblTotalScore, 0, 0);
            this.tlpHeader.Controls.Add(this.lblGameQuestionSequence, 6, 0);
            this.tlpHeader.Controls.Add(this.lblScoreBoard, 2, 0);
            this.tlpHeader.Controls.Add(this.chkTotalScoreBoard, 1, 0);
            this.tlpHeader.Controls.Add(this.chkCurrentGameScoreBoard, 3, 0);
            this.tlpHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.tlpHeader.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.tlpHeader.Location = new System.Drawing.Point(5, 5);
            this.tlpHeader.Margin = new System.Windows.Forms.Padding(0);
            this.tlpHeader.Name = "tlpHeader";
            this.tlpHeader.RowCount = 1;
            this.tlpHeader.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpHeader.Size = new System.Drawing.Size(998, 39);
            this.tlpHeader.TabIndex = 3;
            // 
            // chkGroupAnswers
            // 
            this.chkGroupAnswers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chkGroupAnswers.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkGroupAnswers.AutoSize = true;
            this.chkGroupAnswers.BackColor = System.Drawing.Color.DarkRed;
            this.chkGroupAnswers.FlatAppearance.BorderSize = 0;
            this.chkGroupAnswers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkGroupAnswers.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkGroupAnswers.ForeColor = System.Drawing.Color.White;
            this.chkGroupAnswers.Location = new System.Drawing.Point(563, 5);
            this.chkGroupAnswers.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.chkGroupAnswers.Name = "chkGroupAnswers";
            this.chkGroupAnswers.Size = new System.Drawing.Size(40, 34);
            this.chkGroupAnswers.TabIndex = 9;
            this.chkGroupAnswers.Text = "OFF";
            this.chkGroupAnswers.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkGroupAnswers.UseVisualStyleBackColor = false;
            this.chkGroupAnswers.CheckedChanged += new System.EventHandler(this.chkGroupAnswers_CheckedChanged);
            // 
            // lblGroupAnswers
            // 
            this.lblGroupAnswers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblGroupAnswers.AutoSize = true;
            this.lblGroupAnswers.BackColor = System.Drawing.Color.Black;
            this.lblGroupAnswers.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGroupAnswers.ForeColor = System.Drawing.Color.White;
            this.lblGroupAnswers.Location = new System.Drawing.Point(447, 5);
            this.lblGroupAnswers.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.lblGroupAnswers.Name = "lblGroupAnswers";
            this.lblGroupAnswers.Padding = new System.Windows.Forms.Padding(5);
            this.lblGroupAnswers.Size = new System.Drawing.Size(116, 34);
            this.lblGroupAnswers.TabIndex = 8;
            this.lblGroupAnswers.Text = "Group Answers";
            this.lblGroupAnswers.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTotalScore
            // 
            this.lblTotalScore.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotalScore.AutoSize = true;
            this.lblTotalScore.BackColor = System.Drawing.Color.Black;
            this.lblTotalScore.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalScore.ForeColor = System.Drawing.Color.White;
            this.lblTotalScore.Location = new System.Drawing.Point(10, 5);
            this.lblTotalScore.Margin = new System.Windows.Forms.Padding(10, 5, 0, 0);
            this.lblTotalScore.Name = "lblTotalScore";
            this.lblTotalScore.Padding = new System.Windows.Forms.Padding(5);
            this.lblTotalScore.Size = new System.Drawing.Size(165, 34);
            this.lblTotalScore.TabIndex = 2;
            this.lblTotalScore.Text = "All Games Score Board";
            this.lblTotalScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblGameQuestionSequence
            // 
            this.lblGameQuestionSequence.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblGameQuestionSequence.AutoSize = true;
            this.lblGameQuestionSequence.BackColor = System.Drawing.Color.Transparent;
            this.lblGameQuestionSequence.Font = new System.Drawing.Font("Copperplate Gothic Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGameQuestionSequence.ForeColor = System.Drawing.Color.White;
            this.lblGameQuestionSequence.Location = new System.Drawing.Point(760, 5);
            this.lblGameQuestionSequence.Margin = new System.Windows.Forms.Padding(0, 5, 5, 0);
            this.lblGameQuestionSequence.Name = "lblGameQuestionSequence";
            this.lblGameQuestionSequence.Padding = new System.Windows.Forms.Padding(5);
            this.lblGameQuestionSequence.Size = new System.Drawing.Size(233, 34);
            this.lblGameQuestionSequence.TabIndex = 4;
            this.lblGameQuestionSequence.Text = "Current Question";
            this.lblGameQuestionSequence.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblScoreBoard
            // 
            this.lblScoreBoard.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblScoreBoard.AutoSize = true;
            this.lblScoreBoard.BackColor = System.Drawing.Color.Black;
            this.lblScoreBoard.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScoreBoard.ForeColor = System.Drawing.Color.White;
            this.lblScoreBoard.Location = new System.Drawing.Point(215, 5);
            this.lblScoreBoard.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.lblScoreBoard.Name = "lblScoreBoard";
            this.lblScoreBoard.Padding = new System.Windows.Forms.Padding(5);
            this.lblScoreBoard.Size = new System.Drawing.Size(192, 34);
            this.lblScoreBoard.TabIndex = 4;
            this.lblScoreBoard.Text = "Current Game Score Board";
            this.lblScoreBoard.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // chkTotalScoreBoard
            // 
            this.chkTotalScoreBoard.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chkTotalScoreBoard.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkTotalScoreBoard.AutoSize = true;
            this.chkTotalScoreBoard.BackColor = System.Drawing.Color.DarkRed;
            this.chkTotalScoreBoard.FlatAppearance.BorderSize = 0;
            this.chkTotalScoreBoard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkTotalScoreBoard.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkTotalScoreBoard.ForeColor = System.Drawing.Color.White;
            this.chkTotalScoreBoard.Location = new System.Drawing.Point(175, 5);
            this.chkTotalScoreBoard.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.chkTotalScoreBoard.Name = "chkTotalScoreBoard";
            this.chkTotalScoreBoard.Size = new System.Drawing.Size(40, 34);
            this.chkTotalScoreBoard.TabIndex = 7;
            this.chkTotalScoreBoard.Text = "OFF";
            this.chkTotalScoreBoard.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkTotalScoreBoard.UseVisualStyleBackColor = false;
            this.chkTotalScoreBoard.CheckedChanged += new System.EventHandler(this.chkTotalScoreBoard_CheckedChanged);
            // 
            // chkCurrentGameScoreBoard
            // 
            this.chkCurrentGameScoreBoard.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chkCurrentGameScoreBoard.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkCurrentGameScoreBoard.AutoSize = true;
            this.chkCurrentGameScoreBoard.BackColor = System.Drawing.Color.DarkRed;
            this.chkCurrentGameScoreBoard.FlatAppearance.BorderSize = 0;
            this.chkCurrentGameScoreBoard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkCurrentGameScoreBoard.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkCurrentGameScoreBoard.ForeColor = System.Drawing.Color.White;
            this.chkCurrentGameScoreBoard.Location = new System.Drawing.Point(407, 5);
            this.chkCurrentGameScoreBoard.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.chkCurrentGameScoreBoard.Name = "chkCurrentGameScoreBoard";
            this.chkCurrentGameScoreBoard.Size = new System.Drawing.Size(40, 34);
            this.chkCurrentGameScoreBoard.TabIndex = 5;
            this.chkCurrentGameScoreBoard.Text = "OFF";
            this.chkCurrentGameScoreBoard.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkCurrentGameScoreBoard.UseVisualStyleBackColor = false;
            this.chkCurrentGameScoreBoard.CheckedChanged += new System.EventHandler(this.chkGameScoreBoard_CheckedChanged);
            // 
            // lblGame
            // 
            this.lblGame.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblGame.AutoSize = true;
            this.lblGame.BackColor = System.Drawing.Color.Black;
            this.tlpPoints.SetColumnSpan(this.lblGame, 2);
            this.lblGame.Font = new System.Drawing.Font("Copperplate Gothic Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGame.ForeColor = System.Drawing.Color.White;
            this.lblGame.Location = new System.Drawing.Point(879, 0);
            this.lblGame.Margin = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.lblGame.Name = "lblGame";
            this.lblGame.Padding = new System.Windows.Forms.Padding(5);
            this.lblGame.Size = new System.Drawing.Size(114, 34);
            this.lblGame.TabIndex = 3;
            this.lblGame.Text = "Game";
            this.lblGame.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tlpScores
            // 
            this.tlpScores.AutoSize = true;
            this.tlpScores.BackColor = System.Drawing.Color.Black;
            this.tlpScores.ColumnCount = 1;
            this.tlpScores.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpScores.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpScores.Controls.Add(this.lblScores, 0, 0);
            this.tlpScores.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpScores.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.tlpScores.Location = new System.Drawing.Point(893, 5);
            this.tlpScores.Margin = new System.Windows.Forms.Padding(5, 5, 0, 5);
            this.tlpScores.Name = "tlpScores";
            this.tlpScores.RowCount = 2;
            this.tlpScores.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpScores.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpScores.Size = new System.Drawing.Size(105, 405);
            this.tlpScores.TabIndex = 2;
            // 
            // lblScores
            // 
            this.lblScores.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblScores.AutoSize = true;
            this.lblScores.BackColor = System.Drawing.Color.Black;
            this.lblScores.Font = new System.Drawing.Font("Copperplate Gothic Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScores.ForeColor = System.Drawing.Color.Gold;
            this.lblScores.Location = new System.Drawing.Point(0, 0);
            this.lblScores.Margin = new System.Windows.Forms.Padding(0);
            this.lblScores.Name = "lblScores";
            this.lblScores.Padding = new System.Windows.Forms.Padding(5);
            this.lblScores.Size = new System.Drawing.Size(105, 34);
            this.lblScores.TabIndex = 2;
            this.lblScores.Text = "Scores";
            this.lblScores.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tlpQuestions
            // 
            this.tlpQuestions.BackColor = System.Drawing.Color.White;
            this.tlpQuestions.ColumnCount = 3;
            this.tlpQuestions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpQuestions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tlpQuestions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpQuestions.Controls.Add(this.lblPreviousDetails, 0, 1);
            this.tlpQuestions.Controls.Add(this.btnPrevious, 0, 3);
            this.tlpQuestions.Controls.Add(this.lblQuestions, 0, 0);
            this.tlpQuestions.Controls.Add(this.btnNext, 2, 3);
            this.tlpQuestions.Controls.Add(this.lblPreviousQuestionStatement, 0, 2);
            this.tlpQuestions.Controls.Add(this.lblNextQuestionStatement, 2, 2);
            this.tlpQuestions.Controls.Add(this.tlpCurrentQuestion, 1, 1);
            this.tlpQuestions.Controls.Add(this.lblNextDetails, 2, 1);
            this.tlpQuestions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpQuestions.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.tlpQuestions.Location = new System.Drawing.Point(5, 10);
            this.tlpQuestions.Margin = new System.Windows.Forms.Padding(5, 10, 0, 5);
            this.tlpQuestions.Name = "tlpQuestions";
            this.tlpQuestions.RowCount = 4;
            this.tlpQuestions.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpQuestions.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpQuestions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpQuestions.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpQuestions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpQuestions.Size = new System.Drawing.Size(883, 400);
            this.tlpQuestions.TabIndex = 0;
            // 
            // lblPreviousDetails
            // 
            this.lblPreviousDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPreviousDetails.AutoSize = true;
            this.lblPreviousDetails.BackColor = System.Drawing.Color.Black;
            this.lblPreviousDetails.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPreviousDetails.ForeColor = System.Drawing.Color.White;
            this.lblPreviousDetails.Location = new System.Drawing.Point(5, 39);
            this.lblPreviousDetails.Margin = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.lblPreviousDetails.Name = "lblPreviousDetails";
            this.lblPreviousDetails.Padding = new System.Windows.Forms.Padding(5);
            this.lblPreviousDetails.Size = new System.Drawing.Size(171, 30);
            this.lblPreviousDetails.TabIndex = 9;
            this.lblPreviousDetails.Text = "Details";
            this.lblPreviousDetails.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnPrevious
            // 
            this.btnPrevious.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrevious.AutoSize = true;
            this.btnPrevious.BackColor = System.Drawing.Color.DarkGreen;
            this.btnPrevious.FlatAppearance.BorderSize = 0;
            this.btnPrevious.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrevious.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrevious.ForeColor = System.Drawing.Color.Gold;
            this.btnPrevious.Location = new System.Drawing.Point(5, 349);
            this.btnPrevious.Margin = new System.Windows.Forms.Padding(5, 0, 0, 5);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Padding = new System.Windows.Forms.Padding(5);
            this.btnPrevious.Size = new System.Drawing.Size(171, 46);
            this.btnPrevious.TabIndex = 7;
            this.btnPrevious.Text = "PREVIOUS";
            this.btnPrevious.UseVisualStyleBackColor = false;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // lblQuestions
            // 
            this.lblQuestions.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblQuestions.AutoSize = true;
            this.lblQuestions.BackColor = System.Drawing.Color.Black;
            this.tlpQuestions.SetColumnSpan(this.lblQuestions, 3);
            this.lblQuestions.Font = new System.Drawing.Font("Copperplate Gothic Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestions.ForeColor = System.Drawing.Color.Gold;
            this.lblQuestions.Location = new System.Drawing.Point(5, 5);
            this.lblQuestions.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblQuestions.Name = "lblQuestions";
            this.lblQuestions.Padding = new System.Windows.Forms.Padding(5);
            this.lblQuestions.Size = new System.Drawing.Size(873, 34);
            this.lblQuestions.TabIndex = 3;
            this.lblQuestions.Text = "Questions";
            this.lblQuestions.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnNext
            // 
            this.btnNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNext.AutoSize = true;
            this.btnNext.BackColor = System.Drawing.Color.DarkGreen;
            this.btnNext.FlatAppearance.BorderSize = 0;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.ForeColor = System.Drawing.Color.Gold;
            this.btnNext.Location = new System.Drawing.Point(705, 349);
            this.btnNext.Margin = new System.Windows.Forms.Padding(0, 0, 5, 5);
            this.btnNext.Name = "btnNext";
            this.btnNext.Padding = new System.Windows.Forms.Padding(5);
            this.btnNext.Size = new System.Drawing.Size(173, 46);
            this.btnNext.TabIndex = 8;
            this.btnNext.Text = "NEXT";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // lblPreviousQuestionStatement
            // 
            this.lblPreviousQuestionStatement.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPreviousQuestionStatement.AutoSize = true;
            this.lblPreviousQuestionStatement.BackColor = System.Drawing.Color.Gray;
            this.lblPreviousQuestionStatement.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPreviousQuestionStatement.ForeColor = System.Drawing.Color.Black;
            this.lblPreviousQuestionStatement.Location = new System.Drawing.Point(5, 69);
            this.lblPreviousQuestionStatement.Margin = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.lblPreviousQuestionStatement.Name = "lblPreviousQuestionStatement";
            this.lblPreviousQuestionStatement.Padding = new System.Windows.Forms.Padding(5);
            this.lblPreviousQuestionStatement.Size = new System.Drawing.Size(171, 280);
            this.lblPreviousQuestionStatement.TabIndex = 12;
            this.lblPreviousQuestionStatement.Text = "Question";
            this.lblPreviousQuestionStatement.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNextQuestionStatement
            // 
            this.lblNextQuestionStatement.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNextQuestionStatement.AutoSize = true;
            this.lblNextQuestionStatement.BackColor = System.Drawing.Color.Gray;
            this.lblNextQuestionStatement.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNextQuestionStatement.ForeColor = System.Drawing.Color.Black;
            this.lblNextQuestionStatement.Location = new System.Drawing.Point(705, 69);
            this.lblNextQuestionStatement.Margin = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.lblNextQuestionStatement.Name = "lblNextQuestionStatement";
            this.lblNextQuestionStatement.Padding = new System.Windows.Forms.Padding(5);
            this.lblNextQuestionStatement.Size = new System.Drawing.Size(173, 280);
            this.lblNextQuestionStatement.TabIndex = 13;
            this.lblNextQuestionStatement.Text = "Question";
            this.lblNextQuestionStatement.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tlpCurrentQuestion
            // 
            this.tlpCurrentQuestion.BackColor = System.Drawing.Color.Black;
            this.tlpCurrentQuestion.ColumnCount = 6;
            this.tlpCurrentQuestion.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tlpCurrentQuestion.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpCurrentQuestion.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpCurrentQuestion.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpCurrentQuestion.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpCurrentQuestion.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpCurrentQuestion.Controls.Add(this.lblCurrentQuestionStatement, 0, 2);
            this.tlpCurrentQuestion.Controls.Add(this.lblCurrentSequence, 0, 1);
            this.tlpCurrentQuestion.Controls.Add(this.lblCurrentDifficulty, 1, 1);
            this.tlpCurrentQuestion.Controls.Add(this.lblCurrentPoints, 3, 1);
            this.tlpCurrentQuestion.Controls.Add(this.lblQuestionBox, 0, 0);
            this.tlpCurrentQuestion.Controls.Add(this.chkQuestionBox, 1, 0);
            this.tlpCurrentQuestion.Controls.Add(this.lblShowChoices, 2, 0);
            this.tlpCurrentQuestion.Controls.Add(this.chkShowChoices, 3, 0);
            this.tlpCurrentQuestion.Controls.Add(this.lblAnswer, 4, 0);
            this.tlpCurrentQuestion.Controls.Add(this.chkRevealAnswer, 5, 0);
            this.tlpCurrentQuestion.Controls.Add(this.lblChoices, 0, 3);
            this.tlpCurrentQuestion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpCurrentQuestion.Location = new System.Drawing.Point(176, 39);
            this.tlpCurrentQuestion.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.tlpCurrentQuestion.Name = "tlpCurrentQuestion";
            this.tlpCurrentQuestion.RowCount = 5;
            this.tlpQuestions.SetRowSpan(this.tlpCurrentQuestion, 3);
            this.tlpCurrentQuestion.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpCurrentQuestion.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpCurrentQuestion.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpCurrentQuestion.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpCurrentQuestion.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpCurrentQuestion.Size = new System.Drawing.Size(529, 356);
            this.tlpCurrentQuestion.TabIndex = 14;
            // 
            // lblCurrentQuestionStatement
            // 
            this.lblCurrentQuestionStatement.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCurrentQuestionStatement.AutoSize = true;
            this.lblCurrentQuestionStatement.BackColor = System.Drawing.Color.White;
            this.tlpCurrentQuestion.SetColumnSpan(this.lblCurrentQuestionStatement, 6);
            this.lblCurrentQuestionStatement.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentQuestionStatement.ForeColor = System.Drawing.Color.Black;
            this.lblCurrentQuestionStatement.Location = new System.Drawing.Point(5, 80);
            this.lblCurrentQuestionStatement.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblCurrentQuestionStatement.Name = "lblCurrentQuestionStatement";
            this.lblCurrentQuestionStatement.Padding = new System.Windows.Forms.Padding(5);
            this.lblCurrentQuestionStatement.Size = new System.Drawing.Size(519, 243);
            this.lblCurrentQuestionStatement.TabIndex = 13;
            this.lblCurrentQuestionStatement.Text = "Question";
            this.lblCurrentQuestionStatement.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCurrentSequence
            // 
            this.lblCurrentSequence.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCurrentSequence.AutoSize = true;
            this.lblCurrentSequence.BackColor = System.Drawing.Color.Black;
            this.lblCurrentSequence.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentSequence.ForeColor = System.Drawing.Color.White;
            this.lblCurrentSequence.Location = new System.Drawing.Point(5, 45);
            this.lblCurrentSequence.Margin = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.lblCurrentSequence.Name = "lblCurrentSequence";
            this.lblCurrentSequence.Padding = new System.Windows.Forms.Padding(5);
            this.lblCurrentSequence.Size = new System.Drawing.Size(120, 35);
            this.lblCurrentSequence.TabIndex = 10;
            this.lblCurrentSequence.Text = "Sequence";
            this.lblCurrentSequence.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCurrentDifficulty
            // 
            this.lblCurrentDifficulty.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCurrentDifficulty.AutoSize = true;
            this.lblCurrentDifficulty.BackColor = System.Drawing.Color.Black;
            this.tlpCurrentQuestion.SetColumnSpan(this.lblCurrentDifficulty, 2);
            this.lblCurrentDifficulty.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentDifficulty.ForeColor = System.Drawing.Color.White;
            this.lblCurrentDifficulty.Location = new System.Drawing.Point(125, 45);
            this.lblCurrentDifficulty.Margin = new System.Windows.Forms.Padding(0);
            this.lblCurrentDifficulty.Name = "lblCurrentDifficulty";
            this.lblCurrentDifficulty.Padding = new System.Windows.Forms.Padding(5);
            this.lblCurrentDifficulty.Size = new System.Drawing.Size(174, 35);
            this.lblCurrentDifficulty.TabIndex = 11;
            this.lblCurrentDifficulty.Text = "Difficulty";
            this.lblCurrentDifficulty.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCurrentPoints
            // 
            this.lblCurrentPoints.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCurrentPoints.AutoSize = true;
            this.lblCurrentPoints.BackColor = System.Drawing.Color.Black;
            this.tlpCurrentQuestion.SetColumnSpan(this.lblCurrentPoints, 3);
            this.lblCurrentPoints.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentPoints.ForeColor = System.Drawing.Color.White;
            this.lblCurrentPoints.Location = new System.Drawing.Point(299, 45);
            this.lblCurrentPoints.Margin = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.lblCurrentPoints.Name = "lblCurrentPoints";
            this.lblCurrentPoints.Padding = new System.Windows.Forms.Padding(5);
            this.lblCurrentPoints.Size = new System.Drawing.Size(225, 35);
            this.lblCurrentPoints.TabIndex = 19;
            this.lblCurrentPoints.Text = "Points";
            this.lblCurrentPoints.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblQuestionBox
            // 
            this.lblQuestionBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblQuestionBox.AutoSize = true;
            this.lblQuestionBox.BackColor = System.Drawing.Color.White;
            this.lblQuestionBox.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestionBox.ForeColor = System.Drawing.Color.Black;
            this.lblQuestionBox.Location = new System.Drawing.Point(5, 5);
            this.lblQuestionBox.Margin = new System.Windows.Forms.Padding(5, 5, 0, 5);
            this.lblQuestionBox.Name = "lblQuestionBox";
            this.lblQuestionBox.Padding = new System.Windows.Forms.Padding(5);
            this.lblQuestionBox.Size = new System.Drawing.Size(120, 35);
            this.lblQuestionBox.TabIndex = 20;
            this.lblQuestionBox.Text = "Question Box";
            this.lblQuestionBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // chkQuestionBox
            // 
            this.chkQuestionBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chkQuestionBox.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkQuestionBox.AutoSize = true;
            this.chkQuestionBox.BackColor = System.Drawing.Color.DarkRed;
            this.chkQuestionBox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.chkQuestionBox.FlatAppearance.BorderSize = 0;
            this.chkQuestionBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkQuestionBox.Font = new System.Drawing.Font("Impact", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkQuestionBox.ForeColor = System.Drawing.Color.White;
            this.chkQuestionBox.Location = new System.Drawing.Point(125, 5);
            this.chkQuestionBox.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.chkQuestionBox.Name = "chkQuestionBox";
            this.chkQuestionBox.Size = new System.Drawing.Size(49, 35);
            this.chkQuestionBox.TabIndex = 16;
            this.chkQuestionBox.Text = "OFF";
            this.chkQuestionBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkQuestionBox.UseVisualStyleBackColor = false;
            this.chkQuestionBox.CheckedChanged += new System.EventHandler(this.chkQuestionBox_CheckedChanged);
            // 
            // lblShowChoices
            // 
            this.lblShowChoices.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblShowChoices.AutoSize = true;
            this.lblShowChoices.BackColor = System.Drawing.Color.White;
            this.lblShowChoices.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShowChoices.ForeColor = System.Drawing.Color.Black;
            this.lblShowChoices.Location = new System.Drawing.Point(174, 5);
            this.lblShowChoices.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.lblShowChoices.Name = "lblShowChoices";
            this.lblShowChoices.Padding = new System.Windows.Forms.Padding(5);
            this.lblShowChoices.Size = new System.Drawing.Size(125, 35);
            this.lblShowChoices.TabIndex = 21;
            this.lblShowChoices.Text = "Choices";
            this.lblShowChoices.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // chkShowChoices
            // 
            this.chkShowChoices.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chkShowChoices.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkShowChoices.AutoSize = true;
            this.chkShowChoices.BackColor = System.Drawing.Color.DarkRed;
            this.chkShowChoices.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.chkShowChoices.Enabled = false;
            this.chkShowChoices.FlatAppearance.BorderSize = 0;
            this.chkShowChoices.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkShowChoices.Font = new System.Drawing.Font("Impact", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkShowChoices.ForeColor = System.Drawing.Color.White;
            this.chkShowChoices.Location = new System.Drawing.Point(299, 5);
            this.chkShowChoices.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.chkShowChoices.Name = "chkShowChoices";
            this.chkShowChoices.Size = new System.Drawing.Size(49, 35);
            this.chkShowChoices.TabIndex = 22;
            this.chkShowChoices.Text = "OFF";
            this.chkShowChoices.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkShowChoices.UseVisualStyleBackColor = false;
            this.chkShowChoices.CheckedChanged += new System.EventHandler(this.chkShowChoices_CheckedChanged);
            // 
            // lblAnswer
            // 
            this.lblAnswer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAnswer.AutoSize = true;
            this.lblAnswer.BackColor = System.Drawing.Color.White;
            this.lblAnswer.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnswer.ForeColor = System.Drawing.Color.Black;
            this.lblAnswer.Location = new System.Drawing.Point(348, 5);
            this.lblAnswer.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.lblAnswer.Name = "lblAnswer";
            this.lblAnswer.Padding = new System.Windows.Forms.Padding(5);
            this.lblAnswer.Size = new System.Drawing.Size(125, 35);
            this.lblAnswer.TabIndex = 23;
            this.lblAnswer.Text = "Answer";
            this.lblAnswer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // chkRevealAnswer
            // 
            this.chkRevealAnswer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chkRevealAnswer.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkRevealAnswer.AutoSize = true;
            this.chkRevealAnswer.BackColor = System.Drawing.Color.DarkRed;
            this.chkRevealAnswer.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.chkRevealAnswer.Enabled = false;
            this.chkRevealAnswer.FlatAppearance.BorderSize = 0;
            this.chkRevealAnswer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkRevealAnswer.Font = new System.Drawing.Font("Impact", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkRevealAnswer.ForeColor = System.Drawing.Color.White;
            this.chkRevealAnswer.Location = new System.Drawing.Point(473, 5);
            this.chkRevealAnswer.Margin = new System.Windows.Forms.Padding(0, 5, 5, 5);
            this.chkRevealAnswer.Name = "chkRevealAnswer";
            this.chkRevealAnswer.Size = new System.Drawing.Size(51, 35);
            this.chkRevealAnswer.TabIndex = 17;
            this.chkRevealAnswer.Text = "OFF";
            this.chkRevealAnswer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkRevealAnswer.UseVisualStyleBackColor = false;
            this.chkRevealAnswer.CheckedChanged += new System.EventHandler(this.chkRevealAnswer_CheckedChanged);
            // 
            // lblChoices
            // 
            this.lblChoices.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblChoices.AutoSize = true;
            this.lblChoices.BackColor = System.Drawing.Color.Black;
            this.tlpCurrentQuestion.SetColumnSpan(this.lblChoices, 6);
            this.lblChoices.Font = new System.Drawing.Font("Copperplate Gothic Bold", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChoices.ForeColor = System.Drawing.Color.Gold;
            this.lblChoices.Location = new System.Drawing.Point(5, 323);
            this.lblChoices.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblChoices.Name = "lblChoices";
            this.lblChoices.Padding = new System.Windows.Forms.Padding(5);
            this.lblChoices.Size = new System.Drawing.Size(519, 33);
            this.lblChoices.TabIndex = 14;
            this.lblChoices.Text = "Choices && Answer";
            this.lblChoices.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNextDetails
            // 
            this.lblNextDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNextDetails.AutoSize = true;
            this.lblNextDetails.BackColor = System.Drawing.Color.Black;
            this.lblNextDetails.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNextDetails.ForeColor = System.Drawing.Color.White;
            this.lblNextDetails.Location = new System.Drawing.Point(705, 39);
            this.lblNextDetails.Margin = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.lblNextDetails.Name = "lblNextDetails";
            this.lblNextDetails.Padding = new System.Windows.Forms.Padding(5);
            this.lblNextDetails.Size = new System.Drawing.Size(173, 30);
            this.lblNextDetails.TabIndex = 11;
            this.lblNextDetails.Text = "Details";
            this.lblNextDetails.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tlpPoints
            // 
            this.tlpPoints.AutoSize = true;
            this.tlpPoints.BackColor = System.Drawing.Color.Black;
            this.tlpPoints.ColumnCount = 3;
            this.tlpMain.SetColumnSpan(this.tlpPoints, 2);
            this.tlpPoints.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpPoints.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpPoints.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpPoints.Controls.Add(this.lblPointsTo, 0, 0);
            this.tlpPoints.Controls.Add(this.btnPointsSave, 2, 1);
            this.tlpPoints.Controls.Add(this.lblGame, 1, 0);
            this.tlpPoints.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpPoints.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.tlpPoints.Location = new System.Drawing.Point(0, 415);
            this.tlpPoints.Margin = new System.Windows.Forms.Padding(0);
            this.tlpPoints.Name = "tlpPoints";
            this.tlpPoints.RowCount = 2;
            this.tlpPoints.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpPoints.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpPoints.Size = new System.Drawing.Size(998, 100);
            this.tlpPoints.TabIndex = 1;
            // 
            // lblPointsTo
            // 
            this.lblPointsTo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPointsTo.AutoSize = true;
            this.lblPointsTo.BackColor = System.Drawing.Color.Black;
            this.lblPointsTo.Font = new System.Drawing.Font("Copperplate Gothic Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPointsTo.ForeColor = System.Drawing.Color.Gold;
            this.lblPointsTo.Location = new System.Drawing.Point(10, 0);
            this.lblPointsTo.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.lblPointsTo.Name = "lblPointsTo";
            this.lblPointsTo.Padding = new System.Windows.Forms.Padding(5);
            this.lblPointsTo.Size = new System.Drawing.Size(869, 34);
            this.lblPointsTo.TabIndex = 2;
            this.lblPointsTo.Text = "Points to";
            this.lblPointsTo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnPointsSave
            // 
            this.btnPointsSave.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPointsSave.AutoSize = true;
            this.btnPointsSave.BackColor = System.Drawing.Color.DarkGreen;
            this.btnPointsSave.FlatAppearance.BorderSize = 0;
            this.btnPointsSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPointsSave.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPointsSave.ForeColor = System.Drawing.Color.Gold;
            this.btnPointsSave.Image = global::BibleQuiz.Properties.Resources.save;
            this.btnPointsSave.Location = new System.Drawing.Point(879, 39);
            this.btnPointsSave.Margin = new System.Windows.Forms.Padding(0, 5, 5, 5);
            this.btnPointsSave.Name = "btnPointsSave";
            this.btnPointsSave.Padding = new System.Windows.Forms.Padding(15, 0, 15, 0);
            this.btnPointsSave.Size = new System.Drawing.Size(114, 56);
            this.btnPointsSave.TabIndex = 1;
            this.btnPointsSave.Text = "SAVE";
            this.btnPointsSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPointsSave.UseVisualStyleBackColor = false;
            this.btnPointsSave.Click += new System.EventHandler(this.btnPointsSave_Click);
            // 
            // tlpMain
            // 
            this.tlpMain.AutoSize = true;
            this.tlpMain.BackColor = System.Drawing.Color.Transparent;
            this.tlpMain.ColumnCount = 2;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpMain.Controls.Add(this.tlpScores, 1, 0);
            this.tlpMain.Controls.Add(this.tlpPoints, 0, 1);
            this.tlpMain.Controls.Add(this.tlpQuestions, 0, 0);
            this.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMain.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.tlpMain.Location = new System.Drawing.Point(5, 44);
            this.tlpMain.Margin = new System.Windows.Forms.Padding(0);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.RowCount = 2;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpMain.Size = new System.Drawing.Size(998, 515);
            this.tlpMain.TabIndex = 4;
            // 
            // frmControls
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1008, 564);
            this.Controls.Add(this.tlpMain);
            this.Controls.Add(this.tlpHeader);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = global::BibleQuiz.Properties.Resources.logo;
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.MinimizeBox = false;
            this.Name = "frmControls";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bible Quiz Game Controller";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmControls_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmControls_FormClosed);
            this.Load += new System.EventHandler(this.frmControls_Load);
            this.tlpHeader.ResumeLayout(false);
            this.tlpHeader.PerformLayout();
            this.tlpScores.ResumeLayout(false);
            this.tlpScores.PerformLayout();
            this.tlpQuestions.ResumeLayout(false);
            this.tlpQuestions.PerformLayout();
            this.tlpCurrentQuestion.ResumeLayout(false);
            this.tlpCurrentQuestion.PerformLayout();
            this.tlpPoints.ResumeLayout(false);
            this.tlpPoints.PerformLayout();
            this.tlpMain.ResumeLayout(false);
            this.tlpMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpHeader;
        private System.Windows.Forms.TableLayoutPanel tlpQuestions;
        private System.Windows.Forms.Label lblScoreBoard;
        private System.Windows.Forms.Label lblTotalScore;
        private System.Windows.Forms.TableLayoutPanel tlpScores;
        private System.Windows.Forms.Label lblScores;
        private System.Windows.Forms.Label lblQuestions;
        private System.Windows.Forms.Label lblPreviousDetails;
        private System.Windows.Forms.Label lblNextDetails;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Label lblPreviousQuestionStatement;
        private System.Windows.Forms.Label lblNextQuestionStatement;
        internal System.Windows.Forms.CheckBox chkCurrentGameScoreBoard;
        internal System.Windows.Forms.CheckBox chkTotalScoreBoard;
        private System.Windows.Forms.TableLayoutPanel tlpPoints;
        private System.Windows.Forms.TableLayoutPanel tlpMain;
        private System.Windows.Forms.Label lblPointsTo;
        internal System.Windows.Forms.Button btnPointsSave;
        private System.Windows.Forms.Label lblGameQuestionSequence;
        private System.Windows.Forms.Label lblGame;
        private System.Windows.Forms.TableLayoutPanel tlpCurrentQuestion;
        private System.Windows.Forms.Label lblCurrentSequence;
        private System.Windows.Forms.Label lblCurrentQuestionStatement;
        private System.Windows.Forms.Label lblCurrentDifficulty;
        private System.Windows.Forms.Label lblChoices;
        private System.Windows.Forms.Label lblCurrentPoints;
        private System.Windows.Forms.Label lblQuestionBox;
        internal System.Windows.Forms.CheckBox chkQuestionBox;
        private System.Windows.Forms.Label lblShowChoices;
        internal System.Windows.Forms.CheckBox chkRevealAnswer;
        internal System.Windows.Forms.CheckBox chkShowChoices;
        private System.Windows.Forms.Label lblAnswer;
        internal System.Windows.Forms.CheckBox chkGroupAnswers;
        private System.Windows.Forms.Label lblGroupAnswers;

    }
}
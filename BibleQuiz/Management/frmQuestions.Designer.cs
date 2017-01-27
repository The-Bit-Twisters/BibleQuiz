namespace BibleQuiz.Management
{
    partial class frmQuestions
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tlpMain = new System.Windows.Forms.TableLayoutPanel();
            this.tlpData = new System.Windows.Forms.TableLayoutPanel();
            this.txtBibleReference = new System.Windows.Forms.TextBox();
            this.lblBibleReference = new System.Windows.Forms.Label();
            this.lblPassOrPlay = new System.Windows.Forms.Label();
            this.lblSequence = new System.Windows.Forms.Label();
            this.txtSequence = new System.Windows.Forms.TextBox();
            this.lblQuestion = new System.Windows.Forms.Label();
            this.cbxLevels = new System.Windows.Forms.ComboBox();
            this.txtQuestionStatement = new System.Windows.Forms.TextBox();
            this.lblDifficulty = new System.Windows.Forms.Label();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnPreview = new System.Windows.Forms.Button();
            this.chkPassOrPlay = new System.Windows.Forms.CheckBox();
            this.lblAnswerChoices = new System.Windows.Forms.Label();
            this.cbxChoicesTypes = new System.Windows.Forms.ComboBox();
            this.lblQuestionType = new System.Windows.Forms.Label();
            this.tlpChoicesOrAnswer = new System.Windows.Forms.TableLayoutPanel();
            this.tlpChoices = new System.Windows.Forms.TableLayoutPanel();
            this.tlpIdentification = new System.Windows.Forms.TableLayoutPanel();
            this.txtIdentification = new System.Windows.Forms.TextBox();
            this.tlpTrueOrFalse = new System.Windows.Forms.TableLayoutPanel();
            this.rdoTrue = new System.Windows.Forms.RadioButton();
            this.rdoFalse = new System.Windows.Forms.RadioButton();
            this.tlpMultipleChoice = new System.Windows.Forms.TableLayoutPanel();
            this.tlp4Choices = new System.Windows.Forms.TableLayoutPanel();
            this.rdoMultipleChoiceD = new System.Windows.Forms.RadioButton();
            this.txtMultipleChoiceA = new System.Windows.Forms.TextBox();
            this.txtMultipleChoiceD = new System.Windows.Forms.TextBox();
            this.rdoMultipleChoiceB = new System.Windows.Forms.RadioButton();
            this.rdoMultipleChoiceC = new System.Windows.Forms.RadioButton();
            this.rdoMultipleChoiceA = new System.Windows.Forms.RadioButton();
            this.txtMultipleChoiceB = new System.Windows.Forms.TextBox();
            this.txtMultipleChoiceC = new System.Windows.Forms.TextBox();
            this.tlpLayout = new System.Windows.Forms.TableLayoutPanel();
            this.rdoLayout4x1 = new System.Windows.Forms.RadioButton();
            this.lblLayout = new System.Windows.Forms.Label();
            this.rdoLayout2x2 = new System.Windows.Forms.RadioButton();
            this.rdoLayout1x4 = new System.Windows.Forms.RadioButton();
            this.tlpList = new System.Windows.Forms.TableLayoutPanel();
            this.lblGame = new System.Windows.Forms.Label();
            this.dgvQuestions = new System.Windows.Forms.DataGridView();
            this.colQuestionID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQuestionSequence = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQuestionStatement = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQuestionLevel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSelectGame = new System.Windows.Forms.Button();
            this.tlpMain.SuspendLayout();
            this.tlpData.SuspendLayout();
            this.tlpChoicesOrAnswer.SuspendLayout();
            this.tlpChoices.SuspendLayout();
            this.tlpIdentification.SuspendLayout();
            this.tlpTrueOrFalse.SuspendLayout();
            this.tlpMultipleChoice.SuspendLayout();
            this.tlp4Choices.SuspendLayout();
            this.tlpLayout.SuspendLayout();
            this.tlpList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuestions)).BeginInit();
            this.SuspendLayout();
            // 
            // tlpMain
            // 
            this.tlpMain.BackColor = System.Drawing.Color.Transparent;
            this.tlpMain.ColumnCount = 2;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.tlpMain.Controls.Add(this.tlpData, 1, 0);
            this.tlpMain.Controls.Add(this.tlpList, 0, 0);
            this.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMain.Location = new System.Drawing.Point(5, 5);
            this.tlpMain.Margin = new System.Windows.Forms.Padding(0);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.RowCount = 1;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.Size = new System.Drawing.Size(694, 511);
            this.tlpMain.TabIndex = 0;
            // 
            // tlpData
            // 
            this.tlpData.BackColor = System.Drawing.Color.Gold;
            this.tlpData.ColumnCount = 6;
            this.tlpData.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpData.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpData.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tlpData.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpData.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tlpData.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpData.Controls.Add(this.txtBibleReference, 3, 3);
            this.tlpData.Controls.Add(this.lblBibleReference, 0, 3);
            this.tlpData.Controls.Add(this.lblPassOrPlay, 4, 0);
            this.tlpData.Controls.Add(this.lblSequence, 0, 0);
            this.tlpData.Controls.Add(this.txtSequence, 1, 0);
            this.tlpData.Controls.Add(this.lblQuestion, 0, 1);
            this.tlpData.Controls.Add(this.cbxLevels, 3, 0);
            this.tlpData.Controls.Add(this.txtQuestionStatement, 0, 2);
            this.tlpData.Controls.Add(this.lblDifficulty, 2, 0);
            this.tlpData.Controls.Add(this.btnNew, 0, 7);
            this.tlpData.Controls.Add(this.btnSave, 4, 7);
            this.tlpData.Controls.Add(this.btnPreview, 3, 7);
            this.tlpData.Controls.Add(this.chkPassOrPlay, 5, 0);
            this.tlpData.Controls.Add(this.lblAnswerChoices, 0, 5);
            this.tlpData.Controls.Add(this.cbxChoicesTypes, 3, 4);
            this.tlpData.Controls.Add(this.lblQuestionType, 0, 4);
            this.tlpData.Controls.Add(this.tlpChoicesOrAnswer, 0, 6);
            this.tlpData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpData.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.tlpData.Location = new System.Drawing.Point(247, 0);
            this.tlpData.Margin = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.tlpData.Name = "tlpData";
            this.tlpData.RowCount = 8;
            this.tlpData.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpData.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpData.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpData.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpData.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpData.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpData.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpData.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpData.Size = new System.Drawing.Size(447, 511);
            this.tlpData.TabIndex = 2;
            // 
            // txtBibleReference
            // 
            this.txtBibleReference.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBibleReference.BackColor = System.Drawing.Color.White;
            this.txtBibleReference.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tlpData.SetColumnSpan(this.txtBibleReference, 3);
            this.txtBibleReference.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBibleReference.ForeColor = System.Drawing.Color.Black;
            this.txtBibleReference.Location = new System.Drawing.Point(211, 174);
            this.txtBibleReference.Margin = new System.Windows.Forms.Padding(0, 5, 5, 0);
            this.txtBibleReference.Name = "txtBibleReference";
            this.txtBibleReference.Size = new System.Drawing.Size(231, 26);
            this.txtBibleReference.TabIndex = 34;
            // 
            // lblBibleReference
            // 
            this.lblBibleReference.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBibleReference.AutoSize = true;
            this.lblBibleReference.BackColor = System.Drawing.Color.Black;
            this.tlpData.SetColumnSpan(this.lblBibleReference, 3);
            this.lblBibleReference.Font = new System.Drawing.Font("Copperplate Gothic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBibleReference.ForeColor = System.Drawing.Color.Gold;
            this.lblBibleReference.Location = new System.Drawing.Point(5, 173);
            this.lblBibleReference.Margin = new System.Windows.Forms.Padding(5, 5, 0, 0);
            this.lblBibleReference.Name = "lblBibleReference";
            this.lblBibleReference.Padding = new System.Windows.Forms.Padding(5);
            this.lblBibleReference.Size = new System.Drawing.Size(206, 28);
            this.lblBibleReference.TabIndex = 33;
            this.lblBibleReference.Text = "Bible Reference";
            this.lblBibleReference.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPassOrPlay
            // 
            this.lblPassOrPlay.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPassOrPlay.AutoSize = true;
            this.lblPassOrPlay.BackColor = System.Drawing.Color.Black;
            this.lblPassOrPlay.Font = new System.Drawing.Font("Copperplate Gothic Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassOrPlay.ForeColor = System.Drawing.Color.Gold;
            this.lblPassOrPlay.Location = new System.Drawing.Point(328, 5);
            this.lblPassOrPlay.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.lblPassOrPlay.Name = "lblPassOrPlay";
            this.lblPassOrPlay.Size = new System.Drawing.Size(63, 30);
            this.lblPassOrPlay.TabIndex = 29;
            this.lblPassOrPlay.Text = "Pass or Play";
            this.lblPassOrPlay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSequence
            // 
            this.lblSequence.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSequence.AutoSize = true;
            this.lblSequence.BackColor = System.Drawing.Color.Black;
            this.lblSequence.Font = new System.Drawing.Font("Copperplate Gothic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSequence.ForeColor = System.Drawing.Color.Gold;
            this.lblSequence.Location = new System.Drawing.Point(5, 5);
            this.lblSequence.Margin = new System.Windows.Forms.Padding(5, 5, 0, 0);
            this.lblSequence.Name = "lblSequence";
            this.lblSequence.Size = new System.Drawing.Size(69, 30);
            this.lblSequence.TabIndex = 14;
            this.lblSequence.Text = "No.";
            this.lblSequence.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSequence
            // 
            this.txtSequence.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtSequence.BackColor = System.Drawing.Color.White;
            this.txtSequence.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSequence.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSequence.ForeColor = System.Drawing.Color.Black;
            this.txtSequence.Location = new System.Drawing.Point(74, 7);
            this.txtSequence.Margin = new System.Windows.Forms.Padding(0, 5, 5, 0);
            this.txtSequence.Name = "txtSequence";
            this.txtSequence.ReadOnly = true;
            this.txtSequence.Size = new System.Drawing.Size(57, 26);
            this.txtSequence.TabIndex = 15;
            this.txtSequence.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblQuestion
            // 
            this.lblQuestion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblQuestion.AutoSize = true;
            this.lblQuestion.BackColor = System.Drawing.Color.Black;
            this.tlpData.SetColumnSpan(this.lblQuestion, 6);
            this.lblQuestion.Font = new System.Drawing.Font("Copperplate Gothic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestion.ForeColor = System.Drawing.Color.Gold;
            this.lblQuestion.Location = new System.Drawing.Point(5, 40);
            this.lblQuestion.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Padding = new System.Windows.Forms.Padding(5);
            this.lblQuestion.Size = new System.Drawing.Size(437, 28);
            this.lblQuestion.TabIndex = 17;
            this.lblQuestion.Text = "Question";
            this.lblQuestion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbxLevels
            // 
            this.cbxLevels.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxLevels.BackColor = System.Drawing.Color.White;
            this.cbxLevels.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxLevels.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbxLevels.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxLevels.ForeColor = System.Drawing.Color.Black;
            this.cbxLevels.ItemHeight = 20;
            this.cbxLevels.Location = new System.Drawing.Point(211, 5);
            this.cbxLevels.Margin = new System.Windows.Forms.Padding(0, 5, 5, 0);
            this.cbxLevels.Name = "cbxLevels";
            this.cbxLevels.Size = new System.Drawing.Size(100, 28);
            this.cbxLevels.TabIndex = 13;
            // 
            // txtQuestionStatement
            // 
            this.txtQuestionStatement.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtQuestionStatement.BackColor = System.Drawing.Color.White;
            this.txtQuestionStatement.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tlpData.SetColumnSpan(this.txtQuestionStatement, 6);
            this.txtQuestionStatement.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuestionStatement.ForeColor = System.Drawing.Color.Black;
            this.txtQuestionStatement.Location = new System.Drawing.Point(5, 68);
            this.txtQuestionStatement.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.txtQuestionStatement.MinimumSize = new System.Drawing.Size(2, 100);
            this.txtQuestionStatement.Multiline = true;
            this.txtQuestionStatement.Name = "txtQuestionStatement";
            this.txtQuestionStatement.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtQuestionStatement.Size = new System.Drawing.Size(437, 100);
            this.txtQuestionStatement.TabIndex = 19;
            // 
            // lblDifficulty
            // 
            this.lblDifficulty.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDifficulty.AutoSize = true;
            this.lblDifficulty.BackColor = System.Drawing.Color.Black;
            this.lblDifficulty.Font = new System.Drawing.Font("Copperplate Gothic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDifficulty.ForeColor = System.Drawing.Color.Gold;
            this.lblDifficulty.Location = new System.Drawing.Point(153, 5);
            this.lblDifficulty.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.lblDifficulty.Name = "lblDifficulty";
            this.lblDifficulty.Size = new System.Drawing.Size(58, 30);
            this.lblDifficulty.TabIndex = 16;
            this.lblDifficulty.Text = "Level";
            this.lblDifficulty.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnNew
            // 
            this.btnNew.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnNew.AutoSize = true;
            this.btnNew.BackColor = System.Drawing.Color.DarkGreen;
            this.btnNew.FlatAppearance.BorderSize = 0;
            this.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNew.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.ForeColor = System.Drawing.Color.Gold;
            this.btnNew.Location = new System.Drawing.Point(5, 476);
            this.btnNew.Margin = new System.Windows.Forms.Padding(5);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(46, 30);
            this.btnNew.TabIndex = 0;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = false;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnSave.AutoSize = true;
            this.btnSave.BackColor = System.Drawing.Color.DarkGreen;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.Gold;
            this.btnSave.Location = new System.Drawing.Point(338, 476);
            this.btnSave.Margin = new System.Windows.Forms.Padding(5);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(48, 30);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "SAVE";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnPreview
            // 
            this.btnPreview.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnPreview.AutoSize = true;
            this.btnPreview.BackColor = System.Drawing.Color.DarkGreen;
            this.btnPreview.FlatAppearance.BorderSize = 0;
            this.btnPreview.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPreview.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPreview.ForeColor = System.Drawing.Color.Gold;
            this.btnPreview.Location = new System.Drawing.Point(240, 476);
            this.btnPreview.Margin = new System.Windows.Forms.Padding(5);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(71, 30);
            this.btnPreview.TabIndex = 28;
            this.btnPreview.Text = "Preview";
            this.btnPreview.UseVisualStyleBackColor = false;
            this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
            // 
            // chkPassOrPlay
            // 
            this.chkPassOrPlay.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.chkPassOrPlay.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkPassOrPlay.AutoSize = true;
            this.chkPassOrPlay.BackColor = System.Drawing.Color.DarkRed;
            this.chkPassOrPlay.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.chkPassOrPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkPassOrPlay.ForeColor = System.Drawing.Color.White;
            this.chkPassOrPlay.Location = new System.Drawing.Point(391, 5);
            this.chkPassOrPlay.Margin = new System.Windows.Forms.Padding(0, 5, 5, 0);
            this.chkPassOrPlay.MinimumSize = new System.Drawing.Size(50, 0);
            this.chkPassOrPlay.Name = "chkPassOrPlay";
            this.chkPassOrPlay.Size = new System.Drawing.Size(50, 30);
            this.chkPassOrPlay.TabIndex = 31;
            this.chkPassOrPlay.Text = "No";
            this.chkPassOrPlay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkPassOrPlay.UseVisualStyleBackColor = false;
            this.chkPassOrPlay.CheckedChanged += new System.EventHandler(this.chkPassOrPlay_CheckedChanged);
            // 
            // lblAnswerChoices
            // 
            this.lblAnswerChoices.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAnswerChoices.AutoSize = true;
            this.lblAnswerChoices.BackColor = System.Drawing.Color.Black;
            this.tlpData.SetColumnSpan(this.lblAnswerChoices, 6);
            this.lblAnswerChoices.Font = new System.Drawing.Font("Copperplate Gothic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnswerChoices.ForeColor = System.Drawing.Color.Gold;
            this.lblAnswerChoices.Location = new System.Drawing.Point(5, 239);
            this.lblAnswerChoices.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblAnswerChoices.Name = "lblAnswerChoices";
            this.lblAnswerChoices.Padding = new System.Windows.Forms.Padding(5);
            this.lblAnswerChoices.Size = new System.Drawing.Size(437, 28);
            this.lblAnswerChoices.TabIndex = 18;
            this.lblAnswerChoices.Text = "Choices or Answer";
            this.lblAnswerChoices.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbxChoicesTypes
            // 
            this.cbxChoicesTypes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxChoicesTypes.BackColor = System.Drawing.Color.White;
            this.tlpData.SetColumnSpan(this.cbxChoicesTypes, 3);
            this.cbxChoicesTypes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxChoicesTypes.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbxChoicesTypes.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxChoicesTypes.ForeColor = System.Drawing.Color.Black;
            this.cbxChoicesTypes.ItemHeight = 20;
            this.cbxChoicesTypes.Items.AddRange(new object[] {
            "Multiple Choice",
            "True or False",
            "Identification"});
            this.cbxChoicesTypes.Location = new System.Drawing.Point(211, 206);
            this.cbxChoicesTypes.Margin = new System.Windows.Forms.Padding(0, 5, 5, 0);
            this.cbxChoicesTypes.Name = "cbxChoicesTypes";
            this.cbxChoicesTypes.Size = new System.Drawing.Size(231, 28);
            this.cbxChoicesTypes.TabIndex = 24;
            this.cbxChoicesTypes.SelectedIndexChanged += new System.EventHandler(this.cbxChoicesTypes_SelectedIndexChanged);
            // 
            // lblQuestionType
            // 
            this.lblQuestionType.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblQuestionType.AutoSize = true;
            this.lblQuestionType.BackColor = System.Drawing.Color.Black;
            this.tlpData.SetColumnSpan(this.lblQuestionType, 3);
            this.lblQuestionType.Font = new System.Drawing.Font("Copperplate Gothic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestionType.ForeColor = System.Drawing.Color.Gold;
            this.lblQuestionType.Location = new System.Drawing.Point(5, 206);
            this.lblQuestionType.Margin = new System.Windows.Forms.Padding(5, 5, 0, 0);
            this.lblQuestionType.Name = "lblQuestionType";
            this.lblQuestionType.Padding = new System.Windows.Forms.Padding(5);
            this.lblQuestionType.Size = new System.Drawing.Size(206, 28);
            this.lblQuestionType.TabIndex = 32;
            this.lblQuestionType.Text = "Question Type";
            this.lblQuestionType.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tlpChoicesOrAnswer
            // 
            this.tlpChoicesOrAnswer.BackColor = System.Drawing.Color.White;
            this.tlpChoicesOrAnswer.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tlpChoicesOrAnswer.ColumnCount = 1;
            this.tlpData.SetColumnSpan(this.tlpChoicesOrAnswer, 6);
            this.tlpChoicesOrAnswer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpChoicesOrAnswer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpChoicesOrAnswer.Controls.Add(this.tlpChoices, 0, 0);
            this.tlpChoicesOrAnswer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpChoicesOrAnswer.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.tlpChoicesOrAnswer.Location = new System.Drawing.Point(5, 267);
            this.tlpChoicesOrAnswer.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.tlpChoicesOrAnswer.Name = "tlpChoicesOrAnswer";
            this.tlpChoicesOrAnswer.RowCount = 1;
            this.tlpChoicesOrAnswer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpChoicesOrAnswer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 203F));
            this.tlpChoicesOrAnswer.Size = new System.Drawing.Size(437, 204);
            this.tlpChoicesOrAnswer.TabIndex = 35;
            // 
            // tlpChoices
            // 
            this.tlpChoices.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tlpChoices.AutoSize = true;
            this.tlpChoices.BackColor = System.Drawing.Color.White;
            this.tlpChoices.ColumnCount = 3;
            this.tlpChoices.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpChoices.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpChoices.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpChoices.Controls.Add(this.tlpIdentification, 2, 0);
            this.tlpChoices.Controls.Add(this.tlpTrueOrFalse, 1, 0);
            this.tlpChoices.Controls.Add(this.tlpMultipleChoice, 0, 0);
            this.tlpChoices.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.tlpChoices.Location = new System.Drawing.Point(1, 1);
            this.tlpChoices.Margin = new System.Windows.Forms.Padding(0);
            this.tlpChoices.Name = "tlpChoices";
            this.tlpChoices.RowCount = 1;
            this.tlpChoices.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpChoices.Size = new System.Drawing.Size(435, 202);
            this.tlpChoices.TabIndex = 25;
            // 
            // tlpIdentification
            // 
            this.tlpIdentification.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tlpIdentification.AutoSize = true;
            this.tlpIdentification.BackColor = System.Drawing.Color.Black;
            this.tlpIdentification.ColumnCount = 1;
            this.tlpIdentification.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpIdentification.Controls.Add(this.txtIdentification, 0, 0);
            this.tlpIdentification.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.tlpIdentification.Location = new System.Drawing.Point(567, 5);
            this.tlpIdentification.Margin = new System.Windows.Forms.Padding(5);
            this.tlpIdentification.Name = "tlpIdentification";
            this.tlpIdentification.RowCount = 1;
            this.tlpIdentification.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpIdentification.Size = new System.Drawing.Size(320, 95);
            this.tlpIdentification.TabIndex = 2;
            // 
            // txtIdentification
            // 
            this.txtIdentification.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtIdentification.BackColor = System.Drawing.Color.White;
            this.txtIdentification.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIdentification.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdentification.ForeColor = System.Drawing.Color.Black;
            this.txtIdentification.Location = new System.Drawing.Point(10, 10);
            this.txtIdentification.Margin = new System.Windows.Forms.Padding(10);
            this.txtIdentification.MinimumSize = new System.Drawing.Size(300, 75);
            this.txtIdentification.Multiline = true;
            this.txtIdentification.Name = "txtIdentification";
            this.txtIdentification.Size = new System.Drawing.Size(300, 75);
            this.txtIdentification.TabIndex = 16;
            this.txtIdentification.Tag = "0";
            // 
            // tlpTrueOrFalse
            // 
            this.tlpTrueOrFalse.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tlpTrueOrFalse.AutoSize = true;
            this.tlpTrueOrFalse.BackColor = System.Drawing.Color.Black;
            this.tlpTrueOrFalse.ColumnCount = 2;
            this.tlpTrueOrFalse.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpTrueOrFalse.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpTrueOrFalse.Controls.Add(this.rdoTrue, 0, 0);
            this.tlpTrueOrFalse.Controls.Add(this.rdoFalse, 1, 0);
            this.tlpTrueOrFalse.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.tlpTrueOrFalse.Location = new System.Drawing.Point(357, 5);
            this.tlpTrueOrFalse.Margin = new System.Windows.Forms.Padding(5);
            this.tlpTrueOrFalse.MinimumSize = new System.Drawing.Size(200, 0);
            this.tlpTrueOrFalse.Name = "tlpTrueOrFalse";
            this.tlpTrueOrFalse.RowCount = 1;
            this.tlpTrueOrFalse.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpTrueOrFalse.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 53F));
            this.tlpTrueOrFalse.Size = new System.Drawing.Size(200, 60);
            this.tlpTrueOrFalse.TabIndex = 1;
            // 
            // rdoTrue
            // 
            this.rdoTrue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.rdoTrue.Appearance = System.Windows.Forms.Appearance.Button;
            this.rdoTrue.AutoSize = true;
            this.rdoTrue.BackColor = System.Drawing.Color.DarkRed;
            this.rdoTrue.FlatAppearance.BorderSize = 0;
            this.rdoTrue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdoTrue.ForeColor = System.Drawing.Color.White;
            this.rdoTrue.Location = new System.Drawing.Point(10, 10);
            this.rdoTrue.Margin = new System.Windows.Forms.Padding(10, 10, 5, 10);
            this.rdoTrue.Name = "rdoTrue";
            this.rdoTrue.Padding = new System.Windows.Forms.Padding(5);
            this.rdoTrue.Size = new System.Drawing.Size(85, 40);
            this.rdoTrue.TabIndex = 21;
            this.rdoTrue.TabStop = true;
            this.rdoTrue.Text = "True";
            this.rdoTrue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rdoTrue.UseVisualStyleBackColor = false;
            this.rdoTrue.CheckedChanged += new System.EventHandler(this.rdoTrue_CheckedChanged);
            // 
            // rdoFalse
            // 
            this.rdoFalse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.rdoFalse.Appearance = System.Windows.Forms.Appearance.Button;
            this.rdoFalse.AutoSize = true;
            this.rdoFalse.BackColor = System.Drawing.Color.DarkRed;
            this.rdoFalse.FlatAppearance.BorderSize = 0;
            this.rdoFalse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdoFalse.ForeColor = System.Drawing.Color.White;
            this.rdoFalse.Location = new System.Drawing.Point(105, 10);
            this.rdoFalse.Margin = new System.Windows.Forms.Padding(5, 10, 10, 10);
            this.rdoFalse.Name = "rdoFalse";
            this.rdoFalse.Padding = new System.Windows.Forms.Padding(5);
            this.rdoFalse.Size = new System.Drawing.Size(85, 40);
            this.rdoFalse.TabIndex = 22;
            this.rdoFalse.TabStop = true;
            this.rdoFalse.Text = "False";
            this.rdoFalse.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rdoFalse.UseVisualStyleBackColor = false;
            this.rdoFalse.CheckedChanged += new System.EventHandler(this.rdoFalse_CheckedChanged);
            // 
            // tlpMultipleChoice
            // 
            this.tlpMultipleChoice.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tlpMultipleChoice.AutoSize = true;
            this.tlpMultipleChoice.ColumnCount = 1;
            this.tlpMultipleChoice.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpMultipleChoice.Controls.Add(this.tlp4Choices, 0, 0);
            this.tlpMultipleChoice.Controls.Add(this.tlpLayout, 0, 1);
            this.tlpMultipleChoice.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.tlpMultipleChoice.Location = new System.Drawing.Point(0, 0);
            this.tlpMultipleChoice.Margin = new System.Windows.Forms.Padding(0);
            this.tlpMultipleChoice.Name = "tlpMultipleChoice";
            this.tlpMultipleChoice.RowCount = 2;
            this.tlpMultipleChoice.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMultipleChoice.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpMultipleChoice.Size = new System.Drawing.Size(352, 202);
            this.tlpMultipleChoice.TabIndex = 0;
            // 
            // tlp4Choices
            // 
            this.tlp4Choices.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tlp4Choices.AutoSize = true;
            this.tlp4Choices.BackColor = System.Drawing.Color.Black;
            this.tlp4Choices.ColumnCount = 2;
            this.tlp4Choices.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlp4Choices.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp4Choices.Controls.Add(this.rdoMultipleChoiceD, 0, 3);
            this.tlp4Choices.Controls.Add(this.txtMultipleChoiceA, 1, 0);
            this.tlp4Choices.Controls.Add(this.txtMultipleChoiceD, 1, 3);
            this.tlp4Choices.Controls.Add(this.rdoMultipleChoiceB, 0, 1);
            this.tlp4Choices.Controls.Add(this.rdoMultipleChoiceC, 0, 2);
            this.tlp4Choices.Controls.Add(this.rdoMultipleChoiceA, 0, 0);
            this.tlp4Choices.Controls.Add(this.txtMultipleChoiceB, 1, 1);
            this.tlp4Choices.Controls.Add(this.txtMultipleChoiceC, 1, 2);
            this.tlp4Choices.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.tlp4Choices.Location = new System.Drawing.Point(5, 5);
            this.tlp4Choices.Margin = new System.Windows.Forms.Padding(5);
            this.tlp4Choices.Name = "tlp4Choices";
            this.tlp4Choices.RowCount = 4;
            this.tlp4Choices.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlp4Choices.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlp4Choices.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlp4Choices.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlp4Choices.Size = new System.Drawing.Size(342, 155);
            this.tlp4Choices.TabIndex = 28;
            // 
            // rdoMultipleChoiceD
            // 
            this.rdoMultipleChoiceD.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.rdoMultipleChoiceD.Appearance = System.Windows.Forms.Appearance.Button;
            this.rdoMultipleChoiceD.AutoSize = true;
            this.rdoMultipleChoiceD.BackColor = System.Drawing.Color.DarkRed;
            this.rdoMultipleChoiceD.FlatAppearance.BorderSize = 0;
            this.rdoMultipleChoiceD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdoMultipleChoiceD.ForeColor = System.Drawing.Color.White;
            this.rdoMultipleChoiceD.Location = new System.Drawing.Point(5, 119);
            this.rdoMultipleChoiceD.Margin = new System.Windows.Forms.Padding(5, 5, 2, 5);
            this.rdoMultipleChoiceD.MaximumSize = new System.Drawing.Size(30, 30);
            this.rdoMultipleChoiceD.MinimumSize = new System.Drawing.Size(30, 30);
            this.rdoMultipleChoiceD.Name = "rdoMultipleChoiceD";
            this.rdoMultipleChoiceD.Size = new System.Drawing.Size(30, 30);
            this.rdoMultipleChoiceD.TabIndex = 23;
            this.rdoMultipleChoiceD.TabStop = true;
            this.rdoMultipleChoiceD.Text = "D";
            this.rdoMultipleChoiceD.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rdoMultipleChoiceD.UseVisualStyleBackColor = false;
            this.rdoMultipleChoiceD.CheckedChanged += new System.EventHandler(this.rdoMultipleChoiceD_CheckedChanged);
            // 
            // txtMultipleChoiceA
            // 
            this.txtMultipleChoiceA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMultipleChoiceA.BackColor = System.Drawing.Color.White;
            this.txtMultipleChoiceA.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMultipleChoiceA.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMultipleChoiceA.ForeColor = System.Drawing.Color.Black;
            this.txtMultipleChoiceA.Location = new System.Drawing.Point(37, 6);
            this.txtMultipleChoiceA.Margin = new System.Windows.Forms.Padding(0, 5, 5, 0);
            this.txtMultipleChoiceA.MinimumSize = new System.Drawing.Size(300, 30);
            this.txtMultipleChoiceA.Multiline = true;
            this.txtMultipleChoiceA.Name = "txtMultipleChoiceA";
            this.txtMultipleChoiceA.Size = new System.Drawing.Size(300, 30);
            this.txtMultipleChoiceA.TabIndex = 16;
            this.txtMultipleChoiceA.Tag = "0";
            // 
            // txtMultipleChoiceD
            // 
            this.txtMultipleChoiceD.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMultipleChoiceD.BackColor = System.Drawing.Color.White;
            this.txtMultipleChoiceD.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMultipleChoiceD.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMultipleChoiceD.ForeColor = System.Drawing.Color.Black;
            this.txtMultipleChoiceD.Location = new System.Drawing.Point(37, 119);
            this.txtMultipleChoiceD.Margin = new System.Windows.Forms.Padding(0, 5, 5, 5);
            this.txtMultipleChoiceD.MinimumSize = new System.Drawing.Size(300, 30);
            this.txtMultipleChoiceD.Multiline = true;
            this.txtMultipleChoiceD.Name = "txtMultipleChoiceD";
            this.txtMultipleChoiceD.Size = new System.Drawing.Size(300, 30);
            this.txtMultipleChoiceD.TabIndex = 19;
            this.txtMultipleChoiceD.Tag = "0";
            // 
            // rdoMultipleChoiceB
            // 
            this.rdoMultipleChoiceB.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.rdoMultipleChoiceB.Appearance = System.Windows.Forms.Appearance.Button;
            this.rdoMultipleChoiceB.AutoSize = true;
            this.rdoMultipleChoiceB.BackColor = System.Drawing.Color.DarkRed;
            this.rdoMultipleChoiceB.FlatAppearance.BorderSize = 0;
            this.rdoMultipleChoiceB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdoMultipleChoiceB.ForeColor = System.Drawing.Color.White;
            this.rdoMultipleChoiceB.Location = new System.Drawing.Point(5, 44);
            this.rdoMultipleChoiceB.Margin = new System.Windows.Forms.Padding(5, 5, 2, 0);
            this.rdoMultipleChoiceB.MaximumSize = new System.Drawing.Size(30, 30);
            this.rdoMultipleChoiceB.MinimumSize = new System.Drawing.Size(30, 30);
            this.rdoMultipleChoiceB.Name = "rdoMultipleChoiceB";
            this.rdoMultipleChoiceB.Size = new System.Drawing.Size(30, 30);
            this.rdoMultipleChoiceB.TabIndex = 21;
            this.rdoMultipleChoiceB.TabStop = true;
            this.rdoMultipleChoiceB.Text = "B";
            this.rdoMultipleChoiceB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rdoMultipleChoiceB.UseVisualStyleBackColor = false;
            this.rdoMultipleChoiceB.CheckedChanged += new System.EventHandler(this.rdoMultipleChoiceB_CheckedChanged);
            // 
            // rdoMultipleChoiceC
            // 
            this.rdoMultipleChoiceC.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.rdoMultipleChoiceC.Appearance = System.Windows.Forms.Appearance.Button;
            this.rdoMultipleChoiceC.AutoSize = true;
            this.rdoMultipleChoiceC.BackColor = System.Drawing.Color.DarkRed;
            this.rdoMultipleChoiceC.FlatAppearance.BorderSize = 0;
            this.rdoMultipleChoiceC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdoMultipleChoiceC.ForeColor = System.Drawing.Color.White;
            this.rdoMultipleChoiceC.Location = new System.Drawing.Point(5, 82);
            this.rdoMultipleChoiceC.Margin = new System.Windows.Forms.Padding(5, 5, 2, 0);
            this.rdoMultipleChoiceC.MaximumSize = new System.Drawing.Size(30, 30);
            this.rdoMultipleChoiceC.MinimumSize = new System.Drawing.Size(30, 30);
            this.rdoMultipleChoiceC.Name = "rdoMultipleChoiceC";
            this.rdoMultipleChoiceC.Size = new System.Drawing.Size(30, 30);
            this.rdoMultipleChoiceC.TabIndex = 22;
            this.rdoMultipleChoiceC.TabStop = true;
            this.rdoMultipleChoiceC.Text = "C";
            this.rdoMultipleChoiceC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rdoMultipleChoiceC.UseVisualStyleBackColor = false;
            this.rdoMultipleChoiceC.CheckedChanged += new System.EventHandler(this.rdoMultipleChoiceC_CheckedChanged);
            // 
            // rdoMultipleChoiceA
            // 
            this.rdoMultipleChoiceA.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.rdoMultipleChoiceA.Appearance = System.Windows.Forms.Appearance.Button;
            this.rdoMultipleChoiceA.AutoSize = true;
            this.rdoMultipleChoiceA.BackColor = System.Drawing.Color.DarkRed;
            this.rdoMultipleChoiceA.FlatAppearance.BorderSize = 0;
            this.rdoMultipleChoiceA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdoMultipleChoiceA.ForeColor = System.Drawing.Color.White;
            this.rdoMultipleChoiceA.Location = new System.Drawing.Point(5, 6);
            this.rdoMultipleChoiceA.Margin = new System.Windows.Forms.Padding(5, 5, 2, 0);
            this.rdoMultipleChoiceA.MaximumSize = new System.Drawing.Size(30, 30);
            this.rdoMultipleChoiceA.MinimumSize = new System.Drawing.Size(30, 30);
            this.rdoMultipleChoiceA.Name = "rdoMultipleChoiceA";
            this.rdoMultipleChoiceA.Size = new System.Drawing.Size(30, 30);
            this.rdoMultipleChoiceA.TabIndex = 20;
            this.rdoMultipleChoiceA.TabStop = true;
            this.rdoMultipleChoiceA.Text = "A";
            this.rdoMultipleChoiceA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rdoMultipleChoiceA.UseVisualStyleBackColor = false;
            this.rdoMultipleChoiceA.CheckedChanged += new System.EventHandler(this.rdoMultipleChoiceA_CheckedChanged);
            // 
            // txtMultipleChoiceB
            // 
            this.txtMultipleChoiceB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMultipleChoiceB.BackColor = System.Drawing.Color.White;
            this.txtMultipleChoiceB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMultipleChoiceB.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMultipleChoiceB.ForeColor = System.Drawing.Color.Black;
            this.txtMultipleChoiceB.Location = new System.Drawing.Point(37, 44);
            this.txtMultipleChoiceB.Margin = new System.Windows.Forms.Padding(0, 5, 5, 0);
            this.txtMultipleChoiceB.MinimumSize = new System.Drawing.Size(300, 30);
            this.txtMultipleChoiceB.Multiline = true;
            this.txtMultipleChoiceB.Name = "txtMultipleChoiceB";
            this.txtMultipleChoiceB.Size = new System.Drawing.Size(300, 30);
            this.txtMultipleChoiceB.TabIndex = 17;
            this.txtMultipleChoiceB.Tag = "0";
            // 
            // txtMultipleChoiceC
            // 
            this.txtMultipleChoiceC.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMultipleChoiceC.BackColor = System.Drawing.Color.White;
            this.txtMultipleChoiceC.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMultipleChoiceC.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMultipleChoiceC.ForeColor = System.Drawing.Color.Black;
            this.txtMultipleChoiceC.Location = new System.Drawing.Point(37, 82);
            this.txtMultipleChoiceC.Margin = new System.Windows.Forms.Padding(0, 5, 5, 0);
            this.txtMultipleChoiceC.MinimumSize = new System.Drawing.Size(300, 30);
            this.txtMultipleChoiceC.Multiline = true;
            this.txtMultipleChoiceC.Name = "txtMultipleChoiceC";
            this.txtMultipleChoiceC.Size = new System.Drawing.Size(300, 30);
            this.txtMultipleChoiceC.TabIndex = 18;
            this.txtMultipleChoiceC.Tag = "0";
            // 
            // tlpLayout
            // 
            this.tlpLayout.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tlpLayout.AutoSize = true;
            this.tlpLayout.BackColor = System.Drawing.Color.Black;
            this.tlpLayout.ColumnCount = 4;
            this.tlpLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpLayout.Controls.Add(this.rdoLayout4x1, 3, 0);
            this.tlpLayout.Controls.Add(this.lblLayout, 0, 0);
            this.tlpLayout.Controls.Add(this.rdoLayout2x2, 2, 0);
            this.tlpLayout.Controls.Add(this.rdoLayout1x4, 1, 0);
            this.tlpLayout.Location = new System.Drawing.Point(78, 165);
            this.tlpLayout.Margin = new System.Windows.Forms.Padding(0, 0, 5, 5);
            this.tlpLayout.Name = "tlpLayout";
            this.tlpLayout.RowCount = 1;
            this.tlpLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpLayout.Size = new System.Drawing.Size(191, 32);
            this.tlpLayout.TabIndex = 27;
            // 
            // rdoLayout4x1
            // 
            this.rdoLayout4x1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.rdoLayout4x1.Appearance = System.Windows.Forms.Appearance.Button;
            this.rdoLayout4x1.AutoSize = true;
            this.rdoLayout4x1.BackColor = System.Drawing.Color.DarkRed;
            this.rdoLayout4x1.FlatAppearance.BorderSize = 0;
            this.rdoLayout4x1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdoLayout4x1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoLayout4x1.ForeColor = System.Drawing.Color.White;
            this.rdoLayout4x1.Location = new System.Drawing.Point(151, 1);
            this.rdoLayout4x1.Margin = new System.Windows.Forms.Padding(0, 1, 1, 1);
            this.rdoLayout4x1.Name = "rdoLayout4x1";
            this.rdoLayout4x1.Size = new System.Drawing.Size(39, 30);
            this.rdoLayout4x1.TabIndex = 3;
            this.rdoLayout4x1.TabStop = true;
            this.rdoLayout4x1.Text = "4x1";
            this.rdoLayout4x1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rdoLayout4x1.UseVisualStyleBackColor = false;
            this.rdoLayout4x1.CheckedChanged += new System.EventHandler(this.rdoLayout4x1_CheckedChanged);
            // 
            // lblLayout
            // 
            this.lblLayout.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLayout.AutoSize = true;
            this.lblLayout.BackColor = System.Drawing.Color.Black;
            this.lblLayout.Font = new System.Drawing.Font("Copperplate Gothic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLayout.ForeColor = System.Drawing.Color.Gold;
            this.lblLayout.Location = new System.Drawing.Point(0, 5);
            this.lblLayout.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.lblLayout.Name = "lblLayout";
            this.lblLayout.Size = new System.Drawing.Size(71, 27);
            this.lblLayout.TabIndex = 26;
            this.lblLayout.Text = "Layout";
            this.lblLayout.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rdoLayout2x2
            // 
            this.rdoLayout2x2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.rdoLayout2x2.Appearance = System.Windows.Forms.Appearance.Button;
            this.rdoLayout2x2.AutoSize = true;
            this.rdoLayout2x2.BackColor = System.Drawing.Color.DarkRed;
            this.rdoLayout2x2.FlatAppearance.BorderSize = 0;
            this.rdoLayout2x2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdoLayout2x2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoLayout2x2.ForeColor = System.Drawing.Color.White;
            this.rdoLayout2x2.Location = new System.Drawing.Point(111, 1);
            this.rdoLayout2x2.Margin = new System.Windows.Forms.Padding(0, 1, 1, 1);
            this.rdoLayout2x2.Name = "rdoLayout2x2";
            this.rdoLayout2x2.Size = new System.Drawing.Size(39, 30);
            this.rdoLayout2x2.TabIndex = 2;
            this.rdoLayout2x2.TabStop = true;
            this.rdoLayout2x2.Text = "2x2";
            this.rdoLayout2x2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rdoLayout2x2.UseVisualStyleBackColor = false;
            this.rdoLayout2x2.CheckedChanged += new System.EventHandler(this.rdoLayout2x2_CheckedChanged);
            // 
            // rdoLayout1x4
            // 
            this.rdoLayout1x4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.rdoLayout1x4.Appearance = System.Windows.Forms.Appearance.Button;
            this.rdoLayout1x4.AutoSize = true;
            this.rdoLayout1x4.BackColor = System.Drawing.Color.DarkRed;
            this.rdoLayout1x4.FlatAppearance.BorderSize = 0;
            this.rdoLayout1x4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdoLayout1x4.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoLayout1x4.ForeColor = System.Drawing.Color.White;
            this.rdoLayout1x4.Location = new System.Drawing.Point(71, 1);
            this.rdoLayout1x4.Margin = new System.Windows.Forms.Padding(0, 1, 1, 1);
            this.rdoLayout1x4.Name = "rdoLayout1x4";
            this.rdoLayout1x4.Size = new System.Drawing.Size(39, 30);
            this.rdoLayout1x4.TabIndex = 1;
            this.rdoLayout1x4.Text = "1x4";
            this.rdoLayout1x4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rdoLayout1x4.UseVisualStyleBackColor = false;
            this.rdoLayout1x4.CheckedChanged += new System.EventHandler(this.rdoLayout1x4_CheckedChanged);
            // 
            // tlpList
            // 
            this.tlpList.BackColor = System.Drawing.Color.Gold;
            this.tlpList.ColumnCount = 2;
            this.tlpList.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpList.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpList.Controls.Add(this.lblGame, 1, 0);
            this.tlpList.Controls.Add(this.dgvQuestions, 0, 1);
            this.tlpList.Controls.Add(this.btnSelectGame, 0, 0);
            this.tlpList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpList.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.tlpList.Location = new System.Drawing.Point(0, 0);
            this.tlpList.Margin = new System.Windows.Forms.Padding(0);
            this.tlpList.Name = "tlpList";
            this.tlpList.RowCount = 2;
            this.tlpList.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpList.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpList.Size = new System.Drawing.Size(242, 511);
            this.tlpList.TabIndex = 1;
            // 
            // lblGame
            // 
            this.lblGame.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblGame.AutoSize = true;
            this.lblGame.BackColor = System.Drawing.Color.Black;
            this.lblGame.Font = new System.Drawing.Font("Copperplate Gothic Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGame.ForeColor = System.Drawing.Color.Gold;
            this.lblGame.Location = new System.Drawing.Point(69, 5);
            this.lblGame.Margin = new System.Windows.Forms.Padding(0, 5, 5, 0);
            this.lblGame.Name = "lblGame";
            this.lblGame.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblGame.Size = new System.Drawing.Size(168, 32);
            this.lblGame.TabIndex = 13;
            this.lblGame.Text = "Game";
            this.lblGame.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvQuestions
            // 
            this.dgvQuestions.AllowUserToAddRows = false;
            this.dgvQuestions.AllowUserToDeleteRows = false;
            this.dgvQuestions.AllowUserToResizeColumns = false;
            this.dgvQuestions.AllowUserToResizeRows = false;
            this.dgvQuestions.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Lime;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvQuestions.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvQuestions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQuestions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colQuestionID,
            this.colQuestionSequence,
            this.colQuestionStatement,
            this.colQuestionLevel});
            this.tlpList.SetColumnSpan(this.dgvQuestions, 2);
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Lime;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvQuestions.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvQuestions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvQuestions.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvQuestions.Location = new System.Drawing.Point(5, 42);
            this.dgvQuestions.Margin = new System.Windows.Forms.Padding(5);
            this.dgvQuestions.MultiSelect = false;
            this.dgvQuestions.Name = "dgvQuestions";
            this.dgvQuestions.ReadOnly = true;
            this.dgvQuestions.RowHeadersVisible = false;
            this.dgvQuestions.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvQuestions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvQuestions.ShowCellErrors = false;
            this.dgvQuestions.ShowCellToolTips = false;
            this.dgvQuestions.ShowEditingIcon = false;
            this.dgvQuestions.ShowRowErrors = false;
            this.dgvQuestions.Size = new System.Drawing.Size(232, 464);
            this.dgvQuestions.TabIndex = 1;
            this.dgvQuestions.SelectionChanged += new System.EventHandler(this.dgvQuestions_SelectionChanged);
            // 
            // colQuestionID
            // 
            this.colQuestionID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colQuestionID.FillWeight = 1F;
            this.colQuestionID.HeaderText = "ID";
            this.colQuestionID.Name = "colQuestionID";
            this.colQuestionID.ReadOnly = true;
            this.colQuestionID.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colQuestionID.Visible = false;
            // 
            // colQuestionSequence
            // 
            this.colQuestionSequence.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colQuestionSequence.FillWeight = 15F;
            this.colQuestionSequence.HeaderText = "No.";
            this.colQuestionSequence.Name = "colQuestionSequence";
            this.colQuestionSequence.ReadOnly = true;
            this.colQuestionSequence.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // colQuestionStatement
            // 
            this.colQuestionStatement.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colQuestionStatement.FillWeight = 45F;
            this.colQuestionStatement.HeaderText = "Question";
            this.colQuestionStatement.Name = "colQuestionStatement";
            this.colQuestionStatement.ReadOnly = true;
            // 
            // colQuestionLevel
            // 
            this.colQuestionLevel.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colQuestionLevel.FillWeight = 30F;
            this.colQuestionLevel.HeaderText = "Level";
            this.colQuestionLevel.Name = "colQuestionLevel";
            this.colQuestionLevel.ReadOnly = true;
            // 
            // btnSelectGame
            // 
            this.btnSelectGame.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSelectGame.AutoSize = true;
            this.btnSelectGame.BackColor = System.Drawing.Color.DarkGreen;
            this.btnSelectGame.FlatAppearance.BorderSize = 0;
            this.btnSelectGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelectGame.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectGame.ForeColor = System.Drawing.Color.Gold;
            this.btnSelectGame.Location = new System.Drawing.Point(5, 5);
            this.btnSelectGame.Margin = new System.Windows.Forms.Padding(5, 5, 0, 0);
            this.btnSelectGame.Name = "btnSelectGame";
            this.btnSelectGame.Size = new System.Drawing.Size(64, 32);
            this.btnSelectGame.TabIndex = 12;
            this.btnSelectGame.Text = "Games";
            this.btnSelectGame.UseVisualStyleBackColor = false;
            this.btnSelectGame.Click += new System.EventHandler(this.btnSelectGame_Click);
            // 
            // frmQuestions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(704, 521);
            this.Controls.Add(this.tlpMain);
            this.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = Properties.Resources.logo;
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmQuestions";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Questions Management";
            this.TopMost = true;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmQuestions_FormClosed);
            this.Load += new System.EventHandler(this.frmQuestions_Load);
            this.tlpMain.ResumeLayout(false);
            this.tlpData.ResumeLayout(false);
            this.tlpData.PerformLayout();
            this.tlpChoicesOrAnswer.ResumeLayout(false);
            this.tlpChoicesOrAnswer.PerformLayout();
            this.tlpChoices.ResumeLayout(false);
            this.tlpChoices.PerformLayout();
            this.tlpIdentification.ResumeLayout(false);
            this.tlpIdentification.PerformLayout();
            this.tlpTrueOrFalse.ResumeLayout(false);
            this.tlpTrueOrFalse.PerformLayout();
            this.tlpMultipleChoice.ResumeLayout(false);
            this.tlpMultipleChoice.PerformLayout();
            this.tlp4Choices.ResumeLayout(false);
            this.tlp4Choices.PerformLayout();
            this.tlpLayout.ResumeLayout(false);
            this.tlpLayout.PerformLayout();
            this.tlpList.ResumeLayout(false);
            this.tlpList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuestions)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpMain;
        private System.Windows.Forms.TableLayoutPanel tlpList;
        private System.Windows.Forms.DataGridView dgvQuestions;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnSelectGame;
        private System.Windows.Forms.TableLayoutPanel tlpData;
        private System.Windows.Forms.ComboBox cbxLevels;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblSequence;
        private System.Windows.Forms.Label lblDifficulty;
        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.Label lblAnswerChoices;
        private System.Windows.Forms.TextBox txtQuestionStatement;
        private System.Windows.Forms.Label lblGame;
        private System.Windows.Forms.ComboBox cbxChoicesTypes;
        private System.Windows.Forms.TableLayoutPanel tlpChoices;
        private System.Windows.Forms.Label lblLayout;
        private System.Windows.Forms.TableLayoutPanel tlpLayout;
        private System.Windows.Forms.RadioButton rdoLayout4x1;
        private System.Windows.Forms.RadioButton rdoLayout2x2;
        private System.Windows.Forms.RadioButton rdoLayout1x4;
        private System.Windows.Forms.Button btnPreview;
        private System.Windows.Forms.TextBox txtSequence;
        private System.Windows.Forms.TableLayoutPanel tlpIdentification;
        private System.Windows.Forms.TextBox txtIdentification;
        private System.Windows.Forms.TableLayoutPanel tlpTrueOrFalse;
        private System.Windows.Forms.TableLayoutPanel tlpMultipleChoice;
        private System.Windows.Forms.TextBox txtMultipleChoiceD;
        private System.Windows.Forms.TextBox txtMultipleChoiceA;
        private System.Windows.Forms.TextBox txtMultipleChoiceB;
        private System.Windows.Forms.TextBox txtMultipleChoiceC;
        private System.Windows.Forms.RadioButton rdoTrue;
        private System.Windows.Forms.RadioButton rdoMultipleChoiceD;
        private System.Windows.Forms.RadioButton rdoMultipleChoiceA;
        private System.Windows.Forms.RadioButton rdoMultipleChoiceB;
        private System.Windows.Forms.RadioButton rdoMultipleChoiceC;
        private System.Windows.Forms.RadioButton rdoFalse;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQuestionID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQuestionSequence;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQuestionStatement;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQuestionLevel;
        private System.Windows.Forms.TableLayoutPanel tlp4Choices;
        private System.Windows.Forms.Label lblPassOrPlay;
        private System.Windows.Forms.CheckBox chkPassOrPlay;
        private System.Windows.Forms.Label lblBibleReference;
        private System.Windows.Forms.Label lblQuestionType;
        private System.Windows.Forms.TextBox txtBibleReference;
        private System.Windows.Forms.TableLayoutPanel tlpChoicesOrAnswer;
    }
}
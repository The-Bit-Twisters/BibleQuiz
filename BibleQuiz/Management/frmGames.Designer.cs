namespace BibleQuiz.Management
{
    partial class frmGames
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
            this.tlpList = new System.Windows.Forms.TableLayoutPanel();
            this.lblGames = new System.Windows.Forms.Label();
            this.dgvGames = new System.Windows.Forms.DataGridView();
            this.colGameID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGameSequence = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGameDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGameFinished = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnNew = new System.Windows.Forms.Button();
            this.lblFinished = new System.Windows.Forms.Label();
            this.lblSequence = new System.Windows.Forms.Label();
            this.txtSequence = new System.Windows.Forms.TextBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.btnSave = new System.Windows.Forms.Button();
            this.tlpMain = new System.Windows.Forms.TableLayoutPanel();
            this.tlpData = new System.Windows.Forms.TableLayoutPanel();
            this.txtFinished = new System.Windows.Forms.TextBox();
            this.tlpList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGames)).BeginInit();
            this.tlpMain.SuspendLayout();
            this.tlpData.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpList
            // 
            this.tlpList.BackColor = System.Drawing.Color.Gold;
            this.tlpList.ColumnCount = 1;
            this.tlpList.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpList.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            this.tlpList.Controls.Add(this.lblGames, 0, 0);
            this.tlpList.Controls.Add(this.dgvGames, 0, 1);
            this.tlpList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpList.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.tlpList.Location = new System.Drawing.Point(0, 0);
            this.tlpList.Margin = new System.Windows.Forms.Padding(0);
            this.tlpList.Name = "tlpList";
            this.tlpList.RowCount = 2;
            this.tlpList.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpList.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpList.Size = new System.Drawing.Size(274, 157);
            this.tlpList.TabIndex = 0;
            // 
            // lblGames
            // 
            this.lblGames.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblGames.AutoSize = true;
            this.lblGames.BackColor = System.Drawing.Color.Black;
            this.lblGames.Font = new System.Drawing.Font("Copperplate Gothic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGames.ForeColor = System.Drawing.Color.Gold;
            this.lblGames.Location = new System.Drawing.Point(5, 5);
            this.lblGames.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblGames.Name = "lblGames";
            this.lblGames.Padding = new System.Windows.Forms.Padding(5);
            this.lblGames.Size = new System.Drawing.Size(264, 28);
            this.lblGames.TabIndex = 10;
            this.lblGames.Text = "Games";
            this.lblGames.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvGames
            // 
            this.dgvGames.AllowUserToAddRows = false;
            this.dgvGames.AllowUserToDeleteRows = false;
            this.dgvGames.AllowUserToResizeColumns = false;
            this.dgvGames.AllowUserToResizeRows = false;
            this.dgvGames.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvGames.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvGames.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGames.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colGameID,
            this.colGameSequence,
            this.colGameDate,
            this.colGameFinished});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Lime;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvGames.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvGames.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvGames.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvGames.GridColor = System.Drawing.Color.DimGray;
            this.dgvGames.Location = new System.Drawing.Point(5, 38);
            this.dgvGames.Margin = new System.Windows.Forms.Padding(5);
            this.dgvGames.MultiSelect = false;
            this.dgvGames.Name = "dgvGames";
            this.dgvGames.ReadOnly = true;
            this.dgvGames.RowHeadersVisible = false;
            this.dgvGames.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvGames.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvGames.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvGames.ShowCellErrors = false;
            this.dgvGames.ShowCellToolTips = false;
            this.dgvGames.ShowEditingIcon = false;
            this.dgvGames.ShowRowErrors = false;
            this.dgvGames.Size = new System.Drawing.Size(264, 114);
            this.dgvGames.TabIndex = 1;
            this.dgvGames.SelectionChanged += new System.EventHandler(this.dgvGames_SelectionChanged);
            // 
            // colGameID
            // 
            this.colGameID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colGameID.FillWeight = 1F;
            this.colGameID.HeaderText = "ID";
            this.colGameID.Name = "colGameID";
            this.colGameID.ReadOnly = true;
            this.colGameID.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colGameID.Visible = false;
            // 
            // colGameSequence
            // 
            this.colGameSequence.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colGameSequence.FillWeight = 15F;
            this.colGameSequence.HeaderText = "No.";
            this.colGameSequence.Name = "colGameSequence";
            this.colGameSequence.ReadOnly = true;
            this.colGameSequence.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // colGameDate
            // 
            this.colGameDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colGameDate.FillWeight = 60F;
            this.colGameDate.HeaderText = "Date";
            this.colGameDate.Name = "colGameDate";
            this.colGameDate.ReadOnly = true;
            this.colGameDate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // colGameFinished
            // 
            this.colGameFinished.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colGameFinished.FillWeight = 25F;
            this.colGameFinished.HeaderText = "Finished";
            this.colGameFinished.Name = "colGameFinished";
            this.colGameFinished.ReadOnly = true;
            this.colGameFinished.Resizable = System.Windows.Forms.DataGridViewTriState.False;
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
            this.btnNew.Location = new System.Drawing.Point(5, 119);
            this.btnNew.Margin = new System.Windows.Forms.Padding(5);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(46, 28);
            this.btnNew.TabIndex = 0;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = false;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // lblFinished
            // 
            this.lblFinished.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFinished.AutoSize = true;
            this.lblFinished.BackColor = System.Drawing.Color.Black;
            this.lblFinished.Font = new System.Drawing.Font("Copperplate Gothic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFinished.ForeColor = System.Drawing.Color.Gold;
            this.lblFinished.Location = new System.Drawing.Point(6, 83);
            this.lblFinished.Margin = new System.Windows.Forms.Padding(6, 5, 0, 0);
            this.lblFinished.Name = "lblFinished";
            this.lblFinished.Padding = new System.Windows.Forms.Padding(5);
            this.lblFinished.Size = new System.Drawing.Size(103, 28);
            this.lblFinished.TabIndex = 7;
            this.lblFinished.Text = "Finished?";
            this.lblFinished.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSequence
            // 
            this.lblSequence.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSequence.AutoSize = true;
            this.lblSequence.BackColor = System.Drawing.Color.Black;
            this.lblSequence.Font = new System.Drawing.Font("Copperplate Gothic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSequence.ForeColor = System.Drawing.Color.Gold;
            this.lblSequence.Location = new System.Drawing.Point(5, 7);
            this.lblSequence.Margin = new System.Windows.Forms.Padding(5, 5, 0, 0);
            this.lblSequence.Name = "lblSequence";
            this.lblSequence.Padding = new System.Windows.Forms.Padding(5);
            this.lblSequence.Size = new System.Drawing.Size(104, 28);
            this.lblSequence.TabIndex = 1;
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
            this.txtSequence.Location = new System.Drawing.Point(109, 8);
            this.txtSequence.Margin = new System.Windows.Forms.Padding(0, 5, 5, 0);
            this.txtSequence.Name = "txtSequence";
            this.txtSequence.ReadOnly = true;
            this.txtSequence.Size = new System.Drawing.Size(50, 26);
            this.txtSequence.TabIndex = 0;
            this.txtSequence.Text = "0";
            this.txtSequence.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblDate
            // 
            this.lblDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDate.AutoSize = true;
            this.lblDate.BackColor = System.Drawing.Color.Black;
            this.lblDate.Font = new System.Drawing.Font("Copperplate Gothic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.Color.Gold;
            this.lblDate.Location = new System.Drawing.Point(6, 45);
            this.lblDate.Margin = new System.Windows.Forms.Padding(6, 5, 0, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Padding = new System.Windows.Forms.Padding(5);
            this.lblDate.Size = new System.Drawing.Size(103, 28);
            this.lblDate.TabIndex = 5;
            this.lblDate.Text = "Date";
            this.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dtpDate
            // 
            this.dtpDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpData.SetColumnSpan(this.dtpDate, 2);
            this.dtpDate.CustomFormat = "MMMM dd, yyyy";
            this.dtpDate.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDate.Location = new System.Drawing.Point(109, 46);
            this.dtpDate.Margin = new System.Windows.Forms.Padding(0, 5, 5, 0);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(160, 26);
            this.dtpDate.TabIndex = 1;
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
            this.btnSave.Location = new System.Drawing.Point(218, 119);
            this.btnSave.Margin = new System.Windows.Forms.Padding(5);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(51, 28);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // tlpMain
            // 
            this.tlpMain.ColumnCount = 1;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpMain.Controls.Add(this.tlpList, 0, 0);
            this.tlpMain.Controls.Add(this.tlpData, 0, 1);
            this.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMain.Location = new System.Drawing.Point(5, 5);
            this.tlpMain.Margin = new System.Windows.Forms.Padding(0);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.RowCount = 2;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpMain.Size = new System.Drawing.Size(274, 314);
            this.tlpMain.TabIndex = 1;
            // 
            // tlpData
            // 
            this.tlpData.AutoSize = true;
            this.tlpData.BackColor = System.Drawing.Color.Gold;
            this.tlpData.ColumnCount = 3;
            this.tlpData.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpData.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpData.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpData.Controls.Add(this.lblSequence, 0, 0);
            this.tlpData.Controls.Add(this.btnNew, 0, 3);
            this.tlpData.Controls.Add(this.lblFinished, 0, 2);
            this.tlpData.Controls.Add(this.btnSave, 2, 3);
            this.tlpData.Controls.Add(this.txtSequence, 1, 0);
            this.tlpData.Controls.Add(this.lblDate, 0, 1);
            this.tlpData.Controls.Add(this.dtpDate, 1, 1);
            this.tlpData.Controls.Add(this.txtFinished, 1, 2);
            this.tlpData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpData.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.tlpData.Location = new System.Drawing.Point(0, 162);
            this.tlpData.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.tlpData.Name = "tlpData";
            this.tlpData.RowCount = 4;
            this.tlpData.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpData.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpData.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpData.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpData.Size = new System.Drawing.Size(274, 152);
            this.tlpData.TabIndex = 1;
            // 
            // txtFinished
            // 
            this.txtFinished.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtFinished.BackColor = System.Drawing.Color.White;
            this.txtFinished.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFinished.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFinished.ForeColor = System.Drawing.Color.Black;
            this.txtFinished.Location = new System.Drawing.Point(109, 84);
            this.txtFinished.Margin = new System.Windows.Forms.Padding(0, 5, 6, 0);
            this.txtFinished.Name = "txtFinished";
            this.txtFinished.ReadOnly = true;
            this.txtFinished.Size = new System.Drawing.Size(64, 26);
            this.txtFinished.TabIndex = 13;
            this.txtFinished.Text = "No";
            this.txtFinished.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // frmGames
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(284, 324);
            this.Controls.Add(this.tlpMain);
            this.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = Properties.Resources.logo;
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmGames";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Games Management";
            this.TopMost = true;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmGames_FormClosed);
            this.Load += new System.EventHandler(this.frmGames_Load);
            this.tlpList.ResumeLayout(false);
            this.tlpList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGames)).EndInit();
            this.tlpMain.ResumeLayout(false);
            this.tlpMain.PerformLayout();
            this.tlpData.ResumeLayout(false);
            this.tlpData.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpList;
        private System.Windows.Forms.DataGridView dgvGames;
        private System.Windows.Forms.Label lblSequence;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.TextBox txtSequence;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Label lblFinished;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblGames;
        private System.Windows.Forms.TableLayoutPanel tlpMain;
        private System.Windows.Forms.TableLayoutPanel tlpData;
        private System.Windows.Forms.TextBox txtFinished;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGameID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGameSequence;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGameDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGameFinished;
    }
}
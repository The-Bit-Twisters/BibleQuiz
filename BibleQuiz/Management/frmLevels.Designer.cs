namespace BibleQuiz.Management
{
    partial class frmLevels
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
            this.lblLevels = new System.Windows.Forms.Label();
            this.dgvLevels = new System.Windows.Forms.DataGridView();
            this.colLevelID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLevelName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLevelScore = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnNew = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblScore = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.tlpMain = new System.Windows.Forms.TableLayoutPanel();
            this.tlpData = new System.Windows.Forms.TableLayoutPanel();
            this.nudScore = new System.Windows.Forms.NumericUpDown();
            this.tlpList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLevels)).BeginInit();
            this.tlpMain.SuspendLayout();
            this.tlpData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudScore)).BeginInit();
            this.SuspendLayout();
            // 
            // tlpList
            // 
            this.tlpList.BackColor = System.Drawing.Color.Gold;
            this.tlpList.ColumnCount = 1;
            this.tlpList.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpList.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            this.tlpList.Controls.Add(this.lblLevels, 0, 0);
            this.tlpList.Controls.Add(this.dgvLevels, 0, 1);
            this.tlpList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpList.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.tlpList.Location = new System.Drawing.Point(0, 0);
            this.tlpList.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.tlpList.Name = "tlpList";
            this.tlpList.RowCount = 2;
            this.tlpList.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpList.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpList.Size = new System.Drawing.Size(214, 165);
            this.tlpList.TabIndex = 0;
            // 
            // lblLevels
            // 
            this.lblLevels.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLevels.AutoSize = true;
            this.lblLevels.BackColor = System.Drawing.Color.Black;
            this.lblLevels.Font = new System.Drawing.Font("Copperplate Gothic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLevels.ForeColor = System.Drawing.Color.Gold;
            this.lblLevels.Location = new System.Drawing.Point(5, 5);
            this.lblLevels.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblLevels.Name = "lblLevels";
            this.lblLevels.Padding = new System.Windows.Forms.Padding(5);
            this.lblLevels.Size = new System.Drawing.Size(204, 28);
            this.lblLevels.TabIndex = 10;
            this.lblLevels.Text = "Levels";
            this.lblLevels.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvLevels
            // 
            this.dgvLevels.AllowUserToAddRows = false;
            this.dgvLevels.AllowUserToDeleteRows = false;
            this.dgvLevels.AllowUserToResizeColumns = false;
            this.dgvLevels.AllowUserToResizeRows = false;
            this.dgvLevels.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Lime;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLevels.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvLevels.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLevels.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colLevelID,
            this.colLevelName,
            this.colLevelScore});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Lime;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvLevels.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvLevels.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvLevels.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvLevels.Location = new System.Drawing.Point(5, 38);
            this.dgvLevels.Margin = new System.Windows.Forms.Padding(5);
            this.dgvLevels.MultiSelect = false;
            this.dgvLevels.Name = "dgvLevels";
            this.dgvLevels.ReadOnly = true;
            this.dgvLevels.RowHeadersVisible = false;
            this.dgvLevels.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvLevels.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLevels.ShowCellErrors = false;
            this.dgvLevels.ShowCellToolTips = false;
            this.dgvLevels.ShowEditingIcon = false;
            this.dgvLevels.ShowRowErrors = false;
            this.dgvLevels.Size = new System.Drawing.Size(204, 122);
            this.dgvLevels.TabIndex = 1;
            this.dgvLevels.SelectionChanged += new System.EventHandler(this.dgvLevels_SelectionChanged);
            // 
            // colLevelID
            // 
            this.colLevelID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colLevelID.FillWeight = 1F;
            this.colLevelID.HeaderText = "ID";
            this.colLevelID.Name = "colLevelID";
            this.colLevelID.ReadOnly = true;
            this.colLevelID.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colLevelID.Visible = false;
            // 
            // colLevelName
            // 
            this.colLevelName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colLevelName.FillWeight = 70F;
            this.colLevelName.HeaderText = "Name";
            this.colLevelName.Name = "colLevelName";
            this.colLevelName.ReadOnly = true;
            this.colLevelName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // colLevelScore
            // 
            this.colLevelScore.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colLevelScore.FillWeight = 30F;
            this.colLevelScore.HeaderText = "Score";
            this.colLevelScore.Name = "colLevelScore";
            this.colLevelScore.ReadOnly = true;
            this.colLevelScore.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // btnNew
            // 
            this.btnNew.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnNew.AutoSize = true;
            this.btnNew.BackColor = System.Drawing.Color.DarkGreen;
            this.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNew.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.ForeColor = System.Drawing.Color.Gold;
            this.btnNew.Location = new System.Drawing.Point(5, 67);
            this.btnNew.Margin = new System.Windows.Forms.Padding(5);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(48, 32);
            this.btnNew.TabIndex = 0;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = false;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // lblName
            // 
            this.lblName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.Black;
            this.lblName.Font = new System.Drawing.Font("Copperplate Gothic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.Gold;
            this.lblName.Location = new System.Drawing.Point(5, 5);
            this.lblName.Margin = new System.Windows.Forms.Padding(5, 5, 0, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(63, 26);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Name";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtName
            // 
            this.txtName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtName.BackColor = System.Drawing.Color.White;
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tlpData.SetColumnSpan(this.txtName, 2);
            this.txtName.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold);
            this.txtName.ForeColor = System.Drawing.Color.Black;
            this.txtName.Location = new System.Drawing.Point(68, 5);
            this.txtName.Margin = new System.Windows.Forms.Padding(0, 5, 5, 0);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(141, 26);
            this.txtName.TabIndex = 0;
            // 
            // lblScore
            // 
            this.lblScore.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblScore.AutoSize = true;
            this.lblScore.BackColor = System.Drawing.Color.Black;
            this.lblScore.Font = new System.Drawing.Font("Copperplate Gothic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.ForeColor = System.Drawing.Color.Gold;
            this.lblScore.Location = new System.Drawing.Point(5, 36);
            this.lblScore.Margin = new System.Windows.Forms.Padding(5, 5, 0, 0);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(63, 26);
            this.lblScore.TabIndex = 5;
            this.lblScore.Text = "Score";
            this.lblScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnSave.AutoSize = true;
            this.btnSave.BackColor = System.Drawing.Color.DarkGreen;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.Gold;
            this.btnSave.Location = new System.Drawing.Point(156, 67);
            this.btnSave.Margin = new System.Windows.Forms.Padding(5);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(53, 32);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // tlpMain
            // 
            this.tlpMain.ColumnCount = 1;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.Controls.Add(this.tlpList, 0, 0);
            this.tlpMain.Controls.Add(this.tlpData, 0, 1);
            this.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMain.Location = new System.Drawing.Point(5, 5);
            this.tlpMain.Margin = new System.Windows.Forms.Padding(0);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.RowCount = 2;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpMain.Size = new System.Drawing.Size(214, 274);
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
            this.tlpData.Controls.Add(this.lblName, 0, 0);
            this.tlpData.Controls.Add(this.btnNew, 0, 2);
            this.tlpData.Controls.Add(this.btnSave, 2, 2);
            this.tlpData.Controls.Add(this.lblScore, 0, 1);
            this.tlpData.Controls.Add(this.nudScore, 1, 1);
            this.tlpData.Controls.Add(this.txtName, 1, 0);
            this.tlpData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpData.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.tlpData.Location = new System.Drawing.Point(0, 170);
            this.tlpData.Margin = new System.Windows.Forms.Padding(0);
            this.tlpData.Name = "tlpData";
            this.tlpData.RowCount = 3;
            this.tlpData.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpData.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpData.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpData.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpData.Size = new System.Drawing.Size(214, 104);
            this.tlpData.TabIndex = 1;
            // 
            // nudScore
            // 
            this.nudScore.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.nudScore.BackColor = System.Drawing.Color.White;
            this.nudScore.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nudScore.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold);
            this.nudScore.ForeColor = System.Drawing.Color.Black;
            this.nudScore.Location = new System.Drawing.Point(68, 36);
            this.nudScore.Margin = new System.Windows.Forms.Padding(0, 5, 5, 0);
            this.nudScore.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.nudScore.Name = "nudScore";
            this.nudScore.Size = new System.Drawing.Size(50, 26);
            this.nudScore.TabIndex = 13;
            this.nudScore.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // frmLevels
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(224, 284);
            this.Controls.Add(this.tlpMain);
            this.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = Properties.Resources.logo;
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLevels";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Levels Management";
            this.TopMost = true;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmLevels_FormClosed);
            this.Load += new System.EventHandler(this.frmLevels_Load);
            this.tlpList.ResumeLayout(false);
            this.tlpList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLevels)).EndInit();
            this.tlpMain.ResumeLayout(false);
            this.tlpMain.PerformLayout();
            this.tlpData.ResumeLayout(false);
            this.tlpData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudScore)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpList;
        private System.Windows.Forms.DataGridView dgvLevels;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblLevels;
        private System.Windows.Forms.TableLayoutPanel tlpMain;
        private System.Windows.Forms.TableLayoutPanel tlpData;
        private System.Windows.Forms.NumericUpDown nudScore;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLevelID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLevelName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLevelScore;
    }
}
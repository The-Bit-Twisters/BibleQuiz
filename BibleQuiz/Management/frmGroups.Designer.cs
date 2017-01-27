namespace BibleQuiz.Management
{
    partial class frmGroups
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tlpMain = new System.Windows.Forms.TableLayoutPanel();
            this.tlpList = new System.Windows.Forms.TableLayoutPanel();
            this.lblGroups = new System.Windows.Forms.Label();
            this.dgvGroups = new System.Windows.Forms.DataGridView();
            this.colGroupID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGroupName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tlpData = new System.Windows.Forms.TableLayoutPanel();
            this.btnRemoveMember = new System.Windows.Forms.Button();
            this.btnAddMember = new System.Windows.Forms.Button();
            this.dgvMembers = new System.Windows.Forms.DataGridView();
            this.colMemberID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMemberName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblMembers = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnEditMember = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.tlpMain.SuspendLayout();
            this.tlpList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGroups)).BeginInit();
            this.tlpData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMembers)).BeginInit();
            this.SuspendLayout();
            // 
            // tlpMain
            // 
            this.tlpMain.ColumnCount = 2;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tlpMain.Controls.Add(this.tlpList, 0, 0);
            this.tlpMain.Controls.Add(this.tlpData, 1, 0);
            this.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMain.Location = new System.Drawing.Point(5, 5);
            this.tlpMain.Margin = new System.Windows.Forms.Padding(0);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.RowCount = 1;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.Size = new System.Drawing.Size(394, 234);
            this.tlpMain.TabIndex = 2;
            // 
            // tlpList
            // 
            this.tlpList.BackColor = System.Drawing.Color.Gold;
            this.tlpList.ColumnCount = 1;
            this.tlpList.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpList.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            this.tlpList.Controls.Add(this.lblGroups, 0, 0);
            this.tlpList.Controls.Add(this.dgvGroups, 0, 1);
            this.tlpList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpList.Location = new System.Drawing.Point(0, 0);
            this.tlpList.Margin = new System.Windows.Forms.Padding(0);
            this.tlpList.Name = "tlpList";
            this.tlpList.RowCount = 2;
            this.tlpList.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpList.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpList.Size = new System.Drawing.Size(157, 234);
            this.tlpList.TabIndex = 0;
            // 
            // lblGroups
            // 
            this.lblGroups.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblGroups.AutoSize = true;
            this.lblGroups.BackColor = System.Drawing.Color.Black;
            this.lblGroups.Font = new System.Drawing.Font("Copperplate Gothic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGroups.ForeColor = System.Drawing.Color.Gold;
            this.lblGroups.Location = new System.Drawing.Point(5, 5);
            this.lblGroups.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblGroups.Name = "lblGroups";
            this.lblGroups.Padding = new System.Windows.Forms.Padding(5);
            this.lblGroups.Size = new System.Drawing.Size(147, 28);
            this.lblGroups.TabIndex = 10;
            this.lblGroups.Text = "Groups";
            this.lblGroups.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvGroups
            // 
            this.dgvGroups.AllowUserToAddRows = false;
            this.dgvGroups.AllowUserToDeleteRows = false;
            this.dgvGroups.AllowUserToResizeColumns = false;
            this.dgvGroups.AllowUserToResizeRows = false;
            this.dgvGroups.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Lime;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvGroups.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvGroups.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGroups.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colGroupID,
            this.colGroupName});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Lime;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvGroups.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvGroups.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvGroups.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvGroups.Location = new System.Drawing.Point(5, 38);
            this.dgvGroups.Margin = new System.Windows.Forms.Padding(5);
            this.dgvGroups.MultiSelect = false;
            this.dgvGroups.Name = "dgvGroups";
            this.dgvGroups.ReadOnly = true;
            this.dgvGroups.RowHeadersVisible = false;
            this.dgvGroups.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvGroups.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvGroups.ShowCellErrors = false;
            this.dgvGroups.ShowCellToolTips = false;
            this.dgvGroups.ShowEditingIcon = false;
            this.dgvGroups.ShowRowErrors = false;
            this.dgvGroups.Size = new System.Drawing.Size(147, 191);
            this.dgvGroups.TabIndex = 1;
            this.dgvGroups.SelectionChanged += new System.EventHandler(this.dgvGroups_SelectionChanged);
            // 
            // colGroupID
            // 
            this.colGroupID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colGroupID.FillWeight = 1F;
            this.colGroupID.HeaderText = "ID";
            this.colGroupID.Name = "colGroupID";
            this.colGroupID.ReadOnly = true;
            this.colGroupID.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colGroupID.Visible = false;
            // 
            // colGroupName
            // 
            this.colGroupName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colGroupName.HeaderText = "Name";
            this.colGroupName.Name = "colGroupName";
            this.colGroupName.ReadOnly = true;
            this.colGroupName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // tlpData
            // 
            this.tlpData.AutoSize = true;
            this.tlpData.BackColor = System.Drawing.Color.Gold;
            this.tlpData.ColumnCount = 3;
            this.tlpData.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpData.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpData.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpData.Controls.Add(this.btnRemoveMember, 2, 3);
            this.tlpData.Controls.Add(this.btnAddMember, 0, 3);
            this.tlpData.Controls.Add(this.dgvMembers, 0, 2);
            this.tlpData.Controls.Add(this.lblName, 0, 0);
            this.tlpData.Controls.Add(this.txtName, 1, 0);
            this.tlpData.Controls.Add(this.lblMembers, 0, 1);
            this.tlpData.Controls.Add(this.btnSave, 2, 4);
            this.tlpData.Controls.Add(this.btnEditMember, 1, 3);
            this.tlpData.Controls.Add(this.btnNew, 0, 4);
            this.tlpData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpData.Location = new System.Drawing.Point(162, 0);
            this.tlpData.Margin = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.tlpData.Name = "tlpData";
            this.tlpData.RowCount = 5;
            this.tlpData.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpData.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpData.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpData.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpData.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpData.Size = new System.Drawing.Size(232, 234);
            this.tlpData.TabIndex = 1;
            // 
            // btnRemoveMember
            // 
            this.btnRemoveMember.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemoveMember.AutoSize = true;
            this.btnRemoveMember.BackColor = System.Drawing.Color.DarkGreen;
            this.btnRemoveMember.FlatAppearance.BorderSize = 0;
            this.btnRemoveMember.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveMember.Font = new System.Drawing.Font("Impact", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveMember.ForeColor = System.Drawing.Color.Gold;
            this.btnRemoveMember.Location = new System.Drawing.Point(154, 167);
            this.btnRemoveMember.Margin = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.btnRemoveMember.Name = "btnRemoveMember";
            this.btnRemoveMember.Size = new System.Drawing.Size(73, 25);
            this.btnRemoveMember.TabIndex = 16;
            this.btnRemoveMember.Text = "Remove";
            this.btnRemoveMember.UseVisualStyleBackColor = false;
            this.btnRemoveMember.Click += new System.EventHandler(this.btnRemoveMember_Click);
            // 
            // btnAddMember
            // 
            this.btnAddMember.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddMember.AutoSize = true;
            this.btnAddMember.BackColor = System.Drawing.Color.DarkGreen;
            this.btnAddMember.FlatAppearance.BorderSize = 0;
            this.btnAddMember.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddMember.Font = new System.Drawing.Font("Impact", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddMember.ForeColor = System.Drawing.Color.Gold;
            this.btnAddMember.Location = new System.Drawing.Point(5, 167);
            this.btnAddMember.Margin = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnAddMember.Name = "btnAddMember";
            this.btnAddMember.Size = new System.Drawing.Size(72, 25);
            this.btnAddMember.TabIndex = 14;
            this.btnAddMember.Text = "Add";
            this.btnAddMember.UseVisualStyleBackColor = false;
            this.btnAddMember.Click += new System.EventHandler(this.btnAddMember_Click);
            // 
            // dgvMembers
            // 
            this.dgvMembers.AllowUserToAddRows = false;
            this.dgvMembers.AllowUserToDeleteRows = false;
            this.dgvMembers.AllowUserToResizeColumns = false;
            this.dgvMembers.AllowUserToResizeRows = false;
            this.dgvMembers.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Lime;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMembers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvMembers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMembers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMemberID,
            this.colMemberName});
            this.tlpData.SetColumnSpan(this.dgvMembers, 3);
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Lime;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMembers.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvMembers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMembers.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvMembers.Location = new System.Drawing.Point(5, 54);
            this.dgvMembers.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.dgvMembers.MultiSelect = false;
            this.dgvMembers.Name = "dgvMembers";
            this.dgvMembers.ReadOnly = true;
            this.dgvMembers.RowHeadersVisible = false;
            this.dgvMembers.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvMembers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMembers.ShowCellErrors = false;
            this.dgvMembers.ShowCellToolTips = false;
            this.dgvMembers.ShowEditingIcon = false;
            this.dgvMembers.ShowRowErrors = false;
            this.dgvMembers.Size = new System.Drawing.Size(222, 113);
            this.dgvMembers.TabIndex = 13;
            // 
            // colMemberID
            // 
            this.colMemberID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colMemberID.FillWeight = 1F;
            this.colMemberID.HeaderText = "ID";
            this.colMemberID.Name = "colMemberID";
            this.colMemberID.ReadOnly = true;
            this.colMemberID.Visible = false;
            // 
            // colMemberName
            // 
            this.colMemberName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colMemberName.HeaderText = "Full Name";
            this.colMemberName.Name = "colMemberName";
            this.colMemberName.ReadOnly = true;
            this.colMemberName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
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
            this.lblName.Size = new System.Drawing.Size(72, 26);
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
            this.txtName.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.ForeColor = System.Drawing.Color.Black;
            this.txtName.Location = new System.Drawing.Point(77, 5);
            this.txtName.Margin = new System.Windows.Forms.Padding(0, 5, 5, 0);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(150, 26);
            this.txtName.TabIndex = 0;
            // 
            // lblMembers
            // 
            this.lblMembers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMembers.AutoSize = true;
            this.lblMembers.BackColor = System.Drawing.Color.Black;
            this.tlpData.SetColumnSpan(this.lblMembers, 3);
            this.lblMembers.Font = new System.Drawing.Font("Copperplate Gothic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMembers.ForeColor = System.Drawing.Color.Gold;
            this.lblMembers.Location = new System.Drawing.Point(5, 36);
            this.lblMembers.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblMembers.Name = "lblMembers";
            this.lblMembers.Size = new System.Drawing.Size(222, 18);
            this.lblMembers.TabIndex = 5;
            this.lblMembers.Text = "Members";
            this.lblMembers.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.btnSave.Location = new System.Drawing.Point(173, 197);
            this.btnSave.Margin = new System.Windows.Forms.Padding(5);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(54, 32);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnEditMember
            // 
            this.btnEditMember.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditMember.AutoSize = true;
            this.btnEditMember.BackColor = System.Drawing.Color.DarkGreen;
            this.btnEditMember.FlatAppearance.BorderSize = 0;
            this.btnEditMember.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditMember.Font = new System.Drawing.Font("Impact", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditMember.ForeColor = System.Drawing.Color.Gold;
            this.btnEditMember.Location = new System.Drawing.Point(77, 167);
            this.btnEditMember.Margin = new System.Windows.Forms.Padding(0);
            this.btnEditMember.Name = "btnEditMember";
            this.btnEditMember.Size = new System.Drawing.Size(77, 25);
            this.btnEditMember.TabIndex = 15;
            this.btnEditMember.Text = "Edit";
            this.btnEditMember.UseVisualStyleBackColor = false;
            this.btnEditMember.Click += new System.EventHandler(this.btnEditMember_Click);
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
            this.btnNew.Location = new System.Drawing.Point(5, 197);
            this.btnNew.Margin = new System.Windows.Forms.Padding(5);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(53, 32);
            this.btnNew.TabIndex = 0;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = false;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // frmGroups
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(404, 244);
            this.Controls.Add(this.tlpMain);
            this.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = global::BibleQuiz.Properties.Resources.logo;
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmGroups";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Groups Management";
            this.TopMost = true;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmGroups_FormClosed);
            this.Load += new System.EventHandler(this.frmGroups_Load);
            this.tlpMain.ResumeLayout(false);
            this.tlpMain.PerformLayout();
            this.tlpList.ResumeLayout(false);
            this.tlpList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGroups)).EndInit();
            this.tlpData.ResumeLayout(false);
            this.tlpData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMembers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpMain;
        private System.Windows.Forms.TableLayoutPanel tlpList;
        private System.Windows.Forms.Label lblGroups;
        private System.Windows.Forms.DataGridView dgvGroups;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.TableLayoutPanel tlpData;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblMembers;
        private System.Windows.Forms.DataGridView dgvMembers;
        private System.Windows.Forms.Button btnAddMember;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnRemoveMember;
        private System.Windows.Forms.Button btnEditMember;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGroupID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGroupName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMemberID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMemberName;
    }
}
namespace BibleQuiz.Dialogs
{
    partial class SelectGame
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
            this.lblGames = new System.Windows.Forms.Label();
            this.btnSelect = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.dgvGames = new System.Windows.Forms.DataGridView();
            this.colGameID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGameSequence = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGameDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbxFilter = new System.Windows.Forms.ComboBox();
            this.tlpMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGames)).BeginInit();
            this.SuspendLayout();
            // 
            // tlpMain
            // 
            this.tlpMain.BackColor = System.Drawing.Color.Gold;
            this.tlpMain.ColumnCount = 2;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.Controls.Add(this.lblGames, 0, 0);
            this.tlpMain.Controls.Add(this.btnSelect, 1, 2);
            this.tlpMain.Controls.Add(this.btnCancel, 0, 2);
            this.tlpMain.Controls.Add(this.dgvGames, 0, 1);
            this.tlpMain.Controls.Add(this.cbxFilter, 1, 0);
            this.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMain.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.tlpMain.Location = new System.Drawing.Point(5, 5);
            this.tlpMain.Margin = new System.Windows.Forms.Padding(0);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.RowCount = 3;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpMain.Size = new System.Drawing.Size(210, 190);
            this.tlpMain.TabIndex = 3;
            // 
            // lblGames
            // 
            this.lblGames.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblGames.AutoSize = true;
            this.lblGames.BackColor = System.Drawing.Color.Black;
            this.lblGames.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblGames.Font = new System.Drawing.Font("Copperplate Gothic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGames.ForeColor = System.Drawing.Color.Gold;
            this.lblGames.Location = new System.Drawing.Point(5, 5);
            this.lblGames.Margin = new System.Windows.Forms.Padding(5, 5, 0, 0);
            this.lblGames.Name = "lblGames";
            this.lblGames.Padding = new System.Windows.Forms.Padding(5);
            this.lblGames.Size = new System.Drawing.Size(78, 30);
            this.lblGames.TabIndex = 11;
            this.lblGames.Text = "Games";
            this.lblGames.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSelect
            // 
            this.btnSelect.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnSelect.AutoSize = true;
            this.btnSelect.BackColor = System.Drawing.Color.DarkGreen;
            this.btnSelect.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSelect.FlatAppearance.BorderSize = 0;
            this.btnSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelect.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelect.ForeColor = System.Drawing.Color.Gold;
            this.btnSelect.Location = new System.Drawing.Point(145, 153);
            this.btnSelect.Margin = new System.Windows.Forms.Padding(5);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(60, 32);
            this.btnSelect.TabIndex = 12;
            this.btnSelect.Text = "Select";
            this.btnSelect.UseVisualStyleBackColor = false;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnCancel.AutoSize = true;
            this.btnCancel.BackColor = System.Drawing.Color.DarkGreen;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.Gold;
            this.btnCancel.Location = new System.Drawing.Point(5, 153);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(5);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(64, 32);
            this.btnCancel.TabIndex = 14;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // dgvGames
            // 
            this.dgvGames.AllowUserToAddRows = false;
            this.dgvGames.AllowUserToDeleteRows = false;
            this.dgvGames.AllowUserToResizeColumns = false;
            this.dgvGames.AllowUserToResizeRows = false;
            this.dgvGames.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Lime;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvGames.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvGames.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGames.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colGameID,
            this.colGameSequence,
            this.colGameDate});
            this.tlpMain.SetColumnSpan(this.dgvGames, 2);
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
            this.dgvGames.Location = new System.Drawing.Point(5, 40);
            this.dgvGames.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.dgvGames.MultiSelect = false;
            this.dgvGames.Name = "dgvGames";
            this.dgvGames.ReadOnly = true;
            this.dgvGames.RowHeadersVisible = false;
            this.dgvGames.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvGames.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvGames.ShowCellErrors = false;
            this.dgvGames.ShowCellToolTips = false;
            this.dgvGames.ShowEditingIcon = false;
            this.dgvGames.ShowRowErrors = false;
            this.dgvGames.Size = new System.Drawing.Size(200, 108);
            this.dgvGames.TabIndex = 15;
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
            this.colGameSequence.FillWeight = 25F;
            this.colGameSequence.HeaderText = "No.";
            this.colGameSequence.Name = "colGameSequence";
            this.colGameSequence.ReadOnly = true;
            this.colGameSequence.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // colGameDate
            // 
            this.colGameDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colGameDate.FillWeight = 75F;
            this.colGameDate.HeaderText = "Date";
            this.colGameDate.Name = "colGameDate";
            this.colGameDate.ReadOnly = true;
            this.colGameDate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // cbxFilter
            // 
            this.cbxFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxFilter.BackColor = System.Drawing.Color.White;
            this.cbxFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxFilter.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbxFilter.ForeColor = System.Drawing.Color.Black;
            this.cbxFilter.FormattingEnabled = true;
            this.cbxFilter.Items.AddRange(new object[] {
            "All",
            "Finished",
            "Unfinished"});
            this.cbxFilter.Location = new System.Drawing.Point(83, 6);
            this.cbxFilter.Margin = new System.Windows.Forms.Padding(0, 5, 5, 0);
            this.cbxFilter.Name = "cbxFilter";
            this.cbxFilter.Size = new System.Drawing.Size(122, 28);
            this.cbxFilter.TabIndex = 0;
            this.cbxFilter.SelectedIndexChanged += new System.EventHandler(this.cbxFilter_SelectedIndexChanged);
            // 
            // SelectGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(220, 200);
            this.ControlBox = false;
            this.Controls.Add(this.tlpMain);
            this.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = global::BibleQuiz.Properties.Resources.logo;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SelectGame";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Select Game";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.SelectGame_Load);
            this.tlpMain.ResumeLayout(false);
            this.tlpMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGames)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpMain;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Label lblGames;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.DataGridView dgvGames;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGameID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGameSequence;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGameDate;
        private System.Windows.Forms.ComboBox cbxFilter;
    }
}
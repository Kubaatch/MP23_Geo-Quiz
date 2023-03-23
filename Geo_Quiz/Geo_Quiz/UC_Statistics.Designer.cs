namespace Geo_Quiz
{
    partial class UC_Statistics
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.F_Category = new System.Windows.Forms.ComboBox();
            this.F_Continents = new System.Windows.Forms.ComboBox();
            this.B_SaveFilters = new System.Windows.Forms.Button();
            this.B_Exit = new System.Windows.Forms.Button();
            this.L_Filters = new System.Windows.Forms.Label();
            this.F_Username = new System.Windows.Forms.ComboBox();
            this.B_GameMode = new System.Windows.Forms.Button();
            this.L_Header = new System.Windows.Forms.Label();
            this.StatsTable = new System.Windows.Forms.DataGridView();
            this.B_ResetFilters = new System.Windows.Forms.Button();
            this.L_Username = new System.Windows.Forms.Label();
            this.L_Category = new System.Windows.Forms.Label();
            this.L_Continents = new System.Windows.Forms.Label();
            this.F_QCount = new System.Windows.Forms.ComboBox();
            this.L_QCount = new System.Windows.Forms.Label();
            this.Username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Score = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Avg_Score = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Continents = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StatsTable)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tableLayoutPanel1.BackgroundImage = global::Geo_Quiz.Properties.Resources.WorldMap_tp;
            this.tableLayoutPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.050286F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.77168F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.77168F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.77168F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.77168F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.863F));
            this.tableLayoutPanel1.Controls.Add(this.F_Category, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.F_Continents, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.B_SaveFilters, 5, 2);
            this.tableLayoutPanel1.Controls.Add(this.B_Exit, 5, 4);
            this.tableLayoutPanel1.Controls.Add(this.L_Filters, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.F_Username, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.B_GameMode, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.L_Header, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.StatsTable, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.B_ResetFilters, 5, 3);
            this.tableLayoutPanel1.Controls.Add(this.L_Username, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.L_Category, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.L_Continents, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.F_QCount, 4, 2);
            this.tableLayoutPanel1.Controls.Add(this.L_QCount, 4, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1000, 625);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // F_Category
            // 
            this.F_Category.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.F_Category.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.F_Category.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.F_Category.FormattingEnabled = true;
            this.F_Category.Location = new System.Drawing.Point(290, 103);
            this.F_Category.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.F_Category.Name = "F_Category";
            this.F_Category.Size = new System.Drawing.Size(191, 27);
            this.F_Category.TabIndex = 18;
            this.F_Category.SelectedValueChanged += new System.EventHandler(this.F_Category_SelectedValueChanged);
            // 
            // F_Continents
            // 
            this.F_Continents.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.F_Continents.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.F_Continents.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.F_Continents.FormattingEnabled = true;
            this.F_Continents.Location = new System.Drawing.Point(487, 103);
            this.F_Continents.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.F_Continents.Name = "F_Continents";
            this.F_Continents.Size = new System.Drawing.Size(191, 27);
            this.F_Continents.TabIndex = 17;
            this.F_Continents.SelectedValueChanged += new System.EventHandler(this.F_Continents_SelectedValueChanged);
            // 
            // B_SaveFilters
            // 
            this.B_SaveFilters.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.B_SaveFilters.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B_SaveFilters.ForeColor = System.Drawing.Color.Black;
            this.B_SaveFilters.Location = new System.Drawing.Point(885, 103);
            this.B_SaveFilters.Name = "B_SaveFilters";
            this.B_SaveFilters.Size = new System.Drawing.Size(107, 42);
            this.B_SaveFilters.TabIndex = 15;
            this.B_SaveFilters.Text = "Save filters";
            this.B_SaveFilters.UseVisualStyleBackColor = true;
            this.B_SaveFilters.Click += new System.EventHandler(this.B_SaveFilters_Click);
            // 
            // B_Exit
            // 
            this.B_Exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.B_Exit.AutoSize = true;
            this.B_Exit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.B_Exit.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.B_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B_Exit.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B_Exit.ForeColor = System.Drawing.SystemColors.GrayText;
            this.B_Exit.Location = new System.Drawing.Point(915, 580);
            this.B_Exit.Margin = new System.Windows.Forms.Padding(2, 2, 10, 10);
            this.B_Exit.Name = "B_Exit";
            this.B_Exit.Size = new System.Drawing.Size(75, 35);
            this.B_Exit.TabIndex = 6;
            this.B_Exit.Text = "Return";
            this.B_Exit.UseVisualStyleBackColor = false;
            this.B_Exit.Click += new System.EventHandler(this.B_Exit_Click);
            // 
            // L_Filters
            // 
            this.L_Filters.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.L_Filters.AutoSize = true;
            this.L_Filters.BackColor = System.Drawing.SystemColors.ControlLight;
            this.L_Filters.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_Filters.Location = new System.Drawing.Point(16, 100);
            this.L_Filters.Margin = new System.Windows.Forms.Padding(3, 0, 3, 10);
            this.L_Filters.Name = "L_Filters";
            this.L_Filters.Size = new System.Drawing.Size(71, 24);
            this.L_Filters.TabIndex = 8;
            this.L_Filters.Text = "Filters: ";
            // 
            // F_Username
            // 
            this.F_Username.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.F_Username.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.F_Username.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.F_Username.FormattingEnabled = true;
            this.F_Username.Location = new System.Drawing.Point(93, 103);
            this.F_Username.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.F_Username.Name = "F_Username";
            this.F_Username.Size = new System.Drawing.Size(191, 27);
            this.F_Username.TabIndex = 16;
            this.F_Username.SelectedValueChanged += new System.EventHandler(this.F_Username_SelectedValueChanged);
            // 
            // B_GameMode
            // 
            this.B_GameMode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.B_GameMode.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B_GameMode.Location = new System.Drawing.Point(487, 23);
            this.B_GameMode.Margin = new System.Windows.Forms.Padding(3, 3, 3, 20);
            this.B_GameMode.Name = "B_GameMode";
            this.B_GameMode.Size = new System.Drawing.Size(186, 37);
            this.B_GameMode.TabIndex = 20;
            this.B_GameMode.Text = "temp";
            this.B_GameMode.UseVisualStyleBackColor = true;
            this.B_GameMode.Click += new System.EventHandler(this.B_GameMode_Click);
            // 
            // L_Header
            // 
            this.L_Header.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.L_Header.AutoSize = true;
            this.L_Header.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tableLayoutPanel1.SetColumnSpan(this.L_Header, 3);
            this.L_Header.Font = new System.Drawing.Font("Microsoft YaHei", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_Header.Location = new System.Drawing.Point(112, 23);
            this.L_Header.Margin = new System.Windows.Forms.Padding(3, 3, 3, 20);
            this.L_Header.Name = "L_Header";
            this.L_Header.Size = new System.Drawing.Size(369, 37);
            this.L_Header.TabIndex = 9;
            this.L_Header.Text = "Statistics for gamemode:";
            // 
            // StatsTable
            // 
            this.StatsTable.AllowUserToAddRows = false;
            this.StatsTable.AllowUserToDeleteRows = false;
            this.StatsTable.AllowUserToResizeColumns = false;
            this.StatsTable.AllowUserToResizeRows = false;
            this.StatsTable.Anchor = System.Windows.Forms.AnchorStyles.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.StatsTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.StatsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StatsTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Username,
            this.Score,
            this.Avg_Score,
            this.TotalTime,
            this.QCount,
            this.Category,
            this.Continents});
            this.tableLayoutPanel1.SetColumnSpan(this.StatsTable, 4);
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.StatsTable.DefaultCellStyle = dataGridViewCellStyle2;
            this.StatsTable.Location = new System.Drawing.Point(93, 153);
            this.StatsTable.Name = "StatsTable";
            this.StatsTable.RowHeadersVisible = false;
            this.StatsTable.RowHeadersWidth = 51;
            this.StatsTable.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatsTable.RowTemplate.Height = 24;
            this.StatsTable.RowTemplate.ReadOnly = true;
            this.StatsTable.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.StatsTable.ShowCellToolTips = false;
            this.StatsTable.ShowEditingIcon = false;
            this.StatsTable.Size = new System.Drawing.Size(782, 419);
            this.StatsTable.TabIndex = 7;
            // 
            // B_ResetFilters
            // 
            this.B_ResetFilters.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.B_ResetFilters.Font = new System.Drawing.Font("Microsoft YaHei", 7.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B_ResetFilters.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.B_ResetFilters.Location = new System.Drawing.Point(881, 153);
            this.B_ResetFilters.Name = "B_ResetFilters";
            this.B_ResetFilters.Size = new System.Drawing.Size(115, 48);
            this.B_ResetFilters.TabIndex = 14;
            this.B_ResetFilters.Text = "Reset filters";
            this.B_ResetFilters.UseVisualStyleBackColor = true;
            this.B_ResetFilters.Click += new System.EventHandler(this.B_ResetFilters_Click);
            // 
            // L_Username
            // 
            this.L_Username.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.L_Username.AutoSize = true;
            this.L_Username.BackColor = System.Drawing.SystemColors.ControlLight;
            this.L_Username.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_Username.Location = new System.Drawing.Point(143, 81);
            this.L_Username.Margin = new System.Windows.Forms.Padding(0);
            this.L_Username.Name = "L_Username";
            this.L_Username.Size = new System.Drawing.Size(91, 19);
            this.L_Username.TabIndex = 21;
            this.L_Username.Text = "By username:";
            // 
            // L_Category
            // 
            this.L_Category.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.L_Category.AutoSize = true;
            this.L_Category.BackColor = System.Drawing.SystemColors.ControlLight;
            this.L_Category.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_Category.Location = new System.Drawing.Point(343, 81);
            this.L_Category.Margin = new System.Windows.Forms.Padding(0);
            this.L_Category.Name = "L_Category";
            this.L_Category.Size = new System.Drawing.Size(85, 19);
            this.L_Category.TabIndex = 22;
            this.L_Category.Text = "By category:";
            // 
            // L_Continents
            // 
            this.L_Continents.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.L_Continents.AutoSize = true;
            this.L_Continents.BackColor = System.Drawing.SystemColors.ControlLight;
            this.L_Continents.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_Continents.Location = new System.Drawing.Point(533, 81);
            this.L_Continents.Margin = new System.Windows.Forms.Padding(0);
            this.L_Continents.Name = "L_Continents";
            this.L_Continents.Size = new System.Drawing.Size(99, 19);
            this.L_Continents.TabIndex = 23;
            this.L_Continents.Text = "By continent/s";
            // 
            // F_QCount
            // 
            this.F_QCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.F_QCount.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.F_QCount.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.F_QCount.FormattingEnabled = true;
            this.F_QCount.Location = new System.Drawing.Point(684, 103);
            this.F_QCount.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.F_QCount.Name = "F_QCount";
            this.F_QCount.Size = new System.Drawing.Size(191, 27);
            this.F_QCount.TabIndex = 19;
            this.F_QCount.SelectedValueChanged += new System.EventHandler(this.F_QCount_SelectedValueChanged);
            // 
            // L_QCount
            // 
            this.L_QCount.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.L_QCount.AutoSize = true;
            this.L_QCount.BackColor = System.Drawing.SystemColors.ControlLight;
            this.L_QCount.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_QCount.Location = new System.Drawing.Point(717, 81);
            this.L_QCount.Margin = new System.Windows.Forms.Padding(0);
            this.L_QCount.Name = "L_QCount";
            this.L_QCount.Size = new System.Drawing.Size(124, 19);
            this.L_QCount.TabIndex = 24;
            this.L_QCount.Text = "By question count:";
            // 
            // Username
            // 
            this.Username.HeaderText = "Username";
            this.Username.MinimumWidth = 6;
            this.Username.Name = "Username";
            this.Username.ReadOnly = true;
            this.Username.Width = 110;
            // 
            // Score
            // 
            this.Score.HeaderText = "Score";
            this.Score.MinimumWidth = 6;
            this.Score.Name = "Score";
            this.Score.ReadOnly = true;
            this.Score.Width = 60;
            // 
            // Avg_Score
            // 
            this.Avg_Score.HeaderText = "Average score";
            this.Avg_Score.MinimumWidth = 6;
            this.Avg_Score.Name = "Avg_Score";
            this.Avg_Score.ReadOnly = true;
            this.Avg_Score.Width = 65;
            // 
            // TotalTime
            // 
            this.TotalTime.HeaderText = "Total time";
            this.TotalTime.MinimumWidth = 6;
            this.TotalTime.Name = "TotalTime";
            this.TotalTime.ReadOnly = true;
            this.TotalTime.Width = 130;
            // 
            // QCount
            // 
            this.QCount.HeaderText = "Question count";
            this.QCount.MinimumWidth = 6;
            this.QCount.Name = "QCount";
            this.QCount.ReadOnly = true;
            this.QCount.Width = 60;
            // 
            // Category
            // 
            this.Category.HeaderText = "Category";
            this.Category.MinimumWidth = 6;
            this.Category.Name = "Category";
            this.Category.ReadOnly = true;
            this.Category.Width = 80;
            // 
            // Continents
            // 
            this.Continents.HeaderText = "Continent/s";
            this.Continents.MinimumWidth = 6;
            this.Continents.Name = "Continents";
            this.Continents.ReadOnly = true;
            this.Continents.Width = 110;
            // 
            // UC_Statistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "UC_Statistics";
            this.Size = new System.Drawing.Size(1000, 625);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StatsTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button B_Exit;
        private System.Windows.Forms.DataGridView StatsTable;
        private System.Windows.Forms.Label L_Filters;
        private System.Windows.Forms.Label L_Header;
        private System.Windows.Forms.Button B_ResetFilters;
        private System.Windows.Forms.Button B_SaveFilters;
        private System.Windows.Forms.ComboBox F_Category;
        private System.Windows.Forms.ComboBox F_Continents;
        private System.Windows.Forms.ComboBox F_Username;
        private System.Windows.Forms.ComboBox F_QCount;
        private System.Windows.Forms.Button B_GameMode;
        private System.Windows.Forms.Label L_Username;
        private System.Windows.Forms.Label L_Category;
        private System.Windows.Forms.Label L_Continents;
        private System.Windows.Forms.Label L_QCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Username;
        private System.Windows.Forms.DataGridViewTextBoxColumn Score;
        private System.Windows.Forms.DataGridViewTextBoxColumn Avg_Score;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn QCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Category;
        private System.Windows.Forms.DataGridViewTextBoxColumn Continents;
    }
}

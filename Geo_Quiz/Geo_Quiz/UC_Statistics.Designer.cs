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
            this.components = new System.ComponentModel.Container();
            this.B_SaveReturn = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.B_DiscardReturn = new System.Windows.Forms.Button();
            this.L_Statistics = new System.Windows.Forms.Label();
            this.L_QuizEnd = new System.Windows.Forms.Label();
            this.L_TimeSpent = new System.Windows.Forms.Label();
            this.L_Score = new System.Windows.Forms.Label();
            this.L_AvgScore = new System.Windows.Forms.Label();
            this.TT_PopUp = new System.Windows.Forms.ToolTip(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Score = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Avg_Score = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Time_Spent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // B_SaveReturn
            // 
            this.B_SaveReturn.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.B_SaveReturn.AutoSize = true;
            this.B_SaveReturn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.B_SaveReturn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.B_SaveReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B_SaveReturn.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B_SaveReturn.ForeColor = System.Drawing.SystemColors.GrayText;
            this.B_SaveReturn.Location = new System.Drawing.Point(510, 572);
            this.B_SaveReturn.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.B_SaveReturn.Name = "B_SaveReturn";
            this.B_SaveReturn.Size = new System.Drawing.Size(153, 35);
            this.B_SaveReturn.TabIndex = 6;
            this.B_SaveReturn.Text = "Save and Return";
            this.TT_PopUp.SetToolTip(this.B_SaveReturn, "Clicking this button saves all your stats connected to your current account.\nOh a" +
        "nd it returns you back to the main menu.");
            this.B_SaveReturn.UseVisualStyleBackColor = false;
            this.B_SaveReturn.Click += new System.EventHandler(this.B_SaveReturn_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.B_DiscardReturn, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.L_Statistics, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.B_SaveReturn, 1, 8);
            this.tableLayoutPanel1.Controls.Add(this.L_QuizEnd, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.L_TimeSpent, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.L_Score, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.L_AvgScore, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.dataGridView1, 0, 7);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 10;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1000, 625);
            this.tableLayoutPanel1.TabIndex = 7;
            // 
            // B_DiscardReturn
            // 
            this.B_DiscardReturn.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.B_DiscardReturn.AutoSize = true;
            this.B_DiscardReturn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.B_DiscardReturn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.B_DiscardReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B_DiscardReturn.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B_DiscardReturn.ForeColor = System.Drawing.SystemColors.GrayText;
            this.B_DiscardReturn.Location = new System.Drawing.Point(314, 572);
            this.B_DiscardReturn.Margin = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.B_DiscardReturn.Name = "B_DiscardReturn";
            this.B_DiscardReturn.Size = new System.Drawing.Size(176, 35);
            this.B_DiscardReturn.TabIndex = 10;
            this.B_DiscardReturn.Text = "Discard and Return";
            this.TT_PopUp.SetToolTip(this.B_DiscardReturn, "Clicking this button deletes all stats without saving them. Choose wisely!\nOh and" +
        " it returns you back to the main menu.");
            this.B_DiscardReturn.UseVisualStyleBackColor = false;
            this.B_DiscardReturn.Click += new System.EventHandler(this.B_DiscardReturn_Click);
            // 
            // L_Statistics
            // 
            this.L_Statistics.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.L_Statistics.AutoSize = true;
            this.L_Statistics.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tableLayoutPanel1.SetColumnSpan(this.L_Statistics, 2);
            this.L_Statistics.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_Statistics.Location = new System.Drawing.Point(412, 160);
            this.L_Statistics.Name = "L_Statistics";
            this.L_Statistics.Size = new System.Drawing.Size(175, 27);
            this.L_Statistics.TabIndex = 1;
            this.L_Statistics.Text = "Here\'s your stats:";
            // 
            // L_QuizEnd
            // 
            this.L_QuizEnd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.L_QuizEnd.AutoSize = true;
            this.L_QuizEnd.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tableLayoutPanel1.SetColumnSpan(this.L_QuizEnd, 2);
            this.L_QuizEnd.Font = new System.Drawing.Font("Microsoft YaHei UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_QuizEnd.Location = new System.Drawing.Point(368, 104);
            this.L_QuizEnd.Name = "L_QuizEnd";
            this.L_QuizEnd.Size = new System.Drawing.Size(264, 52);
            this.L_QuizEnd.TabIndex = 0;
            this.L_QuizEnd.Text = "End of quiz!";
            // 
            // L_TimeSpent
            // 
            this.L_TimeSpent.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.L_TimeSpent.AutoSize = true;
            this.L_TimeSpent.BackColor = System.Drawing.SystemColors.Menu;
            this.tableLayoutPanel1.SetColumnSpan(this.L_TimeSpent, 2);
            this.L_TimeSpent.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_TimeSpent.Location = new System.Drawing.Point(419, 350);
            this.L_TimeSpent.Name = "L_TimeSpent";
            this.L_TimeSpent.Size = new System.Drawing.Size(161, 30);
            this.L_TimeSpent.TabIndex = 9;
            this.L_TimeSpent.Text = "Time played: ";
            // 
            // L_Score
            // 
            this.L_Score.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.L_Score.AutoSize = true;
            this.L_Score.BackColor = System.Drawing.SystemColors.Menu;
            this.tableLayoutPanel1.SetColumnSpan(this.L_Score, 2);
            this.L_Score.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_Score.Location = new System.Drawing.Point(425, 250);
            this.L_Score.Name = "L_Score";
            this.L_Score.Size = new System.Drawing.Size(149, 30);
            this.L_Score.TabIndex = 8;
            this.L_Score.Text = "Total score: ";
            // 
            // L_AvgScore
            // 
            this.L_AvgScore.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.L_AvgScore.AutoSize = true;
            this.L_AvgScore.BackColor = System.Drawing.SystemColors.Menu;
            this.tableLayoutPanel1.SetColumnSpan(this.L_AvgScore, 2);
            this.L_AvgScore.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_AvgScore.Location = new System.Drawing.Point(382, 300);
            this.L_AvgScore.Name = "L_AvgScore";
            this.L_AvgScore.Size = new System.Drawing.Size(236, 30);
            this.L_AvgScore.TabIndex = 7;
            this.L_AvgScore.Text = "Score per question: ";
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Username,
            this.Score,
            this.Avg_Score,
            this.Time_Spent,
            this.QCount,
            this.Category});
            this.tableLayoutPanel1.SetColumnSpan(this.dataGridView1, 2);
            this.dataGridView1.Location = new System.Drawing.Point(98, 402);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(803, 150);
            this.dataGridView1.TabIndex = 11;
            // 
            // Username
            // 
            this.Username.HeaderText = "Username";
            this.Username.MinimumWidth = 6;
            this.Username.Name = "Username";
            this.Username.ReadOnly = true;
            this.Username.Width = 125;
            // 
            // Score
            // 
            this.Score.HeaderText = "Score";
            this.Score.MinimumWidth = 6;
            this.Score.Name = "Score";
            this.Score.ReadOnly = true;
            this.Score.Width = 125;
            // 
            // Avg_Score
            // 
            this.Avg_Score.HeaderText = "Avg. score";
            this.Avg_Score.MinimumWidth = 6;
            this.Avg_Score.Name = "Avg_Score";
            this.Avg_Score.ReadOnly = true;
            this.Avg_Score.Width = 125;
            // 
            // Time_Spent
            // 
            this.Time_Spent.HeaderText = "Total time";
            this.Time_Spent.MinimumWidth = 6;
            this.Time_Spent.Name = "Time_Spent";
            this.Time_Spent.ReadOnly = true;
            this.Time_Spent.Width = 125;
            // 
            // QCount
            // 
            this.QCount.HeaderText = "Question Count";
            this.QCount.MinimumWidth = 6;
            this.QCount.Name = "QCount";
            this.QCount.ReadOnly = true;
            this.QCount.Width = 125;
            // 
            // Category
            // 
            this.Category.HeaderText = "Category";
            this.Category.MinimumWidth = 6;
            this.Category.Name = "Category";
            this.Category.ReadOnly = true;
            this.Category.Width = 125;
            // 
            // UC_Statistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "UC_Statistics";
            this.Size = new System.Drawing.Size(1000, 625);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button B_SaveReturn;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label L_Statistics;
        private System.Windows.Forms.Label L_QuizEnd;
        private System.Windows.Forms.Label L_AvgScore;
        private System.Windows.Forms.Label L_Score;
        private System.Windows.Forms.Label L_TimeSpent;
        private System.Windows.Forms.Button B_DiscardReturn;
        private System.Windows.Forms.ToolTip TT_PopUp;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Username;
        private System.Windows.Forms.DataGridViewTextBoxColumn Score;
        private System.Windows.Forms.DataGridViewTextBoxColumn Avg_Score;
        private System.Windows.Forms.DataGridViewTextBoxColumn Time_Spent;
        private System.Windows.Forms.DataGridViewTextBoxColumn QCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Category;
    }
}

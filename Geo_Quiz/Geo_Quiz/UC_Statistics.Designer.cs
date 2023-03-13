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
            this.B_Exit = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.L_Statistics = new System.Windows.Forms.Label();
            this.L_QuizEnd = new System.Windows.Forms.Label();
            this.L_TimeSpent = new System.Windows.Forms.Label();
            this.L_Score = new System.Windows.Forms.Label();
            this.L_AvgScore = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
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
            this.B_Exit.Location = new System.Drawing.Point(842, 580);
            this.B_Exit.Margin = new System.Windows.Forms.Padding(0, 0, 10, 10);
            this.B_Exit.Name = "B_Exit";
            this.B_Exit.Size = new System.Drawing.Size(148, 35);
            this.B_Exit.TabIndex = 6;
            this.B_Exit.Text = "Return to menu";
            this.B_Exit.UseVisualStyleBackColor = false;
            this.B_Exit.Click += new System.EventHandler(this.B_Exit_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.L_Statistics, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.B_Exit, 1, 9);
            this.tableLayoutPanel1.Controls.Add(this.L_QuizEnd, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.L_TimeSpent, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.L_Score, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.L_AvgScore, 0, 5);
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
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1000, 625);
            this.tableLayoutPanel1.TabIndex = 7;
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
            this.L_Score.Location = new System.Drawing.Point(403, 250);
            this.L_Score.Name = "L_Score";
            this.L_Score.Size = new System.Drawing.Size(194, 30);
            this.L_Score.TabIndex = 8;
            this.L_Score.Text = "In total you got ";
            // 
            // L_AvgScore
            // 
            this.L_AvgScore.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.L_AvgScore.AutoSize = true;
            this.L_AvgScore.BackColor = System.Drawing.SystemColors.Menu;
            this.tableLayoutPanel1.SetColumnSpan(this.L_AvgScore, 2);
            this.L_AvgScore.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_AvgScore.Location = new System.Drawing.Point(394, 300);
            this.L_AvgScore.Name = "L_AvgScore";
            this.L_AvgScore.Size = new System.Drawing.Size(212, 30);
            this.L_AvgScore.TabIndex = 7;
            this.L_AvgScore.Text = "Per question it is: ";
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button B_Exit;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label L_Statistics;
        private System.Windows.Forms.Label L_QuizEnd;
        private System.Windows.Forms.Label L_AvgScore;
        private System.Windows.Forms.Label L_Score;
        private System.Windows.Forms.Label L_TimeSpent;
    }
}

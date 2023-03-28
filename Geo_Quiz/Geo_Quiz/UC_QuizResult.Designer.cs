using System.Drawing;
using System.Windows.Forms;

namespace Geo_Quiz
{
    partial class UC_QuizResult
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.B_SaveStats = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.L_Statistics = new System.Windows.Forms.Label();
            this.L_QuizEnd = new System.Windows.Forms.Label();
            this.L_TimeSpent = new System.Windows.Forms.Label();
            this.L_Score = new System.Windows.Forms.Label();
            this.L_AvgScore = new System.Windows.Forms.Label();
            this.StatsGridView = new System.Windows.Forms.DataGridView();
            this.Username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Score = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Avg_Score = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Time_Spent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.B_ReturnToMenu = new System.Windows.Forms.Button();
            this.GameInfoButton = new System.Windows.Forms.PictureBox();
            this.TT_PopUp = new System.Windows.Forms.ToolTip(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StatsGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GameInfoButton)).BeginInit();
            this.SuspendLayout();
            // 
            // B_SaveStats
            // 
            this.B_SaveStats.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.B_SaveStats.AutoSize = true;
            this.B_SaveStats.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.B_SaveStats.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.B_SaveStats.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B_SaveStats.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B_SaveStats.ForeColor = System.Drawing.SystemColors.GrayText;
            this.B_SaveStats.Location = new System.Drawing.Point(381, 572);
            this.B_SaveStats.Margin = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.B_SaveStats.Name = "B_SaveStats";
            this.B_SaveStats.Size = new System.Drawing.Size(109, 35);
            this.B_SaveStats.TabIndex = 1;
            this.B_SaveStats.Text = "Save score";
            this.TT_PopUp.SetToolTip(this.B_SaveStats, "Save your score permanently by clicking this button.\r\nIf you don\'t save your stat" +
        "s will be lost forever!\r\nIf you aren\'t logged in and save, stats will be saved u" +
        "nder username \"Guest\".");
            this.B_SaveStats.UseVisualStyleBackColor = false;
            this.B_SaveStats.Click += new System.EventHandler(this.B_SaveStats_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.BackgroundImage = global::Geo_Quiz.Properties.Resources.WorldMap_tp;
            this.tableLayoutPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.L_Statistics, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.L_QuizEnd, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.L_TimeSpent, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.L_Score, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.L_AvgScore, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.StatsGridView, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.B_SaveStats, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.B_ReturnToMenu, 1, 8);
            this.tableLayoutPanel1.Controls.Add(this.GameInfoButton, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 10;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1000, 625);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // L_Statistics
            // 
            this.L_Statistics.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.L_Statistics.AutoSize = true;
            this.L_Statistics.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tableLayoutPanel1.SetColumnSpan(this.L_Statistics, 2);
            this.L_Statistics.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_Statistics.Location = new System.Drawing.Point(412, 110);
            this.L_Statistics.Name = "L_Statistics";
            this.L_Statistics.Size = new System.Drawing.Size(175, 27);
            this.L_Statistics.TabStop = false;
            this.L_Statistics.Text = "Here\'s your stats:";
            // 
            // L_QuizEnd
            // 
            this.L_QuizEnd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.L_QuizEnd.AutoSize = true;
            this.L_QuizEnd.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tableLayoutPanel1.SetColumnSpan(this.L_QuizEnd, 2);
            this.L_QuizEnd.Font = new System.Drawing.Font("Microsoft YaHei", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_QuizEnd.Location = new System.Drawing.Point(368, 54);
            this.L_QuizEnd.Name = "L_QuizEnd";
            this.L_QuizEnd.Size = new System.Drawing.Size(264, 52);
            this.L_QuizEnd.TabStop = false;
            this.L_QuizEnd.Text = "End of quiz!";
            // 
            // L_TimeSpent
            // 
            this.L_TimeSpent.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.L_TimeSpent.AutoSize = true;
            this.L_TimeSpent.BackColor = System.Drawing.SystemColors.Menu;
            this.tableLayoutPanel1.SetColumnSpan(this.L_TimeSpent, 2);
            this.L_TimeSpent.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_TimeSpent.Location = new System.Drawing.Point(419, 235);
            this.L_TimeSpent.Name = "L_TimeSpent";
            this.L_TimeSpent.Size = new System.Drawing.Size(161, 30);
            this.L_TimeSpent.TabStop = false;
            this.L_TimeSpent.Text = "Time played: ";
            // 
            // L_Score
            // 
            this.L_Score.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.L_Score.AutoSize = true;
            this.L_Score.BackColor = System.Drawing.SystemColors.Menu;
            this.tableLayoutPanel1.SetColumnSpan(this.L_Score, 2);
            this.L_Score.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_Score.Location = new System.Drawing.Point(425, 155);
            this.L_Score.Name = "L_Score";
            this.L_Score.Size = new System.Drawing.Size(149, 30);
            this.L_Score.TabStop = false;
            this.L_Score.Text = "Total score: ";
            // 
            // L_AvgScore
            // 
            this.L_AvgScore.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.L_AvgScore.AutoSize = true;
            this.L_AvgScore.BackColor = System.Drawing.SystemColors.Menu;
            this.tableLayoutPanel1.SetColumnSpan(this.L_AvgScore, 2);
            this.L_AvgScore.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_AvgScore.Location = new System.Drawing.Point(408, 195);
            this.L_AvgScore.Name = "L_AvgScore";
            this.L_AvgScore.Size = new System.Drawing.Size(184, 30);
            this.L_AvgScore.TabStop = false;
            this.L_AvgScore.Text = "Average score: ";
            // 
            // StatsGridView
            // 
            this.StatsGridView.AllowUserToAddRows = false;
            this.StatsGridView.AllowUserToDeleteRows = false;
            this.StatsGridView.AllowUserToResizeColumns = false;
            this.StatsGridView.AllowUserToResizeRows = false;
            this.StatsGridView.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.StatsGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.StatsGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.StatsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StatsGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Username,
            this.Score,
            this.Avg_Score,
            this.Time_Spent,
            this.QCount});
            this.tableLayoutPanel1.SetColumnSpan(this.StatsGridView, 2);
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.StatsGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.StatsGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.StatsGridView.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.StatsGridView.Location = new System.Drawing.Point(172, 279);
            this.StatsGridView.Name = "StatsGridView";
            this.StatsGridView.RowHeadersVisible = false;
            this.StatsGridView.RowHeadersWidth = 51;
            this.StatsGridView.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft YaHei", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatsGridView.RowTemplate.Height = 24;
            this.StatsGridView.RowTemplate.ReadOnly = true;
            this.StatsGridView.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.StatsGridView.ShowCellToolTips = false;
            this.StatsGridView.ShowEditingIcon = false;
            this.StatsGridView.Size = new System.Drawing.Size(656, 277);
            this.StatsGridView.TabStop = false;
            // 
            // Username
            // 
            this.Username.Frozen = true;
            this.Username.HeaderText = "Username";
            this.Username.MinimumWidth = 6;
            this.Username.Name = "Username";
            this.Username.ReadOnly = true;
            this.Username.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Username.Width = 150;
            // 
            // Score
            // 
            this.Score.Frozen = true;
            this.Score.HeaderText = "Score";
            this.Score.MinimumWidth = 6;
            this.Score.Name = "Score";
            this.Score.ReadOnly = true;
            this.Score.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Score.Width = 70;
            // 
            // Avg_Score
            // 
            this.Avg_Score.Frozen = true;
            this.Avg_Score.HeaderText = "Average score";
            this.Avg_Score.MinimumWidth = 6;
            this.Avg_Score.Name = "Avg_Score";
            this.Avg_Score.ReadOnly = true;
            this.Avg_Score.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Avg_Score.Width = 75;
            // 
            // Time_Spent
            // 
            this.Time_Spent.Frozen = true;
            this.Time_Spent.HeaderText = "Total time";
            this.Time_Spent.MinimumWidth = 6;
            this.Time_Spent.Name = "Time_Spent";
            this.Time_Spent.ReadOnly = true;
            this.Time_Spent.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Time_Spent.Width = 115;
            // 
            // QCount
            // 
            this.QCount.Frozen = true;
            this.QCount.HeaderText = "Question Count";
            this.QCount.MinimumWidth = 6;
            this.QCount.Name = "QCount";
            this.QCount.ReadOnly = true;
            this.QCount.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.QCount.Width = 110;
            // 
            // B_ReturnToMenu
            // 
            this.B_ReturnToMenu.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.B_ReturnToMenu.AutoSize = true;
            this.B_ReturnToMenu.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.B_ReturnToMenu.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.B_ReturnToMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B_ReturnToMenu.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B_ReturnToMenu.ForeColor = System.Drawing.SystemColors.GrayText;
            this.B_ReturnToMenu.Location = new System.Drawing.Point(510, 572);
            this.B_ReturnToMenu.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.B_ReturnToMenu.Name = "B_ReturnToMenu";
            this.B_ReturnToMenu.Size = new System.Drawing.Size(148, 35);
            this.B_ReturnToMenu.TabIndex = 2;
            this.B_ReturnToMenu.Text = "Return to menu";
            this.B_ReturnToMenu.UseVisualStyleBackColor = false;
            this.B_ReturnToMenu.Click += new System.EventHandler(this.B_ReturnToMenu_Click);
            // 
            // GameInfoButton
            // 
            this.GameInfoButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.GameInfoButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.GameInfoButton.Image = global::Geo_Quiz.Properties.Resources.infoButton;
            this.GameInfoButton.Location = new System.Drawing.Point(947, 3);
            this.GameInfoButton.Name = "GameInfoButton";
            this.GameInfoButton.Size = new System.Drawing.Size(50, 44);
            this.GameInfoButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.GameInfoButton.TabStop = false;
            this.TT_PopUp.SetToolTip(this.GameInfoButton, "Clicking on this info button opens a message box\r\nshowing" +
                "more in-depth stats of the quiz you just finished.");
            this.GameInfoButton.Click += new System.EventHandler(this.GameInfoButton_Click);
            // 
            // UC_QuizResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "UC_QuizResult";
            this.Size = new System.Drawing.Size(1000, 625);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StatsGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GameInfoButton)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button B_SaveStats;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label L_Statistics;
        private System.Windows.Forms.Label L_QuizEnd;
        private System.Windows.Forms.Label L_AvgScore;
        private System.Windows.Forms.Label L_Score;
        private System.Windows.Forms.Label L_TimeSpent;
        private System.Windows.Forms.Button B_ReturnToMenu;
        private System.Windows.Forms.ToolTip TT_PopUp;
        private System.Windows.Forms.DataGridView StatsGridView;
        private PictureBox GameInfoButton;
        private DataGridViewTextBoxColumn Username;
        private DataGridViewTextBoxColumn Score;
        private DataGridViewTextBoxColumn Avg_Score;
        private DataGridViewTextBoxColumn Time_Spent;
        private DataGridViewTextBoxColumn QCount;
    }
}

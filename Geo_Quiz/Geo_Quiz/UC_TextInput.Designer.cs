using System;
using System.Windows.Forms;

namespace Geo_Quiz
{
    partial class UC_TextInput
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
            this.TB_Answer = new System.Windows.Forms.TextBox();
            this.L_Question = new System.Windows.Forms.Label();
            this.PBar = new System.Windows.Forms.ProgressBar();
            this.L_Result = new System.Windows.Forms.Label();
            this.L_CorrectResult = new System.Windows.Forms.Label();
            this.B_Next = new System.Windows.Forms.Button();
            this.L_QCount = new System.Windows.Forms.Label();
            this.L_Score = new System.Windows.Forms.Label();
            this.PB_Flag = new System.Windows.Forms.PictureBox();
            this.B_Enter = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Flag)).BeginInit();
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
            this.B_Exit.Location = new System.Drawing.Point(914, 580);
            this.B_Exit.Margin = new System.Windows.Forms.Padding(0, 0, 10, 10);
            this.B_Exit.Name = "B_Exit";
            this.B_Exit.Size = new System.Drawing.Size(75, 35);
            this.B_Exit.TabIndex = 6;
            this.B_Exit.Text = "Return";
            this.B_Exit.UseVisualStyleBackColor = false;
            this.B_Exit.Click += new System.EventHandler(this.B_Exit_Click);
            // 
            // TB_Answer
            // 
            this.TB_Answer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel1.SetColumnSpan(this.TB_Answer, 3);
            this.TB_Answer.Enabled = false;
            this.TB_Answer.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_Answer.Location = new System.Drawing.Point(317, 373);
            this.TB_Answer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TB_Answer.Name = "TB_Answer";
            this.TB_Answer.Size = new System.Drawing.Size(364, 33);
            this.TB_Answer.TabIndex = 7;
            this.TB_Answer.Text = "Enter answer here";
            this.TB_Answer.Visible = false;
            this.TB_Answer.GotFocus += new System.EventHandler(this.TB_Answer_GotFocus);
            this.TB_Answer.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TB_Answer_KeyDownEnter);
            this.TB_Answer.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TB_Answer_KeyUpEnter);
            // 
            // L_Question
            // 
            this.L_Question.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.L_Question.AutoSize = true;
            this.L_Question.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tableLayoutPanel1.SetColumnSpan(this.L_Question, 3);
            this.L_Question.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_Question.Location = new System.Drawing.Point(458, 321);
            this.L_Question.Name = "L_Question";
            this.L_Question.Size = new System.Drawing.Size(81, 27);
            this.L_Question.TabIndex = 8;
            this.L_Question.Text = "Temp...";
            this.L_Question.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.L_Question.Visible = false;
            // 
            // PBar
            // 
            this.PBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.PBar, 13);
            this.PBar.Location = new System.Drawing.Point(3, 2);
            this.PBar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PBar.Name = "PBar";
            this.PBar.Size = new System.Drawing.Size(993, 36);
            this.PBar.Step = 1;
            this.PBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.PBar.TabIndex = 9;
            // 
            // L_Result
            // 
            this.L_Result.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.L_Result.AutoSize = true;
            this.L_Result.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tableLayoutPanel1.SetColumnSpan(this.L_Result, 3);
            this.L_Result.Font = new System.Drawing.Font("Microsoft YaHei UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_Result.ForeColor = System.Drawing.Color.Red;
            this.L_Result.Location = new System.Drawing.Point(478, 468);
            this.L_Result.Name = "L_Result";
            this.L_Result.Size = new System.Drawing.Size(42, 54);
            this.L_Result.TabIndex = 11;
            this.L_Result.Text = "_";
            this.L_Result.Visible = false;
            // 
            // L_CorrectResult
            // 
            this.L_CorrectResult.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.L_CorrectResult.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.L_CorrectResult, 3);
            this.L_CorrectResult.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_CorrectResult.Location = new System.Drawing.Point(501, 673);
            this.L_CorrectResult.Name = "L_CorrectResult";
            this.L_CorrectResult.Size = new System.Drawing.Size(244, 30);
            this.L_CorrectResult.TabIndex = 14;
            this.L_CorrectResult.Text = "The correct answer is:\r\n";
            this.L_CorrectResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.L_CorrectResult.Visible = false;
            // 
            // B_Next
            // 
            this.B_Next.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.B_Next.Enabled = false;
            this.B_Next.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B_Next.Location = new System.Drawing.Point(557, 417);
            this.B_Next.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.B_Next.Name = "B_Next";
            this.B_Next.Size = new System.Drawing.Size(97, 31);
            this.B_Next.TabIndex = 15;
            this.B_Next.Text = "Next";
            this.B_Next.UseVisualStyleBackColor = false;
            this.B_Next.KeyUp += new System.Windows.Forms.KeyEventHandler(this.B_Next_Click);
            this.B_Next.MouseClick += new System.Windows.Forms.MouseEventHandler(this.B_Next_Click);
            // 
            // L_QCount
            // 
            this.L_QCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.L_QCount.AutoSize = true;
            this.L_QCount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.L_QCount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.L_QCount.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_QCount.Location = new System.Drawing.Point(924, 45);
            this.L_QCount.Margin = new System.Windows.Forms.Padding(5);
            this.L_QCount.Name = "L_QCount";
            this.L_QCount.Size = new System.Drawing.Size(70, 26);
            this.L_QCount.TabIndex = 16;
            this.L_QCount.Text = "temp...";
            this.L_QCount.Visible = false;
            // 
            // L_Score
            // 
            this.L_Score.AutoSize = true;
            this.L_Score.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.L_Score.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.L_Score.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_Score.Location = new System.Drawing.Point(5, 45);
            this.L_Score.Margin = new System.Windows.Forms.Padding(5);
            this.L_Score.Name = "L_Score";
            this.L_Score.Size = new System.Drawing.Size(76, 26);
            this.L_Score.TabIndex = 17;
            this.L_Score.Text = "Score: _";
            // 
            // PB_Flag
            // 
            this.PB_Flag.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PB_Flag.BackColor = System.Drawing.Color.Transparent;
            this.PB_Flag.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tableLayoutPanel1.SetColumnSpan(this.PB_Flag, 3);
            this.PB_Flag.Location = new System.Drawing.Point(323, 90);
            this.PB_Flag.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PB_Flag.Name = "PB_Flag";
            this.PB_Flag.Size = new System.Drawing.Size(352, 204);
            this.PB_Flag.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PB_Flag.TabIndex = 18;
            this.PB_Flag.TabStop = false;
            this.PB_Flag.Visible = false;
            this.PB_Flag.WaitOnLoad = true;
            // 
            // B_Enter
            // 
            this.B_Enter.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.B_Enter.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.B_Enter.Enabled = false;
            this.B_Enter.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B_Enter.Location = new System.Drawing.Point(450, 417);
            this.B_Enter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.B_Enter.Name = "B_Enter";
            this.B_Enter.Size = new System.Drawing.Size(97, 31);
            this.B_Enter.TabIndex = 19;
            this.B_Enter.Text = "Enter";
            this.B_Enter.UseVisualStyleBackColor = false;
            this.B_Enter.Click += new System.EventHandler(this.B_Enter_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackgroundImage = global::Geo_Quiz.Properties.Resources.WorldMap_tp;
            this.tableLayoutPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 110F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.B_Enter, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.TB_Answer, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.PBar, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.L_Score, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.PB_Flag, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.L_QCount, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.L_CorrectResult, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.L_Question, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.L_Result, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.B_Next, 3, 5);
            this.tableLayoutPanel1.Controls.Add(this.B_Exit, 4, 8);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 9;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(999, 625);
            this.tableLayoutPanel1.TabIndex = 20;
            // 
            // UC_TextInput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = global::Geo_Quiz.Properties.Resources.WorldMap_tp;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.tableLayoutPanel1);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "UC_TextInput";
            this.Size = new System.Drawing.Size(999, 625);
            ((System.ComponentModel.ISupportInitialize)(this.PB_Flag)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button B_Exit;
        private System.Windows.Forms.TextBox TB_Answer;
        private System.Windows.Forms.Label L_Question;
        private System.Windows.Forms.ProgressBar PBar;
        private System.Windows.Forms.Label L_Result;
        private System.Windows.Forms.Label L_CorrectResult;
        private System.Windows.Forms.Button B_Next;
        private System.Windows.Forms.Label L_QCount;
        private System.Windows.Forms.Label L_Score;
        private System.Windows.Forms.PictureBox PB_Flag;
        private System.Windows.Forms.Button B_Enter;
        private TableLayoutPanel tableLayoutPanel1;
    }
}

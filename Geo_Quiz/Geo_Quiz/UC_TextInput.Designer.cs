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
            this.B_Skip = new System.Windows.Forms.Button();
            this.L_Result = new System.Windows.Forms.Label();
            this.L_Country = new System.Windows.Forms.Label();
            this.B_Start = new System.Windows.Forms.Button();
            this.L_CorrectResult = new System.Windows.Forms.Label();
            this.B_Next = new System.Windows.Forms.Button();
            this.L_QCount = new System.Windows.Forms.Label();
            this.L_Score = new System.Windows.Forms.Label();
            this.PB_Flag = new System.Windows.Forms.PictureBox();
            this.B_Enter = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Flag)).BeginInit();
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
            this.B_Exit.Location = new System.Drawing.Point(914, 577);
            this.B_Exit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.B_Exit.Name = "B_Exit";
            this.B_Exit.Size = new System.Drawing.Size(75, 35);
            this.B_Exit.TabIndex = 6;
            this.B_Exit.Text = "Return";
            this.B_Exit.UseVisualStyleBackColor = false;
            this.B_Exit.Click += new System.EventHandler(this.B_Exit_Click);
            // 
            // TB_Answer
            // 
            this.TB_Answer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TB_Answer.Enabled = false;
            this.TB_Answer.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_Answer.Location = new System.Drawing.Point(341, 345);
            this.TB_Answer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TB_Answer.Name = "TB_Answer";
            this.TB_Answer.Size = new System.Drawing.Size(319, 33);
            this.TB_Answer.TabIndex = 7;
            this.TB_Answer.Text = "Enter answer here";
            this.TB_Answer.GotFocus += new System.EventHandler(this.TB_Answer_GotFocus);
            this.TB_Answer.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TB_Answer_KeyUpEnter);
            // 
            // L_Question
            // 
            this.L_Question.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.L_Question.AutoSize = true;
            this.L_Question.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.L_Question.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_Question.Location = new System.Drawing.Point(353, 255);
            this.L_Question.Name = "L_Question";
            this.L_Question.Size = new System.Drawing.Size(81, 27);
            this.L_Question.TabIndex = 8;
            this.L_Question.Text = "Temp...";
            // 
            // PBar
            // 
            this.PBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.PBar.Location = new System.Drawing.Point(0, 0);
            this.PBar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PBar.Name = "PBar";
            this.PBar.Size = new System.Drawing.Size(1000, 36);
            this.PBar.Step = 1;
            this.PBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.PBar.TabIndex = 9;
            // 
            // B_Skip
            // 
            this.B_Skip.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.B_Skip.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.B_Skip.Enabled = false;
            this.B_Skip.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B_Skip.Location = new System.Drawing.Point(341, 383);
            this.B_Skip.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.B_Skip.Name = "B_Skip";
            this.B_Skip.Size = new System.Drawing.Size(102, 31);
            this.B_Skip.TabIndex = 10;
            this.B_Skip.Text = "Skip";
            this.B_Skip.UseVisualStyleBackColor = false;
            this.B_Skip.Click += new System.EventHandler(this.B_Skip_Click);
            // 
            // L_Result
            // 
            this.L_Result.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.L_Result.AutoSize = true;
            this.L_Result.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.L_Result.Font = new System.Drawing.Font("Microsoft YaHei UI", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_Result.ForeColor = System.Drawing.Color.Red;
            this.L_Result.Location = new System.Drawing.Point(384, 414);
            this.L_Result.Name = "L_Result";
            this.L_Result.Size = new System.Drawing.Size(50, 64);
            this.L_Result.TabIndex = 11;
            this.L_Result.Text = "_";
            this.L_Result.Visible = false;
            // 
            // L_Country
            // 
            this.L_Country.AutoSize = true;
            this.L_Country.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.L_Country.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_Country.Location = new System.Drawing.Point(353, 290);
            this.L_Country.Name = "L_Country";
            this.L_Country.Size = new System.Drawing.Size(39, 27);
            this.L_Country.TabIndex = 12;
            this.L_Country.Text = "___";
            // 
            // B_Start
            // 
            this.B_Start.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.B_Start.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.B_Start.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B_Start.Location = new System.Drawing.Point(341, 250);
            this.B_Start.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.B_Start.Name = "B_Start";
            this.B_Start.Size = new System.Drawing.Size(320, 89);
            this.B_Start.TabIndex = 13;
            this.B_Start.Text = "START";
            this.B_Start.UseVisualStyleBackColor = false;
            this.B_Start.Click += new System.EventHandler(this.B_Start_Click);
            // 
            // L_CorrectResult
            // 
            this.L_CorrectResult.AutoSize = true;
            this.L_CorrectResult.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_CorrectResult.Location = new System.Drawing.Point(380, 487);
            this.L_CorrectResult.Name = "L_CorrectResult";
            this.L_CorrectResult.Size = new System.Drawing.Size(165, 24);
            this.L_CorrectResult.TabIndex = 14;
            this.L_CorrectResult.Text = "Correct answer is: ";
            this.L_CorrectResult.Visible = false;
            // 
            // B_Next
            // 
            this.B_Next.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.B_Next.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.B_Next.Enabled = false;
            this.B_Next.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B_Next.Location = new System.Drawing.Point(558, 383);
            this.B_Next.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.B_Next.Name = "B_Next";
            this.B_Next.Size = new System.Drawing.Size(103, 31);
            this.B_Next.TabIndex = 15;
            this.B_Next.Text = "Next";
            this.B_Next.UseVisualStyleBackColor = false;
            this.B_Next.KeyUp += new System.Windows.Forms.KeyEventHandler(this.B_Next_Click);
            this.B_Next.MouseClick += new System.Windows.Forms.MouseEventHandler(this.B_Next_Click);
            // 
            // L_QCount
            // 
            this.L_QCount.AutoSize = true;
            this.L_QCount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.L_QCount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.L_QCount.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_QCount.Location = new System.Drawing.Point(896, 44);
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
            this.L_Score.Location = new System.Drawing.Point(5, 44);
            this.L_Score.Margin = new System.Windows.Forms.Padding(5);
            this.L_Score.Name = "L_Score";
            this.L_Score.Size = new System.Drawing.Size(76, 26);
            this.L_Score.TabIndex = 17;
            this.L_Score.Text = "Score: _";
            // 
            // PB_Flag
            // 
            this.PB_Flag.BackColor = System.Drawing.Color.Transparent;
            this.PB_Flag.Location = new System.Drawing.Point(341, 158);
            this.PB_Flag.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PB_Flag.Name = "PB_Flag";
            this.PB_Flag.Size = new System.Drawing.Size(291, 181);
            this.PB_Flag.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PB_Flag.TabIndex = 18;
            this.PB_Flag.TabStop = false;
            this.PB_Flag.Visible = false;
            this.PB_Flag.WaitOnLoad = true;
            // 
            // B_Enter
            // 
            this.B_Enter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.B_Enter.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.B_Enter.Enabled = false;
            this.B_Enter.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B_Enter.Location = new System.Drawing.Point(449, 383);
            this.B_Enter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.B_Enter.Name = "B_Enter";
            this.B_Enter.Size = new System.Drawing.Size(103, 31);
            this.B_Enter.TabIndex = 19;
            this.B_Enter.Text = "Enter";
            this.B_Enter.UseVisualStyleBackColor = false;
            this.B_Enter.Click += new System.EventHandler(this.B_Enter_Click);
            //
            // UC_TextInput
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;            
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.B_Enter);
            this.Controls.Add(this.B_Start);
            this.Controls.Add(this.L_Score);
            this.Controls.Add(this.L_QCount);
            this.Controls.Add(this.B_Next);
            this.Controls.Add(this.L_CorrectResult);
            this.Controls.Add(this.L_Country);
            this.Controls.Add(this.L_Result);
            this.Controls.Add(this.B_Skip);
            this.Controls.Add(this.PBar);
            this.Controls.Add(this.L_Question);
            this.Controls.Add(this.TB_Answer);
            this.Controls.Add(this.B_Exit);
            this.Controls.Add(this.PB_Flag);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "UC_TextInput";
            this.Size = new System.Drawing.Size(1000, 625);
            ((System.ComponentModel.ISupportInitialize)(this.PB_Flag)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button B_Exit;
        private System.Windows.Forms.TextBox TB_Answer;
        private System.Windows.Forms.Label L_Question;
        private System.Windows.Forms.ProgressBar PBar;
        private System.Windows.Forms.Button B_Skip;
        private System.Windows.Forms.Label L_Result;
        private System.Windows.Forms.Label L_Country;
        private System.Windows.Forms.Button B_Start;
        private System.Windows.Forms.Label L_CorrectResult;
        private System.Windows.Forms.Button B_Next;
        private System.Windows.Forms.Label L_QCount;
        private System.Windows.Forms.Label L_Score;
        private System.Windows.Forms.PictureBox PB_Flag;
        private System.Windows.Forms.Button B_Enter;
    }
}

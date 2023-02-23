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
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.B_Skip = new System.Windows.Forms.Button();
            this.L_Result = new System.Windows.Forms.Label();
            this.L_Country = new System.Windows.Forms.Label();
            this.B_Start = new System.Windows.Forms.Button();
            this.L_CorrectResult = new System.Windows.Forms.Label();
            this.B_Next = new System.Windows.Forms.Button();
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
            this.B_Exit.Location = new System.Drawing.Point(884, 529);
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
            this.TB_Answer.Location = new System.Drawing.Point(341, 344);
            this.TB_Answer.Name = "TB_Answer";
            this.TB_Answer.Size = new System.Drawing.Size(290, 33);
            this.TB_Answer.TabIndex = 7;
            this.TB_Answer.Text = "Enter answer here";
            this.TB_Answer.GotFocus += new System.EventHandler(this.TB_Answer_GotFocus);
            this.TB_Answer.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TB_Answer_KeyUpEnter);
            this.TB_Answer.LostFocus += new System.EventHandler(this.TB_Answer_LostFocus);
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
            this.L_Question.Size = new System.Drawing.Size(262, 27);
            this.L_Question.TabIndex = 8;
            this.L_Question.Text = "What is the capital city of: ";
            this.L_Question.Click += new System.EventHandler(this.L_Question_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.progressBar1.Location = new System.Drawing.Point(0, 0);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(971, 36);
            this.progressBar1.TabIndex = 9;
            // 
            // B_Skip
            // 
            this.B_Skip.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.B_Skip.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.B_Skip.Enabled = false;
            this.B_Skip.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B_Skip.Location = new System.Drawing.Point(341, 383);
            this.B_Skip.Name = "B_Skip";
            this.B_Skip.Size = new System.Drawing.Size(92, 31);
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
            this.L_Country.Location = new System.Drawing.Point(353, 291);
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
            this.B_Start.Name = "B_Start";
            this.B_Start.Size = new System.Drawing.Size(290, 88);
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
            this.L_CorrectResult.Click += new System.EventHandler(this.L_CorrectResult_Click);
            // 
            // B_Next
            // 
            this.B_Next.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.B_Next.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.B_Next.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B_Next.Location = new System.Drawing.Point(539, 383);
            this.B_Next.Name = "B_Next";
            this.B_Next.Size = new System.Drawing.Size(92, 31);
            this.B_Next.TabIndex = 15;
            this.B_Next.Text = "Next";
            this.B_Next.UseVisualStyleBackColor = false;
            this.B_Next.Visible = false;
            this.B_Next.Click += new System.EventHandler(this.B_Next_Click);
            // 
            // UC_TextInput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = global::Geo_Quiz.Properties.Resources.WorldMap_tp;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.B_Next);
            this.Controls.Add(this.L_CorrectResult);
            this.Controls.Add(this.B_Start);
            this.Controls.Add(this.L_Country);
            this.Controls.Add(this.L_Result);
            this.Controls.Add(this.B_Skip);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.L_Question);
            this.Controls.Add(this.TB_Answer);
            this.Controls.Add(this.B_Exit);
            this.DoubleBuffered = true;
            this.Name = "UC_TextInput";
            this.Size = new System.Drawing.Size(971, 577);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button B_Exit;
        private System.Windows.Forms.TextBox TB_Answer;
        private System.Windows.Forms.Label L_Question;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button B_Skip;
        private System.Windows.Forms.Label L_Result;
        private System.Windows.Forms.Label L_Country;
        private System.Windows.Forms.Button B_Start;
        private System.Windows.Forms.Label L_CorrectResult;
        private System.Windows.Forms.Button B_Next;
    }
}

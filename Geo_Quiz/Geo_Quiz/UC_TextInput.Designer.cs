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
            this.B_Exit.Location = new System.Drawing.Point(883, 529);
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
            this.TB_Answer.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_Answer.Location = new System.Drawing.Point(341, 344);
            this.TB_Answer.Name = "TB_Answer";
            this.TB_Answer.Size = new System.Drawing.Size(290, 33);
            this.TB_Answer.TabIndex = 7;
            this.TB_Answer.Text = "Enter answer here";
            this.TB_Answer.TextChanged += new System.EventHandler(this.TB_Answer_TextChanged);
            // 
            // L_Question
            // 
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
            this.progressBar1.Size = new System.Drawing.Size(971, 29);
            this.progressBar1.TabIndex = 9;
            // 
            // UC_TextInput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = global::Geo_Quiz.Properties.Resources.WorldMap_tp;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
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
    }
}

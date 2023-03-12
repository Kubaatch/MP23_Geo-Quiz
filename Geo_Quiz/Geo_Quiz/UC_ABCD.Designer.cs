namespace Geo_Quiz
{
    partial class UC_ABCD
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Button_B = new System.Windows.Forms.Button();
            this.Button_A = new System.Windows.Forms.Button();
            this.Button_D = new System.Windows.Forms.Button();
            this.B_Exit = new System.Windows.Forms.Button();
            this.Button_C = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.L_Question = new System.Windows.Forms.Label();
            this.L_Result = new System.Windows.Forms.Label();
            this.B_Next = new System.Windows.Forms.Button();
            this.PB_Flag = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Flag)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackgroundImage = global::Geo_Quiz.Properties.Resources.WorldMap_tp;
            this.tableLayoutPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32F));
            this.tableLayoutPanel1.Controls.Add(this.Button_B, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.Button_A, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.Button_D, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.B_Exit, 3, 5);
            this.tableLayoutPanel1.Controls.Add(this.Button_C, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.progressBar1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.L_Question, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.L_Result, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.B_Next, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.PB_Flag, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.34531F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 300F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 29.33236F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 29.97702F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.34531F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1000, 625);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // Button_B
            // 
            this.Button_B.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Button_B.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Button_B.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_B.Location = new System.Drawing.Point(503, 408);
            this.Button_B.Name = "Button_B";
            this.Button_B.Size = new System.Drawing.Size(160, 74);
            this.Button_B.TabIndex = 1;
            this.Button_B.Text = "Button_B";
            this.Button_B.UseVisualStyleBackColor = true;
            this.Button_B.Visible = false;
            this.Button_B.Click += new System.EventHandler(this.Button_Click_Answer);
            // 
            // Button_A
            // 
            this.Button_A.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Button_A.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_A.Location = new System.Drawing.Point(337, 408);
            this.Button_A.Name = "Button_A";
            this.Button_A.Size = new System.Drawing.Size(160, 74);
            this.Button_A.TabIndex = 0;
            this.Button_A.Text = "Button_A";
            this.Button_A.UseVisualStyleBackColor = true;
            this.Button_A.Visible = false;
            this.Button_A.Click += new System.EventHandler(this.Button_Click_Answer);
            // 
            // Button_D
            // 
            this.Button_D.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_D.Location = new System.Drawing.Point(503, 488);
            this.Button_D.Name = "Button_D";
            this.Button_D.Size = new System.Drawing.Size(160, 76);
            this.Button_D.TabIndex = 3;
            this.Button_D.Text = "Button_D";
            this.Button_D.UseVisualStyleBackColor = true;
            this.Button_D.Visible = false;
            this.Button_D.Click += new System.EventHandler(this.Button_Click_Answer);
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
            this.B_Exit.Margin = new System.Windows.Forms.Padding(0, 0, 10, 10);
            this.B_Exit.Name = "B_Exit";
            this.B_Exit.Size = new System.Drawing.Size(75, 35);
            this.B_Exit.TabIndex = 5;
            this.B_Exit.Text = "Return";
            this.B_Exit.UseVisualStyleBackColor = false;
            this.B_Exit.Click += new System.EventHandler(this.B_Exit_Click);
            // 
            // Button_C
            // 
            this.Button_C.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Button_C.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_C.Location = new System.Drawing.Point(337, 488);
            this.Button_C.Name = "Button_C";
            this.Button_C.Size = new System.Drawing.Size(160, 76);
            this.Button_C.TabIndex = 2;
            this.Button_C.Text = "Button_C";
            this.Button_C.UseVisualStyleBackColor = true;
            this.Button_C.Visible = false;
            this.Button_C.Click += new System.EventHandler(this.Button_Click_Answer);
            // 
            // progressBar1
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.progressBar1, 4);
            this.progressBar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.progressBar1.Location = new System.Drawing.Point(3, 3);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(994, 46);
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar1.TabIndex = 19;
            // 
            // L_Question
            // 
            this.L_Question.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.L_Question.AutoSize = true;
            this.L_Question.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tableLayoutPanel1.SetColumnSpan(this.L_Question, 2);
            this.L_Question.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_Question.Location = new System.Drawing.Point(452, 355);
            this.L_Question.Margin = new System.Windows.Forms.Padding(15, 0, 15, 0);
            this.L_Question.Name = "L_Question";
            this.L_Question.Size = new System.Drawing.Size(95, 24);
            this.L_Question.TabIndex = 16;
            this.L_Question.Text = "What is...?";
            this.L_Question.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.L_Question.Visible = false;
            // 
            // L_Result
            // 
            this.L_Result.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.L_Result.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.L_Result, 2);
            this.L_Result.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_Result.Location = new System.Drawing.Point(463, 582);
            this.L_Result.Name = "L_Result";
            this.L_Result.Size = new System.Drawing.Size(73, 27);
            this.L_Result.TabIndex = 20;
            this.L_Result.Text = "label1";
            this.L_Result.Visible = false;
            // 
            // B_Next
            // 
            this.B_Next.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.B_Next.Location = new System.Drawing.Point(683, 466);
            this.B_Next.Name = "B_Next";
            this.tableLayoutPanel1.SetRowSpan(this.B_Next, 2);
            this.B_Next.Size = new System.Drawing.Size(110, 40);
            this.B_Next.TabIndex = 4;
            this.B_Next.Text = "Next Question";
            this.B_Next.UseVisualStyleBackColor = true;
            this.B_Next.Visible = false;
            this.B_Next.Click += new System.EventHandler(this.B_Next_Click);
            // 
            // PB_Flag
            // 
            this.PB_Flag.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.PB_Flag.BackColor = System.Drawing.Color.Transparent;
            this.PB_Flag.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tableLayoutPanel1.SetColumnSpan(this.PB_Flag, 2);
            this.PB_Flag.Location = new System.Drawing.Point(331, 98);
            this.PB_Flag.Margin = new System.Windows.Forms.Padding(0, 0, 0, 20);
            this.PB_Flag.Name = "PB_Flag";
            this.PB_Flag.Size = new System.Drawing.Size(338, 237);
            this.PB_Flag.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PB_Flag.TabIndex = 17;
            this.PB_Flag.TabStop = false;
            this.PB_Flag.Visible = false;
            // 
            // UC_ABCD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "UC_ABCD";
            this.Size = new System.Drawing.Size(1000, 625);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Flag)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button Button_A;
        private System.Windows.Forms.Button Button_B;
        private System.Windows.Forms.Button Button_C;
        private System.Windows.Forms.Button Button_D;
        private System.Windows.Forms.Label L_Question;
        private System.Windows.Forms.PictureBox PB_Flag;
        private System.Windows.Forms.Button B_Exit;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label L_Result;
        private System.Windows.Forms.Button B_Next;
    }
}

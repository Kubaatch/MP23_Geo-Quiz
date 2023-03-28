namespace Geo_Quiz
{
    partial class F_SignIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_SignIn));
            this.B_SignUp = new System.Windows.Forms.Button();
            this.B_SignIn = new System.Windows.Forms.Button();
            this.B_Guest = new System.Windows.Forms.Button();
            this.B_Exit = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.L_Logo = new System.Windows.Forms.Label();
            this.L_CurrentAcc = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // B_SignUp
            // 
            this.B_SignUp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.B_SignUp.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.B_SignUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B_SignUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B_SignUp.Location = new System.Drawing.Point(512, 311);
            this.B_SignUp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.B_SignUp.Name = "B_SignUp";
            this.B_SignUp.Size = new System.Drawing.Size(200, 84);
            this.B_SignUp.TabIndex = 2;
            this.B_SignUp.Text = "Sign up";
            this.B_SignUp.UseVisualStyleBackColor = false;
            this.B_SignUp.Click += new System.EventHandler(this.B_SignUp_Click);
            // 
            // B_SignIn
            // 
            this.B_SignIn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.B_SignIn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.B_SignIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B_SignIn.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B_SignIn.Location = new System.Drawing.Point(268, 311);
            this.B_SignIn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.B_SignIn.Name = "B_SignIn";
            this.B_SignIn.Size = new System.Drawing.Size(199, 84);
            this.B_SignIn.TabIndex = 1;
            this.B_SignIn.Text = "Sign in";
            this.B_SignIn.UseVisualStyleBackColor = false;
            this.B_SignIn.Click += new System.EventHandler(this.B_SignIn_Click);
            // 
            // B_Guest
            // 
            this.B_Guest.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.B_Guest.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tableLayoutPanel1.SetColumnSpan(this.B_Guest, 2);
            this.B_Guest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B_Guest.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B_Guest.Location = new System.Drawing.Point(322, 416);
            this.B_Guest.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.B_Guest.Name = "B_Guest";
            this.B_Guest.Size = new System.Drawing.Size(335, 50);
            this.B_Guest.TabIndex = 3;
            this.B_Guest.Text = "Enter main menu";
            this.B_Guest.UseVisualStyleBackColor = false;
            this.B_Guest.Click += new System.EventHandler(this.B_Guest_Click);
            // 
            // B_Exit
            // 
            this.B_Exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.B_Exit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.B_Exit.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.B_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B_Exit.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B_Exit.ForeColor = System.Drawing.SystemColors.GrayText;
            this.B_Exit.Location = new System.Drawing.Point(866, 529);
            this.B_Exit.Margin = new System.Windows.Forms.Padding(1, 1, 10, 10);
            this.B_Exit.Name = "B_Exit";
            this.B_Exit.Size = new System.Drawing.Size(105, 39);
            this.B_Exit.TabIndex = 4;
            this.B_Exit.Text = "Exit App";
            this.B_Exit.UseVisualStyleBackColor = false;
            this.B_Exit.Click += new System.EventHandler(this.B_Exit_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackgroundImage = global::Geo_Quiz.Properties.Resources.WorldMap_tp;
            this.tableLayoutPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.B_SignIn, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.B_Guest, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.L_Logo, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.B_Exit, 3, 5);
            this.tableLayoutPanel1.Controls.Add(this.L_CurrentAcc, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.B_SignUp, 2, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 23.07693F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.38461F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.38461F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.38461F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.38461F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.38461F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(981, 578);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // L_Logo
            // 
            this.L_Logo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.L_Logo.AutoSize = true;
            this.L_Logo.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.tableLayoutPanel1.SetColumnSpan(this.L_Logo, 2);
            this.L_Logo.Font = new System.Drawing.Font("Wide Latin", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_Logo.Location = new System.Drawing.Point(289, 55);
            this.L_Logo.Margin = new System.Windows.Forms.Padding(3, 0, 3, 10);
            this.L_Logo.Name = "L_Logo";
            this.tableLayoutPanel1.SetRowSpan(this.L_Logo, 2);
            this.L_Logo.Size = new System.Drawing.Size(402, 100);
            this.L_Logo.TabIndex = 4;
            this.L_Logo.Text = "Geography Quiz";
            this.L_Logo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // L_CurrentAcc
            // 
            this.L_CurrentAcc.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.L_CurrentAcc.AutoSize = true;
            this.L_CurrentAcc.BackColor = System.Drawing.SystemColors.HighlightText;
            this.L_CurrentAcc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tableLayoutPanel1.SetColumnSpan(this.L_CurrentAcc, 2);
            this.L_CurrentAcc.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_CurrentAcc.Location = new System.Drawing.Point(418, 274);
            this.L_CurrentAcc.Margin = new System.Windows.Forms.Padding(3, 0, 3, 10);
            this.L_CurrentAcc.Name = "L_CurrentAcc";
            this.L_CurrentAcc.Size = new System.Drawing.Size(143, 25);
            this.L_CurrentAcc.TabIndex = 5;
            this.L_CurrentAcc.Text = "Playing as guest";
            // 
            // F_SignIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(981, 578);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "F_SignIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Geography Quiz";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button B_SignUp;
        private System.Windows.Forms.Button B_SignIn;
        private System.Windows.Forms.Button B_Guest;
        private System.Windows.Forms.Button B_Exit;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label L_Logo;
        private System.Windows.Forms.Label L_CurrentAcc;
    }
}
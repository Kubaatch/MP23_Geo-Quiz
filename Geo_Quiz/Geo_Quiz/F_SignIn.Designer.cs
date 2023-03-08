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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // B_SignUp
            // 
            this.B_SignUp.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.B_SignUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B_SignUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B_SignUp.Location = new System.Drawing.Point(273, 378);
            this.B_SignUp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.B_SignUp.Name = "B_SignUp";
            this.B_SignUp.Size = new System.Drawing.Size(200, 106);
            this.B_SignUp.TabIndex = 3;
            this.B_SignUp.Text = "Sign up";
            this.B_SignUp.UseVisualStyleBackColor = false;
            this.B_SignUp.Click += new System.EventHandler(this.B_SignUp_Click);
            // 
            // B_SignIn
            // 
            this.B_SignIn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.B_SignIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B_SignIn.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B_SignIn.Location = new System.Drawing.Point(508, 378);
            this.B_SignIn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.B_SignIn.Name = "B_SignIn";
            this.B_SignIn.Size = new System.Drawing.Size(199, 106);
            this.B_SignIn.TabIndex = 4;
            this.B_SignIn.Text = "Sign in";
            this.B_SignIn.UseVisualStyleBackColor = false;
            this.B_SignIn.Click += new System.EventHandler(this.B_SignIn_Click);
            // 
            // B_Guest
            // 
            this.B_Guest.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.B_Guest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B_Guest.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B_Guest.Location = new System.Drawing.Point(324, 490);
            this.B_Guest.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.B_Guest.Name = "B_Guest";
            this.B_Guest.Size = new System.Drawing.Size(335, 50);
            this.B_Guest.TabIndex = 5;
            this.B_Guest.Text = "Play as Guest";
            this.B_Guest.UseVisualStyleBackColor = false;
            this.B_Guest.Click += new System.EventHandler(this.B_Guest_Click);
            // 
            // B_Exit
            // 
            this.B_Exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.B_Exit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.B_Exit.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.B_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B_Exit.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B_Exit.ForeColor = System.Drawing.SystemColors.GrayText;
            this.B_Exit.Location = new System.Drawing.Point(869, 529);
            this.B_Exit.Name = "B_Exit";
            this.B_Exit.Size = new System.Drawing.Size(100, 37);
            this.B_Exit.TabIndex = 6;
            this.B_Exit.Text = "Exit App";
            this.B_Exit.UseVisualStyleBackColor = false;
            this.B_Exit.Click += new System.EventHandler(this.B_Exit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Geo_Quiz.Properties.Resources.world_map;
            this.pictureBox1.Location = new System.Drawing.Point(107, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(765, 361);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // F_SignIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(981, 578);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.B_Exit);
            this.Controls.Add(this.B_Guest);
            this.Controls.Add(this.B_SignIn);
            this.Controls.Add(this.B_SignUp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "F_SignIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SignIn";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button B_SignUp;
        private System.Windows.Forms.Button B_SignIn;
        private System.Windows.Forms.Button B_Guest;
        private System.Windows.Forms.Button B_Exit;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
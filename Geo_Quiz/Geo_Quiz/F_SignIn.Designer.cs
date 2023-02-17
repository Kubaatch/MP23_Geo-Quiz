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
            this.B_SignIn = new System.Windows.Forms.Button();
            this.B_SignUp = new System.Windows.Forms.Button();
            this.B_Guest = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // B_SignIn
            // 
            this.B_SignIn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.B_SignIn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.B_SignIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B_SignIn.Font = new System.Drawing.Font("Microsoft YaHei", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B_SignIn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.B_SignIn.Location = new System.Drawing.Point(216, 378);
            this.B_SignIn.Name = "B_SignIn";
            this.B_SignIn.Size = new System.Drawing.Size(263, 101);
            this.B_SignIn.TabIndex = 0;
            this.B_SignIn.Text = "Sign in";
            this.B_SignIn.UseVisualStyleBackColor = false;
            // 
            // B_SignUp
            // 
            this.B_SignUp.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.B_SignUp.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.B_SignUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B_SignUp.Font = new System.Drawing.Font("Microsoft YaHei", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B_SignUp.Location = new System.Drawing.Point(503, 378);
            this.B_SignUp.Name = "B_SignUp";
            this.B_SignUp.Size = new System.Drawing.Size(263, 101);
            this.B_SignUp.TabIndex = 3;
            this.B_SignUp.Text = "Sign up";
            this.B_SignUp.UseVisualStyleBackColor = false;
            // 
            // B_Guest
            // 
            this.B_Guest.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.B_Guest.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.B_Guest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B_Guest.Font = new System.Drawing.Font("Microsoft YaHei Light", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B_Guest.Location = new System.Drawing.Point(343, 485);
            this.B_Guest.Name = "B_Guest";
            this.B_Guest.Size = new System.Drawing.Size(293, 45);
            this.B_Guest.TabIndex = 4;
            this.B_Guest.Text = "Play as Guest";
            this.B_Guest.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Geo_Quiz.Properties.Resources.GeoMap;
            this.pictureBox1.Location = new System.Drawing.Point(160, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(662, 360);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // F_SignIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(982, 578);
            this.Controls.Add(this.B_Guest);
            this.Controls.Add(this.B_SignUp);
            this.Controls.Add(this.B_SignIn);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "F_SignIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SignIn";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button B_SignIn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button B_SignUp;
        private System.Windows.Forms.Button B_Guest;
    }
}
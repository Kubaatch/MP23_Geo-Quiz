﻿namespace Geo_Quiz
{
    partial class F_MainMenu
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
            this.B_Testing = new System.Windows.Forms.Button();
            this.B_Training = new System.Windows.Forms.Button();
            this.B_Settings = new System.Windows.Forms.Button();
            this.B_Exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // B_Testing
            // 
            this.B_Testing.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.B_Testing.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.B_Testing.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.B_Testing.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.B_Testing.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B_Testing.Font = new System.Drawing.Font("Microsoft YaHei", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B_Testing.Location = new System.Drawing.Point(221, 135);
            this.B_Testing.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.B_Testing.Name = "B_Testing";
            this.B_Testing.Size = new System.Drawing.Size(300, 75);
            this.B_Testing.TabIndex = 0;
            this.B_Testing.Text = "Testing Mode";
            this.B_Testing.UseVisualStyleBackColor = false;
            this.B_Testing.Click += new System.EventHandler(this.B_Testing_Click);
            // 
            // B_Training
            // 
            this.B_Training.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.B_Training.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.B_Training.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.B_Training.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B_Training.Font = new System.Drawing.Font("Microsoft YaHei", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B_Training.Location = new System.Drawing.Point(221, 227);
            this.B_Training.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.B_Training.Name = "B_Training";
            this.B_Training.Size = new System.Drawing.Size(300, 75);
            this.B_Training.TabIndex = 1;
            this.B_Training.Text = "Learning Mode";
            this.B_Training.UseVisualStyleBackColor = false;
            this.B_Training.Click += new System.EventHandler(this.B_Training_Click);
            // 
            // B_Settings
            // 
            this.B_Settings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.B_Settings.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.B_Settings.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.B_Settings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B_Settings.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B_Settings.ForeColor = System.Drawing.SystemColors.GrayText;
            this.B_Settings.Location = new System.Drawing.Point(11, 409);
            this.B_Settings.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.B_Settings.Name = "B_Settings";
            this.B_Settings.Size = new System.Drawing.Size(125, 50);
            this.B_Settings.TabIndex = 2;
            this.B_Settings.Text = "Settings";
            this.B_Settings.UseVisualStyleBackColor = false;
            this.B_Settings.Click += new System.EventHandler(this.B_Settings_Click);
            // 
            // B_Exit
            // 
            this.B_Exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.B_Exit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.B_Exit.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.B_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B_Exit.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B_Exit.ForeColor = System.Drawing.SystemColors.GrayText;
            this.B_Exit.Location = new System.Drawing.Point(650, 429);
            this.B_Exit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.B_Exit.Name = "B_Exit";
            this.B_Exit.Size = new System.Drawing.Size(75, 30);
            this.B_Exit.TabIndex = 3;
            this.B_Exit.Text = "Exit App";
            this.B_Exit.UseVisualStyleBackColor = false;
            this.B_Exit.Click += new System.EventHandler(this.B_Exit_Click);
            // 
            // F_MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(736, 470);
            this.Controls.Add(this.B_Exit);
            this.Controls.Add(this.B_Settings);
            this.Controls.Add(this.B_Training);
            this.Controls.Add(this.B_Testing);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "F_MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainMenu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button B_Testing;
        private System.Windows.Forms.Button B_Training;
        private System.Windows.Forms.Button B_Settings;
        private System.Windows.Forms.Button B_Exit;
    }
}


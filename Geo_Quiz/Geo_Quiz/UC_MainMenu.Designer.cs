namespace Geo_Quiz
{
    partial class UC_MainMenu
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
            this.B_Testing = new System.Windows.Forms.Button();
            this.B_Account = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.B_Exit = new System.Windows.Forms.Button();
            this.B_Training = new System.Windows.Forms.Button();
            this.L_CurrentAcc = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // B_Testing
            // 
            this.B_Testing.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.B_Testing.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.B_Testing.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.B_Testing.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.B_Testing.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B_Testing.Font = new System.Drawing.Font("Microsoft YaHei", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B_Testing.Location = new System.Drawing.Point(336, 220);
            this.B_Testing.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.B_Testing.Name = "B_Testing";
            this.B_Testing.Size = new System.Drawing.Size(326, 90);
            this.B_Testing.TabIndex = 1;
            this.B_Testing.Text = "Testing Mode";
            this.B_Testing.UseVisualStyleBackColor = false;
            this.B_Testing.Click += new System.EventHandler(this.B_Testing_Click);
            // 
            // B_Account
            // 
            this.B_Account.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.B_Account.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.B_Account.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.B_Account.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B_Account.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B_Account.ForeColor = System.Drawing.SystemColors.GrayText;
            this.B_Account.Location = new System.Drawing.Point(10, 561);
            this.B_Account.Margin = new System.Windows.Forms.Padding(10);
            this.B_Account.Name = "B_Account";
            this.B_Account.Size = new System.Drawing.Size(135, 54);
            this.B_Account.TabIndex = 5;
            this.B_Account.Text = "Account";
            this.B_Account.UseVisualStyleBackColor = false;
            this.B_Account.Click += new System.EventHandler(this.B_Account_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackgroundImage = global::Geo_Quiz.Properties.Resources.WorldMap_tp;
            this.tableLayoutPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.L_CurrentAcc, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.B_Exit, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.B_Account, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.B_Testing, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.B_Training, 1, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1000, 625);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // B_Exit
            // 
            this.B_Exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.B_Exit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.B_Exit.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.B_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B_Exit.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B_Exit.ForeColor = System.Drawing.SystemColors.GrayText;
            this.B_Exit.Location = new System.Drawing.Point(854, 561);
            this.B_Exit.Margin = new System.Windows.Forms.Padding(10);
            this.B_Exit.Name = "B_Exit";
            this.B_Exit.Size = new System.Drawing.Size(136, 54);
            this.B_Exit.TabIndex = 4;
            this.B_Exit.Text = "Exit App";
            this.B_Exit.UseVisualStyleBackColor = false;
            this.B_Exit.Click += new System.EventHandler(this.B_Exit_Click);
            // 
            // B_Training
            // 
            this.B_Training.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.B_Training.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.B_Training.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B_Training.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B_Training.Location = new System.Drawing.Point(340, 345);
            this.B_Training.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.B_Training.Name = "B_Training";
            this.B_Training.Size = new System.Drawing.Size(319, 90);
            this.B_Training.TabIndex = 2;
            this.B_Training.Text = "Learning Mode";
            this.B_Training.UseVisualStyleBackColor = false;
            this.B_Training.Click += new System.EventHandler(this.B_Training_Click);
            // 
            // L_CurrentAcc
            // 
            this.L_CurrentAcc.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.L_CurrentAcc.AutoSize = true;
            this.L_CurrentAcc.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.L_CurrentAcc.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_CurrentAcc.Location = new System.Drawing.Point(426, 123);
            this.L_CurrentAcc.Margin = new System.Windows.Forms.Padding(3, 0, 3, 10);
            this.L_CurrentAcc.Name = "L_CurrentAcc";
            this.L_CurrentAcc.Size = new System.Drawing.Size(147, 23);
            this.L_CurrentAcc.TabIndex = 8;
            this.L_CurrentAcc.Text = "Current account: ";
            // 
            // UC_MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.tableLayoutPanel1);
            this.DoubleBuffered = true;
            this.Name = "UC_MainMenu";
            this.Size = new System.Drawing.Size(1000, 625);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button B_Testing;
        private System.Windows.Forms.Button B_Account;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button B_Exit;
        private System.Windows.Forms.Button B_Training;
        private System.Windows.Forms.Label L_CurrentAcc;
    }
}

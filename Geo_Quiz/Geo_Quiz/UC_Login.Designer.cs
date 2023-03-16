namespace Geo_Quiz
{
    partial class UC_Login
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
            this.L_Header = new System.Windows.Forms.Label();
            this.TB_Password = new System.Windows.Forms.TextBox();
            this.TB_Username = new System.Windows.Forms.TextBox();
            this.L_Username = new System.Windows.Forms.Label();
            this.L_Password = new System.Windows.Forms.Label();
            this.B_Enter = new System.Windows.Forms.Button();
            this.B_Exit = new System.Windows.Forms.Button();
            this.L_WrongPass = new System.Windows.Forms.Label();
            this.L_ExistingUsername = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.SkyBlue;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Controls.Add(this.L_ExistingUsername, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.L_Header, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.TB_Username, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.L_Username, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.L_Password, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.B_Exit, 2, 7);
            this.tableLayoutPanel1.Controls.Add(this.B_Enter, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.TB_Password, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.L_WrongPass, 1, 6);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 8;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(775, 366);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // L_Header
            // 
            this.L_Header.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.L_Header.AutoSize = true;
            this.L_Header.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_Header.Location = new System.Drawing.Point(156, 37);
            this.L_Header.Margin = new System.Windows.Forms.Padding(1, 1, 1, 20);
            this.L_Header.Name = "L_Header";
            this.L_Header.Size = new System.Drawing.Size(463, 30);
            this.L_Header.TabIndex = 4;
            this.L_Header.Text = "Temp";
            this.L_Header.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TB_Password
            // 
            this.TB_Password.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TB_Password.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_Password.Location = new System.Drawing.Point(295, 226);
            this.TB_Password.Name = "TB_Password";
            this.TB_Password.PasswordChar = '*';
            this.TB_Password.Size = new System.Drawing.Size(185, 27);
            this.TB_Password.TabIndex = 1;
            // 
            // TB_Username
            // 
            this.TB_Username.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TB_Username.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_Username.Location = new System.Drawing.Point(295, 130);
            this.TB_Username.Name = "TB_Username";
            this.TB_Username.Size = new System.Drawing.Size(185, 27);
            this.TB_Username.TabIndex = 0;
            // 
            // L_Username
            // 
            this.L_Username.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.L_Username.AutoSize = true;
            this.L_Username.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_Username.Location = new System.Drawing.Point(339, 96);
            this.L_Username.Margin = new System.Windows.Forms.Padding(0, 0, 0, 8);
            this.L_Username.Name = "L_Username";
            this.L_Username.Size = new System.Drawing.Size(96, 23);
            this.L_Username.TabIndex = 5;
            this.L_Username.Text = "Username:";
            // 
            // L_Password
            // 
            this.L_Password.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.L_Password.AutoSize = true;
            this.L_Password.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_Password.Location = new System.Drawing.Point(342, 192);
            this.L_Password.Margin = new System.Windows.Forms.Padding(0, 0, 0, 8);
            this.L_Password.Name = "L_Password";
            this.L_Password.Size = new System.Drawing.Size(90, 23);
            this.L_Password.TabIndex = 6;
            this.L_Password.Text = "Password:";
            // 
            // B_Enter
            // 
            this.B_Enter.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.B_Enter.AutoSize = true;
            this.B_Enter.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.B_Enter.Location = new System.Drawing.Point(334, 294);
            this.B_Enter.Margin = new System.Windows.Forms.Padding(1, 15, 1, 1);
            this.B_Enter.Name = "B_Enter";
            this.B_Enter.Size = new System.Drawing.Size(107, 50);
            this.B_Enter.TabIndex = 2;
            this.B_Enter.Text = "Enter";
            this.B_Enter.UseVisualStyleBackColor = false;
            this.B_Enter.Click += new System.EventHandler(this.B_Enter_Click);
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
            this.B_Exit.Location = new System.Drawing.Point(690, 321);
            this.B_Exit.Margin = new System.Windows.Forms.Padding(0, 0, 10, 10);
            this.B_Exit.Name = "B_Exit";
            this.B_Exit.Size = new System.Drawing.Size(75, 35);
            this.B_Exit.TabIndex = 3;
            this.B_Exit.Text = "Return";
            this.B_Exit.UseVisualStyleBackColor = false;
            this.B_Exit.Click += new System.EventHandler(this.B_Exit_Click);
            // 
            // L_WrongPass
            // 
            this.L_WrongPass.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.L_WrongPass.AutoSize = true;
            this.L_WrongPass.ForeColor = System.Drawing.Color.Red;
            this.L_WrongPass.Location = new System.Drawing.Point(297, 262);
            this.L_WrongPass.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.L_WrongPass.Name = "L_WrongPass";
            this.L_WrongPass.Size = new System.Drawing.Size(180, 16);
            this.L_WrongPass.TabIndex = 7;
            this.L_WrongPass.Text = "Incorrect password, try again!";
            this.L_WrongPass.Visible = false;
            // 
            // L_ExistingUsername
            // 
            this.L_ExistingUsername.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.L_ExistingUsername.AutoSize = true;
            this.L_ExistingUsername.ForeColor = System.Drawing.Color.Red;
            this.L_ExistingUsername.Location = new System.Drawing.Point(279, 166);
            this.L_ExistingUsername.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.L_ExistingUsername.Name = "L_ExistingUsername";
            this.L_ExistingUsername.Size = new System.Drawing.Size(216, 16);
            this.L_ExistingUsername.TabIndex = 8;
            this.L_ExistingUsername.Text = "Username already exists, try again!";
            this.L_ExistingUsername.Visible = false;
            // 
            // UC_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "UC_Login";
            this.Size = new System.Drawing.Size(775, 366);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label L_Header;
        private System.Windows.Forms.TextBox TB_Password;
        private System.Windows.Forms.TextBox TB_Username;
        private System.Windows.Forms.Label L_Username;
        private System.Windows.Forms.Label L_Password;
        private System.Windows.Forms.Button B_Enter;
        private System.Windows.Forms.Button B_Exit;
        private System.Windows.Forms.Label L_WrongPass;
        private System.Windows.Forms.Label L_ExistingUsername;
    }
}

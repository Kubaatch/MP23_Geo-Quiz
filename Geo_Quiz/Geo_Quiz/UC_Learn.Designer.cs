namespace Geo_Quiz
{
    partial class UC_Learn
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.TB_Capital = new System.Windows.Forms.TextBox();
            this.PB_Image = new System.Windows.Forms.PictureBox();
            this.TB_Country = new System.Windows.Forms.TextBox();
            this.L_Area = new System.Windows.Forms.Label();
            this.L_Population = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Image)).BeginInit();
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
            this.B_Exit.Location = new System.Drawing.Point(914, 579);
            this.B_Exit.Margin = new System.Windows.Forms.Padding(0, 0, 10, 10);
            this.B_Exit.Name = "B_Exit";
            this.B_Exit.Size = new System.Drawing.Size(75, 35);
            this.B_Exit.TabIndex = 25;
            this.B_Exit.Text = "Return";
            this.B_Exit.UseVisualStyleBackColor = false;
            this.B_Exit.Click += new System.EventHandler(this.B_Exit_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.TB_Capital, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.PB_Image, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.TB_Country, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.B_Exit, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.L_Area, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.L_Population, 1, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.22222F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.22222F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.22222F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.22222F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(999, 624);
            this.tableLayoutPanel1.TabIndex = 26;
            // 
            // TB_Capital
            // 
            this.TB_Capital.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TB_Capital.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.TB_Capital.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystemDirectories;
            this.TB_Capital.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_Capital.Location = new System.Drawing.Point(93, 294);
            this.TB_Capital.Name = "TB_Capital";
            this.TB_Capital.Size = new System.Drawing.Size(313, 37);
            this.TB_Capital.TabIndex = 28;
            this.TB_Capital.Text = "Capital";
            this.TB_Capital.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // PB_Image
            // 
            this.PB_Image.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PB_Image.Location = new System.Drawing.Point(570, 132);
            this.PB_Image.Name = "PB_Image";
            this.tableLayoutPanel1.SetRowSpan(this.PB_Image, 2);
            this.PB_Image.Size = new System.Drawing.Size(357, 235);
            this.PB_Image.TabIndex = 26;
            this.PB_Image.TabStop = false;
            // 
            // TB_Country
            // 
            this.TB_Country.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TB_Country.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.TB_Country.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.TB_Country.Font = new System.Drawing.Font("Microsoft YaHei UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_Country.Location = new System.Drawing.Point(51, 163);
            this.TB_Country.Name = "TB_Country";
            this.TB_Country.Size = new System.Drawing.Size(396, 49);
            this.TB_Country.TabIndex = 27;
            this.TB_Country.Text = "Country";
            this.TB_Country.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // L_Area
            // 
            this.L_Area.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.L_Area.AutoSize = true;
            this.L_Area.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_Area.Location = new System.Drawing.Point(211, 422);
            this.L_Area.Name = "L_Area";
            this.L_Area.Size = new System.Drawing.Size(77, 30);
            this.L_Area.TabIndex = 29;
            this.L_Area.Text = "Area: ";
            // 
            // L_Population
            // 
            this.L_Population.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.L_Population.AutoSize = true;
            this.L_Population.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_Population.Location = new System.Drawing.Point(675, 422);
            this.L_Population.Name = "L_Population";
            this.L_Population.Size = new System.Drawing.Size(147, 30);
            this.L_Population.TabIndex = 30;
            this.L_Population.Text = "Population: ";
            // 
            // UC_Learn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "UC_Learn";
            this.Size = new System.Drawing.Size(999, 624);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Image)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button B_Exit;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox PB_Image;
        private System.Windows.Forms.TextBox TB_Country;
        private System.Windows.Forms.TextBox TB_Capital;
        private System.Windows.Forms.Label L_Area;
        private System.Windows.Forms.Label L_Population;
    }
}

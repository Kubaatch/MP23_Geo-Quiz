using System.Windows.Forms;

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
            this.B_Previous = new System.Windows.Forms.Button();
            this.B_Next = new System.Windows.Forms.Button();
            this.TB_Capital = new System.Windows.Forms.TextBox();
            this.TB_Country = new System.Windows.Forms.TextBox();
            this.L_Area = new System.Windows.Forms.Label();
            this.L_Population = new System.Windows.Forms.Label();
            this.PB_Image = new System.Windows.Forms.PictureBox();
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
            this.B_Exit.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B_Exit.ForeColor = System.Drawing.SystemColors.GrayText;
            this.B_Exit.Location = new System.Drawing.Point(914, 579);
            this.B_Exit.Margin = new System.Windows.Forms.Padding(0, 0, 10, 10);
            this.B_Exit.Name = "B_Exit";
            this.B_Exit.Size = new System.Drawing.Size(75, 35);
            this.B_Exit.TabIndex = 5;
            this.B_Exit.Text = "Return";
            this.B_Exit.UseVisualStyleBackColor = false;
            this.B_Exit.Click += new System.EventHandler(this.B_Exit_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tableLayoutPanel1.Controls.Add(this.B_Previous, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.B_Next, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.TB_Capital, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.TB_Country, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.L_Area, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.L_Population, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.B_Exit, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.PB_Image, 1, 1);
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
            this.tableLayoutPanel1.TabStop = false;
            // 
            // B_Previous
            // 
            this.B_Previous.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.B_Previous.BackColor = System.Drawing.Color.Transparent;
            this.B_Previous.Location = new System.Drawing.Point(428, 508);
            this.B_Previous.Name = "B_Previous";
            this.B_Previous.Size = new System.Drawing.Size(118, 46);
            this.B_Previous.TabIndex = 3;
            this.B_Previous.Text = "<---";
            this.B_Previous.UseVisualStyleBackColor = false;
            this.B_Previous.Click += new System.EventHandler(this.B_Previous_Click);
            // 
            // B_Next
            // 
            this.B_Next.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.B_Next.BackColor = System.Drawing.Color.Transparent;
            this.B_Next.Location = new System.Drawing.Point(552, 508);
            this.B_Next.Name = "B_Next";
            this.B_Next.Size = new System.Drawing.Size(118, 46);
            this.B_Next.TabIndex = 4;
            this.B_Next.Text = "---->";
            this.B_Next.UseVisualStyleBackColor = false;
            this.B_Next.Click += new System.EventHandler(this.B_Next_Click);
            // 
            // TB_Capital
            // 
            this.TB_Capital.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TB_Capital.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.TB_Capital.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.TB_Capital.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.TB_Capital.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_Capital.Location = new System.Drawing.Point(47, 293);
            this.TB_Capital.Name = "TB_Capital";
            this.TB_Capital.Size = new System.Drawing.Size(455, 38);
            this.TB_Capital.TabIndex = 2;
            this.TB_Capital.Text = "Capital";
            this.TB_Capital.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TB_Capital.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TB_Capital_KeyPressed);
            // 
            // TB_Country
            // 
            this.TB_Country.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TB_Country.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.TB_Country.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.TB_Country.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.TB_Country.Font = new System.Drawing.Font("Microsoft YaHei", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_Country.Location = new System.Drawing.Point(3, 166);
            this.TB_Country.Name = "TB_Country";
            this.TB_Country.Size = new System.Drawing.Size(543, 43);
            this.TB_Country.TabIndex = 1;
            this.TB_Country.Text = "Country";
            this.TB_Country.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TB_Country.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TB_Country_KeyPressed);
            // 
            // L_Area
            // 
            this.L_Area.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.L_Area.AutoSize = true;
            this.L_Area.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.L_Area.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_Area.Location = new System.Drawing.Point(235, 421);
            this.L_Area.Name = "L_Area";
            this.L_Area.Size = new System.Drawing.Size(79, 32);
            this.L_Area.TabStop = false;
            this.L_Area.Text = "Area: ";
            // 
            // L_Population
            // 
            this.L_Population.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.L_Population.AutoSize = true;
            this.L_Population.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.L_Population.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_Population.Location = new System.Drawing.Point(699, 421);
            this.L_Population.Name = "L_Population";
            this.L_Population.Size = new System.Drawing.Size(149, 32);
            this.L_Population.TabStop = false;
            this.L_Population.Text = "Population: ";
            // 
            // PB_Image
            // 
            this.PB_Image.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PB_Image.BackColor = System.Drawing.Color.Transparent;
            this.PB_Image.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.PB_Image.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PB_Image.Image = global::Geo_Quiz.Properties.Resources.Dall_E_flag;
            this.PB_Image.Location = new System.Drawing.Point(584, 132);
            this.PB_Image.Name = "PB_Image";
            this.tableLayoutPanel1.SetRowSpan(this.PB_Image, 2);
            this.PB_Image.Size = new System.Drawing.Size(379, 235);
            this.PB_Image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PB_Image.TabStop = false;
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
        private System.Windows.Forms.Button B_Previous;
        private System.Windows.Forms.Button B_Next;
    }
}

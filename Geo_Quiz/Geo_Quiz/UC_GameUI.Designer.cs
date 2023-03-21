namespace Geo_Quiz
{
    partial class UC_GameUI
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_GameUI));
            this.B_Exit = new System.Windows.Forms.Button();
            this.LB_Category = new System.Windows.Forms.ListBox();
            this.LB_Continents = new System.Windows.Forms.ListBox();
            this.B_TextBox = new System.Windows.Forms.Button();
            this.B_ABCD = new System.Windows.Forms.Button();
            this.TT_PopUp = new System.Windows.Forms.ToolTip(this.components);
            this.SetQCount = new System.Windows.Forms.DomainUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
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
            this.B_Exit.Location = new System.Drawing.Point(915, 580);
            this.B_Exit.Margin = new System.Windows.Forms.Padding(2, 2, 10, 10);
            this.B_Exit.Name = "B_Exit";
            this.B_Exit.Size = new System.Drawing.Size(75, 35);
            this.B_Exit.TabIndex = 5;
            this.B_Exit.Text = "Return";
            this.B_Exit.UseVisualStyleBackColor = false;
            this.B_Exit.Click += new System.EventHandler(this.B_Exit_Click);
            // 
            // LB_Category
            // 
            this.LB_Category.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LB_Category.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Category.FormattingEnabled = true;
            this.LB_Category.ItemHeight = 30;
            this.LB_Category.Location = new System.Drawing.Point(93, 238);
            this.LB_Category.Name = "LB_Category";
            this.LB_Category.Size = new System.Drawing.Size(147, 124);
            this.LB_Category.TabIndex = 6;
            this.TT_PopUp.SetToolTip(this.LB_Category, resources.GetString("LB_Category.ToolTip"));
            this.LB_Category.SelectedIndexChanged += new System.EventHandler(this.LB_Category_SelectedIndexChanged);
            // 
            // LB_Continents
            // 
            this.LB_Continents.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tableLayoutPanel1.SetColumnSpan(this.LB_Continents, 2);
            this.LB_Continents.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Continents.FormattingEnabled = true;
            this.LB_Continents.ItemHeight = 30;
            this.LB_Continents.Location = new System.Drawing.Point(343, 238);
            this.LB_Continents.Name = "LB_Continents";
            this.LB_Continents.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.LB_Continents.Size = new System.Drawing.Size(312, 184);
            this.LB_Continents.TabIndex = 7;
            this.TT_PopUp.SetToolTip(this.LB_Continents, resources.GetString("LB_Continents.ToolTip"));
            // 
            // B_TextBox
            // 
            this.B_TextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.B_TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B_TextBox.Location = new System.Drawing.Point(336, 508);
            this.B_TextBox.Name = "B_TextBox";
            this.B_TextBox.Size = new System.Drawing.Size(160, 50);
            this.B_TextBox.TabIndex = 8;
            this.B_TextBox.Text = "Written answer";
            this.TT_PopUp.SetToolTip(this.B_TextBox, resources.GetString("B_TextBox.ToolTip"));
            this.B_TextBox.UseVisualStyleBackColor = true;
            this.B_TextBox.Click += new System.EventHandler(this.B_Play_Click);
            // 
            // B_ABCD
            // 
            this.B_ABCD.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.B_ABCD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B_ABCD.Location = new System.Drawing.Point(502, 508);
            this.B_ABCD.Name = "B_ABCD";
            this.B_ABCD.Size = new System.Drawing.Size(160, 50);
            this.B_ABCD.TabIndex = 9;
            this.B_ABCD.Text = "4 options";
            this.TT_PopUp.SetToolTip(this.B_ABCD, resources.GetString("B_ABCD.ToolTip"));
            this.B_ABCD.UseVisualStyleBackColor = true;
            this.B_ABCD.Click += new System.EventHandler(this.B_Play_Click);
            // 
            // TT_PopUp
            // 
            this.TT_PopUp.IsBalloon = true;
            this.TT_PopUp.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.TT_PopUp.ToolTipTitle = "Tip: ";
            // 
            // SetQCount
            // 
            this.SetQCount.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.SetQCount.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SetQCount.Items.Add("5");
            this.SetQCount.Items.Add("10");
            this.SetQCount.Items.Add("20");
            this.SetQCount.Items.Add("25");
            this.SetQCount.Items.Add("50");
            this.SetQCount.Items.Add("75");
            this.SetQCount.Items.Add("100");
            this.SetQCount.Items.Add("Max");
            this.SetQCount.Location = new System.Drawing.Point(776, 238);
            this.SetQCount.Name = "SetQCount";
            this.SetQCount.ReadOnly = true;
            this.SetQCount.Size = new System.Drawing.Size(113, 29);
            this.SetQCount.TabIndex = 17;
            this.SetQCount.Text = "Select!";
            this.TT_PopUp.SetToolTip(this.SetQCount, "Select your desired question count from the scroll bar (up/down).\r\nSelecting \'Max" +
        "\' will give you all questions from your continent selection.\r\nThe default value " +
        "is the maximum amount of questions.");
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.LightGray;
            this.tableLayoutPanel1.SetColumnSpan(this.label2, 2);
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(400, 206);
            this.label2.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(198, 19);
            this.label2.TabIndex = 12;
            this.label2.Text = "Select one or more continents:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightGray;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(761, 206);
            this.label1.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 19);
            this.label1.TabIndex = 13;
            this.label1.Text = "Number of questions:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.LightGray;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(108, 206);
            this.label3.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 19);
            this.label3.TabIndex = 14;
            this.label3.Text = "Choose category:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.LightGray;
            this.tableLayoutPanel1.SetColumnSpan(this.label4, 2);
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(452, 475);
            this.label4.Margin = new System.Windows.Forms.Padding(3, 0, 3, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 20);
            this.label4.TabIndex = 15;
            this.label4.Text = "Start game:";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33332F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.Controls.Add(this.LB_Category, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.B_ABCD, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.B_TextBox, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label4, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.B_Exit, 3, 5);
            this.tableLayoutPanel1.Controls.Add(this.LB_Continents, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.SetQCount, 3, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1000, 625);
            this.tableLayoutPanel1.TabIndex = 18;
            // 
            // UC_GameUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = global::Geo_Quiz.Properties.Resources.WorldMap_tp;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.tableLayoutPanel1);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UC_GameUI";
            this.Size = new System.Drawing.Size(1000, 625);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox LB_Category;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox LB_Continents;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button B_TextBox;
        private System.Windows.Forms.Button B_ABCD;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button B_Exit;
        private System.Windows.Forms.ToolTip TT_PopUp;
        private System.Windows.Forms.DomainUpDown SetQCount;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}

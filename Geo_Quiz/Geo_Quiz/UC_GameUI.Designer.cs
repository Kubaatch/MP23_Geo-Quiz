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
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
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
            this.B_Exit.Margin = new System.Windows.Forms.Padding(2);
            this.B_Exit.Name = "B_Exit";
            this.B_Exit.Size = new System.Drawing.Size(75, 35);
            this.B_Exit.TabIndex = 5;
            this.B_Exit.Text = "Return";
            this.B_Exit.UseVisualStyleBackColor = false;
            this.B_Exit.Click += new System.EventHandler(this.B_Exit_Click);
            // 
            // LB_Category
            // 
            this.LB_Category.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Category.FormattingEnabled = true;
            this.LB_Category.ItemHeight = 30;
            this.LB_Category.Location = new System.Drawing.Point(79, 196);
            this.LB_Category.Name = "LB_Category";
            this.LB_Category.Size = new System.Drawing.Size(147, 124);
            this.LB_Category.TabIndex = 6;
            this.TT_PopUp.SetToolTip(this.LB_Category, "Choose category of questions you want in your test.\nYou have to choose one catego" +
        "ryto be able to play. For written answer population/area, you can be off by up t" +
        "o 20%.");
            // 
            // LB_Continents
            // 
            this.LB_Continents.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Continents.FormattingEnabled = true;
            this.LB_Continents.ItemHeight = 30;
            this.LB_Continents.Location = new System.Drawing.Point(314, 178);
            this.LB_Continents.Name = "LB_Continents";
            this.LB_Continents.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.LB_Continents.Size = new System.Drawing.Size(313, 184);
            this.LB_Continents.TabIndex = 7;
            this.TT_PopUp.SetToolTip(this.LB_Continents, resources.GetString("LB_Continents.ToolTip"));
            // 
            // B_TextBox
            // 
            this.B_TextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.B_TextBox.Location = new System.Drawing.Point(725, 214);
            this.B_TextBox.Name = "B_TextBox";
            this.B_TextBox.Size = new System.Drawing.Size(138, 50);
            this.B_TextBox.TabIndex = 8;
            this.B_TextBox.Text = "Written answer";
            this.TT_PopUp.SetToolTip(this.B_TextBox, "In this mode you will write the answer into a text box.");
            this.B_TextBox.UseVisualStyleBackColor = true;
            this.B_TextBox.Click += new System.EventHandler(this.B_Play_Click);
            // 
            // B_ABCD
            // 
            this.B_ABCD.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.B_ABCD.Location = new System.Drawing.Point(725, 270);
            this.B_ABCD.Name = "B_ABCD";
            this.B_ABCD.Size = new System.Drawing.Size(138, 50);
            this.B_ABCD.TabIndex = 9;
            this.B_ABCD.Text = "4 options";
            this.TT_PopUp.SetToolTip(this.B_ABCD, "In this mode you will be choosing the correct answer from\nfour options, where onl" +
        "y one is correct");
            this.B_ABCD.UseVisualStyleBackColor = true;
            this.B_ABCD.Click += new System.EventHandler(this.B_Play_Click);
            // 
            // TT_PopUp
            // 
            this.TT_PopUp.IsBalloon = true;
            this.TT_PopUp.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.TT_PopUp.ToolTipTitle = "Tip: ";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown1.Location = new System.Drawing.Point(440, 426);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            197,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(65, 33);
            this.numericUpDown1.TabIndex = 10;
            this.TT_PopUp.SetToolTip(this.numericUpDown1, "Enter the number of questions you want to answer.\nYou can use up and down arrows " +
        "or enter a specific number by typing.\nMinimum is 5 and maximum 196");
            this.numericUpDown1.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.LightGray;
            this.label2.Location = new System.Drawing.Point(378, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(186, 16);
            this.label2.TabIndex = 12;
            this.label2.Text = "Select one or more continents:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightGray;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(399, 404);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 19);
            this.label1.TabIndex = 13;
            this.label1.Text = "Number of questions:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.LightGray;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(93, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 19);
            this.label3.TabIndex = 14;
            this.label3.Text = "Choose category:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.LightGray;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(728, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 19);
            this.label4.TabIndex = 15;
            this.label4.Text = "Choose gamemode:";
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
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.B_ABCD);
            this.Controls.Add(this.B_TextBox);
            this.Controls.Add(this.LB_Continents);
            this.Controls.Add(this.LB_Category);
            this.Controls.Add(this.B_Exit);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UC_GameUI";
            this.Size = new System.Drawing.Size(1000, 625);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button B_Exit;
        private System.Windows.Forms.ToolTip TT_PopUp;
    }
}

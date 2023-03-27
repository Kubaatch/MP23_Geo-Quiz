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
            this.L_Continents = new System.Windows.Forms.Label();
            this.L_QCount = new System.Windows.Forms.Label();
            this.L_Category = new System.Windows.Forms.Label();
            this.L_StartGame = new System.Windows.Forms.Label();
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
            this.B_Exit.Location = new System.Drawing.Point(715, 455);
            this.B_Exit.Margin = new System.Windows.Forms.Padding(2, 2, 10, 10);
            this.B_Exit.Name = "B_Exit";
            this.B_Exit.Size = new System.Drawing.Size(75, 35);
            this.B_Exit.TabIndex = 6;
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
            this.LB_Category.Location = new System.Drawing.Point(59, 113);
            this.LB_Category.Name = "LB_Category";
            this.LB_Category.Size = new System.Drawing.Size(147, 124);
            this.LB_Category.TabIndex = 1;
            this.TT_PopUp.SetToolTip(this.LB_Category, resources.GetString("LB_Category.ToolTip"));
            // 
            // LB_Continents
            // 
            this.LB_Continents.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tableLayoutPanel1.SetColumnSpan(this.LB_Continents, 2);
            this.LB_Continents.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Continents.FormattingEnabled = true;
            this.LB_Continents.ItemHeight = 30;
            this.LB_Continents.Location = new System.Drawing.Point(269, 113);
            this.LB_Continents.Name = "LB_Continents";
            this.LB_Continents.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.LB_Continents.Size = new System.Drawing.Size(260, 184);
            this.LB_Continents.TabIndex = 2;
            this.TT_PopUp.SetToolTip(this.LB_Continents, resources.GetString("LB_Continents.ToolTip"));
            // 
            // B_TextBox
            // 
            this.B_TextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.B_TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B_TextBox.Location = new System.Drawing.Point(269, 383);
            this.B_TextBox.Name = "B_TextBox";
            this.B_TextBox.Size = new System.Drawing.Size(127, 64);
            this.B_TextBox.TabIndex = 4;
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
            this.B_ABCD.Location = new System.Drawing.Point(402, 383);
            this.B_ABCD.Name = "B_ABCD";
            this.B_ABCD.Size = new System.Drawing.Size(127, 64);
            this.B_ABCD.TabIndex = 5;
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
            this.SetQCount.Location = new System.Drawing.Point(609, 113);
            this.SetQCount.Name = "SetQCount";
            this.SetQCount.ReadOnly = true;
            this.SetQCount.Size = new System.Drawing.Size(113, 29);
            this.SetQCount.TabIndex = 3;
            this.SetQCount.Text = "Select!";
            this.TT_PopUp.SetToolTip(this.SetQCount, "Select your desired question count from the scroll bar (up/down).\r\nSelecting \'Max" +
        "\' will give you all questions from your continent selection.\r\nThe default value " +
        "is the maximum amount of questions.");
            // 
            // L_Continents
            // 
            this.L_Continents.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.L_Continents.AutoSize = true;
            this.L_Continents.BackColor = System.Drawing.Color.LightGray;
            this.tableLayoutPanel1.SetColumnSpan(this.L_Continents, 2);
            this.L_Continents.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_Continents.Location = new System.Drawing.Point(300, 81);
            this.L_Continents.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.L_Continents.Name = "L_Continents";
            this.L_Continents.Size = new System.Drawing.Size(198, 19);
            this.L_Continents.TabStop = false; ;
            this.L_Continents.Text = "Select one or more continents:";
            // 
            // L_QCount
            // 
            this.L_QCount.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.L_QCount.AutoSize = true;
            this.L_QCount.BackColor = System.Drawing.Color.LightGray;
            this.L_QCount.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_QCount.Location = new System.Drawing.Point(594, 81);
            this.L_QCount.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.L_QCount.Name = "L_QCount";
            this.L_QCount.Size = new System.Drawing.Size(143, 19);
            this.L_QCount.TabStop = false;
            this.L_QCount.Text = "Number of questions:";
            // 
            // L_Category
            // 
            this.L_Category.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.L_Category.AutoSize = true;
            this.L_Category.BackColor = System.Drawing.Color.LightGray;
            this.L_Category.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_Category.Location = new System.Drawing.Point(75, 81);
            this.L_Category.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.L_Category.Name = "L_Category";
            this.L_Category.Size = new System.Drawing.Size(116, 19);
            this.L_Category.TabStop = false;
            this.L_Category.Text = "Choose category:";
            // 
            // L_StartGame
            // 
            this.L_StartGame.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.L_StartGame.AutoSize = true;
            this.L_StartGame.BackColor = System.Drawing.Color.LightGray;
            this.tableLayoutPanel1.SetColumnSpan(this.L_StartGame, 2);
            this.L_StartGame.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_StartGame.Location = new System.Drawing.Point(348, 347);
            this.L_StartGame.Margin = new System.Windows.Forms.Padding(3, 0, 3, 10);
            this.L_StartGame.Name = "L_StartGame";
            this.L_StartGame.Size = new System.Drawing.Size(102, 23);
            this.L_StartGame.TabStop = false;
            this.L_StartGame.Text = "Start game:";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackgroundImage = global::Geo_Quiz.Properties.Resources.WorldMap_tp;
            this.tableLayoutPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33332F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.Controls.Add(this.LB_Category, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.B_ABCD, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.B_TextBox, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.L_Category, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.L_StartGame, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.L_Continents, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.L_QCount, 3, 1);
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
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 500);
            this.tableLayoutPanel1.TabStop = false;
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
            this.Size = new System.Drawing.Size(800, 500);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label L_Category;
        private System.Windows.Forms.ListBox LB_Category;
        private System.Windows.Forms.Label L_Continents;
        private System.Windows.Forms.ListBox LB_Continents;
        private System.Windows.Forms.Label L_StartGame;
        private System.Windows.Forms.Button B_TextBox;
        private System.Windows.Forms.Button B_ABCD;
        private System.Windows.Forms.Label L_QCount;
        private System.Windows.Forms.Button B_Exit;
        private System.Windows.Forms.ToolTip TT_PopUp;
        private System.Windows.Forms.DomainUpDown SetQCount;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}

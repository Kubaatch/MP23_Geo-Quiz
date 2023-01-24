namespace Geo_Quiz
{
    partial class Form1
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
            this.B_Main = new System.Windows.Forms.Button();
            this.TB_Main = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // B_Main
            // 
            this.B_Main.Location = new System.Drawing.Point(320, 100);
            this.B_Main.Name = "B_Main";
            this.B_Main.Size = new System.Drawing.Size(157, 67);
            this.B_Main.TabIndex = 0;
            this.B_Main.Text = "Click this!";
            this.B_Main.UseVisualStyleBackColor = true;
            this.B_Main.Click += new System.EventHandler(this.button1_Click);
            // 
            // TB_Main
            // 
            this.TB_Main.Location = new System.Drawing.Point(320, 258);
            this.TB_Main.Name = "TB_Main";
            this.TB_Main.Size = new System.Drawing.Size(157, 22);
            this.TB_Main.TabIndex = 1;
            this.TB_Main.Text = "Test test test.";
            this.TB_Main.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TB_Main.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TB_Main);
            this.Controls.Add(this.B_Main);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button B_Main;
        private System.Windows.Forms.TextBox TB_Main;
    }
}


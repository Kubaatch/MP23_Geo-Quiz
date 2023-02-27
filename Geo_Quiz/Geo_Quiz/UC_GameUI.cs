using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Geo_Quiz
{
    public partial class UC_GameUI : UserControl
    {
        public UC_GameUI()
        {
            InitializeComponent();
        }
        private int Gamemode = 0;
        private string[] Continents;
        private int QCount = 15;

        private void LB_Category_SelectedIndexChanged(object sender, EventArgs e)
        {
            Gamemode = LB_Category.SelectedIndex;
        }

        private void LB_Continents_SelectedIndexChanged(object sender, EventArgs e)
        {
            Continents = LB_Continents.SelectedItems.Cast<string>().ToArray();
        }

        private void NumericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            QCount = Convert.ToInt32(numericUpDown1.Value);
            if (QCount == 0) { QCount = 1; }
        }

        public void B_TextBox_Click(object sender, EventArgs e)
        {
            if (Continents == null || Continents.Length == 0)
            {
                DialogResult result = MessageBox.Show("You haven't chosen any continents, are you sure you want to continue?"
                    + "\nSelecting no continents works as if all were selected...", "¯\\_(ツ)_/¯", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    UC_TextInput uc = new UC_TextInput(Gamemode, Continents, QCount);
                    uc.Dock = DockStyle.Fill;
                    Controls.Add(uc);
                    uc.BringToFront();
                }
            }
            else
            {
                UC_TextInput uc = new UC_TextInput(Gamemode, Continents, QCount);
                uc.Dock = DockStyle.Fill;
                Controls.Add(uc);
                uc.BringToFront();            
            }            
        }

        private void B_ABCD_Click(object sender, EventArgs e)
        {
            //this.Text = "Game on!";
            MessageBox.Show("This gamemode is not set up yet, sorry...", "¯\\_(ツ)_/¯");

            //add UC_ABCD
        }

        private void B_Exit_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}

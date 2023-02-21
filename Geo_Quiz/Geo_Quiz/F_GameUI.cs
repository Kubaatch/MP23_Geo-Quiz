using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Geo_Quiz
{
    public partial class F_GameUI : Form
    {
        public F_GameUI()
        {
            InitializeComponent();
        }

        private string Gamemode;
        private string[] Continents;
        private int QCount = 15;

        private void LB_Category_SelectedIndexChanged(object sender, EventArgs e)
        {            
            Gamemode = LB_Category.SelectedItem.ToString();
        }

        private void LB_Continents_SelectedIndexChanged(object sender, EventArgs e)
        {
            Continents = LB_Continents.SelectedItems.Cast<string>().ToArray();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            QCount = Convert.ToInt32(numericUpDown1.Value);
        }
        
        public void B_TextBox_Click(object sender, EventArgs e)
        {
            this.Text = "Game on!";                  

            UC_TextInput uc = new UC_TextInput(Gamemode, Continents, QCount);
            uc.Dock = DockStyle.Fill;
            Controls.Add(uc);
            uc.BringToFront();
        }

        private void B_ABCD_Click(object sender, EventArgs e)
        {
            this.Text = "Game on!";

            //add UC_ABCD
        }        

        private void B_Exit_Click(object sender, EventArgs e)
        {
            ActiveForm.Hide();
            F_MainMenu f1 = new F_MainMenu();
            f1.ShowDialog();
        }

        private void T_Category_Popup(object sender, PopupEventArgs e)
        {
            
        }
    }
}

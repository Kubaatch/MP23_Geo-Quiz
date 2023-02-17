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
    public partial class Main_Menu : Form
    {
        public Main_Menu()
        {
            InitializeComponent();
        }

        private void B_Testing_Click(object sender, EventArgs e)
        {
            
        }

        private void B_Training_Click(object sender, EventArgs e)
        {

        }

        private void B_Settings_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 f2 = new Form2();
            f2.ShowDialog();
        }

        private void B_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }         
    }
}

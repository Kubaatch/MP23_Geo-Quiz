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
    public partial class F_Settings : Form
    {
        public F_Settings()
        {
            InitializeComponent();
        }
        private void label1_Click(object sender, EventArgs e)
        {
            //do not delete, has to stay
        }

        private void B_Exit_Click(object sender, EventArgs e)
        {
            ActiveForm.Hide();
            F_MainMenu f1 = new F_MainMenu();
            f1.ShowDialog();
        }
    }
}

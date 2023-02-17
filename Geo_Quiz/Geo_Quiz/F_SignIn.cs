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
    public partial class F_SignIn : Form
    {
        public F_SignIn()
        {
            InitializeComponent();
        }

        private void B_Guest_Click(object sender, EventArgs e)
        {
            Console.Beep(550, 500);
            this.Close();
            //Hide();
            //F_MainMenu f2 = new F_MainMenu();
            //f2.Show();            
        }  
        
        private void B_SignIn_Click(object sender, EventArgs e)
        {
            Hide();
            F_Settings f2 = new F_Settings();
            f2.Show();
        }
    }
}

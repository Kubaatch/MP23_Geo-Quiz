﻿using System;
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
    public partial class UC_Statistics : UserControl
    {
        public UC_Statistics()
        {
            InitializeComponent();
        }

        private void B_Exit_Click(object sender, EventArgs e)
        {
            CloseAllUserControls(this.Parent.Parent.Parent);
        }

            //generated by an AI (ChatGPT)
        private void CloseAllUserControls(Control control)
        {
            foreach (Control childControl in control.Controls)
            {
                if (childControl is UserControl userControl)
                {
                    CloseAllUserControls(userControl);
                    userControl.Dispose();
                }
            }
        }
            //end
    }
}

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
    public partial class UC_Learn : UserControl
    {
        public UC_Learn()
        {
            InitializeComponent();
        }

        private void B_Exit_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}

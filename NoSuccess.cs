﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyProjectInstitute
{
    public partial class NoSuccess : Form
    {
        private int ticks = 1;
        public NoSuccess()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ticks++;
            if (ticks == 3)
            {

                timer1.Stop();
                this.Close();
            }
        }

        private void NoSuccess_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}

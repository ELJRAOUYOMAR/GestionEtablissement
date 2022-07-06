using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyProjectInstitute.Message
{
    public partial class MessageZwin : Form
    {
        private int ticks = 1;
        public MessageZwin()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ticks++;
            if (ticks == 6)
            {

                timer1.Stop();
                this.Close();
            }
        }

        private void MessageZwin_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}

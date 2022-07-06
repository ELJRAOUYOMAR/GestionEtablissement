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
    public partial class ConfirmSuppressionProfesseur : Form
    {
        public ConfirmSuppressionProfesseur()
        {
            InitializeComponent();
        }

        private void ButtonOui_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ButtonNon_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

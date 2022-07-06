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
    public partial class MessageRemplirLabel : Form
    {
        string message;
        public MessageRemplirLabel()
        {
            InitializeComponent();
        }
        public MessageRemplirLabel(string m)
        {
            message = m;
            InitializeComponent();
        }

        private void MessageRemplirLabel_Load(object sender, EventArgs e)
        {
            LabelMessage.Text = message;
        }

        private void ButtonFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

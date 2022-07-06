using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyProjectInstitute.Etudiant
{
    public partial class Cert : Form
    {
        Entity.EducationInstitute education = new Entity.EducationInstitute();

        int IDE;
        public Cert(int id)
        {
            IDE = id;
            InitializeComponent();
        }

        private void Cert_Load(object sender, EventArgs e)
        {

            var req = education.Etudients.FirstOrDefault(x => x.IdEtudient == IDE);
            if (req != null)
            {
                LabelNomComplet.Text = req.NomComplet;
                LabelDateToday.Text = DateTime.Now.ToString();
                LabelAdmin.Text = education.Utilisateurs.FirstOrDefault(x => x.Role == "Admin").NomComplet;
            }
        }
        Bitmap bmp;
        private void ButtonImprimer_Click(object sender, EventArgs e)
        {
            ButtonImprimer.Visible = false;
            ButtonFermer.Visible = false;
            Graphics g = this.CreateGraphics();
            bmp = new Bitmap(this.Size.Width, this.Size.Height, g);
            Graphics ng = Graphics.FromImage(bmp);
            ng.CopyFromScreen(this.Location.X, this.Location.Y, 0, 0, this.Size);
            printPreviewDialog1.ShowDialog();
            this.Close();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bmp, 0, 0);
        }

        private void ButtonFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}

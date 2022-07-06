using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyProjectInstitute.Historique
{
    public partial class MainHistorique : UserControl
    {
        Entity.EducationInstitute education = new Entity.EducationInstitute();
        int IDUser;
        public MainHistorique()
        {
            InitializeComponent();
        }
        public MainHistorique(int id)
        {
            IDUser = id;
            InitializeComponent();
        }


        private void MainHistorique_Load(object sender, EventArgs e)
        {
            string admin = education.Utilisateurs.FirstOrDefault(x => x.IdUtilisateur == IDUser).Role;
            if (admin == "Admin")
            {


                DataGridViewHistorique.DataSource = education.Historiques.Select(x => new
                {
                    x.IdAction,
                    x.Utilisateur.CIN,
                    x.Utilisateur.NomComplet,
                    x.Action,
                    x.dateAction
                }
                ).ToList();
                DataGridViewHistorique.Columns[0].Visible = false;
            }
            else
            {
                DataGridViewHistorique.DataSource = education.Historiques.Where(x=>x.IdUtilisateur==IDUser).Select(x => new
                {
                    x.IdAction,
                    x.Utilisateur.CIN,
                    x.Utilisateur.NomComplet,
                    x.Action,
                    x.dateAction
                }
                ).ToList();
                DataGridViewHistorique.Columns[0].Visible = false;
            }

        }

        private void TextSearch_TextChanged(object sender, EventArgs e)
        {
            string search = TextSearch.Text;
            DataGridViewHistorique.DataSource = education.Historiques.Where(x=>x.Utilisateur.CIN.StartsWith(search)||x.Utilisateur.NomComplet.StartsWith(search)||x.Action.StartsWith(search)||x.dateAction.ToString().StartsWith(search)).Select(x => new
            {
                x.IdAction,
                x.Utilisateur.CIN,
                x.Utilisateur.NomComplet,
                x.Action,
                x.dateAction
            }
            ).ToList();
            DataGridViewHistorique.Columns[0].Visible = false;
        }

        private void TextSearch_Leave(object sender, EventArgs e)
        {
            TextSearch.Visible = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (TextSearch.Visible == false)
                TextSearch.Visible = true;
            else
                TextSearch.Visible = false;
        }

        private void ButtonModifier_Click(object sender, EventArgs e)
        {
            try
            {
                if (DataGridViewHistorique.Rows.Count <= 0)
                {
                    Message.MessageRemplirLabel message = new Message.MessageRemplirLabel("Il n y a pas d'historique!"); message.ShowDialog();
                }
                foreach (DataGridViewRow row in DataGridViewHistorique.Rows)
                {
                    int id = (int)row.Cells[0].Value;
                    var exist = education.Historiques.FirstOrDefault(x => x.IdAction == id);
                    if (row.Selected)
                    {
                        if (exist != null)
                        {
                            education.Historiques.Remove(exist);
                        }
                    }
                }
                education.SaveChanges();
                MainHistorique_Load(sender, e);
                Success success = new Success(); success.Show();
            }
            catch
            {
                NoSuccess no = new NoSuccess();no.Show();
            }
        }

        private void DateTimePickerInfer_ValueChanged(object sender, EventArgs e)
        {
        }
    }
}

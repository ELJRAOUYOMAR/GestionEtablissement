using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyProjectInstitute.Seance
{
    public partial class MainSeance : UserControl
    {
        Entity.EducationInstitute education = new Entity.EducationInstitute();
        MainPage main;
        int IDU;
        public MainSeance()
        {
            InitializeComponent();
        }
        public MainSeance(MainPage p,int id)
        {
            main = p;
            IDU = id;
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (TextSearch.Visible == false)
                TextSearch.Visible = true;
            else
                TextSearch.Visible = false;
        }

        private void TextSearch_TextChanged(object sender, EventArgs e)
        {
            string s = TextSearch.Text;
            DataGridViewSeance.DataSource = education.Seances.Where(x => x.Formation.LibelleFormation.StartsWith(s) || x.Groupe.Libelle.StartsWith(s) || x.Professeur.NomComplet.StartsWith(s) || x.Salle.StartsWith(s) || x.Jour_de_seance.StartsWith(s) || x.Mois_de_seance.StartsWith(s) || x.Heure_Debut.ToString().StartsWith(s) || x.Heure_Fin.ToString().StartsWith(s)).ToList();
        }
        public void LoadSeance()
        {
            DataGridViewSeance.DataSource = education.Seances.Select(x => new
            {
                x.IdSeance,
                x.Année_de_seance,
                x.Mois_de_seance,
                x.Jour_de_seance,
                x.Heure_Debut,
                x.Heure_Fin,
                x.Etat,x.Salle,
                x.Groupe.Libelle,
                x.Formation.LibelleFormation
            }).ToList();
            DataGridViewSeance.Columns[0].Visible = false;

        }
        private void MainSeance_Load(object sender, EventArgs e)
        {
            LoadSeance();
        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            LoadSeance();
        }

        private void TextSearch_Leave(object sender, EventArgs e)
        {
            TextSearch.Visible = false;

        }

        private void ButtonAjouter_Click(object sender, EventArgs e)
        {
            AddSeance add = new AddSeance(this, IDU);
            add.ShowDialog();
        }

        private void ButtonModifier_Click(object sender, EventArgs e)
        {
            int IdSeance = (int)DataGridViewSeance.CurrentRow.Cells[0].Value;
            ModifySeance modify = new ModifySeance(this, IDU,IdSeance);
            modify.ShowDialog();
        }

        private void ButtonSupprimer_Click(object sender, EventArgs e)
        {
            try
            {
                if (DataGridViewSeance.Rows.Count <= 0)
                {
                    Message.MessageRemplirLabel m = new Message.MessageRemplirLabel("Le tableau est vide!"); m.ShowDialog();
                    return;
                }
                foreach (DataGridViewRow row in DataGridViewSeance.Rows)
                {
                    int idS = (int)row.Cells[0].Value;
                    var exist = education.Seances.FirstOrDefault(x => x.IdSeance == idS);
                    if (row.Selected)
                    {
                        if (exist != null)
                        {

                            education.Seances.Remove(exist);
                            education.Historiques.Add(new Entity.Historique { IdUtilisateur = IDU, Action = "Suppression d'une seance", dateAction = DateTime.Now });
                        }
                    }
                }
                Message.ConfirmSuppressionProfesseur confirm = new Message.ConfirmSuppressionProfesseur();
                confirm.LabelMessage.Text = "Voulez vous sûrement supprimer ce(ces)seance";
                confirm.ShowDialog();
                if (confirm.ButtonNon.Checked)
                {
                    return;
                }
                else if (confirm.ButtonOui.Checked)
                {
                    education.SaveChanges();
                    LoadSeance();
                    Success success = new Success(); success.Show();
                }
            }
            catch { NoSuccess no = new NoSuccess();no.Show(); }
        }
    
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyProjectInstitute.Formation
{
    
    public partial class Formation_Group_Professeur : Form
    {
        Entity.EducationInstitute education = new Entity.EducationInstitute();
        MainFormation main;
        int IDF, IDU;
        public Formation_Group_Professeur(MainFormation m,int idf,int idu)
        {
            main = m;
            IDU = idu;
            IDF = idf;
            InitializeComponent();
        }
        private void GridEtud_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int IDG = (int)GridEtud.CurrentRow.Cells[1].Value;
            Message.MessageZwin m = new Message.MessageZwin();
            var exist= education.ProfesseurGroupes.FirstOrDefault(x => x.IdGroupe == IDG);
            if (exist != null)
            {
                m.label1.Text = "participé par " + exist.Professeur.NomComplet;
                m.Show();
            }
            else { return; }
        }

        private void ButtonSupprimer_Click(object sender, EventArgs e)
        {
            try
            {
                if (GridEtud.Rows.Count <= 0)
                {
                    Message.MessageRemplirLabel m = new Message.MessageRemplirLabel("Ce tableau est vide!"); m.ShowDialog();
                    return;
                }
                foreach (DataGridViewRow row in GridEtud.Rows)
                {
                    int IDF= (int)row.Cells[0].Value;
                    int idE = (int)row.Cells[1].Value;
                    var exist = education.FormationGroups.FirstOrDefault(x => x.IDGroup == idE && x.IDFormation==IDF);
                    if (row.Selected)
                    {
                        if (exist != null)
                        {
                            string group = exist.Groupe.Libelle;
                            string formation = exist.Formation.LibelleFormation;
                            education.FormationGroups.Remove(exist);
                        //education.Historiques.Add(new Entity.Historique { IdUtilisateur = IDU, Action = "Suppression de group " + group + " de " + formation, dateAction = DateTime.Now });
                    }
                    }
                }
                Message.ConfirmSuppressionProfesseur confirm = new Message.ConfirmSuppressionProfesseur();
                confirm.LabelMessage.Text = "Voulez vous sûrement supprimer ce(ces)gorupe";
                confirm.ShowDialog();
                if (confirm.ButtonNon.Checked)
                {
                    return;
                }
                else if (confirm.ButtonOui.Checked)
                {
                    education.SaveChanges();
                    Formation_Group_Professeur_Load(sender, e);
                    Success success = new Success(); success.Show();
                }
            }
            catch { NoSuccess no = new NoSuccess(); no.Show(); }
        }
    

        private void Formation_Group_Professeur_Load(object sender, EventArgs e)
        {
            GridEtud.DataSource = education.FormationGroups.Where(x => x.IDFormation == IDF).Select(x => new
            {
                x.IDFormation,
                x.IDGroup,
                x.Groupe.Libelle,
                x.Groupe.MaxPlace,
                date_debut_de_formation = x.Datedebut,
                date_fin_de_formation = x.DateFin
            }).ToList();
            LabelLibele.Text = education.Formations.FirstOrDefault(x => x.IdFormation==IDF).LibelleFormation;
        }
    }
}

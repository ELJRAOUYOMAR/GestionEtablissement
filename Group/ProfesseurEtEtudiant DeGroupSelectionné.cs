using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyProjectInstitute.Group
{
    public partial class ProfesseurEtEtudiant_DeGroupSelectionné : Form
    {
        Entity.EducationInstitute education = new Entity.EducationInstitute();
        int IDG,IDUser;
        public ProfesseurEtEtudiant_DeGroupSelectionné()
        {
            InitializeComponent();
        }
        public ProfesseurEtEtudiant_DeGroupSelectionné(int id,int idU)
        {
            IDG = id;
            IDUser = idU;
            InitializeComponent();
        }
        public string ProfGroup()
        {
            string y = "";
            var req =education.ProfesseurGroupes.FirstOrDefault(x => x.IdGroupe == IDG);
            if (req != null)
            {
                y= req.Professeur.NomComplet;
            }
            return y;
            
        }
        public string LibelleGroup()
        {

            return education.Groupes.FirstOrDefault(x=>x.IdGroupe==IDG).Libelle;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ProfesseurEtEtudiant_DeGroupSelectionné_Load(object sender, EventArgs e)
        {
            try
            {
                labelProf.Text = ProfGroup();
                LabelLibele.Text = LibelleGroup();
                ComboBoxProf.DataSource = education.Professeurs.ToList();
                ComboBoxProf.ValueMember = "IdProf";
                ComboBoxProf.DisplayMember = "NomComplet";
                Entity.Groupe g = education.Groupes.FirstOrDefault(x => x.IdGroupe == IDG);
                var remplirEtud = education.EtudientGroupes.Where(x => x.IdGroupe == IDG);
                GridEtud.DataSource = remplirEtud.Select(x => new
                {
                    x.Etudient.CIN,
                    x.Etudient.NomComplet,
                    x.Etudient.Email,
                    x.Etudient.Telephone,
                    x.Etudient.Sexe
                }).ToList();
            }
            catch
            {
                NoSuccess no = new NoSuccess();no.Show();
            }
        }

        private void GridLoad_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void GridProf_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ComboBoxProf_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                int idProf = (int)ComboBoxProf.SelectedValue;
                var test = education.ProfesseurGroupes.FirstOrDefault(x => x.IdGroupe == IDG && x.IdProfesseur == idProf);
                if (test != null)
                {
                    Message.MessageRemplirLabel m = new Message.MessageRemplirLabel("Ce Professeur a travaillé déjà dans ce group");
                    m.ShowDialog();
                    return;
                }
                var count = education.ProfesseurGroupes.Where(x => x.IdGroupe == IDG);
                if (count.Count() >= 1)
                {
                    Message.MessageRemplirLabel m = new Message.MessageRemplirLabel("Ce groupe ayant un professeur");
                    m.ShowDialog();
                    return;
                }
                education.ProfesseurGroupes.Add(new Entity.ProfesseurGroupe
                {
                    IdGroupe = IDG,
                    IdProfesseur=idProf
                }) ;
                education.Historiques.Add(new Entity.Historique
                {
                    IdUtilisateur = IDUser,
                    Action = "Participer un professeurs pour le groupe " + LibelleGroup(),
                    dateAction = DateTime.Now
                });
                Message.ConfirmSuppressionProfesseur confirm = new Message.ConfirmSuppressionProfesseur();
                confirm.LabelMessage.Text = "Voulez vous sûrement engagé ce professeur ";
                confirm.LabelMessage2.Text = "dans le groupe de "+LibelleGroup();
                confirm.LabelMessage2.Visible = true;
                confirm.ShowDialog();
                if (confirm.ButtonNon.Checked)
                {
                    return;
                }
                else if (confirm.ButtonOui.Checked)
                {
                    education.SaveChanges();
                    Success success = new Success(); success.Show();
                    ProfesseurEtEtudiant_DeGroupSelectionné_Load(sender, e);
                }
                }
                catch
                {
                    NoSuccess no = new NoSuccess(); no.Show();
                }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

        }

        private void ComboBoxProf_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ButtonSupprimer_Click(object sender, EventArgs e)
        {
            try
            {
                var delete = education.ProfesseurGroupes.FirstOrDefault(x => x.IdGroupe == IDG);
                if (delete == null)
                {
                    return;
                }
                if (delete != null)
                {
                    education.ProfesseurGroupes.Remove(delete);
                }
                education.Historiques.Add(new Entity.Historique
                {
                    IdUtilisateur = IDUser,
                    Action = "Suppression du professeurs de groupe " + LibelleGroup(),
                    dateAction = DateTime.Now
                });
                Message.ConfirmSuppressionProfesseur confirm = new Message.ConfirmSuppressionProfesseur();
                confirm.LabelMessage.Text = "Voulez vous sûrement supprimer ce professeur";
                confirm.LabelMessage2.Text = "dans ce group";
                confirm.LabelMessage2.Visible = true;
                confirm.ShowDialog();
                if (confirm.ButtonNon.Checked)
                {
                    return;
                }
                else if (confirm.ButtonOui.Checked)
                {
                    education.SaveChanges();
                    Success success = new Success(); success.Show();
                    ProfesseurEtEtudiant_DeGroupSelectionné_Load(sender, e);
                }
            }
            catch { NoSuccess no = new NoSuccess();no.Show(); }
        }
    }
}

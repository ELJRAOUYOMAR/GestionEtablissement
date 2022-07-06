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
    public partial class MainEtudiant : UserControl
    {
        int IDUser;
        MainPage mainPage;
        Entity.EducationInstitute education = new Entity.EducationInstitute();
        public MainEtudiant()
        {
            InitializeComponent();
        }
        public MainEtudiant(int id,MainPage m)
        {
            IDUser = id;
            mainPage = m;
            InitializeComponent();
        }

        public void loadEtudiant()
        {
            label1.Text = education.Etudients.Count().ToString()+" Etudiants";
            ComboBoxSort.Items.Clear();
            ComboBoxSort.Items.Add("Nom Complet");
            ComboBoxSort.Items.Add("Date naissance");
            ComboBoxSort.Items.Add("Âge");
            DataGridViewEtudiant.DataSource = education.Etudients.Select(x => new
            {
                x.IdEtudient,
                x.CIN,
                x.NomComplet,
                x.Email,
                x.Telephone,
                x.Sexe,
                x.dateNaissance,
                x.Age

            }).ToList();
            DataGridViewEtudiant.Columns[0].Visible = false;
            var req = education.Utilisateurs.FirstOrDefault(x => x.IdUtilisateur == IDUser);
            if (req.Role == "Admin")
            {
                ButtonCertificat.Enabled = true;
            }
            else
            {
                ButtonCertificat.Enabled = false;
            }
        }
        private void MainEtudiant_Load(object sender, EventArgs e)
        {

            loadEtudiant();

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
            string search = TextSearch.Text;
            DataGridViewEtudiant.DataSource = education.Etudients.Where(x => x.CIN.StartsWith(search)|| x.NomComplet.StartsWith(search) || x.Age.ToString().StartsWith(search) || x.dateNaissance.ToString().StartsWith(search) || x.Telephone.StartsWith(search) || x.Email.StartsWith(search) || x.Sexe.ToString().StartsWith(search)).Select(x => new
            {
                x.IdEtudient,
                x.CIN,
                x.NomComplet,
                x.Email,
                x.Telephone,
                x.Sexe,
                x.dateNaissance,
                x.Age
            }).ToList();
            DataGridViewEtudiant.Columns[0].Visible = false;

        }

        private void TextSearch_Leave(object sender, EventArgs e)
        {
            TextSearch.Visible = false;
        }

        private void ComboBoxSort_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboBoxSort.SelectedIndex == 0)
            {
                DataGridViewEtudiant.DataSource = education.Etudients.Select(x => new
                {
                    x.IdEtudient,
                    x.CIN,
                    x.NomComplet,
                    x.Email,
                    x.Telephone,
                    x.Sexe,
                    x.dateNaissance,
                    x.Age

                }).OrderBy(x => x.NomComplet).ToList();
                DataGridViewEtudiant.Columns[0].Visible = false;
            }
            else if(ComboBoxSort.SelectedIndex == 1)
            {
                DataGridViewEtudiant.DataSource = education.Etudients.Select(x => new
                {
                    x.IdEtudient,
                    x.CIN,
                    x.NomComplet,
                    x.Email,
                    x.Telephone,
                    x.Sexe,
                    x.dateNaissance,
                    x.Age

                }).OrderBy(x => x.dateNaissance).ToList();
                DataGridViewEtudiant.Columns[0].Visible = false;
            }
            else if(ComboBoxSort.SelectedIndex == 2)
            {
                DataGridViewEtudiant.DataSource = education.Etudients.Select(x => new
                {
                    x.IdEtudient,
                    x.CIN,
                    x.NomComplet,
                    x.Email,
                    x.Telephone,
                    x.Sexe,
                    x.dateNaissance,
                    x.Age

                }).OrderBy(x => x.Age).ToList();
                DataGridViewEtudiant.Columns[0].Visible = false;
            }
        }

        private void ButtonAjouter_Click(object sender, EventArgs e)
        {
            AddEtudiant add = new AddEtudiant(this, IDUser);
            add.ShowDialog();
        }

        private void ButtonModifier_Click(object sender, EventArgs e)
        {
            if (DataGridViewEtudiant.Rows.Count <= 0)
            {
                Message.MessageRemplirLabel m = new Message.MessageRemplirLabel("Il n y a pas des etudiantes ici pour la modification");
                m.ShowDialog(); return;
            }
            int id = (int)DataGridViewEtudiant.CurrentRow.Cells[0].Value;
            ModifierEtudiant modify=new ModifierEtudiant(this,IDUser,id);
            modify.ShowDialog();
        }

        private void ButtonSupprimer_Click(object sender, EventArgs e)
        {
            if (DataGridViewEtudiant.Rows.Count <= 0)
            {
                Message.MessageRemplirLabel m = new Message.MessageRemplirLabel("Ce tableau est vide!"); m.ShowDialog();
                return;
            }
            foreach (DataGridViewRow row in DataGridViewEtudiant.Rows)
            {
                int idE = (int)row.Cells[0].Value;
                var exist = education.Etudients.FirstOrDefault(x => x.IdEtudient == idE);
                if (row.Selected)
                {
                    if (exist != null)
                    {

                        education.Etudients.Remove(exist);
                        education.Historiques.Add(new Entity.Historique { IdUtilisateur = IDUser, Action = "Suppression d'un Etudiant", dateAction = DateTime.Now });
                    }
                    var existInGroup = education.EtudientGroupes.Where(x => x.IdEtudient == idE);
                    foreach (var i in existInGroup)
                    {
                        education.EtudientGroupes.Remove(i);
                    }
                    var existInAbsence = education.AbsenceEtudients.Where(x => x.IdEtudient == idE);
                    foreach (var i in existInAbsence)
                    {
                        education.AbsenceEtudients.Remove(i);
                    }
                    var existInPiece = education.PieceEtudients.Where(x => x.IdEtudient == idE);
                    foreach (var i in existInPiece)
                    {
                        education.PieceEtudients.Remove(i);
                    }



                }
            }
            Message.ConfirmSuppressionProfesseur confirm = new Message.ConfirmSuppressionProfesseur();
            confirm.LabelMessage.Text = "Voulez vous sûrement supprimer ce(ces)Etudiant";
            confirm.LabelMessage2.Text = "peur être il y a de(des)relations";
            confirm.LabelMessage2.Visible = true;
            confirm.ShowDialog();
            if (confirm.ButtonNon.Checked)
            {
                return;
            }
            else if (confirm.ButtonOui.Checked)
            {
                education.SaveChanges();
                loadEtudiant();
                Success success = new Success(); success.Show();
            }
        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            loadEtudiant();
        }

        private void ComboBoxProf_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string libelleG = ComboBoxEtudiant.Text;
            Group.MainGroup main = new Group.MainGroup();
            mainPage.ButtonGroup.Checked = true;
            mainPage.addForm(main);
            //main.DataGridViewGroup.DataSource = education.Groupes.Where(x => x.Libelle == libelleG).ToList();

            foreach (DataGridViewRow row in main.DataGridViewGroup.Rows)
            {
                if (row.Cells[1].Value.ToString() == libelleG)
                {
                    row.Selected = true;
                }
                else
                {
                    row.Selected = false;
                }
            }
        }

        private void DataGridViewEtudiant_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (DataGridViewEtudiant.Rows.Count <= 0)
                    return;
                int IDProf = (int)DataGridViewEtudiant.CurrentRow.Cells[0].Value;
                ComboBoxEtudiant.DataSource = education.EtudientGroupes.Where(x => x.IdEtudient == IDProf).Select(x => new
                {
                    x.IdGroupe,
                    x.Groupe.Libelle
                }).ToList();
                ComboBoxEtudiant.DisplayMember = "Libelle";
                ComboBoxEtudiant.ValueMember = "IdGroupe";
            }
            catch { return; }
        }

        private void DataGridViewEtudiant_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void ComboBoxEtudiant_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (ComboBoxEtudiant.Text == "")
                {
                    TextBoxFormation.Text = "";
                }
                if (ComboBoxEtudiant.SelectedValue != null)
                {
                    int idG = (int)ComboBoxEtudiant.SelectedValue;
                    var FG = education.FormationGroups.FirstOrDefault(x => x.IDGroup == idG);
                    if (FG != null)
                    {
                        TextBoxFormation.Text = FG.Formation.LibelleFormation;
                    }
                    else { TextBoxFormation.Text = ""; }


                }
            }
            catch { return; }
        }

        private void ComboBoxEtudiant_MouseHover(object sender, EventArgs e)
        {
           
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            int IDE = (int)DataGridViewEtudiant.CurrentRow.Cells[0].Value;
            Cert c = new Cert(IDE);
            c.Show();

            
        }
    }
}

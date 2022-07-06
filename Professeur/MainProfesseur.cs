using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyProjectInstitute.Professeur
{
    public partial class MainProfesseur : UserControl
    {
        Entity.EducationInstitute education = new Entity.EducationInstitute();
        int IDUser;
        MainPage mainPage;
        public MainProfesseur()
        {
            InitializeComponent();
        }
        public MainProfesseur(int id,MainPage m)
        {
            IDUser = id;
            mainPage = m;
            InitializeComponent();
        }

        private void ButtonAjouter_Click(object sender, EventArgs e)
        {
            
            Professeur.AddProf add = new AddProf(this,IDUser);
            add.ShowDialog();
        }
        public void loadProf()
        {
            label1.Text = education.Professeurs.Count().ToString()+"Professeurs";
            DataGridViewProfesseur.DataSource = education.Professeurs.Select(x=>new { 
                x.IdProf,x.CIN,x.Email,x.NomComplet,
                x.Adresse,x.Telephone,x.Sexe,x.DateNaissance,
                x.age,x.Salaire

            }).ToList();
            DataGridViewProfesseur.Columns[0].Visible = false;
        }

        private void MainProfesseur_Load(object sender, EventArgs e)
        {
            
            loadProf();
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
            DataGridViewProfesseur.DataSource = education.Professeurs.Where(x =>x.CIN.StartsWith(search)|| x.Email.StartsWith(search)|| x.Adresse.StartsWith(search) || x.age.ToString().StartsWith(search)|| x.Adresse.StartsWith(search) || x.DateNaissance.ToString().StartsWith(search) || x.NomComplet.StartsWith(search) || x.Sexe.StartsWith(search) || x.Telephone.StartsWith(search)).Select(x=>new {
                x.IdProf,
                x.CIN,
                x.Email,
                x.NomComplet,
                x.Adresse,
                x.Telephone,
                x.Sexe,
                x.DateNaissance,
                x.age,
                x.Salaire
            }).ToList();
        }

        private void TextSearch_Leave(object sender, EventArgs e)
        {
            TextSearch.Visible = false;
        }

        private void DateTimePickerInfer_ValueChanged(object sender, EventArgs e)
        {
            if (DateTimePickerInfer.Value > dateTimepickerSup.Value)
            {
                Message.MessageRemplirLabel message = new Message.MessageRemplirLabel("La date debut doit inférieur àa la date fin");
                message.Show();
                return;
            }                
            DataGridViewProfesseur.DataSource = education.Professeurs.Where(x => x.DateNaissance < dateTimepickerSup.Value && x.DateNaissance > DateTimePickerInfer.Value).Select(x=>new {
                x.IdProf,
                x.CIN,
                x.Email,
                x.NomComplet,
                x.Adresse,
                x.Telephone,
                x.Sexe,
                x.DateNaissance,
                x.age,
                x.Salaire

            }).ToList();
        }

        private void dateTimepickerSup_ValueChanged(object sender, EventArgs e)
        {
            DateTimePickerInfer_ValueChanged(sender, e);
        }

        private void ButtonModifier_Click(object sender, EventArgs e)
        {
            if (DataGridViewProfesseur.Rows.Count <= 0)
            {
                Message.MessageRemplirLabel m = new Message.MessageRemplirLabel("Il n y a pas les professeurs ici pour la modification");
                m.ShowDialog();return;
            }
            int id = (int)DataGridViewProfesseur.CurrentRow.Cells[0].Value;
            Professeur.ModifyProfesseur modify = new ModifyProfesseur(this,id, IDUser);
            modify.ShowDialog();
        }


        public void closee(Form form)
        {
            form.Close();
        }
        private void ButtonSupprimer_Click(object sender, EventArgs e)
        {
            if (DataGridViewProfesseur.Rows.Count <= 0)
            {
                Message.MessageRemplirLabel m = new Message.MessageRemplirLabel("Ce tableau est vide!");m.ShowDialog();
                return;
            }
            foreach (DataGridViewRow row in DataGridViewProfesseur.Rows)
            {
                int idP = (int)row.Cells[0].Value;
                var exist = education.Professeurs.FirstOrDefault(x => x.IdProf==idP);
                if (row.Selected)
                {
                    if (exist != null)
                    {
                        
                            education.Professeurs.Remove(exist);
                            education.Historiques.Add(new Entity.Historique 
                            { IdUtilisateur = IDUser, 
                                Action = "Suppression d'un professeur", 
                                dateAction = DateTime.Now
                            });
                    }
                }
            }
            Message.ConfirmSuppressionProfesseur confirm = new Message.ConfirmSuppressionProfesseur();
            confirm.LabelMessage.Text = "Voulez vous sûrement supprimer ce(ces)professeur";
            confirm.ShowDialog();
            if (confirm.ButtonNon.Checked)
            {
                confirm.Close();
                return;
            }
            else if (confirm.ButtonOui.Checked)
            {
                education.SaveChanges();
                loadProf();
                closee(confirm);
                Success success = new Success(); success.Show();
            }



        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            loadProf();
        }

        private void DataGridViewProfesseur_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           

        }

        private void DataGridViewProfesseur_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void DataGridViewProfesseur_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void DataGridViewProfesseur_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (DataGridViewProfesseur.Rows.Count <= 0)
                    return;
                int IDProf = (int)DataGridViewProfesseur.CurrentRow.Cells[0].Value;
                ComboBoxProf.DataSource = education.ProfesseurGroupes.Where(x => x.IdProfesseur == IDProf).Select(x => new
                {
                    x.IdGroupe,
                    x.Groupe.Libelle
                }).ToList();
                ComboBoxProf.DisplayMember = "Libelle";
                ComboBoxProf.ValueMember = "IdGroupe";
            }
            catch { return; }
        }

        private void ComboBoxProf_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                
                int idG = (int)ComboBoxProf.SelectedValue;
                if (ComboBoxProf.SelectedValue != null)
                {
                    if (ComboBoxProf.Text == "")
                    {
                        TextBoxFormation.Text = "";
                    }
                    var FG = education.FormationGroups.FirstOrDefault(x => x.IDGroup == idG);
                    if (FG != null)
                    {
                        TextBoxFormation.Text = FG.Formation.LibelleFormation;
                    }
                }
                else { TextBoxFormation.Text = ""; }
            }
            catch { return; }

        }

        private void ComboBoxProf_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string libelleG = ComboBoxProf.Text;
            Group.MainGroup main = new Group.MainGroup();
            mainPage.ButtonGroup.Checked=true;
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

        private void ComboBoxProf_MouseHover(object sender, EventArgs e)
        {
            
        }
    }
}

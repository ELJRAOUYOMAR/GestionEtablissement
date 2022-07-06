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
    public partial class MainFormation : UserControl
    {
        Entity.EducationInstitute education = new Entity.EducationInstitute();
        int IDUser;
        MainPage main;
        public MainFormation(MainPage p,int id)
        {
            main = p;
            IDUser = id;
            InitializeComponent();
        }
        public MainFormation()
        {
            InitializeComponent();
        }

        public int NumberOfFormations(DataGridView dataGrid)
        {
            int x = 0;
            foreach(DataGridViewRow row in dataGrid.Rows)
            {
                x++;
            }
            return x;
        }
        public  void loadFormation()
        {
            DataGridFormation.DataSource = education.Formations.Select(x => new
            {

                x.IdFormation,
                x.LibelleFormation
            }).ToList();
            DataGridFormation.Columns[0].Visible = false;
            label1.Text = NumberOfFormations(DataGridFormation).ToString();

        }

        private void MainFormation_Load(object sender, EventArgs e)
        {
            DataGridFormation.DataSource = education.Formations.Select(x => new
            {

                x.IdFormation,
                x.LibelleFormation
            }).ToList() ;
            DataGridFormation.Columns[0].Visible = false;
            label1.Text = NumberOfFormations(DataGridFormation).ToString();
            ComboBoxGroup.DataSource = education.Groupes.ToList();
            ComboBoxGroup.DisplayMember = "Libelle";
            ComboBoxGroup.ValueMember = "IdGroupe";

        }

        private void LoadPanel_Paint(object sender, PaintEventArgs e)
        {


        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (guna2TextBox1.Visible == false)
            {
                guna2TextBox1.Visible = true;
                guna2TextBox1.Focus();
            }
            else
                guna2TextBox1.Visible = false;
        }

        private void guna2TextBox1_Leave(object sender, EventArgs e)
        {
            guna2TextBox1.Visible = false;
        }
        private void ButtonpanelAjouetr_Click(object sender, EventArgs e)
        {
            
                string libelle = TextLibelle.Text;
                var ajouterFormation = education.Formations.FirstOrDefault(x => x.LibelleFormation == libelle);
                if (ajouterFormation == null)
                {
                    education.Formations.Add(new Entity.Formation { LibelleFormation = TextLibelle.Text});
                education.Historiques.Add(new Entity.Historique
                {
                    Action = "L'ajout d'une formation " + libelle + " à" + TextLibelle.Text,
                    dateAction = DateTime.Now,
                    IdUtilisateur = IDUser
                });
                education.SaveChanges();
                loadFormation();
                    Success success = new Success();
                    success.Show();
                }
                else
                {
                    NoSuccess noSuccess = new NoSuccess();
                    noSuccess.Show();
                }
            
            
        }

        private void ButtonAjouter_Click(object sender, EventArgs e)
        {
            PanelAjouter.Visible = true;

        }

        private void ButtonPanelAnnuler_Click(object sender, EventArgs e)
        {
            PanelAjouter.Visible = false;
            TextLibelle.Clear();
        }
        private void ButtonSupprimer_Click(object sender, EventArgs e)
        {
            
            foreach (DataGridViewRow row in DataGridFormation.Rows)
            {
                int IdFormation = (int)row.Cells[0].Value;
                var delete = education.Formations.FirstOrDefault(x => x.IdFormation == IdFormation);
                var autre2=education.ProfesseurFormations.Where(x => x.IdFormation == IdFormation);

                if (row.Selected)
                {
                    if (delete != null)
                    {
                        education.Formations.Remove(delete);
                        education.Historiques.Add(new Entity.Historique
                        {
                            Action = "Suppression d'une(des)formation(s)",
                            dateAction = DateTime.Now,
                            IdUtilisateur = IDUser
                        });
                        foreach (var i in autre2)
                        {
                            education.ProfesseurFormations.Remove(i);

                        }
                        Success success = new Success();
                        success.Show();
                    }
                }
            }
            Message.ConfirmSuppressionProfesseur confirm = new Message.ConfirmSuppressionProfesseur();
            confirm.LabelMessage.Text = "Voulez vous sûrement supprimer ce(ces)Formations peut être";
            confirm.LabelMessage2.Text = "il(ils)y a des relations avec autres tables";
            confirm.LabelMessage2.Visible = true;
            confirm.ShowDialog();
            if (confirm.ButtonNon.Checked)
            {
                confirm.Close();
                return;
            }
            else if (confirm.ButtonOui.Checked)
            {
                education.SaveChanges();
                loadFormation();
                Success success = new Success(); success.Show();
            }
        }

        private void ButtonModifier_Click(object sender, EventArgs e)
        {
            int idF = (int)DataGridFormation.CurrentRow.Cells[0].Value;
            string LibelleF = DataGridFormation.CurrentRow.Cells[1].Value.ToString();
            ModiferFormation m = new ModiferFormation(this, idF, LibelleF, IDUser);
            m.ShowDialog();
        }   

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
            var text = guna2TextBox1.Text;
            DataGridFormation.DataSource = education.Formations.Where(x => x.LibelleFormation.StartsWith(text)).Select(x=>new {
                x.IdFormation,
                x.LibelleFormation
            }).ToList();
            DataGridFormation.Columns[0].Visible = false;
        }

        private void guna2Separator2_Click(object sender, EventArgs e)
        {

        }

        private void TextLoad_TextChanged(object sender, EventArgs e)
        {
            ComboBoxGroup.DataSource = education.Groupes.Where(x => x.Libelle.StartsWith(x.Libelle)).ToList();
            ComboBoxGroup.DisplayMember = "Libelle";
            ComboBoxGroup.ValueMember = "IdGroupe";
        }

        private void ButtonGroupFormation_Click(object sender, EventArgs e)
        {
            try
            {
                if (DataGridFormation.Rows.Count <= 0)
                {
                    Message.MessageRemplirLabel m = new Message.MessageRemplirLabel("Le tableau est vide");
                    m.ShowDialog();
                    return;
                }
                int idf = (int)DataGridFormation.CurrentRow.Cells[0].Value;
                int idgroup = (int)ComboBoxGroup.SelectedValue;
                var test = education.FormationGroups.FirstOrDefault(x => x.IDFormation == idf && x.IDGroup == idgroup);
                if (test != null)
                {
                    Message.MessageRemplirLabel m = new Message.MessageRemplirLabel("Ce groupe est déjà dans cette formation");
                    m.ShowDialog();
                    return;
                }
                education.FormationGroups.Add(new Entity.FormationGroup
                {
                    IDGroup = idgroup,
                    IDFormation = idf,
                    Datedebut = DateDebut.Value,
                    DateFin = DateFin.Value

                }) ;
                string libeleG = education.Groupes.FirstOrDefault(x => x.IdGroupe == idgroup).Libelle;
                string libeleF = education.Formations.FirstOrDefault(x => x.IdFormation == idf).LibelleFormation;
                //education.Historiques.Add(new Entity.Historique
                //{
                //    Action = "engager le gorupe" + libeleG + " dans la formation " + libeleF,
                //    dateAction = DateTime.Now,
                //    IdUtilisateur = IDUser

                //}) ;
                education.SaveChanges();
                Success s = new Success(); s.Show();

            }
            catch
            {
                NoSuccess no = new NoSuccess(); no.Show();
            }
        }

        private void DataGridFormation_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            

        }

        private void DataGridFormation_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DataGridFormation_DoubleClick(object sender, EventArgs e)
        {
            int idf = (int)DataGridFormation.CurrentRow.Cells[0].Value;
            Formation_Group_Professeur g = new Formation_Group_Professeur(this, idf, IDUser);
            g.Show();
        }
    }
}

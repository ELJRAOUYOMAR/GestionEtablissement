using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace MyProjectInstitute.Compte
{
    public partial class MainCompte : UserControl
    {
        Entity.EducationInstitute education = new Entity.EducationInstitute();
        MainPage page;
        string imageUrl = null;
        OpenFileDialog f = new OpenFileDialog();
        Image imagePiece;
        int IDU;
        public MainCompte(MainPage p,int id)
        {
            page = p;
            IDU = id;
            InitializeComponent();
        }
        public MainCompte()
        {

            InitializeComponent();
        }
        public void load()
        {
            label1.Text = education.Utilisateurs.Count().ToString() + " Compte";
            DataGridViewCompte.DataSource = education.Utilisateurs.Where(x=>x.Role=="Utilisateur").Select(x => new
            {
                x.IdUtilisateur,
                x.CIN,
                x.NomComplet,
                x.Telephone,
                x.Email,
                x.Role,
                x.Photo,
            }).ToList();
            DataGridViewCompte.Columns[0].Visible = false;
            DataGridViewCompte.Columns[6].Visible = false;
        }
        private void MainCompte_Load(object sender, EventArgs e)
        {
            load();
            DataGridViewCompte.Rows[0].ReadOnly=true;
        }
        private void ButtonAjouter_Click(object sender, EventArgs e)
        {
            ButtonPanelAjouter.Text = "Ajouter";
            panel1.Visible = true;

        }
        private void guna2Button3_Click(object sender, EventArgs e)
        {
            if (f.ShowDialog() == DialogResult.OK)
            {
                imageUrl = f.FileName;
                pictureBoxImage.Image = Image.FromFile(imageUrl);
                imagePiece = Image.FromFile(f.FileName);
            }
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (TextSearch.Visible == false)
                TextSearch.Visible = true;
            else
                TextSearch.Visible = false;
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
            string search = TextSearch.Text;
            DataGridViewCompte.DataSource = education.Utilisateurs.Where(x => x.Email.StartsWith(search) || x.CIN.StartsWith(search) || x.NomComplet.StartsWith(search) || x.Role.StartsWith(search) || x.Telephone.StartsWith(search)).Select(x => new
            {
                x.IdUtilisateur,
                x.CIN,
                x.NomComplet,
                x.Telephone,
                x.Email,
                x.Role,
                x.Photo,
            }).ToList();
        }

        private void guna2TextBox1_Leave(object sender, EventArgs e)
        {
            TextSearch.Visible = false;
        }

        public void addForm(UserControl F)
        {

            F.Dock = DockStyle.Fill;
            page.LoadPanel.Controls.Clear();
            page.LoadPanel.Controls.Add(F);
            F.BringToFront();
        }
        private void MainCompte_Leave(object sender, EventArgs e)
        {
            //if (TextSearch.Text != "" || panel1.Visible == true)
            //{
            //    page.ButtonFormation.Enabled = false;
            //    page.ButtonEtudiant.Enabled = false;
            //    page.ButtonExamen.Enabled = false;
            //    page.ButtonGroup.Enabled = false;
            //    page.ButtonProfesseur.Enabled = false;
            //    page.ButtonSeance.Enabled = false;
            //    page.Buttondash.Enabled = false;
            //    page.ButtonCompte.Enabled = false;
            //    page.ButtonAbsence.Enabled = false;
            //}
            //else
            //{
            //    page.ButtonFormation.Enabled = true;
            //    page.ButtonEtudiant.Enabled = true;
            //    page.ButtonExamen.Enabled = true;
            //    page.ButtonGroup.Enabled = true;
            //    page.ButtonProfesseur.Enabled = true;
            //    page.ButtonSeance.Enabled = true;
            //    page.Buttondash.Enabled = true;
            //    page.ButtonCompte.Enabled = true;
            //    page.ButtonAbsence.Enabled = true;
            //}
            
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            try
            {
                load();
                panel1.Visible = false;
                TextSearch.Text = "";
                
            }
            catch { return; }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            textEmail.Text = "";
            textNom.Text = "";
            textpassword.Text = "";
            TextTelephone.Text = "";
            TextCIN.Text = "";
            pictureBoxImage.Image = null;
        }
        public object cell(int i)
        {
            return DataGridViewCompte.CurrentRow.Cells[i].Value;
        }
        private void ButtonModifier_Click(object sender, EventArgs e)
        {
            int id =(int) DataGridViewCompte.CurrentRow.Cells[0].Value;
            Compte.ModifierCompte modifier = new ModifierCompte(this);
            if (cell(1) == null || cell(2) == null || cell(3) == null || cell(4) == null || cell(5) == null || cell(6) == null)
            {
                modifier.ShowDialog();
                return;
            }
            modifier.ShowDialog();
        }
        private void ButtonPanelAjouter_Click(object sender, EventArgs e)
        {
            try
            {
                if (textEmail.Text == "")
                {
                    textEmail.ShadowDecoration.Color = Color.Red;
                    textEmail.ShadowDecoration.Depth = 30;
                    return;
                }
                if (textpassword.Text == "")
                {
                    textpassword.ShadowDecoration.Color = Color.Red;
                    textpassword.ShadowDecoration.Depth = 30;
                    return;
                }
                if (textNom.Text == "")
                {
                    textNom.ShadowDecoration.Color = Color.Red;
                    textNom.ShadowDecoration.Depth = 30;
                    return;
                }
                if (TextTelephone.Text == "")
                {
                    TextTelephone.ShadowDecoration.Color = Color.Red;
                    TextTelephone.ShadowDecoration.Depth = 30;
                    return;
                }
                if (TextCIN.Text == "")
                {
                    TextCIN.ShadowDecoration.Color = Color.Red;
                    TextCIN.ShadowDecoration.Depth = 30;
                    return;
                }
                string Regexmodel = @"\w*\@\w*";
                Regex r = new Regex(Regexmodel);
                if (!(r.IsMatch(textEmail.Text)))
                {

                    Message.MessageRemplirLabel message = new Message.MessageRemplirLabel("L'email incorrecte");
                    message.ShowDialog();
                    return;
                }
                var CinExist = education.Utilisateurs.FirstOrDefault(x => x.CIN == TextCIN.Text);
                if (CinExist != null)
                {
                    Message.MessageRemplirLabel message = new Message.MessageRemplirLabel("Ce CIN déjà existe");
                    message.Show();
                    return;
                }
                byte[] by;
                ImageConverter conv = new ImageConverter();
                by = (byte[])conv.ConvertTo(pictureBoxImage.Image, typeof(byte[]));
                education.Utilisateurs.Add(new Entity.Utilisateur { CIN = TextCIN.Text, NomComplet = textNom.Text, Email = textEmail.Text, Password = textpassword.Text, Role = "Utilisateur", Photo = by, Telephone = TextTelephone.Text });
                education.Historiques.Add(new Entity.Historique
                {
                    Action = "L'ajout d'un compte(" + textNom.Text + ")",
                    dateAction = DateTime.Now,
                    IdUtilisateur = IDU
                });
                education.SaveChanges();
                MainCompte_Load(sender, e);
                Success s = new Success(); s.Show();
                panel1.Visible = false;
            }
            catch { NoSuccess no = new NoSuccess();no.Show(); }
        }
        private void textEmail_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void DataGridViewCompte_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            
                e.Cancel = true;
            
        }
        private void ButtonSupprimer_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (DataGridViewRow row in DataGridViewCompte.Rows)
                {
                    int id = (int)row.Cells[0].Value;
                    var exist = education.Utilisateurs.FirstOrDefault(x => x.IdUtilisateur == id);
                    if (row.Selected)
                    {
                        
                        if (exist != null)
                        {
                            
                            education.Utilisateurs.Remove(exist);
                            var x = education.Historiques.Where(z => z.IdUtilisateur == id);
                            if (x != null)
                            {
                                foreach(var i in x)
                                {
                                    education.Historiques.Remove(i);
                                }

                            }
                            

                        }
                    }
                }
                education.SaveChanges();
                load();
                Success success = new Success();
                success.Show();
            }
            catch
            {
                NoSuccess no = new NoSuccess();
                no.Show();
            }
        }
    }
}

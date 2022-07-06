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

namespace MyProjectInstitute
{
    public partial class MainPage : Form
    {
        Entity.EducationInstitute education = new Entity.EducationInstitute();
        LoginForm loginForm;
        string Email, Password;
        public MainPage()
        {
            InitializeComponent();
        }
        public MainPage(LoginForm loginForm, string Email, string password)
        {
            this.loginForm = loginForm;
            this.Email = Email;
            this.Password = password;
            InitializeComponent();
        }
        public void addForm(UserControl F)
        {
            F.Dock = DockStyle.Fill;
            LoadPanel.Controls.Clear();
            LoadPanel.Controls.Add(F);
            F.BringToFront();
        }
        private void MainPage_Load(object sender, EventArgs e)
        {
            try
            {
                Formation.MainFormation m = new Formation.MainFormation();
                addForm(m);
                var admin = education.Utilisateurs.FirstOrDefault(x => x.Email==Email && x.Password==Password && x.Role == "Admin");
                var admin2 = education.Utilisateurs.FirstOrDefault(x => x.Email==Email && x.Password==Password && x.Role == "Utilisateur");

                if (admin != null)
                {
                    ButtonCompte.Enabled = true;
                }
                if (admin2 != null)
                {
                    ButtonCompte.Enabled = false;
                }
                string nom = education.Utilisateurs.FirstOrDefault(x => x.Email == Email && x.Password == Password).NomComplet;
                label2.Text = nom;
                Entity.Utilisateur utilisateur = education.Utilisateurs.FirstOrDefault(x => x.Email == Email && x.Password == Password);
                if (utilisateur.Photo == null)
                {
                    PictureBoxUser.Image = null;
                }
                else
                {
                    MemoryStream stream = new MemoryStream(utilisateur.Photo);
                    PictureBoxUser.Image = Image.FromStream(stream);
                }
            }
            catch
            {
                string nom = education.Utilisateurs.FirstOrDefault(x => x.Email == Email && x.Password == Password).NomComplet;
                label2.Text = nom;
                PictureBoxUser.Image = null;
            }
            
        }
        private void ButtonFormation_Click(object sender, EventArgs e)
        {
            int IDUser = education.Utilisateurs.FirstOrDefault(x => x.Email == Email && x.Password == Password).IdUtilisateur;
            Formation.MainFormation mainFormation = new Formation.MainFormation(this,IDUser);
            addForm(mainFormation);
        }
        private void ButtonCompte_Click(object sender, EventArgs e)
        {
            int IDUser = education.Utilisateurs.FirstOrDefault(x => x.Email == Email && x.Password == Password).IdUtilisateur;
            Compte.MainCompte mainCompte = new Compte.MainCompte(this,IDUser);
            addForm(mainCompte);
        }
        private void ButtonProfesseur_Click(object sender, EventArgs e)
        {
            int IDUser = education.Utilisateurs.FirstOrDefault(x => x.Email == Email && x.Password == Password).IdUtilisateur;
            Professeur.MainProfesseur main = new Professeur.MainProfesseur(IDUser,this);
            addForm(main);
        }
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            int IDUser = education.Utilisateurs.FirstOrDefault(x => x.Email == Email && x.Password == Password).IdUtilisateur;
            Historique.MainHistorique main = new Historique.MainHistorique(IDUser);
            addForm(main);
        }
        private void ButtonEtudiant_Click(object sender, EventArgs e)
        {
            int IDUser = education.Utilisateurs.FirstOrDefault(x => x.Email == Email && x.Password == Password).IdUtilisateur;
            Etudiant.MainEtudiant main = new Etudiant.MainEtudiant(IDUser,this);
            addForm(main);
        }

        private void ButtonGroup_Click(object sender, EventArgs e)
        {
            int IDUser = education.Utilisateurs.FirstOrDefault(x => x.Email == Email && x.Password == Password).IdUtilisateur;
            Group.MainGroup main = new Group.MainGroup(IDUser);
            addForm(main);
        }

        private void ButtonAbsence_Click(object sender, EventArgs e)
        {
            int IDUser = education.Utilisateurs.FirstOrDefault(x => x.Email == Email && x.Password == Password).IdUtilisateur;
            Absence.MainAbsence main = new Absence.MainAbsence(IDUser);
            addForm(main);
        }
        private void label2_Click(object sender, EventArgs e)
        {
            
        }
        private void label2_DoubleClick(object sender, EventArgs e)
        {
            var IDU = education.Utilisateurs.FirstOrDefault(x => x.Email == Email && x.Password == Password).IdUtilisateur;
            Compte.MettreAjour m = new Compte.MettreAjour(this, IDU);
            m.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            loginForm.Show();
            loginForm.PasswordText.Text = "";
            this.Close();
        }

        private void ButtonSeance_Click(object sender, EventArgs e)
        {
            var IDU = education.Utilisateurs.FirstOrDefault(x => x.Email == Email && x.Password == Password).IdUtilisateur;
            Seance.MainSeance m = new Seance.MainSeance (this, IDU);
            addForm(m);
        }

        private void PictureBoxUser_Click(object sender, EventArgs e)
        {

        }

        private void PictureBoxUser_DoubleClick(object sender, EventArgs e)
        {
            var IDU = education.Utilisateurs.FirstOrDefault(x => x.Email == Email && x.Password == Password).IdUtilisateur;
            Compte.MettreAjour m = new Compte.MettreAjour(this, IDU);
            m.ShowDialog();
        }
    }
}

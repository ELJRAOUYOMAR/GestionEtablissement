using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace MyProjectInstitute.Professeur
{
    public partial class AddProf : Form
    {
        Entity.EducationInstitute education = new Entity.EducationInstitute();
        MainProfesseur main;
        int IDUser;
        public AddProf()
        {
            InitializeComponent();
        }
        public AddProf(MainProfesseur m,int id)
        {
            main=m;
            IDUser = id;
            InitializeComponent();
        }

        private void ButtonFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ButtonAjouter_Click(object sender, EventArgs e)
        {
            try
            {
                Entity.Professeur CinExist = education.Professeurs.FirstOrDefault(x => x.CIN == TextCIN.Text);
                if (CinExist != null)
                {
                    Message.MessageRemplirLabel message = new Message.MessageRemplirLabel("Ce cin déjà existe");
                    message.ShowDialog();
                }
                else
                {
                    string Regexmodel = @"\w*\@\w*";
                    Regex r = new Regex(Regexmodel);
                    if (!(r.IsMatch(textEmail.Text)))
                    {

                        Message.MessageRemplirLabel message = new Message.MessageRemplirLabel("L'email incorrecte");
                        message.ShowDialog();
                        return;
                    }
                    education.Professeurs.Add(new Entity.Professeur { CIN = TextCIN.Text, Adresse = TextAdresse.Text, DateNaissance = DatePickerDateNaissance.Value, Email = textEmail.Text, NomComplet = textNom.Text, Sexe = ComboBoxSexe.Text, Telephone = TextTelephone.Text, age = DateTime.Now.Year - DatePickerDateNaissance.Value.Year,Salaire=double.Parse(TextSalaire.Text) });
                    education.Historiques.Add(new Entity.Historique { IdUtilisateur=IDUser,Action="Ajout d'un professeur",dateAction=DateTime.Now});
                    education.SaveChanges();
                    main.loadProf();
                    Success success = new Success();
                    success.Show();                    
                }
            }
            catch
            {
                NoSuccess no = new NoSuccess();
                no.Show();
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AddProf_Load(object sender, EventArgs e)
        {
            ComboBoxSexe.Items.Add("Homme");
            ComboBoxSexe.Items.Add("Femme");
            ComboBoxSexe.DropDownStyle = ComboBoxStyle.DropDownList;
        }
    }
}

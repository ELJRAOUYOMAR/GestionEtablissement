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

namespace MyProjectInstitute.Etudiant
{
    public partial class AddEtudiant : Form
    {
        MainEtudiant main;
        int IDUser;
        Entity.EducationInstitute education = new Entity.EducationInstitute();
        public AddEtudiant()
        {
            InitializeComponent();
        }
        public AddEtudiant(MainEtudiant m, int id)
        {
            IDUser = id;
            main = m;
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
                    Entity.Etudient CinExist = education.Etudients.FirstOrDefault(x => x.CIN == TextCIN.Text);
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
                        education.Etudients.Add(new Entity.Etudient { CIN = TextCIN.Text, dateNaissance = DatePickerDateNaissance.Value, Email = textEmail.Text, NomComplet = textNom.Text, Sexe = ComboBoxSexe.Text, Telephone = TextTelephone.Text, Age = DateTime.Now.Year - DatePickerDateNaissance.Value.Year });
                        education.Historiques.Add(new Entity.Historique { IdUtilisateur = IDUser, Action = "Addition d'un Etudiant", dateAction = DateTime.Now });
                        education.SaveChanges();
                        main.loadEtudiant();
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

        private void AddEtudiant_Load(object sender, EventArgs e)
        {
            ComboBoxSexe.Items.Add("M");
            ComboBoxSexe.Items.Add("F");
            ComboBoxSexe.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    } 
}

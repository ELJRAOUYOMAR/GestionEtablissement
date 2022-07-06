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
    public partial class ModifyProfesseur : Form
    {
        Entity.EducationInstitute education = new Entity.EducationInstitute();
        MainProfesseur main;
        int IDProf;
        int IDUser;
        public ModifyProfesseur()
        {
            InitializeComponent();
        }
        public ModifyProfesseur(MainProfesseur m,int id,int idu)
        {
            main = m;
            IDProf = id;
            IDUser = idu;
            InitializeComponent();
        }
        private void ModifyProfesseur_Load(object sender, EventArgs e)
        {
            ComboBoxSexe.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboBoxSexe.Items.Add("Homme");
            ComboBoxSexe.Items.Add("Femme");
            try
            {
                var prof = education.Professeurs.FirstOrDefault(x => x.IdProf == IDProf);
                labelNomProf.Text = prof.NomComplet;
                if (prof.CIN == null)
                    TextCIN.Text = "";
                else
                 TextCIN.Text = prof.CIN;
                if (prof.NomComplet == null)
                    textNom.Text = "";
                else
                    textNom.Text = prof.NomComplet;
                if (prof.Adresse == null)
                    TextAdresse.Text = "";
                else
                    TextAdresse.Text = prof.Adresse;
                if (prof.Email == null)
                    textEmail.Text = "";
                else
                    textEmail.Text = prof.Email;
                if (prof.Sexe == null)
                    ComboBoxSexe.Text = "";
                else
                    ComboBoxSexe.Text = prof.Sexe;
                if (prof.Telephone == null)
                    TextTelephone.Text = "";
                else
                    TextTelephone.Text = prof.Telephone;
                if (prof.DateNaissance == null)
                    DatePickerDateNaissance.Value = DateTime.Now;
                else
                    DatePickerDateNaissance.Value = prof.DateNaissance.Value;
            }
            catch {
                NoSuccess no = new NoSuccess();no.Show();
            }

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void ButtonModifier_Click(object sender, EventArgs e)
        {
            try
            {
                //if CIN was exist
                var modify = education.Professeurs.FirstOrDefault(x => x.CIN == TextCIN.Text && x.IdProf!=IDProf);
                //prof that we need to modify
                var m = education.Professeurs.FirstOrDefault(x => x.IdProf==IDProf);
                if (modify != null)
                {
                    Message.MessageRemplirLabel ms = new Message.MessageRemplirLabel("Ce CIN existe déjà");ms.ShowDialog();
                    return;

                }
                else
                {
                    m.CIN = TextCIN.Text;
                    m.Adresse = TextAdresse.Text;
                    m.Email = textEmail.Text;
                    m.Telephone = TextTelephone.Text;
                    m.Sexe = ComboBoxSexe.Text;
                    m.NomComplet = textNom.Text;
                    m.DateNaissance = DatePickerDateNaissance.Value.Date;
                    m.age = DateTime.Now.Year - DatePickerDateNaissance.Value.Year;
                    m.Salaire = double.Parse(TextSalaire.Text);
                    string Regexmodel = @"\w*\@\w*";
                    Regex r = new Regex(Regexmodel);
                    if (!(r.IsMatch(textEmail.Text)))
                    {

                        Message.MessageRemplirLabel message = new Message.MessageRemplirLabel("L'email incorrecte");
                        message.ShowDialog();
                        return;
                    }
                    education.Historiques.Add(new Entity.Historique { IdUtilisateur = IDUser, Action = "Modification(ou essay de modification) d'un professeur", dateAction = DateTime.Now });
                    education.SaveChanges();
                    main.loadProf();
                    this.Close();
                    Success success = new Success();success.Show();
                }
            }
            catch
            {
                NoSuccess no = new NoSuccess();no.Show();
            }
        }

        private void ButtonFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

    }
}

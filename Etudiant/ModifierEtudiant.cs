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
    public partial class ModifierEtudiant : Form
    {
        Entity.EducationInstitute educationE = new Entity.EducationInstitute();
        MainEtudiant main;
        int IDUser;
        int IDEtudiant;
        public ModifierEtudiant()
        {
            InitializeComponent();
        }
        public ModifierEtudiant(MainEtudiant m,int idU,int idE)
        {
            main = m;
            IDUser = idU;
            IDEtudiant = idE;
            InitializeComponent();
        }

        private void ButtonFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void ModifierEtudiant_Load(object sender, EventArgs e)
        {
            ComboBoxSexe.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboBoxSexe.Items.Add("M");
            ComboBoxSexe.Items.Add("F");
            try
            {
                var Etude = educationE.Etudients.FirstOrDefault(x => x.IdEtudient == IDEtudiant);
                labelNomEtudiant.Text = Etude.NomComplet;
                if (Etude.CIN == null)
                    TextCIN.Text = "";
                else
                    TextCIN.Text = Etude.CIN;
                if (Etude.NomComplet == null)
                    textNom.Text = "";
                else
                    textNom.Text = Etude.NomComplet;
                if (Etude.Email == null)
                    textEmail.Text = "";
                else
                    textEmail.Text = Etude.Email;
                if (Etude.Sexe == null)
                    ComboBoxSexe.Text = "";
                else
                    ComboBoxSexe.Text = Etude.Sexe;
                if (Etude.Telephone == null)
                    TextTelephone.Text = "";
                else
                    TextTelephone.Text = Etude.Telephone;
                if (Etude.dateNaissance == null)
                    DatePickerDateNaissance.Value = DateTime.Now;
                else
                    DatePickerDateNaissance.Value = Etude.dateNaissance.Value;
            }
            catch
            {
                NoSuccess no = new NoSuccess(); no.Show();
            }
        }

        private void ButtonModifier_Click(object sender, EventArgs e)
        {
            try
            {
                //if CIN was exist
                var modify = educationE.Etudients.FirstOrDefault(x => x.CIN == TextCIN.Text && x.IdEtudient != IDEtudiant);
                //prof that we need to modify
                var m = educationE.Etudients.FirstOrDefault(x => x.IdEtudient == IDEtudiant);
                if (modify != null)
                {
                    Message.MessageRemplirLabel ms = new Message.MessageRemplirLabel("Ce CIN existe déjà"); ms.ShowDialog();
                    return;

                }
                else
                {
                    m.CIN = TextCIN.Text;
                    m.Email = textEmail.Text;
                    m.Telephone = TextTelephone.Text;
                    m.Sexe = ComboBoxSexe.Text;
                    m.NomComplet = textNom.Text;
                    m.dateNaissance = DatePickerDateNaissance.Value.Date;
                    m.Age = DateTime.Now.Year - DatePickerDateNaissance.Value.Year;
                    string Regexmodel = @"\w*\@\w*";
                    Regex r = new Regex(Regexmodel);
                    if (!(r.IsMatch(textEmail.Text)))
                    {

                        Message.MessageRemplirLabel message = new Message.MessageRemplirLabel("L'email incorrecte");
                        message.ShowDialog();
                        return;
                    }
                    Success success = new Success(); success.Show();
                    educationE.Historiques.Add(new Entity.Historique { IdUtilisateur=IDUser, Action = "Modification(ou essay de modification) d'un Etudiant", dateAction = DateTime.Now });
                    educationE.SaveChanges();
                    main.loadEtudiant();
                    //this.Close();

                }
            }
            catch
            {
                NoSuccess no = new NoSuccess(); no.Show();
            }








        }
    }
}

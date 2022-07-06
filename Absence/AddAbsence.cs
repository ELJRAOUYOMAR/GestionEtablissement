using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyProjectInstitute.Absence
{
    public partial class AddAbsence : Form
    {
        Entity.EducationInstitute education = new Entity.EducationInstitute();
        MainAbsence main;
        public AddAbsence( MainAbsence m)
        {
            main = m;
            InitializeComponent();
        }

        public AddAbsence()
        {
            InitializeComponent();
        }

        private void guna2RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                ComboBox1.DataSource = education.Professeurs.ToList();
                ComboBox1.DisplayMember = "NomComplet";
                ComboBox1.ValueMember = "IdProf";
            }
            catch { NoSuccess no = new NoSuccess(); no.Show(); }

        }

        private void guna2RadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                ComboBox1.DataSource = education.Etudients.ToList();
                ComboBox1.DisplayMember = "NomComplet";
                ComboBox1.ValueMember = "IdEtudient";
            }
            catch { NoSuccess no = new NoSuccess(); no.Show(); }

        }

        private void AddAbsence_Load(object sender, EventArgs e)
        {
            radioProf.Checked = true;
        }

        private void ButtonAjouter_Click(object sender, EventArgs e)
        {
            try
            {
                int slv = (int)ComboBox1.SelectedValue;
                if (TextCause.Text == "")
                {
                    Message.MessageRemplirLabel m = new Message.MessageRemplirLabel("Il faut donner la cause d'absence");
                    m.ShowDialog();
                    return;
                }
                if (dateDebut.Value > dateFin.Value)
                {
                    Message.MessageRemplirLabel m = new Message.MessageRemplirLabel("La date début doit être inférieur à la date fin");
                    m.ShowDialog();
                    return;
                }
                if (radioProf.Checked)
                {
                    education.AbsenceProfesseurs.Add(new Entity.AbsenceProfesseur
                    {
                        DateDebut = dateDebut.Value,
                        DateFin = dateFin.Value,
                        Cause = TextCause.Text,
                        IdProfesseur=slv
                    });
                    education.SaveChanges();
                    Success success = new Success(); success.Show();
                    main.LoadProf();
                    main.RadioProf.Checked = true;
                    main.RadioEtud.Checked = false;
                }
                else if (radioEtud.Checked)
                {
                    education.AbsenceEtudients.Add(new Entity.AbsenceEtudient
                    {
                        dateDebut = dateDebut.Value,
                        DateFin = dateFin.Value,
                        Cause = TextCause.Text,
                        IdEtudient = slv

                    }) ;
                    education.SaveChanges();
                    Success success = new Success();success.Show();
                    main.LoadEtud();
                    main.RadioEtud.Checked = true;
                    main.RadioProf.Checked = false;

                }
                else
                {
                    Message.MessageRemplirLabel m = new Message.MessageRemplirLabel("Choisissez si professeur ou etudiant");
                    m.ShowDialog();
                    return;
                }
                

            }
            catch
            {
                NoSuccess no = new NoSuccess(); no.Show();

            }
        }

        private void ButtonFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

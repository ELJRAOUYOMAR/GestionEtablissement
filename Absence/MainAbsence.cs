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
    public partial class MainAbsence : UserControl
    {
        Entity.EducationInstitute education = new Entity.EducationInstitute();
        int IDUser;
        public MainAbsence(int id)
        {
            IDUser = id;
            InitializeComponent();
        }

        //date absence doit être datetime
        public void LoadEtud()
        {
            guna2DataGridViewAbsence.DataSource = education.AbsenceEtudients.Select(x => new
            { 
                x.IdAbsence,
                x.Etudient.NomComplet,
                x.Cause,
                x.dateDebut,
                x.DateFin

            }).ToList();
            guna2DataGridViewAbsence.Columns[0].Visible = false;
        }
        public void LoadProf()
        {
            guna2DataGridViewAbsence.DataSource = education.AbsenceProfesseurs.Select(x => new
            {
                x.IdAbsence,
                x.Professeur.NomComplet,
                x.Cause,
                x.DateDebut,
                x.DateFin

            }).ToList();
            guna2DataGridViewAbsence.Columns[0].Visible = false;

        }

        private void MainAbsence_Load(object sender, EventArgs e)
        {
            RadioProf.Checked = true;
            LoadProf();

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
            try
            {
                string s = TextSearch.Text;
                if (RadioProf.Checked)
                {
                    guna2DataGridViewAbsence.DataSource = education.AbsenceProfesseurs.Where(x => x.Cause.StartsWith(s) ||
                    x.DateDebut.ToString().StartsWith(s) || x.DateFin.ToString().StartsWith(s) || x.Professeur.NomComplet.StartsWith(s)).Select(x => new 
                    {
                        x.IdAbsence,
                        x.Professeur.NomComplet,
                        x.Cause,
                        x.DateDebut,
                        x.DateFin
                    }).ToList();

                }
                else
                {
                    guna2DataGridViewAbsence.DataSource = education.AbsenceEtudients.Where(x => x.Cause.StartsWith(s) ||
                   x.dateDebut.ToString().StartsWith(s) || x.DateFin.ToString().StartsWith(s) || x.Etudient.NomComplet.StartsWith(s)).Select(x => new
                   {
                       x.IdAbsence,
                       x.Etudient.NomComplet,
                       x.Cause,
                       x.dateDebut,
                       x.DateFin
                   }).ToList();
                }
            }
            catch
            {
                NoSuccess no = new NoSuccess();no.Show();
            }
        }

        private void ComboBoxSort_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void RadioProf_CheckedChanged(object sender, EventArgs e)
        {
            LoadProf();
        }

        private void RadioEtud_CheckedChanged(object sender, EventArgs e)
        {
            LoadEtud();
        }

        private void TextSearch_Leave(object sender, EventArgs e)
        {
            TextSearch.Visible = false;
        }

        private void ButtonAjouter_Click(object sender, EventArgs e)
        {
            AddAbsence add = new AddAbsence(this);
            add.ShowDialog();
        }

        private void dateTimepickerSup_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (RadioEtud.Checked)
                {
                    guna2DataGridViewAbsence.DataSource = education.AbsenceEtudients.Where(x => x.dateDebut < dateTime1.Value && x.DateFin > dateTime1.Value).Select(x => new
                    {
                        x.IdAbsence,
                        x.Etudient.NomComplet,
                        x.Cause,
                        x.dateDebut,
                        x.DateFin
                    }
                    ).ToList();
                    guna2DataGridViewAbsence.Columns[0].Visible = false;

                }
                else if (RadioProf.Checked)
                {
                    guna2DataGridViewAbsence.DataSource = education.AbsenceProfesseurs.Where(x => x.DateDebut < dateTime1.Value && x.DateFin > dateTime1.Value).Select(x => new
                    {
                        x.IdAbsence,
                        x.Professeur.NomComplet,
                        x.Cause,
                        x.DateDebut,
                        x.DateFin
                    }
                    ).ToList();
                    guna2DataGridViewAbsence.Columns[0].Visible = false;

                }
                else
                {

                }
            }
            catch { NoSuccess no = new NoSuccess();no.Show(); }
        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            if (RadioProf.Checked)
                LoadProf();
            else if (RadioEtud.Checked)
                LoadEtud();
        }

        private void ButtonSupprimer_Click(object sender, EventArgs e)
        {
            var admin = education.Utilisateurs.FirstOrDefault(x => x.IdUtilisateur==IDUser );
            if (admin.Role=="Admin") 
            {
                if (guna2DataGridViewAbsence.Rows.Count <= 0)
                {
                    Message.MessageRemplirLabel m = new Message.MessageRemplirLabel("Le tableau est vide!"); m.ShowDialog();
                    return;
                }
                foreach (DataGridViewRow row in guna2DataGridViewAbsence.Rows)
                {
                    int idA = (int)row.Cells[0].Value;
                    if (RadioEtud.Checked)
                    {
                        var exist = education.AbsenceEtudients.FirstOrDefault(x => x.IdAbsence == idA);
                        if (row.Selected)
                        {
                            if (exist != null)
                            {

                                education.AbsenceEtudients.Remove(exist);
                                education.Historiques.Add(new Entity.Historique { IdUtilisateur = IDUser, Action = "Suppression d'absence de etudiant", dateAction = DateTime.Now });
                            }
                        }
                    }
                    else if (RadioProf.Checked)
                    {
                        var exist = education.AbsenceProfesseurs.FirstOrDefault(x => x.IdAbsence == idA);
                        if (row.Selected)
                        {
                            if (exist != null)
                            {

                                education.AbsenceProfesseurs.Remove(exist);
                                education.Historiques.Add(new Entity.Historique { IdUtilisateur = IDUser, Action = "Suppression d'absence de professeur", dateAction = DateTime.Now });
                            }
                        }
                    }

                }
                Message.ConfirmSuppressionProfesseur confirm = new Message.ConfirmSuppressionProfesseur();
                confirm.LabelMessage.Text = "Voulez vous sûrement supprimer ";
                confirm.ShowDialog();
                if (confirm.ButtonNon.Checked)
                {
                    return;
                }
                else if (confirm.ButtonOui.Checked)
                {
                    education.SaveChanges();
                    if (RadioProf.Checked)
                        LoadProf();
                    else if (RadioEtud.Checked)
                        LoadEtud();
                    else
                    {
                        Success s = new Success(); s.Show();
                    }
                    Success success = new Success(); success.Show();
                }
            }
            else if(admin.Role=="Utilisateur")
            {
                Message.MessageRemplirLabel m = new Message.MessageRemplirLabel("vous n'avez pas la droite de supprimer dans ce table");
                m.ShowDialog();
                return;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyProjectInstitute.Group
{
    public partial class MainGroup : UserControl
    {
        Entity.EducationInstitute education = new Entity.EducationInstitute();
        int IDUser;
        public MainGroup()
        {
            InitializeComponent();
        }
        public MainGroup(int id)
        {
            IDUser = id;
            InitializeComponent();
        }
        public void LoadGroup()
        {
            label1.Text = education.Groupes.Count().ToString() + " Groupes";
            DataGridViewGroup.DataSource = education.Groupes.Select(x => new
            {
                x.IdGroupe,
                x.Libelle,
                x.MaxPlace,
            }).ToList();
            DataGridViewGroup.Columns[0].Visible = false;
        }
        private void MainGroup_Load(object sender, EventArgs e)
        {
            
            ComboBoxEtud.DataSource = education.Etudients.ToList();
            ComboBoxEtud.ValueMember = "IdEtudient";
            ComboBoxEtud.DisplayMember = "NomComplet";
            LoadGroup();
        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            LoadGroup();
        }

        private void ButtonAjouter_Click(object sender, EventArgs e)
        {
            panelModification.Visible = false;
            panelAjout.Visible = true;

        }

        private void ButtonModifier_Click(object sender, EventArgs e)
        {
            if (DataGridViewGroup.Rows.Count <= 0)
            {
                Message.MessageRemplirLabel m = new Message.MessageRemplirLabel("Le tableau est vide");
                m.ShowDialog();
            }
            int idG = (int)DataGridViewGroup.CurrentRow.Cells[0].Value;
            ModifierGroup modifier = new ModifierGroup(this,idG,IDUser);
            modifier.ShowDialog();
            
        }

        private void ButtonPanelAjouter_Click(object sender, EventArgs e)
        {
            try
            {
                var r = education.Groupes.FirstOrDefault(x => x.Libelle == TextLibelleAjout.Text);
                if (r != null)
                {
                    Message.MessageRemplirLabel m = new Message.MessageRemplirLabel("Ce nom déjà existe");
                    m.ShowDialog();
                    return;
                }
                education.Groupes.Add(new Entity.Groupe { Libelle = TextLibelleAjout.Text, MaxPlace = int.Parse(TextNbreAJout.Text) });
                education.Historiques.Add(new Entity.Historique
                { 
                    IdUtilisateur = IDUser ,
                    Action="L'ajout de groupe "+TextLibelleAjout.Text,
                    dateAction=DateTime.Now 
                
                });
                education.SaveChanges();
                Success s = new Success(); s.Show();
                LoadGroup();
            }
            catch
            {
                NoSuccess no = new NoSuccess();no.Show();
            }
        }

        private void ButtonPanelAjoutFermer_Click(object sender, EventArgs e)
        {
            panelAjout.Visible = false;
            panelModification.Visible = false;
        }

        private void ButtonPanelModifFermer_Click(object sender, EventArgs e)
        {
            panelModification.Visible = false;
            panelAjout.Visible = false;
        }

        private void ButtonPanelModifier_Click(object sender, EventArgs e)
        {
            try
            {
                int idG = (int)DataGridViewGroup.CurrentRow.Cells[0].Value;
                Entity.Groupe g = education.Groupes.FirstOrDefault(x => x.IdGroupe == idG);
                if (g != null)
                {
                    g.Libelle = TextLibeleeModif.Text;
                    g.MaxPlace = int.Parse(TextNbreMaxModif.Text);
                    education.Historiques.Add(new Entity.Historique
                    {
                        IdUtilisateur=IDUser,
                        Action="Modification sur le groupe "+TextLibeleeModif.Text,
                        dateAction=DateTime.Now
                    });
                    education.SaveChanges();
                    Success s = new Success(); s.Show();
                }
                panelModification.Visible = false;
                panelAjout.Visible = false;
                LoadGroup();
            }
            catch
            {
                NoSuccess no = new NoSuccess();no.Show();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (TextSearch.Visible == false)
                TextSearch.Visible = true;
            else
                TextSearch.Visible = false;
        }

        private void TextSearch_Leave(object sender, EventArgs e)
        {
            TextSearch.Visible = false;
        }

        private void TextSearch_TextChanged(object sender, EventArgs e)
        {
            string s = TextSearch.Text;
            DataGridViewGroup.DataSource = education.Groupes.Where(x => x.Libelle.StartsWith(s) || x.MaxPlace.ToString().StartsWith(s)).Select(x => new
            {
                x.IdGroupe,
                x.Libelle,x.MaxPlace
            }) ;
            DataGridViewGroup.Columns[0].Visible = false;

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            

        }

        private void ButtonEtudientGoup_Click(object sender, EventArgs e)
        {
            try
            {
                if (DataGridViewGroup.Rows.Count <= 0)
                {
                    Message.MessageRemplirLabel m = new Message.MessageRemplirLabel("Le tableau est vide");
                    m.ShowDialog();
                    return;
                }
                int idG = (int)DataGridViewGroup.CurrentRow.Cells[0].Value;
                int idEtud = (int)ComboBoxEtud.SelectedValue;
                var test = education.EtudientGroupes.FirstOrDefault(x => x.IdGroupe == idG && x.IdEtudient == idEtud);
                if (test != null)
                {
                    Message.MessageRemplirLabel m = new Message.MessageRemplirLabel("Ce Etudiant est déjà dans ce group");
                    m.ShowDialog();
                    return;
                }
                var count = education.EtudientGroupes.Count(x=>x.IdGroupe==idG);
                Entity.Groupe comp = education.Groupes.FirstOrDefault(x => x.MaxPlace == count && x.IdGroupe == idG);
                //int maxGroup = (int)education.Groupes.FirstOrDefault(x => x.IdGroupe == idG).MaxPlace;
                if (comp!=null)
                {
                    Message.MessageRemplirLabel m = new Message.MessageRemplirLabel("Le nombre maximale de ce groupe est"+comp.MaxPlace);
                    m.ShowDialog();
                    return;
                }
                education.EtudientGroupes.Add(new Entity.EtudientGroupe
                {
                    IdGroupe = idG,
                    IdEtudient = idEtud
                });
                education.SaveChanges();
                Success s = new Success(); s.Show();
                
            }
            catch
            {
                NoSuccess no = new NoSuccess(); no.Show();
            }
        }

        private void DataGridViewGroup_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int IDG = (int)DataGridViewGroup.CurrentRow.Cells[0].Value;
            ProfesseurEtEtudiant_DeGroupSelectionné m = new ProfesseurEtEtudiant_DeGroupSelectionné(IDG,IDUser);
            m.Show();
        }

        private void ButtonSupprimer_Click(object sender, EventArgs e)
        {
            try
            {
                if (DataGridViewGroup.Rows.Count <= 0)
                {
                    Message.MessageRemplirLabel m = new Message.MessageRemplirLabel("Ce tableau est vide!"); m.ShowDialog();
                    return;
                }
                foreach (DataGridViewRow row in DataGridViewGroup.Rows)
                {
                    int idG = (int)row.Cells[0].Value;
                    string LibelleG = row.Cells[1].Value.ToString();
                    var exist = education.Groupes.FirstOrDefault(x => x.IdGroupe == idG);
                    if (row.Selected)
                    {
                        if (exist != null)
                        {
                            education.Groupes.Remove(exist);
                            education.Historiques.Add(new Entity.Historique { IdUtilisateur = IDUser, Action = "Suppression de Groupe " + LibelleG, dateAction = DateTime.Now });
                            var reqEtud = education.EtudientGroupes.Where(x => x.IdGroupe == idG);
                            var reqProf = education.ProfesseurGroupes.Where(x => x.IdGroupe == idG);
                            var reqFormation = education.FormationGroups.Where(x => x.IDGroup == idG);
                            foreach (var i in reqEtud)
                            {
                                education.EtudientGroupes.Remove(i);
                            }
                            foreach (var i in reqProf)
                            {
                                education.ProfesseurGroupes.Remove(i);
                            }
                            foreach (var i in reqFormation)
                            {
                                education.FormationGroups.Remove(i);
                            }
                        }
                    }
                }
                Message.ConfirmSuppressionProfesseur confirm = new Message.ConfirmSuppressionProfesseur();
                confirm.LabelMessage.Text = "Voulez vous sûrement supprimer ce(ces)groupes ,";
                confirm.LabelMessage2.Text = "peut être il(ils)y a des relations";
                confirm.LabelMessage2.Visible = true;
                confirm.ShowDialog();
                if (confirm.ButtonNon.Checked)
                {
                    return;
                }
                else if (confirm.ButtonOui.Checked)
                {
                    education.SaveChanges();
                    LoadGroup();
                    Success success = new Success(); success.Show();
                }
            }
            catch { NoSuccess no = new NoSuccess();no.Show(); }
        }

        private void TextLoad_TextChanged(object sender, EventArgs e)
        {
            ComboBoxEtud.DataSource = education.Etudients.Where(x => x.NomComplet.StartsWith(TextLoad.Text)).ToList();
        }

        private void ComboBoxEtud_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

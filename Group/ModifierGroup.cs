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
    public partial class ModifierGroup : Form
    {
        public ModifierGroup(MainGroup m, int idg,int idu)
        {
            main = m;
            IDG = idg;
            IDU = idu;
            InitializeComponent();
        }
        Entity.EducationInstitute education = new Entity.EducationInstitute();
        MainGroup main;
        int IDU, IDG;
        public ModifierGroup()
        {
            InitializeComponent();
        }

        private void ModifierGroup_Load(object sender, EventArgs e)
        {
            Entity.Groupe g = education.Groupes.FirstOrDefault(x => x.IdGroupe == IDG);

            TextLibelleAjout.Text = g.Libelle;
            TextNbreAJout.Text = g.MaxPlace.ToString();
        }

        private void ButtonPanelAjoutFermer_Click(object sender, EventArgs e)
        {
            this.Close();
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
                Entity.Groupe g = education.Groupes.FirstOrDefault(x => x.IdGroupe == IDG);
                if (g != null)
                {
                    g.Libelle = TextLibelleAjout.Text;
                    g.MaxPlace = int.Parse(TextNbreAJout.Text);
                }
                education.Historiques.Add(new Entity.Historique
                {
                    IdUtilisateur = IDU,
                    Action = "Modification sur le group "+g.Libelle+" à"+TextLibelleAjout.Text,
                    dateAction = DateTime.Now

                });
                education.SaveChanges();
                Success s = new Success(); s.Show();
                main.LoadGroup();
            }
            catch { NoSuccess no = new NoSuccess();no.Show(); }
        }

    }
}

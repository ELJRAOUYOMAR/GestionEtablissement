using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyProjectInstitute.Seance
{
    public partial class AddSeance : Form
    {
        Entity.EducationInstitute education = new Entity.EducationInstitute();
        MainSeance main;
        int IDU;
        public AddSeance(MainSeance m,int id)
        {
            main = m;
            IDU = id;
            InitializeComponent();
        }

        private void AddSeance_Load(object sender, EventArgs e)
        {
            for(int i = 2000; i <= 2050; i++)
            {
                ComboYear.Items.Add(i);
            }
            string[] month = { "janvier","février","mars","avril","may","juin","juillet","août","septembre","octobre","novembre", "décembre" };
            foreach(string i in month)
            {
                Combomonth.Items.Add(i);
            }
            string[] day = { "lundi", "mardi", "mercredi", "jeudi", "vendredi", "samedi", "dimanche" };
            foreach (string i in day)
            {
                ComboDay.Items.Add(i);
            }
            string[] heure = { "9:00", "11:00", "14:00", "16:00", "18:00", "20:00", "22:00" };
            foreach (string i in heure)
            {
                comboHeuDebut.Items.Add(i);
                ComboHeuFin.Items.Add(i);

            }
            string[] etat = { "Présentielle", "à distance" };
            foreach (string i in etat)
            {
                ComboEtat.Items.Add(i);

            }
            ComboFormation.DisplayMember = "LibelleFormation";
            ComboFormation.ValueMember = "IdFormation";
            ComboFormation.DataSource = education.Formations.ToList();
        }

        private void ComboFormation_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int idf = int.Parse(ComboFormation.SelectedValue.ToString());
                var s = education.FormationGroups.Where((x => x.Formation.IdFormation == idf)).Select(x => new
                {
                    labelG = x.Groupe.Libelle,
                    x.IDGroup
                });
                if (s != null)
                {

                    ComboGroup.DisplayMember = "labelG";
                    ComboGroup.ValueMember = "IDGroup";
                    ComboGroup.DataSource = s.ToList();
                }
                else
                {
                    Message.MessageRemplirLabel m = new Message.MessageRemplirLabel("il n y a pas de groupe pour cette formation");
                    m.ShowDialog();
                    return;
                }
            }
            catch
            {
                Message.MessageRemplirLabel m = new Message.MessageRemplirLabel("il n y a pas de groupe pour cette formation");
                m.ShowDialog();
                return;
            }
        }

        private void ButtonFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ButtonAjouter_Click(object sender, EventArgs e)
        {
            try
            {
                int idf = (int)ComboFormation.SelectedValue;
                int idg = (int)ComboGroup.SelectedValue;
                int year = int.Parse(ComboYear.Text);
                string month = Combomonth.Text;
                string day = ComboDay.Text;
                string HeureDebut = comboHeuDebut.Text;
                string HeureFin = ComboHeuFin.Text;
                string salle = TextSalle.Text;
                var exist = education.Seances.FirstOrDefault(x => x.Année_de_seance == year && x.Mois_de_seance == month &&
                x.Jour_de_seance == day && x.Heure_Debut==HeureDebut && x.Salle==salle);
                var exist2 = education.Seances.FirstOrDefault(x => x.Année_de_seance == year && x.Mois_de_seance == month &&
                x.Jour_de_seance == day && x.Heure_Fin== HeureFin && x.Salle == salle);
                if(exist!=null || exist2 != null)
                {
                    Message.MessageRemplirLabel message = new Message.MessageRemplirLabel("Cette salle est résérvé par un autre groupe ");
                    message.ShowDialog();return;
                }
                if ((int)comboHeuDebut.SelectedItem >= (int)ComboHeuFin.SelectedItem)
                {
                    Message.MessageRemplirLabel m = new Message.MessageRemplirLabel("Heure début doit être inférieur à date fin");
                    m.ShowDialog();return;
                }
                education.Seances.Add(new Entity.Seance
                {
                    Année_de_seance = (int)ComboYear.SelectedItem,
                    Mois_de_seance = Combomonth.SelectedItem.ToString(),
                    Jour_de_seance = ComboDay.SelectedItem.ToString(),
                    Heure_Debut = comboHeuDebut.SelectedItem.ToString(),
                    Heure_Fin = ComboHeuFin.SelectedItem.ToString(),
                    Salle = TextSalle.Text,
                    Id_Formation = idf,
                    Id_Group = idg,
                    Etat = ComboEtat.SelectedItem.ToString()

                });
                education.Historiques.Add(new Entity.Historique
                {
                    Action = "Ajout d'une seance",
                    dateAction = DateTime.Now,
                    IdUtilisateur = IDU
                });
                education.SaveChanges();
                main.LoadSeance();
                Success s = new Success();s.Show();

            }
            catch
            {
                NoSuccess no = new NoSuccess(); no.Show();return;
            }
        }

        private void ComboGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}

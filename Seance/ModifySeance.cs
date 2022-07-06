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
    public partial class ModifySeance : Form
    {
        Entity.EducationInstitute education = new Entity.EducationInstitute();
        int IDU,IDseance;
        MainSeance main;

        private void ModifySeance_Load(object sender, EventArgs e)
        {
            for (int i = 2000; i <= 2050; i++)
            {
                ComboYear.Items.Add(i);
            }
            string[] month = { "janvier", "février", "mars", "avril", "may", "juin", "juillet", "août", "septembre", "octobre", "novembre", "décembre" };
            foreach (string i in month)
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
            var x = education.Seances.FirstOrDefault(z => z.IdSeance == IDseance);
            ComboYear.Text = x.Année_de_seance.ToString();
            Combomonth.Text = x.Mois_de_seance;
            ComboDay.Text = x.Jour_de_seance;
            comboHeuDebut.Text = x.Heure_Debut;
            ComboHeuFin.Text = x.Heure_Fin;
            TextSalle.Text = x.Salle;
            ComboFormation.Text = x.Formation.LibelleFormation.ToString();
            ComboGroup.Text = x.Groupe.Libelle.ToString();
            ComboEtat.Text = x.Etat;
        }

        private void ButtonFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ButtonModifier_Click(object sender, EventArgs e)
        {
            try
            {
                var seance = education.Seances.FirstOrDefault(z => z.IdSeance == IDseance);
                if (seance != null)
                {
                    seance.Année_de_seance =(int) ComboYear.SelectedItem;
                    seance.Mois_de_seance = Combomonth.SelectedItem.ToString();
                    seance.Jour_de_seance = ComboDay.SelectedItem.ToString();
                    seance.Heure_Debut = comboHeuDebut.SelectedItem.ToString();
                    seance.Heure_Fin = ComboHeuFin.SelectedItem.ToString();
                    seance.Salle = TextSalle.Text;
                    seance.Id_Group = (int)ComboGroup.SelectedValue;
                    seance.Id_Formation = (int)ComboFormation.SelectedValue;
                    seance.Etat = ComboEtat.SelectedItem.ToString();
                    education.Historiques.Add(new Entity.Historique
                    {
                        Action="Modification d'une seance",
                        dateAction=DateTime.Now,
                        IdUtilisateur=IDU
                    });
                    education.SaveChanges();
                    main.LoadSeance();
                    Success s = new Success();s.Show();
                }
            }
            catch
            {
                NoSuccess no = new NoSuccess();no.Show();
            }
        }

        private void ComboFormation_SelectedIndexChanged(object sender, EventArgs e)
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

        public ModifySeance(MainSeance m,int id,int ids)
        {
            main = m;
            IDU = id;
            IDseance = ids;
            InitializeComponent();
        }
    }
}

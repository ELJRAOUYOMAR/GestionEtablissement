using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyProjectInstitute.Formation
{
    public partial class ModiferFormation : Form
    {
        Entity.EducationInstitute education = new Entity.EducationInstitute();
        MainFormation main;
        int IDF,IDU;
        string Libelle;
        public ModiferFormation()
        {
            InitializeComponent();
        }
        public ModiferFormation(MainFormation m,int id,string l,int idu)
        {
            main = m;
            IDF = id;
            Libelle = l;
            IDU = idu;
            InitializeComponent();
        }

        private void ButtonModifier_Click(object sender, EventArgs e)
        {
            try {
                string libelle = Libelle;
                var ajouterFormation = education.Formations.FirstOrDefault(x => x.LibelleFormation == libelle);
                var autre = education.Formations.ToList();

                foreach (var row in autre)
                {
                    if (row.LibelleFormation == TextLibelle.Text)
                    {
                        Message.MessageRemplirLabel m = new Message.MessageRemplirLabel("Cette formation Déjà existe");
                        m.ShowDialog();
                        return;

                    }
                }
                if (ajouterFormation != null)
                {

                    ajouterFormation.LibelleFormation = TextLibelle.Text;
                    education.Historiques.Add(new Entity.Historique
                    {
                        Action = "Modification sur la formation " + libelle + " à" + TextLibelle.Text,
                        dateAction = DateTime.Now,
                        IdUtilisateur = IDU
                    });
                    education.SaveChanges();
                    main.loadFormation();
                    Success success = new Success();
                    success.Show();
                }
                else
                {
                    NoSuccess noSuccess = new NoSuccess();
                    noSuccess.Show();
                }
            }
            catch { NoSuccess no = new NoSuccess();no.Show(); }
        }
        private void Buttonfermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ModiferFormation_Load(object sender, EventArgs e)
        {
            TextLibelle.Text = Libelle;
        }
    }
}

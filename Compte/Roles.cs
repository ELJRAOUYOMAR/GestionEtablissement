using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyProjectInstitute.Compte
{
    public partial class Roles : Form
    {
        Entity.EducationInstitute education = new Entity.EducationInstitute();
        public Roles()
        {
            InitializeComponent();
        }

        private void Roles_Load(object sender, EventArgs e)
        {
            TxtSearch.Focus();
            guna2ComboBox1.DisplayMember = "Cin";
            guna2ComboBox1.ValueMember = "IdUtilisateur";
            guna2ComboBox1.DataSource = education.Utilisateurs.Where(x=>x.Role=="Utilisateur").ToList();
        }
    }
}

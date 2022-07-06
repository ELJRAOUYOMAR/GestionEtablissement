using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyProjectInstitute.Entity;

namespace MyProjectInstitute
{
    public partial class UserCode : Form
    {
        EducationInstitute Education = new EducationInstitute();
        string email, code;
        private int ticks=1;
        public UserCode()
        {
            
            InitializeComponent();
        }
        public UserCode(string email,string code)
        {
            this.email = email;
            this.code = code;
            InitializeComponent();
        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            ticks++;
            if (ticks == 6)
            {
                
                timer2.Stop();
                this.Close();
                LoginForm login = new LoginForm();
                login.EmailText.Text = email;
                login.Show();
            }
        }

        private void guna2GradientPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void UserCode_Load(object sender, EventArgs e)
        {
            //timer2.Start();
            //var req = Education.Utilisateurs.FirstOrDefault(x => x.Email == email && x.Code==code);
            //if (req != null)
            //{
            //    label4.Text = req.Password;
            //}
        }
    }
}

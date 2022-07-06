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
    public partial class ResetPasswordForm : Form
    {
        EducationInstitute education = new EducationInstitute();
        LoginForm loginForm;
        string Email, Password;
        public ResetPasswordForm()
        {
            InitializeComponent();
        }
        public ResetPasswordForm(LoginForm loginForm,string Email,string Password)
        {
            this.loginForm = loginForm;
            this.Email = Email;
            this.Password = Password;
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            loginForm.Show();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            //var Emailtest = education.Utilisateurs.FirstOrDefault(x => x.Email == EmailText.Text);
            //var CodeTest= education.Utilisateurs.FirstOrDefault(x => x.Code == CodeText.Text);
            //if (Emailtest == null)
            //{
            //    EmailText.ShadowDecoration.Color = Color.FromArgb(250, 74, 13);
            //    EmailText.ShadowDecoration.Depth = 30;
            //    return;
            //}
            //if (CodeTest == null)
            //{
            //    CodeText.ShadowDecoration.Color = Color.FromArgb(250, 74, 13);
            //    CodeText.ShadowDecoration.Depth = 30;
            //    return;
            //}
            //UserCode user = new UserCode(EmailText.Text,CodeText.Text);
            //user.Show();
            //this.Close();
            //UserCode user = new UserCode(this,EmailText.Text,CodeText.Text);
            //user.Show();
        }
    }
}

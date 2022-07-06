using MyProjectInstitute.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI.WinForms;
using Guna.UI2.WinForms;
using System.IO;

namespace MyProjectInstitute
{
    public partial class LoginForm : Form
    {
        EducationInstitute education = new EducationInstitute();
        public LoginForm()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            ImageLookPassword.Hide();
            passwordImageButton.Show();
        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }
        private void LoginButton_Click(object sender, EventArgs e)
        {
            var Test = education.Utilisateurs.FirstOrDefault(x => x.Email == EmailText.Text && x.Password==PasswordText.Text);
            //string EmailTest = Test.Email;
            //string PasswordTest = Test.Password;
            if (EmailText.Text== "")
            {
                EmailText.ShadowDecoration.Color = Color.Red;
                EmailText.ShadowDecoration.Depth = 30;
                return;
            }
            else
            {
                EmailText.ShadowDecoration.Color = Color.FromArgb(28, 158, 225);
                EmailText.ShadowDecoration.Depth = 30;
            }
            if (PasswordText.Text=="")
            {
                PasswordText.ShadowDecoration.Color = Color.Red;
                PasswordText.ShadowDecoration.Depth = 30;
                return;
            }
            else
            {
                PasswordText.ShadowDecoration.Color = Color.FromArgb(28, 158, 225);
                PasswordText.ShadowDecoration.Depth = 30;
            }
            if(Test==null)
            {
                EmailText.ShadowDecoration.Color = Color.Red;
                EmailText.ShadowDecoration.Depth = 30;
                PasswordText.ShadowDecoration.Color = Color.Red;
                PasswordText.ShadowDecoration.Depth = 30;
                return;
            }
            MainPage page = new MainPage(this,EmailText.Text,PasswordText.Text);
            page.Show();
            this.Hide();              
        }
        private void label3_MouseHover(object sender, EventArgs e)
        {
            //ForgotPassword.ForeColor = Color.FromArgb(250, 74, 13);
        }

        private void ForgotPassword_Click(object sender, EventArgs e)
        {
            //ResetPasswordForm reset = new ResetPasswordForm(this,EmailText.Text,PasswordText.Text);
            //reset.Show();
            //this.Hide();
        }

        private void guna2PictureBox2_Click(object sender, EventArgs e)
        {
            PasswordText.PasswordChar = '\0';
            PasswordText.UseSystemPasswordChar = false;
            ImageLookPassword.Hide();
        }

        private void passwordImageButton_Click(object sender, EventArgs e)
        {
            PasswordText.PasswordChar = '*';
            PasswordText.UseSystemPasswordChar = true;
            ImageLookPassword.Show();
        }
        private void ForgotPassword_MouseLeave(object sender, EventArgs e)
        {
            //ForgotPassword.ForeColor = Color.Black;
        }

        private void EmailText_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

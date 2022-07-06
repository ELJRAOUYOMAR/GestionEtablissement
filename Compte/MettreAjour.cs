using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.IO;

namespace MyProjectInstitute.Compte
{
    public partial class MettreAjour : Form
    {
        Entity.EducationInstitute education = new Entity.EducationInstitute();
        MainPage main;
        int IDU;
        string imageUrl = null;
        OpenFileDialog f = new OpenFileDialog();
        Image imagePiece;
        public MettreAjour()
        {
            InitializeComponent();
        }
        public MettreAjour(MainPage p,int id)
        {
            main = p;
            IDU = id;
            InitializeComponent();
        }
        private void MettreAjour_Load(object sender, EventArgs e)
        {
            try
            {
                Entity.Utilisateur utilisateur = education.Utilisateurs.FirstOrDefault(x => x.IdUtilisateur == IDU);
                if (utilisateur.CIN == "")
                    TextCIN.Text = "";
                else
                    TextCIN.Text = utilisateur.CIN;
                if (utilisateur.Email == "") textEmail.Text = "";
                else textEmail.Text = utilisateur.Email;
                if (utilisateur.NomComplet == "") textNom.Text = "";
                else textNom.Text = utilisateur.NomComplet;
                if (utilisateur.Password == "") TextPassword.Text = "";
                else TextPassword.Text = utilisateur.Password;
                if (utilisateur.Telephone == "") TextTelephone.Text = "";
                else TextTelephone.Text = utilisateur.Telephone;
                if (utilisateur.Photo == null)
                    pictureBoxImage.Image = null;
                else
                {
                    MemoryStream ms = new MemoryStream(utilisateur.Photo);
                    pictureBoxImage.Image = Image.FromStream(ms);

                }

            }
            catch { return; }

        }

        private void ButtonFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ButtonModifier_Click(object sender, EventArgs e)
        {
            try
            {
                if (textEmail.Text == "")
                {
                    textEmail.BorderColor = Color.DarkRed;
                    textEmail.ShadowDecoration.Color = Color.Red;
                    textEmail.ShadowDecoration.Depth = 30;
                    return;
                }
                if (textNom.Text == "")
                {
                    textNom.BorderColor = Color.DarkRed;
                    textNom.ShadowDecoration.Color = Color.Red;
                    textNom.ShadowDecoration.Depth = 30;
                    return;
                }
                if (TextTelephone.Text == "")
                {
                    TextTelephone.BorderColor = Color.DarkRed;
                    TextTelephone.ShadowDecoration.Color = Color.Red;
                    TextTelephone.ShadowDecoration.Depth = 30;
                    return;
                }
                if (TextCIN.Text == "")
                {
                    TextCIN.BorderColor = Color.DarkRed;
                    TextCIN.ShadowDecoration.Color = Color.Red;
                    TextCIN.ShadowDecoration.Depth = 30;
                    return;
                }
                string Regexmodel = @"\w*\@\w*";
                Regex r = new Regex(Regexmodel);
                if (!(r.IsMatch(textEmail.Text)))
                {

                    Message.MessageRemplirLabel message = new Message.MessageRemplirLabel("L'email incorrecte");
                    message.ShowDialog();
                    return;
                }
                byte[] by;
                ImageConverter conv = new ImageConverter();
                by = (byte[])conv.ConvertTo(pictureBoxImage.Image, typeof(byte[]));
                var User = education.Utilisateurs.FirstOrDefault(x => x.IdUtilisateur == IDU);
                if (User != null)
                {
                    User.Email = textEmail.Text;
                    User.NomComplet = textNom.Text;
                    User.CIN = TextCIN.Text;
                    User.Telephone = TextTelephone.Text;
                    User.Photo = by;
                    User.Password = TextPassword.Text;
                    education.SaveChanges();
                    Compte.MainCompte m = new MainCompte();
                    main.ButtonCompte.Checked = true;
                    main.addForm(m);
                    this.Close();
                }
            }
            catch
            {
                NoSuccess noSuccess = new NoSuccess();
                noSuccess.Show();
            }
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            if (f.ShowDialog() == DialogResult.OK)
            {
                imageUrl = f.FileName;
                pictureBoxImage.Image = Image.FromFile(imageUrl);
                imagePiece = Image.FromFile(f.FileName);
            }
        }
    }
}

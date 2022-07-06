using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;

namespace MyProjectInstitute.Compte
{
    public partial class ModifierCompte : Form
    {
        Entity.EducationInstitute education = new Entity.EducationInstitute();
        Compte.MainCompte main;
        string imageUrl = null;
        OpenFileDialog f = new OpenFileDialog();
        Image imagePiece;
        public ModifierCompte()
        {
            InitializeComponent();
        }
        public ModifierCompte(MainCompte m)
        {
            main = m;
            InitializeComponent();
        }
        public object cell(int i)
        {
            return main.DataGridViewCompte.CurrentRow.Cells[i].Value;
        }
        private void ModifierCompte_Load(object sender, EventArgs e)
        {
            try
            {
                int IDUtil = (int)cell(0);
                var util = education.Utilisateurs.FirstOrDefault(x => x.IdUtilisateur == IDUtil);
                if (util != null)
                {
                    textEmail.Text = util.Email;
                    textNom.Text = util.NomComplet;
                    TextTelephone.Text = util.Telephone;
                    TextCIN.Text = util.CIN;
                    if (util.Photo == null)
                    { pictureBoxImage.Image = null; }
                    else
                    {
                        MemoryStream ms = new MemoryStream(util.Photo);
                        pictureBoxImage.Image = Image.FromStream(ms);

                    }
                    if (util.CIN == "")
                      TextCIN.Text = ""; 
                    if (util.NomComplet == "")
                      textNom.Text = ""; 
                    if (util.Telephone == "")
                       TextTelephone.Text = ""; 
                    if (util.Photo == null)
                       pictureBoxImage.Image = null; 
                }

            }
            catch
            {
                NoSuccess no = new NoSuccess();
                no.Show();
            }

            
        }

        private void ButtonPanelFermer_Click(object sender, EventArgs e)
        {
            this.Close();
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
                int id = (int)cell(0);
                var User = education.Utilisateurs.FirstOrDefault(x => x.IdUtilisateur == id);
                if (User != null)
                {
                    User.Email = textEmail.Text;
                    User.NomComplet = textNom.Text;
                    User.CIN = TextCIN.Text;
                    User.Telephone = TextTelephone.Text;
                    User.Photo = by;
                    education.SaveChanges();
                    main.load();
                    this.Close();
            }
            }
            catch
            {
                NoSuccess noSuccess = new NoSuccess();
                noSuccess.Show();
            }



        }

        private void TextTelephone_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

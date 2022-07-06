
namespace MyProjectInstitute.Etudiant
{
    partial class AddEtudiant
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ComboBoxSexe = new Guna.UI2.WinForms.Guna2ComboBox();
            this.DatePickerDateNaissance = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.TextTelephone = new Guna.UI2.WinForms.Guna2TextBox();
            this.textEmail = new Guna.UI2.WinForms.Guna2TextBox();
            this.textNom = new Guna.UI2.WinForms.Guna2TextBox();
            this.TextCIN = new Guna.UI2.WinForms.Guna2TextBox();
            this.ButtonFermer = new Guna.UI2.WinForms.Guna2Button();
            this.ButtonAjouter = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.ComboBoxSexe);
            this.panel1.Controls.Add(this.DatePickerDateNaissance);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.TextTelephone);
            this.panel1.Controls.Add(this.textEmail);
            this.panel1.Controls.Add(this.textNom);
            this.panel1.Controls.Add(this.TextCIN);
            this.panel1.Controls.Add(this.ButtonFermer);
            this.panel1.Controls.Add(this.ButtonAjouter);
            this.panel1.Location = new System.Drawing.Point(4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(451, 400);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // ComboBoxSexe
            // 
            this.ComboBoxSexe.BackColor = System.Drawing.Color.Transparent;
            this.ComboBoxSexe.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(74)))), ((int)(((byte)(13)))));
            this.ComboBoxSexe.BorderRadius = 10;
            this.ComboBoxSexe.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ComboBoxSexe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxSexe.FocusedColor = System.Drawing.Color.Empty;
            this.ComboBoxSexe.FocusedState.Parent = this.ComboBoxSexe;
            this.ComboBoxSexe.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ComboBoxSexe.ForeColor = System.Drawing.Color.Black;
            this.ComboBoxSexe.FormattingEnabled = true;
            this.ComboBoxSexe.HoverState.BorderColor = System.Drawing.Color.Black;
            this.ComboBoxSexe.HoverState.Parent = this.ComboBoxSexe;
            this.ComboBoxSexe.ItemHeight = 30;
            this.ComboBoxSexe.ItemsAppearance.Parent = this.ComboBoxSexe;
            this.ComboBoxSexe.Location = new System.Drawing.Point(11, 233);
            this.ComboBoxSexe.Name = "ComboBoxSexe";
            this.ComboBoxSexe.ShadowDecoration.Parent = this.ComboBoxSexe;
            this.ComboBoxSexe.Size = new System.Drawing.Size(200, 36);
            this.ComboBoxSexe.TabIndex = 53;
            // 
            // DatePickerDateNaissance
            // 
            this.DatePickerDateNaissance.BorderRadius = 10;
            this.DatePickerDateNaissance.CheckedState.Parent = this.DatePickerDateNaissance;
            this.DatePickerDateNaissance.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.DatePickerDateNaissance.HoverState.Parent = this.DatePickerDateNaissance;
            this.DatePickerDateNaissance.Location = new System.Drawing.Point(239, 233);
            this.DatePickerDateNaissance.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.DatePickerDateNaissance.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.DatePickerDateNaissance.Name = "DatePickerDateNaissance";
            this.DatePickerDateNaissance.ShadowDecoration.Parent = this.DatePickerDateNaissance;
            this.DatePickerDateNaissance.Size = new System.Drawing.Size(200, 36);
            this.DatePickerDateNaissance.TabIndex = 52;
            this.DatePickerDateNaissance.Value = new System.DateTime(2022, 5, 31, 13, 35, 7, 90);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(88, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 21);
            this.label1.TabIndex = 50;
            this.label1.Text = "Addition d\'un(des) Etudiant";
            // 
            // TextTelephone
            // 
            this.TextTelephone.BackColor = System.Drawing.Color.Transparent;
            this.TextTelephone.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(74)))), ((int)(((byte)(13)))));
            this.TextTelephone.BorderRadius = 10;
            this.TextTelephone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextTelephone.DefaultText = "";
            this.TextTelephone.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextTelephone.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextTelephone.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextTelephone.DisabledState.Parent = this.TextTelephone;
            this.TextTelephone.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextTelephone.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(74)))), ((int)(((byte)(13)))));
            this.TextTelephone.FocusedState.Parent = this.TextTelephone;
            this.TextTelephone.ForeColor = System.Drawing.Color.Black;
            this.TextTelephone.HoverState.BorderColor = System.Drawing.Color.Black;
            this.TextTelephone.HoverState.ForeColor = System.Drawing.Color.Black;
            this.TextTelephone.HoverState.Parent = this.TextTelephone;
            this.TextTelephone.Location = new System.Drawing.Point(239, 165);
            this.TextTelephone.Name = "TextTelephone";
            this.TextTelephone.PasswordChar = '\0';
            this.TextTelephone.PlaceholderText = "Téléphone";
            this.TextTelephone.SelectedText = "";
            this.TextTelephone.ShadowDecoration.BorderRadius = 17;
            this.TextTelephone.ShadowDecoration.Color = System.Drawing.Color.Red;
            this.TextTelephone.ShadowDecoration.Parent = this.TextTelephone;
            this.TextTelephone.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.TextTelephone.Size = new System.Drawing.Size(200, 36);
            this.TextTelephone.TabIndex = 45;
            // 
            // textEmail
            // 
            this.textEmail.BackColor = System.Drawing.Color.Transparent;
            this.textEmail.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(74)))), ((int)(((byte)(13)))));
            this.textEmail.BorderRadius = 10;
            this.textEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textEmail.DefaultText = "";
            this.textEmail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textEmail.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textEmail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textEmail.DisabledState.Parent = this.textEmail;
            this.textEmail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textEmail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(74)))), ((int)(((byte)(13)))));
            this.textEmail.FocusedState.Parent = this.textEmail;
            this.textEmail.ForeColor = System.Drawing.Color.Black;
            this.textEmail.HoverState.BorderColor = System.Drawing.Color.Black;
            this.textEmail.HoverState.ForeColor = System.Drawing.Color.Black;
            this.textEmail.HoverState.Parent = this.textEmail;
            this.textEmail.Location = new System.Drawing.Point(11, 165);
            this.textEmail.Name = "textEmail";
            this.textEmail.PasswordChar = '\0';
            this.textEmail.PlaceholderText = "Email";
            this.textEmail.SelectedText = "";
            this.textEmail.ShadowDecoration.BorderRadius = 17;
            this.textEmail.ShadowDecoration.Color = System.Drawing.Color.Red;
            this.textEmail.ShadowDecoration.Parent = this.textEmail;
            this.textEmail.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.textEmail.Size = new System.Drawing.Size(200, 36);
            this.textEmail.TabIndex = 42;
            // 
            // textNom
            // 
            this.textNom.BackColor = System.Drawing.Color.Transparent;
            this.textNom.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(74)))), ((int)(((byte)(13)))));
            this.textNom.BorderRadius = 10;
            this.textNom.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textNom.DefaultText = "";
            this.textNom.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textNom.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textNom.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textNom.DisabledState.Parent = this.textNom;
            this.textNom.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textNom.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(74)))), ((int)(((byte)(13)))));
            this.textNom.FocusedState.Parent = this.textNom;
            this.textNom.ForeColor = System.Drawing.Color.Black;
            this.textNom.HoverState.BorderColor = System.Drawing.Color.Black;
            this.textNom.HoverState.ForeColor = System.Drawing.Color.Black;
            this.textNom.HoverState.Parent = this.textNom;
            this.textNom.Location = new System.Drawing.Point(239, 103);
            this.textNom.Name = "textNom";
            this.textNom.PasswordChar = '\0';
            this.textNom.PlaceholderText = "Nom ";
            this.textNom.SelectedText = "";
            this.textNom.ShadowDecoration.BorderRadius = 17;
            this.textNom.ShadowDecoration.Color = System.Drawing.Color.Red;
            this.textNom.ShadowDecoration.Parent = this.textNom;
            this.textNom.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.textNom.Size = new System.Drawing.Size(200, 36);
            this.textNom.TabIndex = 41;
            // 
            // TextCIN
            // 
            this.TextCIN.BackColor = System.Drawing.Color.Transparent;
            this.TextCIN.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(74)))), ((int)(((byte)(13)))));
            this.TextCIN.BorderRadius = 10;
            this.TextCIN.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextCIN.DefaultText = "";
            this.TextCIN.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextCIN.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextCIN.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextCIN.DisabledState.Parent = this.TextCIN;
            this.TextCIN.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextCIN.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(74)))), ((int)(((byte)(13)))));
            this.TextCIN.FocusedState.Parent = this.TextCIN;
            this.TextCIN.ForeColor = System.Drawing.Color.Black;
            this.TextCIN.HoverState.BorderColor = System.Drawing.Color.Black;
            this.TextCIN.HoverState.ForeColor = System.Drawing.Color.Black;
            this.TextCIN.HoverState.Parent = this.TextCIN;
            this.TextCIN.Location = new System.Drawing.Point(11, 103);
            this.TextCIN.Name = "TextCIN";
            this.TextCIN.PasswordChar = '\0';
            this.TextCIN.PlaceholderText = "CIN";
            this.TextCIN.SelectedText = "";
            this.TextCIN.ShadowDecoration.BorderRadius = 17;
            this.TextCIN.ShadowDecoration.Color = System.Drawing.Color.Red;
            this.TextCIN.ShadowDecoration.Parent = this.TextCIN;
            this.TextCIN.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.TextCIN.Size = new System.Drawing.Size(200, 36);
            this.TextCIN.TabIndex = 40;
            // 
            // ButtonFermer
            // 
            this.ButtonFermer.BackColor = System.Drawing.Color.Transparent;
            this.ButtonFermer.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(74)))), ((int)(((byte)(13)))));
            this.ButtonFermer.BorderRadius = 10;
            this.ButtonFermer.BorderThickness = 2;
            this.ButtonFermer.CheckedState.Parent = this.ButtonFermer;
            this.ButtonFermer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonFermer.CustomImages.Parent = this.ButtonFermer;
            this.ButtonFermer.FillColor = System.Drawing.Color.Transparent;
            this.ButtonFermer.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ButtonFermer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(74)))), ((int)(((byte)(13)))));
            this.ButtonFermer.HoverState.BorderColor = System.Drawing.Color.Transparent;
            this.ButtonFermer.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(74)))), ((int)(((byte)(13)))));
            this.ButtonFermer.HoverState.ForeColor = System.Drawing.Color.White;
            this.ButtonFermer.HoverState.Parent = this.ButtonFermer;
            this.ButtonFermer.Location = new System.Drawing.Point(354, 363);
            this.ButtonFermer.Name = "ButtonFermer";
            this.ButtonFermer.ShadowDecoration.Parent = this.ButtonFermer;
            this.ButtonFermer.Size = new System.Drawing.Size(85, 29);
            this.ButtonFermer.TabIndex = 38;
            this.ButtonFermer.Text = "Fermer";
            this.ButtonFermer.Click += new System.EventHandler(this.ButtonFermer_Click);
            // 
            // ButtonAjouter
            // 
            this.ButtonAjouter.BackColor = System.Drawing.Color.Transparent;
            this.ButtonAjouter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(74)))), ((int)(((byte)(13)))));
            this.ButtonAjouter.BorderRadius = 10;
            this.ButtonAjouter.BorderThickness = 2;
            this.ButtonAjouter.CheckedState.Parent = this.ButtonAjouter;
            this.ButtonAjouter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonAjouter.CustomImages.Parent = this.ButtonAjouter;
            this.ButtonAjouter.FillColor = System.Drawing.Color.Transparent;
            this.ButtonAjouter.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ButtonAjouter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(74)))), ((int)(((byte)(13)))));
            this.ButtonAjouter.HoverState.BorderColor = System.Drawing.Color.Transparent;
            this.ButtonAjouter.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(74)))), ((int)(((byte)(13)))));
            this.ButtonAjouter.HoverState.ForeColor = System.Drawing.Color.White;
            this.ButtonAjouter.HoverState.Parent = this.ButtonAjouter;
            this.ButtonAjouter.Location = new System.Drawing.Point(258, 363);
            this.ButtonAjouter.Name = "ButtonAjouter";
            this.ButtonAjouter.ShadowDecoration.Parent = this.ButtonAjouter;
            this.ButtonAjouter.Size = new System.Drawing.Size(85, 29);
            this.ButtonAjouter.TabIndex = 37;
            this.ButtonAjouter.Text = "Ajouter";
            this.ButtonAjouter.Click += new System.EventHandler(this.ButtonAjouter_Click);
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 10;
            this.guna2Elipse1.TargetControl = this.panel1;
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.BorderRadius = 10;
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.TargetControl = this.panel1;
            // 
            // AddEtudiant
            // 
            this.AcceptButton = this.ButtonAjouter;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(74)))), ((int)(((byte)(13)))));
            this.ClientSize = new System.Drawing.Size(458, 408);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddEtudiant";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddEtudiant";
            this.Load += new System.EventHandler(this.AddEtudiant_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2ComboBox ComboBoxSexe;
        private Guna.UI2.WinForms.Guna2DateTimePicker DatePickerDateNaissance;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox TextTelephone;
        private Guna.UI2.WinForms.Guna2TextBox textEmail;
        private Guna.UI2.WinForms.Guna2TextBox textNom;
        private Guna.UI2.WinForms.Guna2TextBox TextCIN;
        private Guna.UI2.WinForms.Guna2Button ButtonFermer;
        private Guna.UI2.WinForms.Guna2Button ButtonAjouter;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
    }
}
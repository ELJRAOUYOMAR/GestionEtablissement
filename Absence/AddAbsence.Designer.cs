
namespace MyProjectInstitute.Absence
{
    partial class AddAbsence
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
            this.ComboBox1 = new Guna.UI2.WinForms.Guna2ComboBox();
            this.dateDebut = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.TextCause = new Guna.UI2.WinForms.Guna2TextBox();
            this.ButtonFermer = new Guna.UI2.WinForms.Guna2Button();
            this.ButtonAjouter = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.radioProf = new Guna.UI2.WinForms.Guna2RadioButton();
            this.radioEtud = new Guna.UI2.WinForms.Guna2RadioButton();
            this.dateFin = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.dateFin);
            this.panel1.Controls.Add(this.radioEtud);
            this.panel1.Controls.Add(this.radioProf);
            this.panel1.Controls.Add(this.ComboBox1);
            this.panel1.Controls.Add(this.dateDebut);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.TextCause);
            this.panel1.Controls.Add(this.ButtonFermer);
            this.panel1.Controls.Add(this.ButtonAjouter);
            this.panel1.Location = new System.Drawing.Point(3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(451, 481);
            this.panel1.TabIndex = 3;
            // 
            // ComboBox1
            // 
            this.ComboBox1.BackColor = System.Drawing.Color.Transparent;
            this.ComboBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(74)))), ((int)(((byte)(13)))));
            this.ComboBox1.BorderRadius = 10;
            this.ComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBox1.FocusedColor = System.Drawing.Color.Empty;
            this.ComboBox1.FocusedState.Parent = this.ComboBox1;
            this.ComboBox1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ComboBox1.ForeColor = System.Drawing.Color.Black;
            this.ComboBox1.FormattingEnabled = true;
            this.ComboBox1.HoverState.BorderColor = System.Drawing.Color.Black;
            this.ComboBox1.HoverState.Parent = this.ComboBox1;
            this.ComboBox1.ItemHeight = 30;
            this.ComboBox1.ItemsAppearance.Parent = this.ComboBox1;
            this.ComboBox1.Location = new System.Drawing.Point(239, 81);
            this.ComboBox1.Name = "ComboBox1";
            this.ComboBox1.ShadowDecoration.Parent = this.ComboBox1;
            this.ComboBox1.Size = new System.Drawing.Size(200, 36);
            this.ComboBox1.TabIndex = 53;
            // 
            // dateDebut
            // 
            this.dateDebut.BorderRadius = 10;
            this.dateDebut.CheckedState.Parent = this.dateDebut;
            this.dateDebut.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dateDebut.HoverState.Parent = this.dateDebut;
            this.dateDebut.Location = new System.Drawing.Point(203, 133);
            this.dateDebut.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dateDebut.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dateDebut.Name = "dateDebut";
            this.dateDebut.ShadowDecoration.Parent = this.dateDebut;
            this.dateDebut.Size = new System.Drawing.Size(236, 36);
            this.dateDebut.TabIndex = 52;
            this.dateDebut.Value = new System.DateTime(2022, 5, 31, 13, 35, 7, 90);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(88, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 21);
            this.label1.TabIndex = 50;
            this.label1.Text = "Addition d\'une(des) Absence";
            // 
            // TextCause
            // 
            this.TextCause.BackColor = System.Drawing.Color.Transparent;
            this.TextCause.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(74)))), ((int)(((byte)(13)))));
            this.TextCause.BorderRadius = 10;
            this.TextCause.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextCause.DefaultText = "";
            this.TextCause.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextCause.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextCause.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextCause.DisabledState.Parent = this.TextCause;
            this.TextCause.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextCause.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(74)))), ((int)(((byte)(13)))));
            this.TextCause.FocusedState.Parent = this.TextCause;
            this.TextCause.ForeColor = System.Drawing.Color.Black;
            this.TextCause.HoverState.BorderColor = System.Drawing.Color.Black;
            this.TextCause.HoverState.ForeColor = System.Drawing.Color.Black;
            this.TextCause.HoverState.Parent = this.TextCause;
            this.TextCause.Location = new System.Drawing.Point(14, 258);
            this.TextCause.Name = "TextCause";
            this.TextCause.PasswordChar = '\0';
            this.TextCause.PlaceholderText = "Cause";
            this.TextCause.SelectedText = "";
            this.TextCause.ShadowDecoration.BorderRadius = 17;
            this.TextCause.ShadowDecoration.Color = System.Drawing.Color.Red;
            this.TextCause.ShadowDecoration.Parent = this.TextCause;
            this.TextCause.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.TextCause.Size = new System.Drawing.Size(429, 164);
            this.TextCause.TabIndex = 42;
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
            this.ButtonFermer.Location = new System.Drawing.Point(358, 444);
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
            this.ButtonAjouter.Location = new System.Drawing.Point(262, 444);
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
            // radioProf
            // 
            this.radioProf.AutoSize = true;
            this.radioProf.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.radioProf.CheckedState.BorderThickness = 0;
            this.radioProf.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.radioProf.CheckedState.InnerColor = System.Drawing.Color.White;
            this.radioProf.CheckedState.InnerOffset = -4;
            this.radioProf.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.radioProf.Location = new System.Drawing.Point(14, 86);
            this.radioProf.Name = "radioProf";
            this.radioProf.Size = new System.Drawing.Size(91, 20);
            this.radioProf.TabIndex = 54;
            this.radioProf.TabStop = true;
            this.radioProf.Text = "Professeur";
            this.radioProf.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.radioProf.UncheckedState.BorderThickness = 2;
            this.radioProf.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.radioProf.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.radioProf.UseVisualStyleBackColor = true;
            this.radioProf.CheckedChanged += new System.EventHandler(this.guna2RadioButton1_CheckedChanged);
            // 
            // radioEtud
            // 
            this.radioEtud.AutoSize = true;
            this.radioEtud.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.radioEtud.CheckedState.BorderThickness = 0;
            this.radioEtud.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.radioEtud.CheckedState.InnerColor = System.Drawing.Color.White;
            this.radioEtud.CheckedState.InnerOffset = -4;
            this.radioEtud.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.radioEtud.Location = new System.Drawing.Point(125, 86);
            this.radioEtud.Name = "radioEtud";
            this.radioEtud.Size = new System.Drawing.Size(74, 20);
            this.radioEtud.TabIndex = 55;
            this.radioEtud.TabStop = true;
            this.radioEtud.Text = "Etudiant";
            this.radioEtud.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.radioEtud.UncheckedState.BorderThickness = 2;
            this.radioEtud.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.radioEtud.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.radioEtud.UseVisualStyleBackColor = true;
            this.radioEtud.CheckedChanged += new System.EventHandler(this.guna2RadioButton2_CheckedChanged);
            // 
            // dateFin
            // 
            this.dateFin.BorderRadius = 10;
            this.dateFin.CheckedState.Parent = this.dateFin;
            this.dateFin.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dateFin.HoverState.Parent = this.dateFin;
            this.dateFin.Location = new System.Drawing.Point(203, 193);
            this.dateFin.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dateFin.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dateFin.Name = "dateFin";
            this.dateFin.ShadowDecoration.Parent = this.dateFin;
            this.dateFin.Size = new System.Drawing.Size(236, 36);
            this.dateFin.TabIndex = 56;
            this.dateFin.Value = new System.DateTime(2022, 5, 31, 13, 35, 7, 90);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(20, 201);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 20);
            this.label2.TabIndex = 57;
            this.label2.Text = "Date Fin";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(16, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 20);
            this.label3.TabIndex = 58;
            this.label3.Text = "Date Debut";
            // 
            // AddAbsence
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(74)))), ((int)(((byte)(13)))));
            this.ClientSize = new System.Drawing.Size(458, 489);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddAbsence";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddAbsence";
            this.Load += new System.EventHandler(this.AddAbsence_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2RadioButton radioProf;
        private Guna.UI2.WinForms.Guna2ComboBox ComboBox1;
        private Guna.UI2.WinForms.Guna2DateTimePicker dateDebut;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox TextCause;
        private Guna.UI2.WinForms.Guna2Button ButtonFermer;
        private Guna.UI2.WinForms.Guna2Button ButtonAjouter;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2DateTimePicker dateFin;
        private Guna.UI2.WinForms.Guna2RadioButton radioEtud;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}
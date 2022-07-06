
namespace MyProjectInstitute
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.LoginGradientPanel = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.ImageLookPassword = new Guna.UI2.WinForms.Guna2PictureBox();
            this.passwordImageButton = new Guna.UI2.WinForms.Guna2ImageButton();
            this.PasswordText = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.AnnulerButton = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LoginButton = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.EmailText = new Guna.UI2.WinForms.Guna2TextBox();
            this.LoginGradientPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImageLookPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 10;
            this.guna2Elipse1.TargetControl = this;
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.TargetControl = this.LoginGradientPanel;
            // 
            // LoginGradientPanel
            // 
            this.LoginGradientPanel.Controls.Add(this.ImageLookPassword);
            this.LoginGradientPanel.Controls.Add(this.passwordImageButton);
            this.LoginGradientPanel.Controls.Add(this.PasswordText);
            this.LoginGradientPanel.Controls.Add(this.label4);
            this.LoginGradientPanel.Controls.Add(this.AnnulerButton);
            this.LoginGradientPanel.Controls.Add(this.label2);
            this.LoginGradientPanel.Controls.Add(this.label1);
            this.LoginGradientPanel.Controls.Add(this.LoginButton);
            this.LoginGradientPanel.Controls.Add(this.guna2PictureBox1);
            this.LoginGradientPanel.Controls.Add(this.EmailText);
            this.LoginGradientPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LoginGradientPanel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            this.LoginGradientPanel.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(255)))), ((int)(((byte)(253)))));
            this.LoginGradientPanel.Location = new System.Drawing.Point(0, 0);
            this.LoginGradientPanel.Name = "LoginGradientPanel";
            this.LoginGradientPanel.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(231)))), ((int)(((byte)(231)))));
            this.LoginGradientPanel.ShadowDecoration.Parent = this.LoginGradientPanel;
            this.LoginGradientPanel.Size = new System.Drawing.Size(316, 520);
            this.LoginGradientPanel.TabIndex = 0;
            // 
            // ImageLookPassword
            // 
            this.ImageLookPassword.BackColor = System.Drawing.Color.White;
            this.ImageLookPassword.Image = ((System.Drawing.Image)(resources.GetObject("ImageLookPassword.Image")));
            this.ImageLookPassword.Location = new System.Drawing.Point(267, 330);
            this.ImageLookPassword.Name = "ImageLookPassword";
            this.ImageLookPassword.ShadowDecoration.Parent = this.ImageLookPassword;
            this.ImageLookPassword.Size = new System.Drawing.Size(26, 23);
            this.ImageLookPassword.TabIndex = 13;
            this.ImageLookPassword.TabStop = false;
            this.ImageLookPassword.Click += new System.EventHandler(this.guna2PictureBox2_Click);
            // 
            // passwordImageButton
            // 
            this.passwordImageButton.BackColor = System.Drawing.Color.White;
            this.passwordImageButton.CheckedState.Parent = this.passwordImageButton;
            this.passwordImageButton.HoverState.Parent = this.passwordImageButton;
            this.passwordImageButton.Image = ((System.Drawing.Image)(resources.GetObject("passwordImageButton.Image")));
            this.passwordImageButton.Location = new System.Drawing.Point(267, 330);
            this.passwordImageButton.Name = "passwordImageButton";
            this.passwordImageButton.PressedState.Parent = this.passwordImageButton;
            this.passwordImageButton.Size = new System.Drawing.Size(26, 23);
            this.passwordImageButton.TabIndex = 11;
            this.passwordImageButton.Click += new System.EventHandler(this.passwordImageButton_Click);
            // 
            // PasswordText
            // 
            this.PasswordText.BackColor = System.Drawing.Color.Transparent;
            this.PasswordText.BorderColor = System.Drawing.Color.White;
            this.PasswordText.BorderRadius = 17;
            this.PasswordText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PasswordText.DefaultText = "";
            this.PasswordText.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.PasswordText.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.PasswordText.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PasswordText.DisabledState.Parent = this.PasswordText;
            this.PasswordText.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PasswordText.FocusedState.BorderColor = System.Drawing.Color.Transparent;
            this.PasswordText.FocusedState.Parent = this.PasswordText;
            this.PasswordText.ForeColor = System.Drawing.Color.Black;
            this.PasswordText.HoverState.BorderColor = System.Drawing.Color.Transparent;
            this.PasswordText.HoverState.Parent = this.PasswordText;
            this.PasswordText.IconLeft = ((System.Drawing.Image)(resources.GetObject("PasswordText.IconLeft")));
            this.PasswordText.IconLeftOffset = new System.Drawing.Point(3, 0);
            this.PasswordText.IconRightOffset = new System.Drawing.Point(4, 0);
            this.PasswordText.Location = new System.Drawing.Point(27, 321);
            this.PasswordText.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PasswordText.Name = "PasswordText";
            this.PasswordText.PasswordChar = '●';
            this.PasswordText.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.PasswordText.PlaceholderText = "Mot de passe";
            this.PasswordText.SelectedText = "";
            this.PasswordText.ShadowDecoration.BorderRadius = 17;
            this.PasswordText.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(158)))), ((int)(((byte)(225)))));
            this.PasswordText.ShadowDecoration.Enabled = true;
            this.PasswordText.ShadowDecoration.Parent = this.PasswordText;
            this.PasswordText.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(5, 0, 5, 5);
            this.PasswordText.Size = new System.Drawing.Size(270, 40);
            this.PasswordText.TabIndex = 10;
            this.PasswordText.TextOffset = new System.Drawing.Point(5, 0);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11F);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(74)))), ((int)(((byte)(13)))));
            this.label4.Location = new System.Drawing.Point(118, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Omar Education";
            // 
            // AnnulerButton
            // 
            this.AnnulerButton.AutoSize = true;
            this.AnnulerButton.DisabledLinkColor = System.Drawing.Color.Transparent;
            this.AnnulerButton.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AnnulerButton.ForeColor = System.Drawing.Color.Black;
            this.AnnulerButton.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.AnnulerButton.LinkColor = System.Drawing.Color.Black;
            this.AnnulerButton.Location = new System.Drawing.Point(132, 465);
            this.AnnulerButton.Name = "AnnulerButton";
            this.AnnulerButton.Size = new System.Drawing.Size(65, 21);
            this.AnnulerButton.TabIndex = 7;
            this.AnnulerButton.TabStop = true;
            this.AnnulerButton.Text = "Annuler";
            this.AnnulerButton.VisitedLinkColor = System.Drawing.Color.Red;
            this.AnnulerButton.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(74)))), ((int)(((byte)(13)))));
            this.label2.Location = new System.Drawing.Point(12, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 23);
            this.label2.TabIndex = 6;
            this.label2.Text = "Login";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Bienvenue chez";
            // 
            // LoginButton
            // 
            this.LoginButton.BorderRadius = 17;
            this.LoginButton.CheckedState.Parent = this.LoginButton;
            this.LoginButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LoginButton.CustomImages.Parent = this.LoginButton;
            this.LoginButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(158)))), ((int)(((byte)(225)))));
            this.LoginButton.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(195)))), ((int)(((byte)(247)))));
            this.LoginButton.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.LoginButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(255)))), ((int)(((byte)(253)))));
            this.LoginButton.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(195)))), ((int)(((byte)(247)))));
            this.LoginButton.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(158)))), ((int)(((byte)(225)))));
            this.LoginButton.HoverState.Parent = this.LoginButton;
            this.LoginButton.Location = new System.Drawing.Point(60, 411);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.ShadowDecoration.BorderRadius = 17;
            this.LoginButton.ShadowDecoration.Color = System.Drawing.Color.White;
            this.LoginButton.ShadowDecoration.Depth = 10;
            this.LoginButton.ShadowDecoration.Parent = this.LoginButton;
            this.LoginButton.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(5, 0, 5, 5);
            this.LoginButton.Size = new System.Drawing.Size(204, 39);
            this.LoginButton.TabIndex = 3;
            this.LoginButton.Text = "Se connecter";
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            this.guna2PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.Image")));
            this.guna2PictureBox1.Location = new System.Drawing.Point(34, 90);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.ShadowDecoration.Parent = this.guna2PictureBox1;
            this.guna2PictureBox1.Size = new System.Drawing.Size(217, 140);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 2;
            this.guna2PictureBox1.TabStop = false;
            // 
            // EmailText
            // 
            this.EmailText.BackColor = System.Drawing.Color.Transparent;
            this.EmailText.BorderColor = System.Drawing.Color.White;
            this.EmailText.BorderRadius = 17;
            this.EmailText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.EmailText.DefaultText = "";
            this.EmailText.DisabledState.Parent = this.EmailText;
            this.EmailText.FocusedState.BorderColor = System.Drawing.Color.Transparent;
            this.EmailText.FocusedState.Parent = this.EmailText;
            this.EmailText.ForeColor = System.Drawing.Color.Black;
            this.EmailText.HoverState.BorderColor = System.Drawing.Color.Transparent;
            this.EmailText.HoverState.Parent = this.EmailText;
            this.EmailText.IconLeft = ((System.Drawing.Image)(resources.GetObject("EmailText.IconLeft")));
            this.EmailText.IconLeftOffset = new System.Drawing.Point(3, 0);
            this.EmailText.IconRightOffset = new System.Drawing.Point(4, 0);
            this.EmailText.Location = new System.Drawing.Point(27, 262);
            this.EmailText.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.EmailText.Name = "EmailText";
            this.EmailText.PasswordChar = '\0';
            this.EmailText.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.EmailText.PlaceholderText = "Email";
            this.EmailText.SelectedText = "";
            this.EmailText.ShadowDecoration.BorderRadius = 17;
            this.EmailText.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(158)))), ((int)(((byte)(225)))));
            this.EmailText.ShadowDecoration.Enabled = true;
            this.EmailText.ShadowDecoration.Parent = this.EmailText;
            this.EmailText.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(5, 0, 5, 5);
            this.EmailText.Size = new System.Drawing.Size(270, 40);
            this.EmailText.TabIndex = 1;
            this.EmailText.TextOffset = new System.Drawing.Point(5, 0);
            this.EmailText.TextChanged += new System.EventHandler(this.EmailText_TextChanged);
            // 
            // LoginForm
            // 
            this.AcceptButton = this.LoginButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(251)))), ((int)(((byte)(231)))));
            this.ClientSize = new System.Drawing.Size(316, 520);
            this.Controls.Add(this.LoginGradientPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.LoginGradientPanel.ResumeLayout(false);
            this.LoginGradientPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImageLookPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2GradientButton LoginButton;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel AnnulerButton;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2ImageButton passwordImageButton;
        public Guna.UI2.WinForms.Guna2GradientPanel LoginGradientPanel;
        public Guna.UI2.WinForms.Guna2TextBox EmailText;
        private Guna.UI2.WinForms.Guna2PictureBox ImageLookPassword;
        public Guna.UI2.WinForms.Guna2TextBox PasswordText;
    }
}


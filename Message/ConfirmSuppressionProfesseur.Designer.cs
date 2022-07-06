
namespace MyProjectInstitute.Message
{
    partial class ConfirmSuppressionProfesseur
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
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.ButtonOui = new Guna.UI2.WinForms.Guna2Button();
            this.LabelMessage = new System.Windows.Forms.Label();
            this.ButtonNon = new Guna.UI2.WinForms.Guna2Button();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.LabelMessage2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(157)))), ((int)(((byte)(246)))));
            this.panel1.Controls.Add(this.guna2ControlBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(420, 30);
            this.panel1.TabIndex = 40;
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(158)))), ((int)(((byte)(225)))));
            this.guna2ControlBox1.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(113)))), ((int)(((byte)(221)))));
            this.guna2ControlBox1.HoverState.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox1.HoverState.Parent = this.guna2ControlBox1;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox1.Location = new System.Drawing.Point(388, 1);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.ShadowDecoration.Parent = this.guna2ControlBox1;
            this.guna2ControlBox1.Size = new System.Drawing.Size(32, 29);
            this.guna2ControlBox1.TabIndex = 0;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 10;
            this.guna2Elipse1.TargetControl = this;
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.BorderRadius = 2;
            this.guna2Elipse2.TargetControl = this.panel1;
            // 
            // ButtonOui
            // 
            this.ButtonOui.BackColor = System.Drawing.Color.Transparent;
            this.ButtonOui.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(157)))), ((int)(((byte)(246)))));
            this.ButtonOui.BorderRadius = 8;
            this.ButtonOui.BorderThickness = 2;
            this.ButtonOui.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.ButtonOui.CheckedState.Parent = this.ButtonOui;
            this.ButtonOui.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonOui.CustomImages.Parent = this.ButtonOui;
            this.ButtonOui.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(157)))), ((int)(((byte)(246)))));
            this.ButtonOui.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ButtonOui.ForeColor = System.Drawing.Color.White;
            this.ButtonOui.HoverState.BorderColor = System.Drawing.Color.Transparent;
            this.ButtonOui.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(113)))), ((int)(((byte)(221)))));
            this.ButtonOui.HoverState.ForeColor = System.Drawing.Color.White;
            this.ButtonOui.HoverState.Parent = this.ButtonOui;
            this.ButtonOui.Location = new System.Drawing.Point(104, 113);
            this.ButtonOui.Name = "ButtonOui";
            this.ButtonOui.ShadowDecoration.Parent = this.ButtonOui;
            this.ButtonOui.Size = new System.Drawing.Size(85, 29);
            this.ButtonOui.TabIndex = 42;
            this.ButtonOui.Text = "Oui";
            this.ButtonOui.Click += new System.EventHandler(this.ButtonOui_Click);
            // 
            // LabelMessage
            // 
            this.LabelMessage.AutoSize = true;
            this.LabelMessage.Font = new System.Drawing.Font("Microsoft Tai Le", 11F);
            this.LabelMessage.Location = new System.Drawing.Point(13, 51);
            this.LabelMessage.Name = "LabelMessage";
            this.LabelMessage.Size = new System.Drawing.Size(224, 19);
            this.LabelMessage.TabIndex = 41;
            this.LabelMessage.Text = "Voulez vous sûrement supprimer";
            // 
            // ButtonNon
            // 
            this.ButtonNon.BackColor = System.Drawing.Color.Transparent;
            this.ButtonNon.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(157)))), ((int)(((byte)(246)))));
            this.ButtonNon.BorderRadius = 8;
            this.ButtonNon.BorderThickness = 2;
            this.ButtonNon.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.ButtonNon.CheckedState.Parent = this.ButtonNon;
            this.ButtonNon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonNon.CustomImages.Parent = this.ButtonNon;
            this.ButtonNon.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(157)))), ((int)(((byte)(246)))));
            this.ButtonNon.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ButtonNon.ForeColor = System.Drawing.Color.White;
            this.ButtonNon.HoverState.BorderColor = System.Drawing.Color.Transparent;
            this.ButtonNon.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(113)))), ((int)(((byte)(221)))));
            this.ButtonNon.HoverState.ForeColor = System.Drawing.Color.White;
            this.ButtonNon.HoverState.Parent = this.ButtonNon;
            this.ButtonNon.Location = new System.Drawing.Point(225, 113);
            this.ButtonNon.Name = "ButtonNon";
            this.ButtonNon.ShadowDecoration.Parent = this.ButtonNon;
            this.ButtonNon.Size = new System.Drawing.Size(85, 29);
            this.ButtonNon.TabIndex = 43;
            this.ButtonNon.Text = "Non";
            this.ButtonNon.Click += new System.EventHandler(this.ButtonNon_Click);
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.TargetControl = this.panel1;
            // 
            // LabelMessage2
            // 
            this.LabelMessage2.AutoSize = true;
            this.LabelMessage2.Font = new System.Drawing.Font("Microsoft Tai Le", 11F);
            this.LabelMessage2.Location = new System.Drawing.Point(13, 74);
            this.LabelMessage2.Name = "LabelMessage2";
            this.LabelMessage2.Size = new System.Drawing.Size(224, 19);
            this.LabelMessage2.TabIndex = 44;
            this.LabelMessage2.Text = "Voulez vous sûrement supprimer";
            this.LabelMessage2.Visible = false;
            // 
            // ConfirmSuppressionProfesseur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 154);
            this.Controls.Add(this.LabelMessage2);
            this.Controls.Add(this.ButtonNon);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ButtonOui);
            this.Controls.Add(this.LabelMessage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ConfirmSuppressionProfesseur";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ConfirmSuppressionProfesseur";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        public System.Windows.Forms.Label LabelMessage;
        public Guna.UI2.WinForms.Guna2Button ButtonOui;
        public Guna.UI2.WinForms.Guna2Button ButtonNon;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        public System.Windows.Forms.Label LabelMessage2;
    }
}
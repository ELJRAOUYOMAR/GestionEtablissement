
namespace MyProjectInstitute.Message
{
    partial class MessageRemplirLabel
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
            this.LabelMessage = new System.Windows.Forms.Label();
            this.ButtonFermer = new Guna.UI2.WinForms.Guna2Button();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
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
            this.panel1.Size = new System.Drawing.Size(393, 30);
            this.panel1.TabIndex = 0;
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
            this.guna2ControlBox1.Location = new System.Drawing.Point(361, 1);
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
            // LabelMessage
            // 
            this.LabelMessage.AutoSize = true;
            this.LabelMessage.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelMessage.Location = new System.Drawing.Point(27, 52);
            this.LabelMessage.Name = "LabelMessage";
            this.LabelMessage.Size = new System.Drawing.Size(39, 16);
            this.LabelMessage.TabIndex = 1;
            this.LabelMessage.Text = "label1";
            // 
            // ButtonFermer
            // 
            this.ButtonFermer.BackColor = System.Drawing.Color.Transparent;
            this.ButtonFermer.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(157)))), ((int)(((byte)(246)))));
            this.ButtonFermer.BorderRadius = 10;
            this.ButtonFermer.BorderThickness = 2;
            this.ButtonFermer.CheckedState.Parent = this.ButtonFermer;
            this.ButtonFermer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonFermer.CustomImages.Parent = this.ButtonFermer;
            this.ButtonFermer.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(157)))), ((int)(((byte)(246)))));
            this.ButtonFermer.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ButtonFermer.ForeColor = System.Drawing.Color.White;
            this.ButtonFermer.HoverState.BorderColor = System.Drawing.Color.Transparent;
            this.ButtonFermer.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(113)))), ((int)(((byte)(221)))));
            this.ButtonFermer.HoverState.ForeColor = System.Drawing.Color.White;
            this.ButtonFermer.HoverState.Parent = this.ButtonFermer;
            this.ButtonFermer.Location = new System.Drawing.Point(151, 96);
            this.ButtonFermer.Name = "ButtonFermer";
            this.ButtonFermer.ShadowDecoration.Parent = this.ButtonFermer;
            this.ButtonFermer.Size = new System.Drawing.Size(85, 29);
            this.ButtonFermer.TabIndex = 39;
            this.ButtonFermer.Text = "OK";
            this.ButtonFermer.Click += new System.EventHandler(this.ButtonFermer_Click);
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.TargetControl = this.panel1;
            // 
            // MessageRemplirLabel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(225)))), ((int)(((byte)(239)))));
            this.ClientSize = new System.Drawing.Size(393, 132);
            this.Controls.Add(this.ButtonFermer);
            this.Controls.Add(this.LabelMessage);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MessageRemplirLabel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MessageRemplirLabel";
            this.Load += new System.EventHandler(this.MessageRemplirLabel_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private System.Windows.Forms.Label LabelMessage;
        private Guna.UI2.WinForms.Guna2Button ButtonFermer;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
    }
}
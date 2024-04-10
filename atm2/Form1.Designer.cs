namespace atm2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            label1 = new Label();
            btncard = new Guna.UI2.WinForms.Guna2ImageButton();
            label2 = new Label();
            label3 = new Label();
            guna2GradientPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // guna2GradientPanel1
            // 
            guna2GradientPanel1.Controls.Add(label3);
            guna2GradientPanel1.Controls.Add(label2);
            guna2GradientPanel1.Controls.Add(btncard);
            guna2GradientPanel1.Controls.Add(label1);
            guna2GradientPanel1.CustomizableEdges = customizableEdges2;
            guna2GradientPanel1.FillColor = Color.FromArgb(46, 86, 118);
            guna2GradientPanel1.FillColor2 = Color.FromArgb(77, 67, 118);
            guna2GradientPanel1.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal;
            guna2GradientPanel1.Location = new Point(-3, -1);
            guna2GradientPanel1.Margin = new Padding(3, 2, 3, 2);
            guna2GradientPanel1.Name = "guna2GradientPanel1";
            guna2GradientPanel1.ShadowDecoration.CustomizableEdges = customizableEdges3;
            guna2GradientPanel1.Size = new Size(724, 313);
            guna2GradientPanel1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Verdana", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(56, 130);
            label1.Name = "label1";
            label1.Size = new Size(227, 42);
            label1.TabIndex = 30;
            label1.Text = "OhMyBank";
            // 
            // btncard
            // 
            btncard.BackColor = Color.Transparent;
            btncard.BackgroundImageLayout = ImageLayout.Stretch;
            btncard.CheckedState.ImageSize = new Size(64, 64);
            btncard.HoverState.ImageSize = new Size(64, 64);
            btncard.Image = (Image)resources.GetObject("btncard.Image");
            btncard.ImageOffset = new Point(0, 0);
            btncard.ImageRotate = 0F;
            btncard.ImageSize = new Size(200, 200);
            btncard.Location = new Point(430, 37);
            btncard.Name = "btncard";
            btncard.PressedState.ImageSize = new Size(64, 64);
            btncard.ShadowDecoration.CustomizableEdges = customizableEdges1;
            btncard.Size = new Size(230, 208);
            btncard.TabIndex = 31;
            btncard.Click += btncard_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Verdana", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(45, 88);
            label2.Name = "label2";
            label2.Size = new Size(250, 42);
            label2.TabIndex = 32;
            label2.Text = "Welcome to";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Verdana", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(430, 248);
            label3.Name = "label3";
            label3.Size = new Size(240, 42);
            label3.TabIndex = 33;
            label3.Text = "Insert Card";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(720, 308);
            Controls.Add(guna2GradientPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Form1";
            guna2GradientPanel1.ResumeLayout(false);
            guna2GradientPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
        private Label label1;
        private Guna.UI2.WinForms.Guna2ImageButton btncard;
        private Label label3;
        private Label label2;
    }
}

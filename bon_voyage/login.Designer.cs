namespace bon_voyage
{
    partial class login
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
            panel1 = new Panel();
            acces_utilisateur = new Label();
            nom_utilisateur = new Label();
            textBox1 = new TextBox();
            mdp_utilisateur = new Label();
            textBox2 = new TextBox();
            button1 = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(button1);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(mdp_utilisateur);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(nom_utilisateur);
            panel1.Controls.Add(acces_utilisateur);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(201, 303);
            panel1.TabIndex = 0;
            // 
            // acces_utilisateur
            // 
            acces_utilisateur.AutoSize = true;
            acces_utilisateur.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            acces_utilisateur.Location = new Point(29, 41);
            acces_utilisateur.Name = "acces_utilisateur";
            acces_utilisateur.Size = new Size(144, 18);
            acces_utilisateur.TabIndex = 0;
            acces_utilisateur.Text = "Accés utilisateur";
            // 
            // nom_utilisateur
            // 
            nom_utilisateur.AutoSize = true;
            nom_utilisateur.Font = new Font("Yu Gothic UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            nom_utilisateur.Location = new Point(12, 86);
            nom_utilisateur.Name = "nom_utilisateur";
            nom_utilisateur.Size = new Size(108, 17);
            nom_utilisateur.TabIndex = 1;
            nom_utilisateur.Text = "Nom d'utilisateur";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 106);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(161, 23);
            textBox1.TabIndex = 2;
            // 
            // mdp_utilisateur
            // 
            mdp_utilisateur.AutoSize = true;
            mdp_utilisateur.Font = new Font("Yu Gothic UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            mdp_utilisateur.Location = new Point(12, 142);
            mdp_utilisateur.Name = "mdp_utilisateur";
            mdp_utilisateur.Size = new Size(89, 17);
            mdp_utilisateur.TabIndex = 3;
            mdp_utilisateur.Text = "Mot de passe";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(12, 162);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(161, 23);
            textBox2.TabIndex = 4;
            // 
            // button1
            // 
            button1.Location = new Point(54, 221);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 5;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(201, 303);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "login";
            Text = "login";
            Load += login_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox textBox1;
        private Label nom_utilisateur;
        private Label acces_utilisateur;
        private Button button1;
        private TextBox textBox2;
        private Label mdp_utilisateur;
    }
}
namespace bon_voyage
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            pictureBox1 = new PictureBox();
            timer1 = new System.Windows.Forms.Timer(components);
            guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(components);
            explorer = new Button();
            exit = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, -2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(642, 419);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 3000;
            timer1.Tick += timer1_Tick;
            // 
            // guna2DragControl1
            // 
            guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            guna2DragControl1.TargetControl = pictureBox1;
            guna2DragControl1.UseTransparentDrag = true;
            // 
            // explorer
            // 
            explorer.FlatStyle = FlatStyle.Popup;
            explorer.Font = new Font("Candara", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            explorer.Location = new Point(244, 269);
            explorer.Name = "explorer";
            explorer.Size = new Size(173, 28);
            explorer.TabIndex = 1;
            explorer.Text = "Explorer Maintenant";
            explorer.UseVisualStyleBackColor = true;
            explorer.Visible = false;
            explorer.Click += explorer_Click;
            // 
            // exit
            // 
            exit.CustomizableEdges = customizableEdges1;
            exit.DisabledState.BorderColor = Color.DarkGray;
            exit.DisabledState.CustomBorderColor = Color.DarkGray;
            exit.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            exit.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            exit.FillColor = Color.Transparent;
            exit.Font = new Font("Leelawadee UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            exit.ForeColor = Color.Black;
            exit.Location = new Point(569, 12);
            exit.Name = "exit";
            exit.ShadowDecoration.CustomizableEdges = customizableEdges2;
            exit.Size = new Size(50, 30);
            exit.TabIndex = 2;
            exit.Text = "X";
            exit.Click += exit_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(642, 415);
            Controls.Add(exit);
            Controls.Add(explorer);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Button explorer;
        private Guna.UI2.WinForms.Guna2Button exit;
    }
}
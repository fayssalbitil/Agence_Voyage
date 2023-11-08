using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bon_voyage
{
    public partial class acceuil : Form
    {
        public acceuil()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            //panel_show(new Form1());
        }
        public void panel_show(object Form)
        {
            if (this.loginpanel.Controls.Count > 0)
                this.loginpanel.Controls.RemoveAt(0);
            Form h = Form as Form;
            h.TopLevel = false;
            h.Dock = DockStyle.Fill;
            this.loginpanel.Controls.Add(h);
            this.loginpanel.Tag = h;
            h.Show();


        }

        private void acceuil_Load(object sender, EventArgs e)
        {
            loginpanel.BackColor = Color.FromArgb(120, 127, 127, 127);
            services.BackColor = Color.Transparent;
            services.ForeColor = Color.FromArgb(1, 40, 64);
            rechercher.BackColor = Color.FromArgb(1, 40, 64);
            destination.ForeColor = Color.FromArgb(1, 40, 64);
            date.ForeColor = Color.FromArgb(1, 40, 64);
            label2.BackColor = Color.Transparent;
            label2.ForeColor = Color.White;
            label2.Parent = pictureBox1;
            panel1.BackColor = Color.FromArgb(120, 127, 127, 127);
            label1.ForeColor = Color.FromArgb(1, 40, 64);
            label1.BackColor = Color.Transparent;
            acceuil1.ForeColor = Color.FromArgb(1, 40, 64);
            acceuil1.BackColor = Color.Transparent;
            acceuil1.FocusedColor = Color.White;
            tour.ForeColor = Color.FromArgb(1, 40, 64);
            tour.BackColor = Color.Transparent;
            gallerie.ForeColor = Color.FromArgb(1, 40, 64);
            gallerie.BackColor = Color.Transparent;
            Contact.ForeColor = Color.FromArgb(1, 40, 64);
            Contact.BackColor = Color.Transparent;
            panel1.Parent = pictureBox1;
            panel1.BackColor = Color.FromArgb(150, 127, 127, 127);
            panel1.Location = new Point(30, 400);
            panel2.Location = new Point(80, 430);
            combdate.Items.Add("Janvier");
            combdate.Items.Add("Février");
            combdate.Items.Add("Mars");
            combdate.Items.Add("April");
            combdate.Items.Add("Mai");
            combdate.Items.Add("Juin");
            combdate.Items.Add("Juillet");
            combdate.Items.Add("Août");
            combdate.Items.Add("Septembre");
            combdate.Items.Add("Octobre");
            combdate.Items.Add("Novombre");
            combdate.Items.Add("Décembre");
        }

        private void Panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }


        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }



        private void acceuil1_MouseEnter(object sender, EventArgs e)
        {
            acceuil1.Font = new Font("Ebrima", 12, FontStyle.Underline);
            acceuil1.BackColor = Color.White;


        }
        private void acceuil1_MouseLeave(object sender, EventArgs e)
        {
            acceuil1.Font = new Font("Ebrima", 12, FontStyle.Regular);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void tour_MouseEnter(object sender, EventArgs e)
        {
            tour.Font = new Font("Ebrima", 12, FontStyle.Underline);
            tour.BackColor = Color.Transparent;
        }

        private void gallerie_MouseEnter(object sender, EventArgs e)
        {
            gallerie.Font = new Font("Ebrima", 12, FontStyle.Underline);
        }



        private void contact_MouseEnter(object sender, EventArgs e)
        {
            Contact.Font = new Font("Ebrima", 12, FontStyle.Underline);
        }
        private void tour_MouseLeave(object sender, EventArgs e)
        {
            tour.Font = new Font("Ebrima", 12, FontStyle.Regular);
        }

        private void gallerie_MouseLeave(object sender, EventArgs e)
        {
            gallerie.Font = new Font("Ebrima", 12, FontStyle.Regular);
        }

        private void contact_MouseLeave(object sender, EventArgs e)
        {
            Contact.Font = new Font("Ebrima", 12, FontStyle.Regular);
        }

        private void loginpanel_Paint(object sender, PaintEventArgs e)
        {

        }
        int a = 1;

        private void guna2Button1_Click_1(object sender, EventArgs e)
        {
            a++;
            panel_show(new login());
            if (a % 2 == 0)
            {
                loginpanel.Visible = true;
            }
            else
            {
                loginpanel.Visible = false;

            }

        }
    }
}


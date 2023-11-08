namespace bon_voyage
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private int imagenumber = 1;
        private void loadnextimage()
        {
            timer1.Start();
            imagenumber++;
            if (imagenumber > 2)
            {
                imagenumber = 1;
            }
            pictureBox1.ImageLocation = string.Format(@"C:\Users\aya\source\repos\bon_voyage\bon_voyage\image\" + imagenumber + ".png");
        }
        private void loadrightimage()
        {
            timer1.Start();
            imagenumber--;
            if (imagenumber < 1)
            {
                imagenumber = 2;
            }
            pictureBox1.ImageLocation = string.Format(@"C:\Users\aya\source\repos\bon_voyage\bon_voyage\image\\" + imagenumber + ".png");
        }
        private void Form1_Load(object sender, EventArgs e)
        {

            exit.Parent = pictureBox1;
            exit.BackColor = Color.Transparent;
            exit.ForeColor = Color.FromArgb(242, 242, 242);
            explorer.BackColor = Color.FromArgb(242, 242, 242);
            explorer.ForeColor = Color.FromArgb(1, 40, 64);
            pictureBox1.ImageLocation = string.Format(@"C:\Users\aya\source\repos\bon_voyage\bon_voyage\image\" + imagenumber + ".png");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            loadnextimage();
            if (timer1.Interval == 3000)
            {
                timer1.Stop();
                explorer.Visible = true;

            }
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void explorer_Click(object sender, EventArgs e)
        {
            acceuil formulaire= new acceuil();
            formulaire.Show();
            
        }
    }
}
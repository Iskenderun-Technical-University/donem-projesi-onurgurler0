namespace Afetzede
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AfetzedeEkleme ekle = new AfetzedeEkleme();
            ekle.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CadirEkleme ekle = new CadirEkleme();
            ekle.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Listeleme listeleme = new Listeleme();
            listeleme.Show();
        }
    }
}
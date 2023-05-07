using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Afetzede
{
    public partial class CadirEkleme : Form
    {
        Afetzede cadirekle = new Afetzede();
        public CadirEkleme()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-OQJ59QU;Initial Catalog=Afetzede;Integrated Security=True");
        DataTable tablo;
        private void btnGeridon_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            string giris = "insert into cadir(cadir) values(@cadir+' NOLU ÇADIR')";
            SqlCommand komut2 = new SqlCommand();
            komut2.Parameters.AddWithValue("@cadir", txtCadirEkle.Text);
            cadirekle.ekle_sil_guncelle(komut2, giris);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string giris = "delete from cadir where cadir = '" + txtCadirEkle.Text.ToString() + "'";
            SqlCommand komut2 = new SqlCommand();
            cadirekle.ekle_sil_guncelle(komut2, giris);

        }
    }
}

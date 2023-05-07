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
    public partial class AfetzedeEkleme : Form
    {
        Afetzede afetzede_ekleme = new Afetzede();
        public AfetzedeEkleme()
        {
            InitializeComponent();

        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-OQJ59QU;Initial Catalog=Afetzede;Integrated Security=True");
        DataTable tablo;
        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string giris = "insert into kisiler(kimlikno,adsoyad,tel,cadir,uyruk,hasar) values(@kimlikno,@adsoyad,@tel,@cadir,@uyruk,@hasar)";
            SqlCommand komut2 = new SqlCommand();
            komut2.Parameters.AddWithValue("@kimlikno", txtTc.Text);
            komut2.Parameters.AddWithValue("@adsoyad", txtAdsoyad.Text);
            komut2.Parameters.AddWithValue("@tel", txtTel.Text);
            komut2.Parameters.AddWithValue("@cadir", cmbCadir.Text);
            komut2.Parameters.AddWithValue("@uyruk", cmbUyruk.Text);
            komut2.Parameters.AddWithValue("@hasar", cmbHasar.Text);
            afetzede_ekleme.ekle_sil_guncelle(komut2, giris);

        }

        private void AfetzedeEkleme_Load(object sender, EventArgs e)
        {
            cmbCadir.Items.Clear();

            baglanti.Open();
            SqlCommand sorgu = new SqlCommand("select *from cadir", baglanti);
            sorgu.ExecuteNonQuery();

            DataTable dt = new DataTable();
            SqlDataAdapter adp = new SqlDataAdapter(sorgu);
            adp.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                cmbCadir.Items.Add(dr["cadir"].ToString());
            }
            baglanti.Close();

            cmbUyruk.Items.Clear();

            baglanti.Open();
            SqlCommand sorgu2 = new SqlCommand("select *from Uyruk", baglanti);

            sorgu2.ExecuteNonQuery();

            DataTable dt2 = new DataTable();
            SqlDataAdapter adp2 = new SqlDataAdapter(sorgu2);
            adp2.Fill(dt2);
            foreach (DataRow dr2 in dt2.Rows)
            {
                cmbUyruk.Items.Add(dr2["uyruk"].ToString());
            }
            baglanti.Close();
            cmbHasar.Items.Clear();

            baglanti.Open();
            SqlCommand sorgu3 = new SqlCommand("select *from hasar", baglanti);
            sorgu3.ExecuteNonQuery();

            DataTable dt3 = new DataTable();
            SqlDataAdapter adp3 = new SqlDataAdapter(sorgu3);
            adp3.Fill(dt3);
            foreach (DataRow dr3 in dt3.Rows)
            {
                cmbHasar.Items.Add(dr3["hasar"].ToString());
            }
            baglanti.Close();
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            txtAdsoyad.Text = "";
            txtTc.Text = "";
            txtTel.Text = "";
            cmbCadir.Text = "";
            cmbHasar.Text = "";
            cmbUyruk.Text = "";
           
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Afetzede
{
    public partial class Listeleme : Form
    {
        Afetzede listeleme = new Afetzede();
        public Listeleme()
        {

            InitializeComponent();
        }

        private void btnGeridon_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Listeleme_Load(object sender, EventArgs e)
        {
            YenileListele();
        }

        private void YenileListele()
        {
            string giris = "select *from kisiler";
            SqlDataAdapter adtr2 = new SqlDataAdapter();
            
            dataGridView1.DataSource = listeleme.listele(adtr2, giris);
            dataGridView1.Columns[0].HeaderText = "Kimlik No";
            dataGridView1.Columns[1].HeaderText = "Ad Soyad";
            dataGridView1.Columns[2].HeaderText = "Tel No";
            dataGridView1.Columns[3].HeaderText = "Çadır No";
            dataGridView1.Columns[4].HeaderText = "Uyruk";
            dataGridView1.Columns[5].HeaderText = "Ev Hasarı";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow satir = dataGridView1.CurrentRow;
            txtTc.Text = satir.Cells[0].Value.ToString();
            txtAdsoyad.Text = satir.Cells[1].Value.ToString();
            txtTel.Text = satir.Cells[2].Value.ToString();
            cmbCadir.Text = satir.Cells[3].Value.ToString();
            cmbUyruk.Text = satir.Cells[4].Value.ToString();
            cmbHasar.Text = satir.Cells[5].Value.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string giris = "select *from kisiler where kimlikno like '%" + textBox1.Text + "%'";
            SqlDataAdapter adtr2 = new SqlDataAdapter();
           
            dataGridView1.DataSource = listeleme.listele(adtr2, giris);
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            string giris = "update kisiler set adsoyad=@adsoyad, tel=@tel, cadir=@cadir, uyruk=@Uyruk, hasar=@hasar where kimlikno=@kimlikno";
            SqlCommand komut2 = new SqlCommand();
            komut2.Parameters.AddWithValue("@kimlikno", txtTc.Text);
            komut2.Parameters.AddWithValue("@adsoyad", txtAdsoyad.Text);
            komut2.Parameters.AddWithValue("@tel", txtTel.Text);
            komut2.Parameters.AddWithValue("@cadir", cmbCadir.Text);
            komut2.Parameters.AddWithValue("@uyruk", cmbUyruk.Text);
            komut2.Parameters.AddWithValue("@hasar", cmbHasar.Text);
            listeleme.ekle_sil_guncelle(komut2, giris);
            YenileListele();

        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            DataGridViewRow satir = dataGridView1.CurrentRow;
            string giris = "delete from kisiler where tc='" + satir.Cells["kimlikno"].Value.ToString() + "'";
            SqlCommand komut2= new SqlCommand();
            listeleme.ekle_sil_guncelle(komut2, giris);
            YenileListele();

        }
    }
}

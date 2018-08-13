using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace HukukBuroOtomasyonu.KarsiTaraf
{
    public partial class FormKarsiTarafGuncelleDoldur : Form
    {
        public FormKarsiTarafGuncelleDoldur()
        {
            InitializeComponent();
        }

        public SqlConnection baglanti = new SqlConnection(@"Data Source = EMIRHAN\EMIRHANSQLSERVER; Initial Catalog = HukukBuroDB; User Id = System Admin; Password = !001994gs; ");

        private void buttonKarsiTarafKisiGuncelle_Click(object sender, EventArgs e)
        {
            if (baglanti.State == ConnectionState.Closed) baglanti.Open();
            SqlCommand spKarsiTarafKisiGuncelle = new SqlCommand();
            spKarsiTarafKisiGuncelle.Connection = baglanti;
            spKarsiTarafKisiGuncelle.CommandType = CommandType.StoredProcedure;
            spKarsiTarafKisiGuncelle.CommandText = "spKarsiTarafKisiGuncelle";
            spKarsiTarafKisiGuncelle.Parameters.AddWithValue("@KarsiTaraf_ID", textBoxKarsiTarafNo.Text);
            spKarsiTarafKisiGuncelle.Parameters.AddWithValue("@KarsiTaraf_Isim", textBoxKisi_Isim.Text);
            spKarsiTarafKisiGuncelle.Parameters.AddWithValue("@KarsiTarafTCNo", textBoxKisiTCNo.Text);
            spKarsiTarafKisiGuncelle.Parameters.AddWithValue("@KarsiTarafSicilNo", textBoxKisiSicilNo.Text);
            spKarsiTarafKisiGuncelle.Parameters.AddWithValue("@KarsiTarafCinsiyet", comboBoxKisiCinsiyet.Text);
            spKarsiTarafKisiGuncelle.Parameters.AddWithValue("@KarsiTarafTelefonNo", textBoxKarsiTarafTelefonNo.Text);
            spKarsiTarafKisiGuncelle.Parameters.AddWithValue("@KarsiTarafAdres", textBoxKarsiTarafAdres.Text);
            spKarsiTarafKisiGuncelle.Parameters.AddWithValue("@KarsiTarafTipi", comboBoxKarsiTarafTipi.Text);
            spKarsiTarafKisiGuncelle.Parameters.AddWithValue("@KarsiTarafSecimi", textBoxKarsiTarafSecimi.Text);
            spKarsiTarafKisiGuncelle.ExecuteNonQuery();

            MessageBox.Show("Karşı Taraf-Kişi Bilgileri Güncellendi");
            this.Hide();
        }

        private void buttonKarsiTarafKurulusGuncelle_Click(object sender, EventArgs e)
        {
            if (baglanti.State == ConnectionState.Closed) baglanti.Open();
            SqlCommand spKarsiTarafKurulusGuncelle = new SqlCommand();
            spKarsiTarafKurulusGuncelle.Connection = baglanti;
            spKarsiTarafKurulusGuncelle.CommandType = CommandType.StoredProcedure;
            spKarsiTarafKurulusGuncelle.CommandText = "spKarsiTarafKurulusGuncelle";
            spKarsiTarafKurulusGuncelle.Parameters.AddWithValue("@KarsiTaraf_ID", textBoxKarsiTarafNo.Text);
            spKarsiTarafKurulusGuncelle.Parameters.AddWithValue("@KarsiTaraf_Isim", textBoxKurulus_Isim.Text);
            spKarsiTarafKurulusGuncelle.Parameters.AddWithValue("@KarsiTarafVergiNo", textBoxKurulusVergiNo.Text);
            spKarsiTarafKurulusGuncelle.Parameters.AddWithValue("@KarsiTarafTelefonNo", textBoxKarsiTarafTelefonNo.Text);
            spKarsiTarafKurulusGuncelle.Parameters.AddWithValue("@KarsiTarafAdres", textBoxKarsiTarafAdres.Text);
            spKarsiTarafKurulusGuncelle.Parameters.AddWithValue("@KarsiTarafTipi", comboBoxKarsiTarafTipi.Text);
            spKarsiTarafKurulusGuncelle.Parameters.AddWithValue("@KarsiTarafSecimi", textBoxKarsiTarafSecimi.Text);
            spKarsiTarafKurulusGuncelle.ExecuteNonQuery();

            MessageBox.Show("Karşı Taraf-Kuruluş Bilgileri Güncellendi");
            this.Hide();
        }
    }
}

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

namespace HukukBuroOtomasyonu.Muvekkiller
{
    public partial class FormMuvekkilGuncelleDoldur : Form
    {
        public FormMuvekkilGuncelleDoldur()
        {
            InitializeComponent();
        }

        public SqlConnection baglanti = new SqlConnection(@"Data Source = EMIRHAN\EMIRHANSQLSERVER; Initial Catalog = HukukBuroDB; User Id = System Admin; Password = !001994gs; ");


        private void buttonMuvKisiGuncelle_Click(object sender, EventArgs e)
        {
            if (baglanti.State == ConnectionState.Closed) baglanti.Open();
            SqlCommand spMuvekkilKisiGuncelle = new SqlCommand();
            spMuvekkilKisiGuncelle.Connection = baglanti;
            spMuvekkilKisiGuncelle.CommandType = CommandType.StoredProcedure;
            spMuvekkilKisiGuncelle.CommandText = "spMuvekkilKisiGuncelle";
            spMuvekkilKisiGuncelle.Parameters.AddWithValue("@Muvekkil_ID", textBoxMuvNo.Text);
            spMuvekkilKisiGuncelle.Parameters.AddWithValue("@Muvekkil_Isim", textBoxKisi_Isim.Text);
            spMuvekkilKisiGuncelle.Parameters.AddWithValue("@MuvekkilTCNo", textBoxKisiTCNo.Text);
            spMuvekkilKisiGuncelle.Parameters.AddWithValue("@MuvekkilSicilNo", textBoxKisiSicilNo.Text);
            spMuvekkilKisiGuncelle.Parameters.AddWithValue("@MuvekkilCinsiyet", comboBoxKisiCinsiyet.Text);
            spMuvekkilKisiGuncelle.Parameters.AddWithValue("@MuvekkilTelefonNo", textBoxMuvekkilTelefonNo.Text);
            spMuvekkilKisiGuncelle.Parameters.AddWithValue("@MuvekkilAdres", textBoxMuvekkilAdres.Text);
            spMuvekkilKisiGuncelle.Parameters.AddWithValue("@MuvekkilTipi", comboBoxMuvekkilTipi.Text);
            spMuvekkilKisiGuncelle.Parameters.AddWithValue("@MuvekkilSecimi", textBoxMuvekkilSecimi.Text);
            spMuvekkilKisiGuncelle.ExecuteNonQuery();
            
            MessageBox.Show("Müvekkil-Kişi Bilgileri Güncellendi");
            this.Hide();
        }

        private void buttonMuvKurulusGuncelle_Click(object sender, EventArgs e)
        {
            if (baglanti.State == ConnectionState.Closed) baglanti.Open();
            SqlCommand spMuvekkilKurulusGuncelle = new SqlCommand();
            spMuvekkilKurulusGuncelle.Connection = baglanti;
            spMuvekkilKurulusGuncelle.CommandType = CommandType.StoredProcedure;
            spMuvekkilKurulusGuncelle.CommandText = "spMuvekkilKurulusGuncelle";
            spMuvekkilKurulusGuncelle.Parameters.AddWithValue("@Muvekkil_ID", textBoxMuvNo.Text);
            spMuvekkilKurulusGuncelle.Parameters.AddWithValue("@Muvekkil_Isim", textBoxKurulus_Isim.Text);
            spMuvekkilKurulusGuncelle.Parameters.AddWithValue("@MuvekkilVergiNo", textBoxKurulusVergiNo.Text);
            spMuvekkilKurulusGuncelle.Parameters.AddWithValue("@MuvekkilTelefonNo", textBoxMuvekkilTelefonNo.Text);
            spMuvekkilKurulusGuncelle.Parameters.AddWithValue("@MuvekkilAdres", textBoxMuvekkilAdres.Text);
            spMuvekkilKurulusGuncelle.Parameters.AddWithValue("@MuvekkilTipi", comboBoxMuvekkilTipi.Text);
            spMuvekkilKurulusGuncelle.Parameters.AddWithValue("@MuvekkilSecimi", textBoxMuvekkilSecimi.Text);
            spMuvekkilKurulusGuncelle.ExecuteNonQuery();
            
            MessageBox.Show("Müvekkil-Kuruluş Bilgileri Güncellendi");
            this.Hide();
        }
    }
}

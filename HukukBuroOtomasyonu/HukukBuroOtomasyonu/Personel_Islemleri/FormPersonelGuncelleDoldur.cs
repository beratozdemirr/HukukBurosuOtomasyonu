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

namespace HukukBuroOtomasyonu.Personel_Islemleri
{
    public partial class FormPersonelGuncelleDoldur : Form
    {
        public FormPersonelGuncelleDoldur()
        {
            InitializeComponent();
        }

        public SqlConnection baglanti = new SqlConnection(@"Data Source = EMIRHAN\EMIRHANSQLSERVER; Initial Catalog = HukukBuroDB; User Id = System Admin; Password = !001994gs; ");



        private void buttonGuncelle_Click(object sender, EventArgs e)
        {
            if (baglanti.State == ConnectionState.Closed) baglanti.Open();
            SqlCommand spPersonelGuncelle = new SqlCommand();
            spPersonelGuncelle.Connection = baglanti;
            spPersonelGuncelle.CommandType = CommandType.StoredProcedure;
            spPersonelGuncelle.CommandText = "spPersonelGuncelle";
            spPersonelGuncelle.Parameters.AddWithValue("@Personel_ID", textBoxPersonelNo.Text);
            spPersonelGuncelle.Parameters.AddWithValue("@PersonelAdiSoyadi", textBoxPersonelAdSoyad.Text);
            spPersonelGuncelle.Parameters.AddWithValue("@PersonelKullaniciAdi", textBoxPersonelKullaniciAdi.Text);
            spPersonelGuncelle.Parameters.AddWithValue("@PersonelSifre", textBoxPersonelSifre.Text);
            spPersonelGuncelle.Parameters.AddWithValue("@PersonelYetkisi", comboBoxPersonelYetkisi.Text);
            spPersonelGuncelle.Parameters.AddWithValue("@isVeriOku", checkBox_isVeriOku.Checked);
            spPersonelGuncelle.Parameters.AddWithValue("@isVeriGir", checkBox_isVeriGir.Checked);
            spPersonelGuncelle.Parameters.AddWithValue("@isVeriGuncelle", checkBox_isVeriGuncelle.Checked);
            spPersonelGuncelle.Parameters.AddWithValue("@isVeriSil", checkBox_isVeriSil.Checked);
            spPersonelGuncelle.Parameters.AddWithValue("@isRaporOlustur", checkBox_isRaporOlustur.Checked);
            spPersonelGuncelle.Parameters.AddWithValue("@isKullaniciIslemleri", checkBox_isKullanici_Islemleri.Checked);
            spPersonelGuncelle.ExecuteNonQuery();

            MessageBox.Show("Personel Bilgileri Güncellendi");
        }
    }
}

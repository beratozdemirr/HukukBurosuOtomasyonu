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
    public partial class FormPersonelEkle : Form
    {
        public FormPersonelEkle()
        {
            InitializeComponent();
        }

        public SqlConnection baglanti = new SqlConnection(@"Data Source = EMIRHAN\EMIRHANSQLSERVER; Initial Catalog = HukukBuroDB; User Id = System Admin; Password = !001994gs; ");

        public void PersonelYetkisiGetir()
        {
            if (baglanti.State == ConnectionState.Closed) baglanti.Open();
            SqlCommand yetkiYukle = new SqlCommand("SELECT DISTINCT PersonelYetkisi FROM Personel", baglanti);
            SqlDataReader okuYukle;
            okuYukle = yetkiYukle.ExecuteReader();
            while (okuYukle.Read())
            {
                comboBoxPersonelYetkisi.Items.Add(okuYukle["PersonelYetkisi"]);
            }
            baglanti.Close();
        }

        private void FormPersonelEkle_Load(object sender, EventArgs e)
        {
            PersonelYetkisiGetir();
        }

        private void buttonKaydet_Click(object sender, EventArgs e)
        {
            if (baglanti.State == ConnectionState.Closed) baglanti.Open();
            SqlCommand spPersonelEkle = new SqlCommand();
            spPersonelEkle.Connection = baglanti;
            spPersonelEkle.CommandType = CommandType.StoredProcedure;
            spPersonelEkle.CommandText = "spPersonelEkle";
            SqlParameter Personel_ID = new SqlParameter("@Personel_ID", SqlDbType.Int);
            Personel_ID.Direction = ParameterDirection.Output;
            spPersonelEkle.Parameters.Add(Personel_ID);
            spPersonelEkle.Parameters.AddWithValue("@PersonelAdiSoyadi", textBoxPersonelAdSoyad.Text);
            spPersonelEkle.Parameters.AddWithValue("@PersonelKullaniciAdi", textBoxPersonelKullaniciAdi.Text);
            spPersonelEkle.Parameters.AddWithValue("@PersonelSifre", textBoxPersonelSifre.Text);
            spPersonelEkle.Parameters.AddWithValue("@PersonelYetkisi", comboBoxPersonelYetkisi.Text);
            spPersonelEkle.Parameters.AddWithValue("@isVeriOku", checkBox_isVeriOku.Checked);
            spPersonelEkle.Parameters.AddWithValue("@isVeriGir", checkBox_isVeriGir.Checked);
            spPersonelEkle.Parameters.AddWithValue("@isVeriGuncelle", checkBox_isVeriGuncelle.Checked);
            spPersonelEkle.Parameters.AddWithValue("@isVeriSil", checkBox_isVeriSil.Checked);
            spPersonelEkle.Parameters.AddWithValue("@isRaporOlustur", checkBox_isRaporOlustur.Checked);
            spPersonelEkle.Parameters.AddWithValue("@isKullaniciIslemleri", checkBox_isRaporOlustur.Checked);
            spPersonelEkle.ExecuteNonQuery();
            MessageBox.Show("Personel Eklendi.");

            textBoxPersonelAdSoyad.Clear();
            textBoxPersonelKullaniciAdi.Clear();
            textBoxPersonelSifre.Clear();
            checkBox_isVeriOku.Checked = false;
            checkBox_isVeriGir.Checked = false;
            checkBox_isVeriGuncelle.Checked = false;
            checkBox_isVeriSil.Checked = false;
            checkBox_isRaporOlustur.Checked = false;
            checkBox_isKullanici_Islemleri.Checked = false;
        }
    }
}

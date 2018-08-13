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
using HukukBuroOtomasyonu.Personel_Islemleri;

namespace HukukBuroOtomasyonu.PersonelIslemleri
{
    public partial class FormPersoneller : Form
    {
        public FormPersoneller()
        {
            InitializeComponent();
        }

        public SqlConnection baglanti = new SqlConnection(@"Data Source = EMIRHAN\EMIRHANSQLSERVER; Initial Catalog = HukukBuroDB; User Id = System Admin; Password = !001994gs; ");
        public SqlConnection baglantiYedektenDon = new SqlConnection(@"Data Source = EMIRHAN\EMIRHANSQLSERVER; Initial Catalog = DENEME; User Id = System Admin; Password = !001994gs; ");

        public void KayitGetir()
        {
            if (baglanti.State == ConnectionState.Closed) baglanti.Open();
            string listelePersonel = "SELECT * FROM Personel";
            SqlCommand komutListele = new SqlCommand(listelePersonel, baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komutListele);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridViewPersoneller.DataSource = dt;
        }

        public void PersonelleriGetir()
        {
            if (baglanti.State == ConnectionState.Closed) baglanti.Open();
            SqlCommand personelYukle = new SqlCommand("SELECT PersonelAdiSoyadi FROM Personel", baglanti);
            SqlDataReader okuPersonelAdi;
            okuPersonelAdi = personelYukle.ExecuteReader();
            while (okuPersonelAdi.Read())
            {
                comboBoxPersoneller.Items.Add(okuPersonelAdi["PersonelAdiSoyadi"]);
            }
            baglanti.Close();
        }

        public void SilinmisDavaKayitlariniGetir()
        {
            if (baglanti.State == ConnectionState.Closed) baglanti.Open();
            string listeleSilinmis = "SELECT * FROM SilinmisDavaKayitlari";
            SqlCommand komutListele = new SqlCommand(listeleSilinmis, baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komutListele);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridViewPersoneller.DataSource = dt;
        }

        private void FormPersoneller_Load(object sender, EventArgs e)
        {
            KayitGetir();
            PersonelleriGetir();
        }

        private void buttonPersonelEkle_Click(object sender, EventArgs e)
        {
            FormPersonelEkle perEkle = new FormPersonelEkle();
            perEkle.ShowDialog();
        }

        private void buttonPersonelSil_Click(object sender, EventArgs e)
        {
            FormPersonelSil perSil = new FormPersonelSil();
            perSil.ShowDialog();
        }

        private void buttonPersonelGuncelle_Click(object sender, EventArgs e)
        {
            FormPersonelGuncelle perGunc = new FormPersonelGuncelle();
            perGunc.ShowDialog();
        }

        private void buttonRaporOlustur_Click(object sender, EventArgs e)
        {
            FormPersonelRaporOlustur perRapor = new FormPersonelRaporOlustur();
            perRapor.ShowDialog();
        }

        private void buttonAnaEkranaDon_Click(object sender, EventArgs e)
        {
            formBuroOtomasyonu acilisaDon = new formBuroOtomasyonu();
            this.Hide();
            acilisaDon.Show();
        }

        private void buttonPersonelAra_Click(object sender, EventArgs e)
        {
            if (baglanti.State == ConnectionState.Closed) baglanti.Open();
            SqlParameter PersonelBilgisi = new SqlParameter("@PersonelBilgisi", comboBoxPersoneller.Text);
            SqlCommand PersonelBilgisiAra = new SqlCommand("SELECT * FROM Personel WHERE PersonelAdiSoyadi = @PersonelBilgisi OR PersonelKullaniciAdi = @PersonelBilgisi", baglanti);
            PersonelBilgisiAra.Parameters.Add(PersonelBilgisi);
            SqlDataAdapter da = new SqlDataAdapter(PersonelBilgisiAra);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridViewPersoneller.DataSource = dt;
        }

        private void buttonListele_Click(object sender, EventArgs e)
        {
            KayitGetir();
        }

        private void buttonKullaniciYetkisiAra_Click(object sender, EventArgs e)
        {
            if (baglanti.State == ConnectionState.Closed) baglanti.Open();
            SqlParameter veriOku = new SqlParameter("@isVeriOku", SqlDbType.Bit);
            SqlParameter veriGir = new SqlParameter("@isVeriGir", SqlDbType.Bit);
            SqlParameter veriGuncelle = new SqlParameter("@isVeriGuncelle", SqlDbType.Bit);
            SqlParameter veriSil = new SqlParameter("@isVeriSil", SqlDbType.Bit);
            SqlParameter raporOlustur = new SqlParameter("@isRaporOlustur", SqlDbType.Bit);
            SqlParameter kullaniciIslemleri = new SqlParameter("@isKullaniciIslemleri", SqlDbType.Bit);
            SqlCommand PersonelYetkisiAra = new SqlCommand("SELECT * FROM Personel WHERE isVeriOku = @isVeriOku AND isVeriGir = @isVeriGir AND isVeriGuncelle = @isVeriGuncelle AND isVeriSil = @isVeriSil AND isRaporOlustur = @isRaporOlustur AND isKullaniciIslemleri = @isKullaniciIslemleri", baglanti);
            PersonelYetkisiAra.Parameters.AddWithValue("isVeriOku", checkBox_isVeriOku.Checked);
            PersonelYetkisiAra.Parameters.AddWithValue("@isVeriGir", checkBox_isVeriGir.Checked);
            PersonelYetkisiAra.Parameters.AddWithValue("@isVeriGuncelle", checkBox_isVeriGuncelle.Checked);
            PersonelYetkisiAra.Parameters.AddWithValue("@isVeriSil", checkBox_isVeriSil.Checked);
            PersonelYetkisiAra.Parameters.AddWithValue("@isRaporOlustur", checkBox_isRaporOlustur.Checked);
            PersonelYetkisiAra.Parameters.AddWithValue("@isKullaniciIslemleri", checkBox_isKullanici_Islemleri.Checked);
            SqlDataAdapter da = new SqlDataAdapter(PersonelYetkisiAra);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridViewPersoneller.DataSource = dt;
        }

        private void buttonSilinmisDavaKayitlari_Click(object sender, EventArgs e)
        {
            SilinmisDavaKayitlariniGetir();
        }

        private void buttonYedekAl_Click(object sender, EventArgs e)
        {
            if (baglanti.State == ConnectionState.Closed) baglanti.Open();
            SqlCommand sp_Backup_Database = new SqlCommand();
            sp_Backup_Database.Connection = baglanti;
            sp_Backup_Database.CommandType = CommandType.StoredProcedure;
            sp_Backup_Database.CommandText = "spBackupDB";
            sp_Backup_Database.ExecuteNonQuery();
            MessageBox.Show("Veritabanının yedeği alındı");
        }

        

        private void buttonYedektenDon_Click(object sender, EventArgs e)
        {
            OpenFileDialog dosyaYolu = new OpenFileDialog();
            dosyaYolu.ShowDialog();
            textBoxYedekDosyaYolu.Text = dosyaYolu.FileName;

            baglanti.Close();

                if (baglantiYedektenDon.State == ConnectionState.Closed) baglantiYedektenDon.Open();
                SqlCommand spRestoreDB = new SqlCommand();
                spRestoreDB.Connection = baglantiYedektenDon;
                spRestoreDB.CommandType = CommandType.StoredProcedure;
                spRestoreDB.CommandText = "spRestoreDB";
                spRestoreDB.Parameters.AddWithValue("@DosyaYolu", textBoxYedekDosyaYolu.Text);
                spRestoreDB.ExecuteNonQuery();
                MessageBox.Show("Veritabanı yedekten geri yüklendi");
                baglantiYedektenDon.Close();
            
            
        }
    }
}


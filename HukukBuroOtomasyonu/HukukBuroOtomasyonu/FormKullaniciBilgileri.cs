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

namespace HukukBuroOtomasyonu
{
    public partial class FormKullaniciBilgileri : Form
    {
        public FormKullaniciBilgileri()
        {
            InitializeComponent();
        }

        public SqlConnection baglanti = new SqlConnection(@"Data Source = EMIRHAN\EMIRHANSQLSERVER; Initial Catalog = HukukBuroDB; User Id = System Admin; Password = !001994gs; ");

        public void KayitGetir()
        {
            if (baglanti.State == ConnectionState.Closed) baglanti.Open();
            string listeleBilgi = "SELECT * FROM Personel WHERE PersonelKullaniciAdi = @PersonelKullaniciAdi AND PersonelSifre = @PersonelSifre";
            SqlCommand komutListele = new SqlCommand(listeleBilgi, baglanti);
            komutListele.Parameters.AddWithValue("@PersonelKullaniciAdi", textBoxKullaniciAdi.Text);
            komutListele.Parameters.AddWithValue("@PersonelSifre", textBoxKullaniciSifre.Text);
            SqlDataAdapter da = new SqlDataAdapter(komutListele);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridViewKullaniciBilgileri.DataSource = dt;
        }

        public void KayitYukle()
        {
            if (Convert.ToBoolean(dataGridViewKullaniciBilgileri.CurrentRow.Cells[5].Value) == true) checkBox_isVeriOku.Checked = true;
            if (Convert.ToBoolean(dataGridViewKullaniciBilgileri.CurrentRow.Cells[6].Value) == true) checkBox_isVeriGir.Checked = true;
            if (Convert.ToBoolean(dataGridViewKullaniciBilgileri.CurrentRow.Cells[7].Value) == true) checkBox_isVeriGuncelle.Checked = true;
            if (Convert.ToBoolean(dataGridViewKullaniciBilgileri.CurrentRow.Cells[8].Value) == true) checkBox_isVeriSil.Checked = true;
            if (Convert.ToBoolean(dataGridViewKullaniciBilgileri.CurrentRow.Cells[9].Value) == true) checkBox_isRaporOlustur.Checked = true;
            if (Convert.ToBoolean(dataGridViewKullaniciBilgileri.CurrentRow.Cells[10].Value) == true) checkBox_isKullanici_Islemleri.Checked = true;
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void FormKullaniciBilgileri_Load(object sender, EventArgs e)
        {
            KayitGetir();
            KayitYukle();

            SqlCommand kullaniciBilgileriniGetir = new SqlCommand();
            kullaniciBilgileriniGetir.Connection = baglanti;
            kullaniciBilgileriniGetir.CommandType = CommandType.Text;
            kullaniciBilgileriniGetir.CommandText = "SELECT PersonelKullaniciAdi, PersonelSifre, isVeriOku, isVeriGir, isVeriGuncelle, isVeriSil, isRaporOlustur, isKullaniciIslemleri FROM Personel WHERE PersonelKullaniciAdi = @PersonelKullaniciAdi AND PersonelSifre = @PersonelSifre";
            //kullaniciBilgileriniGetir.Parameters.Add
        }
    }
}

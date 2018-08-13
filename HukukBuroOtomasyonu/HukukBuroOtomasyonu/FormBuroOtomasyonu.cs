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
using HukukBuroOtomasyonu.Muvekkiller;
using HukukBuroOtomasyonu.Davalar;
using HukukBuroOtomasyonu.KarsiTaraf;
using HukukBuroOtomasyonu.PersonelIslemleri;
using HukukBuroOtomasyonu.Adliye;

namespace HukukBuroOtomasyonu
{
    public partial class formBuroOtomasyonu : Form
    {
        public formBuroOtomasyonu()
        {
            InitializeComponent();
        }

        public SqlConnection baglanti = new SqlConnection(@"Data Source = EMIRHAN\EMIRHANSQLSERVER; Initial Catalog = HukukBuroDB; User Id = System Admin; Password = !001994gs; ");


        private void BuroOtomasyonu_Load(object sender, EventArgs e)
        {
            KalanDavaSayisi();
            SonuclanmisDavaSayisi();
            BasariliDavaSayisi();
            BasarisizDavaSayisi();
            MuvekkilSayisi();
            KarsiTarafSayisi();
            KullaniciSayisi();
            YaklasanDavaNo();
        }

        public void KalanDavaSayisi()
        {
            if (baglanti.State == ConnectionState.Closed) baglanti.Open();
            SqlCommand KalanDavaSayisiGoruntule = new SqlCommand("SELECT COUNT(*) FROM Dava");
            KalanDavaSayisiGoruntule.Connection = baglanti;
            Int32 kalanDavaSayisi = (Int32)KalanDavaSayisiGoruntule.ExecuteScalar();
            textBoxKalanDavaSayisi.Text = kalanDavaSayisi.ToString();
            baglanti.Close();
        }

        public void SonuclanmisDavaSayisi()
        {
            if (baglanti.State == ConnectionState.Closed) baglanti.Open();
            SqlCommand SonuclanmisDavaSayisiGoruntule = new SqlCommand("SELECT COUNT(*) FROM DavaSonucu");
            SonuclanmisDavaSayisiGoruntule.Connection = baglanti;
            Int32 sonuclanmisDavaSayisi = (Int32)SonuclanmisDavaSayisiGoruntule.ExecuteScalar();
            textBoxSonuclanmisDavaSayisi.Text = sonuclanmisDavaSayisi.ToString();
            baglanti.Close();
        }

        public void BasariliDavaSayisi()
        {
            if (baglanti.State == ConnectionState.Closed) baglanti.Open();
            SqlCommand BasariliDavaSayisiGoruntule = new SqlCommand("SELECT COUNT(*) FROM DavaSonucu WHERE DavaSonucu = 'BAŞARILI'");
            BasariliDavaSayisiGoruntule.Connection = baglanti;
            Int32 basariliDavaSayisi = (Int32)BasariliDavaSayisiGoruntule.ExecuteScalar();
            textBoxBasariliDavaSayisi.Text = basariliDavaSayisi.ToString();
            baglanti.Close();
        }

        public void BasarisizDavaSayisi()
        {
            if (baglanti.State == ConnectionState.Closed) baglanti.Open();
            SqlCommand BasarisizDavaSayisiGoruntule = new SqlCommand("SELECT COUNT(*) FROM DavaSonucu WHERE DavaSonucu = 'BAŞARISIZ'");
            BasarisizDavaSayisiGoruntule.Connection = baglanti;
            Int32 basarisizDavaSayisi = (Int32)BasarisizDavaSayisiGoruntule.ExecuteScalar();
            textBoxBasarisizDavaSayisi.Text = basarisizDavaSayisi.ToString();
            baglanti.Close();
        }

        public void MuvekkilSayisi()
        {
            if (baglanti.State == ConnectionState.Closed) baglanti.Open();
            SqlCommand MuvekkilSayisiGoruntule = new SqlCommand("SELECT COUNT(*) FROM Muvekkil");
            MuvekkilSayisiGoruntule.Connection = baglanti;
            Int32 MuvekkilSayisi = (Int32)MuvekkilSayisiGoruntule.ExecuteScalar();
            textBoxMuvekkilSayisi.Text = MuvekkilSayisi.ToString();
            baglanti.Close();
        }

        public void KarsiTarafSayisi()
        {
            if (baglanti.State == ConnectionState.Closed) baglanti.Open();
            SqlCommand KarsiTarafSayisiGoruntule = new SqlCommand("SELECT COUNT(*) FROM KarsiTaraf");
            KarsiTarafSayisiGoruntule.Connection = baglanti;
            Int32 KarsiTarafSayisi = (Int32)KarsiTarafSayisiGoruntule.ExecuteScalar();
            textBoxKarsiTarafSayisi.Text = KarsiTarafSayisi.ToString();
            baglanti.Close();
        }

        public void KullaniciSayisi()
        {
            if (baglanti.State == ConnectionState.Closed) baglanti.Open();
            SqlCommand KullaniciSayisiGoruntule = new SqlCommand("SELECT COUNT(*) FROM Personel");
            KullaniciSayisiGoruntule.Connection = baglanti;
            Int32 KullaniciSayisi = (Int32)KullaniciSayisiGoruntule.ExecuteScalar();
            textBoxKullaniciSayisi.Text = KullaniciSayisi.ToString();
            baglanti.Close();
        }

        public void YaklasanDavaNo()
        {
            try
            {
                if (baglanti.State == ConnectionState.Closed) baglanti.Open();
                SqlCommand YaklasanDavaNoGoruntule = new SqlCommand("SELECT TOP 1 DavaNo FROM Dava ORDER BY ABS(DATEDIFF(MINUTE, DavaGelecekOturumTarihi, GETDATE()))");
                YaklasanDavaNoGoruntule.Connection = baglanti;
                Int32 YaklasanDavaNo = (Int32)YaklasanDavaNoGoruntule.ExecuteScalar();
                textBoxYaklasanDavaNo.Text = YaklasanDavaNo.ToString();
                baglanti.Close();
            }
            catch
            {
                textBoxYaklasanDavaNo.Text = "DAVA YOK";
            }
        }

        private void buttonMuvekkiller_Click(object sender, EventArgs e)
        {
            FormMuvekkiller muvekkilGit = new FormMuvekkiller();
            this.Hide();
            muvekkilGit.Show();
        }

        private void buttonDavalar_Click(object sender, EventArgs e)
        {
            FormDavalar davavaGit = new FormDavalar();
            this.Hide();
            davavaGit.Show();
        }

        private void buttonKarsiTaraf_Click(object sender, EventArgs e)
        {
            FormKarsiTaraf karsitarafGit = new FormKarsiTaraf();
            this.Hide();
            karsitarafGit.Show();
        }

        private void buttonYonetimsel_Islemler_Click(object sender, EventArgs e)
        {
            FormPersoneller personelGit = new FormPersoneller();
            this.Hide();
            personelGit.Show();
        }

        private void buttonAdliye_Click(object sender, EventArgs e)
        {

            FormAdliyeler adliyeGit = new FormAdliyeler();
            this.Hide();
            adliyeGit.Show();
        }
    }
}



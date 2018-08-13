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

namespace HukukBuroOtomasyonu.Davalar
{
    public partial class FormDavaGuncelleDoldur : Form
    {
        public FormDavaGuncelleDoldur()
        {
            InitializeComponent();
        }

        public SqlConnection baglanti = new SqlConnection(@"Data Source = EMIRHAN\EMIRHANSQLSERVER; Initial Catalog = HukukBuroDB; User Id = System Admin; Password = !001994gs; ");

        public void MuvekilleriGetir()
        {
            if (baglanti.State == ConnectionState.Closed) baglanti.Open();
            SqlCommand muvekkilYukle = new SqlCommand("SELECT Muvekkil_Isim FROM Muvekkil", baglanti);
            SqlDataReader okuMuvekkilAdi;
            okuMuvekkilAdi = muvekkilYukle.ExecuteReader();
            while (okuMuvekkilAdi.Read())
            {
                comboBoxMuvekkil_Isim.Items.Add(okuMuvekkilAdi["Muvekkil_Isim"]);
            }
            baglanti.Close();
        }

        public void KarsiTaraflariGetir()
        {
            if (baglanti.State == ConnectionState.Closed) baglanti.Open();
            SqlCommand karsiTarafYukle = new SqlCommand("SELECT KarsiTaraf_Isim FROM KarsiTaraf", baglanti);
            SqlDataReader okuKarsiTarafAdi;
            okuKarsiTarafAdi = karsiTarafYukle.ExecuteReader();
            while (okuKarsiTarafAdi.Read())
            {
                comboBoxKarsiTaraf_Isim.Items.Add(okuKarsiTarafAdi["KarsiTaraf_Isim"]);
            }
            baglanti.Close();
        }

        public void AdliyeleriGetir()
        {
            if (baglanti.State == ConnectionState.Closed) baglanti.Open();
            SqlCommand AdliyeAdiYukle = new SqlCommand("SELECT AdliyeAdi FROM Adliye", baglanti);
            SqlDataReader okuAdliyeAdi;
            okuAdliyeAdi = AdliyeAdiYukle.ExecuteReader();
            while (okuAdliyeAdi.Read())
            {
                comboBoxAdliyeBinasi.Items.Add(okuAdliyeAdi["AdliyeAdi"]);
            }
            baglanti.Close();
        }

        public void Muvekkil_IDGetir()
        {
            if (baglanti.State == ConnectionState.Closed) baglanti.Open();
            SqlCommand Muv_IDGetir = new SqlCommand("SELECT Muvekkil_ID FROM Muvekkil WHERE Muvekkil_Isim = @Muvekkil_Isim");
            Muv_IDGetir.Parameters.AddWithValue("@Muvekkil_Isim", comboBoxMuvekkil_Isim.Text);
            Muv_IDGetir.Connection = baglanti;
            Int32 Muvekkil_ID = (Int32)Muv_IDGetir.ExecuteScalar();
            textBoxMuvekkil_ID.Text = Muvekkil_ID.ToString();
            baglanti.Close();
        }

        public void KarsiTaraf_IDGetir()
        {
            if (baglanti.State == ConnectionState.Closed) baglanti.Open();
            SqlCommand KT_IDGetir = new SqlCommand("SELECT KarsiTaraf_ID FROM KarsiTaraf WHERE KarsiTaraf_Isim = @KarsiTaraf_Isim");
            KT_IDGetir.Parameters.AddWithValue("@KarsiTaraf_Isim", comboBoxKarsiTaraf_Isim.Text);
            KT_IDGetir.Connection = baglanti;
            Int32 KarsiTaraf_ID = (Int32)KT_IDGetir.ExecuteScalar();
            textBoxKarsiTaraf_ID.Text = KarsiTaraf_ID.ToString();
            baglanti.Close();
        }

        public void Adliye_IDGetir()
        {
            if (baglanti.State == ConnectionState.Closed) baglanti.Open();
            SqlCommand Adliye_IDGetir = new SqlCommand("SELECT Adliye_ID FROM Adliye WHERE AdliyeAdi = @AdliyeAdi");
            Adliye_IDGetir.Parameters.AddWithValue("@AdliyeAdi", comboBoxAdliyeBinasi.Text);
            Adliye_IDGetir.Connection = baglanti;
            Int32 Adliye_ID = (Int32)Adliye_IDGetir.ExecuteScalar();
            textBoxAdliye_ID.Text = Adliye_ID.ToString();
            baglanti.Close();
        }

        public void AdliyeAdresiGetir()
        {
            if (baglanti.State == ConnectionState.Closed) baglanti.Open();
            SqlCommand AdliyeAdresiGetir = new SqlCommand("SELECT AdliyeAdres FROM Adliye WHERE AdliyeAdi = @AdliyeAdresi");
            AdliyeAdresiGetir.Parameters.AddWithValue("@AdliyeAdresi", comboBoxAdliyeBinasi.Text);
            AdliyeAdresiGetir.Connection = baglanti;
            SqlDataReader AdliyeAdresi;
            AdliyeAdresi = AdliyeAdresiGetir.ExecuteReader();
            while (AdliyeAdresi.Read())
            {
                textBoxAdliyeAdresi.Text = Convert.ToString(AdliyeAdresi["AdliyeAdres"]);
            }
            baglanti.Close();
        }

        private void FormDavaGuncelleDoldur_Load(object sender, EventArgs e)
        {
            MuvekilleriGetir();
            KarsiTaraflariGetir();
            AdliyeleriGetir();
        }

        private void checkBoxMuvOnay_CheckedChanged(object sender, EventArgs e)
        {
            Muvekkil_IDGetir();
        }

        private void checkBoxKTOnay_CheckedChanged(object sender, EventArgs e)
        {
            KarsiTaraf_IDGetir();
        }

        private void checkBoxAdliyeOnay_CheckedChanged(object sender, EventArgs e)
        {
            Adliye_IDGetir();
            AdliyeAdresiGetir();
        }

        private void buttonGuncelle_Click(object sender, EventArgs e)
        {
            if (baglanti.State == ConnectionState.Closed) baglanti.Open();
            SqlCommand spDavaGuncelle = new SqlCommand();
            spDavaGuncelle.Connection = baglanti;
            spDavaGuncelle.CommandType = CommandType.StoredProcedure;
            spDavaGuncelle.CommandText = "spDavaGuncelle";
            spDavaGuncelle.Parameters.AddWithValue("@Dava_ID", textBoxDavaID.Text);
            spDavaGuncelle.Parameters.AddWithValue("@Muvekkil_ID", textBoxMuvekkil_ID.Text);
            spDavaGuncelle.Parameters.AddWithValue("@KarsiTaraf_ID", textBoxKarsiTaraf_ID.Text);
            spDavaGuncelle.Parameters.AddWithValue("@Personel_ID", textBoxPersonel_ID.Text);
            spDavaGuncelle.Parameters.AddWithValue("@Adliye_ID", textBoxAdliye_ID.Text);
            spDavaGuncelle.Parameters.AddWithValue("@DavaNo", textBoxDavaNo.Text);
            spDavaGuncelle.Parameters.AddWithValue("@DavaAcilisTarihi", dateTimePickerDavaAcilisTarihi.Value);
            spDavaGuncelle.Parameters.AddWithValue("@DavaTuru", comboBoxDavaTuru.Text);
            spDavaGuncelle.Parameters.AddWithValue("@DavaMuvekkilTalep", textBoxMuvekkilTalebi.Text);
            spDavaGuncelle.Parameters.AddWithValue("@DavaTutari", textBoxDavaTutari.Text);
            spDavaGuncelle.Parameters.AddWithValue("@DavaSalonNo", textBoxSalonNo.Text);
            spDavaGuncelle.Parameters.AddWithValue("@DavaGelecekOturumTarihi", dateTimePickerGelecekOturumTarihi.Value);
            spDavaGuncelle.Parameters.AddWithValue("@DavaSaati", textBoxOturumSaati.Text);
            spDavaGuncelle.ExecuteNonQuery();

            MessageBox.Show("Dava Bilgileri Güncellendi");
        }
    }
}

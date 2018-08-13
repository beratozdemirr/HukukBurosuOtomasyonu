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
    public partial class FormDavaEkle : Form
    {
        public FormDavaEkle()
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
                textBoxAdliyeAdresi.Text = Convert.ToString( AdliyeAdresi["AdliyeAdres"] );
            }
            baglanti.Close();
        }

        private void FormDavaEkle_Load(object sender, EventArgs e)
        {
            MuvekilleriGetir();
            KarsiTaraflariGetir();
            AdliyeleriGetir();
        }

        private void buttonKaydet_Click(object sender, EventArgs e)
        {
            if (baglanti.State == ConnectionState.Closed) baglanti.Open();
            SqlCommand spDavaEkle = new SqlCommand();
            spDavaEkle.Connection = baglanti;
            spDavaEkle.CommandType = CommandType.StoredProcedure;
            spDavaEkle.CommandText = "spDavaEkle";
            SqlParameter Dava_ID = new SqlParameter("@Dava_ID", SqlDbType.Int);
            Dava_ID.Direction = ParameterDirection.Output;
            spDavaEkle.Parameters.Add(Dava_ID);
            spDavaEkle.Parameters.AddWithValue("@Muvekkil_ID", textBoxMuvekkil_ID.Text);
            spDavaEkle.Parameters.AddWithValue("@KarsiTaraf_ID", textBoxKarsiTaraf_ID.Text);
            spDavaEkle.Parameters.AddWithValue("@Personel_ID", textBoxPersonel_ID.Text);
            spDavaEkle.Parameters.AddWithValue("@Adliye_ID", textBoxAdliye_ID.Text);
            spDavaEkle.Parameters.AddWithValue("@DavaNo", textBoxDavaNo.Text);
            spDavaEkle.Parameters.AddWithValue("@DavaAcilisTarihi", dateTimePickeDavaBaslangicTarihi.Value);
            spDavaEkle.Parameters.AddWithValue("@DavaTuru", comboBoxDavaTuru.Text);
            spDavaEkle.Parameters.AddWithValue("@DavaMuvekkilTalep", textBoxMuvekkilTalebi.Text);
            spDavaEkle.Parameters.AddWithValue("@DavaTutari", textBoxDavaTutari.Text);
            spDavaEkle.Parameters.AddWithValue("@DavaSalonNo", textBoxSalonNo.Text);
            spDavaEkle.Parameters.AddWithValue("@DavaGelecekOturumTarihi", dateTimePickerGelecekOturumTarihi.Value);
            spDavaEkle.Parameters.AddWithValue("@DavaSaati", textBoxOturumSaati.Text);
            spDavaEkle.ExecuteNonQuery();
            MessageBox.Show("Dava Eklendi.");

            textBoxMuvekkil_ID.Clear();
            textBoxKarsiTaraf_ID.Clear();
            textBoxPersonel_ID.Clear();
            textBoxAdliye_ID.Clear();
            textBoxDavaNo.Clear();
            comboBoxDavaTuru.Items.Add("");
            textBoxMuvekkilTalebi.Clear();
            textBoxDavaTutari.Clear();
            textBoxSalonNo.Clear();
            textBoxOturumSaati.Clear();
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
    }
}

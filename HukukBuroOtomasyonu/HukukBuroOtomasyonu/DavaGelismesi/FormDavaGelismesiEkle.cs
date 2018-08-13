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

namespace HukukBuroOtomasyonu.DavaGelismesi
{
    public partial class FormDavaGelismesiEkle : Form
    {
        public FormDavaGelismesiEkle()
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


        public void DavaNoGetir()
        {
            if (baglanti.State == ConnectionState.Closed) baglanti.Open();
            SqlCommand Dava_IDYukle = new SqlCommand("SELECT Dava_ID FROM Dava WHERE Muvekkil_ID IN(SELECT Muvekkil_ID FROM Muvekkil WHERE Muvekkil_Isim = @Muvekkil_Isim)", baglanti);
            Dava_IDYukle.Parameters.AddWithValue("Muvekkil_Isim", comboBoxMuvekkil_Isim.Text);
            SqlDataReader okuDava_ID;
            okuDava_ID = Dava_IDYukle.ExecuteReader();
            while (okuDava_ID.Read())
            {
                comboBoxDavaNoSec.Items.Add(okuDava_ID["Dava_ID"]);
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


        public void Dava_IDGetir()
        {
            if (baglanti.State == ConnectionState.Closed) baglanti.Open();
            SqlCommand Dava_IDGetir = new SqlCommand("SELECT Dava_ID FROM Dava WHERE Muvekkil_ID IN(SELECT Muvekkil_ID FROM Muvekkil WHERE Muvekkil_Isim = @Muvekkil_Isim)");
            Dava_IDGetir.Parameters.AddWithValue("@Muvekkil_Isim", comboBoxMuvekkil_Isim.Text);
            Dava_IDGetir.Connection = baglanti;
            Int32 Dava_ID = (Int32)Dava_IDGetir.ExecuteScalar();
            textBoxDava_ID.Text = Dava_ID.ToString();
            baglanti.Close();
        }

        private void FormDavaGelismesiEkle_Load(object sender, EventArgs e)
        {
            MuvekilleriGetir();
        }

        private void buttonKaydet_Click(object sender, EventArgs e)
        {
            if (baglanti.State == ConnectionState.Closed) baglanti.Open();
            SqlCommand spDavaGelismesiEkle = new SqlCommand();
            spDavaGelismesiEkle.Connection = baglanti;
            spDavaGelismesiEkle.CommandType = CommandType.StoredProcedure;
            spDavaGelismesiEkle.CommandText = "spDavaGelismesiEkle";
            SqlParameter Gelisme_ID = new SqlParameter("@Gelisme_ID", SqlDbType.Int);
            Gelisme_ID.Direction = ParameterDirection.Output;
            spDavaGelismesiEkle.Parameters.Add(Gelisme_ID);
            spDavaGelismesiEkle.Parameters.AddWithValue("@Muvekkil_ID", textBoxMuvekkil_ID.Text);
            spDavaGelismesiEkle.Parameters.AddWithValue("@Dava_ID", textBoxDava_ID.Text);
            spDavaGelismesiEkle.Parameters.AddWithValue("@GelismeAciklamasi", textBoxGelismeAciklamasi.Text);
            spDavaGelismesiEkle.Parameters.AddWithValue("@GelismeTarihi", dateTimePickerGelismeTarihi.Value);
            spDavaGelismesiEkle.Parameters.AddWithValue("@DavaDurumu", comboBoxDavaDurumu.Text);
            spDavaGelismesiEkle.ExecuteNonQuery();
            MessageBox.Show("Gelişme Eklendi.");

            textBoxGelismeAciklamasi.Clear();
            comboBoxDavaDurumu.Items.Add("");
        }

        private void checkBoxMuvekkilOnayla_CheckedChanged(object sender, EventArgs e)
        {
            Muvekkil_IDGetir();
            comboBoxDavaNoSec.Items.Clear();
            DavaNoGetir();
        }

        private void checkBoxDavaOnayla_CheckedChanged(object sender, EventArgs e)
        {
            Dava_IDGetir();
        }
    }
}

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
    public partial class FormKarsiTarafEkle : Form
    {
        public FormKarsiTarafEkle()
        {
            InitializeComponent();
        }

        public SqlConnection baglanti = new SqlConnection(@"Data Source = EMIRHAN\EMIRHANSQLSERVER; Initial Catalog = HukukBuroDB; User Id = System Admin; Password = !001994gs; ");


        private void buttonKarsiTarafSec_Click(object sender, EventArgs e)
        {
            if (comboBoxKarsiTarafSecimi.Text == "KİŞİ")
            {
                groupBoxKisiselBilgilerKisi.Visible = true;
                groupBoxKisiselBilgilerKurulus.Visible = false;
                buttonKaydetKisi.Visible = true;
                buttonKaydetKurulus.Visible = false;
            }

            else if (comboBoxKarsiTarafSecimi.Text == "KURULUŞ")
            {
                groupBoxKisiselBilgilerKurulus.Visible = true;
                groupBoxKisiselBilgilerKisi.Visible = false;
                buttonKaydetKurulus.Visible = true;
                buttonKaydetKisi.Visible = false;
            }
        }


        private void buttonKaydetKurulus_Click(object sender, EventArgs e)
        {
            if (baglanti.State == ConnectionState.Closed) baglanti.Open();
            SqlCommand spKarsiTarafKurulusEkle = new SqlCommand();
            spKarsiTarafKurulusEkle.Connection = baglanti;
            spKarsiTarafKurulusEkle.CommandType = CommandType.StoredProcedure;
            spKarsiTarafKurulusEkle.CommandText = "spKarsiTarafKurulusEkle";
            SqlParameter KarsiTaraf_ID = new SqlParameter("@KarsiTaraf_ID", SqlDbType.Int);
            KarsiTaraf_ID.Direction = ParameterDirection.Output;
            spKarsiTarafKurulusEkle.Parameters.Add(KarsiTaraf_ID);
            spKarsiTarafKurulusEkle.Parameters.AddWithValue("@KarsiTaraf_Isim", textBoxKurulus_Isim.Text);
            spKarsiTarafKurulusEkle.Parameters.AddWithValue("@KarsiTarafVergiNo", textBoxKurulusVergiNo.Text);
            spKarsiTarafKurulusEkle.Parameters.AddWithValue("@KarsiTarafTelefonNo", textBoxKarsiTarafTelefonNo.Text);
            spKarsiTarafKurulusEkle.Parameters.AddWithValue("@KarsiTarafAdres", textBoxKarsiTarafAdres.Text);
            spKarsiTarafKurulusEkle.Parameters.AddWithValue("@KarsiTarafTipi", comboBoxKarsiTarafTipi.Text);
            spKarsiTarafKurulusEkle.Parameters.AddWithValue("@KarsiTarafSecimi", comboBoxKarsiTarafSecimi.Text);
            spKarsiTarafKurulusEkle.ExecuteNonQuery();
            MessageBox.Show("Karşı Taraf-Kuruluş Eklendi.");

            textBoxKurulus_Isim.Clear();
            textBoxKurulusVergiNo.Clear();
            textBoxKarsiTarafTelefonNo.Clear();
            textBoxKarsiTarafAdres.Clear();
            comboBoxKarsiTarafTipi.Items.Add("");
            comboBoxKarsiTarafSecimi.Items.Add("");
        }

        private void buttonKaydetKisi_Click(object sender, EventArgs e)
        {
            if (baglanti.State == ConnectionState.Closed) baglanti.Open();
            SqlCommand spKarsiTarafKisiEkle = new SqlCommand();
            spKarsiTarafKisiEkle.Connection = baglanti;
            spKarsiTarafKisiEkle.CommandType = CommandType.StoredProcedure;
            spKarsiTarafKisiEkle.CommandText = "spKarsiTarafKisiEkle";
            SqlParameter KarsiTaraf_ID = new SqlParameter("@KarsiTaraf_ID", SqlDbType.Int);
            KarsiTaraf_ID.Direction = ParameterDirection.Output;
            spKarsiTarafKisiEkle.Parameters.Add(KarsiTaraf_ID);
            spKarsiTarafKisiEkle.Parameters.AddWithValue("@KarsiTaraf_Isim", textBoxKisi_Isim.Text);
            spKarsiTarafKisiEkle.Parameters.AddWithValue("@KarsiTarafTCNo", textBoxKisiTCNo.Text);
            spKarsiTarafKisiEkle.Parameters.AddWithValue("@KarsiTarafSicilNo", textBoxKisiSicilNo.Text);
            spKarsiTarafKisiEkle.Parameters.AddWithValue("@KarsiTarafCinsiyet", comboBoxKisiCinsiyet.Text);
            spKarsiTarafKisiEkle.Parameters.AddWithValue("@KarsiTarafTelefonNo", textBoxKarsiTarafTelefonNo.Text);
            spKarsiTarafKisiEkle.Parameters.AddWithValue("@KarsiTarafAdres", textBoxKarsiTarafAdres.Text);
            spKarsiTarafKisiEkle.Parameters.AddWithValue("@KarsiTarafTipi", comboBoxKarsiTarafTipi.Text);
            spKarsiTarafKisiEkle.Parameters.AddWithValue("@KarsiTarafSecimi", comboBoxKarsiTarafSecimi.Text);
            spKarsiTarafKisiEkle.ExecuteNonQuery();
            MessageBox.Show("Karşı Taraf-Kişi Eklendi.");

            textBoxKisi_Isim.Clear();
            textBoxKisiTCNo.Clear();
            textBoxKisiSicilNo.Clear();
            comboBoxKisiCinsiyet.Items.Add("");
            textBoxKarsiTarafTelefonNo.Clear();
            textBoxKarsiTarafAdres.Clear();
            comboBoxKarsiTarafTipi.Items.Add("");
            comboBoxKarsiTarafSecimi.Items.Add("");
        }

        
    }
}

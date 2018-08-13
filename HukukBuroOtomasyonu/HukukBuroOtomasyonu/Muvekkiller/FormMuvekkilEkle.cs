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
    public partial class FormMuvekkilEkle : Form
    {
        public FormMuvekkilEkle()
        {
            InitializeComponent();
        }

        public SqlConnection baglanti = new SqlConnection(@"Data Source = EMIRHAN\EMIRHANSQLSERVER; Initial Catalog = HukukBuroDB; User Id = System Admin; Password = !001994gs; ");


        private void FormMuvekkilEkle_Load(object sender, EventArgs e)
        {
           
        }

        private void buttonMuvekkilSec_Click(object sender, EventArgs e)
        {
            if (comboBoxMuvekkilSecimi.Text == "KİŞİ")
            {
                groupBoxKisiselBilgilerKisi.Visible = true;
                groupBoxKisiselBilgilerKurulus.Visible = false;
                buttonKaydetKisi.Visible = true;
                buttonKaydetKurulus.Visible = false;
            }
    
            else if (comboBoxMuvekkilSecimi.Text == "KURULUŞ")
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
            SqlCommand spMuvekkilKurulusEkle = new SqlCommand();
            spMuvekkilKurulusEkle.Connection = baglanti;
            spMuvekkilKurulusEkle.CommandType = CommandType.StoredProcedure;
            spMuvekkilKurulusEkle.CommandText = "spMuvekkilKurulusEkle";
            SqlParameter Muvekkil_ID = new SqlParameter("@Muvekkil_ID", SqlDbType.Int);
            Muvekkil_ID.Direction = ParameterDirection.Output;
            spMuvekkilKurulusEkle.Parameters.Add(Muvekkil_ID);
            spMuvekkilKurulusEkle.Parameters.AddWithValue("@Muvekkil_Isim", textBoxKurulus_Isim.Text);
            spMuvekkilKurulusEkle.Parameters.AddWithValue("@MuvekkilVergiNo", textBoxKurulusVergiNo.Text);
            spMuvekkilKurulusEkle.Parameters.AddWithValue("@MuvekkilTelefonNo", textBoxMuvekkilTelefonNo.Text);
            spMuvekkilKurulusEkle.Parameters.AddWithValue("@MuvekkilAdres", textBoxMuvekkilAdres.Text);
            spMuvekkilKurulusEkle.Parameters.AddWithValue("@MuvekkilTipi", comboBoxMuvekkilTipi.Text);
            spMuvekkilKurulusEkle.Parameters.AddWithValue("@MuvekkilSecimi", comboBoxMuvekkilSecimi.Text);
            spMuvekkilKurulusEkle.ExecuteNonQuery();
            MessageBox.Show("Müvekkil-Kuruluş Eklendi.");

            textBoxKurulus_Isim.Clear();
            textBoxKurulusVergiNo.Clear();
            textBoxMuvekkilTelefonNo.Clear();
            textBoxMuvekkilAdres.Clear();
            comboBoxMuvekkilTipi.Items.Add("");
            comboBoxMuvekkilSecimi.Items.Add("");
        }

        private void buttonKaydetKisi_Click(object sender, EventArgs e)
        {
            if (baglanti.State == ConnectionState.Closed) baglanti.Open();
            SqlCommand spMuvekkilKisiEkle = new SqlCommand();
            spMuvekkilKisiEkle.Connection = baglanti;
            spMuvekkilKisiEkle.CommandType = CommandType.StoredProcedure;
            spMuvekkilKisiEkle.CommandText = "spMuvekkilKisiEkle";
            SqlParameter Muvekkil_ID = new SqlParameter("@Muvekkil_ID", SqlDbType.Int);
            Muvekkil_ID.Direction = ParameterDirection.Output;
            spMuvekkilKisiEkle.Parameters.Add(Muvekkil_ID);
            spMuvekkilKisiEkle.Parameters.AddWithValue("@Muvekkil_Isim", textBoxKisi_Isim.Text);
            spMuvekkilKisiEkle.Parameters.AddWithValue("@MuvekkilTCNo", textBoxKisiTCNo.Text);
            spMuvekkilKisiEkle.Parameters.AddWithValue("@MuvekkilSicilNo", textBoxKisiSicilNo.Text);
            spMuvekkilKisiEkle.Parameters.AddWithValue("@MuvekkilCinsiyet", comboBoxKisiCinsiyet.Text);
            spMuvekkilKisiEkle.Parameters.AddWithValue("@MuvekkilTelefonNo", textBoxMuvekkilTelefonNo.Text);
            spMuvekkilKisiEkle.Parameters.AddWithValue("@MuvekkilAdres", textBoxMuvekkilAdres.Text);
            spMuvekkilKisiEkle.Parameters.AddWithValue("@MuvekkilTipi", comboBoxMuvekkilTipi.Text);
            spMuvekkilKisiEkle.Parameters.AddWithValue("@MuvekkilSecimi", comboBoxMuvekkilSecimi.Text);
            spMuvekkilKisiEkle.ExecuteNonQuery();
            MessageBox.Show("Müvekkil-Kişi Eklendi.");

            textBoxKisi_Isim.Clear();
            textBoxKisiTCNo.Clear();
            textBoxKisiSicilNo.Clear();
            comboBoxKisiCinsiyet.Items.Add("");
            textBoxMuvekkilTelefonNo.Clear();
            textBoxMuvekkilAdres.Clear();
            comboBoxMuvekkilTipi.Items.Add("");
            comboBoxMuvekkilSecimi.Items.Add("");
        }

       
    }
}

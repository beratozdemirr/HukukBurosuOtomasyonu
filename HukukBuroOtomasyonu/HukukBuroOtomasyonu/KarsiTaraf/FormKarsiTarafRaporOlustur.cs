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
    public partial class FormKarsiTarafRaporOlustur : Form
    {
        public FormKarsiTarafRaporOlustur()
        {
            InitializeComponent();
        }

        public SqlConnection baglanti = new SqlConnection(@"Data Source = EMIRHAN\EMIRHANSQLSERVER; Initial Catalog = HukukBuroDB; User Id = System Admin; Password = !001994gs; ");

        public void KayitGetir()
        {
            if (baglanti.State == ConnectionState.Closed) baglanti.Open();
            string listeleKarsiTaraf = "SELECT * FROM KarsiTaraf";
            SqlCommand komutListele = new SqlCommand(listeleKarsiTaraf, baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komutListele);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridViewKarsiTaraf.DataSource = dt;
        }

        private void buttonKarsiTarafBilgisiAra_Click(object sender, EventArgs e)
        {
            if (baglanti.State == ConnectionState.Closed) baglanti.Open();
            SqlParameter KarsiTarafBilgisi = new SqlParameter("@KarsiTarafBilgisi", textBoxAraCoklu.Text);
            SqlCommand KarsiTarafBilgisiAra = new SqlCommand("SELECT * FROM KarsiTaraf WHERE KarsiTaraf_Isim = @KarsiTarafBilgisi OR KarsiTarafTCNo = @KarsiTarafBilgisi OR KarsiTarafVergiNo = @KarsiTarafBilgisi OR KarsiTarafSicilNo = @KarsiTarafBilgisi OR KarsiTarafCinsiyet = @KarsiTarafBilgisi OR KarsiTarafTelefonNo = @KarsiTarafBilgisi OR KarsiTarafAdres = @KarsiTarafBilgisi OR KarsiTarafTipi = @KarsiTarafBilgisi OR KarsiTarafSecimi = @KarsiTarafBilgisi", baglanti);
            KarsiTarafBilgisiAra.Parameters.Add(KarsiTarafBilgisi);
            SqlDataAdapter da = new SqlDataAdapter(KarsiTarafBilgisiAra);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridViewKarsiTaraf.DataSource = dt;
        }

        private void buttonKarsiTarafTipAra_Click(object sender, EventArgs e)
        {
            if (baglanti.State == ConnectionState.Closed) baglanti.Open();
            SqlCommand spKarsiTarafTipiBul = new SqlCommand();
            spKarsiTarafTipiBul.Connection = baglanti;
            spKarsiTarafTipiBul.CommandType = CommandType.StoredProcedure;
            spKarsiTarafTipiBul.CommandText = "spKarsiTarafTipiBul";
            spKarsiTarafTipiBul.Parameters.AddWithValue("@KarsiTarafTipi", comboBoxAraKarsiTarafTipi.Text);
            spKarsiTarafTipiBul.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter(spKarsiTarafTipiBul);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridViewKarsiTaraf.DataSource = dt;
        }

        private void FormKarsiTarafRaporOlustur_Load(object sender, EventArgs e)
        {
            KayitGetir();
        }

        private void buttonListele_Click(object sender, EventArgs e)
        {
            KayitGetir();
        }
    }
}

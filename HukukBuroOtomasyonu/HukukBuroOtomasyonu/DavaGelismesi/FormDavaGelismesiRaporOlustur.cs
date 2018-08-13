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
    public partial class FormDavaGelismesiRaporOlustur : Form
    {
        public FormDavaGelismesiRaporOlustur()
        {
            InitializeComponent();
        }

        public SqlConnection baglanti = new SqlConnection(@"Data Source = EMIRHAN\EMIRHANSQLSERVER; Initial Catalog = HukukBuroDB; User Id = System Admin; Password = !001994gs; ");

        public void KayitGetir()
        {
            if (baglanti.State == ConnectionState.Closed) baglanti.Open();
            string listeleDavaGelismesi = "SELECT * FROM DavaGelismesi";
            SqlCommand komutListele = new SqlCommand(listeleDavaGelismesi, baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komutListele);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridViewDavaGelismeleri.DataSource = dt;
        }

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

        private void buttonAraligaGoreGelismeBul_Click(object sender, EventArgs e)
        {
            if (baglanti.State == ConnectionState.Closed) baglanti.Open();
            SqlParameter BaslangicTarihi = new SqlParameter("@BaslangicTarihi", dateTimePickerBaslangicTarihi.Value);
            SqlParameter BitisTarihi = new SqlParameter("@BitisTarihi", dateTimePickerBitisTarihi.Value);
            SqlCommand AraligaGoreGelismeBul = new SqlCommand("SELECT * FROM DavaGelismesi WHERE GelismeTarihi BETWEEN @BaslangicTarihi AND @BitisTarihi", baglanti);
            AraligaGoreGelismeBul.Parameters.Add(BaslangicTarihi);
            AraligaGoreGelismeBul.Parameters.Add(BitisTarihi);
            SqlDataAdapter da = new SqlDataAdapter(AraligaGoreGelismeBul);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridViewDavaGelismeleri.DataSource = dt;
        }

        private void buttonMuvekkileGoreGelismeAra_Click(object sender, EventArgs e)
        {
            if (baglanti.State == ConnectionState.Closed) baglanti.Open();
            SqlParameter Muvekkil_Isim = new SqlParameter("@Muvekkil_Isim", comboBoxMuvekkil_Isim.Text);
            SqlCommand MuvekkileGoreGelismeGetir = new SqlCommand("SELECT * FROM DavaGelismesi WHERE Muvekkil_ID IN(SELECT Muvekkil_ID FROM Muvekkil WHERE Muvekkil_Isim = @Muvekkil_Isim)", baglanti);
            MuvekkileGoreGelismeGetir.Parameters.Add(Muvekkil_Isim);
            SqlDataAdapter da = new SqlDataAdapter(MuvekkileGoreGelismeGetir);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridViewDavaGelismeleri.DataSource = dt;
        }

        private void buttonDavaDurumuAra_Click(object sender, EventArgs e)
        {
            if (baglanti.State == ConnectionState.Closed) baglanti.Open();
            SqlCommand spDavaDurumuBul = new SqlCommand();
            spDavaDurumuBul.Connection = baglanti;
            spDavaDurumuBul.CommandType = CommandType.StoredProcedure;
            spDavaDurumuBul.CommandText = "spDavaDurumuBul";
            spDavaDurumuBul.Parameters.AddWithValue("@DavaDurumu", comboBoxDavaDurumu.Text);
            spDavaDurumuBul.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter(spDavaDurumuBul);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridViewDavaGelismeleri.DataSource = dt;
        }

        private void buttonListele_Click(object sender, EventArgs e)
        {
            KayitGetir();
        }

        private void FormDavaGelismesiRaporOlustur_Load(object sender, EventArgs e)
        {
            MuvekilleriGetir();
            KayitGetir();
        }

        private void buttonRaporOlustur_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxDavaDurumu_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePickerBitisTarihi_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePickerBaslangicTarihi_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxMuvekkil_Isim_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

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
    public partial class FormDavaGelismesiSil : Form
    {
        public FormDavaGelismesiSil()
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

        private void FormDavaGelismesiSil_Load(object sender, EventArgs e)
        {
            MuvekilleriGetir();
            KayitGetir();
        }

        private void buttonSil_Click(object sender, EventArgs e)
        {
            if (baglanti.State == ConnectionState.Closed) baglanti.Open();
            SqlCommand spDavaGelismesiSil = new SqlCommand();
            spDavaGelismesiSil.Connection = baglanti;
            spDavaGelismesiSil.CommandType = CommandType.StoredProcedure;
            spDavaGelismesiSil.CommandText = "spDavaGelismesiSil";
            spDavaGelismesiSil.Parameters.Add("@Gelisme_ID", dataGridViewDavaGelismeleri.CurrentRow.Cells[0].Value.ToString());
            spDavaGelismesiSil.ExecuteNonQuery();
            MessageBox.Show("Gelişme Bilgileri Silindi");
            KayitGetir();
        }
    }
}

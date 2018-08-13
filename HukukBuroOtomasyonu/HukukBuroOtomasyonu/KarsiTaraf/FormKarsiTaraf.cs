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
    public partial class FormKarsiTaraf : Form
    {
        public FormKarsiTaraf()
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

        private void buttonKarsiTarafEkle_Click(object sender, EventArgs e)
        {
            FormKarsiTarafEkle karsiTarafEkle = new FormKarsiTarafEkle();
            karsiTarafEkle.ShowDialog();
        }

        private void buttonKarsiTarafSil_Click(object sender, EventArgs e)
        {
            FormKarsiTarafSil karsiTarafSil = new FormKarsiTarafSil();
            karsiTarafSil.ShowDialog();
        }

        private void buttonKarsiTarafGuncelle_Click(object sender, EventArgs e)
        {
            FormKarsiTarafGuncelle karsiTarafGuncelle = new FormKarsiTarafGuncelle();
            karsiTarafGuncelle.ShowDialog();
        }

        private void buttonKarsiTarafRaporuOlustur_Click(object sender, EventArgs e)
        {
            FormKarsiTarafRaporOlustur karsiTarafRapor = new FormKarsiTarafRaporOlustur();
            karsiTarafRapor.ShowDialog();
        }

        private void buttonAnaEkranaDön_Click(object sender, EventArgs e)
        {
            formBuroOtomasyonu acilisaDon = new formBuroOtomasyonu();
            this.Hide();
            acilisaDon.Show();
        }

        private void buttonKarsiTarafAra_Click(object sender, EventArgs e)
        {
            if (baglanti.State == ConnectionState.Closed) baglanti.Open();
            SqlParameter KarsiTarafBilgisi = new SqlParameter("@KarsiTarafBilgisi", textBoxKarsiTarafBilgisiAra.Text);
            SqlCommand KarsiTarafBilgisiAra = new SqlCommand("SELECT * FROM KarsiTaraf WHERE KarsiTaraf_Isim = @KarsiTarafBilgisi OR KarsiTarafTCNo = @KarsiTarafBilgisi OR KarsiTarafVergiNo = @KarsiTarafBilgisi OR KarsiTarafSicilNo = @KarsiTarafBilgisi OR KarsiTarafCinsiyet = @KarsiTarafBilgisi OR KarsiTarafTelefonNo = @KarsiTarafBilgisi OR KarsiTarafAdres = @KarsiTarafBilgisi OR KarsiTarafTipi = @KarsiTarafBilgisi OR KarsiTarafSecimi = @KarsiTarafBilgisi", baglanti);
            KarsiTarafBilgisiAra.Parameters.Add(KarsiTarafBilgisi);
            SqlDataAdapter da = new SqlDataAdapter(KarsiTarafBilgisiAra);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridViewKarsiTaraf.DataSource = dt;
        }

        private void dataGridViewKarsiTaraf_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FormKarsiTaraf_Load(object sender, EventArgs e)
        {
            KayitGetir();
        }

        private void buttonListele_Click(object sender, EventArgs e)
        {
            KayitGetir();
        }
    }
}

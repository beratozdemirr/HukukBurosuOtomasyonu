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
    public partial class FormKarsiTarafGuncelle : Form
    {
        public FormKarsiTarafGuncelle()
        {
            InitializeComponent();
        }

        public SqlConnection baglanti = new SqlConnection(@"Data Source = EMIRHAN\EMIRHANSQLSERVER; Initial Catalog = HukukBuroDB; User Id = System Admin; Password = !001994gs; ");

        FormKarsiTarafGuncelleDoldur karsiTarafGuncDoldur = new FormKarsiTarafGuncelleDoldur();

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

        public void KayitYukle()
        {
            var value = dataGridViewKarsiTaraf.CurrentRow.Cells[9].Value.ToString();

            if (value == "KİŞİ")
            {
                karsiTarafGuncDoldur.Visible = true;
                karsiTarafGuncDoldur.groupBoxKisiselBilgilerKurulus.Visible = false;
                karsiTarafGuncDoldur.buttonKarsiTarafKisiGuncelle.Visible = true;
                karsiTarafGuncDoldur.buttonKarsiTarafKurulusGuncelle.Visible = false;

                karsiTarafGuncDoldur.textBoxKarsiTarafNo.Text = dataGridViewKarsiTaraf.CurrentRow.Cells[0].Value.ToString();
                karsiTarafGuncDoldur.textBoxKisi_Isim.Text = dataGridViewKarsiTaraf.CurrentRow.Cells[1].Value.ToString();
                karsiTarafGuncDoldur.textBoxKisiTCNo.Text = dataGridViewKarsiTaraf.CurrentRow.Cells[2].Value.ToString();
                karsiTarafGuncDoldur.textBoxKurulusVergiNo.Text = dataGridViewKarsiTaraf.CurrentRow.Cells[3].Value.ToString();
                karsiTarafGuncDoldur.textBoxKisiSicilNo.Text = dataGridViewKarsiTaraf.CurrentRow.Cells[4].Value.ToString();
                karsiTarafGuncDoldur.comboBoxKisiCinsiyet.Text = dataGridViewKarsiTaraf.CurrentRow.Cells[5].Value.ToString();
                karsiTarafGuncDoldur.textBoxKarsiTarafTelefonNo.Text = dataGridViewKarsiTaraf.CurrentRow.Cells[6].Value.ToString();
                karsiTarafGuncDoldur.textBoxKarsiTarafAdres.Text = dataGridViewKarsiTaraf.CurrentRow.Cells[7].Value.ToString();
                karsiTarafGuncDoldur.comboBoxKarsiTarafTipi.Text = dataGridViewKarsiTaraf.CurrentRow.Cells[8].Value.ToString();
                karsiTarafGuncDoldur.textBoxKarsiTarafSecimi.Text = dataGridViewKarsiTaraf.CurrentRow.Cells[9].Value.ToString();
            }

            else if (value == "KURULUŞ")
            {
                karsiTarafGuncDoldur.groupBoxKisiselBilgilerKurulus.Visible = true;
                karsiTarafGuncDoldur.groupBoxKisiselBilgilerKisi.Visible = false;
                karsiTarafGuncDoldur.buttonKarsiTarafKurulusGuncelle.Visible = true;
                karsiTarafGuncDoldur.buttonKarsiTarafKisiGuncelle.Visible = false;

                karsiTarafGuncDoldur.textBoxKarsiTarafNo.Text = dataGridViewKarsiTaraf.CurrentRow.Cells[0].Value.ToString();
                karsiTarafGuncDoldur.textBoxKurulus_Isim.Text = dataGridViewKarsiTaraf.CurrentRow.Cells[1].Value.ToString();
                karsiTarafGuncDoldur.textBoxKisiTCNo.Text = dataGridViewKarsiTaraf.CurrentRow.Cells[2].Value.ToString();
                karsiTarafGuncDoldur.textBoxKurulusVergiNo.Text = dataGridViewKarsiTaraf.CurrentRow.Cells[3].Value.ToString();
                karsiTarafGuncDoldur.textBoxKisiSicilNo.Text = dataGridViewKarsiTaraf.CurrentRow.Cells[4].Value.ToString();
                karsiTarafGuncDoldur.comboBoxKisiCinsiyet.Text = dataGridViewKarsiTaraf.CurrentRow.Cells[5].Value.ToString();
                karsiTarafGuncDoldur.textBoxKarsiTarafTelefonNo.Text = dataGridViewKarsiTaraf.CurrentRow.Cells[6].Value.ToString();
                karsiTarafGuncDoldur.textBoxKarsiTarafAdres.Text = dataGridViewKarsiTaraf.CurrentRow.Cells[7].Value.ToString();
                karsiTarafGuncDoldur.comboBoxKarsiTarafTipi.Text = dataGridViewKarsiTaraf.CurrentRow.Cells[8].Value.ToString();
                karsiTarafGuncDoldur.textBoxKarsiTarafSecimi.Text = dataGridViewKarsiTaraf.CurrentRow.Cells[9].Value.ToString();
            }
        }

        private void FormKarsiTarafGuncelle_Load(object sender, EventArgs e)
        {
            KayitGetir();
        }

        private void buttonGuncelle_Click(object sender, EventArgs e)
        {
            KayitYukle();
            karsiTarafGuncDoldur.Show();
        }

        private void buttonListele_Click(object sender, EventArgs e)
        {
            KayitGetir();
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

        private void buttonKarsiTarafTipiAra_Click(object sender, EventArgs e)
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
    }
}

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
using HukukBuroOtomasyonu.Muvekkiller;

namespace HukukBuroOtomasyonu.Muvekkiller
{
    public partial class FormMuvekkiller : Form
    {
        public FormMuvekkiller()
        {
            InitializeComponent();
        }

        public SqlConnection baglanti = new SqlConnection(@"Data Source = EMIRHAN\EMIRHANSQLSERVER; Initial Catalog = HukukBuroDB; User Id = System Admin; Password = !001994gs; ");

        
        
        
        
        //formBuroOtomasyonu acilisaDon = new formBuroOtomasyonu();

        public void KayitGetir()
        {
            if (baglanti.State == ConnectionState.Closed) baglanti.Open();
            string listeleMuvekkil = "SELECT * FROM Muvekkil";
            SqlCommand komutListele = new SqlCommand(listeleMuvekkil, baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komutListele);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridViewMuvekkiller.DataSource = dt;
        }

        private void buttonMuvekkilEkle_Click(object sender, EventArgs e)
        {
            FormMuvekkilEkle muvEkle = new FormMuvekkilEkle();
            muvEkle.ShowDialog();
        }

        private void buttonMuvekkilSil_Click(object sender, EventArgs e)
        {
            FormMuvekkilSil muvSil = new FormMuvekkilSil();
            muvSil.ShowDialog();
        }

        private void buttonMuvekkilGuncelle_Click(object sender, EventArgs e)
        {
            FormMuvekkilGuncelle muvGunc = new FormMuvekkilGuncelle();
            muvGunc.ShowDialog();
        }

        private void buttonMuvekkilRaporuOlustur_Click(object sender, EventArgs e)
        {
            FormMuvekkilRaporOlustur muvRapor = new FormMuvekkilRaporOlustur();
            muvRapor.ShowDialog();
        }

        private void buttonAnaEkran_Click(object sender, EventArgs e)
        {
            formBuroOtomasyonu acilisaDon = new formBuroOtomasyonu();
            this.Hide();
            acilisaDon.Show();
        }

        private void buttonMuvekkilAra_Click(object sender, EventArgs e)
        {
            if (baglanti.State == ConnectionState.Closed) baglanti.Open();
            SqlParameter MuvekkilBilgisi = new SqlParameter("@MuvekkilBilgisi", textBoxMuvekkilBilgisiAra.Text);
            SqlCommand MuvekkilBilgisiAra = new SqlCommand("SELECT * FROM Muvekkil WHERE Muvekkil_Isim = @MuvekkilBilgisi OR MuvekkilTCNo = @MuvekkilBilgisi OR MuvekkilVergiNo = @MuvekkilBilgisi OR MuvekkilSicilNo = @MuvekkilBilgisi OR MuvekkilCinsiyet = @MuvekkilBilgisi OR MuvekkilTelefonNo = @MuvekkilBilgisi OR MuvekkilTipi = @MuvekkilBilgisi OR MuvekkilSecimi = @MuvekkilBilgisi", baglanti);
            MuvekkilBilgisiAra.Parameters.Add(MuvekkilBilgisi);
            SqlDataAdapter da = new SqlDataAdapter(MuvekkilBilgisiAra);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridViewMuvekkiller.DataSource = dt;
        }

        private void FormMuvekkiller_Load(object sender, EventArgs e)
        {
            KayitGetir();
        }

        private void buttonListele_Click(object sender, EventArgs e)
        {
            KayitGetir();
        }
    }
}

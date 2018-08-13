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
using HukukBuroOtomasyonu.DavaGelismesi;
using HukukBuroOtomasyonu.DavaSonucu;

namespace HukukBuroOtomasyonu.Davalar
{
    public partial class FormDavalar : Form
    {
        public FormDavalar()
        {
            InitializeComponent();
        }

        public SqlConnection baglanti = new SqlConnection(@"Data Source = EMIRHAN\EMIRHANSQLSERVER; Initial Catalog = HukukBuroDB; User Id = System Admin; Password = !001994gs; ");

        public void KayitGetir()
        {
            if (baglanti.State == ConnectionState.Closed) baglanti.Open();
            string listeleDava = "SELECT * FROM Dava";
            SqlCommand komutListele = new SqlCommand(listeleDava, baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komutListele);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridViewDavalar.DataSource = dt;
        }

        private void FormDavalar_Load(object sender, EventArgs e)
        {
            KayitGetir();
        }

        private void buttonDavaEkle_Click(object sender, EventArgs e)
        {
            FormDavaEkle davaEkle = new FormDavaEkle();
            davaEkle.ShowDialog();
        }

        private void buttonDavaSil_Click(object sender, EventArgs e)
        {
            FormDavaSil davaSil = new FormDavaSil();
            davaSil.ShowDialog();
        }

        private void buttonDavaGuncelle_Click(object sender, EventArgs e)
        {
            FormDavaGuncelle davaGunc = new FormDavaGuncelle();
            davaGunc.ShowDialog();
        }

        private void buttonDavaRaporuOlustur_Click(object sender, EventArgs e)
        {
            FormDavaRaporOlustur davaRapor = new FormDavaRaporOlustur();
            davaRapor.ShowDialog();
        }

        private void buttonDavaGelismesi_Click(object sender, EventArgs e)
        {
            FormDavaGelismeleri davaGelismeleri = new FormDavaGelismeleri();
            this.Hide();
            davaGelismeleri.Show();
        }

        private void buttonDavaSonucu_Click(object sender, EventArgs e)
        {
            FormDavaSonuclari davaSonuclari = new FormDavaSonuclari();
            this.Hide();
            davaSonuclari.Show();
        }

        private void buttonAnaEkranaDön_Click(object sender, EventArgs e)
        {
            formBuroOtomasyonu acilisaDon = new formBuroOtomasyonu();
            this.Hide();
            acilisaDon.Show();
        }

        private void buttonDavaAra_Click(object sender, EventArgs e)
        {
            if (baglanti.State == ConnectionState.Closed) baglanti.Open();
            SqlParameter DavaNo = new SqlParameter("@DavaNo", textBoxDavaBilgisiAra.Text);
            SqlCommand DavaNoAra = new SqlCommand("SELECT * FROM Dava WHERE DavaNo = @DavaNo", baglanti);
            DavaNoAra.Parameters.Add(DavaNo);
            SqlDataAdapter da = new SqlDataAdapter(DavaNoAra);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridViewDavalar.DataSource = dt;
        }

        private void buttonListele_Click(object sender, EventArgs e)
        {
            KayitGetir();
        }
    }
}

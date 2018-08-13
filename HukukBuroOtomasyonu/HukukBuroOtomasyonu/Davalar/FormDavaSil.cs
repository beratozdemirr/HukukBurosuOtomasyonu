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

namespace HukukBuroOtomasyonu.Davalar
{
    public partial class FormDavaSil : Form
    {
        public FormDavaSil()
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

        public void MuvekilleriGetir()
        {
            if (baglanti.State == ConnectionState.Closed) baglanti.Open();
            SqlCommand muvekkilYukle = new SqlCommand("SELECT Muvekkil_Isim FROM Muvekkil", baglanti);
            SqlDataReader okuMuvekkilAdi;
            okuMuvekkilAdi = muvekkilYukle.ExecuteReader();
            while (okuMuvekkilAdi.Read())
            {
                comboBoxMuvekkil_IsimARA.Items.Add(okuMuvekkilAdi["Muvekkil_Isim"]);
            }
            baglanti.Close();
        }

        public void AdliyeleriGetir()
        {
            if (baglanti.State == ConnectionState.Closed) baglanti.Open();
            SqlCommand AdliyeAdiYukle = new SqlCommand("SELECT AdliyeAdi FROM Adliye", baglanti);
            SqlDataReader okuAdliyeAdi;
            okuAdliyeAdi = AdliyeAdiYukle.ExecuteReader();
            while (okuAdliyeAdi.Read())
            {
                comboBoxAdliyeBinasiARA.Items.Add(okuAdliyeAdi["AdliyeAdi"]);
            }
            baglanti.Close();
        }

        private void comboBoxAdliyeBinasi_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FormDavaSil_Load(object sender, EventArgs e)
        {
            KayitGetir();
            MuvekilleriGetir();
            AdliyeleriGetir();
        }

        private void buttonMuvekkilAra_Click(object sender, EventArgs e)
        {
            if (baglanti.State == ConnectionState.Closed) baglanti.Open();
            SqlParameter Muvekkil_Isim = new SqlParameter("@Muvekkil_Isim", comboBoxMuvekkil_IsimARA.Text);
            SqlCommand MuvekkilAdinaGoreDavaARA = new SqlCommand("SELECT * FROM Dava WHERE Muvekkil_ID IN(SELECT Muvekkil_ID FROM Muvekkil WHERE Muvekkil_Isim = @Muvekkil_Isim)", baglanti);
            MuvekkilAdinaGoreDavaARA.Parameters.Add(Muvekkil_Isim);
            SqlDataAdapter da = new SqlDataAdapter(MuvekkilAdinaGoreDavaARA);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridViewDavalar.DataSource = dt;
            comboBoxMuvekkil_IsimARA.Items.Add("");
        }

        private void buttonDavaTuruAra_Click(object sender, EventArgs e)
        {
            if (baglanti.State == ConnectionState.Closed) baglanti.Open();
            SqlCommand spDavaTuruBul = new SqlCommand();
            spDavaTuruBul.Connection = baglanti;
            spDavaTuruBul.CommandType = CommandType.StoredProcedure;
            spDavaTuruBul.CommandText = "spDavaTuruBul";
            spDavaTuruBul.Parameters.AddWithValue("@DavaTuru", comboBoxDavaTuruARA.Text);
            spDavaTuruBul.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter(spDavaTuruBul);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridViewDavalar.DataSource = dt;
        }

        private void buttonAdliyeBinasiAra_Click(object sender, EventArgs e)
        {
            if (baglanti.State == ConnectionState.Closed) baglanti.Open();
            SqlParameter AdliyeAdi = new SqlParameter("@AdliyeAdi", comboBoxAdliyeBinasiARA.Text);
            SqlCommand AdliyeAdinaGoreDavaARA = new SqlCommand("SELECT * FROM Dava WHERE Adliye_ID IN (SELECT Adliye_ID FROM Adliye WHERE AdliyeAdi = @AdliyeAdi)", baglanti);
            AdliyeAdinaGoreDavaARA.Parameters.Add(AdliyeAdi);
            SqlDataAdapter da = new SqlDataAdapter(AdliyeAdinaGoreDavaARA);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridViewDavalar.DataSource = dt;
            comboBoxAdliyeBinasiARA.Items.Add("");
        }

        private void buttonListele_Click(object sender, EventArgs e)
        {
            KayitGetir();
        }

        private void buttonSil_Click(object sender, EventArgs e)
        {
            if (baglanti.State == ConnectionState.Closed) baglanti.Open();
            SqlCommand spDavaSil = new SqlCommand();
            spDavaSil.Connection = baglanti;
            spDavaSil.CommandType = CommandType.StoredProcedure;
            spDavaSil.CommandText = "spDavaSil";
            spDavaSil.Parameters.Add("@Dava_ID", dataGridViewDavalar.CurrentRow.Cells[0].Value.ToString());
            spDavaSil.ExecuteNonQuery();
            MessageBox.Show("Dava Bilgileri Silindi");
            KayitGetir();
        }
    }
}

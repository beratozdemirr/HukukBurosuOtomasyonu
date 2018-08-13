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
    public partial class FormDavaGuncelle : Form
    {
        public FormDavaGuncelle()
        {
            InitializeComponent();
        }

        public SqlConnection baglanti = new SqlConnection(@"Data Source = EMIRHAN\EMIRHANSQLSERVER; Initial Catalog = HukukBuroDB; User Id = System Admin; Password = !001994gs; ");

        FormDavaGuncelleDoldur davaGuncDoldur = new FormDavaGuncelleDoldur();

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

        private void buttonListele_Click(object sender, EventArgs e)
        {
            KayitGetir();
        }

        private void FormDavaGuncelle_Load(object sender, EventArgs e)
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

        public void Muvekkil_IsmiGetir()
        {
            if (baglanti.State == ConnectionState.Closed) baglanti.Open();
            SqlCommand Muvekkil_IsmiGetir = new SqlCommand("SELECT Muvekkil_Isim FROM Muvekkil WHERE Muvekkil_ID IN(SELECT Muvekkil_ID FROM Muvekkil WHERE Muvekkil_ID = @Muvekkil_ID)");
            Muvekkil_IsmiGetir.Parameters.AddWithValue("@Muvekkil_ID", davaGuncDoldur.textBoxMuvekkil_ID.Text);
            Muvekkil_IsmiGetir.Connection = baglanti;
            SqlDataReader Muvekkil_Isim;
            Muvekkil_Isim = Muvekkil_IsmiGetir.ExecuteReader();
            while (Muvekkil_Isim.Read())
            {
                davaGuncDoldur.comboBoxMuvekkil_Isim.Text  = Convert.ToString(Muvekkil_Isim["Muvekkil_Isim"]);
            }
            baglanti.Close();
        }

        public void KarsiTaraf_IsmiGetir()
        {
            if (baglanti.State == ConnectionState.Closed) baglanti.Open();
            SqlCommand KarsiTaraf_IsmiGetir = new SqlCommand("SELECT KarsiTaraf_Isim FROM KarsiTaraf WHERE KarsiTaraf_ID IN(SELECT KarsiTaraf_ID FROM KarsiTaraf WHERE KarsiTaraf_ID = @KarsiTaraf_ID)");
            KarsiTaraf_IsmiGetir.Parameters.AddWithValue("@KarsiTaraf_ID", davaGuncDoldur.textBoxKarsiTaraf_ID.Text);
            KarsiTaraf_IsmiGetir.Connection = baglanti;
            SqlDataReader KarsiTaraf_Isim;
            KarsiTaraf_Isim = KarsiTaraf_IsmiGetir.ExecuteReader();
            while (KarsiTaraf_Isim.Read())
            {
                davaGuncDoldur.comboBoxKarsiTaraf_Isim.Text = Convert.ToString(KarsiTaraf_Isim["KarsiTaraf_Isim"]);
            }
            baglanti.Close();
        }

        public void AdliyeBinasiniGetir()
        {
            if (baglanti.State == ConnectionState.Closed) baglanti.Open();
            SqlCommand AdliyeBinasiniGetir = new SqlCommand("SELECT AdliyeAdi FROM Adliye WHERE Adliye_ID IN(SELECT Adliye_ID FROM Adliye WHERE Adliye_ID = @Adliye_ID)");
            AdliyeBinasiniGetir.Parameters.AddWithValue("@Adliye_ID", davaGuncDoldur.textBoxAdliye_ID.Text);
            AdliyeBinasiniGetir.Connection = baglanti;
            SqlDataReader AdliyeAdi;
            AdliyeAdi = AdliyeBinasiniGetir.ExecuteReader();
            while (AdliyeAdi.Read())
            {
                davaGuncDoldur.comboBoxAdliyeBinasi.Text = Convert.ToString(AdliyeAdi["AdliyeAdi"]);
            }
            baglanti.Close();
        }

        public void KayitYukle()
        {
            davaGuncDoldur.textBoxDavaID.Text = dataGridViewDavalar.CurrentRow.Cells[0].Value.ToString();
            davaGuncDoldur.textBoxMuvekkil_ID.Text = dataGridViewDavalar.CurrentRow.Cells[1].Value.ToString();
            davaGuncDoldur.textBoxKarsiTaraf_ID.Text = dataGridViewDavalar.CurrentRow.Cells[2].Value.ToString();
            davaGuncDoldur.textBoxPersonel_ID.Text = dataGridViewDavalar.CurrentRow.Cells[3].Value.ToString();
            davaGuncDoldur.textBoxAdliye_ID.Text = dataGridViewDavalar.CurrentRow.Cells[4].Value.ToString();
            davaGuncDoldur.textBoxDavaNo.Text = dataGridViewDavalar.CurrentRow.Cells[5].Value.ToString();
            davaGuncDoldur.dateTimePickerDavaAcilisTarihi.Text = dataGridViewDavalar.CurrentRow.Cells[6].Value.ToString();
            davaGuncDoldur.comboBoxDavaTuru.Text = dataGridViewDavalar.CurrentRow.Cells[7].Value.ToString();
            davaGuncDoldur.textBoxMuvekkilTalebi.Text = dataGridViewDavalar.CurrentRow.Cells[8].Value.ToString();
            davaGuncDoldur.textBoxDavaTutari.Text = dataGridViewDavalar.CurrentRow.Cells[9].Value.ToString();
            davaGuncDoldur.textBoxSalonNo.Text = dataGridViewDavalar.CurrentRow.Cells[10].Value.ToString();
            davaGuncDoldur.dateTimePickerGelecekOturumTarihi.Text = dataGridViewDavalar.CurrentRow.Cells[12].Value.ToString();
            davaGuncDoldur.textBoxOturumSaati.Text = dataGridViewDavalar.CurrentRow.Cells[13].Value.ToString();
        }

        private void buttonGuncelle_Click(object sender, EventArgs e)
        {
            KayitYukle();
            Muvekkil_IsmiGetir();
            KarsiTaraf_IsmiGetir();
            AdliyeBinasiniGetir();
            davaGuncDoldur.ShowDialog();
        }
    }
}

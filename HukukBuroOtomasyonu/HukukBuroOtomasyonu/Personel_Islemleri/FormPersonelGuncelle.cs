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

namespace HukukBuroOtomasyonu.Personel_Islemleri
{
    public partial class FormPersonelGuncelle : Form
    {
        public FormPersonelGuncelle()
        {
            InitializeComponent();
        }

        public SqlConnection baglanti = new SqlConnection(@"Data Source = EMIRHAN\EMIRHANSQLSERVER; Initial Catalog = HukukBuroDB; User Id = System Admin; Password = !001994gs; ");
        
        FormPersonelGuncelleDoldur perGuncDoldur = new FormPersonelGuncelleDoldur();

        public void KayitGetir()
        {
            if (baglanti.State == ConnectionState.Closed) baglanti.Open();
            string listelePersonel = "SELECT * FROM Personel";
            SqlCommand komutListele = new SqlCommand(listelePersonel, baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komutListele);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridViewPersoneller.DataSource = dt;
        }

        public void PersonelleriGetir()
        {
            if (baglanti.State == ConnectionState.Closed) baglanti.Open();
            SqlCommand personelYukle = new SqlCommand("SELECT PersonelAdiSoyadi FROM Personel", baglanti);
            SqlDataReader okuPersonelAdi;
            okuPersonelAdi = personelYukle.ExecuteReader();
            while (okuPersonelAdi.Read())
            {
                comboBoxPersonel.Items.Add(okuPersonelAdi["PersonelAdiSoyadi"]);
            }
            baglanti.Close();
        }

        public void KayitYukle()
        {
            perGuncDoldur.checkBox_isVeriOku.Checked = false;
            perGuncDoldur.checkBox_isVeriGir.Checked = false;
            perGuncDoldur.checkBox_isVeriGuncelle.Checked = false;
            perGuncDoldur.checkBox_isVeriSil.Checked = false;
            perGuncDoldur.checkBox_isRaporOlustur.Checked = false;
            perGuncDoldur.checkBox_isKullanici_Islemleri.Checked = false;

            perGuncDoldur.textBoxPersonelNo.Text = dataGridViewPersoneller.CurrentRow.Cells[0].Value.ToString();
            perGuncDoldur.textBoxPersonelAdSoyad.Text = dataGridViewPersoneller.CurrentRow.Cells[1].Value.ToString();
            perGuncDoldur.textBoxPersonelKullaniciAdi.Text = dataGridViewPersoneller.CurrentRow.Cells[2].Value.ToString();
            perGuncDoldur.textBoxPersonelSifre.Text = dataGridViewPersoneller.CurrentRow.Cells[3].Value.ToString();
            perGuncDoldur.comboBoxPersonelYetkisi.Text = dataGridViewPersoneller.CurrentRow.Cells[4].Value.ToString();

            if (Convert.ToBoolean(dataGridViewPersoneller.CurrentRow.Cells[5].Value) == true) perGuncDoldur.checkBox_isVeriOku.Checked = true;
            if (Convert.ToBoolean(dataGridViewPersoneller.CurrentRow.Cells[6].Value) == true) perGuncDoldur.checkBox_isVeriGir.Checked = true;
            if (Convert.ToBoolean(dataGridViewPersoneller.CurrentRow.Cells[7].Value) == true) perGuncDoldur.checkBox_isVeriGuncelle.Checked = true;
            if (Convert.ToBoolean(dataGridViewPersoneller.CurrentRow.Cells[8].Value) == true) perGuncDoldur.checkBox_isVeriSil.Checked = true;
            if (Convert.ToBoolean(dataGridViewPersoneller.CurrentRow.Cells[9].Value) == true) perGuncDoldur.checkBox_isRaporOlustur.Checked = true;
            if (Convert.ToBoolean(dataGridViewPersoneller.CurrentRow.Cells[10].Value) == true) perGuncDoldur.checkBox_isKullanici_Islemleri.Checked = true;

        }

        private void FormPersonelGuncelle_Load(object sender, EventArgs e)
        {
            KayitGetir();
            PersonelleriGetir();
        }

        private void buttonGuncelle_Click(object sender, EventArgs e)
        {
            KayitYukle();
            perGuncDoldur.ShowDialog();
        }

        private void buttonListele_Click(object sender, EventArgs e)
        {
            KayitGetir();
        }

        private void buttonPersonelAdiAra_Click(object sender, EventArgs e)
        {
            if (baglanti.State == ConnectionState.Closed) baglanti.Open();
            SqlCommand spPersonelBul = new SqlCommand();
            spPersonelBul.Connection = baglanti;
            spPersonelBul.CommandType = CommandType.StoredProcedure;
            spPersonelBul.CommandText = "spPersonelBul";
            spPersonelBul.Parameters.AddWithValue("@PersonelAdiSoyadi", comboBoxPersonel.Text);
            spPersonelBul.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter(spPersonelBul);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridViewPersoneller.DataSource = dt;
        }
    }
}

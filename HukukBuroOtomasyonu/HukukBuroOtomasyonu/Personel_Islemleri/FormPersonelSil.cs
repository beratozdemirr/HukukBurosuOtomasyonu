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
    public partial class FormPersonelSil : Form
    {
        public FormPersonelSil()
        {
            InitializeComponent();
        }

        public SqlConnection baglanti = new SqlConnection(@"Data Source = EMIRHAN\EMIRHANSQLSERVER; Initial Catalog = HukukBuroDB; User Id = System Admin; Password = !001994gs; ");

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

        private void FormPersonelSil_Load(object sender, EventArgs e)
        {
            KayitGetir();
            PersonelleriGetir();
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

        private void buttonSil_Click(object sender, EventArgs e)
        {
            if (baglanti.State == ConnectionState.Closed) baglanti.Open();
            SqlCommand spPersonelSil = new SqlCommand();
            spPersonelSil.Connection = baglanti;
            spPersonelSil.CommandType = CommandType.StoredProcedure;
            spPersonelSil.CommandText = "spPersonelSil";
            spPersonelSil.Parameters.Add("@Personel_ID", dataGridViewPersoneller.CurrentRow.Cells[0].Value.ToString());
            spPersonelSil.ExecuteNonQuery();
            MessageBox.Show("Personel Bilgileri Silindi");
            KayitGetir();
        }
    }
}

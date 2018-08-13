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
    public partial class FormDavaGelismesiGuncelleDoldur : Form
    {
        public FormDavaGelismesiGuncelleDoldur()
        {
            InitializeComponent();
        }

        public SqlConnection baglanti = new SqlConnection(@"Data Source = EMIRHAN\EMIRHANSQLSERVER; Initial Catalog = HukukBuroDB; User Id = System Admin; Password = !001994gs; ");

        private void buttonGuncelle_Click(object sender, EventArgs e)
        {
            if (baglanti.State == ConnectionState.Closed) baglanti.Open();
            SqlCommand spDavaGelismesiGuncelle = new SqlCommand();
            spDavaGelismesiGuncelle.Connection = baglanti;
            spDavaGelismesiGuncelle.CommandType = CommandType.StoredProcedure;
            spDavaGelismesiGuncelle.CommandText = "spDavaGelismesiGuncelle";
            spDavaGelismesiGuncelle.Parameters.AddWithValue("@Gelisme_ID", textBoxGelismeNo.Text);
            spDavaGelismesiGuncelle.Parameters.AddWithValue("@Muvekkil_ID", textBoxMuvekkilNo.Text);
            spDavaGelismesiGuncelle.Parameters.AddWithValue("@Dava_ID", textBoxDavaNo.Text);
            spDavaGelismesiGuncelle.Parameters.AddWithValue("@GelismeAciklamasi", textBoxGelismeAciklamasi.Text);
            spDavaGelismesiGuncelle.Parameters.AddWithValue("@GelismeTarihi", dateTimePickerGelismeTarihi.Value);
            spDavaGelismesiGuncelle.Parameters.AddWithValue("@DavaDurumu", comboBoxDavaDurumu.Text);
            spDavaGelismesiGuncelle.ExecuteNonQuery();

            MessageBox.Show("Gelişme Bilgileri Güncellendi");
            this.Hide();
        }
    }
}

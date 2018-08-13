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

namespace HukukBuroOtomasyonu.Adliye
{
    public partial class FormAdliyeGuncelleDoldur : Form
    {
        public FormAdliyeGuncelleDoldur()
        {
            InitializeComponent();
        }

        public SqlConnection baglanti = new SqlConnection(@"Data Source = EMIRHAN\EMIRHANSQLSERVER; Initial Catalog = HukukBuroDB; User Id = System Admin; Password = !001994gs; ");

        private void buttonGuncelle_Click(object sender, EventArgs e)
        {
            if (baglanti.State == ConnectionState.Closed) baglanti.Open();
            SqlCommand spAdliyeGuncelle = new SqlCommand();
            spAdliyeGuncelle.Connection = baglanti;
            spAdliyeGuncelle.CommandType = CommandType.StoredProcedure;
            spAdliyeGuncelle.CommandText = "spAdliyeGuncelle";
            spAdliyeGuncelle.Parameters.AddWithValue("@Adliye_ID", textBoxAdliyeNo.Text);
            spAdliyeGuncelle.Parameters.AddWithValue("@AdliyeAdi", textBoxAdliyeAdi.Text);
            spAdliyeGuncelle.Parameters.AddWithValue("@AdliyeTelefonNo", textBoxAdliyeTelNo.Text);
            spAdliyeGuncelle.Parameters.AddWithValue("@AdliyeAdres", textBoxAdliyeAdres.Text);
            spAdliyeGuncelle.ExecuteNonQuery();

            MessageBox.Show("Müvekkil-Kişi Bilgileri Güncellendi");
            this.Hide();
        }
    }
}

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

namespace HukukBuroOtomasyonu.DavaSonucu
{
    public partial class FormDavaSonucuGuncelleDoldur : Form
    {
        public FormDavaSonucuGuncelleDoldur()
        {
            InitializeComponent();
        }

        public SqlConnection baglanti = new SqlConnection(@"Data Source = EMIRHAN\EMIRHANSQLSERVER; Initial Catalog = HukukBuroDB; User Id = System Admin; Password = !001994gs; ");

        private void buttonGuncelle_Click(object sender, EventArgs e)
        {
            if (baglanti.State == ConnectionState.Closed) baglanti.Open();
            SqlCommand spDavaSonucuGuncelle = new SqlCommand();
            spDavaSonucuGuncelle.Connection = baglanti;
            spDavaSonucuGuncelle.CommandType = CommandType.StoredProcedure;
            spDavaSonucuGuncelle.CommandText = "spDavaSonucuGuncelle";
            spDavaSonucuGuncelle.Parameters.AddWithValue("@DavaSonuc_ID", textBoxDavaSonuc_ID.Text);
            spDavaSonucuGuncelle.Parameters.AddWithValue("@Muvekkil_ID", textBoxMuvekkil_ID.Text);
            spDavaSonucuGuncelle.Parameters.AddWithValue("@KarsiTaraf_ID", textBoxKarsiTaraf_ID.Text);
            spDavaSonucuGuncelle.Parameters.AddWithValue("@DavaBitisTarihi", dateTimePickerSonucTarihi.Value);
            spDavaSonucuGuncelle.Parameters.AddWithValue("@DavaSonucu", comboBoxDavaSonucu.Text);
            spDavaSonucuGuncelle.ExecuteNonQuery();

            MessageBox.Show("Dava Sonuç Bilgileri Güncellendi");
            this.Hide();
        }
    }
}

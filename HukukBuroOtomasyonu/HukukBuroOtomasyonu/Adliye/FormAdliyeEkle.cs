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
    public partial class FormAdliyeEkle : Form
    {
        public FormAdliyeEkle()
        {
            InitializeComponent();
        }

        public SqlConnection baglanti = new SqlConnection(@"Data Source = EMIRHAN\EMIRHANSQLSERVER; Initial Catalog = HukukBuroDB; User Id = System Admin; Password = !001994gs; ");

        private void buttonKaydet_Click(object sender, EventArgs e)
        {
            if (baglanti.State == ConnectionState.Closed) baglanti.Open();
            SqlCommand spAdliyeEkle = new SqlCommand();
            spAdliyeEkle.Connection = baglanti;
            spAdliyeEkle.CommandType = CommandType.StoredProcedure;
            spAdliyeEkle.CommandText = "spAdliyeEkle";
            SqlParameter Adliye_ID = new SqlParameter("@Adliye_ID", SqlDbType.Int);
            Adliye_ID.Direction = ParameterDirection.Output;
            spAdliyeEkle.Parameters.Add(Adliye_ID);
            spAdliyeEkle.Parameters.AddWithValue("@AdliyeAdi", textBoxAdliyeAdi.Text);
            spAdliyeEkle.Parameters.AddWithValue("@AdliyeTelefonNo", textBoxAdliyeTelNo.Text);
            spAdliyeEkle.Parameters.AddWithValue("@AdliyeAdres", textBoxAdliyeAdres.Text);
            spAdliyeEkle.ExecuteNonQuery();
            MessageBox.Show("Adliye Eklendi.");

            textBoxAdliyeAdi.Clear();
            textBoxAdliyeTelNo.Clear();
            textBoxAdliyeAdres.Clear();
        }
    }
}

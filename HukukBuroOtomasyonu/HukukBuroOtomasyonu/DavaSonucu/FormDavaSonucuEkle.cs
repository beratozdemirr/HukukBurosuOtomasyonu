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
    public partial class FormDavaSonucuEkle : Form
    {
        public FormDavaSonucuEkle()
        {
            InitializeComponent();
        }

        public SqlConnection baglanti = new SqlConnection(@"Data Source = EMIRHAN\EMIRHANSQLSERVER; Initial Catalog = HukukBuroDB; User Id = System Admin; Password = !001994gs; ");

        public void MuvekilleriGetir()
        {
            if (baglanti.State == ConnectionState.Closed) baglanti.Open();
            SqlCommand muvekkilYukle = new SqlCommand("SELECT Muvekkil_Isim FROM Muvekkil", baglanti);
            SqlDataReader okuMuvekkilAdi;
            okuMuvekkilAdi = muvekkilYukle.ExecuteReader();
            while (okuMuvekkilAdi.Read())
            {
                comboBoxMuvekkil_Isim.Items.Add(okuMuvekkilAdi["Muvekkil_Isim"]);
            }
            baglanti.Close();
        }

        public void KarsiTarafNoGetir()
        {
            if (baglanti.State == ConnectionState.Closed) baglanti.Open();
            SqlCommand KarsiTaraf_IDYukle = new SqlCommand("SELECT KarsiTaraf_ID FROM KarsiTaraf WHERE KarsiTaraf_ID IN(SELECT KarsiTaraf_ID FROM Dava WHERE Muvekkil_ID IN(SELECT Muvekkil_ID FROM Muvekkil WHERE Muvekkil_Isim = @Muvekkil_Isim))", baglanti);
            KarsiTaraf_IDYukle.Parameters.AddWithValue("Muvekkil_Isim", comboBoxMuvekkil_Isim.Text);
            SqlDataReader okuKarsiTaraf_ID;
            okuKarsiTaraf_ID = KarsiTaraf_IDYukle.ExecuteReader();
            while (okuKarsiTaraf_ID.Read())
            {
                comboBoxKarsiTarafSec.Items.Add(okuKarsiTaraf_ID["KarsiTaraf_ID"]);
            }
            baglanti.Close();
        }


        public void Muvekkil_IDGetir()
        {
            try
            {
                if (baglanti.State == ConnectionState.Closed) baglanti.Open();
                SqlCommand Muv_IDGetir = new SqlCommand("SELECT Muvekkil_ID FROM Muvekkil WHERE Muvekkil_Isim = @Muvekkil_Isim");
                Muv_IDGetir.Parameters.AddWithValue("@Muvekkil_Isim", comboBoxMuvekkil_Isim.Text);
                Muv_IDGetir.Connection = baglanti;
                Int32 Muvekkil_ID = (Int32)Muv_IDGetir.ExecuteScalar();
                textBoxMuvekkil_ID.Text = Muvekkil_ID.ToString();
                baglanti.Close();
            }
            catch
            {
                MessageBox.Show("Müvekkil Bilgisi Bulunamadı.");
            }

        }
        
       public void KarsiTaraf_IDGetir()
        {
            try
            {
                if (baglanti.State == ConnectionState.Closed) baglanti.Open();
                SqlCommand KarsiTaraf_IDGetir = new SqlCommand("SELECT KarsiTaraf_ID FROM KarsiTaraf WHERE KarsiTaraf_ID IN(SELECT KarsiTaraf_ID FROM Dava WHERE Muvekkil_ID IN(SELECT Muvekkil_ID FROM Muvekkil WHERE Muvekkil_Isim = @Muvekkil_Isim))");
                KarsiTaraf_IDGetir.Parameters.AddWithValue("@Muvekkil_Isim", comboBoxMuvekkil_Isim.Text);
                KarsiTaraf_IDGetir.Connection = baglanti;
                Int32 KarsiTaraf_ID = (Int32)KarsiTaraf_IDGetir.ExecuteScalar();
                textBoxKarsiTaraf_ID.Text = KarsiTaraf_ID.ToString();
                baglanti.Close();
            }
            catch
            {
                MessageBox.Show("Karşı Taraf Bilgisi Bulunamadı");
            }
            
        }


        private void FormDavaSonucuEkle_Load(object sender, EventArgs e)
        {
            MuvekilleriGetir();
        }

        private void checkBoxMuvekkilOnayla_CheckedChanged(object sender, EventArgs e)
        {
            Muvekkil_IDGetir();
            KarsiTarafNoGetir();
        }

        

        private void checkBoxKarsiTarafOnay_CheckedChanged(object sender, EventArgs e)
        {
            KarsiTaraf_IDGetir();
        }

        private void buttonKaydet_Click(object sender, EventArgs e)
        {
            if (baglanti.State == ConnectionState.Closed) baglanti.Open();
            SqlCommand spDavaSonucuEkle = new SqlCommand();
            spDavaSonucuEkle.Connection = baglanti;
            spDavaSonucuEkle.CommandType = CommandType.StoredProcedure;
            spDavaSonucuEkle.CommandText = "spDavaSonucuEkle";
            SqlParameter DavaSonuc_ID = new SqlParameter("@DavaSonuc_ID", SqlDbType.Int);
            DavaSonuc_ID.Direction = ParameterDirection.Output;
            spDavaSonucuEkle.Parameters.Add(DavaSonuc_ID);
            spDavaSonucuEkle.Parameters.AddWithValue("@Muvekkil_ID", textBoxMuvekkil_ID.Text);
            spDavaSonucuEkle.Parameters.AddWithValue("@KarsiTaraf_ID", textBoxKarsiTaraf_ID.Text);
            spDavaSonucuEkle.Parameters.AddWithValue("@DavaBitisTarihi", dateTimePickerSonucTarihi.Value);
            spDavaSonucuEkle.Parameters.AddWithValue("@DavaSonucu", comboBoxDavaSonucu.Text);
            spDavaSonucuEkle.ExecuteNonQuery();
            MessageBox.Show("Dava Sonucu Eklendi.");

            textBoxDavaIDGir.Clear();
            textBoxKarsiTaraf_ID.Clear();
            textBoxMuvekkil_ID.Clear();
            comboBoxDavaSonucu.Items.Add("");   
        }
    }
}

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
    public partial class FormAdliyeler : Form
    {
        public FormAdliyeler()
        {
            InitializeComponent();
        }

        public SqlConnection baglanti = new SqlConnection(@"Data Source = EMIRHAN\EMIRHANSQLSERVER; Initial Catalog = HukukBuroDB; User Id = System Admin; Password = !001994gs; ");



        //public void arayuzBicimlendir()
        //{
            //FormKullaniciBilgileri yetkiGetir = new FormKullaniciBilgileri();

            //if (yetkiGetir.checkBox_isVeriOku.Checked == true)  dataGridViewAdliyeler.Visible = false; 
            //if (yetkiGetir.checkBox_isVeriGir.Checked == true)  buttonAdliyeEkle.Visible = false; 
            //if (yetkiGetir.checkBox_isVeriGuncelle.Checked == true)  buttonAdliyeGuncelle.Visible = false; 
            //if (yetkiGetir.checkBox_isVeriSil.Checked == true)  buttonAdliyeSil.Visible = false; 
            //if (yetkiGetir.checkBox_isRaporOlustur.Checked == true)  buttonRaporOlustur.Visible = false; 

            //if (Convert.ToBoolean(yetkiGetir.dataGridViewKullaniciBilgileri.CurrentRow.Cells[5].Value) == false) dataGridViewAdliyeler.Visible = false;
            //if (Convert.ToBoolean(yetkiGetir.dataGridViewKullaniciBilgileri.CurrentRow.Cells[6].Value) == false) buttonAdliyeEkle.Visible = false;
            //if (Convert.ToBoolean(yetkiGetir.dataGridViewKullaniciBilgileri.CurrentRow.Cells[7].Value) == false) buttonAdliyeGuncelle.Visible = false;
            //if (Convert.ToBoolean(yetkiGetir.dataGridViewKullaniciBilgileri.CurrentRow.Cells[8].Value) == false) buttonAdliyeSil.Visible = false;
            //if (Convert.ToBoolean(yetkiGetir.dataGridViewKullaniciBilgileri.CurrentRow.Cells[9].Value) == false) buttonRaporOlustur.Visible = false;

        //}

        //public void kullaniciArayuzuOlustur()
        //{
        //    FormKullaniciBilgileri kullaniciBilgisiGetir = new FormKullaniciBilgileri();
        //    SqlCommand komutBilgiGetir = new SqlCommand();
        //    komutBilgiGetir.Connection = baglanti;
        //    komutBilgiGetir.CommandType = CommandType.Text;
        //    komutBilgiGetir.CommandText = "SELECT isVeriOku, isVeriGir, isVeriGuncelle, isVeriSil, isRaporOlustur , isKullaniciIslemleri FROM Personel WHERE PersonelKullaniciAdi = @PersonelKullaniciAdi AND PersonelSifre = @PersonelSifre";
        //    komutBilgiGetir.Parameters.AddWithValue("@PersonelKullaniciAdi", kullaniciBilgisiGetir.textBoxKullaniciAdi.Text);
        //    komutBilgiGetir.Parameters.AddWithValue("@PersonelSifre", kullaniciBilgisiGetir.textBoxKullaniciSifre.Text);
        //    komutBilgiGetir.Connection.Open();
        //    SqlDataReader okuBilgi = komutBilgiGetir.ExecuteReader(CommandBehavior.CloseConnection);

        //    if (okuBilgi.HasRows)
        //    {
        //        while (okuBilgi.Read())
        //        {
        //            if(okuBilgi["isVeriOku"].ToString() == "False")
        //            {
        //                dataGridViewAdliyeler.Visible = false;
        //            }

        //            if(okuBilgi["isVeriGir"].ToString() == "False")
        //            {
        //                buttonAdliyeEkle.Visible = false;
        //            }

        //            if (okuBilgi["isVeriGuncelle"].ToString() == "False")
        //            {
        //                buttonAdliyeGuncelle.Visible = false;
        //            }

        //            if (okuBilgi["isVeriSil"].ToString() == "False")
        //            {
        //                buttonAdliyeSil.Visible = false;
        //            }

        //            if (okuBilgi["isRaporOlustur"].ToString() == "False")
        //            {
        //                buttonRaporOlustur.Visible = false;
        //            }
        //        }
        //    }

        //    else
        //    {
        //        okuBilgi.Close();
        //    }

        //}




        public void KayitGetir()
        {
            if (baglanti.State == ConnectionState.Closed) baglanti.Open();
            string listeleAdliye = "SELECT * FROM Adliye";
            SqlCommand komutListele = new SqlCommand(listeleAdliye, baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komutListele);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridViewAdliyeler.DataSource = dt;
        }

        private void FormAdliyeler_Load(object sender, EventArgs e)
        {
            KayitGetir();
        }

        private void buttonAdliyeEkle_Click(object sender, EventArgs e)
        {
            FormAdliyeEkle adlEkle = new FormAdliyeEkle();
            adlEkle.ShowDialog();
        }

        private void buttonAdliyeSil_Click(object sender, EventArgs e)
        {
            FormAdliyeSil adlSil = new FormAdliyeSil();
            adlSil.ShowDialog();
        }

        private void buttonAdliyeGuncelle_Click(object sender, EventArgs e)
        {
            FormAdliyeGuncelle adlGunc = new FormAdliyeGuncelle();
            adlGunc.ShowDialog();
        }

        private void buttonRaporOlustur_Click(object sender, EventArgs e)
        {
            FormAdliyeRaporOlustur adlRapor = new FormAdliyeRaporOlustur();
            adlRapor.ShowDialog();
        }

        private void buttonAnaEkranaDon_Click(object sender, EventArgs e)
        {
            formBuroOtomasyonu acilisaDon = new formBuroOtomasyonu();
            this.Hide();
            acilisaDon.Show();
        }

        private void buttonAdliyeAra_Click(object sender, EventArgs e)
        {
            if (baglanti.State == ConnectionState.Closed) baglanti.Open();
            SqlParameter AdliyeBilgisi = new SqlParameter("@AdliyeBilgisi", textBoxAdliyeAra.Text);
            SqlCommand AdliyeBilgisiAra = new SqlCommand("SELECT * FROM Adliye WHERE AdliyeAdi = @AdliyeBilgisi OR AdliyeTelefonNo = @AdliyeBilgisi", baglanti);
            AdliyeBilgisiAra.Parameters.Add(AdliyeBilgisi);
            SqlDataAdapter da = new SqlDataAdapter(AdliyeBilgisiAra);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridViewAdliyeler.DataSource = dt;
        }

        private void buttonListele_Click(object sender, EventArgs e)
        {
                KayitGetir();
        }
    }
}

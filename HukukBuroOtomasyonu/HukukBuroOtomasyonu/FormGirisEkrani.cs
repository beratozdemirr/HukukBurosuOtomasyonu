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

namespace HukukBuroOtomasyonu
{
    public partial class FormGirisEkrani : Form
    {
        public FormGirisEkrani()
        {
            InitializeComponent();
        }

        public SqlConnection baglanti = new SqlConnection(@"Data Source = EMIRHAN\EMIRHANSQLSERVER; Initial Catalog = HukukBuroDB; User Id = System Admin; Password = !001994gs; ");

        


        private void buttonGirisYap_Click(object sender, EventArgs e)
        {
            SqlCommand komutGirisYap = new SqlCommand();
            komutGirisYap.Connection = baglanti;
            komutGirisYap.CommandType = CommandType.Text;
            komutGirisYap.CommandText = "SELECT PersonelKullaniciAdi, PersonelSifre, isKullaniciIslemleri FROM Personel WHERE PersonelKullaniciAdi = @PersonelKullaniciAdi AND PersonelSifre = @PersonelSifre";
            komutGirisYap.Parameters.AddWithValue("@PersonelKullaniciAdi", textBoxKullaniciAdi.Text);
            komutGirisYap.Parameters.AddWithValue("@PersonelSifre", textBoxSifre.Text);
            komutGirisYap.Connection.Open();
            SqlDataReader okuGiris = komutGirisYap.ExecuteReader(CommandBehavior.CloseConnection);

            FormKullaniciBilgileri kullaniciBilgisiGetir = new FormKullaniciBilgileri();
            

            //KULLANICI ADIVE ŞİFRE YÜKLEMEK İÇİN GEREKLİ!!!

            kullaniciBilgisiGetir.textBoxKullaniciAdi.Text = textBoxKullaniciAdi.Text.ToString();
            kullaniciBilgisiGetir.textBoxKullaniciSifre.Text = textBoxSifre.Text.ToString();
            
            

            if (okuGiris.HasRows)
            {
                while (okuGiris.Read())
                {
                    if (okuGiris["isKullaniciIslemleri"].ToString() == "True")
                    {
                        formBuroOtomasyonu anaEkranaGec = new formBuroOtomasyonu();
                        anaEkranaGec.buttonYonetimsel_Islemler.Visible = true;
                        this.Hide();
                        anaEkranaGec.Show();
                        //kullaniciBilgisiGetir.ShowDialog();
                    }

                    else if (okuGiris["isKullaniciIslemleri"].ToString() == "False")
                    {
                        formBuroOtomasyonu anaEkranaGec = new formBuroOtomasyonu();
                        anaEkranaGec.buttonYonetimsel_Islemler.Visible = false;
                        this.Hide();
                        anaEkranaGec.Show();
                        //kullaniciBilgisiGetir.ShowDialog();
                    }
                }
            }

            else
            {
                okuGiris.Close();
                MessageBox.Show("Kullanıcı Adı Veya Şifresi Geçersiz.", "Uyarı!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void FormGirisEkrani_Load(object sender, EventArgs e)
        {
            
        }
    }
}

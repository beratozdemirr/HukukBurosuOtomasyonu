﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using HukukBuroOtomasyonu.Davalar;

namespace HukukBuroOtomasyonu.DavaSonucu
{
    public partial class FormDavaSonuclari : Form
    {
        public FormDavaSonuclari()
        {
            InitializeComponent();
        }

        public SqlConnection baglanti = new SqlConnection(@"Data Source = EMIRHAN\EMIRHANSQLSERVER; Initial Catalog = HukukBuroDB; User Id = System Admin; Password = !001994gs; ");

        public void KayitGetir()
        {
            if (baglanti.State == ConnectionState.Closed) baglanti.Open();
            string listeleDavaSonucu = "SELECT * FROM DavaSonucu";
            SqlCommand komutListele = new SqlCommand(listeleDavaSonucu, baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komutListele);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridViewDavaSonuclari.DataSource = dt;
        }

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

        private void FormDavaSonuclari_Load(object sender, EventArgs e)
        {
            MuvekilleriGetir();
            KayitGetir();
        }

        private void buttonDavaSonucuEkle_Click(object sender, EventArgs e)
        {
            FormDavaSonucuEkle sonucEkle = new FormDavaSonucuEkle();
            sonucEkle.ShowDialog();
        }

        private void buttonDavaSonucuSil_Click(object sender, EventArgs e)
        {
            FormDavaSonucuSil sonucSil = new FormDavaSonucuSil();
            sonucSil.ShowDialog();
        }

        private void buttonDavaSonucuGuncelle_Click(object sender, EventArgs e)
        {
            FormDavaSonucuGuncelle sonucGuncelle = new FormDavaSonucuGuncelle();
            sonucGuncelle.ShowDialog();
        }

        private void buttonRaporOlustur_Click(object sender, EventArgs e)
        {
            FormDavaSonucuRaporOlustur sonucRapor = new FormDavaSonucuRaporOlustur();
            sonucRapor.ShowDialog();
        }

        private void buttonAnaEkranaDon_Click(object sender, EventArgs e)
        {
            FormDavalar davalaraDon = new FormDavalar();
            this.Hide();
            davalaraDon.Show();
        }

        private void buttonAraligaGoreGelismeBul_Click(object sender, EventArgs e)
        {
            if (baglanti.State == ConnectionState.Closed) baglanti.Open();
            SqlParameter BaslangicTarihi = new SqlParameter("@BaslangicTarihi", dateTimePickerBaslangicTarihi.Value);
            SqlParameter BitisTarihi = new SqlParameter("@BitisTarihi", dateTimePickerBitisTarihi.Value);
            SqlCommand AraligaGoreSonucBul = new SqlCommand("SELECT * FROM DavaSonucu WHERE DavaBitisTarihi BETWEEN @BaslangicTarihi AND @BitisTarihi", baglanti);
            AraligaGoreSonucBul.Parameters.Add(BaslangicTarihi);
            AraligaGoreSonucBul.Parameters.Add(BitisTarihi);
            SqlDataAdapter da = new SqlDataAdapter(AraligaGoreSonucBul);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridViewDavaSonuclari.DataSource = dt;
        }

        private void buttonMuvekkileGoreGelismeAra_Click(object sender, EventArgs e)
        {
            if (baglanti.State == ConnectionState.Closed) baglanti.Open();
            SqlParameter Muvekkil_Isim = new SqlParameter("@Muvekkil_Isim", comboBoxMuvekkil_Isim.Text);
            SqlCommand MuvekkileGoreSonucGetir = new SqlCommand("SELECT * FROM DavaSonucu WHERE Muvekkil_ID IN(SELECT Muvekkil_ID FROM Muvekkil WHERE Muvekkil_Isim = @Muvekkil_Isim)", baglanti);
            MuvekkileGoreSonucGetir.Parameters.Add(Muvekkil_Isim);
            SqlDataAdapter da = new SqlDataAdapter(MuvekkileGoreSonucGetir);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridViewDavaSonuclari.DataSource = dt;
        }

        private void buttonDavaSonucuAra_Click(object sender, EventArgs e)
        {
            if (baglanti.State == ConnectionState.Closed) baglanti.Open();
            SqlCommand spDavaSonucuBul = new SqlCommand();
            spDavaSonucuBul.Connection = baglanti;
            spDavaSonucuBul.CommandType = CommandType.StoredProcedure;
            spDavaSonucuBul.CommandText = "spDavaSonucuBul";
            spDavaSonucuBul.Parameters.AddWithValue("@DavaSonucu", comboBoxDavaSonucu.Text);
            spDavaSonucuBul.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter(spDavaSonucuBul);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridViewDavaSonuclari.DataSource = dt;
        }

        private void buttonListele_Click(object sender, EventArgs e)
        {
            KayitGetir();
        }
    }
}

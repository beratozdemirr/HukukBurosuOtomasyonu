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

namespace HukukBuroOtomasyonu.Adliye
{
    public partial class FormAdliyeRaporOlustur : Form
    {
        public FormAdliyeRaporOlustur()
        {
            InitializeComponent();
        }

        public SqlConnection baglanti = new SqlConnection(@"Data Source = EMIRHAN\EMIRHANSQLSERVER; Initial Catalog = HukukBuroDB; User Id = System Admin; Password = !001994gs; ");

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

        private void FormAdliyeRaporOlustur_Load(object sender, EventArgs e)
        {
            KayitGetir();
        }

        private void buttonAdliyeAdiAra_Click(object sender, EventArgs e)
        {
            if (baglanti.State == ConnectionState.Closed) baglanti.Open();
            SqlParameter AdliyeAdi = new SqlParameter("@AdliyeAdi", textBoxAdliyeAra.Text);
            SqlCommand AdliyeAdiAra = new SqlCommand("SELECT * FROM Adliye WHERE AdliyeAdi = @AdliyeAdi", baglanti);
            AdliyeAdiAra.Parameters.Add(AdliyeAdi);
            SqlDataAdapter da = new SqlDataAdapter(AdliyeAdiAra);
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

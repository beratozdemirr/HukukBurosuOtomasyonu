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

namespace HukukBuroOtomasyonu.Muvekkiller
{
    public partial class FormMuvekkilGuncelle : Form
    {
        public FormMuvekkilGuncelle()
        {
            InitializeComponent();
        }

        public SqlConnection baglanti = new SqlConnection(@"Data Source = EMIRHAN\EMIRHANSQLSERVER; Initial Catalog = HukukBuroDB; User Id = System Admin; Password = !001994gs; ");

        FormMuvekkilGuncelleDoldur muvGuncDol = new FormMuvekkilGuncelleDoldur();

        
        

        public void KayitGetir()
        {
            if (baglanti.State == ConnectionState.Closed) baglanti.Open();
            string listeleMuvekkil = "SELECT * FROM Muvekkil";
            SqlCommand komutListele = new SqlCommand(listeleMuvekkil, baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komutListele);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridViewMuvekkiller.DataSource = dt;
        }

        public void KayitYukle()
        {
            var value = dataGridViewMuvekkiller.CurrentRow.Cells[9].Value.ToString();

            if (value == "KİŞİ")
            {
                muvGuncDol.groupBoxKisiselBilgilerKisi.Visible = true;
                muvGuncDol.groupBoxKisiselBilgilerKurulus.Visible = false;
                muvGuncDol.buttonMuvKisiGuncelle.Visible = true;
                muvGuncDol.buttonMuvKurulusGuncelle.Visible = false;
                
                muvGuncDol.textBoxMuvNo.Text = dataGridViewMuvekkiller.CurrentRow.Cells[0].Value.ToString();
                muvGuncDol.textBoxKisi_Isim.Text = dataGridViewMuvekkiller.CurrentRow.Cells[1].Value.ToString();
                muvGuncDol.textBoxKisiTCNo.Text = dataGridViewMuvekkiller.CurrentRow.Cells[2].Value.ToString();
                muvGuncDol.textBoxKurulusVergiNo.Text = dataGridViewMuvekkiller.CurrentRow.Cells[3].Value.ToString();
                muvGuncDol.textBoxKisiSicilNo.Text = dataGridViewMuvekkiller.CurrentRow.Cells[4].Value.ToString();
                muvGuncDol.comboBoxKisiCinsiyet.Text = dataGridViewMuvekkiller.CurrentRow.Cells[5].Value.ToString();
                muvGuncDol.textBoxMuvekkilTelefonNo.Text = dataGridViewMuvekkiller.CurrentRow.Cells[6].Value.ToString();
                muvGuncDol.textBoxMuvekkilAdres.Text = dataGridViewMuvekkiller.CurrentRow.Cells[7].Value.ToString();
                muvGuncDol.comboBoxMuvekkilTipi.Text = dataGridViewMuvekkiller.CurrentRow.Cells[8].Value.ToString();
                muvGuncDol.textBoxMuvekkilSecimi.Text = dataGridViewMuvekkiller.CurrentRow.Cells[9].Value.ToString();
            }

            else if(value == "KURULUŞ")
            {
                muvGuncDol.groupBoxKisiselBilgilerKurulus.Visible = true;
                muvGuncDol.groupBoxKisiselBilgilerKisi.Visible = false;
                muvGuncDol.buttonMuvKurulusGuncelle.Visible = true;
                muvGuncDol.buttonMuvKisiGuncelle.Visible = false;

                muvGuncDol.textBoxMuvNo.Text = dataGridViewMuvekkiller.CurrentRow.Cells[0].Value.ToString();
                muvGuncDol.textBoxKurulus_Isim.Text = dataGridViewMuvekkiller.CurrentRow.Cells[1].Value.ToString();
                muvGuncDol.textBoxKisiTCNo.Text = dataGridViewMuvekkiller.CurrentRow.Cells[2].Value.ToString();
                muvGuncDol.textBoxKurulusVergiNo.Text = dataGridViewMuvekkiller.CurrentRow.Cells[3].Value.ToString();
                muvGuncDol.textBoxKisiSicilNo.Text = dataGridViewMuvekkiller.CurrentRow.Cells[4].Value.ToString();
                muvGuncDol.comboBoxKisiCinsiyet.Text = dataGridViewMuvekkiller.CurrentRow.Cells[5].Value.ToString();
                muvGuncDol.textBoxMuvekkilTelefonNo.Text = dataGridViewMuvekkiller.CurrentRow.Cells[6].Value.ToString();
                muvGuncDol.textBoxMuvekkilAdres.Text = dataGridViewMuvekkiller.CurrentRow.Cells[7].Value.ToString();
                muvGuncDol.comboBoxMuvekkilTipi.Text = dataGridViewMuvekkiller.CurrentRow.Cells[8].Value.ToString();
                muvGuncDol.textBoxMuvekkilSecimi.Text = dataGridViewMuvekkiller.CurrentRow.Cells[9].Value.ToString();
            }
            
        }

        private void FormMuvekkilGuncelle_Load(object sender, EventArgs e)
        {
            KayitGetir();
        }

        private void buttonGuncelle_Click(object sender, EventArgs e)
        {
            KayitYukle();
            muvGuncDol.ShowDialog();
        }

        private void buttonMuvekkil_IsimAra_Click(object sender, EventArgs e)
        {
            if (baglanti.State == ConnectionState.Closed) baglanti.Open();
            SqlCommand spMuvekkil_IsmiBul = new SqlCommand();
            spMuvekkil_IsmiBul.Connection = baglanti;
            spMuvekkil_IsmiBul.CommandType = CommandType.StoredProcedure;
            spMuvekkil_IsmiBul.CommandText = "spMuvekkil_IsmiBul";
            spMuvekkil_IsmiBul.Parameters.AddWithValue("@Muvekkil_Isim", textBoxMuvekkil_IsmiAra.Text);
            spMuvekkil_IsmiBul.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter(spMuvekkil_IsmiBul);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridViewMuvekkiller.DataSource = dt;
        }

        private void buttonListele_Click(object sender, EventArgs e)
        {
            KayitGetir();
        }

        private void buttonMuvekkilTipiAra_Click(object sender, EventArgs e)
        {
            if (baglanti.State == ConnectionState.Closed) baglanti.Open();
            SqlCommand spMuvekkilTipiBul = new SqlCommand();
            spMuvekkilTipiBul.Connection = baglanti;
            spMuvekkilTipiBul.CommandType = CommandType.StoredProcedure;
            spMuvekkilTipiBul.CommandText = "spMuvekkilTipiBul";
            spMuvekkilTipiBul.Parameters.AddWithValue("@MuvekkilTipi", comboBoxAraMuvekkilTipi.Text);
            spMuvekkilTipiBul.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter(spMuvekkilTipiBul);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridViewMuvekkiller.DataSource = dt;
        }

       
    }
}

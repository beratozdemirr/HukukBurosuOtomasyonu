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
    public partial class FormMuvekkilSil : Form
    {
        public FormMuvekkilSil()
        {
            InitializeComponent();
        }

        public SqlConnection baglanti = new SqlConnection(@"Data Source = EMIRHAN\EMIRHANSQLSERVER; Initial Catalog = HukukBuroDB; User Id = System Admin; Password = !001994gs; ");

        

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

        private void FormMuvekkilSil_Load(object sender, EventArgs e)
        {
            KayitGetir();
        }

        private void buttonSilMuvBilgisiAra_Click(object sender, EventArgs e)
        {
            if (baglanti.State == ConnectionState.Closed) baglanti.Open();
            SqlParameter MuvekkilBilgisi = new SqlParameter("@MuvekkilBilgisi", textBoxAraCoklu.Text);
            SqlCommand MuvekkilBilgisiAra = new SqlCommand("SELECT * FROM Muvekkil WHERE Muvekkil_Isim = @MuvekkilBilgisi OR MuvekkilTCNo = @MuvekkilBilgisi OR MuvekkilVergiNo = @MuvekkilBilgisi OR MuvekkilSicilNo = @MuvekkilBilgisi OR MuvekkilCinsiyet = @MuvekkilBilgisi OR MuvekkilTelefonNo = @MuvekkilBilgisi OR MuvekkilTipi = @MuvekkilBilgisi OR MuvekkilSecimi = @MuvekkilBilgisi", baglanti);
            MuvekkilBilgisiAra.Parameters.Add(MuvekkilBilgisi);
            SqlDataAdapter da = new SqlDataAdapter(MuvekkilBilgisiAra);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridViewMuvekkiller.DataSource = dt;
        }

        private void buttonSilMuvTipiAra_Click(object sender, EventArgs e)
        {
            if (baglanti.State == ConnectionState.Closed) baglanti.Open();
            SqlParameter MuvekkilTipi = new SqlParameter("@MuvekkilTipi", comboBoxAraMuvekkilTipi.Text);
            SqlCommand MuvekkilTipiAra = new SqlCommand("SELECT * FROM Muvekkil WHERE MuvekkilTipi = @MuvekkilTipi", baglanti);
            MuvekkilTipiAra.Parameters.Add(MuvekkilTipi);
            SqlDataAdapter da = new SqlDataAdapter(MuvekkilTipiAra);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridViewMuvekkiller.DataSource = dt;
        }

        private void buttonListele_Click(object sender, EventArgs e)
        {
            KayitGetir();
        }

        private void buttonSil_Click(object sender, EventArgs e)
        {
            if (baglanti.State == ConnectionState.Closed) baglanti.Open();
            SqlCommand spMuvekkilSil = new SqlCommand();
            spMuvekkilSil.Connection = baglanti;
            spMuvekkilSil.CommandType = CommandType.StoredProcedure;
            spMuvekkilSil.CommandText = "spMuvekkilSil";
            spMuvekkilSil.Parameters.Add("@Muvekkil_ID", dataGridViewMuvekkiller.CurrentRow.Cells[0].Value.ToString());
            spMuvekkilSil.ExecuteNonQuery();
            MessageBox.Show("Müşteri Bilgileri Silindi");
            KayitGetir();
        }
    }
}

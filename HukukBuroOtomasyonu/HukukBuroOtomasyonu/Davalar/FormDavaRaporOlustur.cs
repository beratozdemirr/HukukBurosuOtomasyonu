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
using Excel = Microsoft.Office.Interop.Excel;
using HukukBuroOtomasyonu.KarsiTaraf;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;

namespace HukukBuroOtomasyonu.Davalar
{
    public partial class FormDavaRaporOlustur : Form
    {
        public FormDavaRaporOlustur()
        {
            InitializeComponent();
        }

        public SqlConnection baglanti = new SqlConnection(@"Data Source = EMIRHAN\EMIRHANSQLSERVER; Initial Catalog = HukukBuroDB; User Id = System Admin; Password = !001994gs; ");

        FormRaporGoster raporGor = new FormRaporGoster();

        ReportDocument cryRpt = new ReportDocument();

        int satirSay;


        public void KayitGetir()
        {
            if (baglanti.State == ConnectionState.Closed) baglanti.Open();
            string listeleDava = "SELECT * FROM Dava";
            SqlCommand komutListele = new SqlCommand(listeleDava, baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komutListele);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridViewDavalar.DataSource = dt;
        }

        public void MuvekilleriGetir()
        {
            if (baglanti.State == ConnectionState.Closed) baglanti.Open();
            SqlCommand muvekkilYukle = new SqlCommand("SELECT Muvekkil_Isim FROM Muvekkil", baglanti);
            SqlDataReader okuMuvekkilAdi;
            okuMuvekkilAdi = muvekkilYukle.ExecuteReader();
            while (okuMuvekkilAdi.Read())
            {
                comboBoxMuvekkil_IsimARA.Items.Add(okuMuvekkilAdi["Muvekkil_Isim"]);
            }
            baglanti.Close();
        }

        public void AdliyeleriGetir()
        {
            if (baglanti.State == ConnectionState.Closed) baglanti.Open();
            SqlCommand AdliyeAdiYukle = new SqlCommand("SELECT AdliyeAdi FROM Adliye", baglanti);
            SqlDataReader okuAdliyeAdi;
            okuAdliyeAdi = AdliyeAdiYukle.ExecuteReader();
            while (okuAdliyeAdi.Read())
            {
                comboBoxAdliyeBinasiARA.Items.Add(okuAdliyeAdi["AdliyeAdi"]);
            }
            baglanti.Close();
        }


        private void tumunuPanoyaKopyala()
        {
            dataGridViewDavalar.SelectAll();
            DataObject veri = dataGridViewDavalar.GetClipboardContent();
            if (veri != null)
                Clipboard.SetDataObject(veri);
        }

        private void buttonDataExportToExcel_Click(object sender, EventArgs e)
        {
            tumunuPanoyaKopyala();
            Microsoft.Office.Interop.Excel.Application xlexcel;
            Microsoft.Office.Interop.Excel.Workbook xlWorkBook;
            Microsoft.Office.Interop.Excel.Worksheet xlWorkSheet;
            object misValue = System.Reflection.Missing.Value;
            xlexcel = new Excel.Application();
            xlexcel.Visible = true;
            xlWorkBook = xlexcel.Workbooks.Add(misValue);
            xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);
            Excel.Range CR = (Excel.Range)xlWorkSheet.Cells[1, 1];
            CR.Select();
            xlWorkSheet.PasteSpecial(CR, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, true);
        }

        

        



        private void FormDavaRaporOlustur_Load(object sender, EventArgs e)
        {
            KayitGetir();
            MuvekilleriGetir();
            AdliyeleriGetir();
        }

        

        private void buttonListele_Click(object sender, EventArgs e)
        {
            KayitGetir();
        }

        private void buttonMuvekkilAra_Click(object sender, EventArgs e)
        {
            if (baglanti.State == ConnectionState.Closed) baglanti.Open();
            SqlParameter Muvekkil_Isim = new SqlParameter("@Muvekkil_Isim", comboBoxMuvekkil_IsimARA.Text);
            SqlCommand MuvekkilAdinaGoreDavaARA = new SqlCommand("SELECT * FROM Dava WHERE Muvekkil_ID IN(SELECT Muvekkil_ID FROM Muvekkil WHERE Muvekkil_Isim = @Muvekkil_Isim)", baglanti);
            MuvekkilAdinaGoreDavaARA.Parameters.Add(Muvekkil_Isim);
            SqlDataAdapter da = new SqlDataAdapter(MuvekkilAdinaGoreDavaARA);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridViewDavalar.DataSource = dt;
            comboBoxMuvekkil_IsimARA.Items.Add("");
        }

        private void buttonDavaTuruAra_Click(object sender, EventArgs e)
        {
            if (baglanti.State == ConnectionState.Closed) baglanti.Open();
            SqlCommand spDavaTuruBul = new SqlCommand();
            spDavaTuruBul.Connection = baglanti;
            spDavaTuruBul.CommandType = CommandType.StoredProcedure;
            spDavaTuruBul.CommandText = "spDavaTuruBul";
            spDavaTuruBul.Parameters.AddWithValue("@DavaTuru", comboBoxDavaTuruARA.Text);
            spDavaTuruBul.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter(spDavaTuruBul);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridViewDavalar.DataSource = dt;
        }

        private void buttonAdliyeBinasiAra_Click(object sender, EventArgs e)
        {
            if (baglanti.State == ConnectionState.Closed) baglanti.Open();
            SqlParameter AdliyeAdi = new SqlParameter("@AdliyeAdi", comboBoxAdliyeBinasiARA.Text);
            SqlCommand AdliyeAdinaGoreDavaARA = new SqlCommand("SELECT * FROM Dava WHERE Adliye_ID IN (SELECT Adliye_ID FROM Adliye WHERE AdliyeAdi = @AdliyeAdi)", baglanti);
            AdliyeAdinaGoreDavaARA.Parameters.Add(AdliyeAdi);
            SqlDataAdapter da = new SqlDataAdapter(AdliyeAdinaGoreDavaARA);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridViewDavalar.DataSource = dt;
            comboBoxAdliyeBinasiARA.Items.Add("");
        }

        private void buttonBelgeAc_Click(object sender, EventArgs e)
        {
            
        }

        public void satirSutunOlustur()
        {
            raporGor.dataGridViewRapor.ColumnCount = 14;
            raporGor.dataGridViewRapor.Columns[0].Name = "Dava_ID";
            raporGor.dataGridViewRapor.Columns[1].Name = "Muvekkil_ID";
            raporGor.dataGridViewRapor.Columns[2].Name = "KarsiTaraf_ID";
            raporGor.dataGridViewRapor.Columns[3].Name = "Personel_ID";
            raporGor.dataGridViewRapor.Columns[4].Name = "Adliye_ID";
            raporGor.dataGridViewRapor.Columns[5].Name = "DavaNo";
            raporGor.dataGridViewRapor.Columns[6].Name = "DavaAcilisTarihi";
            raporGor.dataGridViewRapor.Columns[7].Name = "DavaTuru";
            raporGor.dataGridViewRapor.Columns[8].Name = "DavaMuvekkilTalep";
            raporGor.dataGridViewRapor.Columns[9].Name = "DavaTutari";
            raporGor.dataGridViewRapor.Columns[10].Name = "DavaSalonNo";
            raporGor.dataGridViewRapor.Columns[11].Name = "DavaOturumSayisi";
            raporGor.dataGridViewRapor.Columns[12].Name = "DavaGelecekOturumTarihi";
            raporGor.dataGridViewRapor.Columns[13].Name = "DavaSaati";
        }

        private void buttonImportEt_Click(object sender, EventArgs e) // DATASOURCE HATASI ALIYORUM DATAYI DATAREAD İLE OKUTMAYA ÇALIŞ
        {
            baglanti.Close();
            satirSutunOlustur();
            Excel.Application app = new Microsoft.Office.Interop.Excel.Application();
            Excel.Workbook workbook = app.Workbooks.Open(@"C:\Users\Emirhan\Desktop\test4.xlsx");
            Excel.Worksheet worksheet = workbook.ActiveSheet;

            satirSay = worksheet.UsedRange.Rows.Count;

            int i = 0;

            for (; i < satirSay; i++)
            {
                //dataGridView1.Rows[i].Cells["Column1"].Value = worksheet.Cells[i + 1, 1].Value;
                //dataGridView1.Rows[i].Cells["Column2"].Value = worksheet.Cells[i + 1, 2].Value;
                raporGor.dataGridViewRapor.Rows.Add(worksheet.Cells[i + 1, 1].Value, worksheet.Cells[i + 1, 2].Value, worksheet.Cells[i + 1, 3].Value, worksheet.Cells[i + 1, 4].Value, worksheet.Cells[i + 1, 5].Value, worksheet.Cells[i + 1, 6].Value, worksheet.Cells[i + 1, 7].Value, worksheet.Cells[i + 1, 8].Value, worksheet.Cells[i + 1, 9].Value, worksheet.Cells[i + 1, 10].Value, worksheet.Cells[i + 1, 11].Value, worksheet.Cells[i + 1, 12].Value, worksheet.Cells[i + 1, 13].Value, worksheet.Cells[i + 1, 14].Value);
            }

            raporGor.ShowDialog();
        }

        private void buttonRaporOlustur_Click(object sender, EventArgs e)
        {
            
                cryRpt.Load(@"C:\Users\Emirhan\Desktop\\DavaRaporu.rpt");
            crystalReportViewerDava.ReportSource = cryRpt;
            crystalReportViewerDava.Refresh();

            
        }

        private void buttonPdfOlustur_Click(object sender, EventArgs e)
        {
            try
            {
                ExportOptions CrExportOptions;
                DiskFileDestinationOptions CrDiskFileDestinationOptions = new DiskFileDestinationOptions();
                PdfRtfWordFormatOptions CrFormatTypeOptions = new PdfRtfWordFormatOptions();
                CrDiskFileDestinationOptions.DiskFileName = @"C:\Users\Emirhan\Desktop\\DavaRaporu.pdf";
                CrExportOptions = cryRpt.ExportOptions;
                {
                    CrExportOptions.ExportDestinationType = ExportDestinationType.DiskFile;
                    CrExportOptions.ExportFormatType = ExportFormatType.PortableDocFormat;
                    CrExportOptions.DestinationOptions = CrDiskFileDestinationOptions;
                    CrExportOptions.FormatOptions = CrFormatTypeOptions;
                }
                cryRpt.Export();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}

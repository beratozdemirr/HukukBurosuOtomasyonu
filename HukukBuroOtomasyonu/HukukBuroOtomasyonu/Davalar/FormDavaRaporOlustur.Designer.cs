namespace HukukBuroOtomasyonu.Davalar
{
    partial class FormDavaRaporOlustur
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDavaRaporOlustur));
            this.comboBoxAdliyeBinasiARA = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.comboBoxDavaTuruARA = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxMuvekkil_IsimARA = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.dataGridViewDavalar = new System.Windows.Forms.DataGridView();
            this.groupBoxParametreler_1 = new System.Windows.Forms.GroupBox();
            this.buttonDavaTuruAra = new System.Windows.Forms.Button();
            this.buttonMuvekkilAra = new System.Windows.Forms.Button();
            this.groupBoxParametreler2 = new System.Windows.Forms.GroupBox();
            this.buttonAdliyeBinasiAra = new System.Windows.Forms.Button();
            this.buttonListele = new System.Windows.Forms.Button();
            this.buttonDataExportToExcel = new System.Windows.Forms.Button();
            this.buttonRaporOlustur = new System.Windows.Forms.Button();
            this.buttonImportEt = new System.Windows.Forms.Button();
            this.crystalReportViewerDava = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.buttonPdfOlustur = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDavalar)).BeginInit();
            this.groupBoxParametreler_1.SuspendLayout();
            this.groupBoxParametreler2.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBoxAdliyeBinasiARA
            // 
            this.comboBoxAdliyeBinasiARA.FormattingEnabled = true;
            this.comboBoxAdliyeBinasiARA.Location = new System.Drawing.Point(103, 44);
            this.comboBoxAdliyeBinasiARA.Name = "comboBoxAdliyeBinasiARA";
            this.comboBoxAdliyeBinasiARA.Size = new System.Drawing.Size(206, 21);
            this.comboBoxAdliyeBinasiARA.TabIndex = 56;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.Location = new System.Drawing.Point(18, 47);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(79, 13);
            this.label13.TabIndex = 57;
            this.label13.Text = "Adliye Binası";
            // 
            // comboBoxDavaTuruARA
            // 
            this.comboBoxDavaTuruARA.FormattingEnabled = true;
            this.comboBoxDavaTuruARA.Items.AddRange(new object[] {
            "KİRA DAVALARI",
            "AİLE DAVALARI",
            "MİRAS DAVALARI",
            "BORÇ DAVALARI",
            "ŞİRKET DAVALARI",
            "İCRA DAVALARI",
            "KİŞİLİK HAKLARI DAVALARI"});
            this.comboBoxDavaTuruARA.Location = new System.Drawing.Point(94, 71);
            this.comboBoxDavaTuruARA.Name = "comboBoxDavaTuruARA";
            this.comboBoxDavaTuruARA.Size = new System.Drawing.Size(219, 21);
            this.comboBoxDavaTuruARA.TabIndex = 52;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(18, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 54;
            this.label3.Text = "Dava Türü";
            // 
            // comboBoxMuvekkil_IsimARA
            // 
            this.comboBoxMuvekkil_IsimARA.FormattingEnabled = true;
            this.comboBoxMuvekkil_IsimARA.Location = new System.Drawing.Point(94, 22);
            this.comboBoxMuvekkil_IsimARA.Name = "comboBoxMuvekkil_IsimARA";
            this.comboBoxMuvekkil_IsimARA.Size = new System.Drawing.Size(219, 21);
            this.comboBoxMuvekkil_IsimARA.TabIndex = 48;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(26, 25);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 13);
            this.label10.TabIndex = 49;
            this.label10.Text = "Müvekkil";
            // 
            // dataGridViewDavalar
            // 
            this.dataGridViewDavalar.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridViewDavalar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDavalar.Location = new System.Drawing.Point(1, 0);
            this.dataGridViewDavalar.Name = "dataGridViewDavalar";
            this.dataGridViewDavalar.Size = new System.Drawing.Size(883, 281);
            this.dataGridViewDavalar.TabIndex = 46;
            // 
            // groupBoxParametreler_1
            // 
            this.groupBoxParametreler_1.Controls.Add(this.buttonDavaTuruAra);
            this.groupBoxParametreler_1.Controls.Add(this.buttonMuvekkilAra);
            this.groupBoxParametreler_1.Controls.Add(this.label10);
            this.groupBoxParametreler_1.Controls.Add(this.comboBoxMuvekkil_IsimARA);
            this.groupBoxParametreler_1.Controls.Add(this.label3);
            this.groupBoxParametreler_1.Controls.Add(this.comboBoxDavaTuruARA);
            this.groupBoxParametreler_1.Location = new System.Drawing.Point(48, 303);
            this.groupBoxParametreler_1.Name = "groupBoxParametreler_1";
            this.groupBoxParametreler_1.Size = new System.Drawing.Size(394, 112);
            this.groupBoxParametreler_1.TabIndex = 60;
            this.groupBoxParametreler_1.TabStop = false;
            // 
            // buttonDavaTuruAra
            // 
            this.buttonDavaTuruAra.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonDavaTuruAra.BackgroundImage")));
            this.buttonDavaTuruAra.Location = new System.Drawing.Point(332, 60);
            this.buttonDavaTuruAra.Name = "buttonDavaTuruAra";
            this.buttonDavaTuruAra.Size = new System.Drawing.Size(40, 40);
            this.buttonDavaTuruAra.TabIndex = 131;
            this.buttonDavaTuruAra.UseVisualStyleBackColor = true;
            this.buttonDavaTuruAra.Click += new System.EventHandler(this.buttonDavaTuruAra_Click);
            // 
            // buttonMuvekkilAra
            // 
            this.buttonMuvekkilAra.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonMuvekkilAra.BackgroundImage")));
            this.buttonMuvekkilAra.Location = new System.Drawing.Point(332, 11);
            this.buttonMuvekkilAra.Name = "buttonMuvekkilAra";
            this.buttonMuvekkilAra.Size = new System.Drawing.Size(40, 40);
            this.buttonMuvekkilAra.TabIndex = 130;
            this.buttonMuvekkilAra.UseVisualStyleBackColor = true;
            this.buttonMuvekkilAra.Click += new System.EventHandler(this.buttonMuvekkilAra_Click);
            // 
            // groupBoxParametreler2
            // 
            this.groupBoxParametreler2.Controls.Add(this.buttonAdliyeBinasiAra);
            this.groupBoxParametreler2.Controls.Add(this.label13);
            this.groupBoxParametreler2.Controls.Add(this.comboBoxAdliyeBinasiARA);
            this.groupBoxParametreler2.Location = new System.Drawing.Point(469, 303);
            this.groupBoxParametreler2.Name = "groupBoxParametreler2";
            this.groupBoxParametreler2.Size = new System.Drawing.Size(384, 112);
            this.groupBoxParametreler2.TabIndex = 61;
            this.groupBoxParametreler2.TabStop = false;
            // 
            // buttonAdliyeBinasiAra
            // 
            this.buttonAdliyeBinasiAra.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonAdliyeBinasiAra.BackgroundImage")));
            this.buttonAdliyeBinasiAra.Location = new System.Drawing.Point(326, 33);
            this.buttonAdliyeBinasiAra.Name = "buttonAdliyeBinasiAra";
            this.buttonAdliyeBinasiAra.Size = new System.Drawing.Size(40, 40);
            this.buttonAdliyeBinasiAra.TabIndex = 132;
            this.buttonAdliyeBinasiAra.UseVisualStyleBackColor = true;
            this.buttonAdliyeBinasiAra.Click += new System.EventHandler(this.buttonAdliyeBinasiAra_Click);
            // 
            // buttonListele
            // 
            this.buttonListele.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonListele.Location = new System.Drawing.Point(-1, 519);
            this.buttonListele.Name = "buttonListele";
            this.buttonListele.Size = new System.Drawing.Size(135, 43);
            this.buttonListele.TabIndex = 135;
            this.buttonListele.Text = "LİSTELE";
            this.buttonListele.UseVisualStyleBackColor = true;
            this.buttonListele.Click += new System.EventHandler(this.buttonListele_Click);
            // 
            // buttonDataExportToExcel
            // 
            this.buttonDataExportToExcel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonDataExportToExcel.Location = new System.Drawing.Point(227, 514);
            this.buttonDataExportToExcel.Name = "buttonDataExportToExcel";
            this.buttonDataExportToExcel.Size = new System.Drawing.Size(147, 48);
            this.buttonDataExportToExcel.TabIndex = 136;
            this.buttonDataExportToExcel.Text = "VERİ EXPORT ET";
            this.buttonDataExportToExcel.UseVisualStyleBackColor = true;
            this.buttonDataExportToExcel.Click += new System.EventHandler(this.buttonDataExportToExcel_Click);
            // 
            // buttonRaporOlustur
            // 
            this.buttonRaporOlustur.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonRaporOlustur.Location = new System.Drawing.Point(586, 517);
            this.buttonRaporOlustur.Name = "buttonRaporOlustur";
            this.buttonRaporOlustur.Size = new System.Drawing.Size(141, 43);
            this.buttonRaporOlustur.TabIndex = 138;
            this.buttonRaporOlustur.Text = "RAPOR OLUŞTUR";
            this.buttonRaporOlustur.UseVisualStyleBackColor = true;
            this.buttonRaporOlustur.Click += new System.EventHandler(this.buttonRaporOlustur_Click);
            // 
            // buttonImportEt
            // 
            this.buttonImportEt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonImportEt.Location = new System.Drawing.Point(380, 514);
            this.buttonImportEt.Name = "buttonImportEt";
            this.buttonImportEt.Size = new System.Drawing.Size(140, 48);
            this.buttonImportEt.TabIndex = 143;
            this.buttonImportEt.Text = "VERİ IMPORT ET";
            this.buttonImportEt.UseVisualStyleBackColor = true;
            this.buttonImportEt.Click += new System.EventHandler(this.buttonImportEt_Click);
            // 
            // crystalReportViewerDava
            // 
            this.crystalReportViewerDava.ActiveViewIndex = -1;
            this.crystalReportViewerDava.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewerDava.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewerDava.Location = new System.Drawing.Point(25, 431);
            this.crystalReportViewerDava.Name = "crystalReportViewerDava";
            this.crystalReportViewerDava.Size = new System.Drawing.Size(38, 50);
            this.crystalReportViewerDava.TabIndex = 144;
            // 
            // buttonPdfOlustur
            // 
            this.buttonPdfOlustur.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonPdfOlustur.Location = new System.Drawing.Point(733, 517);
            this.buttonPdfOlustur.Name = "buttonPdfOlustur";
            this.buttonPdfOlustur.Size = new System.Drawing.Size(141, 43);
            this.buttonPdfOlustur.TabIndex = 145;
            this.buttonPdfOlustur.Text = "PDF OLUŞTUR";
            this.buttonPdfOlustur.UseVisualStyleBackColor = true;
            this.buttonPdfOlustur.Click += new System.EventHandler(this.buttonPdfOlustur_Click);
            // 
            // FormDavaRaporOlustur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.buttonPdfOlustur);
            this.Controls.Add(this.crystalReportViewerDava);
            this.Controls.Add(this.buttonImportEt);
            this.Controls.Add(this.buttonRaporOlustur);
            this.Controls.Add(this.buttonDataExportToExcel);
            this.Controls.Add(this.buttonListele);
            this.Controls.Add(this.groupBoxParametreler2);
            this.Controls.Add(this.groupBoxParametreler_1);
            this.Controls.Add(this.dataGridViewDavalar);
            this.Name = "FormDavaRaporOlustur";
            this.Text = "DAVA RAPORU OLUŞTUR";
            this.Load += new System.EventHandler(this.FormDavaRaporOlustur_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDavalar)).EndInit();
            this.groupBoxParametreler_1.ResumeLayout(false);
            this.groupBoxParametreler_1.PerformLayout();
            this.groupBoxParametreler2.ResumeLayout(false);
            this.groupBoxParametreler2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxAdliyeBinasiARA;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox comboBoxDavaTuruARA;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxMuvekkil_IsimARA;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dataGridViewDavalar;
        private System.Windows.Forms.GroupBox groupBoxParametreler_1;
        private System.Windows.Forms.GroupBox groupBoxParametreler2;
        private System.Windows.Forms.Button buttonListele;
        private System.Windows.Forms.Button buttonMuvekkilAra;
        private System.Windows.Forms.Button buttonDavaTuruAra;
        private System.Windows.Forms.Button buttonAdliyeBinasiAra;
        private System.Windows.Forms.Button buttonDataExportToExcel;
        private System.Windows.Forms.Button buttonRaporOlustur;
        private System.Windows.Forms.Button buttonImportEt;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewerDava;
        private System.Windows.Forms.Button buttonPdfOlustur;
    }
}
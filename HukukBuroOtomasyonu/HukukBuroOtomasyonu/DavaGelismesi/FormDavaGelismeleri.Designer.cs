namespace HukukBuroOtomasyonu.DavaGelismesi
{
    partial class FormDavaGelismeleri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDavaGelismeleri));
            this.dataGridViewDavaGelismeleri = new System.Windows.Forms.DataGridView();
            this.buttonAnaEkranaDon = new System.Windows.Forms.Button();
            this.buttonRaporOlustur = new System.Windows.Forms.Button();
            this.buttonDavaGelismesiGuncelle = new System.Windows.Forms.Button();
            this.buttonDavaGelismesiSil = new System.Windows.Forms.Button();
            this.buttonDavaGelismesiEkle = new System.Windows.Forms.Button();
            this.comboBoxMuvekkil_Isim = new System.Windows.Forms.ComboBox();
            this.comboBoxDavaDurumu = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePickerBaslangicTarihi = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerBitisTarihi = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonAraligaGoreGelismeBul = new System.Windows.Forms.Button();
            this.buttonMuvekkileGoreGelismeAra = new System.Windows.Forms.Button();
            this.buttonDavaDurumuAra = new System.Windows.Forms.Button();
            this.buttonListele = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDavaGelismeleri)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewDavaGelismeleri
            // 
            this.dataGridViewDavaGelismeleri.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridViewDavaGelismeleri.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDavaGelismeleri.Location = new System.Drawing.Point(1, 47);
            this.dataGridViewDavaGelismeleri.Name = "dataGridViewDavaGelismeleri";
            this.dataGridViewDavaGelismeleri.Size = new System.Drawing.Size(882, 329);
            this.dataGridViewDavaGelismeleri.TabIndex = 17;
            // 
            // buttonAnaEkranaDon
            // 
            this.buttonAnaEkranaDon.BackColor = System.Drawing.Color.SkyBlue;
            this.buttonAnaEkranaDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonAnaEkranaDon.Location = new System.Drawing.Point(710, -1);
            this.buttonAnaEkranaDon.Name = "buttonAnaEkranaDon";
            this.buttonAnaEkranaDon.Size = new System.Drawing.Size(180, 48);
            this.buttonAnaEkranaDon.TabIndex = 16;
            this.buttonAnaEkranaDon.Text = "ANA EKRANA DÖN";
            this.buttonAnaEkranaDon.UseVisualStyleBackColor = false;
            this.buttonAnaEkranaDon.Click += new System.EventHandler(this.buttonAnaEkranaDon_Click);
            // 
            // buttonRaporOlustur
            // 
            this.buttonRaporOlustur.BackColor = System.Drawing.Color.SkyBlue;
            this.buttonRaporOlustur.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonRaporOlustur.Location = new System.Drawing.Point(532, -1);
            this.buttonRaporOlustur.Name = "buttonRaporOlustur";
            this.buttonRaporOlustur.Size = new System.Drawing.Size(180, 48);
            this.buttonRaporOlustur.TabIndex = 15;
            this.buttonRaporOlustur.Text = "RAPOR OLUŞTUR";
            this.buttonRaporOlustur.UseVisualStyleBackColor = false;
            this.buttonRaporOlustur.Click += new System.EventHandler(this.buttonRaporOlustur_Click);
            // 
            // buttonDavaGelismesiGuncelle
            // 
            this.buttonDavaGelismesiGuncelle.BackColor = System.Drawing.Color.SkyBlue;
            this.buttonDavaGelismesiGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonDavaGelismesiGuncelle.Location = new System.Drawing.Point(354, -1);
            this.buttonDavaGelismesiGuncelle.Name = "buttonDavaGelismesiGuncelle";
            this.buttonDavaGelismesiGuncelle.Size = new System.Drawing.Size(180, 48);
            this.buttonDavaGelismesiGuncelle.TabIndex = 14;
            this.buttonDavaGelismesiGuncelle.Text = "DAVA GELİŞMESİ GÜNCELLE";
            this.buttonDavaGelismesiGuncelle.UseVisualStyleBackColor = false;
            this.buttonDavaGelismesiGuncelle.Click += new System.EventHandler(this.buttonDavaGelismesiGuncelle_Click);
            // 
            // buttonDavaGelismesiSil
            // 
            this.buttonDavaGelismesiSil.BackColor = System.Drawing.Color.SkyBlue;
            this.buttonDavaGelismesiSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonDavaGelismesiSil.Location = new System.Drawing.Point(176, -1);
            this.buttonDavaGelismesiSil.Name = "buttonDavaGelismesiSil";
            this.buttonDavaGelismesiSil.Size = new System.Drawing.Size(180, 48);
            this.buttonDavaGelismesiSil.TabIndex = 13;
            this.buttonDavaGelismesiSil.Text = "DAVA GELİŞMESİ SİL";
            this.buttonDavaGelismesiSil.UseVisualStyleBackColor = false;
            this.buttonDavaGelismesiSil.Click += new System.EventHandler(this.buttonDavaGelismesiSil_Click);
            // 
            // buttonDavaGelismesiEkle
            // 
            this.buttonDavaGelismesiEkle.BackColor = System.Drawing.Color.SkyBlue;
            this.buttonDavaGelismesiEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonDavaGelismesiEkle.Location = new System.Drawing.Point(-2, -1);
            this.buttonDavaGelismesiEkle.Name = "buttonDavaGelismesiEkle";
            this.buttonDavaGelismesiEkle.Size = new System.Drawing.Size(180, 48);
            this.buttonDavaGelismesiEkle.TabIndex = 12;
            this.buttonDavaGelismesiEkle.Text = "DAVA GELİŞMESİ EKLE";
            this.buttonDavaGelismesiEkle.UseVisualStyleBackColor = false;
            this.buttonDavaGelismesiEkle.Click += new System.EventHandler(this.buttonDavaGelismesiEkle_Click);
            // 
            // comboBoxMuvekkil_Isim
            // 
            this.comboBoxMuvekkil_Isim.FormattingEnabled = true;
            this.comboBoxMuvekkil_Isim.Location = new System.Drawing.Point(176, 483);
            this.comboBoxMuvekkil_Isim.Name = "comboBoxMuvekkil_Isim";
            this.comboBoxMuvekkil_Isim.Size = new System.Drawing.Size(219, 21);
            this.comboBoxMuvekkil_Isim.TabIndex = 18;
            // 
            // comboBoxDavaDurumu
            // 
            this.comboBoxDavaDurumu.FormattingEnabled = true;
            this.comboBoxDavaDurumu.Items.AddRange(new object[] {
            "ERTELENDİ",
            "SONUÇLANDI"});
            this.comboBoxDavaDurumu.Location = new System.Drawing.Point(591, 483);
            this.comboBoxDavaDurumu.Name = "comboBoxDavaDurumu";
            this.comboBoxDavaDurumu.Size = new System.Drawing.Size(172, 21);
            this.comboBoxDavaDurumu.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(86, 486);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Müvekkil İsim";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(502, 486);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Dava Durumu";
            // 
            // dateTimePickerBaslangicTarihi
            // 
            this.dateTimePickerBaslangicTarihi.Location = new System.Drawing.Point(258, 408);
            this.dateTimePickerBaslangicTarihi.Name = "dateTimePickerBaslangicTarihi";
            this.dateTimePickerBaslangicTarihi.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerBaslangicTarihi.TabIndex = 22;
            // 
            // dateTimePickerBitisTarihi
            // 
            this.dateTimePickerBitisTarihi.Location = new System.Drawing.Point(489, 408);
            this.dateTimePickerBitisTarihi.Name = "dateTimePickerBitisTarihi";
            this.dateTimePickerBitisTarihi.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerBitisTarihi.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(464, 405);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 25);
            this.label3.TabIndex = 24;
            this.label3.Text = "-";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(180, 410);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "Tarih Aralığı";
            // 
            // buttonAraligaGoreGelismeBul
            // 
            this.buttonAraligaGoreGelismeBul.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonAraligaGoreGelismeBul.BackgroundImage")));
            this.buttonAraligaGoreGelismeBul.Location = new System.Drawing.Point(706, 400);
            this.buttonAraligaGoreGelismeBul.Name = "buttonAraligaGoreGelismeBul";
            this.buttonAraligaGoreGelismeBul.Size = new System.Drawing.Size(40, 40);
            this.buttonAraligaGoreGelismeBul.TabIndex = 130;
            this.buttonAraligaGoreGelismeBul.UseVisualStyleBackColor = true;
            this.buttonAraligaGoreGelismeBul.Click += new System.EventHandler(this.buttonAraligaGoreGelismeBul_Click);
            // 
            // buttonMuvekkileGoreGelismeAra
            // 
            this.buttonMuvekkileGoreGelismeAra.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonMuvekkileGoreGelismeAra.BackgroundImage")));
            this.buttonMuvekkileGoreGelismeAra.Location = new System.Drawing.Point(418, 472);
            this.buttonMuvekkileGoreGelismeAra.Name = "buttonMuvekkileGoreGelismeAra";
            this.buttonMuvekkileGoreGelismeAra.Size = new System.Drawing.Size(40, 40);
            this.buttonMuvekkileGoreGelismeAra.TabIndex = 131;
            this.buttonMuvekkileGoreGelismeAra.UseVisualStyleBackColor = true;
            this.buttonMuvekkileGoreGelismeAra.Click += new System.EventHandler(this.buttonMuvekkileGoreGelismeAra_Click);
            // 
            // buttonDavaDurumuAra
            // 
            this.buttonDavaDurumuAra.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonDavaDurumuAra.BackgroundImage")));
            this.buttonDavaDurumuAra.Location = new System.Drawing.Point(769, 472);
            this.buttonDavaDurumuAra.Name = "buttonDavaDurumuAra";
            this.buttonDavaDurumuAra.Size = new System.Drawing.Size(40, 40);
            this.buttonDavaDurumuAra.TabIndex = 132;
            this.buttonDavaDurumuAra.UseVisualStyleBackColor = true;
            this.buttonDavaDurumuAra.Click += new System.EventHandler(this.buttonDavaDurumuAra_Click);
            // 
            // buttonListele
            // 
            this.buttonListele.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonListele.Location = new System.Drawing.Point(-1, 523);
            this.buttonListele.Name = "buttonListele";
            this.buttonListele.Size = new System.Drawing.Size(117, 39);
            this.buttonListele.TabIndex = 135;
            this.buttonListele.Text = "LİSTELE";
            this.buttonListele.UseVisualStyleBackColor = true;
            this.buttonListele.Click += new System.EventHandler(this.buttonListele_Click);
            // 
            // FormDavaGelismeleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.buttonListele);
            this.Controls.Add(this.buttonDavaDurumuAra);
            this.Controls.Add(this.buttonMuvekkileGoreGelismeAra);
            this.Controls.Add(this.buttonAraligaGoreGelismeBul);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateTimePickerBitisTarihi);
            this.Controls.Add(this.dateTimePickerBaslangicTarihi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxDavaDurumu);
            this.Controls.Add(this.comboBoxMuvekkil_Isim);
            this.Controls.Add(this.dataGridViewDavaGelismeleri);
            this.Controls.Add(this.buttonAnaEkranaDon);
            this.Controls.Add(this.buttonRaporOlustur);
            this.Controls.Add(this.buttonDavaGelismesiGuncelle);
            this.Controls.Add(this.buttonDavaGelismesiSil);
            this.Controls.Add(this.buttonDavaGelismesiEkle);
            this.Name = "FormDavaGelismeleri";
            this.Text = "DAVA GELİŞMELERİ";
            this.Load += new System.EventHandler(this.FormDavaGelismeleri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDavaGelismeleri)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewDavaGelismeleri;
        private System.Windows.Forms.Button buttonAnaEkranaDon;
        private System.Windows.Forms.Button buttonRaporOlustur;
        private System.Windows.Forms.Button buttonDavaGelismesiGuncelle;
        private System.Windows.Forms.Button buttonDavaGelismesiSil;
        private System.Windows.Forms.Button buttonDavaGelismesiEkle;
        private System.Windows.Forms.ComboBox comboBoxMuvekkil_Isim;
        private System.Windows.Forms.ComboBox comboBoxDavaDurumu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePickerBaslangicTarihi;
        private System.Windows.Forms.DateTimePicker dateTimePickerBitisTarihi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonAraligaGoreGelismeBul;
        private System.Windows.Forms.Button buttonMuvekkileGoreGelismeAra;
        private System.Windows.Forms.Button buttonDavaDurumuAra;
        private System.Windows.Forms.Button buttonListele;
    }
}
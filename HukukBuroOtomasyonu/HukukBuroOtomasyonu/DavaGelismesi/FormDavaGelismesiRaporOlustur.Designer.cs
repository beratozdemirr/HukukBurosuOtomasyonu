﻿namespace HukukBuroOtomasyonu.DavaGelismesi
{
    partial class FormDavaGelismesiRaporOlustur
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDavaGelismesiRaporOlustur));
            this.dataGridViewDavaGelismeleri = new System.Windows.Forms.DataGridView();
            this.buttonRaporOlustur = new System.Windows.Forms.Button();
            this.buttonDavaDurumuAra = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxDavaDurumu = new System.Windows.Forms.ComboBox();
            this.buttonListele = new System.Windows.Forms.Button();
            this.buttonMuvekkileGoreGelismeAra = new System.Windows.Forms.Button();
            this.buttonAraligaGoreGelismeBul = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePickerBitisTarihi = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerBaslangicTarihi = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxMuvekkil_Isim = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDavaGelismeleri)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewDavaGelismeleri
            // 
            this.dataGridViewDavaGelismeleri.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridViewDavaGelismeleri.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDavaGelismeleri.Location = new System.Drawing.Point(1, 1);
            this.dataGridViewDavaGelismeleri.Name = "dataGridViewDavaGelismeleri";
            this.dataGridViewDavaGelismeleri.Size = new System.Drawing.Size(883, 355);
            this.dataGridViewDavaGelismeleri.TabIndex = 62;
            // 
            // buttonRaporOlustur
            // 
            this.buttonRaporOlustur.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonRaporOlustur.Location = new System.Drawing.Point(755, 520);
            this.buttonRaporOlustur.Name = "buttonRaporOlustur";
            this.buttonRaporOlustur.Size = new System.Drawing.Size(130, 42);
            this.buttonRaporOlustur.TabIndex = 89;
            this.buttonRaporOlustur.Text = "RAPOR OLUŞTUR";
            this.buttonRaporOlustur.UseVisualStyleBackColor = true;
            this.buttonRaporOlustur.Click += new System.EventHandler(this.buttonRaporOlustur_Click);
            // 
            // buttonDavaDurumuAra
            // 
            this.buttonDavaDurumuAra.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonDavaDurumuAra.BackgroundImage")));
            this.buttonDavaDurumuAra.Location = new System.Drawing.Point(749, 448);
            this.buttonDavaDurumuAra.Name = "buttonDavaDurumuAra";
            this.buttonDavaDurumuAra.Size = new System.Drawing.Size(40, 40);
            this.buttonDavaDurumuAra.TabIndex = 151;
            this.buttonDavaDurumuAra.UseVisualStyleBackColor = true;
            this.buttonDavaDurumuAra.Click += new System.EventHandler(this.buttonDavaDurumuAra_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(482, 462);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 150;
            this.label2.Text = "Dava Durumu";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // comboBoxDavaDurumu
            // 
            this.comboBoxDavaDurumu.FormattingEnabled = true;
            this.comboBoxDavaDurumu.Items.AddRange(new object[] {
            "ERTELENDİ",
            "SONUÇLANDI"});
            this.comboBoxDavaDurumu.Location = new System.Drawing.Point(571, 459);
            this.comboBoxDavaDurumu.Name = "comboBoxDavaDurumu";
            this.comboBoxDavaDurumu.Size = new System.Drawing.Size(172, 21);
            this.comboBoxDavaDurumu.TabIndex = 149;
            this.comboBoxDavaDurumu.SelectedIndexChanged += new System.EventHandler(this.comboBoxDavaDurumu_SelectedIndexChanged);
            // 
            // buttonListele
            // 
            this.buttonListele.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonListele.Location = new System.Drawing.Point(-1, 520);
            this.buttonListele.Name = "buttonListele";
            this.buttonListele.Size = new System.Drawing.Size(130, 42);
            this.buttonListele.TabIndex = 148;
            this.buttonListele.Text = "LİSTELE";
            this.buttonListele.UseVisualStyleBackColor = true;
            this.buttonListele.Click += new System.EventHandler(this.buttonListele_Click);
            // 
            // buttonMuvekkileGoreGelismeAra
            // 
            this.buttonMuvekkileGoreGelismeAra.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonMuvekkileGoreGelismeAra.BackgroundImage")));
            this.buttonMuvekkileGoreGelismeAra.Location = new System.Drawing.Point(404, 448);
            this.buttonMuvekkileGoreGelismeAra.Name = "buttonMuvekkileGoreGelismeAra";
            this.buttonMuvekkileGoreGelismeAra.Size = new System.Drawing.Size(40, 40);
            this.buttonMuvekkileGoreGelismeAra.TabIndex = 147;
            this.buttonMuvekkileGoreGelismeAra.UseVisualStyleBackColor = true;
            this.buttonMuvekkileGoreGelismeAra.Click += new System.EventHandler(this.buttonMuvekkileGoreGelismeAra_Click);
            // 
            // buttonAraligaGoreGelismeBul
            // 
            this.buttonAraligaGoreGelismeBul.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonAraligaGoreGelismeBul.BackgroundImage")));
            this.buttonAraligaGoreGelismeBul.Location = new System.Drawing.Point(686, 386);
            this.buttonAraligaGoreGelismeBul.Name = "buttonAraligaGoreGelismeBul";
            this.buttonAraligaGoreGelismeBul.Size = new System.Drawing.Size(40, 40);
            this.buttonAraligaGoreGelismeBul.TabIndex = 146;
            this.buttonAraligaGoreGelismeBul.UseVisualStyleBackColor = true;
            this.buttonAraligaGoreGelismeBul.Click += new System.EventHandler(this.buttonAraligaGoreGelismeBul_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(153, 400);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 145;
            this.label4.Text = "Tarih Aralığı";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(438, 395);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 25);
            this.label3.TabIndex = 144;
            this.label3.Text = "-";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // dateTimePickerBitisTarihi
            // 
            this.dateTimePickerBitisTarihi.Location = new System.Drawing.Point(463, 398);
            this.dateTimePickerBitisTarihi.Name = "dateTimePickerBitisTarihi";
            this.dateTimePickerBitisTarihi.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerBitisTarihi.TabIndex = 143;
            this.dateTimePickerBitisTarihi.ValueChanged += new System.EventHandler(this.dateTimePickerBitisTarihi_ValueChanged);
            // 
            // dateTimePickerBaslangicTarihi
            // 
            this.dateTimePickerBaslangicTarihi.Location = new System.Drawing.Point(232, 398);
            this.dateTimePickerBaslangicTarihi.Name = "dateTimePickerBaslangicTarihi";
            this.dateTimePickerBaslangicTarihi.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerBaslangicTarihi.TabIndex = 142;
            this.dateTimePickerBaslangicTarihi.ValueChanged += new System.EventHandler(this.dateTimePickerBaslangicTarihi_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(98, 462);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 141;
            this.label1.Text = "Müvekkil";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // comboBoxMuvekkil_Isim
            // 
            this.comboBoxMuvekkil_Isim.FormattingEnabled = true;
            this.comboBoxMuvekkil_Isim.Location = new System.Drawing.Point(168, 459);
            this.comboBoxMuvekkil_Isim.Name = "comboBoxMuvekkil_Isim";
            this.comboBoxMuvekkil_Isim.Size = new System.Drawing.Size(219, 21);
            this.comboBoxMuvekkil_Isim.TabIndex = 140;
            this.comboBoxMuvekkil_Isim.SelectedIndexChanged += new System.EventHandler(this.comboBoxMuvekkil_Isim_SelectedIndexChanged);
            // 
            // FormDavaGelismesiRaporOlustur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.buttonDavaDurumuAra);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxDavaDurumu);
            this.Controls.Add(this.buttonListele);
            this.Controls.Add(this.buttonMuvekkileGoreGelismeAra);
            this.Controls.Add(this.buttonAraligaGoreGelismeBul);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateTimePickerBitisTarihi);
            this.Controls.Add(this.dateTimePickerBaslangicTarihi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxMuvekkil_Isim);
            this.Controls.Add(this.buttonRaporOlustur);
            this.Controls.Add(this.dataGridViewDavaGelismeleri);
            this.Name = "FormDavaGelismesiRaporOlustur";
            this.Text = "DAVA GELİŞMESİ RAPORU OLUŞTUR";
            this.Load += new System.EventHandler(this.FormDavaGelismesiRaporOlustur_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDavaGelismeleri)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridViewDavaGelismeleri;
        private System.Windows.Forms.Button buttonRaporOlustur;
        private System.Windows.Forms.Button buttonDavaDurumuAra;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxDavaDurumu;
        private System.Windows.Forms.Button buttonListele;
        private System.Windows.Forms.Button buttonMuvekkileGoreGelismeAra;
        private System.Windows.Forms.Button buttonAraligaGoreGelismeBul;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePickerBitisTarihi;
        private System.Windows.Forms.DateTimePicker dateTimePickerBaslangicTarihi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxMuvekkil_Isim;
    }
}
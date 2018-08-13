namespace HukukBuroOtomasyonu.Personel_Islemleri
{
    partial class FormPersonelEkle
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
            this.textBoxPersonelAdSoyad = new System.Windows.Forms.TextBox();
            this.textBoxPersonelKullaniciAdi = new System.Windows.Forms.TextBox();
            this.textBoxPersonelSifre = new System.Windows.Forms.TextBox();
            this.comboBoxPersonelYetkisi = new System.Windows.Forms.ComboBox();
            this.groupBoxYetkiler = new System.Windows.Forms.GroupBox();
            this.checkBox_isKullanici_Islemleri = new System.Windows.Forms.CheckBox();
            this.checkBox_isRaporOlustur = new System.Windows.Forms.CheckBox();
            this.checkBox_isVeriSil = new System.Windows.Forms.CheckBox();
            this.checkBox_isVeriGuncelle = new System.Windows.Forms.CheckBox();
            this.checkBox_isVeriGir = new System.Windows.Forms.CheckBox();
            this.checkBox_isVeriOku = new System.Windows.Forms.CheckBox();
            this.groupBoxGirisBilgileri = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonKaydet = new System.Windows.Forms.Button();
            this.groupBoxYetkiler.SuspendLayout();
            this.groupBoxGirisBilgileri.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxPersonelAdSoyad
            // 
            this.textBoxPersonelAdSoyad.Location = new System.Drawing.Point(147, 153);
            this.textBoxPersonelAdSoyad.Name = "textBoxPersonelAdSoyad";
            this.textBoxPersonelAdSoyad.Size = new System.Drawing.Size(227, 20);
            this.textBoxPersonelAdSoyad.TabIndex = 0;
            // 
            // textBoxPersonelKullaniciAdi
            // 
            this.textBoxPersonelKullaniciAdi.Location = new System.Drawing.Point(92, 30);
            this.textBoxPersonelKullaniciAdi.Name = "textBoxPersonelKullaniciAdi";
            this.textBoxPersonelKullaniciAdi.Size = new System.Drawing.Size(227, 20);
            this.textBoxPersonelKullaniciAdi.TabIndex = 1;
            // 
            // textBoxPersonelSifre
            // 
            this.textBoxPersonelSifre.Location = new System.Drawing.Point(92, 87);
            this.textBoxPersonelSifre.Name = "textBoxPersonelSifre";
            this.textBoxPersonelSifre.Size = new System.Drawing.Size(227, 20);
            this.textBoxPersonelSifre.TabIndex = 2;
            // 
            // comboBoxPersonelYetkisi
            // 
            this.comboBoxPersonelYetkisi.FormattingEnabled = true;
            this.comboBoxPersonelYetkisi.Location = new System.Drawing.Point(546, 153);
            this.comboBoxPersonelYetkisi.Name = "comboBoxPersonelYetkisi";
            this.comboBoxPersonelYetkisi.Size = new System.Drawing.Size(155, 21);
            this.comboBoxPersonelYetkisi.TabIndex = 3;
            // 
            // groupBoxYetkiler
            // 
            this.groupBoxYetkiler.Controls.Add(this.checkBox_isKullanici_Islemleri);
            this.groupBoxYetkiler.Controls.Add(this.checkBox_isRaporOlustur);
            this.groupBoxYetkiler.Controls.Add(this.checkBox_isVeriSil);
            this.groupBoxYetkiler.Controls.Add(this.checkBox_isVeriGuncelle);
            this.groupBoxYetkiler.Controls.Add(this.checkBox_isVeriGir);
            this.groupBoxYetkiler.Controls.Add(this.checkBox_isVeriOku);
            this.groupBoxYetkiler.Location = new System.Drawing.Point(458, 235);
            this.groupBoxYetkiler.Name = "groupBoxYetkiler";
            this.groupBoxYetkiler.Size = new System.Drawing.Size(356, 90);
            this.groupBoxYetkiler.TabIndex = 20;
            this.groupBoxYetkiler.TabStop = false;
            this.groupBoxYetkiler.Text = "Yetkiler";
            // 
            // checkBox_isKullanici_Islemleri
            // 
            this.checkBox_isKullanici_Islemleri.AutoSize = true;
            this.checkBox_isKullanici_Islemleri.Location = new System.Drawing.Point(230, 52);
            this.checkBox_isKullanici_Islemleri.Name = "checkBox_isKullanici_Islemleri";
            this.checkBox_isKullanici_Islemleri.Size = new System.Drawing.Size(105, 17);
            this.checkBox_isKullanici_Islemleri.TabIndex = 5;
            this.checkBox_isKullanici_Islemleri.Text = "Kullanıcı İşlemleri";
            this.checkBox_isKullanici_Islemleri.UseVisualStyleBackColor = true;
            // 
            // checkBox_isRaporOlustur
            // 
            this.checkBox_isRaporOlustur.AutoSize = true;
            this.checkBox_isRaporOlustur.Location = new System.Drawing.Point(230, 19);
            this.checkBox_isRaporOlustur.Name = "checkBox_isRaporOlustur";
            this.checkBox_isRaporOlustur.Size = new System.Drawing.Size(91, 17);
            this.checkBox_isRaporOlustur.TabIndex = 4;
            this.checkBox_isRaporOlustur.Text = "Rapor Oluştur";
            this.checkBox_isRaporOlustur.UseVisualStyleBackColor = true;
            // 
            // checkBox_isVeriSil
            // 
            this.checkBox_isVeriSil.AutoSize = true;
            this.checkBox_isVeriSil.Location = new System.Drawing.Point(132, 52);
            this.checkBox_isVeriSil.Name = "checkBox_isVeriSil";
            this.checkBox_isVeriSil.Size = new System.Drawing.Size(58, 17);
            this.checkBox_isVeriSil.TabIndex = 3;
            this.checkBox_isVeriSil.Text = "Veri Sil";
            this.checkBox_isVeriSil.UseVisualStyleBackColor = true;
            // 
            // checkBox_isVeriGuncelle
            // 
            this.checkBox_isVeriGuncelle.AutoSize = true;
            this.checkBox_isVeriGuncelle.Location = new System.Drawing.Point(132, 19);
            this.checkBox_isVeriGuncelle.Name = "checkBox_isVeriGuncelle";
            this.checkBox_isVeriGuncelle.Size = new System.Drawing.Size(89, 17);
            this.checkBox_isVeriGuncelle.TabIndex = 2;
            this.checkBox_isVeriGuncelle.Text = "Veri Güncelle";
            this.checkBox_isVeriGuncelle.UseVisualStyleBackColor = true;
            // 
            // checkBox_isVeriGir
            // 
            this.checkBox_isVeriGir.AutoSize = true;
            this.checkBox_isVeriGir.Location = new System.Drawing.Point(19, 52);
            this.checkBox_isVeriGir.Name = "checkBox_isVeriGir";
            this.checkBox_isVeriGir.Size = new System.Drawing.Size(60, 17);
            this.checkBox_isVeriGir.TabIndex = 1;
            this.checkBox_isVeriGir.Text = "Veri Gir";
            this.checkBox_isVeriGir.UseVisualStyleBackColor = true;
            // 
            // checkBox_isVeriOku
            // 
            this.checkBox_isVeriOku.AutoSize = true;
            this.checkBox_isVeriOku.Location = new System.Drawing.Point(19, 19);
            this.checkBox_isVeriOku.Name = "checkBox_isVeriOku";
            this.checkBox_isVeriOku.Size = new System.Drawing.Size(67, 17);
            this.checkBox_isVeriOku.TabIndex = 0;
            this.checkBox_isVeriOku.Text = "Veri Oku";
            this.checkBox_isVeriOku.UseVisualStyleBackColor = true;
            // 
            // groupBoxGirisBilgileri
            // 
            this.groupBoxGirisBilgileri.Controls.Add(this.textBoxPersonelSifre);
            this.groupBoxGirisBilgileri.Controls.Add(this.label3);
            this.groupBoxGirisBilgileri.Controls.Add(this.textBoxPersonelKullaniciAdi);
            this.groupBoxGirisBilgileri.Controls.Add(this.label2);
            this.groupBoxGirisBilgileri.Location = new System.Drawing.Point(55, 205);
            this.groupBoxGirisBilgileri.Name = "groupBoxGirisBilgileri";
            this.groupBoxGirisBilgileri.Size = new System.Drawing.Size(351, 131);
            this.groupBoxGirisBilgileri.TabIndex = 21;
            this.groupBoxGirisBilgileri.TabStop = false;
            this.groupBoxGirisBilgileri.Text = "Giriş Bilgileri";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "Şifre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Kullanıcı Adı";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(77, 156);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Ad Soyad";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(455, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "Personel Yetkisi";
            // 
            // buttonKaydet
            // 
            this.buttonKaydet.Location = new System.Drawing.Point(403, 429);
            this.buttonKaydet.Name = "buttonKaydet";
            this.buttonKaydet.Size = new System.Drawing.Size(116, 49);
            this.buttonKaydet.TabIndex = 26;
            this.buttonKaydet.Text = "KAYDET";
            this.buttonKaydet.UseVisualStyleBackColor = true;
            this.buttonKaydet.Click += new System.EventHandler(this.buttonKaydet_Click);
            // 
            // FormPersonelEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.buttonKaydet);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBoxGirisBilgileri);
            this.Controls.Add(this.groupBoxYetkiler);
            this.Controls.Add(this.comboBoxPersonelYetkisi);
            this.Controls.Add(this.textBoxPersonelAdSoyad);
            this.Name = "FormPersonelEkle";
            this.Text = "PERSONEL EKLE";
            this.Load += new System.EventHandler(this.FormPersonelEkle_Load);
            this.groupBoxYetkiler.ResumeLayout(false);
            this.groupBoxYetkiler.PerformLayout();
            this.groupBoxGirisBilgileri.ResumeLayout(false);
            this.groupBoxGirisBilgileri.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxPersonelAdSoyad;
        private System.Windows.Forms.TextBox textBoxPersonelKullaniciAdi;
        private System.Windows.Forms.TextBox textBoxPersonelSifre;
        private System.Windows.Forms.ComboBox comboBoxPersonelYetkisi;
        private System.Windows.Forms.GroupBox groupBoxYetkiler;
        private System.Windows.Forms.CheckBox checkBox_isKullanici_Islemleri;
        private System.Windows.Forms.CheckBox checkBox_isRaporOlustur;
        private System.Windows.Forms.CheckBox checkBox_isVeriSil;
        private System.Windows.Forms.CheckBox checkBox_isVeriGuncelle;
        private System.Windows.Forms.CheckBox checkBox_isVeriGir;
        private System.Windows.Forms.CheckBox checkBox_isVeriOku;
        private System.Windows.Forms.GroupBox groupBoxGirisBilgileri;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonKaydet;
    }
}
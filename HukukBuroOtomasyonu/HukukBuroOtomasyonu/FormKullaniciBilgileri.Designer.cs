namespace HukukBuroOtomasyonu
{
    partial class FormKullaniciBilgileri
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
            this.textBoxKullaniciAdi = new System.Windows.Forms.TextBox();
            this.textBoxKullaniciSifre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBoxYetkiler = new System.Windows.Forms.GroupBox();
            this.checkBox_isKullanici_Islemleri = new System.Windows.Forms.CheckBox();
            this.checkBox_isRaporOlustur = new System.Windows.Forms.CheckBox();
            this.checkBox_isVeriSil = new System.Windows.Forms.CheckBox();
            this.checkBox_isVeriGuncelle = new System.Windows.Forms.CheckBox();
            this.checkBox_isVeriGir = new System.Windows.Forms.CheckBox();
            this.checkBox_isVeriOku = new System.Windows.Forms.CheckBox();
            this.dataGridViewKullaniciBilgileri = new System.Windows.Forms.DataGridView();
            this.groupBoxYetkiler.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKullaniciBilgileri)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxKullaniciAdi
            // 
            this.textBoxKullaniciAdi.Location = new System.Drawing.Point(234, 200);
            this.textBoxKullaniciAdi.Name = "textBoxKullaniciAdi";
            this.textBoxKullaniciAdi.Size = new System.Drawing.Size(186, 20);
            this.textBoxKullaniciAdi.TabIndex = 0;
            // 
            // textBoxKullaniciSifre
            // 
            this.textBoxKullaniciSifre.Location = new System.Drawing.Point(534, 200);
            this.textBoxKullaniciSifre.Name = "textBoxKullaniciSifre";
            this.textBoxKullaniciSifre.Size = new System.Drawing.Size(188, 20);
            this.textBoxKullaniciSifre.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(164, 203);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Kullanıcı Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(455, 203);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Kullanıcı Şifre\r\n";
            // 
            // groupBoxYetkiler
            // 
            this.groupBoxYetkiler.Controls.Add(this.checkBox_isKullanici_Islemleri);
            this.groupBoxYetkiler.Controls.Add(this.checkBox_isRaporOlustur);
            this.groupBoxYetkiler.Controls.Add(this.checkBox_isVeriSil);
            this.groupBoxYetkiler.Controls.Add(this.checkBox_isVeriGuncelle);
            this.groupBoxYetkiler.Controls.Add(this.checkBox_isVeriGir);
            this.groupBoxYetkiler.Controls.Add(this.checkBox_isVeriOku);
            this.groupBoxYetkiler.Location = new System.Drawing.Point(282, 278);
            this.groupBoxYetkiler.Name = "groupBoxYetkiler";
            this.groupBoxYetkiler.Size = new System.Drawing.Size(356, 90);
            this.groupBoxYetkiler.TabIndex = 21;
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
            // dataGridViewKullaniciBilgileri
            // 
            this.dataGridViewKullaniciBilgileri.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewKullaniciBilgileri.Location = new System.Drawing.Point(12, 23);
            this.dataGridViewKullaniciBilgileri.Name = "dataGridViewKullaniciBilgileri";
            this.dataGridViewKullaniciBilgileri.Size = new System.Drawing.Size(860, 150);
            this.dataGridViewKullaniciBilgileri.TabIndex = 22;
            // 
            // FormKullaniciBilgileri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.dataGridViewKullaniciBilgileri);
            this.Controls.Add(this.groupBoxYetkiler);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxKullaniciSifre);
            this.Controls.Add(this.textBoxKullaniciAdi);
            this.Name = "FormKullaniciBilgileri";
            this.Text = "KULLANICI BİLGİLERİ";
            this.Load += new System.EventHandler(this.FormKullaniciBilgileri_Load);
            this.groupBoxYetkiler.ResumeLayout(false);
            this.groupBoxYetkiler.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKullaniciBilgileri)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox textBoxKullaniciAdi;
        public System.Windows.Forms.TextBox textBoxKullaniciSifre;
        public System.Windows.Forms.GroupBox groupBoxYetkiler;
        public System.Windows.Forms.CheckBox checkBox_isKullanici_Islemleri;
        public System.Windows.Forms.CheckBox checkBox_isRaporOlustur;
        public System.Windows.Forms.CheckBox checkBox_isVeriSil;
        public System.Windows.Forms.CheckBox checkBox_isVeriGuncelle;
        public System.Windows.Forms.CheckBox checkBox_isVeriGir;
        public System.Windows.Forms.CheckBox checkBox_isVeriOku;
        public System.Windows.Forms.DataGridView dataGridViewKullaniciBilgileri;
    }
}
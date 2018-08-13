namespace HukukBuroOtomasyonu.KarsiTaraf
{
    partial class FormKarsiTarafEkle
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
            this.buttonKaydetKurulus = new System.Windows.Forms.Button();
            this.buttonKaydetKisi = new System.Windows.Forms.Button();
            this.groupBoxİletisimBilgileri = new System.Windows.Forms.GroupBox();
            this.textBoxKarsiTarafTelefonNo = new System.Windows.Forms.TextBox();
            this.textBoxKarsiTarafAdres = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxKurulus_Isim = new System.Windows.Forms.TextBox();
            this.textBoxKurulusVergiNo = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBoxKisiselBilgilerKurulus = new System.Windows.Forms.GroupBox();
            this.groupBoxKisiselBilgilerKisi = new System.Windows.Forms.GroupBox();
            this.textBoxKisi_Isim = new System.Windows.Forms.TextBox();
            this.comboBoxKisiCinsiyet = new System.Windows.Forms.ComboBox();
            this.textBoxKisiTCNo = new System.Windows.Forms.TextBox();
            this.textBoxKisiSicilNo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelMuvekkil_Isim = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxKarsiTarafSecimi = new System.Windows.Forms.ComboBox();
            this.comboBoxKarsiTarafTipi = new System.Windows.Forms.ComboBox();
            this.buttonKarsiTarafSec = new System.Windows.Forms.Button();
            this.groupBoxİletisimBilgileri.SuspendLayout();
            this.groupBoxKisiselBilgilerKurulus.SuspendLayout();
            this.groupBoxKisiselBilgilerKisi.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonKaydetKurulus
            // 
            this.buttonKaydetKurulus.Location = new System.Drawing.Point(648, 419);
            this.buttonKaydetKurulus.Name = "buttonKaydetKurulus";
            this.buttonKaydetKurulus.Size = new System.Drawing.Size(111, 43);
            this.buttonKaydetKurulus.TabIndex = 38;
            this.buttonKaydetKurulus.Text = "KAYDET";
            this.buttonKaydetKurulus.UseVisualStyleBackColor = true;
            this.buttonKaydetKurulus.Visible = false;
            this.buttonKaydetKurulus.Click += new System.EventHandler(this.buttonKaydetKurulus_Click);
            // 
            // buttonKaydetKisi
            // 
            this.buttonKaydetKisi.Location = new System.Drawing.Point(648, 419);
            this.buttonKaydetKisi.Name = "buttonKaydetKisi";
            this.buttonKaydetKisi.Size = new System.Drawing.Size(111, 43);
            this.buttonKaydetKisi.TabIndex = 35;
            this.buttonKaydetKisi.Text = "KAYDET";
            this.buttonKaydetKisi.UseVisualStyleBackColor = true;
            this.buttonKaydetKisi.Visible = false;
            this.buttonKaydetKisi.Click += new System.EventHandler(this.buttonKaydetKisi_Click);
            // 
            // groupBoxİletisimBilgileri
            // 
            this.groupBoxİletisimBilgileri.Controls.Add(this.textBoxKarsiTarafTelefonNo);
            this.groupBoxİletisimBilgileri.Controls.Add(this.textBoxKarsiTarafAdres);
            this.groupBoxİletisimBilgileri.Controls.Add(this.label8);
            this.groupBoxİletisimBilgileri.Controls.Add(this.label7);
            this.groupBoxİletisimBilgileri.Location = new System.Drawing.Point(29, 351);
            this.groupBoxİletisimBilgileri.Name = "groupBoxİletisimBilgileri";
            this.groupBoxİletisimBilgileri.Size = new System.Drawing.Size(348, 184);
            this.groupBoxİletisimBilgileri.TabIndex = 34;
            this.groupBoxİletisimBilgileri.TabStop = false;
            this.groupBoxİletisimBilgileri.Text = "İletişim Bilgileri";
            // 
            // textBoxKarsiTarafTelefonNo
            // 
            this.textBoxKarsiTarafTelefonNo.Location = new System.Drawing.Point(87, 28);
            this.textBoxKarsiTarafTelefonNo.Name = "textBoxKarsiTarafTelefonNo";
            this.textBoxKarsiTarafTelefonNo.Size = new System.Drawing.Size(241, 20);
            this.textBoxKarsiTarafTelefonNo.TabIndex = 5;
            // 
            // textBoxKarsiTarafAdres
            // 
            this.textBoxKarsiTarafAdres.Location = new System.Drawing.Point(87, 80);
            this.textBoxKarsiTarafAdres.Multiline = true;
            this.textBoxKarsiTarafAdres.Name = "textBoxKarsiTarafAdres";
            this.textBoxKarsiTarafAdres.Size = new System.Drawing.Size(241, 93);
            this.textBoxKarsiTarafAdres.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(17, 83);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Adres";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(5, 35);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Telefon No";
            // 
            // textBoxKurulus_Isim
            // 
            this.textBoxKurulus_Isim.Location = new System.Drawing.Point(129, 76);
            this.textBoxKurulus_Isim.Name = "textBoxKurulus_Isim";
            this.textBoxKurulus_Isim.Size = new System.Drawing.Size(241, 20);
            this.textBoxKurulus_Isim.TabIndex = 0;
            // 
            // textBoxKurulusVergiNo
            // 
            this.textBoxKurulusVergiNo.Location = new System.Drawing.Point(127, 156);
            this.textBoxKurulusVergiNo.Name = "textBoxKurulusVergiNo";
            this.textBoxKurulusVergiNo.Size = new System.Drawing.Size(241, 20);
            this.textBoxKurulusVergiNo.TabIndex = 8;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(22, 79);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(79, 13);
            this.label11.TabIndex = 9;
            this.label11.Text = "Karşı Taraf İsim";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(34, 159);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(48, 13);
            this.label12.TabIndex = 13;
            this.label12.Text = "Vergi No";
            // 
            // groupBoxKisiselBilgilerKurulus
            // 
            this.groupBoxKisiselBilgilerKurulus.Controls.Add(this.textBoxKurulus_Isim);
            this.groupBoxKisiselBilgilerKurulus.Controls.Add(this.textBoxKurulusVergiNo);
            this.groupBoxKisiselBilgilerKurulus.Controls.Add(this.label11);
            this.groupBoxKisiselBilgilerKurulus.Controls.Add(this.label12);
            this.groupBoxKisiselBilgilerKurulus.Location = new System.Drawing.Point(455, 81);
            this.groupBoxKisiselBilgilerKurulus.Name = "groupBoxKisiselBilgilerKurulus";
            this.groupBoxKisiselBilgilerKurulus.Size = new System.Drawing.Size(401, 236);
            this.groupBoxKisiselBilgilerKurulus.TabIndex = 37;
            this.groupBoxKisiselBilgilerKurulus.TabStop = false;
            this.groupBoxKisiselBilgilerKurulus.Text = "Kurumsal Bilgiler";
            // 
            // groupBoxKisiselBilgilerKisi
            // 
            this.groupBoxKisiselBilgilerKisi.Controls.Add(this.textBoxKisi_Isim);
            this.groupBoxKisiselBilgilerKisi.Controls.Add(this.comboBoxKisiCinsiyet);
            this.groupBoxKisiselBilgilerKisi.Controls.Add(this.textBoxKisiTCNo);
            this.groupBoxKisiselBilgilerKisi.Controls.Add(this.textBoxKisiSicilNo);
            this.groupBoxKisiselBilgilerKisi.Controls.Add(this.label5);
            this.groupBoxKisiselBilgilerKisi.Controls.Add(this.label4);
            this.groupBoxKisiselBilgilerKisi.Controls.Add(this.labelMuvekkil_Isim);
            this.groupBoxKisiselBilgilerKisi.Controls.Add(this.label2);
            this.groupBoxKisiselBilgilerKisi.Location = new System.Drawing.Point(29, 81);
            this.groupBoxKisiselBilgilerKisi.Name = "groupBoxKisiselBilgilerKisi";
            this.groupBoxKisiselBilgilerKisi.Size = new System.Drawing.Size(401, 236);
            this.groupBoxKisiselBilgilerKisi.TabIndex = 33;
            this.groupBoxKisiselBilgilerKisi.TabStop = false;
            this.groupBoxKisiselBilgilerKisi.Text = "Kişisel Bilgiler";
            // 
            // textBoxKisi_Isim
            // 
            this.textBoxKisi_Isim.Location = new System.Drawing.Point(129, 19);
            this.textBoxKisi_Isim.Name = "textBoxKisi_Isim";
            this.textBoxKisi_Isim.Size = new System.Drawing.Size(241, 20);
            this.textBoxKisi_Isim.TabIndex = 0;
            // 
            // comboBoxKisiCinsiyet
            // 
            this.comboBoxKisiCinsiyet.FormattingEnabled = true;
            this.comboBoxKisiCinsiyet.Items.AddRange(new object[] {
            "BAY",
            "BAYAN"});
            this.comboBoxKisiCinsiyet.Location = new System.Drawing.Point(129, 185);
            this.comboBoxKisiCinsiyet.Name = "comboBoxKisiCinsiyet";
            this.comboBoxKisiCinsiyet.Size = new System.Drawing.Size(121, 21);
            this.comboBoxKisiCinsiyet.TabIndex = 1;
            // 
            // textBoxKisiTCNo
            // 
            this.textBoxKisiTCNo.Location = new System.Drawing.Point(129, 76);
            this.textBoxKisiTCNo.Name = "textBoxKisiTCNo";
            this.textBoxKisiTCNo.Size = new System.Drawing.Size(241, 20);
            this.textBoxKisiTCNo.TabIndex = 2;
            // 
            // textBoxKisiSicilNo
            // 
            this.textBoxKisiSicilNo.Location = new System.Drawing.Point(129, 130);
            this.textBoxKisiSicilNo.Name = "textBoxKisiSicilNo";
            this.textBoxKisiSicilNo.Size = new System.Drawing.Size(241, 20);
            this.textBoxKisiSicilNo.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(41, 188);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Cinsiyet";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Sicil No";
            // 
            // labelMuvekkil_Isim
            // 
            this.labelMuvekkil_Isim.AutoSize = true;
            this.labelMuvekkil_Isim.Location = new System.Drawing.Point(18, 23);
            this.labelMuvekkil_Isim.Name = "labelMuvekkil_Isim";
            this.labelMuvekkil_Isim.Size = new System.Drawing.Size(79, 13);
            this.labelMuvekkil_Isim.TabIndex = 9;
            this.labelMuvekkil_Isim.Text = "Karşı Taraf İsim";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "TC Kimlik No";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(475, 364);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 13);
            this.label6.TabIndex = 32;
            this.label6.Text = "Karşı Taraf Tipi";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 31;
            this.label1.Text = "Karşı Taraf";
            // 
            // comboBoxKarsiTarafSecimi
            // 
            this.comboBoxKarsiTarafSecimi.FormattingEnabled = true;
            this.comboBoxKarsiTarafSecimi.Items.AddRange(new object[] {
            "KİŞİ",
            "KURULUŞ"});
            this.comboBoxKarsiTarafSecimi.Location = new System.Drawing.Point(132, 33);
            this.comboBoxKarsiTarafSecimi.Name = "comboBoxKarsiTarafSecimi";
            this.comboBoxKarsiTarafSecimi.Size = new System.Drawing.Size(133, 21);
            this.comboBoxKarsiTarafSecimi.TabIndex = 30;
            // 
            // comboBoxKarsiTarafTipi
            // 
            this.comboBoxKarsiTarafTipi.FormattingEnabled = true;
            this.comboBoxKarsiTarafTipi.Items.AddRange(new object[] {
            "ALACAKLI",
            "BORÇLU",
            "HİSSEDAR",
            "DAVALI"});
            this.comboBoxKarsiTarafTipi.Location = new System.Drawing.Point(577, 361);
            this.comboBoxKarsiTarafTipi.Name = "comboBoxKarsiTarafTipi";
            this.comboBoxKarsiTarafTipi.Size = new System.Drawing.Size(241, 21);
            this.comboBoxKarsiTarafTipi.TabIndex = 29;
            // 
            // buttonKarsiTarafSec
            // 
            this.buttonKarsiTarafSec.Location = new System.Drawing.Point(302, 25);
            this.buttonKarsiTarafSec.Name = "buttonKarsiTarafSec";
            this.buttonKarsiTarafSec.Size = new System.Drawing.Size(75, 34);
            this.buttonKarsiTarafSec.TabIndex = 39;
            this.buttonKarsiTarafSec.Text = "SEÇ";
            this.buttonKarsiTarafSec.UseVisualStyleBackColor = true;
            this.buttonKarsiTarafSec.Click += new System.EventHandler(this.buttonKarsiTarafSec_Click);
            // 
            // FormKarsiTarafEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.buttonKarsiTarafSec);
            this.Controls.Add(this.buttonKaydetKurulus);
            this.Controls.Add(this.buttonKaydetKisi);
            this.Controls.Add(this.groupBoxİletisimBilgileri);
            this.Controls.Add(this.groupBoxKisiselBilgilerKurulus);
            this.Controls.Add(this.groupBoxKisiselBilgilerKisi);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxKarsiTarafSecimi);
            this.Controls.Add(this.comboBoxKarsiTarafTipi);
            this.Name = "FormKarsiTarafEkle";
            this.Text = "KARŞI TARAF EKLE";
            this.groupBoxİletisimBilgileri.ResumeLayout(false);
            this.groupBoxİletisimBilgileri.PerformLayout();
            this.groupBoxKisiselBilgilerKurulus.ResumeLayout(false);
            this.groupBoxKisiselBilgilerKurulus.PerformLayout();
            this.groupBoxKisiselBilgilerKisi.ResumeLayout(false);
            this.groupBoxKisiselBilgilerKisi.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonKaydetKurulus;
        private System.Windows.Forms.Button buttonKaydetKisi;
        private System.Windows.Forms.GroupBox groupBoxİletisimBilgileri;
        private System.Windows.Forms.TextBox textBoxKarsiTarafTelefonNo;
        private System.Windows.Forms.TextBox textBoxKarsiTarafAdres;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxKurulus_Isim;
        private System.Windows.Forms.TextBox textBoxKurulusVergiNo;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBoxKisiselBilgilerKurulus;
        private System.Windows.Forms.GroupBox groupBoxKisiselBilgilerKisi;
        private System.Windows.Forms.TextBox textBoxKisi_Isim;
        private System.Windows.Forms.ComboBox comboBoxKisiCinsiyet;
        private System.Windows.Forms.TextBox textBoxKisiTCNo;
        private System.Windows.Forms.TextBox textBoxKisiSicilNo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelMuvekkil_Isim;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxKarsiTarafSecimi;
        private System.Windows.Forms.ComboBox comboBoxKarsiTarafTipi;
        private System.Windows.Forms.Button buttonKarsiTarafSec;
    }
}
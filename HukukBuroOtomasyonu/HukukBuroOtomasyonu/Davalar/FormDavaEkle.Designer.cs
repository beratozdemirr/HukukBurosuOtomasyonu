namespace HukukBuroOtomasyonu.Davalar
{
    partial class FormDavaEkle
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
            this.textBoxDavaNo = new System.Windows.Forms.TextBox();
            this.comboBoxDavaTuru = new System.Windows.Forms.ComboBox();
            this.textBoxMuvekkilTalebi = new System.Windows.Forms.TextBox();
            this.textBoxOturumSaati = new System.Windows.Forms.TextBox();
            this.textBoxDavaTutari = new System.Windows.Forms.TextBox();
            this.textBoxSalonNo = new System.Windows.Forms.TextBox();
            this.dateTimePickeDavaBaslangicTarihi = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerGelecekOturumTarihi = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.comboBoxMuvekkil_Isim = new System.Windows.Forms.ComboBox();
            this.comboBoxKarsiTaraf_Isim = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBoxTaraflar = new System.Windows.Forms.GroupBox();
            this.checkBoxKTOnay = new System.Windows.Forms.CheckBox();
            this.checkBoxMuvOnay = new System.Windows.Forms.CheckBox();
            this.textBoxKarsiTaraf_ID = new System.Windows.Forms.TextBox();
            this.textBoxMuvekkil_ID = new System.Windows.Forms.TextBox();
            this.groupBoxDavaBilgileri = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.comboBoxAdliyeBinasi = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.textBoxAdliyeAdresi = new System.Windows.Forms.TextBox();
            this.groupBoxOturumBilgileri = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBoxAdresBilgileri = new System.Windows.Forms.GroupBox();
            this.checkBoxAdliyeOnay = new System.Windows.Forms.CheckBox();
            this.textBoxAdliye_ID = new System.Windows.Forms.TextBox();
            this.buttonKaydet = new System.Windows.Forms.Button();
            this.textBoxPersonel_ID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBoxTaraflar.SuspendLayout();
            this.groupBoxDavaBilgileri.SuspendLayout();
            this.groupBoxOturumBilgileri.SuspendLayout();
            this.groupBoxAdresBilgileri.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxDavaNo
            // 
            this.textBoxDavaNo.Location = new System.Drawing.Point(143, 27);
            this.textBoxDavaNo.Name = "textBoxDavaNo";
            this.textBoxDavaNo.Size = new System.Drawing.Size(191, 20);
            this.textBoxDavaNo.TabIndex = 0;
            // 
            // comboBoxDavaTuru
            // 
            this.comboBoxDavaTuru.FormattingEnabled = true;
            this.comboBoxDavaTuru.Items.AddRange(new object[] {
            "KİRA DAVALARI",
            "AİLE DAVALARI",
            "MİRAS DAVALARI",
            "BORÇ DAVALARI",
            "ŞİRKET DAVALARI",
            "İCRA DAVALARI",
            "KİŞİLİK HAKLARI DAVALARI"});
            this.comboBoxDavaTuru.Location = new System.Drawing.Point(118, 92);
            this.comboBoxDavaTuru.Name = "comboBoxDavaTuru";
            this.comboBoxDavaTuru.Size = new System.Drawing.Size(253, 21);
            this.comboBoxDavaTuru.TabIndex = 1;
            // 
            // textBoxMuvekkilTalebi
            // 
            this.textBoxMuvekkilTalebi.Location = new System.Drawing.Point(120, 173);
            this.textBoxMuvekkilTalebi.Multiline = true;
            this.textBoxMuvekkilTalebi.Name = "textBoxMuvekkilTalebi";
            this.textBoxMuvekkilTalebi.Size = new System.Drawing.Size(255, 91);
            this.textBoxMuvekkilTalebi.TabIndex = 3;
            // 
            // textBoxOturumSaati
            // 
            this.textBoxOturumSaati.Location = new System.Drawing.Point(146, 93);
            this.textBoxOturumSaati.Name = "textBoxOturumSaati";
            this.textBoxOturumSaati.Size = new System.Drawing.Size(121, 20);
            this.textBoxOturumSaati.TabIndex = 4;
            // 
            // textBoxDavaTutari
            // 
            this.textBoxDavaTutari.Location = new System.Drawing.Point(118, 301);
            this.textBoxDavaTutari.Name = "textBoxDavaTutari";
            this.textBoxDavaTutari.Size = new System.Drawing.Size(255, 20);
            this.textBoxDavaTutari.TabIndex = 5;
            // 
            // textBoxSalonNo
            // 
            this.textBoxSalonNo.Location = new System.Drawing.Point(115, 217);
            this.textBoxSalonNo.Name = "textBoxSalonNo";
            this.textBoxSalonNo.Size = new System.Drawing.Size(100, 20);
            this.textBoxSalonNo.TabIndex = 6;
            // 
            // dateTimePickeDavaBaslangicTarihi
            // 
            this.dateTimePickeDavaBaslangicTarihi.Location = new System.Drawing.Point(120, 40);
            this.dateTimePickeDavaBaslangicTarihi.Name = "dateTimePickeDavaBaslangicTarihi";
            this.dateTimePickeDavaBaslangicTarihi.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickeDavaBaslangicTarihi.TabIndex = 7;
            // 
            // dateTimePickerGelecekOturumTarihi
            // 
            this.dateTimePickerGelecekOturumTarihi.Location = new System.Drawing.Point(146, 47);
            this.dateTimePickerGelecekOturumTarihi.Name = "dateTimePickerGelecekOturumTarihi";
            this.dateTimePickerGelecekOturumTarihi.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerGelecekOturumTarihi.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(39, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Dava Numarası";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(14, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Başlangıç Tarihi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(21, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Dava Türü";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(5, 173);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Müvekkil Talebi";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(7, 50);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(134, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Gelecek Oturum Tarihi";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(42, 96);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Oturum Saati";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(16, 304);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "Dava Tutarı";
            // 
            // comboBoxMuvekkil_Isim
            // 
            this.comboBoxMuvekkil_Isim.FormattingEnabled = true;
            this.comboBoxMuvekkil_Isim.Location = new System.Drawing.Point(118, 18);
            this.comboBoxMuvekkil_Isim.Name = "comboBoxMuvekkil_Isim";
            this.comboBoxMuvekkil_Isim.Size = new System.Drawing.Size(253, 21);
            this.comboBoxMuvekkil_Isim.TabIndex = 21;
            // 
            // comboBoxKarsiTaraf_Isim
            // 
            this.comboBoxKarsiTaraf_Isim.FormattingEnabled = true;
            this.comboBoxKarsiTaraf_Isim.Location = new System.Drawing.Point(118, 63);
            this.comboBoxKarsiTaraf_Isim.Name = "comboBoxKarsiTaraf_Isim";
            this.comboBoxKarsiTaraf_Isim.Size = new System.Drawing.Size(253, 21);
            this.comboBoxKarsiTaraf_Isim.TabIndex = 22;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(38, 21);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 13);
            this.label10.TabIndex = 23;
            this.label10.Text = "Müvekkil";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(34, 66);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(69, 13);
            this.label11.TabIndex = 24;
            this.label11.Text = "Karşı Taraf";
            // 
            // groupBoxTaraflar
            // 
            this.groupBoxTaraflar.Controls.Add(this.checkBoxKTOnay);
            this.groupBoxTaraflar.Controls.Add(this.checkBoxMuvOnay);
            this.groupBoxTaraflar.Controls.Add(this.textBoxKarsiTaraf_ID);
            this.groupBoxTaraflar.Controls.Add(this.textBoxMuvekkil_ID);
            this.groupBoxTaraflar.Controls.Add(this.comboBoxKarsiTaraf_Isim);
            this.groupBoxTaraflar.Controls.Add(this.label11);
            this.groupBoxTaraflar.Controls.Add(this.comboBoxMuvekkil_Isim);
            this.groupBoxTaraflar.Controls.Add(this.label10);
            this.groupBoxTaraflar.Location = new System.Drawing.Point(23, 74);
            this.groupBoxTaraflar.Name = "groupBoxTaraflar";
            this.groupBoxTaraflar.Size = new System.Drawing.Size(409, 100);
            this.groupBoxTaraflar.TabIndex = 25;
            this.groupBoxTaraflar.TabStop = false;
            this.groupBoxTaraflar.Text = "TARAFLAR";
            // 
            // checkBoxKTOnay
            // 
            this.checkBoxKTOnay.AutoSize = true;
            this.checkBoxKTOnay.Location = new System.Drawing.Point(381, 68);
            this.checkBoxKTOnay.Name = "checkBoxKTOnay";
            this.checkBoxKTOnay.Size = new System.Drawing.Size(15, 14);
            this.checkBoxKTOnay.TabIndex = 39;
            this.checkBoxKTOnay.UseVisualStyleBackColor = true;
            this.checkBoxKTOnay.CheckedChanged += new System.EventHandler(this.checkBoxKTOnay_CheckedChanged);
            // 
            // checkBoxMuvOnay
            // 
            this.checkBoxMuvOnay.AutoSize = true;
            this.checkBoxMuvOnay.Location = new System.Drawing.Point(381, 23);
            this.checkBoxMuvOnay.Name = "checkBoxMuvOnay";
            this.checkBoxMuvOnay.Size = new System.Drawing.Size(15, 14);
            this.checkBoxMuvOnay.TabIndex = 38;
            this.checkBoxMuvOnay.UseVisualStyleBackColor = true;
            this.checkBoxMuvOnay.CheckedChanged += new System.EventHandler(this.checkBoxMuvOnay_CheckedChanged);
            // 
            // textBoxKarsiTaraf_ID
            // 
            this.textBoxKarsiTaraf_ID.Location = new System.Drawing.Point(6, 63);
            this.textBoxKarsiTaraf_ID.Name = "textBoxKarsiTaraf_ID";
            this.textBoxKarsiTaraf_ID.Size = new System.Drawing.Size(31, 20);
            this.textBoxKarsiTaraf_ID.TabIndex = 37;
            // 
            // textBoxMuvekkil_ID
            // 
            this.textBoxMuvekkil_ID.Location = new System.Drawing.Point(6, 18);
            this.textBoxMuvekkil_ID.Name = "textBoxMuvekkil_ID";
            this.textBoxMuvekkil_ID.Size = new System.Drawing.Size(33, 20);
            this.textBoxMuvekkil_ID.TabIndex = 36;
            // 
            // groupBoxDavaBilgileri
            // 
            this.groupBoxDavaBilgileri.Controls.Add(this.textBoxMuvekkilTalebi);
            this.groupBoxDavaBilgileri.Controls.Add(this.comboBoxDavaTuru);
            this.groupBoxDavaBilgileri.Controls.Add(this.label9);
            this.groupBoxDavaBilgileri.Controls.Add(this.textBoxDavaTutari);
            this.groupBoxDavaBilgileri.Controls.Add(this.dateTimePickeDavaBaslangicTarihi);
            this.groupBoxDavaBilgileri.Controls.Add(this.label2);
            this.groupBoxDavaBilgileri.Controls.Add(this.label5);
            this.groupBoxDavaBilgileri.Controls.Add(this.label3);
            this.groupBoxDavaBilgileri.Location = new System.Drawing.Point(23, 191);
            this.groupBoxDavaBilgileri.Name = "groupBoxDavaBilgileri";
            this.groupBoxDavaBilgileri.Size = new System.Drawing.Size(409, 358);
            this.groupBoxDavaBilgileri.TabIndex = 26;
            this.groupBoxDavaBilgileri.TabStop = false;
            this.groupBoxDavaBilgileri.Text = "DAVA BİLGİLERİ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.Location = new System.Drawing.Point(19, 220);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(95, 13);
            this.label12.TabIndex = 27;
            this.label12.Text = "Salon Numarası";
            // 
            // comboBoxAdliyeBinasi
            // 
            this.comboBoxAdliyeBinasi.FormattingEnabled = true;
            this.comboBoxAdliyeBinasi.Location = new System.Drawing.Point(115, 29);
            this.comboBoxAdliyeBinasi.Name = "comboBoxAdliyeBinasi";
            this.comboBoxAdliyeBinasi.Size = new System.Drawing.Size(248, 21);
            this.comboBoxAdliyeBinasi.TabIndex = 28;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.Location = new System.Drawing.Point(30, 32);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(79, 13);
            this.label13.TabIndex = 29;
            this.label13.Text = "Adliye Binası";
            // 
            // textBoxAdliyeAdresi
            // 
            this.textBoxAdliyeAdresi.Location = new System.Drawing.Point(115, 89);
            this.textBoxAdliyeAdresi.Multiline = true;
            this.textBoxAdliyeAdresi.Name = "textBoxAdliyeAdresi";
            this.textBoxAdliyeAdresi.Size = new System.Drawing.Size(248, 91);
            this.textBoxAdliyeAdresi.TabIndex = 30;
            // 
            // groupBoxOturumBilgileri
            // 
            this.groupBoxOturumBilgileri.Controls.Add(this.textBoxOturumSaati);
            this.groupBoxOturumBilgileri.Controls.Add(this.dateTimePickerGelecekOturumTarihi);
            this.groupBoxOturumBilgileri.Controls.Add(this.label7);
            this.groupBoxOturumBilgileri.Controls.Add(this.label8);
            this.groupBoxOturumBilgileri.Location = new System.Drawing.Point(479, 74);
            this.groupBoxOturumBilgileri.Name = "groupBoxOturumBilgileri";
            this.groupBoxOturumBilgileri.Size = new System.Drawing.Size(393, 138);
            this.groupBoxOturumBilgileri.TabIndex = 31;
            this.groupBoxOturumBilgileri.TabStop = false;
            this.groupBoxOturumBilgileri.Text = "OTURUM BİLGİLERİ";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label14.Location = new System.Drawing.Point(48, 92);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(39, 13);
            this.label14.TabIndex = 32;
            this.label14.Text = "Adres";
            // 
            // groupBoxAdresBilgileri
            // 
            this.groupBoxAdresBilgileri.Controls.Add(this.checkBoxAdliyeOnay);
            this.groupBoxAdresBilgileri.Controls.Add(this.textBoxAdliye_ID);
            this.groupBoxAdresBilgileri.Controls.Add(this.textBoxAdliyeAdresi);
            this.groupBoxAdresBilgileri.Controls.Add(this.label14);
            this.groupBoxAdresBilgileri.Controls.Add(this.textBoxSalonNo);
            this.groupBoxAdresBilgileri.Controls.Add(this.label12);
            this.groupBoxAdresBilgileri.Controls.Add(this.comboBoxAdliyeBinasi);
            this.groupBoxAdresBilgileri.Controls.Add(this.label13);
            this.groupBoxAdresBilgileri.Location = new System.Drawing.Point(479, 231);
            this.groupBoxAdresBilgileri.Name = "groupBoxAdresBilgileri";
            this.groupBoxAdresBilgileri.Size = new System.Drawing.Size(393, 261);
            this.groupBoxAdresBilgileri.TabIndex = 33;
            this.groupBoxAdresBilgileri.TabStop = false;
            this.groupBoxAdresBilgileri.Text = "ADRES BİLGİLERİ";
            // 
            // checkBoxAdliyeOnay
            // 
            this.checkBoxAdliyeOnay.AutoSize = true;
            this.checkBoxAdliyeOnay.Location = new System.Drawing.Point(369, 32);
            this.checkBoxAdliyeOnay.Name = "checkBoxAdliyeOnay";
            this.checkBoxAdliyeOnay.Size = new System.Drawing.Size(15, 14);
            this.checkBoxAdliyeOnay.TabIndex = 39;
            this.checkBoxAdliyeOnay.UseVisualStyleBackColor = true;
            this.checkBoxAdliyeOnay.CheckedChanged += new System.EventHandler(this.checkBoxAdliyeOnay_CheckedChanged);
            // 
            // textBoxAdliye_ID
            // 
            this.textBoxAdliye_ID.Location = new System.Drawing.Point(0, 29);
            this.textBoxAdliye_ID.Name = "textBoxAdliye_ID";
            this.textBoxAdliye_ID.Size = new System.Drawing.Size(33, 20);
            this.textBoxAdliye_ID.TabIndex = 38;
            // 
            // buttonKaydet
            // 
            this.buttonKaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonKaydet.Location = new System.Drawing.Point(635, 508);
            this.buttonKaydet.Name = "buttonKaydet";
            this.buttonKaydet.Size = new System.Drawing.Size(115, 41);
            this.buttonKaydet.TabIndex = 34;
            this.buttonKaydet.Text = "KAYDET";
            this.buttonKaydet.UseVisualStyleBackColor = true;
            this.buttonKaydet.Click += new System.EventHandler(this.buttonKaydet_Click);
            // 
            // textBoxPersonel_ID
            // 
            this.textBoxPersonel_ID.Location = new System.Drawing.Point(594, 27);
            this.textBoxPersonel_ID.Name = "textBoxPersonel_ID";
            this.textBoxPersonel_ID.Size = new System.Drawing.Size(145, 20);
            this.textBoxPersonel_ID.TabIndex = 35;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(509, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 36;
            this.label4.Text = "Personel No";
            // 
            // FormDavaEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxPersonel_ID);
            this.Controls.Add(this.buttonKaydet);
            this.Controls.Add(this.groupBoxAdresBilgileri);
            this.Controls.Add(this.groupBoxOturumBilgileri);
            this.Controls.Add(this.groupBoxDavaBilgileri);
            this.Controls.Add(this.groupBoxTaraflar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxDavaNo);
            this.Name = "FormDavaEkle";
            this.Text = "DAVA EKLE";
            this.Load += new System.EventHandler(this.FormDavaEkle_Load);
            this.groupBoxTaraflar.ResumeLayout(false);
            this.groupBoxTaraflar.PerformLayout();
            this.groupBoxDavaBilgileri.ResumeLayout(false);
            this.groupBoxDavaBilgileri.PerformLayout();
            this.groupBoxOturumBilgileri.ResumeLayout(false);
            this.groupBoxOturumBilgileri.PerformLayout();
            this.groupBoxAdresBilgileri.ResumeLayout(false);
            this.groupBoxAdresBilgileri.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxDavaNo;
        private System.Windows.Forms.ComboBox comboBoxDavaTuru;
        private System.Windows.Forms.TextBox textBoxMuvekkilTalebi;
        private System.Windows.Forms.TextBox textBoxOturumSaati;
        private System.Windows.Forms.TextBox textBoxDavaTutari;
        private System.Windows.Forms.TextBox textBoxSalonNo;
        private System.Windows.Forms.DateTimePicker dateTimePickeDavaBaslangicTarihi;
        private System.Windows.Forms.DateTimePicker dateTimePickerGelecekOturumTarihi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboBoxMuvekkil_Isim;
        private System.Windows.Forms.ComboBox comboBoxKarsiTaraf_Isim;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBoxTaraflar;
        private System.Windows.Forms.GroupBox groupBoxDavaBilgileri;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox comboBoxAdliyeBinasi;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBoxAdliyeAdresi;
        private System.Windows.Forms.GroupBox groupBoxOturumBilgileri;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.GroupBox groupBoxAdresBilgileri;
        private System.Windows.Forms.Button buttonKaydet;
        private System.Windows.Forms.TextBox textBoxPersonel_ID;
        private System.Windows.Forms.TextBox textBoxMuvekkil_ID;
        private System.Windows.Forms.TextBox textBoxKarsiTaraf_ID;
        private System.Windows.Forms.TextBox textBoxAdliye_ID;
        private System.Windows.Forms.CheckBox checkBoxKTOnay;
        private System.Windows.Forms.CheckBox checkBoxMuvOnay;
        private System.Windows.Forms.CheckBox checkBoxAdliyeOnay;
        private System.Windows.Forms.Label label4;
    }
}
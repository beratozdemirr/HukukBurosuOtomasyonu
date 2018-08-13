namespace HukukBuroOtomasyonu.DavaSonucu
{
    partial class FormDavaSonucuGuncelle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDavaSonucuGuncelle));
            this.buttonGuncelle = new System.Windows.Forms.Button();
            this.dataGridViewDavaSonuclari = new System.Windows.Forms.DataGridView();
            this.buttonMuvekkileGoreGelismeAra = new System.Windows.Forms.Button();
            this.buttonAraligaGoreGelismeBul = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePickerBitisTarihi = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerBaslangicTarihi = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxDavaSonucu = new System.Windows.Forms.ComboBox();
            this.comboBoxMuvekkil_Isim = new System.Windows.Forms.ComboBox();
            this.buttonListele = new System.Windows.Forms.Button();
            this.buttonDavaSonucuAra = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDavaSonuclari)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonGuncelle
            // 
            this.buttonGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonGuncelle.Location = new System.Drawing.Point(775, 523);
            this.buttonGuncelle.Name = "buttonGuncelle";
            this.buttonGuncelle.Size = new System.Drawing.Size(110, 39);
            this.buttonGuncelle.TabIndex = 54;
            this.buttonGuncelle.Text = "GÜNCELLE";
            this.buttonGuncelle.UseVisualStyleBackColor = true;
            this.buttonGuncelle.Click += new System.EventHandler(this.buttonGuncelle_Click);
            // 
            // dataGridViewDavaSonuclari
            // 
            this.dataGridViewDavaSonuclari.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridViewDavaSonuclari.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDavaSonuclari.Location = new System.Drawing.Point(0, 2);
            this.dataGridViewDavaSonuclari.Name = "dataGridViewDavaSonuclari";
            this.dataGridViewDavaSonuclari.Size = new System.Drawing.Size(883, 361);
            this.dataGridViewDavaSonuclari.TabIndex = 45;
            // 
            // buttonMuvekkileGoreGelismeAra
            // 
            this.buttonMuvekkileGoreGelismeAra.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonMuvekkileGoreGelismeAra.BackgroundImage")));
            this.buttonMuvekkileGoreGelismeAra.Location = new System.Drawing.Point(417, 459);
            this.buttonMuvekkileGoreGelismeAra.Name = "buttonMuvekkileGoreGelismeAra";
            this.buttonMuvekkileGoreGelismeAra.Size = new System.Drawing.Size(40, 40);
            this.buttonMuvekkileGoreGelismeAra.TabIndex = 142;
            this.buttonMuvekkileGoreGelismeAra.UseVisualStyleBackColor = true;
            this.buttonMuvekkileGoreGelismeAra.Click += new System.EventHandler(this.buttonMuvekkileGoreGelismeAra_Click);
            // 
            // buttonAraligaGoreGelismeBul
            // 
            this.buttonAraligaGoreGelismeBul.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonAraligaGoreGelismeBul.BackgroundImage")));
            this.buttonAraligaGoreGelismeBul.Location = new System.Drawing.Point(705, 387);
            this.buttonAraligaGoreGelismeBul.Name = "buttonAraligaGoreGelismeBul";
            this.buttonAraligaGoreGelismeBul.Size = new System.Drawing.Size(40, 40);
            this.buttonAraligaGoreGelismeBul.TabIndex = 141;
            this.buttonAraligaGoreGelismeBul.UseVisualStyleBackColor = true;
            this.buttonAraligaGoreGelismeBul.Click += new System.EventHandler(this.buttonAraligaGoreGelismeBul_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(179, 397);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 140;
            this.label4.Text = "Tarih Aralığı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(463, 392);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 25);
            this.label3.TabIndex = 139;
            this.label3.Text = "-";
            // 
            // dateTimePickerBitisTarihi
            // 
            this.dateTimePickerBitisTarihi.Location = new System.Drawing.Point(488, 395);
            this.dateTimePickerBitisTarihi.Name = "dateTimePickerBitisTarihi";
            this.dateTimePickerBitisTarihi.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerBitisTarihi.TabIndex = 138;
            // 
            // dateTimePickerBaslangicTarihi
            // 
            this.dateTimePickerBaslangicTarihi.Location = new System.Drawing.Point(257, 395);
            this.dateTimePickerBaslangicTarihi.Name = "dateTimePickerBaslangicTarihi";
            this.dateTimePickerBaslangicTarihi.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerBaslangicTarihi.TabIndex = 137;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(501, 473);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 136;
            this.label2.Text = "Dava Sonucu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(85, 473);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 135;
            this.label1.Text = "Müvekkil İsim";
            // 
            // comboBoxDavaSonucu
            // 
            this.comboBoxDavaSonucu.FormattingEnabled = true;
            this.comboBoxDavaSonucu.Items.AddRange(new object[] {
            "BAŞARILI",
            "BAŞARISIZ"});
            this.comboBoxDavaSonucu.Location = new System.Drawing.Point(590, 470);
            this.comboBoxDavaSonucu.Name = "comboBoxDavaSonucu";
            this.comboBoxDavaSonucu.Size = new System.Drawing.Size(172, 21);
            this.comboBoxDavaSonucu.TabIndex = 134;
            // 
            // comboBoxMuvekkil_Isim
            // 
            this.comboBoxMuvekkil_Isim.FormattingEnabled = true;
            this.comboBoxMuvekkil_Isim.Location = new System.Drawing.Point(175, 470);
            this.comboBoxMuvekkil_Isim.Name = "comboBoxMuvekkil_Isim";
            this.comboBoxMuvekkil_Isim.Size = new System.Drawing.Size(219, 21);
            this.comboBoxMuvekkil_Isim.TabIndex = 133;
            // 
            // buttonListele
            // 
            this.buttonListele.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonListele.Location = new System.Drawing.Point(-1, 523);
            this.buttonListele.Name = "buttonListele";
            this.buttonListele.Size = new System.Drawing.Size(117, 39);
            this.buttonListele.TabIndex = 144;
            this.buttonListele.Text = "LİSTELE";
            this.buttonListele.UseVisualStyleBackColor = true;
            this.buttonListele.Click += new System.EventHandler(this.buttonListele_Click);
            // 
            // buttonDavaSonucuAra
            // 
            this.buttonDavaSonucuAra.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonDavaSonucuAra.BackgroundImage")));
            this.buttonDavaSonucuAra.Location = new System.Drawing.Point(775, 459);
            this.buttonDavaSonucuAra.Name = "buttonDavaSonucuAra";
            this.buttonDavaSonucuAra.Size = new System.Drawing.Size(40, 40);
            this.buttonDavaSonucuAra.TabIndex = 145;
            this.buttonDavaSonucuAra.UseVisualStyleBackColor = true;
            this.buttonDavaSonucuAra.Click += new System.EventHandler(this.buttonDavaSonucuAra_Click);
            // 
            // FormDavaSonucuGuncelle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.buttonDavaSonucuAra);
            this.Controls.Add(this.buttonListele);
            this.Controls.Add(this.buttonMuvekkileGoreGelismeAra);
            this.Controls.Add(this.buttonAraligaGoreGelismeBul);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateTimePickerBitisTarihi);
            this.Controls.Add(this.dateTimePickerBaslangicTarihi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxDavaSonucu);
            this.Controls.Add(this.comboBoxMuvekkil_Isim);
            this.Controls.Add(this.buttonGuncelle);
            this.Controls.Add(this.dataGridViewDavaSonuclari);
            this.Name = "FormDavaSonucuGuncelle";
            this.Text = "DAVA SONUCU GUNCELLE";
            this.Load += new System.EventHandler(this.FormDavaSonucuGuncelle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDavaSonuclari)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonGuncelle;
        private System.Windows.Forms.DataGridView dataGridViewDavaSonuclari;
        private System.Windows.Forms.Button buttonMuvekkileGoreGelismeAra;
        private System.Windows.Forms.Button buttonAraligaGoreGelismeBul;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePickerBitisTarihi;
        private System.Windows.Forms.DateTimePicker dateTimePickerBaslangicTarihi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxDavaSonucu;
        private System.Windows.Forms.ComboBox comboBoxMuvekkil_Isim;
        private System.Windows.Forms.Button buttonListele;
        private System.Windows.Forms.Button buttonDavaSonucuAra;
    }
}
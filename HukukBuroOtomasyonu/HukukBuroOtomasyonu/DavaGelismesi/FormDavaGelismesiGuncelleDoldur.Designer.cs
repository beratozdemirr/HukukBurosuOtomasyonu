namespace HukukBuroOtomasyonu.DavaGelismesi
{
    partial class FormDavaGelismesiGuncelleDoldur
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
            this.buttonGuncelle = new System.Windows.Forms.Button();
            this.groupBoxGelismeBilgileri = new System.Windows.Forms.GroupBox();
            this.textBoxGelismeAciklamasi = new System.Windows.Forms.TextBox();
            this.dateTimePickerGelismeTarihi = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxDavaDurumu = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxGelismeNo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxMuvekkilNo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxDavaNo = new System.Windows.Forms.TextBox();
            this.groupBoxGelismeBilgileri.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonGuncelle
            // 
            this.buttonGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonGuncelle.Location = new System.Drawing.Point(435, 417);
            this.buttonGuncelle.Name = "buttonGuncelle";
            this.buttonGuncelle.Size = new System.Drawing.Size(121, 47);
            this.buttonGuncelle.TabIndex = 38;
            this.buttonGuncelle.Text = "GÜNCELLE";
            this.buttonGuncelle.UseVisualStyleBackColor = true;
            this.buttonGuncelle.Click += new System.EventHandler(this.buttonGuncelle_Click);
            // 
            // groupBoxGelismeBilgileri
            // 
            this.groupBoxGelismeBilgileri.Controls.Add(this.textBoxGelismeAciklamasi);
            this.groupBoxGelismeBilgileri.Controls.Add(this.dateTimePickerGelismeTarihi);
            this.groupBoxGelismeBilgileri.Controls.Add(this.label4);
            this.groupBoxGelismeBilgileri.Controls.Add(this.comboBoxDavaDurumu);
            this.groupBoxGelismeBilgileri.Controls.Add(this.label3);
            this.groupBoxGelismeBilgileri.Controls.Add(this.label2);
            this.groupBoxGelismeBilgileri.Location = new System.Drawing.Point(263, 106);
            this.groupBoxGelismeBilgileri.Name = "groupBoxGelismeBilgileri";
            this.groupBoxGelismeBilgileri.Size = new System.Drawing.Size(423, 275);
            this.groupBoxGelismeBilgileri.TabIndex = 37;
            this.groupBoxGelismeBilgileri.TabStop = false;
            this.groupBoxGelismeBilgileri.Text = "Gelişme Bilgileri";
            // 
            // textBoxGelismeAciklamasi
            // 
            this.textBoxGelismeAciklamasi.Location = new System.Drawing.Point(125, 157);
            this.textBoxGelismeAciklamasi.Multiline = true;
            this.textBoxGelismeAciklamasi.Name = "textBoxGelismeAciklamasi";
            this.textBoxGelismeAciklamasi.Size = new System.Drawing.Size(277, 99);
            this.textBoxGelismeAciklamasi.TabIndex = 28;
            // 
            // dateTimePickerGelismeTarihi
            // 
            this.dateTimePickerGelismeTarihi.Location = new System.Drawing.Point(125, 19);
            this.dateTimePickerGelismeTarihi.Name = "dateTimePickerGelismeTarihi";
            this.dateTimePickerGelismeTarihi.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerGelismeTarihi.TabIndex = 29;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(37, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 33;
            this.label4.Text = "Dava Durumu";
            // 
            // comboBoxDavaDurumu
            // 
            this.comboBoxDavaDurumu.FormattingEnabled = true;
            this.comboBoxDavaDurumu.Location = new System.Drawing.Point(125, 75);
            this.comboBoxDavaDurumu.Name = "comboBoxDavaDurumu";
            this.comboBoxDavaDurumu.Size = new System.Drawing.Size(200, 21);
            this.comboBoxDavaDurumu.TabIndex = 30;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(37, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 32;
            this.label3.Text = "Gelişme Tarihi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(9, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 13);
            this.label2.TabIndex = 31;
            this.label2.Text = "Gelişme Açıklaması";
            // 
            // textBoxGelismeNo
            // 
            this.textBoxGelismeNo.Location = new System.Drawing.Point(240, 60);
            this.textBoxGelismeNo.Name = "textBoxGelismeNo";
            this.textBoxGelismeNo.Size = new System.Drawing.Size(119, 20);
            this.textBoxGelismeNo.TabIndex = 39;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(163, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 40;
            this.label1.Text = "Gelişme No";
            // 
            // textBoxMuvekkilNo
            // 
            this.textBoxMuvekkilNo.Location = new System.Drawing.Point(469, 60);
            this.textBoxMuvekkilNo.Name = "textBoxMuvekkilNo";
            this.textBoxMuvekkilNo.Size = new System.Drawing.Size(119, 20);
            this.textBoxMuvekkilNo.TabIndex = 41;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(385, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 42;
            this.label5.Text = "Müvekkil No";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(621, 63);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 43;
            this.label6.Text = "Dava No";
            // 
            // textBoxDavaNo
            // 
            this.textBoxDavaNo.Location = new System.Drawing.Point(684, 60);
            this.textBoxDavaNo.Name = "textBoxDavaNo";
            this.textBoxDavaNo.Size = new System.Drawing.Size(119, 20);
            this.textBoxDavaNo.TabIndex = 44;
            // 
            // FormDavaGelismesiGuncelleDoldur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.textBoxDavaNo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxMuvekkilNo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxGelismeNo);
            this.Controls.Add(this.buttonGuncelle);
            this.Controls.Add(this.groupBoxGelismeBilgileri);
            this.Name = "FormDavaGelismesiGuncelleDoldur";
            this.Text = "DAVA GELİŞMESİ GÜNCELLEME FORMU";
            this.groupBoxGelismeBilgileri.ResumeLayout(false);
            this.groupBoxGelismeBilgileri.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonGuncelle;
        private System.Windows.Forms.GroupBox groupBoxGelismeBilgileri;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox textBoxGelismeAciklamasi;
        public System.Windows.Forms.DateTimePicker dateTimePickerGelismeTarihi;
        public System.Windows.Forms.ComboBox comboBoxDavaDurumu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox textBoxGelismeNo;
        public System.Windows.Forms.TextBox textBoxMuvekkilNo;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox textBoxDavaNo;
    }
}
namespace HukukBuroOtomasyonu.DavaSonucu
{
    partial class FormDavaSonucuGuncelleDoldur
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
            this.dateTimePickerSonucTarihi = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxDavaSonucu = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxDavaSonuc_ID = new System.Windows.Forms.TextBox();
            this.textBoxMuvekkil_ID = new System.Windows.Forms.TextBox();
            this.textBoxKarsiTaraf_ID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBoxGelismeBilgileri.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonGuncelle
            // 
            this.buttonGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonGuncelle.Location = new System.Drawing.Point(402, 376);
            this.buttonGuncelle.Name = "buttonGuncelle";
            this.buttonGuncelle.Size = new System.Drawing.Size(121, 47);
            this.buttonGuncelle.TabIndex = 40;
            this.buttonGuncelle.Text = "GÜNCELLE";
            this.buttonGuncelle.UseVisualStyleBackColor = true;
            this.buttonGuncelle.Click += new System.EventHandler(this.buttonGuncelle_Click);
            // 
            // groupBoxGelismeBilgileri
            // 
            this.groupBoxGelismeBilgileri.Controls.Add(this.dateTimePickerSonucTarihi);
            this.groupBoxGelismeBilgileri.Controls.Add(this.label4);
            this.groupBoxGelismeBilgileri.Controls.Add(this.comboBoxDavaSonucu);
            this.groupBoxGelismeBilgileri.Controls.Add(this.label3);
            this.groupBoxGelismeBilgileri.Location = new System.Drawing.Point(256, 149);
            this.groupBoxGelismeBilgileri.Name = "groupBoxGelismeBilgileri";
            this.groupBoxGelismeBilgileri.Size = new System.Drawing.Size(410, 146);
            this.groupBoxGelismeBilgileri.TabIndex = 39;
            this.groupBoxGelismeBilgileri.TabStop = false;
            this.groupBoxGelismeBilgileri.Text = "Dava Sonucu Bilgileri";
            // 
            // dateTimePickerSonucTarihi
            // 
            this.dateTimePickerSonucTarihi.Location = new System.Drawing.Point(146, 39);
            this.dateTimePickerSonucTarihi.Name = "dateTimePickerSonucTarihi";
            this.dateTimePickerSonucTarihi.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerSonucTarihi.TabIndex = 29;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(58, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 33;
            this.label4.Text = "Dava Sonucu";
            // 
            // comboBoxDavaSonucu
            // 
            this.comboBoxDavaSonucu.FormattingEnabled = true;
            this.comboBoxDavaSonucu.Items.AddRange(new object[] {
            "BAŞARILI",
            "BAŞARISIZ"});
            this.comboBoxDavaSonucu.Location = new System.Drawing.Point(146, 95);
            this.comboBoxDavaSonucu.Name = "comboBoxDavaSonucu";
            this.comboBoxDavaSonucu.Size = new System.Drawing.Size(200, 21);
            this.comboBoxDavaSonucu.TabIndex = 30;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(58, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 32;
            this.label3.Text = "Sonuç Tarihi";
            // 
            // textBoxDavaSonuc_ID
            // 
            this.textBoxDavaSonuc_ID.Location = new System.Drawing.Point(227, 98);
            this.textBoxDavaSonuc_ID.Name = "textBoxDavaSonuc_ID";
            this.textBoxDavaSonuc_ID.ReadOnly = true;
            this.textBoxDavaSonuc_ID.Size = new System.Drawing.Size(100, 20);
            this.textBoxDavaSonuc_ID.TabIndex = 41;
            // 
            // textBoxMuvekkil_ID
            // 
            this.textBoxMuvekkil_ID.Location = new System.Drawing.Point(434, 98);
            this.textBoxMuvekkil_ID.Name = "textBoxMuvekkil_ID";
            this.textBoxMuvekkil_ID.ReadOnly = true;
            this.textBoxMuvekkil_ID.Size = new System.Drawing.Size(100, 20);
            this.textBoxMuvekkil_ID.TabIndex = 42;
            // 
            // textBoxKarsiTaraf_ID
            // 
            this.textBoxKarsiTaraf_ID.Location = new System.Drawing.Point(651, 98);
            this.textBoxKarsiTaraf_ID.Name = "textBoxKarsiTaraf_ID";
            this.textBoxKarsiTaraf_ID.ReadOnly = true;
            this.textBoxKarsiTaraf_ID.Size = new System.Drawing.Size(100, 20);
            this.textBoxKarsiTaraf_ID.TabIndex = 43;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(158, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 44;
            this.label1.Text = "Sonuç No";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(351, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 45;
            this.label2.Text = "Müvekkil No";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(559, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 13);
            this.label5.TabIndex = 46;
            this.label5.Text = "Karşı Taraf No";
            // 
            // FormDavaSonucuGuncelleDoldur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxKarsiTaraf_ID);
            this.Controls.Add(this.textBoxMuvekkil_ID);
            this.Controls.Add(this.textBoxDavaSonuc_ID);
            this.Controls.Add(this.buttonGuncelle);
            this.Controls.Add(this.groupBoxGelismeBilgileri);
            this.Name = "FormDavaSonucuGuncelleDoldur";
            this.Text = "DAVA SONUCU GÜNCELLEME FORMU";
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
        public System.Windows.Forms.DateTimePicker dateTimePickerSonucTarihi;
        public System.Windows.Forms.ComboBox comboBoxDavaSonucu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox textBoxDavaSonuc_ID;
        public System.Windows.Forms.TextBox textBoxMuvekkil_ID;
        public System.Windows.Forms.TextBox textBoxKarsiTaraf_ID;
    }
}
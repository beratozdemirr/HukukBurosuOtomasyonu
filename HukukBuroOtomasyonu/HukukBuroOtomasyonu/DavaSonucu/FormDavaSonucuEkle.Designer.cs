namespace HukukBuroOtomasyonu.DavaSonucu
{
    partial class FormDavaSonucuEkle
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
            this.label10 = new System.Windows.Forms.Label();
            this.comboBoxMuvekkil_Isim = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePickerSonucTarihi = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxDavaSonucu = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonKaydet = new System.Windows.Forms.Button();
            this.groupBoxGelismeBilgileri = new System.Windows.Forms.GroupBox();
            this.groupBoxDavaBilgileri = new System.Windows.Forms.GroupBox();
            this.checkBoxKarsiTarafOnay = new System.Windows.Forms.CheckBox();
            this.checkBoxMuvekkilOnayla = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxKarsiTarafSec = new System.Windows.Forms.ComboBox();
            this.textBoxMuvekkil_ID = new System.Windows.Forms.TextBox();
            this.textBoxKarsiTaraf_ID = new System.Windows.Forms.TextBox();
            this.textBoxDavaIDGir = new System.Windows.Forms.TextBox();
            this.groupBoxGelismeBilgileri.SuspendLayout();
            this.groupBoxDavaBilgileri.SuspendLayout();
            this.SuspendLayout();
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(15, 33);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 13);
            this.label10.TabIndex = 25;
            this.label10.Text = "Müvekkil";
            // 
            // comboBoxMuvekkil_Isim
            // 
            this.comboBoxMuvekkil_Isim.FormattingEnabled = true;
            this.comboBoxMuvekkil_Isim.Location = new System.Drawing.Point(93, 30);
            this.comboBoxMuvekkil_Isim.Name = "comboBoxMuvekkil_Isim";
            this.comboBoxMuvekkil_Isim.Size = new System.Drawing.Size(253, 21);
            this.comboBoxMuvekkil_Isim.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(15, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "Dava ID";
            // 
            // dateTimePickerSonucTarihi
            // 
            this.dateTimePickerSonucTarihi.Location = new System.Drawing.Point(115, 28);
            this.dateTimePickerSonucTarihi.Name = "dateTimePickerSonucTarihi";
            this.dateTimePickerSonucTarihi.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerSonucTarihi.TabIndex = 29;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(27, 77);
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
            this.comboBoxDavaSonucu.Location = new System.Drawing.Point(115, 74);
            this.comboBoxDavaSonucu.Name = "comboBoxDavaSonucu";
            this.comboBoxDavaSonucu.Size = new System.Drawing.Size(200, 21);
            this.comboBoxDavaSonucu.TabIndex = 30;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(27, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 32;
            this.label3.Text = "Sonuç Tarihi";
            // 
            // buttonKaydet
            // 
            this.buttonKaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonKaydet.Location = new System.Drawing.Point(406, 452);
            this.buttonKaydet.Name = "buttonKaydet";
            this.buttonKaydet.Size = new System.Drawing.Size(121, 47);
            this.buttonKaydet.TabIndex = 39;
            this.buttonKaydet.Text = "KAYDET";
            this.buttonKaydet.UseVisualStyleBackColor = true;
            this.buttonKaydet.Click += new System.EventHandler(this.buttonKaydet_Click);
            // 
            // groupBoxGelismeBilgileri
            // 
            this.groupBoxGelismeBilgileri.Controls.Add(this.dateTimePickerSonucTarihi);
            this.groupBoxGelismeBilgileri.Controls.Add(this.label4);
            this.groupBoxGelismeBilgileri.Controls.Add(this.comboBoxDavaSonucu);
            this.groupBoxGelismeBilgileri.Controls.Add(this.label3);
            this.groupBoxGelismeBilgileri.Location = new System.Drawing.Point(275, 277);
            this.groupBoxGelismeBilgileri.Name = "groupBoxGelismeBilgileri";
            this.groupBoxGelismeBilgileri.Size = new System.Drawing.Size(368, 125);
            this.groupBoxGelismeBilgileri.TabIndex = 38;
            this.groupBoxGelismeBilgileri.TabStop = false;
            this.groupBoxGelismeBilgileri.Text = "Dava Sonuç Bilgileri";
            // 
            // groupBoxDavaBilgileri
            // 
            this.groupBoxDavaBilgileri.Controls.Add(this.textBoxDavaIDGir);
            this.groupBoxDavaBilgileri.Controls.Add(this.checkBoxKarsiTarafOnay);
            this.groupBoxDavaBilgileri.Controls.Add(this.checkBoxMuvekkilOnayla);
            this.groupBoxDavaBilgileri.Controls.Add(this.label2);
            this.groupBoxDavaBilgileri.Controls.Add(this.comboBoxKarsiTarafSec);
            this.groupBoxDavaBilgileri.Controls.Add(this.label10);
            this.groupBoxDavaBilgileri.Controls.Add(this.comboBoxMuvekkil_Isim);
            this.groupBoxDavaBilgileri.Controls.Add(this.label1);
            this.groupBoxDavaBilgileri.Location = new System.Drawing.Point(275, 57);
            this.groupBoxDavaBilgileri.Name = "groupBoxDavaBilgileri";
            this.groupBoxDavaBilgileri.Size = new System.Drawing.Size(368, 173);
            this.groupBoxDavaBilgileri.TabIndex = 37;
            this.groupBoxDavaBilgileri.TabStop = false;
            this.groupBoxDavaBilgileri.Text = "Dava Bilgileri";
            // 
            // checkBoxKarsiTarafOnay
            // 
            this.checkBoxKarsiTarafOnay.AutoSize = true;
            this.checkBoxKarsiTarafOnay.Location = new System.Drawing.Point(350, 83);
            this.checkBoxKarsiTarafOnay.Name = "checkBoxKarsiTarafOnay";
            this.checkBoxKarsiTarafOnay.Size = new System.Drawing.Size(15, 14);
            this.checkBoxKarsiTarafOnay.TabIndex = 44;
            this.checkBoxKarsiTarafOnay.UseVisualStyleBackColor = true;
            this.checkBoxKarsiTarafOnay.CheckedChanged += new System.EventHandler(this.checkBoxKarsiTarafOnay_CheckedChanged);
            // 
            // checkBoxMuvekkilOnayla
            // 
            this.checkBoxMuvekkilOnayla.AutoSize = true;
            this.checkBoxMuvekkilOnayla.Location = new System.Drawing.Point(350, 33);
            this.checkBoxMuvekkilOnayla.Name = "checkBoxMuvekkilOnayla";
            this.checkBoxMuvekkilOnayla.Size = new System.Drawing.Size(15, 14);
            this.checkBoxMuvekkilOnayla.TabIndex = 43;
            this.checkBoxMuvekkilOnayla.UseVisualStyleBackColor = true;
            this.checkBoxMuvekkilOnayla.CheckedChanged += new System.EventHandler(this.checkBoxMuvekkilOnayla_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(15, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 29;
            this.label2.Text = "Karşı Taraf";
            // 
            // comboBoxKarsiTarafSec
            // 
            this.comboBoxKarsiTarafSec.FormattingEnabled = true;
            this.comboBoxKarsiTarafSec.Location = new System.Drawing.Point(93, 79);
            this.comboBoxKarsiTarafSec.Name = "comboBoxKarsiTarafSec";
            this.comboBoxKarsiTarafSec.Size = new System.Drawing.Size(253, 21);
            this.comboBoxKarsiTarafSec.TabIndex = 28;
            // 
            // textBoxMuvekkil_ID
            // 
            this.textBoxMuvekkil_ID.Location = new System.Drawing.Point(191, 87);
            this.textBoxMuvekkil_ID.Name = "textBoxMuvekkil_ID";
            this.textBoxMuvekkil_ID.Size = new System.Drawing.Size(78, 20);
            this.textBoxMuvekkil_ID.TabIndex = 40;
            // 
            // textBoxKarsiTaraf_ID
            // 
            this.textBoxKarsiTaraf_ID.Location = new System.Drawing.Point(191, 136);
            this.textBoxKarsiTaraf_ID.Name = "textBoxKarsiTaraf_ID";
            this.textBoxKarsiTaraf_ID.Size = new System.Drawing.Size(78, 20);
            this.textBoxKarsiTaraf_ID.TabIndex = 42;
            // 
            // textBoxDavaIDGir
            // 
            this.textBoxDavaIDGir.Location = new System.Drawing.Point(93, 130);
            this.textBoxDavaIDGir.Name = "textBoxDavaIDGir";
            this.textBoxDavaIDGir.Size = new System.Drawing.Size(143, 20);
            this.textBoxDavaIDGir.TabIndex = 45;
            // 
            // FormDavaSonucuEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.textBoxKarsiTaraf_ID);
            this.Controls.Add(this.textBoxMuvekkil_ID);
            this.Controls.Add(this.buttonKaydet);
            this.Controls.Add(this.groupBoxGelismeBilgileri);
            this.Controls.Add(this.groupBoxDavaBilgileri);
            this.Name = "FormDavaSonucuEkle";
            this.Text = "DAVA SONUCU EKLE";
            this.Load += new System.EventHandler(this.FormDavaSonucuEkle_Load);
            this.groupBoxGelismeBilgileri.ResumeLayout(false);
            this.groupBoxGelismeBilgileri.PerformLayout();
            this.groupBoxDavaBilgileri.ResumeLayout(false);
            this.groupBoxDavaBilgileri.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox comboBoxMuvekkil_Isim;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePickerSonucTarihi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxDavaSonucu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonKaydet;
        private System.Windows.Forms.GroupBox groupBoxGelismeBilgileri;
        private System.Windows.Forms.GroupBox groupBoxDavaBilgileri;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxKarsiTarafSec;
        private System.Windows.Forms.TextBox textBoxMuvekkil_ID;
        private System.Windows.Forms.TextBox textBoxKarsiTaraf_ID;
        private System.Windows.Forms.CheckBox checkBoxMuvekkilOnayla;
        private System.Windows.Forms.CheckBox checkBoxKarsiTarafOnay;
        private System.Windows.Forms.TextBox textBoxDavaIDGir;
    }
}
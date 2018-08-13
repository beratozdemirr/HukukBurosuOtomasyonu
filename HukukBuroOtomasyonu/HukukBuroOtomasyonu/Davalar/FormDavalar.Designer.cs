namespace HukukBuroOtomasyonu.Davalar
{
    partial class FormDavalar
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxDavaBilgisiAra = new System.Windows.Forms.TextBox();
            this.buttonAnaEkranaDön = new System.Windows.Forms.Button();
            this.buttonDavaRaporuOlustur = new System.Windows.Forms.Button();
            this.buttonDavaGuncelle = new System.Windows.Forms.Button();
            this.buttonDavaAra = new System.Windows.Forms.Button();
            this.buttonDavaSil = new System.Windows.Forms.Button();
            this.buttonDavaEkle = new System.Windows.Forms.Button();
            this.dataGridViewDavalar = new System.Windows.Forms.DataGridView();
            this.buttonDavaGelismesi = new System.Windows.Forms.Button();
            this.buttonDavaSonucu = new System.Windows.Forms.Button();
            this.buttonListele = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDavalar)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(164, 510);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "DAVA BİLGİSİ";
            // 
            // textBoxDavaBilgisiAra
            // 
            this.textBoxDavaBilgisiAra.Location = new System.Drawing.Point(258, 507);
            this.textBoxDavaBilgisiAra.Name = "textBoxDavaBilgisiAra";
            this.textBoxDavaBilgisiAra.Size = new System.Drawing.Size(276, 20);
            this.textBoxDavaBilgisiAra.TabIndex = 18;
            // 
            // buttonAnaEkranaDön
            // 
            this.buttonAnaEkranaDön.BackColor = System.Drawing.Color.SkyBlue;
            this.buttonAnaEkranaDön.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonAnaEkranaDön.Location = new System.Drawing.Point(761, 1);
            this.buttonAnaEkranaDön.Name = "buttonAnaEkranaDön";
            this.buttonAnaEkranaDön.Size = new System.Drawing.Size(122, 48);
            this.buttonAnaEkranaDön.TabIndex = 17;
            this.buttonAnaEkranaDön.Text = "ANA EKRANA DÖN";
            this.buttonAnaEkranaDön.UseVisualStyleBackColor = false;
            this.buttonAnaEkranaDön.Click += new System.EventHandler(this.buttonAnaEkranaDön_Click);
            // 
            // buttonDavaRaporuOlustur
            // 
            this.buttonDavaRaporuOlustur.BackColor = System.Drawing.Color.SkyBlue;
            this.buttonDavaRaporuOlustur.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonDavaRaporuOlustur.Location = new System.Drawing.Point(395, 1);
            this.buttonDavaRaporuOlustur.Name = "buttonDavaRaporuOlustur";
            this.buttonDavaRaporuOlustur.Size = new System.Drawing.Size(126, 48);
            this.buttonDavaRaporuOlustur.TabIndex = 15;
            this.buttonDavaRaporuOlustur.Text = "RAPOR OLUŞTUR";
            this.buttonDavaRaporuOlustur.UseVisualStyleBackColor = false;
            this.buttonDavaRaporuOlustur.Click += new System.EventHandler(this.buttonDavaRaporuOlustur_Click);
            // 
            // buttonDavaGuncelle
            // 
            this.buttonDavaGuncelle.BackColor = System.Drawing.Color.SkyBlue;
            this.buttonDavaGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonDavaGuncelle.Location = new System.Drawing.Point(265, 1);
            this.buttonDavaGuncelle.Name = "buttonDavaGuncelle";
            this.buttonDavaGuncelle.Size = new System.Drawing.Size(132, 48);
            this.buttonDavaGuncelle.TabIndex = 14;
            this.buttonDavaGuncelle.Text = "DAVA GÜNCELLE";
            this.buttonDavaGuncelle.UseVisualStyleBackColor = false;
            this.buttonDavaGuncelle.Click += new System.EventHandler(this.buttonDavaGuncelle_Click);
            // 
            // buttonDavaAra
            // 
            this.buttonDavaAra.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonDavaAra.Location = new System.Drawing.Point(553, 494);
            this.buttonDavaAra.Name = "buttonDavaAra";
            this.buttonDavaAra.Size = new System.Drawing.Size(124, 45);
            this.buttonDavaAra.TabIndex = 13;
            this.buttonDavaAra.Text = "DAVA ARA";
            this.buttonDavaAra.UseVisualStyleBackColor = true;
            this.buttonDavaAra.Click += new System.EventHandler(this.buttonDavaAra_Click);
            // 
            // buttonDavaSil
            // 
            this.buttonDavaSil.BackColor = System.Drawing.Color.SkyBlue;
            this.buttonDavaSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonDavaSil.Location = new System.Drawing.Point(133, 1);
            this.buttonDavaSil.Name = "buttonDavaSil";
            this.buttonDavaSil.Size = new System.Drawing.Size(134, 48);
            this.buttonDavaSil.TabIndex = 12;
            this.buttonDavaSil.Text = "DAVA SİL";
            this.buttonDavaSil.UseVisualStyleBackColor = false;
            this.buttonDavaSil.Click += new System.EventHandler(this.buttonDavaSil_Click);
            // 
            // buttonDavaEkle
            // 
            this.buttonDavaEkle.BackColor = System.Drawing.Color.SkyBlue;
            this.buttonDavaEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonDavaEkle.Location = new System.Drawing.Point(0, 1);
            this.buttonDavaEkle.Name = "buttonDavaEkle";
            this.buttonDavaEkle.Size = new System.Drawing.Size(135, 48);
            this.buttonDavaEkle.TabIndex = 11;
            this.buttonDavaEkle.Text = "DAVA EKLE";
            this.buttonDavaEkle.UseVisualStyleBackColor = false;
            this.buttonDavaEkle.Click += new System.EventHandler(this.buttonDavaEkle_Click);
            // 
            // dataGridViewDavalar
            // 
            this.dataGridViewDavalar.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridViewDavalar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDavalar.Location = new System.Drawing.Point(1, 49);
            this.dataGridViewDavalar.Name = "dataGridViewDavalar";
            this.dataGridViewDavalar.Size = new System.Drawing.Size(882, 413);
            this.dataGridViewDavalar.TabIndex = 10;
            // 
            // buttonDavaGelismesi
            // 
            this.buttonDavaGelismesi.BackColor = System.Drawing.Color.SkyBlue;
            this.buttonDavaGelismesi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonDavaGelismesi.Location = new System.Drawing.Point(519, 1);
            this.buttonDavaGelismesi.Name = "buttonDavaGelismesi";
            this.buttonDavaGelismesi.Size = new System.Drawing.Size(124, 48);
            this.buttonDavaGelismesi.TabIndex = 20;
            this.buttonDavaGelismesi.Text = "DAVA GELİŞMESİ";
            this.buttonDavaGelismesi.UseVisualStyleBackColor = false;
            this.buttonDavaGelismesi.Click += new System.EventHandler(this.buttonDavaGelismesi_Click);
            // 
            // buttonDavaSonucu
            // 
            this.buttonDavaSonucu.BackColor = System.Drawing.Color.SkyBlue;
            this.buttonDavaSonucu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonDavaSonucu.Location = new System.Drawing.Point(641, 1);
            this.buttonDavaSonucu.Name = "buttonDavaSonucu";
            this.buttonDavaSonucu.Size = new System.Drawing.Size(122, 48);
            this.buttonDavaSonucu.TabIndex = 21;
            this.buttonDavaSonucu.Text = "DAVA SONUCU";
            this.buttonDavaSonucu.UseVisualStyleBackColor = false;
            this.buttonDavaSonucu.Click += new System.EventHandler(this.buttonDavaSonucu_Click);
            // 
            // buttonListele
            // 
            this.buttonListele.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonListele.Location = new System.Drawing.Point(-1, 523);
            this.buttonListele.Name = "buttonListele";
            this.buttonListele.Size = new System.Drawing.Size(117, 39);
            this.buttonListele.TabIndex = 126;
            this.buttonListele.Text = "LİSTELE";
            this.buttonListele.UseVisualStyleBackColor = true;
            this.buttonListele.Click += new System.EventHandler(this.buttonListele_Click);
            // 
            // FormDavalar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.buttonListele);
            this.Controls.Add(this.buttonDavaSonucu);
            this.Controls.Add(this.buttonDavaGelismesi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxDavaBilgisiAra);
            this.Controls.Add(this.buttonAnaEkranaDön);
            this.Controls.Add(this.buttonDavaRaporuOlustur);
            this.Controls.Add(this.buttonDavaGuncelle);
            this.Controls.Add(this.buttonDavaAra);
            this.Controls.Add(this.buttonDavaSil);
            this.Controls.Add(this.buttonDavaEkle);
            this.Controls.Add(this.dataGridViewDavalar);
            this.Name = "FormDavalar";
            this.Text = "DAVALAR";
            this.Load += new System.EventHandler(this.FormDavalar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDavalar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxDavaBilgisiAra;
        private System.Windows.Forms.Button buttonAnaEkranaDön;
        private System.Windows.Forms.Button buttonDavaRaporuOlustur;
        private System.Windows.Forms.Button buttonDavaGuncelle;
        private System.Windows.Forms.Button buttonDavaAra;
        private System.Windows.Forms.Button buttonDavaSil;
        private System.Windows.Forms.Button buttonDavaEkle;
        private System.Windows.Forms.DataGridView dataGridViewDavalar;
        private System.Windows.Forms.Button buttonDavaGelismesi;
        private System.Windows.Forms.Button buttonDavaSonucu;
        private System.Windows.Forms.Button buttonListele;
    }
}
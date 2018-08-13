namespace HukukBuroOtomasyonu.Muvekkiller
{
    partial class FormMuvekkiller
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
            this.textBoxMuvekkilBilgisiAra = new System.Windows.Forms.TextBox();
            this.buttonMuvekkilRaporuOlustur = new System.Windows.Forms.Button();
            this.buttonMuvekkilGuncelle = new System.Windows.Forms.Button();
            this.buttonMuvekkilAra = new System.Windows.Forms.Button();
            this.buttonMuvekkilSil = new System.Windows.Forms.Button();
            this.buttonMuvekkilEkle = new System.Windows.Forms.Button();
            this.dataGridViewMuvekkiller = new System.Windows.Forms.DataGridView();
            this.buttonAnaEkran = new System.Windows.Forms.Button();
            this.buttonListele = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMuvekkiller)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(140, 506);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 17);
            this.label1.TabIndex = 17;
            this.label1.Text = "MÜVEKKİL BİLGİSİ";
            // 
            // textBoxMuvekkilBilgisiAra
            // 
            this.textBoxMuvekkilBilgisiAra.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxMuvekkilBilgisiAra.Location = new System.Drawing.Point(299, 503);
            this.textBoxMuvekkilBilgisiAra.Name = "textBoxMuvekkilBilgisiAra";
            this.textBoxMuvekkilBilgisiAra.Size = new System.Drawing.Size(276, 23);
            this.textBoxMuvekkilBilgisiAra.TabIndex = 16;
            // 
            // buttonMuvekkilRaporuOlustur
            // 
            this.buttonMuvekkilRaporuOlustur.BackColor = System.Drawing.Color.SkyBlue;
            this.buttonMuvekkilRaporuOlustur.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonMuvekkilRaporuOlustur.Location = new System.Drawing.Point(525, -1);
            this.buttonMuvekkilRaporuOlustur.Name = "buttonMuvekkilRaporuOlustur";
            this.buttonMuvekkilRaporuOlustur.Size = new System.Drawing.Size(179, 48);
            this.buttonMuvekkilRaporuOlustur.TabIndex = 15;
            this.buttonMuvekkilRaporuOlustur.Text = "RAPOR OLUŞTUR";
            this.buttonMuvekkilRaporuOlustur.UseVisualStyleBackColor = false;
            this.buttonMuvekkilRaporuOlustur.Click += new System.EventHandler(this.buttonMuvekkilRaporuOlustur_Click);
            // 
            // buttonMuvekkilGuncelle
            // 
            this.buttonMuvekkilGuncelle.BackColor = System.Drawing.Color.SkyBlue;
            this.buttonMuvekkilGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonMuvekkilGuncelle.Location = new System.Drawing.Point(358, -1);
            this.buttonMuvekkilGuncelle.Name = "buttonMuvekkilGuncelle";
            this.buttonMuvekkilGuncelle.Size = new System.Drawing.Size(169, 48);
            this.buttonMuvekkilGuncelle.TabIndex = 14;
            this.buttonMuvekkilGuncelle.Text = "MÜVEKKİL GÜNCELLE";
            this.buttonMuvekkilGuncelle.UseVisualStyleBackColor = false;
            this.buttonMuvekkilGuncelle.Click += new System.EventHandler(this.buttonMuvekkilGuncelle_Click);
            // 
            // buttonMuvekkilAra
            // 
            this.buttonMuvekkilAra.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonMuvekkilAra.Location = new System.Drawing.Point(611, 490);
            this.buttonMuvekkilAra.Name = "buttonMuvekkilAra";
            this.buttonMuvekkilAra.Size = new System.Drawing.Size(169, 48);
            this.buttonMuvekkilAra.TabIndex = 13;
            this.buttonMuvekkilAra.Text = "MÜVEKKİL ARA";
            this.buttonMuvekkilAra.UseVisualStyleBackColor = true;
            this.buttonMuvekkilAra.Click += new System.EventHandler(this.buttonMuvekkilAra_Click);
            // 
            // buttonMuvekkilSil
            // 
            this.buttonMuvekkilSil.BackColor = System.Drawing.Color.SkyBlue;
            this.buttonMuvekkilSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonMuvekkilSil.Location = new System.Drawing.Point(174, -1);
            this.buttonMuvekkilSil.Name = "buttonMuvekkilSil";
            this.buttonMuvekkilSil.Size = new System.Drawing.Size(186, 48);
            this.buttonMuvekkilSil.TabIndex = 12;
            this.buttonMuvekkilSil.Text = "MÜVEKKİL SİL";
            this.buttonMuvekkilSil.UseVisualStyleBackColor = false;
            this.buttonMuvekkilSil.Click += new System.EventHandler(this.buttonMuvekkilSil_Click);
            // 
            // buttonMuvekkilEkle
            // 
            this.buttonMuvekkilEkle.BackColor = System.Drawing.Color.SkyBlue;
            this.buttonMuvekkilEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonMuvekkilEkle.Location = new System.Drawing.Point(0, -1);
            this.buttonMuvekkilEkle.Name = "buttonMuvekkilEkle";
            this.buttonMuvekkilEkle.Size = new System.Drawing.Size(176, 48);
            this.buttonMuvekkilEkle.TabIndex = 11;
            this.buttonMuvekkilEkle.Text = "MÜVEKKİL EKLE";
            this.buttonMuvekkilEkle.UseVisualStyleBackColor = false;
            this.buttonMuvekkilEkle.Click += new System.EventHandler(this.buttonMuvekkilEkle_Click);
            // 
            // dataGridViewMuvekkiller
            // 
            this.dataGridViewMuvekkiller.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridViewMuvekkiller.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMuvekkiller.Location = new System.Drawing.Point(1, 47);
            this.dataGridViewMuvekkiller.Name = "dataGridViewMuvekkiller";
            this.dataGridViewMuvekkiller.Size = new System.Drawing.Size(882, 413);
            this.dataGridViewMuvekkiller.TabIndex = 10;
            // 
            // buttonAnaEkran
            // 
            this.buttonAnaEkran.BackColor = System.Drawing.Color.SkyBlue;
            this.buttonAnaEkran.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonAnaEkran.Location = new System.Drawing.Point(702, -1);
            this.buttonAnaEkran.Name = "buttonAnaEkran";
            this.buttonAnaEkran.Size = new System.Drawing.Size(181, 48);
            this.buttonAnaEkran.TabIndex = 18;
            this.buttonAnaEkran.Text = "ANA EKRANA DÖN";
            this.buttonAnaEkran.UseVisualStyleBackColor = false;
            this.buttonAnaEkran.Click += new System.EventHandler(this.buttonAnaEkran_Click);
            // 
            // buttonListele
            // 
            this.buttonListele.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonListele.Location = new System.Drawing.Point(-1, 523);
            this.buttonListele.Name = "buttonListele";
            this.buttonListele.Size = new System.Drawing.Size(117, 39);
            this.buttonListele.TabIndex = 29;
            this.buttonListele.Text = "LİSTELE";
            this.buttonListele.UseVisualStyleBackColor = true;
            this.buttonListele.Click += new System.EventHandler(this.buttonListele_Click);
            // 
            // FormMuvekkiller
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.buttonListele);
            this.Controls.Add(this.buttonAnaEkran);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxMuvekkilBilgisiAra);
            this.Controls.Add(this.buttonMuvekkilRaporuOlustur);
            this.Controls.Add(this.buttonMuvekkilGuncelle);
            this.Controls.Add(this.buttonMuvekkilAra);
            this.Controls.Add(this.buttonMuvekkilSil);
            this.Controls.Add(this.buttonMuvekkilEkle);
            this.Controls.Add(this.dataGridViewMuvekkiller);
            this.Name = "FormMuvekkiller";
            this.Text = "MÜVEKKİLLER";
            this.Load += new System.EventHandler(this.FormMuvekkiller_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMuvekkiller)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxMuvekkilBilgisiAra;
        private System.Windows.Forms.Button buttonMuvekkilRaporuOlustur;
        private System.Windows.Forms.Button buttonMuvekkilGuncelle;
        private System.Windows.Forms.Button buttonMuvekkilAra;
        private System.Windows.Forms.Button buttonMuvekkilSil;
        private System.Windows.Forms.Button buttonMuvekkilEkle;
        private System.Windows.Forms.DataGridView dataGridViewMuvekkiller;
        private System.Windows.Forms.Button buttonAnaEkran;
        private System.Windows.Forms.Button buttonListele;
    }
}
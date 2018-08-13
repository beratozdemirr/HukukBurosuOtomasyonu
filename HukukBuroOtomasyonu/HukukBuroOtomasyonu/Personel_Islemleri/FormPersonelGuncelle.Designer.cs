namespace HukukBuroOtomasyonu.Personel_Islemleri
{
    partial class FormPersonelGuncelle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPersonelGuncelle));
            this.buttonGuncelle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxPersonel = new System.Windows.Forms.ComboBox();
            this.dataGridViewPersoneller = new System.Windows.Forms.DataGridView();
            this.buttonListele = new System.Windows.Forms.Button();
            this.buttonPersonelAdiAra = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPersoneller)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonGuncelle
            // 
            this.buttonGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonGuncelle.Location = new System.Drawing.Point(766, 524);
            this.buttonGuncelle.Name = "buttonGuncelle";
            this.buttonGuncelle.Size = new System.Drawing.Size(119, 38);
            this.buttonGuncelle.TabIndex = 47;
            this.buttonGuncelle.Text = "GÜNCELLE";
            this.buttonGuncelle.UseVisualStyleBackColor = true;
            this.buttonGuncelle.Click += new System.EventHandler(this.buttonGuncelle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(286, 438);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 17);
            this.label1.TabIndex = 46;
            this.label1.Text = "Personel";
            // 
            // comboBoxPersonel
            // 
            this.comboBoxPersonel.FormattingEnabled = true;
            this.comboBoxPersonel.Location = new System.Drawing.Point(364, 437);
            this.comboBoxPersonel.Name = "comboBoxPersonel";
            this.comboBoxPersonel.Size = new System.Drawing.Size(245, 21);
            this.comboBoxPersonel.TabIndex = 45;
            // 
            // dataGridViewPersoneller
            // 
            this.dataGridViewPersoneller.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridViewPersoneller.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPersoneller.Location = new System.Drawing.Point(1, 1);
            this.dataGridViewPersoneller.Name = "dataGridViewPersoneller";
            this.dataGridViewPersoneller.Size = new System.Drawing.Size(883, 368);
            this.dataGridViewPersoneller.TabIndex = 44;
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
            // buttonPersonelAdiAra
            // 
            this.buttonPersonelAdiAra.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonPersonelAdiAra.BackgroundImage")));
            this.buttonPersonelAdiAra.Location = new System.Drawing.Point(624, 426);
            this.buttonPersonelAdiAra.Name = "buttonPersonelAdiAra";
            this.buttonPersonelAdiAra.Size = new System.Drawing.Size(40, 40);
            this.buttonPersonelAdiAra.TabIndex = 127;
            this.buttonPersonelAdiAra.UseVisualStyleBackColor = true;
            this.buttonPersonelAdiAra.Click += new System.EventHandler(this.buttonPersonelAdiAra_Click);
            // 
            // FormPersonelGuncelle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.buttonPersonelAdiAra);
            this.Controls.Add(this.buttonListele);
            this.Controls.Add(this.buttonGuncelle);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxPersonel);
            this.Controls.Add(this.dataGridViewPersoneller);
            this.Name = "FormPersonelGuncelle";
            this.Text = "PERSONEL GÜNCELLE";
            this.Load += new System.EventHandler(this.FormPersonelGuncelle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPersoneller)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonGuncelle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxPersonel;
        private System.Windows.Forms.DataGridView dataGridViewPersoneller;
        private System.Windows.Forms.Button buttonListele;
        private System.Windows.Forms.Button buttonPersonelAdiAra;
    }
}
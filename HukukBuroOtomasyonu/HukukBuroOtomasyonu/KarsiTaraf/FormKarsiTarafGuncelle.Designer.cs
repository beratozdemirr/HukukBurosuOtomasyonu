namespace HukukBuroOtomasyonu.KarsiTaraf
{
    partial class FormKarsiTarafGuncelle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormKarsiTarafGuncelle));
            this.dataGridViewKarsiTaraf = new System.Windows.Forms.DataGridView();
            this.comboBoxAraKarsiTarafTipi = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxAraCoklu = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxMuvekkilTipiArama = new System.Windows.Forms.GroupBox();
            this.buttonKarsiTarafTipiAra = new System.Windows.Forms.Button();
            this.groupBoxCokluArama = new System.Windows.Forms.GroupBox();
            this.buttonKarsiTarafBilgisiAra = new System.Windows.Forms.Button();
            this.buttonGuncelle = new System.Windows.Forms.Button();
            this.buttonListele = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKarsiTaraf)).BeginInit();
            this.groupBoxMuvekkilTipiArama.SuspendLayout();
            this.groupBoxCokluArama.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewKarsiTaraf
            // 
            this.dataGridViewKarsiTaraf.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridViewKarsiTaraf.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewKarsiTaraf.Location = new System.Drawing.Point(1, 1);
            this.dataGridViewKarsiTaraf.Name = "dataGridViewKarsiTaraf";
            this.dataGridViewKarsiTaraf.Size = new System.Drawing.Size(883, 368);
            this.dataGridViewKarsiTaraf.TabIndex = 28;
            // 
            // comboBoxAraKarsiTarafTipi
            // 
            this.comboBoxAraKarsiTarafTipi.FormattingEnabled = true;
            this.comboBoxAraKarsiTarafTipi.Items.AddRange(new object[] {
            "ALACAKLI",
            "BORÇLU",
            "HİSSEDAR",
            "DAVALI"});
            this.comboBoxAraKarsiTarafTipi.Location = new System.Drawing.Point(96, 38);
            this.comboBoxAraKarsiTarafTipi.Name = "comboBoxAraKarsiTarafTipi";
            this.comboBoxAraKarsiTarafTipi.Size = new System.Drawing.Size(241, 21);
            this.comboBoxAraKarsiTarafTipi.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 42);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Karşı Taraf Tipi";
            // 
            // textBoxAraCoklu
            // 
            this.textBoxAraCoklu.Location = new System.Drawing.Point(101, 39);
            this.textBoxAraCoklu.Name = "textBoxAraCoklu";
            this.textBoxAraCoklu.Size = new System.Drawing.Size(241, 20);
            this.textBoxAraCoklu.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Karşı Taraf Bilgisi";
            // 
            // groupBoxMuvekkilTipiArama
            // 
            this.groupBoxMuvekkilTipiArama.Controls.Add(this.buttonKarsiTarafTipiAra);
            this.groupBoxMuvekkilTipiArama.Controls.Add(this.comboBoxAraKarsiTarafTipi);
            this.groupBoxMuvekkilTipiArama.Controls.Add(this.label6);
            this.groupBoxMuvekkilTipiArama.Location = new System.Drawing.Point(467, 392);
            this.groupBoxMuvekkilTipiArama.Name = "groupBoxMuvekkilTipiArama";
            this.groupBoxMuvekkilTipiArama.Size = new System.Drawing.Size(417, 84);
            this.groupBoxMuvekkilTipiArama.TabIndex = 31;
            this.groupBoxMuvekkilTipiArama.TabStop = false;
            // 
            // buttonKarsiTarafTipiAra
            // 
            this.buttonKarsiTarafTipiAra.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonKarsiTarafTipiAra.BackgroundImage")));
            this.buttonKarsiTarafTipiAra.Location = new System.Drawing.Point(352, 28);
            this.buttonKarsiTarafTipiAra.Name = "buttonKarsiTarafTipiAra";
            this.buttonKarsiTarafTipiAra.Size = new System.Drawing.Size(40, 40);
            this.buttonKarsiTarafTipiAra.TabIndex = 123;
            this.buttonKarsiTarafTipiAra.UseVisualStyleBackColor = true;
            this.buttonKarsiTarafTipiAra.Click += new System.EventHandler(this.buttonKarsiTarafTipiAra_Click);
            // 
            // groupBoxCokluArama
            // 
            this.groupBoxCokluArama.Controls.Add(this.buttonKarsiTarafBilgisiAra);
            this.groupBoxCokluArama.Controls.Add(this.textBoxAraCoklu);
            this.groupBoxCokluArama.Controls.Add(this.label1);
            this.groupBoxCokluArama.Location = new System.Drawing.Point(35, 392);
            this.groupBoxCokluArama.Name = "groupBoxCokluArama";
            this.groupBoxCokluArama.Size = new System.Drawing.Size(437, 84);
            this.groupBoxCokluArama.TabIndex = 30;
            this.groupBoxCokluArama.TabStop = false;
            // 
            // buttonKarsiTarafBilgisiAra
            // 
            this.buttonKarsiTarafBilgisiAra.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonKarsiTarafBilgisiAra.BackgroundImage")));
            this.buttonKarsiTarafBilgisiAra.Location = new System.Drawing.Point(360, 27);
            this.buttonKarsiTarafBilgisiAra.Name = "buttonKarsiTarafBilgisiAra";
            this.buttonKarsiTarafBilgisiAra.Size = new System.Drawing.Size(40, 40);
            this.buttonKarsiTarafBilgisiAra.TabIndex = 123;
            this.buttonKarsiTarafBilgisiAra.UseVisualStyleBackColor = true;
            this.buttonKarsiTarafBilgisiAra.Click += new System.EventHandler(this.buttonKarsiTarafBilgisiAra_Click);
            // 
            // buttonGuncelle
            // 
            this.buttonGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonGuncelle.Location = new System.Drawing.Point(781, 523);
            this.buttonGuncelle.Name = "buttonGuncelle";
            this.buttonGuncelle.Size = new System.Drawing.Size(104, 39);
            this.buttonGuncelle.TabIndex = 29;
            this.buttonGuncelle.Text = "GÜNCELLE";
            this.buttonGuncelle.UseVisualStyleBackColor = true;
            this.buttonGuncelle.Click += new System.EventHandler(this.buttonGuncelle_Click);
            // 
            // buttonListele
            // 
            this.buttonListele.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonListele.Location = new System.Drawing.Point(-1, 523);
            this.buttonListele.Name = "buttonListele";
            this.buttonListele.Size = new System.Drawing.Size(102, 39);
            this.buttonListele.TabIndex = 32;
            this.buttonListele.Text = "LİSTELE";
            this.buttonListele.UseVisualStyleBackColor = true;
            this.buttonListele.Click += new System.EventHandler(this.buttonListele_Click);
            // 
            // FormKarsiTarafGuncelle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.buttonListele);
            this.Controls.Add(this.dataGridViewKarsiTaraf);
            this.Controls.Add(this.groupBoxMuvekkilTipiArama);
            this.Controls.Add(this.groupBoxCokluArama);
            this.Controls.Add(this.buttonGuncelle);
            this.Name = "FormKarsiTarafGuncelle";
            this.Text = "KARŞI TARAF GÜNCELLE";
            this.Load += new System.EventHandler(this.FormKarsiTarafGuncelle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKarsiTaraf)).EndInit();
            this.groupBoxMuvekkilTipiArama.ResumeLayout(false);
            this.groupBoxMuvekkilTipiArama.PerformLayout();
            this.groupBoxCokluArama.ResumeLayout(false);
            this.groupBoxCokluArama.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewKarsiTaraf;
        private System.Windows.Forms.ComboBox comboBoxAraKarsiTarafTipi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxAraCoklu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBoxMuvekkilTipiArama;
        private System.Windows.Forms.GroupBox groupBoxCokluArama;
        private System.Windows.Forms.Button buttonGuncelle;
        private System.Windows.Forms.Button buttonListele;
        private System.Windows.Forms.Button buttonKarsiTarafTipiAra;
        private System.Windows.Forms.Button buttonKarsiTarafBilgisiAra;
    }
}
namespace HukukBuroOtomasyonu.Muvekkiller
{
    partial class FormMuvekkilRaporOlustur
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMuvekkilRaporOlustur));
            this.dataGridViewMuvekkiller = new System.Windows.Forms.DataGridView();
            this.comboBoxAraMuvekkilTipi = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxAraCoklu = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxMuvekkilTipiArama = new System.Windows.Forms.GroupBox();
            this.buttonKarsiTarafTipAra = new System.Windows.Forms.Button();
            this.groupBoxCokluArama = new System.Windows.Forms.GroupBox();
            this.buttonKarsiTarafBilgisiAra = new System.Windows.Forms.Button();
            this.buttonRaporOlustur = new System.Windows.Forms.Button();
            this.buttonListele = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMuvekkiller)).BeginInit();
            this.groupBoxMuvekkilTipiArama.SuspendLayout();
            this.groupBoxCokluArama.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewMuvekkiller
            // 
            this.dataGridViewMuvekkiller.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridViewMuvekkiller.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMuvekkiller.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewMuvekkiller.Name = "dataGridViewMuvekkiller";
            this.dataGridViewMuvekkiller.Size = new System.Drawing.Size(883, 368);
            this.dataGridViewMuvekkiller.TabIndex = 24;
            // 
            // comboBoxAraMuvekkilTipi
            // 
            this.comboBoxAraMuvekkilTipi.FormattingEnabled = true;
            this.comboBoxAraMuvekkilTipi.Items.AddRange(new object[] {
            "ALACAKLI",
            "BORÇLU",
            "HİSSEDAR",
            "MAĞDUR",
            "DAVALI"});
            this.comboBoxAraMuvekkilTipi.Location = new System.Drawing.Point(97, 35);
            this.comboBoxAraMuvekkilTipi.Name = "comboBoxAraMuvekkilTipi";
            this.comboBoxAraMuvekkilTipi.Size = new System.Drawing.Size(241, 21);
            this.comboBoxAraMuvekkilTipi.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Müvekkil Tipi";
            // 
            // textBoxAraCoklu
            // 
            this.textBoxAraCoklu.Location = new System.Drawing.Point(155, 35);
            this.textBoxAraCoklu.Name = "textBoxAraCoklu";
            this.textBoxAraCoklu.Size = new System.Drawing.Size(241, 20);
            this.textBoxAraCoklu.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(15, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Müvekkil Arama Bilgisi";
            // 
            // groupBoxMuvekkilTipiArama
            // 
            this.groupBoxMuvekkilTipiArama.Controls.Add(this.buttonKarsiTarafTipAra);
            this.groupBoxMuvekkilTipiArama.Controls.Add(this.comboBoxAraMuvekkilTipi);
            this.groupBoxMuvekkilTipiArama.Controls.Add(this.label6);
            this.groupBoxMuvekkilTipiArama.Location = new System.Drawing.Point(466, 383);
            this.groupBoxMuvekkilTipiArama.Name = "groupBoxMuvekkilTipiArama";
            this.groupBoxMuvekkilTipiArama.Size = new System.Drawing.Size(406, 84);
            this.groupBoxMuvekkilTipiArama.TabIndex = 27;
            this.groupBoxMuvekkilTipiArama.TabStop = false;
            // 
            // buttonKarsiTarafTipAra
            // 
            this.buttonKarsiTarafTipAra.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonKarsiTarafTipAra.BackgroundImage")));
            this.buttonKarsiTarafTipAra.Location = new System.Drawing.Point(348, 24);
            this.buttonKarsiTarafTipAra.Name = "buttonKarsiTarafTipAra";
            this.buttonKarsiTarafTipAra.Size = new System.Drawing.Size(40, 40);
            this.buttonKarsiTarafTipAra.TabIndex = 22;
            this.buttonKarsiTarafTipAra.UseVisualStyleBackColor = true;
            this.buttonKarsiTarafTipAra.Click += new System.EventHandler(this.buttonMuvTipAra_Click);
            // 
            // groupBoxCokluArama
            // 
            this.groupBoxCokluArama.Controls.Add(this.buttonKarsiTarafBilgisiAra);
            this.groupBoxCokluArama.Controls.Add(this.textBoxAraCoklu);
            this.groupBoxCokluArama.Controls.Add(this.label1);
            this.groupBoxCokluArama.Location = new System.Drawing.Point(12, 383);
            this.groupBoxCokluArama.Name = "groupBoxCokluArama";
            this.groupBoxCokluArama.Size = new System.Drawing.Size(459, 84);
            this.groupBoxCokluArama.TabIndex = 26;
            this.groupBoxCokluArama.TabStop = false;
            // 
            // buttonKarsiTarafBilgisiAra
            // 
            this.buttonKarsiTarafBilgisiAra.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonKarsiTarafBilgisiAra.BackgroundImage")));
            this.buttonKarsiTarafBilgisiAra.Location = new System.Drawing.Point(404, 24);
            this.buttonKarsiTarafBilgisiAra.Name = "buttonKarsiTarafBilgisiAra";
            this.buttonKarsiTarafBilgisiAra.Size = new System.Drawing.Size(40, 40);
            this.buttonKarsiTarafBilgisiAra.TabIndex = 21;
            this.buttonKarsiTarafBilgisiAra.UseVisualStyleBackColor = true;
            this.buttonKarsiTarafBilgisiAra.Click += new System.EventHandler(this.buttonMuvekkilBilgisiAra_Click);
            // 
            // buttonRaporOlustur
            // 
            this.buttonRaporOlustur.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonRaporOlustur.Location = new System.Drawing.Point(763, 518);
            this.buttonRaporOlustur.Name = "buttonRaporOlustur";
            this.buttonRaporOlustur.Size = new System.Drawing.Size(122, 44);
            this.buttonRaporOlustur.TabIndex = 60;
            this.buttonRaporOlustur.Text = "RAPOR OLUŞTUR";
            this.buttonRaporOlustur.UseVisualStyleBackColor = true;
            // 
            // buttonListele
            // 
            this.buttonListele.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonListele.Location = new System.Drawing.Point(-1, 523);
            this.buttonListele.Name = "buttonListele";
            this.buttonListele.Size = new System.Drawing.Size(106, 39);
            this.buttonListele.TabIndex = 61;
            this.buttonListele.Text = "LİSTELE";
            this.buttonListele.UseVisualStyleBackColor = true;
            this.buttonListele.Click += new System.EventHandler(this.buttonListele_Click);
            // 
            // FormMuvekkilRaporOlustur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.buttonListele);
            this.Controls.Add(this.buttonRaporOlustur);
            this.Controls.Add(this.dataGridViewMuvekkiller);
            this.Controls.Add(this.groupBoxMuvekkilTipiArama);
            this.Controls.Add(this.groupBoxCokluArama);
            this.Name = "FormMuvekkilRaporOlustur";
            this.Text = "MÜVEKKİL RAPORU OLUŞTUR";
            this.Load += new System.EventHandler(this.FormMuvekkilRaporOlustur_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMuvekkiller)).EndInit();
            this.groupBoxMuvekkilTipiArama.ResumeLayout(false);
            this.groupBoxMuvekkilTipiArama.PerformLayout();
            this.groupBoxCokluArama.ResumeLayout(false);
            this.groupBoxCokluArama.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewMuvekkiller;
        private System.Windows.Forms.ComboBox comboBoxAraMuvekkilTipi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxAraCoklu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBoxMuvekkilTipiArama;
        private System.Windows.Forms.GroupBox groupBoxCokluArama;
        private System.Windows.Forms.Button buttonRaporOlustur;
        private System.Windows.Forms.Button buttonKarsiTarafTipAra;
        private System.Windows.Forms.Button buttonKarsiTarafBilgisiAra;
        private System.Windows.Forms.Button buttonListele;
    }
}
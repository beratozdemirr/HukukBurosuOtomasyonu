namespace HukukBuroOtomasyonu.Muvekkiller
{
    partial class FormMuvekkilGuncelle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMuvekkilGuncelle));
            this.dataGridViewMuvekkiller = new System.Windows.Forms.DataGridView();
            this.comboBoxAraMuvekkilTipi = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxMuvekkil_IsmiAra = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxMuvekkilTipiArama = new System.Windows.Forms.GroupBox();
            this.buttonMuvekkilTipiAra = new System.Windows.Forms.Button();
            this.groupBoxCokluArama = new System.Windows.Forms.GroupBox();
            this.buttonMuvekkil_IsimAra = new System.Windows.Forms.Button();
            this.buttonGuncelle = new System.Windows.Forms.Button();
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
            this.dataGridViewMuvekkiller.Size = new System.Drawing.Size(883, 331);
            this.dataGridViewMuvekkiller.TabIndex = 24;
            // 
            // comboBoxAraMuvekkilTipi
            // 
            this.comboBoxAraMuvekkilTipi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBoxAraMuvekkilTipi.FormattingEnabled = true;
            this.comboBoxAraMuvekkilTipi.Items.AddRange(new object[] {
            "ALACAKLI",
            "BORÇLU",
            "HİSSEDAR",
            "MAĞDUR",
            "DAVALI"});
            this.comboBoxAraMuvekkilTipi.Location = new System.Drawing.Point(119, 36);
            this.comboBoxAraMuvekkilTipi.Name = "comboBoxAraMuvekkilTipi";
            this.comboBoxAraMuvekkilTipi.Size = new System.Drawing.Size(241, 24);
            this.comboBoxAraMuvekkilTipi.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(11, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 17);
            this.label6.TabIndex = 18;
            this.label6.Text = "Müvekkil Tipi";
            // 
            // textBoxMuvekkil_IsmiAra
            // 
            this.textBoxMuvekkil_IsmiAra.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxMuvekkil_IsmiAra.Location = new System.Drawing.Point(132, 36);
            this.textBoxMuvekkil_IsmiAra.Name = "textBoxMuvekkil_IsmiAra";
            this.textBoxMuvekkil_IsmiAra.Size = new System.Drawing.Size(241, 23);
            this.textBoxMuvekkil_IsmiAra.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(23, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 17);
            this.label1.TabIndex = 20;
            this.label1.Text = "Müvekkil İsim";
            // 
            // groupBoxMuvekkilTipiArama
            // 
            this.groupBoxMuvekkilTipiArama.Controls.Add(this.buttonMuvekkilTipiAra);
            this.groupBoxMuvekkilTipiArama.Controls.Add(this.comboBoxAraMuvekkilTipi);
            this.groupBoxMuvekkilTipiArama.Controls.Add(this.label6);
            this.groupBoxMuvekkilTipiArama.Location = new System.Drawing.Point(445, 355);
            this.groupBoxMuvekkilTipiArama.Name = "groupBoxMuvekkilTipiArama";
            this.groupBoxMuvekkilTipiArama.Size = new System.Drawing.Size(417, 84);
            this.groupBoxMuvekkilTipiArama.TabIndex = 27;
            this.groupBoxMuvekkilTipiArama.TabStop = false;
            // 
            // buttonMuvekkilTipiAra
            // 
            this.buttonMuvekkilTipiAra.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonMuvekkilTipiAra.BackgroundImage")));
            this.buttonMuvekkilTipiAra.Location = new System.Drawing.Point(371, 26);
            this.buttonMuvekkilTipiAra.Name = "buttonMuvekkilTipiAra";
            this.buttonMuvekkilTipiAra.Size = new System.Drawing.Size(40, 40);
            this.buttonMuvekkilTipiAra.TabIndex = 123;
            this.buttonMuvekkilTipiAra.UseVisualStyleBackColor = true;
            this.buttonMuvekkilTipiAra.Click += new System.EventHandler(this.buttonMuvekkilTipiAra_Click);
            // 
            // groupBoxCokluArama
            // 
            this.groupBoxCokluArama.Controls.Add(this.buttonMuvekkil_IsimAra);
            this.groupBoxCokluArama.Controls.Add(this.textBoxMuvekkil_IsmiAra);
            this.groupBoxCokluArama.Controls.Add(this.label1);
            this.groupBoxCokluArama.Location = new System.Drawing.Point(13, 355);
            this.groupBoxCokluArama.Name = "groupBoxCokluArama";
            this.groupBoxCokluArama.Size = new System.Drawing.Size(437, 84);
            this.groupBoxCokluArama.TabIndex = 26;
            this.groupBoxCokluArama.TabStop = false;
            // 
            // buttonMuvekkil_IsimAra
            // 
            this.buttonMuvekkil_IsimAra.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonMuvekkil_IsimAra.BackgroundImage")));
            this.buttonMuvekkil_IsimAra.Location = new System.Drawing.Point(386, 27);
            this.buttonMuvekkil_IsimAra.Name = "buttonMuvekkil_IsimAra";
            this.buttonMuvekkil_IsimAra.Size = new System.Drawing.Size(40, 40);
            this.buttonMuvekkil_IsimAra.TabIndex = 122;
            this.buttonMuvekkil_IsimAra.UseVisualStyleBackColor = true;
            this.buttonMuvekkil_IsimAra.Click += new System.EventHandler(this.buttonMuvekkil_IsimAra_Click);
            // 
            // buttonGuncelle
            // 
            this.buttonGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonGuncelle.Location = new System.Drawing.Point(768, 523);
            this.buttonGuncelle.Name = "buttonGuncelle";
            this.buttonGuncelle.Size = new System.Drawing.Size(117, 39);
            this.buttonGuncelle.TabIndex = 25;
            this.buttonGuncelle.Text = "GÜNCELLE";
            this.buttonGuncelle.UseVisualStyleBackColor = true;
            this.buttonGuncelle.Click += new System.EventHandler(this.buttonGuncelle_Click);
            // 
            // buttonListele
            // 
            this.buttonListele.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonListele.Location = new System.Drawing.Point(-1, 523);
            this.buttonListele.Name = "buttonListele";
            this.buttonListele.Size = new System.Drawing.Size(117, 39);
            this.buttonListele.TabIndex = 28;
            this.buttonListele.Text = "LİSTELE";
            this.buttonListele.UseVisualStyleBackColor = true;
            this.buttonListele.Click += new System.EventHandler(this.buttonListele_Click);
            // 
            // FormMuvekkilGuncelle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.buttonListele);
            this.Controls.Add(this.dataGridViewMuvekkiller);
            this.Controls.Add(this.groupBoxMuvekkilTipiArama);
            this.Controls.Add(this.groupBoxCokluArama);
            this.Controls.Add(this.buttonGuncelle);
            this.Name = "FormMuvekkilGuncelle";
            this.Text = "MÜVEKKİL GÜNCELLE";
            this.Load += new System.EventHandler(this.FormMuvekkilGuncelle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMuvekkiller)).EndInit();
            this.groupBoxMuvekkilTipiArama.ResumeLayout(false);
            this.groupBoxMuvekkilTipiArama.PerformLayout();
            this.groupBoxCokluArama.ResumeLayout(false);
            this.groupBoxCokluArama.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox comboBoxAraMuvekkilTipi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxMuvekkil_IsmiAra;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBoxMuvekkilTipiArama;
        private System.Windows.Forms.GroupBox groupBoxCokluArama;
        private System.Windows.Forms.Button buttonGuncelle;
        private System.Windows.Forms.Button buttonMuvekkilTipiAra;
        private System.Windows.Forms.Button buttonMuvekkil_IsimAra;
        private System.Windows.Forms.Button buttonListele;
        public System.Windows.Forms.DataGridView dataGridViewMuvekkiller;
    }
}
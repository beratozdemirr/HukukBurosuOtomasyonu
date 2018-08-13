namespace HukukBuroOtomasyonu.Muvekkiller
{
    partial class FormMuvekkilSil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMuvekkilSil));
            this.dataGridViewMuvekkiller = new System.Windows.Forms.DataGridView();
            this.textBoxAraCoklu = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxCokluArama = new System.Windows.Forms.GroupBox();
            this.buttonSilMuvBilgisiAra = new System.Windows.Forms.Button();
            this.buttonSil = new System.Windows.Forms.Button();
            this.buttonSilMuvTipiAra = new System.Windows.Forms.Button();
            this.comboBoxAraMuvekkilTipi = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBoxMuvekkilTipiArama = new System.Windows.Forms.GroupBox();
            this.buttonListele = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMuvekkiller)).BeginInit();
            this.groupBoxCokluArama.SuspendLayout();
            this.groupBoxMuvekkilTipiArama.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewMuvekkiller
            // 
            this.dataGridViewMuvekkiller.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridViewMuvekkiller.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMuvekkiller.Location = new System.Drawing.Point(0, 1);
            this.dataGridViewMuvekkiller.Name = "dataGridViewMuvekkiller";
            this.dataGridViewMuvekkiller.Size = new System.Drawing.Size(883, 368);
            this.dataGridViewMuvekkiller.TabIndex = 24;
            // 
            // textBoxAraCoklu
            // 
            this.textBoxAraCoklu.Location = new System.Drawing.Point(146, 39);
            this.textBoxAraCoklu.Name = "textBoxAraCoklu";
            this.textBoxAraCoklu.Size = new System.Drawing.Size(241, 20);
            this.textBoxAraCoklu.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(6, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Müvekkil Arama Bilgisi";
            // 
            // groupBoxCokluArama
            // 
            this.groupBoxCokluArama.Controls.Add(this.buttonSilMuvBilgisiAra);
            this.groupBoxCokluArama.Controls.Add(this.textBoxAraCoklu);
            this.groupBoxCokluArama.Controls.Add(this.label1);
            this.groupBoxCokluArama.Location = new System.Drawing.Point(12, 392);
            this.groupBoxCokluArama.Name = "groupBoxCokluArama";
            this.groupBoxCokluArama.Size = new System.Drawing.Size(459, 84);
            this.groupBoxCokluArama.TabIndex = 26;
            this.groupBoxCokluArama.TabStop = false;
            // 
            // buttonSilMuvBilgisiAra
            // 
            this.buttonSilMuvBilgisiAra.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonSilMuvBilgisiAra.BackgroundImage")));
            this.buttonSilMuvBilgisiAra.Location = new System.Drawing.Point(402, 28);
            this.buttonSilMuvBilgisiAra.Name = "buttonSilMuvBilgisiAra";
            this.buttonSilMuvBilgisiAra.Size = new System.Drawing.Size(40, 40);
            this.buttonSilMuvBilgisiAra.TabIndex = 21;
            this.buttonSilMuvBilgisiAra.UseVisualStyleBackColor = true;
            this.buttonSilMuvBilgisiAra.Click += new System.EventHandler(this.buttonSilMuvBilgisiAra_Click);
            // 
            // buttonSil
            // 
            this.buttonSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonSil.Location = new System.Drawing.Point(779, 523);
            this.buttonSil.Name = "buttonSil";
            this.buttonSil.Size = new System.Drawing.Size(106, 39);
            this.buttonSil.TabIndex = 25;
            this.buttonSil.Text = "SİL";
            this.buttonSil.UseVisualStyleBackColor = true;
            this.buttonSil.Click += new System.EventHandler(this.buttonSil_Click);
            // 
            // buttonSilMuvTipiAra
            // 
            this.buttonSilMuvTipiAra.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonSilMuvTipiAra.BackgroundImage")));
            this.buttonSilMuvTipiAra.Location = new System.Drawing.Point(349, 28);
            this.buttonSilMuvTipiAra.Name = "buttonSilMuvTipiAra";
            this.buttonSilMuvTipiAra.Size = new System.Drawing.Size(40, 40);
            this.buttonSilMuvTipiAra.TabIndex = 19;
            this.buttonSilMuvTipiAra.UseVisualStyleBackColor = true;
            this.buttonSilMuvTipiAra.Click += new System.EventHandler(this.buttonSilMuvTipiAra_Click);
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
            this.comboBoxAraMuvekkilTipi.Location = new System.Drawing.Point(96, 38);
            this.comboBoxAraMuvekkilTipi.Name = "comboBoxAraMuvekkilTipi";
            this.comboBoxAraMuvekkilTipi.Size = new System.Drawing.Size(241, 21);
            this.comboBoxAraMuvekkilTipi.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(11, 42);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Müvekkil Tipi";
            // 
            // groupBoxMuvekkilTipiArama
            // 
            this.groupBoxMuvekkilTipiArama.Controls.Add(this.buttonSilMuvTipiAra);
            this.groupBoxMuvekkilTipiArama.Controls.Add(this.comboBoxAraMuvekkilTipi);
            this.groupBoxMuvekkilTipiArama.Controls.Add(this.label6);
            this.groupBoxMuvekkilTipiArama.Location = new System.Drawing.Point(466, 392);
            this.groupBoxMuvekkilTipiArama.Name = "groupBoxMuvekkilTipiArama";
            this.groupBoxMuvekkilTipiArama.Size = new System.Drawing.Size(406, 84);
            this.groupBoxMuvekkilTipiArama.TabIndex = 27;
            this.groupBoxMuvekkilTipiArama.TabStop = false;
            // 
            // buttonListele
            // 
            this.buttonListele.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonListele.Location = new System.Drawing.Point(-1, 523);
            this.buttonListele.Name = "buttonListele";
            this.buttonListele.Size = new System.Drawing.Size(106, 39);
            this.buttonListele.TabIndex = 28;
            this.buttonListele.Text = "LİSTELE";
            this.buttonListele.UseVisualStyleBackColor = true;
            this.buttonListele.Click += new System.EventHandler(this.buttonListele_Click);
            // 
            // FormMuvekkilSil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.buttonListele);
            this.Controls.Add(this.dataGridViewMuvekkiller);
            this.Controls.Add(this.groupBoxCokluArama);
            this.Controls.Add(this.buttonSil);
            this.Controls.Add(this.groupBoxMuvekkilTipiArama);
            this.Name = "FormMuvekkilSil";
            this.Text = "MÜVEKKİL SİL";
            this.Load += new System.EventHandler(this.FormMuvekkilSil_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMuvekkiller)).EndInit();
            this.groupBoxCokluArama.ResumeLayout(false);
            this.groupBoxCokluArama.PerformLayout();
            this.groupBoxMuvekkilTipiArama.ResumeLayout(false);
            this.groupBoxMuvekkilTipiArama.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewMuvekkiller;
        private System.Windows.Forms.TextBox textBoxAraCoklu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBoxCokluArama;
        private System.Windows.Forms.Button buttonSilMuvBilgisiAra;
        private System.Windows.Forms.Button buttonSil;
        private System.Windows.Forms.Button buttonSilMuvTipiAra;
        private System.Windows.Forms.ComboBox comboBoxAraMuvekkilTipi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBoxMuvekkilTipiArama;
        private System.Windows.Forms.Button buttonListele;
    }
}
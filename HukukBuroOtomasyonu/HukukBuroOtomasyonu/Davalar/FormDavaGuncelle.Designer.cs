namespace HukukBuroOtomasyonu.Davalar
{
    partial class FormDavaGuncelle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDavaGuncelle));
            this.comboBoxAdliyeBinasiARA = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.comboBoxDavaTuruARA = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxMuvekkil_IsimARA = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.buttonGuncelle = new System.Windows.Forms.Button();
            this.dataGridViewDavalar = new System.Windows.Forms.DataGridView();
            this.buttonMuvekkilAra = new System.Windows.Forms.Button();
            this.buttonDavaTuruAra = new System.Windows.Forms.Button();
            this.buttonAdliyeBinasiAra = new System.Windows.Forms.Button();
            this.buttonListele = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDavalar)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxAdliyeBinasiARA
            // 
            this.comboBoxAdliyeBinasiARA.FormattingEnabled = true;
            this.comboBoxAdliyeBinasiARA.Location = new System.Drawing.Point(627, 439);
            this.comboBoxAdliyeBinasiARA.Name = "comboBoxAdliyeBinasiARA";
            this.comboBoxAdliyeBinasiARA.Size = new System.Drawing.Size(240, 21);
            this.comboBoxAdliyeBinasiARA.TabIndex = 44;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.Location = new System.Drawing.Point(529, 442);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(79, 13);
            this.label13.TabIndex = 45;
            this.label13.Text = "Adliye Binası";
            // 
            // comboBoxDavaTuruARA
            // 
            this.comboBoxDavaTuruARA.FormattingEnabled = true;
            this.comboBoxDavaTuruARA.Items.AddRange(new object[] {
            "KİRA DAVALARI",
            "AİLE DAVALARI",
            "MİRAS DAVALARI",
            "BORÇ DAVALARI",
            "ŞİRKET DAVALARI",
            "İCRA DAVALARI",
            "KİŞİLİK HAKLARI DAVALARI"});
            this.comboBoxDavaTuruARA.Location = new System.Drawing.Point(148, 470);
            this.comboBoxDavaTuruARA.Name = "comboBoxDavaTuruARA";
            this.comboBoxDavaTuruARA.Size = new System.Drawing.Size(255, 21);
            this.comboBoxDavaTuruARA.TabIndex = 40;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(59, 473);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 42;
            this.label3.Text = "Dava Türü";
            // 
            // comboBoxMuvekkil_IsimARA
            // 
            this.comboBoxMuvekkil_IsimARA.FormattingEnabled = true;
            this.comboBoxMuvekkil_IsimARA.Location = new System.Drawing.Point(148, 414);
            this.comboBoxMuvekkil_IsimARA.Name = "comboBoxMuvekkil_IsimARA";
            this.comboBoxMuvekkil_IsimARA.Size = new System.Drawing.Size(255, 21);
            this.comboBoxMuvekkil_IsimARA.TabIndex = 36;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(69, 417);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 13);
            this.label10.TabIndex = 37;
            this.label10.Text = "Müvekkil";
            // 
            // buttonGuncelle
            // 
            this.buttonGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonGuncelle.Location = new System.Drawing.Point(915, 523);
            this.buttonGuncelle.Name = "buttonGuncelle";
            this.buttonGuncelle.Size = new System.Drawing.Size(117, 39);
            this.buttonGuncelle.TabIndex = 35;
            this.buttonGuncelle.Text = "GÜNCELLE";
            this.buttonGuncelle.UseVisualStyleBackColor = true;
            this.buttonGuncelle.Click += new System.EventHandler(this.buttonGuncelle_Click);
            // 
            // dataGridViewDavalar
            // 
            this.dataGridViewDavalar.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridViewDavalar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDavalar.Location = new System.Drawing.Point(1, 0);
            this.dataGridViewDavalar.Name = "dataGridViewDavalar";
            this.dataGridViewDavalar.Size = new System.Drawing.Size(1030, 368);
            this.dataGridViewDavalar.TabIndex = 34;
            // 
            // buttonMuvekkilAra
            // 
            this.buttonMuvekkilAra.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonMuvekkilAra.BackgroundImage")));
            this.buttonMuvekkilAra.Location = new System.Drawing.Point(420, 403);
            this.buttonMuvekkilAra.Name = "buttonMuvekkilAra";
            this.buttonMuvekkilAra.Size = new System.Drawing.Size(40, 40);
            this.buttonMuvekkilAra.TabIndex = 129;
            this.buttonMuvekkilAra.UseVisualStyleBackColor = true;
            this.buttonMuvekkilAra.Click += new System.EventHandler(this.buttonMuvekkilAra_Click);
            // 
            // buttonDavaTuruAra
            // 
            this.buttonDavaTuruAra.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonDavaTuruAra.BackgroundImage")));
            this.buttonDavaTuruAra.Location = new System.Drawing.Point(420, 459);
            this.buttonDavaTuruAra.Name = "buttonDavaTuruAra";
            this.buttonDavaTuruAra.Size = new System.Drawing.Size(40, 40);
            this.buttonDavaTuruAra.TabIndex = 130;
            this.buttonDavaTuruAra.UseVisualStyleBackColor = true;
            this.buttonDavaTuruAra.Click += new System.EventHandler(this.buttonDavaTuruAra_Click);
            // 
            // buttonAdliyeBinasiAra
            // 
            this.buttonAdliyeBinasiAra.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonAdliyeBinasiAra.BackgroundImage")));
            this.buttonAdliyeBinasiAra.Location = new System.Drawing.Point(883, 428);
            this.buttonAdliyeBinasiAra.Name = "buttonAdliyeBinasiAra";
            this.buttonAdliyeBinasiAra.Size = new System.Drawing.Size(40, 40);
            this.buttonAdliyeBinasiAra.TabIndex = 131;
            this.buttonAdliyeBinasiAra.UseVisualStyleBackColor = true;
            this.buttonAdliyeBinasiAra.Click += new System.EventHandler(this.buttonAdliyeBinasiAra_Click);
            // 
            // buttonListele
            // 
            this.buttonListele.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonListele.Location = new System.Drawing.Point(-1, 523);
            this.buttonListele.Name = "buttonListele";
            this.buttonListele.Size = new System.Drawing.Size(117, 39);
            this.buttonListele.TabIndex = 134;
            this.buttonListele.Text = "LİSTELE";
            this.buttonListele.UseVisualStyleBackColor = true;
            this.buttonListele.Click += new System.EventHandler(this.buttonListele_Click);
            // 
            // FormDavaGuncelle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(1031, 561);
            this.Controls.Add(this.buttonListele);
            this.Controls.Add(this.buttonAdliyeBinasiAra);
            this.Controls.Add(this.buttonDavaTuruAra);
            this.Controls.Add(this.buttonMuvekkilAra);
            this.Controls.Add(this.comboBoxAdliyeBinasiARA);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.comboBoxDavaTuruARA);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxMuvekkil_IsimARA);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.buttonGuncelle);
            this.Controls.Add(this.dataGridViewDavalar);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Name = "FormDavaGuncelle";
            this.Text = "DAVA GÜNCELLE";
            this.Load += new System.EventHandler(this.FormDavaGuncelle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDavalar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxAdliyeBinasiARA;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox comboBoxDavaTuruARA;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxMuvekkil_IsimARA;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button buttonGuncelle;
        private System.Windows.Forms.DataGridView dataGridViewDavalar;
        private System.Windows.Forms.Button buttonMuvekkilAra;
        private System.Windows.Forms.Button buttonDavaTuruAra;
        private System.Windows.Forms.Button buttonAdliyeBinasiAra;
        private System.Windows.Forms.Button buttonListele;
    }
}
namespace HukukBuroOtomasyonu.Adliye
{
    partial class FormAdliyeGuncelleDoldur
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxAdliyeAdres = new System.Windows.Forms.TextBox();
            this.textBoxAdliyeTelNo = new System.Windows.Forms.TextBox();
            this.textBoxAdliyeAdi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxAdliyeNo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonGuncelle
            // 
            this.buttonGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonGuncelle.Location = new System.Drawing.Point(409, 404);
            this.buttonGuncelle.Name = "buttonGuncelle";
            this.buttonGuncelle.Size = new System.Drawing.Size(129, 51);
            this.buttonGuncelle.TabIndex = 20;
            this.buttonGuncelle.Text = "GÜNCELLE";
            this.buttonGuncelle.UseVisualStyleBackColor = true;
            this.buttonGuncelle.Click += new System.EventHandler(this.buttonGuncelle_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(247, 271);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Adliye Adres";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(238, 220);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Adliye Telefon No";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(259, 170);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Adliye Adı";
            // 
            // textBoxAdliyeAdres
            // 
            this.textBoxAdliyeAdres.Location = new System.Drawing.Point(352, 268);
            this.textBoxAdliyeAdres.Multiline = true;
            this.textBoxAdliyeAdres.Name = "textBoxAdliyeAdres";
            this.textBoxAdliyeAdres.Size = new System.Drawing.Size(256, 104);
            this.textBoxAdliyeAdres.TabIndex = 16;
            // 
            // textBoxAdliyeTelNo
            // 
            this.textBoxAdliyeTelNo.Location = new System.Drawing.Point(352, 217);
            this.textBoxAdliyeTelNo.Name = "textBoxAdliyeTelNo";
            this.textBoxAdliyeTelNo.Size = new System.Drawing.Size(194, 20);
            this.textBoxAdliyeTelNo.TabIndex = 15;
            // 
            // textBoxAdliyeAdi
            // 
            this.textBoxAdliyeAdi.Location = new System.Drawing.Point(352, 167);
            this.textBoxAdliyeAdi.Name = "textBoxAdliyeAdi";
            this.textBoxAdliyeAdi.Size = new System.Drawing.Size(256, 20);
            this.textBoxAdliyeAdi.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(274, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Adliye No";
            // 
            // textBoxAdliyeNo
            // 
            this.textBoxAdliyeNo.Location = new System.Drawing.Point(352, 115);
            this.textBoxAdliyeNo.Name = "textBoxAdliyeNo";
            this.textBoxAdliyeNo.ReadOnly = true;
            this.textBoxAdliyeNo.Size = new System.Drawing.Size(150, 20);
            this.textBoxAdliyeNo.TabIndex = 22;
            // 
            // FormAdliyeGuncelleDoldur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.textBoxAdliyeNo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonGuncelle);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxAdliyeAdres);
            this.Controls.Add(this.textBoxAdliyeTelNo);
            this.Controls.Add(this.textBoxAdliyeAdi);
            this.Name = "FormAdliyeGuncelleDoldur";
            this.Text = "ADLİYE GÜNCELLEME FORMU";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button buttonGuncelle;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox textBoxAdliyeAdres;
        public System.Windows.Forms.TextBox textBoxAdliyeTelNo;
        public System.Windows.Forms.TextBox textBoxAdliyeAdi;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox textBoxAdliyeNo;
    }
}
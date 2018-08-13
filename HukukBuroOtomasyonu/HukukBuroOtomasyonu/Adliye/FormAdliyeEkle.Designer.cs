namespace HukukBuroOtomasyonu.Adliye
{
    partial class FormAdliyeEkle
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
            this.buttonKaydet = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxAdliyeAdres = new System.Windows.Forms.TextBox();
            this.textBoxAdliyeTelNo = new System.Windows.Forms.TextBox();
            this.textBoxAdliyeAdi = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonKaydet
            // 
            this.buttonKaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonKaydet.Location = new System.Drawing.Point(401, 391);
            this.buttonKaydet.Name = "buttonKaydet";
            this.buttonKaydet.Size = new System.Drawing.Size(113, 43);
            this.buttonKaydet.TabIndex = 13;
            this.buttonKaydet.Text = "KAYDET";
            this.buttonKaydet.UseVisualStyleBackColor = true;
            this.buttonKaydet.Click += new System.EventHandler(this.buttonKaydet_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(245, 236);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Adliye Adres";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(219, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Adliye Telefon No";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(257, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Adliye Adı";
            // 
            // textBoxAdliyeAdres
            // 
            this.textBoxAdliyeAdres.Location = new System.Drawing.Point(333, 233);
            this.textBoxAdliyeAdres.Multiline = true;
            this.textBoxAdliyeAdres.Name = "textBoxAdliyeAdres";
            this.textBoxAdliyeAdres.Size = new System.Drawing.Size(256, 104);
            this.textBoxAdliyeAdres.TabIndex = 9;
            // 
            // textBoxAdliyeTelNo
            // 
            this.textBoxAdliyeTelNo.Location = new System.Drawing.Point(333, 182);
            this.textBoxAdliyeTelNo.Name = "textBoxAdliyeTelNo";
            this.textBoxAdliyeTelNo.Size = new System.Drawing.Size(194, 20);
            this.textBoxAdliyeTelNo.TabIndex = 8;
            // 
            // textBoxAdliyeAdi
            // 
            this.textBoxAdliyeAdi.Location = new System.Drawing.Point(333, 132);
            this.textBoxAdliyeAdi.Name = "textBoxAdliyeAdi";
            this.textBoxAdliyeAdi.Size = new System.Drawing.Size(256, 20);
            this.textBoxAdliyeAdi.TabIndex = 7;
            // 
            // FormAdliyeEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.buttonKaydet);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxAdliyeAdres);
            this.Controls.Add(this.textBoxAdliyeTelNo);
            this.Controls.Add(this.textBoxAdliyeAdi);
            this.Name = "FormAdliyeEkle";
            this.Text = "ADLİYE EKLE";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonKaydet;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxAdliyeAdres;
        private System.Windows.Forms.TextBox textBoxAdliyeTelNo;
        private System.Windows.Forms.TextBox textBoxAdliyeAdi;
    }
}
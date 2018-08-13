namespace HukukBuroOtomasyonu.Adliye
{
    partial class FormAdliyeGuncelle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAdliyeGuncelle));
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxAdliyeAra = new System.Windows.Forms.TextBox();
            this.buttonAdliyeGuncelle = new System.Windows.Forms.Button();
            this.buttonListele = new System.Windows.Forms.Button();
            this.buttonAdliyeAdiAra = new System.Windows.Forms.Button();
            this.dataGridViewAdliyeler = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAdliyeler)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(239, 439);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 38;
            this.label1.Text = "ADLİYE ADI";
            // 
            // textBoxAdliyeAra
            // 
            this.textBoxAdliyeAra.Location = new System.Drawing.Point(334, 436);
            this.textBoxAdliyeAra.Name = "textBoxAdliyeAra";
            this.textBoxAdliyeAra.Size = new System.Drawing.Size(276, 20);
            this.textBoxAdliyeAra.TabIndex = 37;
            // 
            // buttonAdliyeGuncelle
            // 
            this.buttonAdliyeGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonAdliyeGuncelle.Location = new System.Drawing.Point(768, 523);
            this.buttonAdliyeGuncelle.Name = "buttonAdliyeGuncelle";
            this.buttonAdliyeGuncelle.Size = new System.Drawing.Size(117, 39);
            this.buttonAdliyeGuncelle.TabIndex = 36;
            this.buttonAdliyeGuncelle.Text = "GÜNCELLE";
            this.buttonAdliyeGuncelle.UseVisualStyleBackColor = true;
            this.buttonAdliyeGuncelle.Click += new System.EventHandler(this.buttonAdliyeGuncelle_Click);
            // 
            // buttonListele
            // 
            this.buttonListele.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonListele.Location = new System.Drawing.Point(-1, 523);
            this.buttonListele.Name = "buttonListele";
            this.buttonListele.Size = new System.Drawing.Size(117, 39);
            this.buttonListele.TabIndex = 39;
            this.buttonListele.Text = "LİSTELE";
            this.buttonListele.UseVisualStyleBackColor = true;
            this.buttonListele.Click += new System.EventHandler(this.buttonListele_Click);
            // 
            // buttonAdliyeAdiAra
            // 
            this.buttonAdliyeAdiAra.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonAdliyeAdiAra.BackgroundImage")));
            this.buttonAdliyeAdiAra.Location = new System.Drawing.Point(628, 425);
            this.buttonAdliyeAdiAra.Name = "buttonAdliyeAdiAra";
            this.buttonAdliyeAdiAra.Size = new System.Drawing.Size(40, 40);
            this.buttonAdliyeAdiAra.TabIndex = 123;
            this.buttonAdliyeAdiAra.UseVisualStyleBackColor = true;
            this.buttonAdliyeAdiAra.Click += new System.EventHandler(this.buttonAdliyeAdiAra_Click);
            // 
            // dataGridViewAdliyeler
            // 
            this.dataGridViewAdliyeler.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridViewAdliyeler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAdliyeler.Location = new System.Drawing.Point(259, 0);
            this.dataGridViewAdliyeler.Name = "dataGridViewAdliyeler";
            this.dataGridViewAdliyeler.Size = new System.Drawing.Size(448, 320);
            this.dataGridViewAdliyeler.TabIndex = 124;
            // 
            // FormAdliyeGuncelle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.dataGridViewAdliyeler);
            this.Controls.Add(this.buttonAdliyeAdiAra);
            this.Controls.Add(this.buttonListele);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxAdliyeAra);
            this.Controls.Add(this.buttonAdliyeGuncelle);
            this.Name = "FormAdliyeGuncelle";
            this.Text = "ADLİYE GÜNCELLE";
            this.Load += new System.EventHandler(this.FormAdliyeGuncelle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAdliyeler)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxAdliyeAra;
        private System.Windows.Forms.Button buttonAdliyeGuncelle;
        private System.Windows.Forms.Button buttonListele;
        private System.Windows.Forms.Button buttonAdliyeAdiAra;
        private System.Windows.Forms.DataGridView dataGridViewAdliyeler;
    }
}
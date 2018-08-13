namespace HukukBuroOtomasyonu.Personel_Islemleri
{
    partial class FormPersonelSil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPersonelSil));
            this.dataGridViewPersoneller = new System.Windows.Forms.DataGridView();
            this.comboBoxPersonel = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonSil = new System.Windows.Forms.Button();
            this.buttonPersonelAdiAra = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPersoneller)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewPersoneller
            // 
            this.dataGridViewPersoneller.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridViewPersoneller.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPersoneller.Location = new System.Drawing.Point(1, 0);
            this.dataGridViewPersoneller.Name = "dataGridViewPersoneller";
            this.dataGridViewPersoneller.Size = new System.Drawing.Size(883, 368);
            this.dataGridViewPersoneller.TabIndex = 40;
            // 
            // comboBoxPersonel
            // 
            this.comboBoxPersonel.FormattingEnabled = true;
            this.comboBoxPersonel.Location = new System.Drawing.Point(347, 429);
            this.comboBoxPersonel.Name = "comboBoxPersonel";
            this.comboBoxPersonel.Size = new System.Drawing.Size(245, 21);
            this.comboBoxPersonel.TabIndex = 41;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(279, 432);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 42;
            this.label1.Text = "Personel";
            // 
            // buttonSil
            // 
            this.buttonSil.Location = new System.Drawing.Point(419, 491);
            this.buttonSil.Name = "buttonSil";
            this.buttonSil.Size = new System.Drawing.Size(119, 38);
            this.buttonSil.TabIndex = 43;
            this.buttonSil.Text = "SİL";
            this.buttonSil.UseVisualStyleBackColor = true;
            this.buttonSil.Click += new System.EventHandler(this.buttonSil_Click);
            // 
            // buttonPersonelAdiAra
            // 
            this.buttonPersonelAdiAra.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonPersonelAdiAra.BackgroundImage")));
            this.buttonPersonelAdiAra.Location = new System.Drawing.Point(613, 418);
            this.buttonPersonelAdiAra.Name = "buttonPersonelAdiAra";
            this.buttonPersonelAdiAra.Size = new System.Drawing.Size(40, 40);
            this.buttonPersonelAdiAra.TabIndex = 128;
            this.buttonPersonelAdiAra.UseVisualStyleBackColor = true;
            this.buttonPersonelAdiAra.Click += new System.EventHandler(this.buttonPersonelAdiAra_Click);
            // 
            // FormPersonelSil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.buttonPersonelAdiAra);
            this.Controls.Add(this.buttonSil);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxPersonel);
            this.Controls.Add(this.dataGridViewPersoneller);
            this.Name = "FormPersonelSil";
            this.Text = "PERSONEL SİL";
            this.Load += new System.EventHandler(this.FormPersonelSil_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPersoneller)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewPersoneller;
        private System.Windows.Forms.ComboBox comboBoxPersonel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonSil;
        private System.Windows.Forms.Button buttonPersonelAdiAra;
    }
}
namespace HukukBuroOtomasyonu.Adliye
{
    partial class FormAdliyeSil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAdliyeSil));
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxAdliyeAra = new System.Windows.Forms.TextBox();
            this.buttonAdliyeSil = new System.Windows.Forms.Button();
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
            this.label1.Location = new System.Drawing.Point(243, 437);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 42;
            this.label1.Text = "ADLİYE ADI";
            // 
            // textBoxAdliyeAra
            // 
            this.textBoxAdliyeAra.Location = new System.Drawing.Point(325, 434);
            this.textBoxAdliyeAra.Name = "textBoxAdliyeAra";
            this.textBoxAdliyeAra.Size = new System.Drawing.Size(276, 20);
            this.textBoxAdliyeAra.TabIndex = 41;
            // 
            // buttonAdliyeSil
            // 
            this.buttonAdliyeSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonAdliyeSil.Location = new System.Drawing.Point(777, 520);
            this.buttonAdliyeSil.Name = "buttonAdliyeSil";
            this.buttonAdliyeSil.Size = new System.Drawing.Size(108, 42);
            this.buttonAdliyeSil.TabIndex = 40;
            this.buttonAdliyeSil.Text = "SİL";
            this.buttonAdliyeSil.UseVisualStyleBackColor = true;
            this.buttonAdliyeSil.Click += new System.EventHandler(this.buttonAdliyeSil_Click);
            // 
            // buttonListele
            // 
            this.buttonListele.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonListele.Location = new System.Drawing.Point(-1, 523);
            this.buttonListele.Name = "buttonListele";
            this.buttonListele.Size = new System.Drawing.Size(106, 39);
            this.buttonListele.TabIndex = 62;
            this.buttonListele.Text = "LİSTELE";
            this.buttonListele.UseVisualStyleBackColor = true;
            this.buttonListele.Click += new System.EventHandler(this.buttonListele_Click);
            // 
            // buttonAdliyeAdiAra
            // 
            this.buttonAdliyeAdiAra.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonAdliyeAdiAra.BackgroundImage")));
            this.buttonAdliyeAdiAra.Location = new System.Drawing.Point(618, 423);
            this.buttonAdliyeAdiAra.Name = "buttonAdliyeAdiAra";
            this.buttonAdliyeAdiAra.Size = new System.Drawing.Size(40, 40);
            this.buttonAdliyeAdiAra.TabIndex = 63;
            this.buttonAdliyeAdiAra.UseVisualStyleBackColor = true;
            this.buttonAdliyeAdiAra.Click += new System.EventHandler(this.buttonAdliyeAdiAra_Click);
            // 
            // dataGridViewAdliyeler
            // 
            this.dataGridViewAdliyeler.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridViewAdliyeler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAdliyeler.Location = new System.Drawing.Point(246, 0);
            this.dataGridViewAdliyeler.Name = "dataGridViewAdliyeler";
            this.dataGridViewAdliyeler.Size = new System.Drawing.Size(448, 320);
            this.dataGridViewAdliyeler.TabIndex = 64;
            // 
            // FormAdliyeSil
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
            this.Controls.Add(this.buttonAdliyeSil);
            this.Name = "FormAdliyeSil";
            this.Text = "ADLİYE SİL";
            this.Load += new System.EventHandler(this.FormAdliyeSil_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAdliyeler)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxAdliyeAra;
        private System.Windows.Forms.Button buttonAdliyeSil;
        private System.Windows.Forms.Button buttonListele;
        private System.Windows.Forms.Button buttonAdliyeAdiAra;
        private System.Windows.Forms.DataGridView dataGridViewAdliyeler;
    }
}
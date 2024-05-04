namespace OTOBUS_SINIFI
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.cmbSeferAdi = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbSeferSaati = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbModel = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtKoltukSayisi = new System.Windows.Forms.TextBox();
            this.btnOtobusEkle = new System.Windows.Forms.Button();
            this.lstOutput = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sefer Adı:";
            // 
            // cmbSeferAdi
            // 
            this.cmbSeferAdi.FormattingEnabled = true;
            this.cmbSeferAdi.Location = new System.Drawing.Point(138, 10);
            this.cmbSeferAdi.Name = "cmbSeferAdi";
            this.cmbSeferAdi.Size = new System.Drawing.Size(224, 28);
            this.cmbSeferAdi.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Sefer Saati:";
            // 
            // cmbSeferSaati
            // 
            this.cmbSeferSaati.FormattingEnabled = true;
            this.cmbSeferSaati.Location = new System.Drawing.Point(138, 44);
            this.cmbSeferSaati.Name = "cmbSeferSaati";
            this.cmbSeferSaati.Size = new System.Drawing.Size(224, 28);
            this.cmbSeferSaati.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Model:";
            // 
            // cmbModel
            // 
            this.cmbModel.FormattingEnabled = true;
            this.cmbModel.Location = new System.Drawing.Point(138, 78);
            this.cmbModel.Name = "cmbModel";
            this.cmbModel.Size = new System.Drawing.Size(224, 28);
            this.cmbModel.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Koltuk Sayısı:";
            // 
            // txtKoltukSayisi
            // 
            this.txtKoltukSayisi.Location = new System.Drawing.Point(138, 112);
            this.txtKoltukSayisi.Name = "txtKoltukSayisi";
            this.txtKoltukSayisi.Size = new System.Drawing.Size(224, 26);
            this.txtKoltukSayisi.TabIndex = 2;
            // 
            // btnOtobusEkle
            // 
            this.btnOtobusEkle.Location = new System.Drawing.Point(17, 148);
            this.btnOtobusEkle.Name = "btnOtobusEkle";
            this.btnOtobusEkle.Size = new System.Drawing.Size(345, 50);
            this.btnOtobusEkle.TabIndex = 3;
            this.btnOtobusEkle.Text = "OTOBUS EKLE";
            this.btnOtobusEkle.UseVisualStyleBackColor = true;
            this.btnOtobusEkle.Click += new System.EventHandler(this.btnOtobusEkle_Click);
            // 
            // lstOutput
            // 
            this.lstOutput.FormattingEnabled = true;
            this.lstOutput.ItemHeight = 20;
            this.lstOutput.Location = new System.Drawing.Point(369, 13);
            this.lstOutput.Name = "lstOutput";
            this.lstOutput.Size = new System.Drawing.Size(742, 184);
            this.lstOutput.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1123, 210);
            this.Controls.Add(this.lstOutput);
            this.Controls.Add(this.btnOtobusEkle);
            this.Controls.Add(this.txtKoltukSayisi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbModel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbSeferSaati);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbSeferAdi);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbSeferAdi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbSeferSaati;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbModel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtKoltukSayisi;
        private System.Windows.Forms.Button btnOtobusEkle;
        private System.Windows.Forms.ListBox lstOutput;
    }
}


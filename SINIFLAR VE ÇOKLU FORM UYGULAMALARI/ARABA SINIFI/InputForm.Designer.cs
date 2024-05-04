namespace ARABA_SINIFI
{
    partial class InputForm
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
            this.txtYear = new System.Windows.Forms.MaskedTextBox();
            this.txtMake = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(156, 72);
            this.txtYear.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtYear.Mask = "0000";
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(103, 26);
            this.txtYear.TabIndex = 9;
            // 
            // txtMake
            // 
            this.txtMake.Location = new System.Drawing.Point(156, 14);
            this.txtMake.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMake.Name = "txtMake";
            this.txtMake.Size = new System.Drawing.Size(230, 26);
            this.txtMake.TabIndex = 8;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(276, 126);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(112, 35);
            this.btnSubmit.TabIndex = 7;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 77);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Enter Car Year";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Enter Car Make";
            // 
            // InputForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 176);
            this.Controls.Add(this.txtYear);
            this.Controls.Add(this.txtMake);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "InputForm";
            this.Text = "InputForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox txtYear;
        private System.Windows.Forms.TextBox txtMake;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}
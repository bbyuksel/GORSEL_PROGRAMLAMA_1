namespace ARABA_SINIFI
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSpeed = new System.Windows.Forms.TextBox();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.txtMake = new System.Windows.Forms.TextBox();
            this.btnAddCar = new System.Windows.Forms.Button();
            this.btnBreak = new System.Windows.Forms.Button();
            this.btnAccelerate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 129);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 20);
            this.label3.TabIndex = 17;
            this.label3.Text = "Current Speed";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 72);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 20);
            this.label2.TabIndex = 16;
            this.label2.Text = "Car Year";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 20);
            this.label1.TabIndex = 15;
            this.label1.Text = "Car Make";
            // 
            // txtSpeed
            // 
            this.txtSpeed.Location = new System.Drawing.Point(138, 125);
            this.txtSpeed.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSpeed.Name = "txtSpeed";
            this.txtSpeed.ReadOnly = true;
            this.txtSpeed.Size = new System.Drawing.Size(233, 26);
            this.txtSpeed.TabIndex = 14;
            this.txtSpeed.TabStop = false;
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(138, 68);
            this.txtYear.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtYear.Name = "txtYear";
            this.txtYear.ReadOnly = true;
            this.txtYear.Size = new System.Drawing.Size(233, 26);
            this.txtYear.TabIndex = 13;
            this.txtYear.TabStop = false;
            // 
            // txtMake
            // 
            this.txtMake.Location = new System.Drawing.Point(138, 14);
            this.txtMake.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMake.Name = "txtMake";
            this.txtMake.ReadOnly = true;
            this.txtMake.Size = new System.Drawing.Size(233, 26);
            this.txtMake.TabIndex = 12;
            this.txtMake.TabStop = false;
            // 
            // btnAddCar
            // 
            this.btnAddCar.Location = new System.Drawing.Point(17, 189);
            this.btnAddCar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAddCar.Name = "btnAddCar";
            this.btnAddCar.Size = new System.Drawing.Size(112, 35);
            this.btnAddCar.TabIndex = 9;
            this.btnAddCar.Text = "Add Car";
            this.btnAddCar.UseVisualStyleBackColor = true;
            this.btnAddCar.Click += new System.EventHandler(this.btnAddCar_Click);
            // 
            // btnBreak
            // 
            this.btnBreak.Enabled = false;
            this.btnBreak.Location = new System.Drawing.Point(259, 189);
            this.btnBreak.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBreak.Name = "btnBreak";
            this.btnBreak.Size = new System.Drawing.Size(112, 35);
            this.btnBreak.TabIndex = 11;
            this.btnBreak.Text = "Break";
            this.btnBreak.UseVisualStyleBackColor = true;
            this.btnBreak.Click += new System.EventHandler(this.btnBreak_Click);
            // 
            // btnAccelerate
            // 
            this.btnAccelerate.Enabled = false;
            this.btnAccelerate.Location = new System.Drawing.Point(138, 189);
            this.btnAccelerate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAccelerate.Name = "btnAccelerate";
            this.btnAccelerate.Size = new System.Drawing.Size(112, 35);
            this.btnAccelerate.TabIndex = 10;
            this.btnAccelerate.Text = "Accelerate";
            this.btnAccelerate.UseVisualStyleBackColor = true;
            this.btnAccelerate.Click += new System.EventHandler(this.btnAccelerate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 255);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSpeed);
            this.Controls.Add(this.txtYear);
            this.Controls.Add(this.txtMake);
            this.Controls.Add(this.btnAddCar);
            this.Controls.Add(this.btnBreak);
            this.Controls.Add(this.btnAccelerate);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSpeed;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.TextBox txtMake;
        private System.Windows.Forms.Button btnAddCar;
        private System.Windows.Forms.Button btnBreak;
        private System.Windows.Forms.Button btnAccelerate;
    }
}


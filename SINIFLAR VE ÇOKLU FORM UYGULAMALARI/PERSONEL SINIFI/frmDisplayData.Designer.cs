namespace PERSONEL_SINIFI
{
    partial class frmDisplayData
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
            this.btnReturn = new System.Windows.Forms.Button();
            this.lstOutput = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(139, 310);
            this.btnReturn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(112, 69);
            this.btnReturn.TabIndex = 3;
            this.btnReturn.Text = "Return to Main Form";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // lstOutput
            // 
            this.lstOutput.ItemHeight = 20;
            this.lstOutput.Location = new System.Drawing.Point(13, 14);
            this.lstOutput.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lstOutput.Name = "lstOutput";
            this.lstOutput.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.lstOutput.Size = new System.Drawing.Size(388, 264);
            this.lstOutput.TabIndex = 2;
            this.lstOutput.TabStop = false;
            // 
            // frmDisplayData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 397);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.lstOutput);
            this.Name = "frmDisplayData";
            this.Text = "frmDisplayData";
            this.Load += new System.EventHandler(this.frmDisplayData_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.ListBox lstOutput;
    }
}
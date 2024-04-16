using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SATIŞ_VERGİSİ
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double salesAmount;
            const double STATE_TAX=0.04;
            const double COUNTY_TAX = 0.02;
            double totalSalesTax;
            double totalSales;
            double totalStateTax;
            double totalCountyTax;

            salesAmount = Convert.ToDouble(txtSalesAmount.Text);
            totalStateTax = salesAmount * STATE_TAX;
            totalCountyTax = salesAmount * COUNTY_TAX;
            totalSalesTax = totalStateTax + totalCountyTax;
            totalSales = salesAmount + totalSalesTax;

            lstOutput.Items.Add("Satış Tutarı: \t" + salesAmount.ToString("C"));
            lstOutput.Items.Add("İl Vergisi: \t" + totalStateTax.ToString("C"));
            lstOutput.Items.Add("Bölge Vergisi: \t" + totalCountyTax.ToString("C"));
            lstOutput.Items.Add("Toplam Sayış Vergisi: \t" + totalSalesTax.ToString("C"));
            lstOutput.Items.Add("Toplam Tutar: \t" + totalSales.ToString("C"));


        }


    }
}

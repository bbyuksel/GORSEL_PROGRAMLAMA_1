using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADİSYON
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            const double TIP = 0.15;
            const double TAX = 0.08;
            double costOfMeal;
            double totalAmount; //camelCase

            double.TryParse(txtMealCost.Text, out costOfMeal);
            totalAmount = costOfMeal + (costOfMeal * TIP) + (costOfMeal * TAX);
            lstOutput.Items.Add("Yemek: \t" + costOfMeal.ToString("C"));
            lstOutput.Items.Add("KDV: \t" + TAX.ToString("P"));
            lstOutput.Items.Add("Küver: \t" + TIP.ToString("P"));
            lstOutput.Items.Add("Toplam Ödenecek Tutar: \t" + totalAmount.ToString("C"));
        }
    }
}

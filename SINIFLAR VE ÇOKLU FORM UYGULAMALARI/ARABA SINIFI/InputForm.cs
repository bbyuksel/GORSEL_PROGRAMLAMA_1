using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ARABA_SINIFI
{
    public partial class InputForm : Form
    {
        public InputForm()
        {
            InitializeComponent();
        }

        public Car car;
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string make = txtMake.Text;
            int year;

            if (!string.IsNullOrWhiteSpace(make) && int.TryParse(txtYear.Text, out year))
            {
                car = new Car(make, year);
                this.Close();
            }
            else
                MessageBox.Show("Please enter valid input", "Invalid input");
        }
    }
}

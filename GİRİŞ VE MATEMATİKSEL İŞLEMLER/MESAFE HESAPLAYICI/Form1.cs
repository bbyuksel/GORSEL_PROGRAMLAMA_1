using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MESAFE_HESAPLAYICI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtCalculate_Click(object sender, EventArgs e)
        {
            int speed;
            decimal timeTravelled;
            decimal distance;

            timeTravelled = Convert.ToDecimal(txtTime.Text);
            speed = Convert.ToInt32(txtSpeed.Text);

            distance = timeTravelled * speed;

            txtDistance.Text = distance.ToString();
        }
    }
}

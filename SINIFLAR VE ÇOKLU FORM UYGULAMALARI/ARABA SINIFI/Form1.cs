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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Car car;
        private void btnAddCar_Click(object sender, EventArgs e)
        {
            InputForm frm2 = new InputForm();
            frm2.ShowDialog();
            car = frm2.car;

            DisplayCar();
            btnAccelerate.Enabled = true;
            btnBreak.Enabled = true;
        }
        private void DisplayCar()
        {
            txtMake.Text = car.Make;
            txtYear.Text = car.Year.ToString();
            txtSpeed.Text = car.Speed.ToString();
        }

        private void btnAccelerate_Click(object sender, EventArgs e)
        {
            car.Accelarate();
            txtSpeed.Text = car.Speed.ToString();
        }

        private void btnBreak_Click(object sender, EventArgs e)
        {
            if (car.Speed > 0)
                car.Break();

            txtSpeed.Text = car.Speed.ToString();
        }
    }
}

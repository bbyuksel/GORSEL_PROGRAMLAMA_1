using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OTOBUS_SINIFI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            cmbSeferAdi.Items.Add("İSTANBUL-ANKARA");
            cmbSeferAdi.Items.Add("İSTANBUL-İZMİR");
            cmbSeferSaati.Items.Add("19.00");
            cmbSeferSaati.Items.Add("21.00");
            cmbModel.Items.Add("SETRA");
            cmbModel.Items.Add("TRAVEGO");
            
        }

        private void btnOtobusEkle_Click(object sender, EventArgs e)
        {
            try
            {
                string seferAdi = cmbSeferAdi.Text;
                string seferSaati = cmbSeferSaati.Text;
                string model = cmbModel.Text;
                int koltukSayisi = int.Parse(txtKoltukSayisi.Text);

                Otobus yeniOtobus = new Otobus(seferAdi, seferSaati, model, koltukSayisi);
                lstOutput.Items.Add(yeniOtobus.ToString());
            }
            catch (ArgumentOutOfRangeException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lütfen tüm bilgileri doğru girin!");
            }
        }
    }
}

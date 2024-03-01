using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ///butona basıldığında çalışacak kodlar
            Close();
        }

        private void button2_Click(object sender, EventArgs e) //mesaj kutusu göster
        {
            MessageBox.Show("Merhaba Dünya","Selamlama");
        }

        private void button3_Click(object sender, EventArgs e) //textbox a ali uzun yaz
        {
            textBox1.Text = "ALİ UZUN";
            textBox1.ForeColor = Color.Blue;
        }

        private void button4_Click(object sender, EventArgs e) //form başlığını değiştir
        {
            this.Text = "BASİT KODLAR";
        }

        private void button5_Click(object sender, EventArgs e)// textboxın içini temizle
        {
            // 3 şekilde yapabiliriz.
           // textBox1.Text = "";
           // textBox1.Clear();
            textBox1.Text = String.Empty;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            //listBox1.Items.Add("ali uzun");
            for (int i = 0; i < 100; i++)
            {
                listBox1.Items.Add(i);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            button7.BackColor = Color.Yellow;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            //button7.Hide();
            button7.Visible = false;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox2.Text = "1";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            int deger = int.Parse(textBox2.Text);
            deger+=5;
            textBox2.Text = deger.ToString();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            int deger = int.Parse(textBox2.Text);
            deger-=5;
            textBox2.Text = deger.ToString();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            BackColor = Color.Blue;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            button13.Text = button13.Text == "GİZLE" ? "GÖSTER" : "GİZLE";
            
            foreach (Control x in Controls)
            {
                if (x !=button13)
                {
                    x.Visible = !x.Visible;
                }
                
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Hide();
        }
    }
}

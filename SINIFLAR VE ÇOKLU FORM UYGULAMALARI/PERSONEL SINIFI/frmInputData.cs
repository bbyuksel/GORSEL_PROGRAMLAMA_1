using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PERSONEL_SINIFI
{
    public partial class frmInputData : Form
    {
        public frmInputData()
        {
            InitializeComponent();
        }
        public static List<PersonEntry> persons = new List<PersonEntry>();
        public static int selectedPerson;

        private void frmInputData_Load(object sender, EventArgs e)
        {
            try
            {
                StreamReader sr = new StreamReader("Data.txt");
                while (!sr.EndOfStream)
                {
                    string[] s = sr.ReadLine().Split(',');
                    PersonEntry person = new PersonEntry(s[0], s[1], s[2]);
                    persons.Add(person);
                }

                PopulateListBox();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void lstData_SelectedIndexChanged(object sender, EventArgs e)
        {
            //MessageBox.Show(lstData.SelectedIndex.ToString());
            selectedPerson = lstData.SelectedIndex;
            frmDisplayData form2 = new frmDisplayData();
            form2.ShowDialog();
        }
        private void PopulateListBox()
        {
            foreach (PersonEntry p in persons)
            {
                lstData.Items.Add(p.Name);
            }
        }
    }
}

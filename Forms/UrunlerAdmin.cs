using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Pinar_bunu_demenolursun
{
    public partial class UrunlerAdmin : Form
    {
        public UrunlerAdmin()
        {
            InitializeComponent();
           
        }

        private void checkedurunekle_SelectedIndexChanged(object sender, EventArgs e)
        {
            
          
        }

        private void btnurunekle_Click(object sender, EventArgs e)
        {
            mevcuturunler.Items.Add(checkedListBox1.SelectedItem);
            mevcuturunler.ClearSelected();
        }

        private void btnuruncikar_Click(object sender, EventArgs e)
        {
            while (mevcuturunler.CheckedItems.Count > 0)
            {
                mevcuturunler.Items.RemoveAt(mevcuturunler.CheckedIndices[0]);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StreamReader admin = new StreamReader(Application.StartupPath + "\\urunler.txt");
            string c;
            List<string> Urunler = new List<string>();


            while ((c = admin.ReadLine()) != null)
            {
                Urunler.Add(c);

            }

            admin.Close();
            
            StreamWriter sw = new StreamWriter(Application.StartupPath + "\\urunler.txt");
            foreach (string ur in Urunler)
            {
                sw.WriteLine(ur);

            }
            sw.WriteLine(textBox1.Text.ToUpper() + ", " + textBox2.Text.ToUpper() + "  TL, " + textBox3.Text.ToUpper() + " GR, "+ textBox4.Text.ToUpper());
            sw.Close();
           
            StreamReader urunler = new StreamReader(Application.StartupPath + "\\urunler.txt");
            string b;

            while ((b = urunler.ReadLine()) != null)
            {
                string[] _split = b.Split(',');
                checkedListBox1.Items.Add(_split[0] + " " + _split[1] + " " + _split[2] + " " + _split[3]);
            }
            urunler.Close();
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = ""; 

        }
        


        private void btnurunguncelle_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            while (checkedListBox1.CheckedItems.Count > 0)
            {
                checkedListBox1.Items.RemoveAt(checkedListBox1.CheckedIndices[0]);
            }
            StreamReader admin = new StreamReader(Application.StartupPath + "\\urunler.txt");
            string a;
            List<string> Urunler = new List<string>();


            while ((a = admin.ReadLine()) != null)
            {
                Urunler.Clear();

            }
        }

        private void UrunlerAdmin_Load(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

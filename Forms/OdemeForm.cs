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
    public partial class OdemeForm : Form
    {
        public OdemeForm()
        {

            InitializeComponent();

            textBox1.Enabled = false;
            maskedTextBox4.Enabled = false;
            maskedTextBox3.Enabled = false;
            maskedTextBox2.Enabled = false;
            maskedTextBox1.Enabled = false;
            button1.Enabled = false;

            StreamReader ad = new StreamReader(Application.StartupPath + "\\toplamfiyat.txt");
            string f;

            while ((f = ad.ReadLine()) != null)
            {
                string[] ss = f.Split();
                label3.Text = ss[0];

            }
            ad.Close();


        }





        private void OdemeForm_Load(object sender, EventArgs e)
        {



        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            maskedTextBox1.Enabled = true;
            maskedTextBox2.Enabled = true;
            maskedTextBox3.Enabled = true;
            button1.Enabled = true;
            textBox1.Enabled = false;
            maskedTextBox4.Enabled = false;



        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            button1.Enabled = true;
            textBox1.Enabled = false;
            maskedTextBox4.Enabled = false;
            maskedTextBox1.Enabled = false;
            maskedTextBox2.Enabled = false;
            maskedTextBox3.Enabled = false;

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Enabled = true;
            maskedTextBox4.Enabled = true;
            maskedTextBox1.Enabled = false;
            maskedTextBox2.Enabled = false;
            maskedTextBox3.Enabled = false;

        }


        private void button1_Click(object sender, EventArgs e)
        {


            if (radioButton1.Checked)
            {
                StreamReader dm = new StreamReader(Application.StartupPath + "\\kartlar.txt");
                string a;
                List<string> kartlar = new List<string>();

                KrediKarti kr = new KrediKarti();
                kr.KartBilgileri1(maskedTextBox1.Text);
                kr.KartBilgileri2(maskedTextBox2.Text);
                kr.KartBilgileri3(maskedTextBox3.Text);

                while ((a = dm.ReadLine()) != null)
                {
                    kartlar.Add(a);

                }

                dm.Close();
                StreamWriter sw = new StreamWriter(Application.StartupPath + "\\kartlar.txt");
                foreach (string idsif in kartlar)
                {
                    sw.WriteLine(idsif);

                }
                sw.WriteLine(maskedTextBox1.Text + "," + maskedTextBox2.Text + "," + maskedTextBox3.Text);
                sw.Close();

                MessageBox.Show("Ödemeniz Alındı. Bizi tercih ettğiniz için teşekkürler.");

            }

            else if (radioButton2.Checked)
            {
                StreamReader dm = new StreamReader(Application.StartupPath + "\\kartlar.txt");
                string a;
                List<string> kartlar = new List<string>();

                MessageBox.Show("Ödemeniz alınacak.");
            }
            else if (radioButton3.Checked)
            {

                StreamReader dm = new StreamReader(Application.StartupPath + "\\kartlar.txt");
                string a;
                List<string> cekler = new List<string>();

                MessageBox.Show("Ödemeniz alınacak.");
                Cek ck = new Cek();
                ck.CekBilgiler1(textBox1.Text);
                ck.CekBilgiler2(maskedTextBox4.Text);

                while ((a = dm.ReadLine()) != null)
                {
                    cekler.Add(a);

                }

                dm.Close();
                StreamWriter sw = new StreamWriter(Application.StartupPath + "\\cekler.txt");
                foreach (string idsif in cekler)
                {
                    sw.WriteLine(idsif);

                }
                sw.WriteLine(textBox1.Text + "," + maskedTextBox4.Text);
                sw.Close();

                MessageBox.Show("Ödemeniz Alındı. Bizi tercih ettğiniz için teşekkürler.");
            }


        }
    }
}
    


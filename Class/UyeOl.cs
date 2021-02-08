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
    public partial class UyeOl : Form
    {
        public UyeOl()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            StreamReader admin = new StreamReader(Application.StartupPath + "\\uyeol.txt");
            string a;
            List<string> karsilastirma = new List<string>();


            while ((a = admin.ReadLine()) != null)
            {
                karsilastirma.Add(a);

            }

            admin.Close();
            StreamWriter sw = new StreamWriter(Application.StartupPath + "\\uyeol.txt");
            foreach (string idsif in karsilastirma)
            {
                sw.WriteLine(idsif);

            }
            sw.WriteLine( textBox1.Text + "," + textBox2.Text + "," + txtad.Text);
            sw.Close();
            MessageBox.Show("Kaydınız başarıyla tamamlandı.");






        }

        private void UyeOl_Load(object sender, EventArgs e)
        {

        }
    }
}

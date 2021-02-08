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
    // Edibe Nuran ÖZKUL
    // Duygu EROĞLU
    public partial class GirisYap : Form
    {
        public GirisYap()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void kullanıcıToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            textBox1.Visible = true;
            textBox2.Visible = true;
            label1.Visible = true;
            label2.Visible = true;
            button1.Visible = false;
            btnadmingirisyap.Visible = true;
        }

        private void üyeOlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UyeOl uy = new UyeOl();
            uy.Show();



        }

        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Visible = true;
            textBox2.Visible = true;
            label1.Visible = true;
            label2.Visible = true;
            button1.Visible = true;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            StreamReader uyeol = new StreamReader(Application.StartupPath + "\\uyeol.txt");
            string j;

            while ((j = uyeol.ReadLine()) != null)
            {
                string[] b = j.Split(',');
                if (b[0] == textBox1.Text)
                {
                    if (b[1] == textBox2.Text)
                        MessageBox.Show("Giriş Başarılı");
                       
                }

            }
            uyeol.Close();
            Urunler lr = new Urunler();
            lr.Show();
            this.Hide();
        }

        private void btnadmingirisyap_Click(object sender, EventArgs e)
        {
            StreamReader kullanici = new StreamReader(Application.StartupPath + "\\kullanici.txt");
            string k;

            while ((k = kullanici.ReadLine()) != null)
            {
                string[] _split = k.Split(',');
                if (_split[0] == textBox1.Text)
                {
                    if (_split[1] == textBox2.Text)
                        MessageBox.Show("Giriş Başarılı");

                }
                
            }
            kullanici.Close();
            UrunlerAdmin ad = new UrunlerAdmin();
            ad.Show();
            this.Hide();
           
        }
    }
}

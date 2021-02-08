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
    public partial class Urunler : Form
    {
        public Urunler()
        {
            InitializeComponent();
            string sonfiyat;
            label1.Visible = false;
        }


        private void Urunler_Load(object sender, EventArgs e)
        {
          StreamReader urunler = new StreamReader(Application.StartupPath + "\\urunler.txt");
          string a;

          while ((a = urunler.ReadLine()) != null)
          {
              string[] b = a.Split(',');
              listBox1.Items.Add(b[0] + " " + b[1] + " " + b[2] + " " + b[3]);
              listBox1.Items.Add(Environment.NewLine);
              listBox1.Items.Add(Environment.NewLine);
              
               
          }
          urunler.Close();
           
            }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        
        }

        private void button1_Click(object sender, EventArgs e)
        {   StreamReader urunler = new StreamReader(Application.StartupPath + "\\urunler.txt");
          string b;
          decimal toplamfiyat=0;
          decimal toptoplamfiyat = 0; 
           

         
            while ((b = urunler.ReadLine()) != null)
          {
             
              string[] a = b.Split(',');
              if (a[0] == "KULAKLIK") toplamfiyat = (numericUpDown1.Value * 35);
              if (a[0] == "MOUSE")  toplamfiyat = (numericUpDown2.Value * 45);
              if (a[0] == "TELEFON KAP") toplamfiyat = (numericUpDown3.Value * 15);
              if (a[0] == "KORUYUCU CAM") toplamfiyat = (numericUpDown4.Value * 10);
              if (a[0] == "KİTAP") toplamfiyat = (numericUpDown5.Value * 20);
              if (a[0] == "HOPARLÖR") toplamfiyat = (numericUpDown6.Value * 60);

              toptoplamfiyat = toplamfiyat + toptoplamfiyat;
          }
          urunler.Close();
         
         label1.Text = toptoplamfiyat.ToString();
         label1.Visible = true;
        
         StreamWriter sw = new StreamWriter(Application.StartupPath + "\\toplamfiyat.txt");
       
         sw.WriteLine(toptoplamfiyat);
         sw.Close();
         
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OdemeForm ode = new OdemeForm();
            ode.Show();
            this.Hide();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
          

        }

       
    }


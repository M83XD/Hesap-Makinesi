using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
         
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            try {
                double sonuc = 0;
                double s1 = double.Parse(textBox1.Text);
                double s2 = double.Parse(textBox2.Text);
                sonuc = s1 + s2;
                label3.Text = "Sonuç : " + sonuc;
            }
            catch (Exception hata)
            {
                MessageBox.Show("Hatalı işlem. Hata : " + hata.Message);
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            try {
                double sonuc = 0;
                double s1 = double.Parse(textBox1.Text);
                double s2 = double.Parse(textBox2.Text);
                sonuc = s1 - s2;
                label3.Text = "Sonuç : " + sonuc;
            }
            catch (Exception hata)
            {
                MessageBox.Show("Hatalı işlem. Hata : " + hata.Message);
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            try {
                double sonuc = 0;
                double s1 = double.Parse(textBox1.Text);
                double s2 = double.Parse(textBox2.Text);
                sonuc = s1 / s2;
                label3.Text = "Sonuç : " + sonuc;
            }
            catch (Exception hata)
            {
                MessageBox.Show("Hatalı işlem. Hata : " + hata.Message);
            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            try {
                double sonuc = 0;
                double s1 = double.Parse(textBox1.Text);
                double s2 = double.Parse(textBox2.Text);
                sonuc = s1 * s2;
                label3.Text = "Sonuç : " + sonuc;
            }
            catch (Exception hata)
            {
                MessageBox.Show("Hatalı işlem. Hata : " + hata.Message);
            }
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                double sonuc = 0;
                double s1 = double.Parse(textBox1.Text);
                double s2 = double.Parse(textBox2.Text);
                sonuc = s1 % s2;
                label3.Text = "Sonuç : " + sonuc;
            }
            catch (Exception hata)
            {
                MessageBox.Show("Hatalı işlem. Hata : " + hata.Message);
            }
        }
        }
    }

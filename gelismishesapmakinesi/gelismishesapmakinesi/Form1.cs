using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gelismishesapmakinesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double sayi1, sayi2, sonuc;

        private void button3_Click(object sender, EventArgs e)
        {
            sayi1 = Convert.ToDouble(textBox1.Text);
            sonuc = System.Math.Exp(sayi1);
            textBox3.Text = sonuc.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            sayi1 = Convert.ToDouble(textBox1.Text);
            sonuc = System.Math.Cos(sayi1*(Math.PI/180));
            textBox3.Text = sonuc.ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            sayi1 = Convert.ToDouble(textBox1.Text);
            sonuc = System.Math.Pow(sayi1,3);
            textBox3.Text = sonuc.ToString();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            sayi1 = Convert.ToDouble(textBox1.Text);
            sonuc = System.Math.Log(sayi1);
            textBox3.Text = sonuc.ToString();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            sayi1 = Convert.ToDouble(textBox1.Text);
            sonuc = System.Math.Tan(sayi1*(Math.PI/180));
            textBox3.Text = sonuc.ToString();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            sayi1 = Convert.ToDouble(textBox1.Text);
            sonuc = System.Math.Pow(sayi1,2);
            textBox3.Text = sonuc.ToString();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            sayi1 = Convert.ToDouble(textBox1.Text);
            sonuc = 1 / sayi1;
            textBox3.Text = sonuc.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            sayi1 = Convert.ToDouble(textBox1.Text);
            sayi2 = Convert.ToDouble(textBox2.Text);
            sonuc = sayi1 + sayi2;
            textBox3.Text = sonuc.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            sayi1 = Convert.ToDouble(textBox1.Text);
            sayi2 = Convert.ToDouble(textBox2.Text);
            sonuc = sayi1 - sayi2;
            textBox3.Text = sonuc.ToString();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            sayi1 = Convert.ToDouble(textBox1.Text);
            sayi2 = Convert.ToDouble(textBox2.Text);
            sonuc = sayi1 * sayi2;
            textBox3.Text = sonuc.ToString();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            sayi1 = Convert.ToDouble(textBox1.Text);
            sayi2 = Convert.ToDouble(textBox2.Text);
            sonuc = sayi1 / sayi2;
            textBox3.Text = sonuc.ToString("0.00");
        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBox1.Text = " ";
            textBox2.Text = " ";
            textBox3.Text = " ";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sayi1 = Convert.ToDouble(textBox1.Text);
            sayi2 = Convert.ToDouble(textBox2.Text);
            sonuc = System.Math.Pow(sayi1, sayi2);
            textBox3.Text = sonuc.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sayi1 = Convert.ToDouble(textBox1.Text);
            sonuc=System.Math.Sin(sayi1 * (Math.PI / 180));
            textBox3.Text = sonuc.ToString();

            
        }
    }
}

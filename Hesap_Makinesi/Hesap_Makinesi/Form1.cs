using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _183311116_Hicret_AY
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }
        bool op = false;
        double sonuc = 0;
        string kontrol = "";

        private void button_7_Click(object sender, EventArgs e) //Sayıların ortak click'i
        {
            if(textBox1.Text=="0"||op)

                textBox1.Clear();
            
            op = false;
            Button buton = (Button)sender;
            textBox1.Text += buton.Text;
        }

        private void islem_click(object sender, EventArgs e)  //İşlemlerin ortak click'i
        { 
            Button buton= (Button)sender;
            string yenikontrol = buton.Text;

            if(op == true)
            {
                kontrol = yenikontrol;
            }

            if(op==false)
            {
                op = true;

            switch (kontrol)
            {
                case "+":
                    textBox1.Text = (sonuc + Double.Parse(textBox1.Text)).ToString(); 
                    break;

                case "-":
                    textBox1.Text = (sonuc - Double.Parse(textBox1.Text)).ToString();
                    break;

                case "*":
                    textBox1.Text = (sonuc * Double.Parse(textBox1.Text)).ToString();
                    break;

                case "/":
                    textBox1.Text = (sonuc / Double.Parse(textBox1.Text)).ToString();
                    break;

            }
            sonuc = Double.Parse(textBox1.Text);
            textBox1.Text = sonuc.ToString();
            kontrol = yenikontrol;

            }
        }

  
        private void button_esittir_Click(object sender, EventArgs e)
        {
            op = true;

            switch (kontrol)
            {
                case "+":
                    textBox1.Text = (sonuc + Double.Parse(textBox1.Text)).ToString();
                    break;

                case "-":
                    textBox1.Text = (sonuc - Double.Parse(textBox1.Text)).ToString();
                    break;

                case "*":
                    textBox1.Text = (sonuc * Double.Parse(textBox1.Text)).ToString();
                    break;

                case "/":
                    textBox1.Text = (sonuc / Double.Parse(textBox1.Text)).ToString();
                    break;

            }
            sonuc = Double.Parse(textBox1.Text);
            textBox1.Text = sonuc.ToString();
            kontrol = "";
            
        }

        private void button_virgul_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")  
            {
                textBox1.Text = "0";
            }

            else if (op)
                textBox1.Text = "0";

            if(!textBox1.Text.Contains("."))
            {
                textBox1.Text += ",";
            }

            op = false;
        }

        private void button_bir_bolu_Click(object sender, EventArgs e)
        {
            decimal sayi;
            sayi = decimal.Parse(textBox1.Text);

            if (textBox1.Text.Length==0)
            {
                textBox1.Text = "0";
            }

            else
            { 
                textBox1.Text = (1 / sayi).ToString();
            }
        }

        private void button_geri_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0)
            { textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1); }
        }

        private void button_karekok_Click(object sender, EventArgs e)
        {
            textBox1.Text = Math.Sqrt(Double.Parse(textBox1.Text)).ToString();
        }

        private void button_ce_Click(object sender, EventArgs e)  //Tamamını temizleme
        {
            textBox1.Text = "0";
        }

        private void button_c_Click(object sender, EventArgs e)  //Son girilen işlemi temizleme
        {
            textBox1.Text = "0";
            kontrol = "";
            sonuc = 0;
            op = false;
        }

        private void button_arti_eksi_Click(object sender, EventArgs e)
        {
            if (textBox1.Text=="")
            {
                textBox1.Text = "-";
            }

            else if (textBox1.Text=="-")
            {
                textBox1.Text = "";
            }
            else if (textBox1.Text!=""||textBox1.Text!="-")
            {
                textBox1.Text = (-1 * Double.Parse(textBox1.Text)).ToString();
            }
        }

        private void button_yuzde_Click(object sender, EventArgs e)
        {
            double sayi;
            sayi = double.Parse(textBox1.Text);

            if(op==false)
            {
                textBox1.Text = "0";
            }
            else if(op==true)
            {
                textBox1.Text = (sayi / 100).ToString();
            }
           
        }
    }

}

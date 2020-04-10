using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dizi_İslemleri
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox1.Text);
            textBox1.Clear();
            textBox1.Focus();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int[] sayilar = new int[listBox1.Items.Count];
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                sayilar[i] = Int32.Parse(listBox1.Items[i].ToString());
            }

            Array.Sort(sayilar);
            label3.Text = sayilar[sayilar.Length - 1].ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int[] sayilar = new int[listBox1.Items.Count];
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                sayilar[i] = Int32.Parse(listBox1.Items[i].ToString());
            }

            Array.Sort(sayilar);
            label4.Text = sayilar[0].ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int[] sayilar = new int[listBox1.Items.Count];
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                sayilar[i] = Int32.Parse(listBox1.Items[i].ToString());
            }

            int toplam = 0;
            foreach (var sayi in sayilar)
            {
                toplam += sayi;
                label5.Text = toplam.ToString();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int ortalama;
            int[] sayilar = new int[listBox1.Items.Count];
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                sayilar[i] = Int32.Parse(listBox1.Items[i].ToString());
            }

            int toplam = 0;
            foreach (var sayi in sayilar)
            {
                toplam += sayi;
                ortalama = toplam / sayilar.Length;
                label7.Text = ortalama.ToString();
            }

        }
    }
}

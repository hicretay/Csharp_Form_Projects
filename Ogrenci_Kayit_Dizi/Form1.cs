using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ogrenci_Kayit_Dizi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        string[] adsoyad = new string[10];
        string[] telefon = new string[10];
        string[] il = new string[10];
        int i = 0;

        void temizle()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            adsoyad[i] = textBox1.Text;
            telefon[i] = textBox2.Text;
            il[i] = textBox3.Text;
            i++;
            temizle();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            i--;
            label7.Text = adsoyad[i];
            label8.Text = telefon[i];
            label9.Text = il[i];

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            i--;
            label7.Text = adsoyad[i];
            label8.Text = telefon[i];
            label9.Text = il[i];
        }

        private void button3_Click(object sender, EventArgs e)
        {
            i++;
            label7.Text = adsoyad[i];
            label8.Text = telefon[i];
            label9.Text = il[i];
        }
    }
}

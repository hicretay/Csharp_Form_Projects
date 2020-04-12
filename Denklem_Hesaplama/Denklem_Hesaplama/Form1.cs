using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Denklem_Hesaplama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random rnd = new Random();
        private void button1_Click(object sender, EventArgs e)
        {
            int n = (int)numericUpDown1.Value;
            if(n<=1)
            {
                MessageBox.Show("Dizinin boyutu en az 2 olmalı");
                return;
            }


            double[] X = new double[n];

            for (int i = 0; i < X.Length; i++)
            {
                X[i] = rnd.NextDouble();
                listBox1.Items.Add(X[i]);
            }

            double f1;
            f1 = 1 - Math.Exp(-4 * X[0]) * Math.Pow((Math.Sin(6 * Math.PI * X[0])), 6);
            labelf1.Text = "f1:" + f1;

            double toplam = 0;
            for (int i = 1; i < n; i++)
            {
                toplam += X[i];
            }
            double g = 1 + 9 * Math.Pow(toplam / (n - 1), 0.25);
            labelG.Text= "g:" + g;

            double f2 = g * (1 - Math.Pow(f1 / g, 2));
            labelf2.Text = "f2:" + f2;





            


        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Algoritmik_Ornekler
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            int sayi = 0;
            int sayac = 0;
            
            Convert.ToInt32(textBox1.Text);

            for (int i = 2; i < sayi; i++)
            {
                if (sayi % i == 0)
                {
                    sayac++;
                    break;
                }
            }
                if(sayac==0)
                   {
                       label2.Text = "sayı asal sayıdır";
                   }

            else
                {
                    label2.Text = "sayı asal sayı değildir";
                }
            
        }
    }
}

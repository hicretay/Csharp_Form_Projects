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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int toplam = 0;
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi;
            int bolunensayisi = 0;
            int mod = 0;

            mod = Convert.ToInt32(textBox2.Text);
            sayi = Convert.ToInt32(textBox1.Text);
            for(int i=1;i<=sayi;i++)
                if(i%mod==0)
                {
                    bolunensayisi++;
                    label2.Text = bolunensayisi.ToString();

                    toplam += i;
                    label4.Text = toplam.ToString();
                }

        }
    }
}

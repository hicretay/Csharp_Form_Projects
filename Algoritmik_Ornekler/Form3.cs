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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void temizle()
        {
            textBox1.Clear();
        }


        int tektoplam=0;
        int cifttoplam = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi = 0;
            sayi = Convert.ToInt32(textBox1.Text);

            if(sayi%2==0)
            {
                cifttoplam = sayi + cifttoplam;
                label3.Text = cifttoplam.ToString();
                temizle();
            }

            if(sayi%2==1)
            {
                tektoplam = sayi + tektoplam;
                label2.Text = tektoplam.ToString();
                temizle();

            }
        }
    }
}

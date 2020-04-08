using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Double_Hesap_Makinesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double sayı1, sayı2, toplam,fark,çarpım,bölüm ;

            sayı1 = Convert.ToDouble(textBox1.Text);
            sayı2 = Convert.ToDouble(textBox2.Text);

            toplam = sayı1 + sayı2;
            label7.Text = toplam.ToString();

            çarpım = sayı1 * sayı2;
            label9.Text = çarpım.ToString();

            fark = sayı1 - sayı2;
            label8.Text = fark.ToString();

            bölüm = sayı1 / sayı2;
            label10.Text = bölüm.ToString();

        }
    }
}

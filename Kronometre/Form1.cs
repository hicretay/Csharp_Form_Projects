using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kronometre
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int dakika;
        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int sayi = Convert.ToInt32(label2.Text);
            sayi++;
            label2.Text = sayi.ToString();

            if(sayi==60)
            {
                sayi = 0;
                label2.Text = sayi.ToString();
                dakika++;
                label4.Text = dakika.ToString();
            }
        }
    }
}

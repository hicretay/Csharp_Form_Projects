using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Asal_Sayı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi = (int)numericUpDown1.Value;

            for (int j = 2; j <= sayi; j++)
            {
                bool ctrl = true;
                for (int i = 2; i < j / 2; i++)
                {
                    if(j%i==0)
                    {
                        ctrl = false;
                        break;
                    }
                }
                if (ctrl==true)
                {
                    listBox1.Items.Add(j);
                }
            }
        }
    }
}

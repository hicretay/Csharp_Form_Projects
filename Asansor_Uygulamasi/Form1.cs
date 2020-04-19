using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Asansor_Uygulamasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonyukari_Click(object sender, EventArgs e)
        {
            timer1.Start();
            label9.Text = "1";
            label5.BackColor = Color.Sienna;
            label6.BackColor = Color.Sienna;

        }

        private void buttonasagı_Click(object sender, EventArgs e)
        {
            timer1.Start();
            label9.Text = "0";
            label7.BackColor = Color.Sienna;
            label8.BackColor = Color.Sienna;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (label9.Text == "1")
            {
                pictureBox1.Top -= 5;
                if(pictureBox1.Location.Y<=169)
                {
                    timer1.Stop();
                    label7.BackColor = Color.Yellow;
                    label8.BackColor = Color.Yellow;
                }
            }



            if (label9.Text == "0")
            { 
                pictureBox1.Top += 5;
                if(pictureBox1.Location.Y>=351)
                {
                    timer1.Stop();
                    label5.BackColor = Color.Yellow;
                    label6.BackColor = Color.Yellow;
                }
            }
        }
    }
}

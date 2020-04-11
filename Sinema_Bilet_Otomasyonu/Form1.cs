using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sinema_Bilet_Otomasyonu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int seans1 = 0;
        int seans2 = 0;
        int seans3 = 0;
        int seans4 = 0;
        int ucret1 = 0;
        int ucret2 = 0;
        int ucret3 = 0;
        int ucret4 = 0;

        int mısır = 0;
        int ucretmısır = 0;

        int su = 0;
        int ucretsu = 0;

        int cay = 0;
        int ucretcay = 0;

        int kola = 0;
        int ucretkola = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            seans1++;
            ucret1 += 8;
            textBox1.Text = seans1.ToString();
            textBox2.Text = ucret1.ToString();

            if(seans1==30)
            {
                button1.Enabled = false;
            }

            if(seans1>=0)
            {
                button2.Enabled = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            seans1--;
            ucret1 -= 8;
            textBox1.Text = seans1.ToString();
            textBox2.Text = ucret1.ToString();

            if(seans1==0)
            {
                button2.Enabled = false;
            }

            if(seans1<=30)
            {
                button1.Enabled = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            seans2++;
            ucret2 += 8;
            textBox3.Text = seans2.ToString();
            textBox4.Text = ucret2.ToString();

            if(seans2==30)
            {
                button3.Enabled = false;
            }

            if(seans2>=0)
            {
                button4.Enabled = true;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            seans2--;
            ucret2 -= 8;
            textBox3.Text = seans2.ToString();
            textBox4.Text = ucret2.ToString();

            if(seans2==0)
            {
                button4.Enabled = false;
            }

            if(seans2<=30)
            {
                button3.Enabled = true;
            }
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            seans3++;
            ucret3 += 8;
            textBox5.Text = seans3.ToString();
            textBox6.Text = ucret3.ToString();

            if (seans3 == 30)
            {
                button5.Enabled = false;
            }

            if (seans3 >= 0)
            {
                button6.Enabled = true;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            seans3--;
            ucret3 -= 8;
            textBox5.Text = seans3.ToString();
            textBox6.Text = ucret3.ToString();

            if (seans3 == 0)
            {
                button6.Enabled = false;
            }

            if (seans2 <= 30)
            {
                button5.Enabled = true;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            seans4++;
            ucret4 += 8;
            textBox7.Text = seans4.ToString();
            textBox8.Text = ucret4.ToString();

            if (seans4== 30)
            {
                button7.Enabled = false;
            }

            if (seans4>= 0)
            {
                button8.Enabled = true;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            seans4--;
            ucret4 -= 8;
            textBox7.Text = seans4.ToString();
            textBox8.Text = ucret4.ToString();

            if (seans4 == 0)
            {
                button8.Enabled = false;
            }

            if (seans4 <= 30)
            {
                button7.Enabled = true;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            
            mısır++;
            ucretmısır +=5;
            textBox9.Text = mısır.ToString();
            textBox10.Text = ucretmısır.ToString();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            mısır--;
            ucretmısır -= 5;
            textBox9.Text = mısır.ToString();
            textBox10.Text = ucretmısır.ToString();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            cay++;
            ucretcay += 4;
            textBox11.Text = cay.ToString();
            textBox12.Text = ucretcay.ToString();
        }

        private void button11_Click(object sender, EventArgs e)
        {

            cay--;
            ucretcay -= 4;
            textBox11.Text = cay.ToString();
            textBox12.Text = ucretcay.ToString();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            kola++;
            ucretkola += 5;
            textBox14.Text = kola.ToString();
            textBox13.Text = ucretkola.ToString();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            kola--;
            ucretkola -= 5;
            textBox14.Text = kola.ToString();
            textBox13.Text = ucretkola.ToString();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            su++;
            ucretsu += 2;
            textBox16.Text = su.ToString();
            textBox15.Text = ucretsu.ToString();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            su--;
            ucretsu -= 2;
            textBox16.Text = su.ToString();
            textBox15.Text = ucretsu.ToString();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            int toplamucret=0;
            toplamucret = ucret1 + ucret2 + ucret3 + ucret4 + ucretcay + ucretmısır + ucretsu + ucretkola;
            textBox17.Text = toplamucret.ToString();
        }
    }
}

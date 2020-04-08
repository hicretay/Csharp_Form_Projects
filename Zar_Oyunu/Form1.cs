using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zar_Oyunu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int toplamben = 0;
        int toplampc = 0;
        Random rastgele = new Random();
        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button2.Enabled = true;

            int sayi1 = rastgele.Next(1, 7);
            label3.Text = sayi1.ToString();

            int sayi2 = rastgele.Next(1, 7);
            label4.Text = sayi2.ToString();

            toplamben += sayi1 + sayi2;
            label17.Text = toplamben.ToString();

            if(sayi1==1)
            {
                pictureBox1.ImageLocation = "C:\\Users\\hiicr\\Desktop\\1.png";
            }

            if (sayi1 == 2)
            {
                pictureBox1.ImageLocation = "C:\\Users\\hiicr\\Desktop\\2.png";
            }

            if (sayi1 == 3)
            {
                pictureBox1.ImageLocation = "C:\\Users\\hiicr\\Desktop\\3.png";
            }
            if (sayi1 == 4)
            {
                pictureBox1.ImageLocation = "C:\\Users\\hiicr\\Desktop\\4.png";
            }
            if (sayi1 == 5)
            {
                pictureBox1.ImageLocation = "C:\\Users\\hiicr\\Desktop\\5.png";
            }
            if (sayi1 == 6)
            {
                pictureBox1.ImageLocation = "C:\\Users\\hiicr\\Desktop\\6.png";
            }
            if (sayi2 == 1)
            {
                pictureBox2.ImageLocation = "C:\\Users\\hiicr\\Desktop\\1.png";
            }
            if (sayi2 == 2)
            {
                pictureBox2.ImageLocation = "C:\\Users\\hiicr\\Desktop\\2.png";
            }
            if (sayi2 == 3)
            {
                pictureBox2.ImageLocation = "C:\\Users\\hiicr\\Desktop\\3.png";
            }
            if (sayi2 == 4)
            {
                pictureBox2.ImageLocation = "C:\\Users\\hiicr\\Desktop\\4.png";
            }
            if (sayi2 == 5)
            {
                pictureBox2.ImageLocation = "C:\\Users\\hiicr\\Desktop\\5.png";
            }
            if (sayi2 == 6)
            {
                pictureBox2.ImageLocation = "C:\\Users\\hiicr\\Desktop\\6.png";
            }
        }


        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.Enabled = false;
            button1.Enabled = true;

            int sayi3 = rastgele.Next(1, 7);
            label10.Text = sayi3.ToString();

            int sayi4 = rastgele.Next(1, 7);
            label9.Text = sayi4.ToString();

            toplampc += sayi3 + sayi4;
            label16.Text = toplampc.ToString();

            if (sayi3 == 1)
            {
                pictureBox1.ImageLocation = "C:\\Users\\hiicr\\Desktop\\1.png";
            }

            if (sayi3 == 2)
            {
                pictureBox1.ImageLocation = "C:\\Users\\hiicr\\Desktop\\2.png";
            }

            if (sayi3 == 3)
            {
                pictureBox1.ImageLocation = "C:\\Users\\hiicr\\Desktop\\3.png";
            }
            if (sayi3 == 4)
            {
                pictureBox1.ImageLocation = "C:\\Users\\hiicr\\Desktop\\4.png";
            }
            if (sayi3 == 5)
            {
                pictureBox1.ImageLocation = "C:\\Users\\hiicr\\Desktop\\5.png";
            }
            if (sayi3 == 6)
            {
                pictureBox1.ImageLocation = "C:\\Users\\hiicr\\Desktop\\6.png";
            }
            if (sayi4 == 1)
            {
                pictureBox2.ImageLocation = "C:\\Users\\hiicr\\Desktop\\1.png";
            }
            if (sayi4== 2)
            {
                pictureBox2.ImageLocation = "C:\\Users\\hiicr\\Desktop\\2.png";
            }
            if (sayi4 == 3)
            {
                pictureBox2.ImageLocation = "C:\\Users\\hiicr\\Desktop\\3.png";
            }
            if (sayi4 == 4)
            {
                pictureBox2.ImageLocation = "C:\\Users\\hiicr\\Desktop\\4.png";
            }
            if (sayi4 == 5)
            {
                pictureBox2.ImageLocation = "C:\\Users\\hiicr\\Desktop\\5.png";
            }
            if (sayi4 == 6)
            {
                pictureBox2.ImageLocation = "C:\\Users\\hiicr\\Desktop\\6.png";
            }

            if(toplamben>100&&toplamben>toplampc)
            {
                label14.Text = "KAZANAN SİZSİNİZ!";
            }

            if(toplampc>100&&toplampc>toplamben)
            {
                label14.Text = "KAZANAN BİLGİSAYAR!";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button1.Enabled = true;
            button2.Enabled = false;
        }
    }
}

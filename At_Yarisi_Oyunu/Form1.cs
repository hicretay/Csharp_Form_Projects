using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace At_Yarişi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int sayı;
        int birinciatsolauzaklik, ikiciatsolauzaklık, ucuncuatsolayzaklık;
        Random rastgele = new Random();

        private void timer1_Tick(object sender, EventArgs e)
        {
            int sayı = Convert.ToInt32(label7.Text);
            sayı++;
            label7.Text = sayı.ToString();

            int birinciatingenisligi = pictureBox1.Width;
            int ikinciatingenisligi = pictureBox2.Width;
            int ucuncuatingenisligi = pictureBox3.Width;

            int bitisuzakligi = label5.Left;

            pictureBox1.Left += rastgele.Next(5, 15);
            pictureBox2.Left += rastgele.Next(5, 15);
            pictureBox3.Left += rastgele.Next(5, 15);

            if(pictureBox1.Left>pictureBox2.Left+5&&pictureBox1.Left>pictureBox3.Left+5)
            {
                label6.Text=("birinci at önde");
            }

            if (pictureBox2.Left > pictureBox1.Left + 5 && pictureBox2.Left > pictureBox3.Left + 5)
            {
                label6.Text = ("ikinci at önde");
            }
            if (pictureBox3.Left > pictureBox1.Left + 5 && pictureBox3.Left > pictureBox2.Left + 5)
            {
                label6.Text = ("üçüncü at önde");
            }

            if (birinciatingenisligi+pictureBox1.Left>=bitisuzakligi)
            {
                timer1.Enabled = false;
                label6.Text=("birinci at kazandı");
            }

            if(ikinciatingenisligi+pictureBox2.Left>=bitisuzakligi)
            {
                timer1.Enabled = false;
                label6.Text = ("ikinci at kazandı");
            }

            if(ucuncuatingenisligi+pictureBox3.Left>=bitisuzakligi)
            {
                timer1.Enabled = false;
                label6.Text = ("üçüncü at kazandı");
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            birinciatsolauzaklik = pictureBox1.Left;
            ikiciatsolauzaklık = pictureBox2.Left;
            ucuncuatsolayzaklık = pictureBox3.Left;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

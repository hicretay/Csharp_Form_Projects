using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pansiyon_Kayit_Otomasyonu
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void bTN_giris_Click(object sender, EventArgs e)
        {
            if(textBox1.Text=="admin"&&textBox2.Text=="1234")
            {
                Form1 yeni = new Form1();
                yeni.Show();
                this.Hide();
            }    
            else
            {
                MessageBox.Show("HATALI GİRİŞ!");
                textBox1.Clear();
                textBox2.Clear();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            textBox3.Text = textBox3.Text.Substring(1) + textBox3.Text.Substring(0, 1);
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Otobüs_Otomasyonu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text=="Hicret" && textBox2.Text=="3210")
            { 
            Form2 yeni = new Form2();
            yeni.Show();
            this.Hide();
            }
            else
            {
                MessageBox.Show("YANLIŞ GİRİŞ");
                textBox1.Clear();
                textBox2.Clear();
;            }
        }
    }
}

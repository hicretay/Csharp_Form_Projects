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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("3");
            listBox2.Items.Add(textBox1.Text);
            listBox4.Items.Add(textBox2.Text);
            listBox6.Items.Add(comboBox1.Text);
            listBox5.Items.Add(comboBox2.Text);

            if (radioButton1.Checked)
            {
                listBox3.Items.Add(radioButton1.Text);
            }
            else
            {
                listBox3.Items.Add(radioButton2.Text);
            }

            textBox1.Clear();
            textBox2.Clear();
            comboBox1.Text = " ";
            comboBox2.Text = " ";
            radioButton1.Checked = false;
            radioButton2.Checked = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("4");
            listBox2.Items.Add(textBox1.Text);
            listBox4.Items.Add(textBox2.Text);
            listBox6.Items.Add(comboBox1.Text);
            listBox5.Items.Add(comboBox2.Text);

            if (radioButton1.Checked)
            {
                listBox3.Items.Add(radioButton1.Text);
            }
            else
            {
                listBox3.Items.Add(radioButton2.Text);
            }

            textBox1.Clear();
            textBox2.Clear();
            comboBox1.Text = " ";
            comboBox2.Text = " ";
            radioButton1.Checked = false;
            radioButton2.Checked = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("1");
            listBox2.Items.Add(textBox1.Text);
            listBox4.Items.Add(textBox2.Text);
            listBox6.Items.Add(comboBox1.Text);
            listBox5.Items.Add(comboBox2.Text);

            if(radioButton1.Checked)
            {
                listBox3.Items.Add(radioButton1.Text);
            }
            else
            {
                listBox3.Items.Add(radioButton2.Text);
            }

            textBox1.Clear();
            textBox2.Clear();
            comboBox1.Text = " ";
            comboBox2.Text = " ";
            radioButton1.Checked = false;
            radioButton2.Checked = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("2");
            listBox2.Items.Add(textBox1.Text);
            listBox4.Items.Add(textBox2.Text);
            listBox6.Items.Add(comboBox1.Text);
            listBox5.Items.Add(comboBox2.Text);

            if (radioButton1.Checked)
            {
                listBox3.Items.Add(radioButton1.Text);
            }
            else
            {
                listBox3.Items.Add(radioButton2.Text);
            }

            textBox1.Clear();
            textBox2.Clear();
            comboBox1.Text = " ";
            comboBox2.Text = " ";
            radioButton1.Checked = false;
            radioButton2.Checked = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("5");
            listBox2.Items.Add(textBox1.Text);
            listBox4.Items.Add(textBox2.Text);
            listBox6.Items.Add(comboBox1.Text);
            listBox5.Items.Add(comboBox2.Text);

            if (radioButton1.Checked)
            {
                listBox3.Items.Add(radioButton1.Text);
            }
            else
            {
                listBox3.Items.Add(radioButton2.Text);
            }

            textBox1.Clear();
            textBox2.Clear();
            comboBox1.Text = " ";
            comboBox2.Text = " ";
            radioButton1.Checked = false;
            radioButton2.Checked = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("6");
            listBox2.Items.Add(textBox1.Text);
            listBox4.Items.Add(textBox2.Text);
            listBox6.Items.Add(comboBox1.Text);
            listBox5.Items.Add(comboBox2.Text);

            if (radioButton1.Checked)
            {
                listBox3.Items.Add(radioButton1.Text);
            }
            else
            {
                listBox3.Items.Add(radioButton2.Text);
            }

            textBox1.Clear();
            textBox2.Clear();
            comboBox1.Text = " ";
            comboBox2.Text = " ";
            radioButton1.Checked = false;
            radioButton2.Checked = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}

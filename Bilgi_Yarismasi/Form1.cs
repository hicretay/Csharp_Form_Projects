using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace veritabanli_bilgi_yarismasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection baglan = new SqlConnection("Data Source=localhost;Initial Catalog=bilgiyarismasi;Integrated Security=True");
        int sayac = 0;
        int puan = 0;
        int süre = 20;

        private void button1_Click(object sender, EventArgs e)
        {
            if (labeldogru.Text == d.Text)
            {
                puan += 10;
                label3.Text = puan.ToString();
                d.BackColor = Color.Green;
            }
            else
            {
                d.BackColor = Color.Red;
            }

            button1.Enabled = true;
            a.Enabled = false;
            b.Enabled = false;
            c.Enabled = false;
            d.Enabled = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            süre = 20;

            a.BackColor = Color.White;
            b.BackColor = Color.White;
            c.BackColor = Color.White;
            d.BackColor = Color.White;

            button1.Enabled = false;
            a.Enabled = true;
            b.Enabled = true;
            c.Enabled = true;
            d.Enabled = true;

            button1.Text = "İLERİ";
            sayac++;
            label2.Text = sayac.ToString();
            if (sayac == 1)
            {
                baglan.Open();

                SqlCommand komut = new SqlCommand("Select *from soru_1 order by NEWID()", baglan);
                SqlDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                {
                    a.Text = (oku["a"].ToString());
                    b.Text = (oku["b"].ToString());
                    c.Text = (oku["c"].ToString());
                    d.Text = (oku["d"].ToString());

                    textBox1.Text = (oku["soru"].ToString());
                    labeldogru.Text = (oku["dogru"].ToString());

                }
                baglan.Close();
            }

            if(sayac==2)
            {
                baglan.Open();

                SqlCommand komut = new SqlCommand("Select *from soru_2 order by NEWID()", baglan);
                SqlDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                {
                    a.Text = (oku["a"].ToString());
                    b.Text = (oku["b"].ToString());
                    c.Text = (oku["c"].ToString());
                    d.Text = (oku["d"].ToString());

                    textBox1.Text = (oku["soru"].ToString());
                    labeldogru.Text = (oku["dogru"].ToString());

                }
                baglan.Close();
            }

            if(sayac==3)
            {
                baglan.Open();

                SqlCommand komut = new SqlCommand("Select *from soru_3 order by NEWID()", baglan);
                SqlDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                {
                    a.Text = (oku["a"].ToString());
                    b.Text = (oku["b"].ToString());
                    c.Text = (oku["c"].ToString());
                    d.Text = (oku["d"].ToString());

                    textBox1.Text = (oku["soru"].ToString());
                    labeldogru.Text = (oku["dogru"].ToString());

                }
                baglan.Close();
            }

            if(sayac==4)
            {
                baglan.Open();

                SqlCommand komut = new SqlCommand("Select *from soru_4 order by NEWID()", baglan);
                SqlDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                {
                    a.Text = (oku["a"].ToString());
                    b.Text = (oku["b"].ToString());
                    c.Text = (oku["c"].ToString());
                    d.Text = (oku["d"].ToString());

                    textBox1.Text = (oku["soru"].ToString());
                    labeldogru.Text = (oku["dogru"].ToString());

                }
                baglan.Close();
            }

            if(sayac==5)
            {
                baglan.Open();
                button1.Text = "OYUN BİTTİ";
                button1.Enabled = false;
                

                SqlCommand komut = new SqlCommand("Select *from soru_5 order by NEWID()", baglan);
                SqlDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                {
                    a.Text = (oku["a"].ToString());
                    b.Text = (oku["b"].ToString());
                    c.Text = (oku["c"].ToString());
                    d.Text = (oku["d"].ToString());

                    textBox1.Text = (oku["soru"].ToString());
                    labeldogru.Text = (oku["dogru"].ToString());

                }
                baglan.Close();
            }

            if(sayac==6)
            {
                a.Enabled = false;
                b.Enabled = false;
                c.Enabled = false;
                d.Enabled = false;

                timer1.Enabled = false;
            }
        }

        private void a_Click(object sender, EventArgs e)
        {
            if(labeldogru.Text==a.Text)
            {
                puan += 10;
                label3.Text = puan.ToString();
                a.BackColor = Color.Green;
            }
            else
            {
                a.BackColor = Color.Red;
            }

            button1.Enabled = true;
            a.Enabled = false;
            b.Enabled = false;
            c.Enabled = false;
            d.Enabled = false;

        }

        private void b_Click(object sender, EventArgs e)
        {
            if (labeldogru.Text == b.Text)
            {
                puan += 10;
                label3.Text = puan.ToString();
                b.BackColor = Color.Green;
            }
            else
            {
                b.BackColor = Color.Red;
            }

            button1.Enabled = true;
            a.Enabled = false;
            b.Enabled = false;
            c.Enabled = false;
            d.Enabled = false;

        }


        private void c_Click(object sender, EventArgs e)
        {
            if (labeldogru.Text == c.Text)
            {
                puan += 10;
                label3.Text = puan.ToString();
                c.BackColor = Color.Green;
            }
            else
            {
                c.BackColor = Color.Red;
            }

            button1.Enabled = true;
            a.Enabled = false;
            b.Enabled = false;
            c.Enabled = false;
            d.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            süre -= 1;
            label5.Text = süre.ToString();

            if(süre==0)
            {
                timer1.Enabled = false;
                a.Enabled = false;
                b.Enabled = false;
                c.Enabled = false;
                d.Enabled = false;
                button1.Enabled = true;
            }
        }
    }
}

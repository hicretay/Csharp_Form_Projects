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


namespace Kayit_Program
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=localhost;Initial Catalog=Kayitlar;Integrated Security=True");

        private void verigoster()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select *from Kayitlar", baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while(oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["Adsoyad"].ToString();
                ekle.SubItems.Add(oku["Firma"].ToString());
                ekle.SubItems.Add(oku["Telefon"].ToString());
                listView1.Items.Add(ekle);
            }

            baglanti.Close();

        }


        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            verigoster();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Insert into Kayitlar (Adsoyad,Firma,Telefon) Values('" + textBox1.Text.ToString() + " ','" +textBox2.Text.ToString()+"','"+ textBox3.Text.ToString() + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            verigoster();

            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}

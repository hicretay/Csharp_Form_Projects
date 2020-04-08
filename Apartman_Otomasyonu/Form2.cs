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

namespace Apartman_Otomasyonu
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        int id = 0;
        SqlConnection baglan = new SqlConnection("Data Source=localhost;Initial Catalog=siteotomasyon;Integrated Security=True");
        private void goster()
        {
            listView1.Items.Clear();
            baglan.Open();
            SqlCommand komut = new SqlCommand("Select *from sitebilgi", baglan);
            SqlDataReader oku = komut.ExecuteReader();

            while(oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["id"].ToString();
                ekle.SubItems.Add(oku["satkira"].ToString());
                ekle.SubItems.Add(oku["oda"].ToString());
                ekle.SubItems.Add(oku["metre"].ToString());
                ekle.SubItems.Add(oku["fiyat"].ToString());
                ekle.SubItems.Add(oku["blok"].ToString());
                ekle.SubItems.Add(oku["no"].ToString());
                ekle.SubItems.Add(oku["adsoyad"].ToString());
                ekle.SubItems.Add(oku["telefon"].ToString());
                ekle.SubItems.Add(oku["notlar"].ToString());
                ekle.SubItems.Add(oku["site"].ToString());
                listView1.Items.Add(ekle);

            }
            baglan.Close();
             
        }
            
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox1.Text=="Zambak Sitesi")
            {
                buttonzambak.BackColor = Color.Blue;
                buttongül.BackColor = Color.Silver;
                buttonmenekse.BackColor = Color.Silver;
                buttonpapatya.BackColor = Color.Silver;
            }

            if(comboBox1.Text=="Gül Sitesi")
            {
                buttongül.BackColor = Color.Blue;
                buttonzambak.BackColor = Color.Silver;
                buttonmenekse.BackColor = Color.Silver;
                buttonpapatya.BackColor = Color.Silver;
            }

            if (comboBox1.Text == "Menekşe Sitesi")
            {
                buttonmenekse.BackColor = Color.Blue;
                buttongül.BackColor = Color.Silver;
                buttonzambak.BackColor = Color.Silver;
                buttonpapatya.BackColor = Color.Silver;
            }

            if (comboBox1.Text == "Papatya Sitesi")
            {
                buttonpapatya.BackColor = Color.Blue;
                buttongül.BackColor = Color.Silver;
                buttonmenekse.BackColor = Color.Silver;
                buttonzambak.BackColor = Color.Silver;
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttongörüntüle_Click(object sender, EventArgs e)
        {
            goster();
        }

        private void buttonkaydet_Click(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand komut = new SqlCommand("Insert into sitebilgi(id,satkira,oda,metre,fiyat,blok,no,adsoyad,telefon,notlar,site)" +
                "Values('" + textBox8.Text.ToString() + "','" + comboBox2.Text.ToString() + "','" + comboBox3.Text.ToString() + "','" + textBox1.Text.ToString()
                + "','" + textBox2.Text.ToString() + "','" + comboBox4.Text.ToString() + "','" + textBox7.Text.ToString() + "','" + textBox4.Text.ToString() + "','" + textBox5.Text.ToString()
                + "','" + textBox3.Text.ToString() + "','" + comboBox1.Text.ToString() + "')",baglan);

            komut.ExecuteNonQuery();
            baglan.Close();
            goster();
        }

        private void buttonsil_Click(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand komut = new SqlCommand("Delete From sitebilgi where id=("+id+")",baglan);
            komut.ExecuteNonQuery();
            baglan.Close();
            goster();
        }

        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            id = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);

            textBox8.Text = listView1.SelectedItems[0].SubItems[0].Text;
            comboBox2.Text = listView1.SelectedItems[0].SubItems[1].Text;
            comboBox3.Text = listView1.SelectedItems[0].SubItems[2].Text;
            textBox1.Text = listView1.SelectedItems[0].SubItems[3].Text;
            textBox2.Text = listView1.SelectedItems[0].SubItems[4].Text;
            comboBox4.Text = listView1.SelectedItems[0].SubItems[5].Text;
            textBox7.Text = listView1.SelectedItems[0].SubItems[6].Text;
            textBox4.Text = listView1.SelectedItems[0].SubItems[7].Text;
            textBox5.Text = listView1.SelectedItems[0].SubItems[8].Text;
            textBox3.Text = listView1.SelectedItems[0].SubItems[9].Text;
            comboBox1.Text = listView1.SelectedItems[0].SubItems[10].Text;
        }

        private void buttondüzelt_Click(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand komut = new SqlCommand("Update sitebilgi set id='" + textBox8.Text.ToString()
                + "',satkira='" + comboBox2.Text.ToString() + "',oda='" + comboBox3.Text.ToString()
                + "',metre='" + textBox1.Text.ToString() + "',fiyat='" + textBox2.Text.ToString()
                + "',blok='" + comboBox4.Text.ToString() + "',no='" + textBox7.Text.ToString()
                + "',adsoyad='" + textBox4.Text.ToString() + "',telefon='" + textBox5.Text.ToString()
                + "',notlar='" + textBox3.Text.ToString() + "',site='" + comboBox1.Text.ToString()
                + "'where id=" + id + "", baglan);
            komut.ExecuteNonQuery();
            baglan.Close();
            goster();
        }
    }
}

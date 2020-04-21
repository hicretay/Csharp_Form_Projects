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

namespace Pansiyon_Kayit_Otomasyonu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int id = 0;
        SqlConnection baglan = new SqlConnection("Data Source=localhost;Initial Catalog=pansiyon;Integrated Security=True");

        private void goster()
        {
            listView1.Items.Clear();
            baglan.Open();
            SqlCommand komut = new SqlCommand("Select *from musteriler", baglan);
            SqlDataReader oku =komut.ExecuteReader();

            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["id"].ToString();
                ekle.SubItems.Add(oku["Ad"].ToString());
                ekle.SubItems.Add(oku["Soyad"].ToString());
                ekle.SubItems.Add(oku["OdaNo"].ToString());
                ekle.SubItems.Add(oku["GTarih"].ToString());
                ekle.SubItems.Add(oku["Telefon"].ToString());
                ekle.SubItems.Add(oku["Hesap"].ToString());
                ekle.SubItems.Add(oku["CTarih"].ToString());

                listView1.Items.Add(ekle);
            }
            baglan.Close();

        }
        private void btn_kayitlariGoster_Click(object sender, EventArgs e)
        {
            goster();
        }

        private void btn_kaydet_Click(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand komut = new SqlCommand("insert into musteriler (id,Ad,Soyad,OdaNo,GTarih,Telefon,Hesap,CTarih) values ('" + textBox1.Text.ToString() +"','" + textBox2.Text.ToString() + "','" + textBox3.Text.ToString() + "','" + comboBox1.Text.ToString() + "','" + dateTimePicker1.Text.ToString() + "','" + textBox5.Text.ToString() + "','" + textBox6.Text.ToString() + "','" + dateTimePicker2.Text.ToString() + "')", baglan);
            komut.ExecuteNonQuery();

            komut.CommandText = "insert into doluoda(doluyerler) VALUES ('" + comboBox1.Text + "')";
            komut.ExecuteNonQuery();

            komut.CommandText = ("Delete from bosoda where bosyerler='" + comboBox1.Text + "'");
            komut.ExecuteNonQuery();

            baglan.Close();
            goster();
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            comboBox1.Text="";
            textBox5.Clear();
            textBox6.Clear();
        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand komut = new SqlCommand("Delete from musteriler where id=(" + id + ")", baglan);
            komut.ExecuteNonQuery();

            komut.CommandText = "insert into bosoda(bosyerler) VALUES ('" + comboBox1.Text + "')";
            komut.ExecuteNonQuery();

            komut.CommandText = ("Delete from doluoda where doluyerler='" + comboBox1.Text + "'");
            komut.ExecuteNonQuery();

            baglan.Close();
            goster();
        }

        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            id = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);

            textBox1.Text=listView1.SelectedItems[0].SubItems[0].Text;
            textBox2.Text = listView1.SelectedItems[0].SubItems[1].Text;
            textBox3.Text = listView1.SelectedItems[0].SubItems[2].Text;
            comboBox1.Text = listView1.SelectedItems[0].SubItems[3].Text;
            dateTimePicker1.Text = listView1.SelectedItems[0].SubItems[4].Text;
            textBox5.Text = listView1.SelectedItems[0].SubItems[5].Text;
            textBox6.Text = listView1.SelectedItems[0].SubItems[6].Text;
            dateTimePicker2.Text = listView1.SelectedItems[0].SubItems[7].Text;
           
        }

        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand komut = new SqlCommand("Update musteriler set id='" + textBox1.Text.ToString() + "',Ad='" + textBox2.Text.ToString() + "',Soyad='" + textBox3.Text.ToString() + "',OdaNo='" + comboBox1.Text.ToString() + "',Gtarih='" + dateTimePicker1.Text.ToString() + "',Telefon='" + textBox5.Text.ToString() + "',Hesap='" + textBox6.Text.ToString() + "',CTarih='" + dateTimePicker2.Text.ToString() + "'where id=" + id + "", baglan);
            komut.ExecuteNonQuery();
            baglan.Close();
            goster();
        }

        private void btn_ara_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            baglan.Open();
            SqlCommand komut = new SqlCommand("Select *from musteriler where Ad like '%" + textBox_ara.Text + "%'", baglan);
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["id"].ToString();
                ekle.SubItems.Add(oku["Ad"].ToString());
                ekle.SubItems.Add(oku["Soyad"].ToString());
                ekle.SubItems.Add(oku["OdaNo"].ToString());
                ekle.SubItems.Add(oku["GTarih"].ToString());
                ekle.SubItems.Add(oku["Telefon"].ToString());
                ekle.SubItems.Add(oku["Hesap"].ToString());
                ekle.SubItems.Add(oku["CTarih"].ToString());

                listView1.Items.Add(ekle);
            }
            baglan.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand komut = new SqlCommand("Select *from bosoda", baglan);
            SqlDataReader oda = komut.ExecuteReader();
            while(oda.Read())
            {
                comboBox1.Items.Add(oda[0].ToString());
            }
            baglan.Close();
        }
    }
}

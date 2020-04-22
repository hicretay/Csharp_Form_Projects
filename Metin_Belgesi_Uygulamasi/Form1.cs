using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Metin_Belgesi_Uygulamasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        StreamWriter sw; 
        string belgeadi, belgeyolu;

        private void button_url_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)  //dosya acıldıgında yeni pencere acmak icin
            {
                belgeyolu = folderBrowserDialog1.SelectedPath.ToString();
                textBox2.Text = belgeyolu.ToString();

            }
        }

        private void button_kaydet_Click(object sender, EventArgs e)
        {
            belgeadi = textBox1.Text;
            sw = File.CreateText(belgeyolu + "\\" + belgeadi + ".txt");
            sw.Close(); 
        }

        private void button_listele_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamReader oku = new StreamReader(openFileDialog1.FileName);
                string satir = oku.ReadLine();

                while (satir!=null)
                {
                    listBox1.Items.Add(satir);
                    satir=oku.ReadLine();
                }
            }
        }

        private void btn_veri_kaydet_Click(object sender, EventArgs e)
        {
            try
            {
                saveFileDialog1.Title = "Kayıt yerini seçin";  //pencere baslıgı
                saveFileDialog1.Filter = "Metin Dosyası(*.txt)|*.txt";  //metin dosyası olarak filtrelendi
                saveFileDialog1.FilterIndex = 2;      
                saveFileDialog1.InitialDirectory = "C:\\"; //ilk nerenin açılacagını seçer
                saveFileDialog1.ShowDialog();
                StreamWriter kaydet = new StreamWriter(saveFileDialog1.FileName);
                kaydet.WriteLine(richTextBox2.Text);
                kaydet.Close();
                MessageBox.Show("kaynak metin belgesine yazdırıldı");
            }
            catch (Exception)
            {
                MessageBox.Show("Hata oluştu işlem gerçekleştirilemedi!");
            }
        }

        private void button_txtgoster_Click(object sender, EventArgs e)
        {
            OpenFileDialog ac = new OpenFileDialog();
            ac.Filter = "Metin Dosyası(*.txt)|*.txt";
            ac.Multiselect = false;

            if (ac.ShowDialog()==System.Windows.Forms.DialogResult.OK)
            {
                textBox3.Text = ac.SafeFileName;
                try
                {
                    StreamReader oku = new StreamReader(ac.FileName);
                    richTextBox1.Text = oku.ReadToEnd();
                    oku.Close();
                }
                catch (Exception)
                {
                    MessageBox.Show("Dosya okunurken hata oluştu");
                }
            }
        }
    }
}

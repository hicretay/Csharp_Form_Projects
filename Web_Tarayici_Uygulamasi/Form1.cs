using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Web_Tarayici_Uygulamasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(textBox1.Text);
        }

        private void buttongeri_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
        }

        private void buttonileri_Click(object sender, EventArgs e)
        {
            webBrowser1.GoForward();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            webBrowser1.Refresh();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            webBrowser1.Stop();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("www.google.com");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("www.yahoo.com.tr");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("www.yandex.com.tr");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("www.google.com.tr");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label2.Text = DateTime.Now.ToLongDateString();
            label3.Text = DateTime.Now.ToLongTimeString();
        }

        private void yenileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Refresh();
        }

        private void milliyetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("www.milliyet.com.tr");
        }

        private void fanatikToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("www.fanatik.com.tr");
        }

        private void maviToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.CadetBlue;
        }

        private void yeşilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Green;
        }

        private void kırmızıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Red;
        }

        private void sarıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Yellow;
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel2.Text = webBrowser1.StatusText;
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            textBox1.Text = webBrowser1.Url.ToString();
            string zaman = DateTime.Now.Day + "." + DateTime.Now.Month + "." + DateTime.Now.Year;
            string zaman2= DateTime.Now.Hour+"." + DateTime.Now.Minute + "." + DateTime.Now.Second;

            FileStream f = new FileStream("Gecmis.txt", FileMode.Append);
            StreamWriter yaz = new StreamWriter(f);
            yaz.WriteLine(zaman + "/" + zaman2 + "/" + webBrowser1.Url);
            yaz.Close();
            gecmis();
        }

        private void webBrowser1_ProgressChanged(object sender, WebBrowserProgressChangedEventArgs e)
        {
            try
            {
                toolStripProgressBar1.Maximum = Convert.ToInt32(e.MaximumProgress);
                toolStripProgressBar1.Maximum = Convert.ToInt32(e.CurrentProgress);
            }
            catch (Exception)
            {
                toolStripProgressBar1.Minimum = 0;
            }
        }

        private void buttongecmis_Click(object sender, EventArgs e)
        {
            gecmis();
        }

        private void gecmis()
        {
            listBox1.Items.Clear();
            StreamReader dosya = new StreamReader("Gecmis.txt");
            while (!dosya.EndOfStream)
            {
                listBox1.Items.Add(dosya.ReadLine());
            }
            dosya.Close();
        }

        private void buttongecmis_sil_Click(object sender, EventArgs e)
        {
            StreamWriter dosya = new StreamWriter("Gecmis.txt");
            dosya.Write("");
            dosya.Close();
            gecmis();

        }
    }
}

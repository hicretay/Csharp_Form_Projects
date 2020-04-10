using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Random_Number_Generator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       
        private void buttonrandom_Click(object sender, EventArgs e)
        {
            int üstsınır = (int)numericUpDown2.Value;
            int altsınır = (int)numericUpDown1.Value;

            Random random = new Random();
            int sayı = random.Next(altsınır, üstsınır);

            for (int i = 0; i < sayı; i++)
            {
                if (listele.Items.Contains(sayı.ToString()))
                { }
                else
                {
                    listele.Items.Add(sayı.ToString());
                    int sayac = listele.Items.Count - 1;
                }
            }

        }
    }
}

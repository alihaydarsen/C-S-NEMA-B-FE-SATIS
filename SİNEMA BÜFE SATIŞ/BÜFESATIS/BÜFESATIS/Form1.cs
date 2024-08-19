using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace BÜFESATIS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        int toplam = 0;
        int kasa = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            
            try
            {
                int mısır, kola, su, cips, bilet;
                mısır = Convert.ToInt32(textBox1.Text);

                kola = Convert.ToInt32(textBox2.Text);

                su = Convert.ToInt32(textBox3.Text);

                cips = Convert.ToInt32(textBox4.Text);

                bilet = Convert.ToInt32(textBox5.Text);

                toplam = mısır * 80 + kola * 30 + su * 10 + cips * 25 + bilet * 75;
                kasa = kasa + toplam;
                textBox6.Text = toplam.ToString() + "TL";
                textBox7.Text = kasa.ToString() + "TL";
            }
            catch (Exception)
            {
                MessageBox.Show("LÜTFEN DOĞRU DEĞERLER GİRİNİZ");
              
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox1.Focus();
        }
    }
}

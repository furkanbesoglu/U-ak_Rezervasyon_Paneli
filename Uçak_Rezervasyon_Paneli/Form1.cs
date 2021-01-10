using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uçak_Rezervasyon_Paneli
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("rota: " + comboBox1.Text + " - " + "nereye: " +  comboBox2.Text + " - "  + "Saat:" + maskedTextBox2.Text + " - " + "Tarih" + dateTimePicker1.Text + " - " + "Yolcu Adı Soyad:" + textBox1.Text + " - " + " T.C Numarası: " + maskedTextBox3.Text  + " - " + " Telefon Numarası:" + maskedTextBox4.Text );
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label9.Text = comboBox2.Text;
            comboBox2.Text = comboBox1.Text;
            comboBox1.Text = label9.Text;
   

        }
    }
}

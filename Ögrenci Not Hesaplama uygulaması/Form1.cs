using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ögrenci_Not_Hesaplama_uygulaması
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Adı, Soyadı;
            int Numarası, S1, S2,Proje;
            double Ortalama;
            Adı = textBox1.Text;
            Soyadı = textBox2.Text;
            Numarası = Convert.ToInt32(textBox3.Text);
            S1= Convert.ToInt32(textBox4.Text);
            S2= Convert.ToInt32(textBox5.Text);
            Proje = Convert.ToInt32(textBox6.Text);
            Ortalama = (S1 + S2 + (Proje * 20) / 100) / 3; 
            listBox1.Items.Add(Adı + " " + Soyadı + " " +"Numara:" +  Numarası + " " + "Ortalama:"  +Ortalama);


        }
    }
}

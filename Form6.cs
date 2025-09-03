using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arac_Kullanimlari
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Rota: " + comboBox1.Text + " - " + comboBox2.Text + " " + "Tarih: " + dateTimePicker1.Text + " Saat: " + maskedTextBox1.Text + "Yolcu Bilgileri ~ Ad: " + textBox1.Text + "TC: " + maskedTextBox2.Text + "Telefon: " + maskedTextBox3.Text);
        }

        private void button2_Click(object sender, EventArgs e) //nereden nereye şehirlerini tam tersi yapacak button
        {
            label9.Text = comboBox2.Text; //combobox2 değerini visiblefalse olan label9a yazdırıyoruz. bu değer burada tutuluyor
            comboBox2.Text = comboBox1.Text; //combobox2 değeri yerine combobox1 değeri yazdırılıyor
            comboBox1.Text = label9.Text; //label9da tutulan değer combobox1e yazdırılıyor.
        }
    }
}

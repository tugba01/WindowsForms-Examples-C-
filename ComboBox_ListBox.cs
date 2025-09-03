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
    public partial class ComboBox_ListBox : Form
    {
        public ComboBox_ListBox()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) //combobox'a öğe eklemek için
        {
            comboBox1.Items.Add("Antalya"); //comboboxa öğe ekler
        }

        private void button2_Click(object sender, EventArgs e) //bu butona bastığımızda textboxa girdiğimiz veriyi combobox'a ekleyecek
        {
            comboBox1.Items.Add(textBox1.Text); //textbox1den gelen text öğesini ekleyecek comboboxa 
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Kasiyer"); //listboxa öğe ekler
            listBox1.Items.Add("Futbolcu"); //listboxa öğe ekler
            listBox1.Items.Add("Muhasebeci"); //listboxa öğe ekler
            listBox1.Items.Add("Antrenör"); //listboxa öğe ekler
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox2.Text); //textbox2den gelen veriyi listboxa ekler
        }
    }
}

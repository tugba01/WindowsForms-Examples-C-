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
    public partial class MaskedBox_PictureBox_DateTimePicker : Form
    {
        public MaskedBox_PictureBox_DateTimePicker()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) //maskedtextboxlardan gelen değerleri listboxa yazdıracak
        {
            listBox1.Items.Add(maskedTextBox1.Text + " " + maskedTextBox2.Text + " " + maskedTextBox3.Text + " " + maskedTextBox4.Text);
        }

        private void button2_Click(object sender, EventArgs e) //datetimepickerdaki verileri listboxa göndermek için
        {
            listBox1.Items.Add(dateTimePicker1.Text);
        }
    }
}

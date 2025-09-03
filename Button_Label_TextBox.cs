namespace Arac_Kullanimlari
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) //click events'i, butona týklandýðýnda
        {
            MessageBox.Show("Merhaba Dünya!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label2.Text = "Ayþe";
        }

        private void button3_Click(object sender, EventArgs e) //bilgi getir
        {
            label6.Text = "Ahmet";
            label7.Text = "Yýlmaz";
            label8.Text = "Öðretmen";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //textBox1.Text = "Yazýlým Mühendisliði";
            label9.Text = textBox1.Text; //textbox1'den gelen metni label9'a yazdýracaðýz. butona çift týklayarak
        }
    }
}

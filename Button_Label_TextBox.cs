namespace Arac_Kullanimlari
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) //click events'i, butona t�kland���nda
        {
            MessageBox.Show("Merhaba D�nya!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label2.Text = "Ay�e";
        }

        private void button3_Click(object sender, EventArgs e) //bilgi getir
        {
            label6.Text = "Ahmet";
            label7.Text = "Y�lmaz";
            label8.Text = "��retmen";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //textBox1.Text = "Yaz�l�m M�hendisli�i";
            label9.Text = textBox1.Text; //textbox1'den gelen metni label9'a yazd�raca��z. butona �ift t�klayarak
        }
    }
}

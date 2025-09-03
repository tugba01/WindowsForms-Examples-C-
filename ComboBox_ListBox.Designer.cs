namespace Arac_Kullanimlari
{
    partial class ComboBox_ListBox
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            comboBox1 = new ComboBox();
            button1 = new Button();
            button2 = new Button();
            textBox1 = new TextBox();
            label1 = new Label();
            listBox1 = new ListBox();
            button3 = new Button();
            label2 = new Label();
            button4 = new Button();
            textBox2 = new TextBox();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Bursa", "Ankara", "Balıkesir", "Gaziantep", "Elazığ", "Malatya", "İstanbul", "İzmir", "Aydın" });
            comboBox1.Location = new Point(39, 55);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(230, 36);
            comboBox1.TabIndex = 0;

            // 
            // button1
            // 
            button1.Location = new Point(96, 97);
            button1.Name = "button1";
            button1.Size = new Size(121, 51);
            button1.TabIndex = 1;
            button1.Text = "Şehir Ekle";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(428, 100);
            button2.Name = "button2";
            button2.Size = new Size(121, 51);
            button2.TabIndex = 2;
            button2.Text = "Ekle";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(428, 47);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 36);
            textBox1.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(333, 55);
            label1.Name = "label1";
            label1.Size = new Size(67, 28);
            label1.TabIndex = 4;
            label1.Text = "Şehir:";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 28;
            listBox1.Items.AddRange(new object[] { "Öğretmen", "Doktor", "Mühendis", "Hemşire" });
            listBox1.Location = new Point(96, 311);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(230, 116);
            listBox1.TabIndex = 5;
            // 
            // button3
            // 
            button3.Location = new Point(96, 474);
            button3.Name = "button3";
            button3.Size = new Size(222, 34);
            button3.TabIndex = 6;
            button3.Text = "Meslek Ekle";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(390, 311);
            label2.Name = "label2";
            label2.Size = new Size(84, 28);
            label2.TabIndex = 7;
            label2.Text = "Meslek:";
            // 
            // button4
            // 
            button4.Location = new Point(427, 367);
            button4.Name = "button4";
            button4.Size = new Size(100, 39);
            button4.TabIndex = 8;
            button4.Text = "Kaydet";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(509, 311);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 36);
            textBox2.TabIndex = 9;
            // 
            // ComboBox_ListBox
            // 
            AutoScaleDimensions = new SizeF(12F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SandyBrown;
            ClientSize = new Size(936, 538);
            Controls.Add(textBox2);
            Controls.Add(button4);
            Controls.Add(label2);
            Controls.Add(button3);
            Controls.Add(listBox1);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(comboBox1);
            Font = new Font("Corbel", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            Margin = new Padding(4);
            Name = "ComboBox_ListBox";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private Button button1;
        private Button button2;
        private TextBox textBox1;
        private Label label1;
        private ListBox listBox1;
        private Button button3;
        private Label label2;
        private Button button4;
        private TextBox textBox2;
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyLib;


namespace Square
{
    public partial class Form1 : Form
    {
        public double value { get; set; }
        Counter counter = new Counter();
        public Form1()
        {
            InitializeComponent();

        }


        private void button1_Click(object sender, EventArgs e) // О программе
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e) // счетчик точности
        {
            value = (double)numericUpDown1.Value;
            counter.count = value;
        }
        

        private void button4_Click(object sender, EventArgs e) //  цифра 1
        {
            
        }

        private void groupBox1_Enter(object sender, EventArgs e) // выбор типа
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e) // обработка нажатия на цифры
        {
            Button C = (Button)sender; // почему C ?
            if (textBox1.Text == "0")
            {
                textBox1.Text = C.Text;
            }
            else
            {
                textBox1.Text = textBox1.Text + C.Text;
            }
            
        }

        private void button18_Click(object sender, EventArgs e) // нажатие на результат (сохранение введенного числа)
        {
            double number = double.Parse(textBox1.Text);
        }

        private void button20_Click(object sender, EventArgs e) // кнопка с надписью:"точность ввода"
        {
            MessageBox.Show($"{counter.count}");
        }
    }
}

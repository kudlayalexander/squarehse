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
        Sqrt sqrt = new Sqrt();

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
            sqrt.iter = value;

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
            Button buttonNumber = (Button)sender; // почему C ?
            if (textBox1.Text == "0")
            {
                textBox1.Text = buttonNumber.Text;
            }
            else
            {
                textBox1.Text = textBox1.Text + buttonNumber.Text;
            }
            
        }

        private void button18_Click(object sender, EventArgs e) // нажатие на результат (сохранение введенного числа)
        {
            sqrt.number = double.Parse(textBox1.Text);
            sqrt.doubleSqrt = sqrt.GetDoubleSqrt();
            sqrt.analSqrt = sqrt.GetAnalSqrt();
            textBox1.Text = $"{sqrt.doubleSqrt}";
            //textBox1.Text = $"{sqrt.analSqrt}";


        }

        private void button20_Click(object sender, EventArgs e) // кнопка с надписью:"точность ввода"
        {
            MessageBox.Show($"{counter.count}");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

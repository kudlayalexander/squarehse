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
        public double value { get; set; } // создание поля которое может хранить значение
        Sqrt sqrt = new Sqrt(); // создание экземпляра класса Sqrt

        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e) // О программе
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e) // счетчик точности
        {
            value = (double)numericUpDown1.Value;// в поле value присвоится значение из счетчика
            sqrt.iter = value; // в поле итер записываем значение точности

        }
        

        private void button4_Click(object sender, EventArgs e) //  цифра 1
        {
            
        }

        private void groupBox1_Enter(object sender, EventArgs e) // выбор типа
        {
            Controls.Add(button1);

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e) // обработка нажатия на цифры
        {
            Button buttonNumber = (Button)sender; 
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
            sqrt.number = double.Parse(textBox1.Text);// приводим строку, которая в дисплее в тип double
            sqrt.doubleSqrt = sqrt.GetDoubleSqrt();// в поле результата обычного корня присваиваем значение метода
            sqrt.analSqrt = sqrt.GetAnalSqrt();// аналогично
            textBox1.Text = $"{sqrt.doubleSqrt}";// вывод значения на экран
            //textBox1.Text = $"{sqrt.analSqrt}";

            button13.Enabled = true; // включает запятую


        }

        private void button20_Click(object sender, EventArgs e) // кнопка с надписью:"точность ввода"
        {
            MessageBox.Show($"{sqrt.iter}");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e) // Реальные
        {
            if (radioButton2.Checked)
            {
                // отключение кнопок при нажатии на реал.числа
                button15.Enabled = false;
                button16.Enabled = false;
                button17.Enabled = false;
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e) //Комплексные
        {
            if (radioButton1.Checked)
            {
                // включение кнопок при нажатии на компл.числа
                button15.Enabled = true;   
                button16.Enabled = true;
                button17.Enabled = true;
            }
        }

        private void button19_Click(object sender, EventArgs e) // кнопка C (стирание написанного) 
        {
            textBox1.Text = "0";
            button13.Enabled = true; // включает запятую
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e) // Способ извл. корня:  Обычный
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e) // Способо извл. корня:  Аналитический
        {

        }

        private void button13_Click(object sender, EventArgs e) // Ввод запятой
        {
            Button buttonComma = (Button)sender;
            if (textBox1.Text.Count(x => x == ',') == 0)
            {
                textBox1.Text = textBox1.Text + buttonComma.Text;
                button13.Enabled = false;
            }
        }

        private void button22_Click(object sender, EventArgs e) // Выход из программы
        {
            DialogResult res = MessageBox.Show("Вы точно хотите выйти из программу ?", "Выход из программы ", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (res == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}

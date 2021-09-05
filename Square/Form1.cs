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
        public bool simple = true;
        public bool analit = false;
        public bool isreal = true;
        public bool iscomplex = false;
        public bool islong = false;
        public bool textBox2Clicked = true;

        public double value { get; set; } // создание поля которое может хранить значение
        Sqrt sqrt = new Sqrt(); // создание экземпляра класса Sqrt
        Complex complex = new Complex();
        LongNumbers longNumber = new LongNumbers();

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
        


        private void groupBox1_Enter(object sender, EventArgs e) // выбор типа
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e) // обработка нажатия на цифры
        {
            Button buttonNumber = (Button)sender;
            if (radioButton2.Checked)
            {
                if (textBox1.TextLength<40)
                {
                    if (textBox1.Text == "0")
                        textBox1.Text = buttonNumber.Text;
                    else
                        textBox1.Text = textBox1.Text + buttonNumber.Text;
                }
                else
                {
                    textBox1.Text = textBox1.Text;
                }
            }

            if (textBox2Clicked == true)  // ввод при клике пользователя 
            {
                if (textBox2.Text == "0")
                    textBox2.Text = buttonNumber.Text;
                else
                    textBox2.Text = textBox2.Text + buttonNumber.Text;
            }
            else
            {
                if (textBox3.Text == "0")
                    textBox3.Text = buttonNumber.Text;
                else
                    textBox3.Text = textBox3.Text + buttonNumber.Text;
            }

            if (radioButton5.Checked)
            {
                if (textBox6.Text == "0")
                    textBox6.Text = buttonNumber.Text;
                else
                    textBox6.Text = textBox6.Text + buttonNumber.Text;
            }
        }

        private void button18_Click(object sender, EventArgs e) // нажатие на результат (сохранение введенного числа)
        {

            if (isreal)
            {
                if (simple)
                {
                    if (sqrt.positive)
                    {
                        sqrt.number = double.Parse(textBox1.Text);// приводим строку, которая в дисплее в тип double
                        sqrt.doubleSqrt = sqrt.GetDoubleSqrt();// в поле результата обычного корня присваиваем значение метода
                        textBox1.Text = $"{sqrt.doubleSqrt}";// вывод значения на экран
                    }
                    else
                    {
                        sqrt.number = double.Parse(textBox1.Text.Replace("-", ""));// приводим строку, которая в дисплее в тип double и удаляем -
                        sqrt.doubleSqrt = sqrt.GetDoubleSqrt(); // в поле результата обычного корня присваиваем значение метода
                        textBox1.Text = $"±{sqrt.doubleSqrt}i"; // вывод значения на экран
                        sqrt.positive = true;
                        button18.Enabled = false;
                        button15.Enabled = false;
                    }
                }
                if (analit)
                {
                    if (sqrt.positive)
                    {
                        sqrt.number = double.Parse(textBox1.Text);// приводим строку, которая в дисплее в тип double

                        sqrt.analitSqrt = sqrt.GetAnalitSqrt();
                        textBox1.Text = $"{sqrt.analitSqrt}";
                    }
                    else
                    {
                        sqrt.number = double.Parse(textBox1.Text.Replace("-", ""));// приводим строку, которая в дисплее в тип double и удаляем -
                        sqrt.analitSqrt = sqrt.GetAnalitSqrt();
                        textBox1.Text = $"±{sqrt.analitSqrt}i";
                        sqrt.positive = true;
                        button18.Enabled = false;
                        button15.Enabled = false;
                    }
                }
            }
            if (iscomplex)
            {
                complex.real = double.Parse(textBox2.Text);
                complex.imaginary = double.Parse(textBox3.Text);
                complex.WholeProcess();
                textBox4.Text = complex.sqrtTrig1;
                textBox5.Text = complex.sqrtTrig2;




            }
            if (islong)
            {
                longNumber.number = textBox6.Text;
            }

            button13.Enabled = true; // включает запятую
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e) // Реальные числа, переключатель
        {
            if (radioButton2.Checked)
            {
                // отключение кнопок при нажатии на реал.числа
                numericUpDown1.Visible = true;
                label2.Visible = true;
                textBox1.Visible = true;
                textBox2.Visible = false;
                textBox3.Visible = false;
                textBox4.Visible = false;
                textBox5.Visible = false;
                textBox6.Visible = false;

                label3.Visible = false;
                label4.Visible = false;
                label5.Visible = false;
                label6.Visible = false;
                label7.Visible = false;
                label8.Visible = false;
                label9.Visible = false;

                isreal = true;
                iscomplex = false;
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e) // Комплексные числа, переключатель
        {
            if (radioButton1.Checked)
            {
                // включение кнопок при нажатии на компл.числа
                numericUpDown1.Visible = false;
                label2.Visible = false;
                textBox1.Visible = false;
                textBox2.Visible = true;
                textBox3.Visible = true;
                textBox4.Visible = true;
                textBox5.Visible = true;
                textBox6.Visible = false;

                label3.Visible = true;
                label4.Visible = true;
                label5.Visible = true;
                label6.Visible = true;
                label7.Visible = true;
                label8.Visible = true;
                label9.Visible = true;
                isreal = false;
                iscomplex = true;
            }
        }

        private void button19_Click(object sender, EventArgs e) // кнопка C (стирание написанного) 
        {
            if (radioButton2.Checked)
            {
                textBox1.Text = "0";
            }
            if (radioButton1.Checked)
            {
                textBox2.Text = "0";
                textBox3.Text = "0";
                textBox4.Text = "0";
                textBox5.Text = "0";

            }

            button13.Enabled = true; // включает запятую
            button18.Enabled = true;
            button15.Enabled = true;


        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e) // Способо извл. корня:  Аналитический
        {
            simple = false;
            analit = true;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e) // Способ извл. корня:  Обычный
        {
            simple = true;
            analit = false;
        }

        private void button13_Click(object sender, EventArgs e) // Ввод запятой
        {
            Button buttonComma = (Button)sender;
            if (radioButton2.Checked)
            {
                if (textBox1.Text.Count(x => x == ',') == 0)
                {
                    textBox1.Text = textBox1.Text + buttonComma.Text;
                    button13.Enabled = false;
                }
            }
            else
            {
                if (textBox2Clicked)
                {
                    textBox2.Text = textBox2.Text + buttonComma.Text;
                    button13.Enabled = false;
                }
                else
                {
                    textBox3.Text = textBox3.Text + buttonComma.Text;
                    button13.Enabled = false;
                }
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button15_Click(object sender, EventArgs e) //смена знака
        {
            if (radioButton2.Checked) // для реальных чисел
            {
                if (textBox1.Text != "0")
                {
                    if (sqrt.positive)
                    {
                        textBox1.Text = "-" + textBox1.Text;
                        sqrt.positive = false;
                    }
                    else
                    {
                        textBox1.Text = textBox1.Text.Replace("-", "");
                        sqrt.positive = true;
                    }
                }
            }
            else if (radioButton1.Checked) // для комплексных чисел
            {
                if (textBox2Clicked && textBox2.Text != "0") // реальная часть, смена знака
                {
                    if (double.Parse(textBox2.Text) > 0)
                    {
                        textBox2.Text = "-" + textBox2.Text;
                    }
                    else
                    {
                        textBox2.Text = textBox2.Text.Replace("-", "");
                    }
                }
                else if (textBox2Clicked == false && textBox3.Text != "0") // мнимая часть, смена знака
                {
                    if (double.Parse(textBox3.Text) > 0)
                    {
                        textBox3.Text = "-" + textBox3.Text;
                    }
                    else
                    {
                        textBox3.Text = textBox3.Text.Replace("-", "");
                    }
                }
            }
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            textBox2Clicked = true;
            if (textBox2.Text.Count(x => x == ',') == 0)
                button13.Enabled = true;
        }

        private void textBox3_Click(object sender, EventArgs e)
        {
            textBox2Clicked = false;
            if (textBox3.Text.Count(x => x == ',') == 0)
                button13.Enabled = true;
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            label7.Visible = true;
            label2.Visible = true;
            numericUpDown1.Visible = true;
            textBox6.Visible = true;
            textBox1.Visible = true;

            label5.Visible = false;
            label6.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label8.Visible = false;
            label9.Visible = false;
            textBox2.Visible = false;
            textBox3.Visible = false;
            textBox4.Visible = false;
            textBox5.Visible = false;
        }


    }
}

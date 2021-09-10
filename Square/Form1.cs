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

        public bool isRussian { get; set; }
        public bool isEnglish { get; set; }
        public bool isSpanish { get; set; }
        public bool isChinese { get; set; }
        public bool isHindi { get; set; }


        public void SetRussian()
        {
            isRussian = true;
            isEnglish = false;
            isSpanish = false;
            isChinese = false;
            isHindi = false;

            label10.Text = "Вы можете ввести число \nпроизвольной длины, \nно без дробной части";
            label11.Text = "Ввод - вывод";
            label2.Text = "Число знаков после запятой";
            label1.Text = "Выбор языка (Language)";
            groupBox1.Text = "Тип данных";
            radioButton1.Text = "Комплексные";
            radioButton2.Text = "Реальные";
            label5.Text = "Реальная часть";
            label6.Text = "Мнимая часть";
            radioButton5.Text = "Длинные числа";
            button1.Text = "О программе";
            button2.Text = "Связаться";
            button22.Text = "Выход";
            Text = "Извлекатель";
        }

        public void SetEnglish()
        {
            isRussian = false;
            isEnglish = true;
            isSpanish = false;
            isChinese = false;
            isHindi = false;
            label10.Text = "You can enter a number \narbitrary length, \nbut without fractional part";
            label11.Text = "Input - output";
            label2.Text = "Number of decimal places";
            label1.Text = "Language selection (Language)";
            groupBox1.Text = "Data type";
            radioButton1.Text = "Complex";
            radioButton2.Text = "Real";
            label5.Text = "Real part";
            label6.Text = "Imaginary part";
            label7.Text = "Result";
            radioButton5.Text = "Long numbers";
            button1.Text = "About";
            button2.Text = "Contact";
            button22.Text = "Exit";
            Text = "Squarer";
        }

        public void SetSpanish()
        {
            isRussian = false;
            isEnglish = false;
            isSpanish = true;
            isChinese = false;
            isHindi = false;

            label10.Text= "Puede ingresar un número \nlongitud arbitraria, \npero sin parte fraccionaria";
            label11.Text = "Aporte - producción";
            label2.Text = "El número de posiciones decimales";
            label1.Text = "Elegir el idioma (Language)";
            groupBox1.Text = "Tipo de datos";
            radioButton1.Text = "Complejos";
            radioButton2.Text = "Real";
            label5.Text = "Parte real";
            label6.Text = "Parte imaginaria";
            label7.Text = "Resultado";
            radioButton5.Text = "Números largos";
            button1.Text = "Sobre el programa";
            button2.Text = "Сontacto";
            button22.Text = "Salida";
            Text = "Radical";
        }

        public void SetChinese()
        {
            isRussian = false;
            isEnglish = false;
            isSpanish = false;
            isChinese = true;
            isHindi = false;

            label10.Text = "你可以输入一个数字 \n任意长度, \n但没有小数部分";
            label11.Text = "输入 - 输出";
            label2.Text = "小数位数";
            label1.Text = "语言选择 (Language)";
            groupBox1.Text = "数据类型";
            radioButton1.Text = "复杂的";
            radioButton2.Text = "真实的";
            label5.Text = "真实的部分";
            label6.Text = "虚部";
            label7.Text = "结果";
            radioButton5.Text = "长号";
            button1.Text = "关于节目";
            button2.Text = "接触";
            button22.Text = "输出";
            Text = "激進的";
        }

        public void SetHindi()
        {
            isRussian = false;
            isEnglish = false;
            isSpanish = false;
            isChinese = false;
            isHindi = true;

            label11.Text = "प्रवेश करना - उत्पादन";
            label10.Text = "आप एक नंबर दर्ज कर सकते हैं \nमनमानी लंबाई, \nलेकिन भिन्नात्मक भाग के बिना";
            label2.Text = "दशमलव स्थानों की संख्या";
            label1.Text = "भाषा चयन (Language)";
            groupBox1.Text = "डाटा प्रकार";
            radioButton1.Text = "जटिल";
            radioButton2.Text = "असली";
            label5.Text = "असली हिस्सा";
            label6.Text = "काल्पनिक भाग";
            label7.Text = "नतीजा";
            radioButton5.Text = "लंबी संख्या";
            button1.Text = "कार्यक्रम के बारे में";
            button2.Text = "संपर्क";
            button22.Text = "उत्पादन";
            Text = "मौलिक";
        }


        public bool simple = true;
        public bool analit = false;
        public bool isreal = true;
        public bool iscomplex = false;
        public bool islong = false;
        public bool textBox2Clicked = true;

        public double value { get; set; } // создание поля которое может хранить значение
        Sqrt sqrt = new Sqrt(); // создание экземпляра класса Sqrt
        Complex complex = new Complex();
        public Form1()
        {
            InitializeComponent();
            SetEnglish();
        }


        private void button1_Click(object sender, EventArgs e) // Кнопка "О программе"
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e) // счетчик точности
        {
            value = (double)numericUpDown1.Value;// в поле value присвоится значение из счетчика
            sqrt.iter = value; // в поле итер записываем значение точности

        }
        
        private void button2_Click(object sender, EventArgs e) // Кнопка "Связь"
        {

        }

        private void button14_Click(object sender, EventArgs e) // обработка нажатия на цифры
        {
            Button buttonNumber = (Button)sender;
            if (radioButton2.Checked && textBox1.TextLength < 20)
            {
                if (textBox1.Text == "0")
                    textBox1.Text = buttonNumber.Text;
                else
                    textBox1.Text = textBox1.Text + buttonNumber.Text;
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

            if (radioButton5.Checked && textBox6.Text.Length < 500)
            {
                if (textBox6.Text == "0")
                    textBox6.Text = buttonNumber.Text;
                else
                    textBox6.Text = textBox6.Text + buttonNumber.Text;
            }
        }


        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar)) && (e.KeyChar != 45) && (e.KeyChar != (char)Keys.Back)) e.Handled = true;
        }


        private void button18_Click(object sender, EventArgs e) // нажатие на результат (сохранение введенного числа)
        {

            if (isreal)
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
                textBox6.Text = LongNumbers.Sqrt(textBox6.Text);
            }

            button13.Enabled = true; // включает запятую
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
                button13.Enabled = true;
                textBox6.Text = "0";

                label3.Visible = false;
                label4.Visible = false;
                label5.Visible = false;
                label6.Visible = false;
                label7.Visible = false;
                label8.Visible = false;
                label9.Visible = false;
                label10.Visible = false;
                label11.Visible = false;

                islong = false;
                isreal = true;
                iscomplex = false;

                button18.Enabled = true;
                button15.Enabled = true;
                textBox2.Text = "0";
                textBox3.Text = "0";

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
                label10.Visible = false;
                label11.Visible = false;
                textBox6.Text = "0";

                button13.Enabled = true;
                label3.Visible = true;
                label4.Visible = true;
                label5.Visible = true;
                label6.Visible = true;
                label7.Visible = true;
                label8.Visible = true;
                label9.Visible = true;
                islong = false;
                isreal = false;
                iscomplex = true;

                button18.Enabled = true;
                button15.Enabled = true;
                textBox1.Text = "0";
            }
        }

        private void button19_Click(object sender, EventArgs e) // кнопка C (стирание написанного) 
        {

                textBox1.Text = "0";
                textBox2.Text = "0";
                textBox3.Text = "0";
                textBox4.Text = "0";
                textBox5.Text = "0";
                textBox6.Text = "0";

            button13.Enabled = true; // включает запятую
            button18.Enabled = true;
            button15.Enabled = true;


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
                Application.Exit();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) // при выборе языка он меняется
        {
            if (comboBox1.Text == "Russian (Русский)")
                SetRussian();
            if (comboBox1.Text == "English")
                SetEnglish();
            if (comboBox1.Text == "Hindi (हिन्दी)")
                SetHindi();
            if (comboBox1.Text == "Chinese (中文)")
                SetChinese();
            if (comboBox1.Text == "Spanish (Español)")
                SetSpanish();
        }

        private void button15_Click(object sender, EventArgs e) //смена знака +/-
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

        private void textBox2_Click(object sender, EventArgs e) // проверка для корректной работы запятой
        {
            textBox2Clicked = true;
            if (textBox2.Text.Count(x => x == ',') == 0)
                button13.Enabled = true;
        }

        private void textBox3_Click(object sender, EventArgs e) // проверка для корректной работы запятой
        {
            textBox2Clicked = false;
            if (textBox3.Text.Count(x => x == ',') == 0)
                button13.Enabled = true;
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e) // переключение на длинные числа
        {
            label10.Visible = true;
            label11.Visible = true;
            label7.Visible = false;
            label2.Visible = false;
            numericUpDown1.Visible = false;
            textBox6.Visible = true;
            textBox1.Visible = true;
            button13.Enabled = false;
            label5.Visible = false;
            label6.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label8.Visible = false;
            label9.Visible = false;
            textBox1.Visible = false;
            textBox2.Visible = false;
            textBox3.Visible = false;
            textBox4.Visible = false;
            textBox5.Visible = false;

            islong = true;
            isreal = false;
            iscomplex = false;

            button18.Enabled = true;
            button15.Enabled = true;
            textBox2.Text = "0";
            textBox3.Text = "0";
            textBox1.Text = "0";
            textBox6.Text = "0";
        }

    }
}

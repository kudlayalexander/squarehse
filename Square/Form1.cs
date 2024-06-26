﻿using System;
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
        public void SetRussian() // установка русского языка
        {
            Language.Rus = true;
            Language.Eng = false;
            Language.Sp = false;
            Language.Chi = false;
            Language.Hin = false;

            comboBox1.Text = "Russian (Русский)";
            incorrectInput = "Неверный ввод";
            incorrectCaption = "Ошибка";
            label10.Text = "Вы можете ввести число \nдлиной < 1500 символов, \nбез дробной части";
            label11.Text = "Ввод - вывод";
            label7.Text = "Результат";
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

        public void SetEnglish()// установка английского языка
        {
            Language.Rus = false;
            Language.Eng = true;
            Language.Sp = false;
            Language.Chi = false;
            Language.Hin = false;

            comboBox1.Text = "English";
            incorrectInput = "Incorrect input";
            incorrectCaption = "Error";
            label10.Text = "You can enter a number \nwith a length of <1500 characters, \nwithout the fractional part";
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

        public void SetSpanish()// установка испанского языка
        {
            Language.Rus = false;
            Language.Eng = false;
            Language.Sp = true;
            Language.Chi = false;
            Language.Hin = false;

            comboBox1.Text = "Spanish (Español)";
            incorrectInput = "Entrada incorrecta";
            incorrectCaption = "Error";
            label10.Text= "Puede ingresar un número \ncon una longitud de <1500 caracteres, \nsin la parte fraccionaria";
            label11.Text = "Aporte - producción";
            label2.Text = "El número de posiciones \ndecimales";
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

        public void SetChinese() // установка китайского языка
        {
            Language.Rus = false;
            Language.Eng = false;
            Language.Sp = false;
            Language.Chi = true;
            Language.Hin = false;

            comboBox1.Text = "Chinese (中文)";
            incorrectInput = "输入不正确";
            incorrectCaption = "错误";
            label10.Text = "您可以輸入長度小於 1500 \n個字符的數字，\n不含小數部分";
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

        public void SetHindi() // установка языка хинди
        {
            Language.Rus = false;
            Language.Eng = false;
            Language.Sp = false;
            Language.Chi = false;
            Language.Hin = true;

            comboBox1.Text = "Hindi (हिन्दी)";
            incorrectInput = "गलत इनपुट";
            incorrectCaption = "गलती";
            label11.Text = "प्रवेश करना - उत्पादन";
            label10.Text = "आप भिन्नात्मक भाग के \nबिना <1500 वर्णों की लंबाई \nवाली संख्या दर्ज कर सकते हैं";
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


        // объявление переменных для корректной работы вывода длинных чисел
        string incorrectInput = "Incorrect input";
        string incorrectCaption = "Error";
        bool correctInput = true;

        public double value { get; set; } // создание поля которое может хранить значение
        Sqrt sqrt = new Sqrt(); // создание экземпляра класса Sqrt
        Complex complex = new Complex();

        public Form1()
        {
            
            InitializeComponent();
            if (Language.Eng) SetEnglish();
            if (Language.Chi) SetChinese();
            if (Language.Sp) SetSpanish();
            if (Language.Rus) SetRussian();
            if (Language.Hin) SetHindi();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e) // счетчик точности
        {
            value = (double)numericUpDown1.Value;// в поле value присвоится значение из счетчика
            sqrt.iter = value; // в поле итер записываем значение точности

        }
        
        private void button2_Click(object sender, EventArgs e) // Кнопка "Связь"
        {
            MessageBox.Show("kudlay2014@yandex.ru \nVitaliyTyu@yandex.ru");
        }

        private void button14_Click(object sender, EventArgs e) // обработка нажатия на цифры
        {
            Button buttonNumber = (Button)sender;
            if (radioButton2.Checked && textBox1.TextLength < 20) // ограничение длины текста в реальных числах
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

            if (radioButton5.Checked && textBox6.Text.Length < 1500) // ограничение длины текста в длинных числах
            {
                if (textBox6.Text == "0")
                    textBox6.Text = buttonNumber.Text;
                else
                    textBox6.Text = textBox6.Text + buttonNumber.Text;
            }
        }

        private void button18_Click(object sender, EventArgs e) // нажатие на результат (сохранение введенного числа)
        {

            if (isreal) // результат корня из реальных чисел
            {
                if (sqrt.positive)
                {
                    if (double.Parse(textBox1.Text) > 0)
                    {
                        sqrt.number = double.Parse(textBox1.Text);// приводим строку, которая в дисплее в тип double
                        sqrt.doubleSqrt = sqrt.GetDoubleSqrt();// в поле результата обычного корня присваиваем значение метода
                        textBox1.Text = $"±{sqrt.doubleSqrt}";// вывод значения на экран
                        button18.Enabled = false;
                        button15.Enabled = false;
                    }
                    else
                    {
                        sqrt.number = double.Parse(textBox1.Text);// приводим строку, которая в дисплее в тип double
                        sqrt.doubleSqrt = sqrt.GetDoubleSqrt();// в поле результата обычного корня присваиваем значение метода
                        textBox1.Text = $"{sqrt.doubleSqrt}";// вывод значения на экран
                    }
                   
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
                button13.Enabled = true; // включает запятую
            }

            if (iscomplex) // результат корня из комплексных чисел
            {
                complex.real = double.Parse(textBox2.Text);
                complex.imaginary = double.Parse(textBox3.Text);
                complex.WholeProcess();
                textBox4.Text = complex.sqrtTrig1;
                textBox5.Text = complex.sqrtTrig2;
                if (textBox2.Text.Count(x => x == ',') == 0)
                    button13.Enabled = true;
                if (textBox3.Text.Count(x => x == ',') == 0)
                    button13.Enabled = true;

            }
            if (islong) // результат корня из длинных чисел
            {
                // проверка введенных значений
                correctInput = true;
                for (int i = 0; i < textBox6.Text.Length; i++)
                {
                    if (i == 0 && !(Char.IsDigit(textBox6.Text[i])) && textBox6.Text[i] != '-') // проверка первого символа числа (цифра/минус)
                        correctInput = false;

                    if (i > 0 && (!Char.IsDigit(textBox6.Text[i]) || textBox6.Text[i] == '-')) // проверка остальных символов (цифры)
                        correctInput = false;

                    if (textBox6.Text.Length >= 1500) // ограничение ввода после преодоления максимума длины
                        correctInput = false;
                }

                if (LongNumbers.positive) // корень из положительных длинных чисел
                {
                    if (textBox6.Text == "0")
                    {
                        textBox6.Text = "0";
                    }
                    if (correctInput)
                    {
                        textBox6.Text = LongNumbers.Sqrt(textBox6.Text); // вывод значения на экран
                        textBox6.Text = "±" + textBox6.Text;
                        button18.Enabled = false;
                        button15.Enabled = false;
                    }
                    else
                    {
                        MessageBox.Show(incorrectInput, incorrectCaption, MessageBoxButtons.OK, MessageBoxIcon.Warning); // вывод ошибки ввода на экран
                    }
                }
                else // корень из отрицательных длинных чисел
                {
                    if (correctInput)
                    {
                        textBox6.Text = $"±{LongNumbers.Sqrt(textBox6.Text.Replace("-", ""))}i"; // вывод значения на экран
                        LongNumbers.positive = true;
                        button18.Enabled = false;
                        button15.Enabled = false;
                    }
                    else
                    {
                        MessageBox.Show(incorrectInput, incorrectCaption, MessageBoxButtons.OK, MessageBoxIcon.Warning); // вывод ошибки ввода на экран
                    }
                }
                button13.Enabled = true; // включает запятую


            }

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
            // очистка всех полей
            textBox1.Text = "0";
            textBox2.Text = "0";
            textBox3.Text = "0";
            textBox4.Text = "0";
            textBox5.Text = "0";
            textBox6.Text = "0";

            // включение кнопок после очистки
            button13.Enabled = true;
            button18.Enabled = true; 
            button15.Enabled = true;


        }

        private void button13_Click(object sender, EventArgs e) // Ввод запятой
        {
            Button buttonComma = (Button)sender;
            if (radioButton2.Checked) // ввод запятой для реальных чисел
            {
                if (textBox1.Text.Count(x => x == ',') == 0)
                {
                    textBox1.Text = textBox1.Text + buttonComma.Text;
                    button13.Enabled = false;
                }
            }
            else // ввод запятой для комплексных чисел
            {
                if (textBox2Clicked) // ввод запятой в реальную часть
                {
                    textBox2.Text = textBox2.Text + buttonComma.Text;
                    button13.Enabled = false;
                }
                else // ввод запятой в мнимую часть
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
                    if (sqrt.positive) // добавляет минус у положительных чисел
                    {
                        textBox1.Text = "-" + textBox1.Text;
                        sqrt.positive = false;
                    }
                    else // убирает минус у отрицательных чисел
                    {
                        textBox1.Text = textBox1.Text.Replace("-", "");
                        sqrt.positive = true;
                    }
                }
            }

            if (radioButton1.Checked) // для комплексных чисел
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

            if (radioButton5.Checked) // длинные числа
            {
                if (textBox6.Text != "0")
                {
                    if (LongNumbers.positive) // смена знака для положительных
                    {
                        textBox6.Text = "-" + textBox6.Text;
                        LongNumbers.positive = false;
                    }
                    else
                    {
                        textBox6.Text = textBox6.Text.Replace("-", "");
                        LongNumbers.positive = true;

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

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e) // ограничение на ввод в длинных числах
        {
            {
                if (!(Char.IsDigit(e.KeyChar)) && (e.KeyChar != (char)Keys.Back)) e.Handled = true;
            }
        }

        private void button1_Click_1(object sender, EventArgs e) // кнопка "О программе"
        {
            Guide nextForm = new Guide();
            Form1.ActiveForm.Visible = false;
            nextForm.Show();
        }
    }
}

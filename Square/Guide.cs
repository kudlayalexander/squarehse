using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Square
{
    public partial class Guide : Form
    {
        public Guide()
        {

            InitializeComponent();
            label3.Text = "(1.) Тип данных: 'Реальные' позволяет вачислить корень из числа(положительного \nили отрицательного), имеющего 20 разрдов, с точность знаков после запятой равной 0 - 15.\n\n" +
                "(2.)(3.) Выберите тип данных:'Комплексные' или тип данных:'Длинные числа', чтобы \nиспользовать измененный функионал программы.\n\n" +
                "(4.) Добавит или удалит знак минус перед введенным числом. Чтобы после извлечение корня из \nотрицательного числа вернутья к вводу чисел нажмите кнопку (5.).\n\n" +
                "(5.) Вернет текст поля вводва/вывода в первоначальное состояние.\n\n" +
                "(6.) Нажмите для вычисления корня из числа, которе находится в поле(8.).\n\n" +
                "(7.) Вы можете выпрать один из пяти языков.\n\n" +
                "(8.) Поле ввода/вывода.\n\n" +
                "(9.) Нажмите, чтобы посмотреть обучение.\n\n" +
                "(10.) Связь с разработчиками.\n\n" +
                "(11.) точность вывода , максимальное значение 15.\n\n";

            label5.Text = "(1.) Нажмите на поле ввода мнимой или реальной части, после этого начните ввод. Вы можете \nввести по 20 символов в каждое поле.\n\n" +
                "(2). Меняет знак у числа в выбранном поле(1.).\n\n" +
                "(3.) Вывод результата.\n\n";

            label7.Text = "Все кнопики выполняют тот же функционал.\nВ этом разделе вы можете вводить число с клавиатуры.";


        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 nextForm = new Form1();
            Guide.ActiveForm.Visible = false;
            nextForm.Show();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

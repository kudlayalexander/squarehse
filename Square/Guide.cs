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
    public partial class Guide : Form
    {
        public void SetRussian()
        {
            pictureBox1.Image = Properties.Resources.RealRUS;
            pictureBox2.Image = Properties.Resources.ComplexRUS;
            pictureBox3.Image = Properties.Resources.LongRUS;


            button1.Text = "К программе";
            button22.Text = "Выход";

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

            label7.Text = "Все кнопки выполняют тот же функционал.\nВ этом разделе вы можете вводить число с клавиатуры.";
        }
        public void SetEnglish()
        {
            pictureBox1.Image = Properties.Resources.RealENG;
            pictureBox2.Image = Properties.Resources.ComplexENG;
            pictureBox3.Image = Properties.Resources.LongENG;


            button1.Text = "To programm";
            button22.Text = "Exit";

            label3.Text = "(1.) Data type: 'Real' allows you to count the root of number(positive \nor negative), which has 20 digits, with precision of decimal places equal to 0 - 15.\n\n" +
                "(2.)(3.) Choose  the data type:'Complex' or 'Long numbers', to \nuse modified program functions.\n\n" +
                "(4.) Add or remove a minus sign in front of an entered number. So that after extracting the root from \na negative number return to entering numbers press (5.).\n\n" +
                "(5.) Returns the text from the input/output field to its original state.\n\n" +
                "(6.) Click to calculate the root of the number in the field(8.).\n\n" +
                "(7.) You can choose one of the five languages.\n\n" +
                "(8.) Input/output field.\n\n" +
                "(9.) Click to watch the tutorial.\n\n" +
                "(10.) Contact with developers.\n\n" +
                "(11.) output accuracy , maximum value 15.\n\n";

            label5.Text = "(1.) Click on the input field of the imaginary or real part, after that start typing. You can \nenter 20 characters in each field.\n\n" +
                "(2). Changes the sign of the number in the selected field(1.).\n\n" +
                "(3.) Outputting the result.\n\n";

            label7.Text = "All buttons perform the same functionality.\nIn this section, you can enter a number from the keyboard.";

        }
        public void SetChinese()
        {
            pictureBox1.Image = Properties.Resources.RealCHN;
            pictureBox2.Image = Properties.Resources.ComplexCHN;
            pictureBox3.Image = Properties.Resources.LongCHN;


            button1.Text = "到程序";
            button22.Text = "退出";

            label3.Text = "(1.) 数据类型：'真实' 允许您计算一个数的根(积极的 \n或否定), 有 20 位, 小数点精度等于 0 - 15.\n\n" +
                "(2.)(3.) 选择数据类型：“复数”或“长数”, \n使用程序修改后的功能.\n\n" +
                "(4.) 在输入的数字前添加或删除减号. 所以在提取根之后 \n负数返回输入数字按 (5.).\n\n" +
                "(5.) 将 I/O 字段的文本返回到其原始状态.\n\n" +
                "(6.) 单击以计算字段中数字的根(8.).\n\n" +
                "(7.) 您可以使用五种语言中的一种.\n\n" +
                "(8.) 输入/输出领域.\n\n" +
                "(9.) 点击观看教程.\n\n" +
                "(10.) 与开发者沟通.\n\n" +
                "(11.) 输出精度，最大值 15.\n\n";

            label5.Text = "(1.) 点击虚部或实部的输入栏，然后开始输入. 您可以 \n在每个字段中输入 20 个字符.\n\n" +
                "(2). 更改所选字段中数字的符号(1.).\n\n" +
                "(3.) 输出结果.\n\n";

            label7.Text = "所有按钮执行相同的功能.\n在此部分中，您可以从键盘输入数字.";
        }
        public void SetHindi()
        {
            pictureBox1.Image = Properties.Resources.RealHINDI;
            pictureBox2.Image = Properties.Resources.ComplexHINDI;
            pictureBox3.Image = Properties.Resources.LongHINDI;


            button1.Text = "कार्यक्रम के लिए";
            button22.Text = "बाहर निकलें";

            label3.Text = "(1.) डेटा प्रकार: 'रियल' आपको किसी संख्या की जड़ की गणना करने की अनुमति देता है(सकारात्मक \nया नकारात्मक), दशमलव परिशुद्धता के साथ 20 अंक होने के बराबर 0 - 15.\n\n" +
                "(2.)(3.) डेटा प्रकार का चयन करें: प्रोग्राम की संशोधित कार्यक्षमता का उपयोग करने के लिए 'कॉम्प्लेक्स' या 'लॉन्ग नंबर' \nका उपयोग करें.\n\n" +
                "(4.) दर्ज संख्या के सामने ऋण चिह्न जोड़ें या हटाएं. ऋणात्मक संख्या का मूल \nनिकालने के बाद प्रविष्ट संख्याओं पर लौटने के लिए, बटन दबाएं (5.).\n\n" +
                "(5.) I / O फ़ील्ड के टेक्स्ट को उसकी मूल स्थिति में लौटाता है।\n\n" +
                "(6.) फ़ील्ड में संख्या के मूल की गणना करने के लिए क्लिक करें(8.).\n\n" +
                "(7.) आप पाँच भाषाओं में से किसी एक से बाहर रह सकते हैं.\n\n" +
                "(8.) आई / ओ फील्ड.\n\n" +
                "(9.) ट्यूटोरियल देखने के लिए क्लिक करें.\n\n" +
                "(10.) डेवलपर्स के साथ संचार.\n\n" +
                "(11.) आउटपुट परिशुद्धता, अधिकतम मूल्य 15.\n\n";

            label5.Text = "(1.) काल्पनिक या वास्तविक भाग के इनपुट फ़ील्ड पर क्लिक करें, फिर टाइप करना शुरू करें. आप ऐसा कर सकते हैं \nप्रत्येक क्षेत्र में २० वर्ण दर्ज करें.\n\n" +
                "(2). चयनित फ़ील्ड में संख्या का चिह्न बदलता है(1.).\n\n" +
                "(3.) परिणाम आउटपुट.\n\n";

            label7.Text = "सभी बटन समान कार्यक्षमता करते हैं.\nइस खंड में, आप कीबोर्ड से एक नंबर दर्ज कर सकते हैं.";
        }
        public void SetSpanish()
        {
            pictureBox1.Image = Properties.Resources.RealSPN;
            pictureBox2.Image = Properties.Resources.ComplexSPN;
            pictureBox3.Image = Properties.Resources.LongSPN;


            button1.Text = "Al programa";
            button22.Text = "Salida";

            label3.Text = "(1.) Tipo de datos: 'Real' le permite calcular la raíz de un número(positivo \no negativo), que tiene 20 dígitos, con precisión decimal igual a 0 - 15.\n\n" +
                "(2.)(3.) Seleccione el tipo de datos: 'Complejo' o 'Números largos' para \nutilizar la función de programa modificado.\n\n" +
                "(4.) Agregar o quitar un signo menos delante de un número ingresado. Para que después de extraer la raíz de \nun número negativo volver a ingresar números presione el (5.).\n\n" +
                "(5.) Devuelve el texto del campo de E / S a su estado original..\n\n" +
                "(6.) Haga clic para calcular la raíz del número en el campo(8.).\n\n" +
                "(7.) Puedes destacar uno de los cinco idiomas.\n\n" +
                "(8.) Campo de E / S.\n\n" +
                "(9.) Haga clic para ver el tutorial.\n\n" +
                "(10.) Comunicación con desarrolladores.\n\n" +
                "(11.) precisión de salida, valor máximo 15.\n\n";

            label5.Text = "(1.) Haga clic en el campo de entrada de la parte imaginaria y real, luego comience a escribir. Usted puede \ningrese 20 caracteres en cada campo.\n\n" +
                "(2). Cambia el signo del número en el campo seleccionado(1.).\n\n" +
                "(3.) Salida del resultado.\n\n";

            label7.Text = "Todos los botones realizan la misma funcionalidad.\nEn esta sección, puede ingresar un número desde el teclado.";
        }

        public Guide()
        {

            InitializeComponent();
            SetEnglish();
            if (Language.Eng) SetEnglish();
            if (Language.Chi) SetChinese();
            if (Language.Sp) SetSpanish();
            if (Language.Rus) SetRussian();
            if (Language.Hin) SetHindi();

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

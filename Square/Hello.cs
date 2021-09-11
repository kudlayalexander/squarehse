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
    public partial class Hello : Form
    {
        public void SetRussian()
        {
            Language.Rus = true;
            Language.Eng = false;
            Language.Sp = false;
            Language.Chi = false;
            Language.Hin = false;

            button2.Text = "Выход";
            button1.Text = "Старт";
        }

        public void SetEnglish()
        {
            Language.Rus = false;
            Language.Eng = true;
            Language.Sp = false;
            Language.Chi = false;
            Language.Hin = false;

            button2.Text = "Exit";
            button1.Text = "Start";
        }

        public void SetSpanish()
        {
            Language.Rus = false;
            Language.Eng = false;
            Language.Sp = true;
            Language.Chi = false;
            Language.Hin = false;

            button2.Text = "Salida";
            button1.Text = "Comienzo";
        }

        public void SetChinese()
        {
            Language.Rus = false;
            Language.Eng = false;
            Language.Sp = false;
            Language.Chi = true;
            Language.Hin = false;

            button2.Text = "出口";
            button1.Text = "開始";
        }

        public void SetHindi()
        {
            Language.Rus = false;
            Language.Eng = false;
            Language.Sp = false;
            Language.Chi = false;
            Language.Hin = true;

            button2.Text = "बाहर जाएं";
            button1.Text = "शुरू";
        }

        public Hello()
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
            Guide nextForm = new Guide();
            Hello.ActiveForm.Visible = false;
            nextForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
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
    }
}

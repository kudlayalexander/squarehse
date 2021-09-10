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
    public partial class Hello : Form
    {
        public Hello()
        {

            InitializeComponent();
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
    }
}

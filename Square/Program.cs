using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyLib;

namespace Square
{
    static class Program
    {

        [STAThread]
        /*!
         launch first window
         */
        /// test
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Hello());
        }
    }
}

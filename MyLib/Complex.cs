using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLib
{
    public class Complex
    {
        public double real { get; set; }
        public double imaginary { get; set; }
        public double realTrig { get; set; }
        public double imaginaryTrig { get; set; }
        public double module { get; set; }
        public double argument { get; set; }
        public bool realPositive { get; set; }
        public bool imaginaryPositive { get; set; }
        public int quarter { get; set; }
        public string sqrtTrig1 { get; set; }
        public string sqrtTrig2 { get; set; }




        public Complex(double real=0, double imaginary=0)
        {
            this.real = real;
            this.imaginary = imaginary;
            realPositive = real >= 0;
            imaginaryPositive = imaginary >= 0;
            SetModule();
            SetArgument();
            realTrig = module * Math.Cos(argument);
            imaginaryTrig = module * Math.Sin(argument);
            CalculateSqrt();

        }

        /// calculate module
        public void SetModule()
        {
            module = Math.Sqrt(Math.Pow(real, 2) + Math.Pow(imaginary, 2));
        }

        public void SetQuarter()
        {
            if (realPositive && imaginaryPositive)
            {
                quarter = 1;
            }
            if (!realPositive && imaginaryPositive)
            {
                quarter = 2;
            }
            if (!realPositive && !imaginaryPositive)
            {
                quarter = 3;
            }
            if (realPositive && !imaginaryPositive)
            {
                quarter = 4;
            }
        }

        public void SetArgument()
        {

            SetQuarter();

            switch (quarter)
            {
                case 1:
                    if (real == 0) argument = Math.PI / 2;
                    else argument = Math.Atan((double)(imaginary / real));
                    break;

                case 2:
                    if (real == 0) argument = Math.PI / 2;
                    else argument = Math.Atan((double)(imaginary / real)) + Math.PI;
                    break;

                case 3:
                    if (real == 0) argument = -(Math.PI / 2);
                    else argument = Math.Atan((double)(imaginary / real)) + Math.PI;
                    break;

                case 4:
                    if (real == 0) argument = -(Math.PI / 2);
                    else argument = Math.Atan((double)(imaginary / real)) + 2 * Math.PI;
                    break;
            }
        }
        public void CalculateSqrt()
        {
            double re1 = Math.Cos((double)((argument + 2 * Math.PI * 0) / 2)) * Math.Sqrt(module);
            double im1 = Math.Sin((double)((argument + 2 * Math.PI * 0) / 2)) * Math.Sqrt(module);
            double re2 = Math.Cos((double)((argument + 2 * Math.PI * 1) / 2)) * Math.Sqrt(module);
            double im2 = Math.Sin((double)((argument + 2 * Math.PI * 1) / 2)) * Math.Sqrt(module);
            if (im1 >= 0) sqrtTrig1 = $"{re1}  +  {im1}i";
            else sqrtTrig1 = $"{re1}" + $"{im1}"[0] + $"{im1}".Replace("-", "") + "i";

            if (im2 >= 0) sqrtTrig2 = $"{re2} + {im2}i";
            else sqrtTrig2 = $"{re2}  " + $"{im2}"[0] + $"  {im2}".Replace("-", "") + "i";
        }

        public void WholeProcess()
        {
            realPositive = real >= 0;
            imaginaryPositive = imaginary >= 0;
            SetModule();
            SetArgument();
            CalculateSqrt();
        }

    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLib
{
    class Complex
    {
        public double real { get; set; }
        public double imaginary { get; set; }
        public double realTrig { get; set; }
        public double imaginaryTrig { get; set; }
        public string operation { get; set; }
        public double module { get; set; }
        public double argument { get; set; }
        public bool realPositive { get; set; }
        public bool imaginaryPositive { get; set; }
        public int quarter { get; set; }




        public Complex(double real=0, double imaginary=0, string operation="+", bool realPositive=true, bool imaginaryPositive=true)
        {
            this.real = real;
            this.imaginary = imaginary;
            this.operation = operation;
            this.realPositive = realPositive;
            this.imaginaryPositive = imaginaryPositive;
            module = Math.Sqrt(Math.Pow(real, 2) + Math.Pow(imaginary, 2));
            SetArgument();
            realTrig = module * Math.Cos(argument);
            imaginaryTrig = module * Math.Sin(argument);



        }

        public void GetQuarter()
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

            GetQuarter();

            switch (quarter)
            {
                case 1:
                    if (real == 0) argument = 0;
                    else argument = Math.Atan((double)(imaginary / real));
                    break;

                case 2:
                    if (real == 0) argument = 0;
                    else argument = Math.Atan((double)(imaginary / real)) + Math.PI;
                    break;

                case 3:
                    if (real == 0) argument = 0;
                    else argument = Math.Atan((double)(imaginary / real)) + Math.PI;
                    break;

                case 4:
                    if (real == 0) argument = 0;
                    else argument = Math.Atan((double)(imaginary / real));
                    break;
            }
        }

        public void setTrig()
        {

        }



    }
}

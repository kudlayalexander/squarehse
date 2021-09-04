using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MyLib
{
    public class Sqrt
    {
        public double doubleSqrt { get; set; }
        public double number { get; set; }

        public Sqrt (double doubleSqrt=0,double number=0)
        {
            this.doubleSqrt = doubleSqrt;
            this.number = number;
        }

        public double GetDoubleSqrt(double number)
        {
            return Math.Sqrt(number);
        }

    }
}

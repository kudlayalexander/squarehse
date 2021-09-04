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

        public double analSqrt { get; set; }

        public double number { get; set; }

        public double iter { get; set; }

        public Sqrt (double number=0)
        {
            this.number = number;
        }

        public double GetDoubleSqrt()
        {
            return Math.Sqrt(number);
        }

        /*
        a = float(input())
        def x(n, a):
            return (1/2)*(n+a/n)
        sqrt = 0
        n = 1
        e = 0.000000000000001
        while abs(x(n, a)-n) > e:
            sqrt = x(n, a)
            n = sqrt
        print(sqrt)
        */

        public double AnalFunc(double n, double a)
        {
            return (1 / 2) * (n + a / n);
        }

        public double GetAnalSqrt()
        {
            double n = 1;
            double result = 0;

            for (int i = 0; i < iter; i++)
            {
                result = AnalFunc(n, number);
                n = result;
            }

            return result;

        }
    }
}

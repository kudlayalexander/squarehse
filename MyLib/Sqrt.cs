using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MyLib
{
    public class Sqrt
    {
        public bool positive { get; set; }
        public double doubleSqrt { get; set; } // поле с результатом после обычного вычисления корня
        public double analitSqrt { get; set; } // поле с результатом после аналитического вычисления
        public double number { get; set; } // поле с числом, их которого будем брать корень
        public double iter { get; set; } // точность
        public double e { get; set; }
        public Sqrt (double number=0) // конструктор, который при создании экземпляра класса Sqrt  присвоит полю number нужное нам число
        {
            this.number = number;
            positive = true;
        }

        public double GetDoubleSqrt() // метод, вычисляет обычный корень
        {
            double result =  Math.Sqrt(number);
            return Math.Round(result, (int)iter);
        }

        public double AnalitFunc(double n, double a) // метод который нужен в методе GetAnalitSqrt
        {
            return (double)(1 / 2) * (n + (double)(a / n));
        }

        public double GetAnalitSqrt() // возвращает значение анал корня
        {
            double n = 1;
            double result = 0;

                for (int i = 0; i <= iter; i++)
                {
                    result = AnalitFunc(n, number);
                    n = result;
                }

            return result;

        }
    }
}

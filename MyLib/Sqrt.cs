using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MyLib
{
    public class Sqrt
    {
        public double doubleSqrt { get; set; } // поле с результатом после обычного вычисления корня

        public double analSqrt { get; set; } // поле с результатом после аналитического вычисления

        public double number { get; set; } // поле с числом, их которого будем брать корень

        public double iter { get; set; } // точность

        public Sqrt (double number=0) // конструктор, который при создании экземпляра класса Sqrt  присвоит полю number нужное нам число
        {
            this.number = number;
        }

        public double GetDoubleSqrt() // метод, вычисляет обычный корень
        {
            double result =  Math.Sqrt(number);
            return Math.Round(result, (int)iter);
        }

        public double AnalFunc(double n, double a) // метод который нужен в методе GetAnalSqrt
        {
            return (double)(1 / 2) * (n + (double)(a / n));
        }

        public double GetAnalSqrt() // возвращает значение анал корня
        {
            double n = 1;
            double result = 0;

                for (int i = 0; i <= iter; i++)
                {
                    result = AnalFunc(n, number);
                    n = result;
                }



            return result;

        }
    }
}

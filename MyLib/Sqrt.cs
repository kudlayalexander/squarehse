using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MyLib
{
    public class Sqrt
    {
        // comment
        public bool positive { get; set; }
        public double doubleSqrt { get; set; } // поле с результатом после обычного вычисления корня
        public double number { get; set; } // поле с числом, их которого будем брать корень
        public double iter { get; set; } // точность
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



    }
}

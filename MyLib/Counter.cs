using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLib
{
    public class Counter
    {
        public double count { get; set; }
        public double number { get; set; }

        public Counter (double count=0, double number=0)
        {
            this.count = count;
            this.number = number;
        }
    }
}

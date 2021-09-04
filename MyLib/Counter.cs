using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLib
{
    public class Counter
    {
        public string count { get; set; }

        public Counter (string count = "0")
        {
            this.count = count;
        }
    }
}

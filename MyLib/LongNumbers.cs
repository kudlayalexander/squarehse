using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;


namespace MyLib
{
    public class LongNumbers
    {
        public string strNumber { get; set; }
        public BigInteger bigNumber { get; set; }
        public string sqrt { get; set; }

        public LongNumbers(string strNumber="0")
        {
            this.strNumber = strNumber;
            SetSqrt();
        }

        public void SetSqrt()
        {
            bigNumber = BigInteger.Parse(strNumber);
            sqrt = $"{Math.Pow(Math.E, BigInteger.Log(bigNumber) / 2)}";
        }

    }
}

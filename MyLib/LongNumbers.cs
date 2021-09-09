using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace MyLib
{
    public static class LongNumbers
    {
        public static string Sqrt(string strNumber)
        {
            BigInteger a = BigInteger.Parse(strNumber);
            BigInteger b1 = 1; BigInteger b2 = 0; BigInteger b3 = 0;
            if (a == 0)
            {
                return "0";
            }

            if (a == 3)
            {
                return "1";
            }

            else
            {
                while ((b3 - b1 > (BigInteger)0.000001) || (b3 - b1 < -(BigInteger)0.000001))
                {
                    b2 = (BigInteger)((b1 + a / b1) / 2);
                    b3 = b1;
                    b1 = b2;
                }
                return $"{b1}";
            }
        }
    }
}

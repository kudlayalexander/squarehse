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

        public static string SqrtN(string strNumber) // извлечение корня методом Ньютона
        {
            BigInteger N = BigInteger.Parse(strNumber);
            BigInteger rootN = N;
            int bitLength = 1; // There is a bug in finding bit length hence we start with 1 not 0
            while (rootN / 2 != 0)
            {
                rootN /= 2;
                bitLength++;
            }
            bitLength = (bitLength + 1) / 2;
            rootN = N >> bitLength;

            BigInteger lastRoot = BigInteger.Zero;
            do
            {
                lastRoot = rootN;
                rootN = (BigInteger.Divide(N, rootN) + rootN) >> 1;
            }
            while (!((rootN ^ lastRoot).ToString() == "0"));
            return $"{rootN}";
        } // SqRtN

    }
}

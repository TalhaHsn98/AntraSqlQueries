using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysAndStrings
{
    public static class PrimeNumbers
    {
        public static int[] Prime(int startnum, int endNum)
        {
            List<int> primes = new List<int>();
            for (int i = startnum; i <= endNum; i++)
            {
                bool isPrime = true;
                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (i > 1 && isPrime)
                    primes.Add(i);
            }
            return primes.ToArray();

        }
    }
}

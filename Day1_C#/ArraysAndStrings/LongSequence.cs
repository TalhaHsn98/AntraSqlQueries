using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysAndStrings
{
    public static class LongSequence
    {
        public static void FindLongestSequence()
        {
            int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int bestLen = 1, bestNum = arr[0], currLen = 1;

            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] == arr[i - 1])
                    currLen++;
                else
                    currLen = 1;

                if (currLen > bestLen)
                {
                    bestLen = currLen;
                    bestNum = arr[i];
                }
            }

            for (int i = 0; i < bestLen; i++)
                Console.Write(bestNum + " ");
        }
    }
}

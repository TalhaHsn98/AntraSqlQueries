using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysAndStrings
{
    public static class MostFrequent
    {

        public static void FindMostFrequent()
        {
            int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

            Dictionary<int, int> freq = new Dictionary<int, int>();
            int maxFreq = 0;
            int result = arr[0];

            foreach (int num in arr)
            {
                if (!freq.ContainsKey(num)) {
                    freq[num] = 0;
                }
                freq[num]++;
            }

            foreach (int num in arr)
            {
                if (freq[num] > maxFreq)
                {
                    maxFreq = freq[num];
                    result = num;
                }
            }

            Console.WriteLine($"The number {result} is the most frequent (occurs {maxFreq} times)");
        }
    }
}

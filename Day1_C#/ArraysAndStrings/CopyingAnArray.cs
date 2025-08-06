using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysAndStrings
{
    public class CopyingAnArray
    {
        public void ArrayCopy()
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };

            int[] newArray = new int[numbers.Length];

            for (int i = 0; i < numbers.Length; i++) 
            {
                newArray[i] = numbers[i];
            }

            Console.WriteLine(string.Join(", ",newArray));
            Console.WriteLine(string.Join(", ", numbers));

        }
    }
}

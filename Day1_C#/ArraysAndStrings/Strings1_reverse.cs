using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysAndStrings
{
    public static class Strings1_reverse
    {
        public static void ReverseUsingArray()
        {

            Console.WriteLine("write the string to be reversed");
            string input = Console.ReadLine();
            char[] arr = input.ToCharArray();
            Array.Reverse(arr);
            Console.WriteLine(new string(arr));
        }

        public static void ReverseUsingLoop()
        {
            Console.WriteLine("write the string to be reversed");
            string input = Console.ReadLine();
            for (int i = input.Length - 1; i >= 0; i--)
            {
                Console.Write(input[i]);

            }
            Console.WriteLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2_C__Homework
{
    public static class Working_With_Methods
    {

        public static int[] GenerateNumbers(int len)
        {
            int[] myarray = new int[len];
            for (int i = 0; i < len; i++)
            {
                myarray[i] = i+1;
            }

            return myarray;
        }

        public static void reverse(int[] arr)
        {
            int len = arr.Length;
            int[] temp = new int[len];

            for (int i = 0; i < len; i++) 
            {
                temp[temp.Length -1 - i] = arr[i];
            }

            for(int i = 0; i < len; i++)
            {
                arr[i] = temp[i];
            }

        }

        public static void PrintNumbers(int[] arr)
        {
            foreach(int ar in arr)
            {
                Console.WriteLine(ar);
            }
        }


    }
}

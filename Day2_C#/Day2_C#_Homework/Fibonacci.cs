using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2_C__Homework
{
    public class Fibonacci
    {
        public static int fibonacci(int num)
        {
           
            if (num == 1 || num == 2)
            { 
                return 1;
            }
            
            int result = fibonacci(num - 1) + fibonacci(num-2);
           
            return result;
         

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise03
{
    public class FizzBuzz
    {
        public void Fizzbuzz(int number)
        {

            for (int i = 1; i < number; i++) 
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("fizzbuzz");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("fizz");
                }

                else if (i % 5 == 0)
                {
                    Console.WriteLine("buzz");
                }

                else {
                    Console.WriteLine(i);
                }
            }

        }
    }
}

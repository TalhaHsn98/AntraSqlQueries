using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise03
{
    public class Print_a_Pyramid
    {

        public void Print_Pyramid(int floors) 
        {
            for (int i = 1; i <= floors; i++) 
            {
                Console.WriteLine();

                for (int j = 1; j <= floors-i; j++)
                {
                    Console.Write(" ");
                }

                for(int k = 1; k <= (2 * i) - 1; k++) 
                {
                    Console.Write("*");
                }
            }
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise03
{
    public class CountUpTo24
    {
        public void count() 
        {
            int number = 24;
            for (int i = 1; i <= 4; i++)
            {
                Console.WriteLine();
                for(int j = 0; j <= number; j = j + i) {
                    Console.Write(j);

                    if (j < 24)
                    {
                        Console.Write(",");
                    }
                }
            }

        }
    }
}

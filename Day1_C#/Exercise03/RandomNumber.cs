using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise03
{
    public class RandomNumber
    {

        public void Random() 
        {
            int correctNumber = new Random().Next(3) + 1;
            Console.WriteLine("YOU ONLY HAVE 3 Chances");

            for (int i = 1; i <= 3; i++) {

                Console.WriteLine("Guess the Number:");
                int guessedNumber = int.Parse(Console.ReadLine());

                if (guessedNumber > 3 || guessedNumber < 1)
                {
                    Console.WriteLine("Outside the Range of numbers");
                    continue;
                }
                else if (correctNumber == guessedNumber)
                {
                    Console.WriteLine("YOU HAVE GOT IT RIGHT");
                    break;
                }
                else if (guessedNumber > correctNumber)
                {
                    Console.WriteLine("You have guessed HIGH");
                    continue;
                }
                else if (guessedNumber < correctNumber)
                {
                    Console.WriteLine("You have guessed Low");
                    continue;
                }


            }
            

        }
    }
}

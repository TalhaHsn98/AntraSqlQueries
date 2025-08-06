using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise03
{
    public class Greeting_Time_Of_Day
    {
        public void Greeting()
        {
            DateTime currentTime = DateTime.Now;

            int currentHour = currentTime.Hour;

            if(currentHour>5 && currentHour < 12)
            {
                Console.WriteLine("Good Morning");

            }

            else if(currentHour>12 &&  currentHour < 17){
                Console.WriteLine("Good Afternoon");
            }

            else if(currentHour>17 &&  currentHour < 20)
            {
                Console.WriteLine("Good Evening");

            }
            else
            {
                Console.WriteLine("Good Night");
            }
        }
    }
}

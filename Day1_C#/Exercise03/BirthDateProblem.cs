using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise03
{
    public class BirthDateProblem
    {
        public void BirthDate()
        {
            DateTime birthDate = new DateTime(1998, 12, 31);

            DateTime today = DateTime.Now;

            TimeSpan age = today - birthDate;

            int ageindays = age.Days;

            int DaysToNext27thAnniversary = 9862 - (ageindays % 9862);

            DateTime exactDate = DateTime.Now;
            Console.WriteLine($"Your age in days: {ageindays}, Your days to next anniversary: {DaysToNext27thAnniversary}");
            exactDate = exactDate.AddDays(DaysToNext27thAnniversary);
            Console.WriteLine($"Your next anniversary date{ exactDate}");
        }

    }
}

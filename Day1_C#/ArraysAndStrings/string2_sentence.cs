using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ArraysAndStrings
{
    public class string2_sentence
    {
        public static void ReverseWords()
        {
            string input = Console.ReadLine();

            var parts = Regex.Matches(input, @"[A-Za-z0-9#+]+|[^A-Za-z0-9#+]+");
            List<string> words = new List<string>();

            foreach (Match m in parts)
                if (Regex.IsMatch(m.Value, @"[A-Za-z0-9#+]+"))
                    words.Add(m.Value);

            words.Reverse();

            int w = 0;
            foreach (Match m in parts)
            {
                if (Regex.IsMatch(m.Value, @"[A-Za-z0-9#+]+"))
                    Console.Write(words[w++]);
                else
                    Console.Write(m.Value);
            }
            Console.WriteLine();
        }
    }
}

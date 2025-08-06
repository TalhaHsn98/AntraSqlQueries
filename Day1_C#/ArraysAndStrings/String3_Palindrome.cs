using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysAndStrings
{
    public class String3_Palindrome
    {
        public static void FindPalindromes()
        {
            string input = Console.ReadLine();
            char[] delimiters = { ' ', ',', '.', '?', '!', ':', ';' };
            string[] words = input.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);

            HashSet<string> unique = new HashSet<string>();

            foreach (var word in words)
            {
                string reversed = new string(word.Reverse().ToArray());
                if (word.Length > 0 && word == reversed)
                    unique.Add(word);
            }

            var result = unique.OrderBy(x => x).ToList();
            Console.WriteLine(string.Join(", ", result));
        }
    }
}

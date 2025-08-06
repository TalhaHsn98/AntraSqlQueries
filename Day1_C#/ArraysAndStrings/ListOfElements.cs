using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysAndStrings
{
    public class ListOfElements
    {

        public void listElements()
        {

            List<string> myList = new List<string>();

            for (; ; )
            {
                Console.WriteLine("Enter command (+ item, - item, or -- to clear):");
                string input = Console.ReadLine();

                input = input.Trim();

                if (input.StartsWith("+"))
                {
                    string itemToAdd = input.Substring(1).Trim();
                    if (!string.IsNullOrEmpty(itemToAdd))
                    {
                        myList.Add(itemToAdd);
                        Console.WriteLine($"Added the item {itemToAdd}");
                    }
                }
                else if (input.StartsWith("-") && input.Length > 1)
                {
                    string itemToRemove = input.Substring(1).Trim();
                    if (myList.Remove(itemToRemove))
                    {
                        Console.WriteLine($"removed: {itemToRemove}");
                    }
                    else
                    {
                        Console.WriteLine($" not found: {itemToRemove}");
                    }
                }
                else if (input == "--")
                {
                    myList.Clear();
                    Console.WriteLine("List cleared.");
                }

                Console.WriteLine("list: " + string.Join(", ", myList));
                Console.WriteLine();

            }

        }
    }
}

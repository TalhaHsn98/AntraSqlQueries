using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysAndStrings
{
    public static class String4_URL
    {
        public static void ParseUrl()
        {
            string input = Console.ReadLine();
            string protocol = "";
            string server = "";
            string resource = "";

            if (input.Contains("://"))
            {
                int index = input.IndexOf("://");
                protocol = input.Substring(0, index);
                input = input.Substring(index + 3);
            }

            if (input.Contains("/"))
            {
                int index = input.IndexOf("/");
                server = input.Substring(0, index);
                resource = input.Substring(index + 1);
            }
            else
            {
                server = input;
            }

            if (protocol != "") Console.WriteLine("[protocol] = \"" + protocol + "\"");
            Console.WriteLine("[server] = \"" + server + "\"");
            if (resource != "") Console.WriteLine("[resource] = \"" + resource + "\"");
        }
    }
}

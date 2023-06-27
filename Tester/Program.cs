using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using UnicodeTransliteration;

namespace Tester
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;

            var input = "íóßÆ";

            var output = SQLFunctions.Transliterate(input);

            Console.WriteLine($" Input: {input}");
            Console.WriteLine($"Output: {output}");

            Console.WriteLine("Press any key to contine...");

            Console.ReadKey();
        }
    }
}

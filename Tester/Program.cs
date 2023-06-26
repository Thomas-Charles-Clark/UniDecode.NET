using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using UniDecode.NET;

namespace Tester
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;

            var input = "";

            var output = SQLFunctions.Transliterate(input);

            Console.WriteLine($" Input: {input}");
            Console.WriteLine($"Output: {output}");

            Console.WriteLine("Press any key to contine...");
        }
    }
}

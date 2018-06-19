using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escape_Sequences
{
    class Program
    {
        static void Main(string[] args)
        {

            string hello = "hello";
            string world = "World";
            String symbol = "!";


            Console.Write(hello + "\t" + world + symbol + "\n");
            Console.WriteLine();

            Console.Write(hello + "\n" + world + symbol + "\n");
            Console.WriteLine();

            Console.Write("\"" + hello + world + symbol + "\"" + "\n");
            Console.WriteLine();

            Console.Write(hello + "\\" + world + symbol + "\n");
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}

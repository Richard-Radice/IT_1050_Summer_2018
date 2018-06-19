using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math_Product
{
    class Program
    {
        static void Main(string[] args)
        {

            int x = 5;
            int y = 6;
            int z = 7;
            string equation = "(x+y)*(z+10)" + new string(' ', 21);
            string w = " " + new string(' ', 30);
            while (true)
            {
                Console.Write("Press enter to start the solution\n");

                if (Console.ReadKey().Key == ConsoleKey.Enter)
                {

                    Console.Write(equation + "\n");

                    Console.ReadKey();

                    Console.Write("({0}+{1}) * ({2}+10)\n", x, y, z);

                    Console.ReadKey();

                    Console.Write("({0})*({1})\n", x + y, z + 10);

                    Console.ReadKey();

                    Console.Write((x + y) * (z + 10) + "\n");

                    Console.ReadKey();

                    break;
                }

                else
                {
                    Console.WriteLine();
                    Console.Write("Invalid input\n");

                }

            }
        }
    }
} 

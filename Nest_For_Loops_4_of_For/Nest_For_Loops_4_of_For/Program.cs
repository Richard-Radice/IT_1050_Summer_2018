using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nest_For_Loops_4_of_For
{
    class Program
    {
        static void Main(string[] args)
        {

            int x, y, h, w;

            for (x = 0; x <= 10; x++)
            {

                for (y = 1; y <= 1 + x; y++)
                {

                    Console.Write("*");




                }



                Console.WriteLine();
            }


            for (w = 0; x + w > 10 && x + w <= 20; w++)
            {
                for (h = 1; h <= 10 - w; h++)

                {

                    Console.Write("*");

                }

                Console.WriteLine();

            }

        }
    }
}

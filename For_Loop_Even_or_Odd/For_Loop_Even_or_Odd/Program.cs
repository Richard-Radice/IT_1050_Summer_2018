using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace For_Loop_Even_or_Odd
{
    class Program
    {
        static void Main(string[] args)
        {
            string w = " " + new string (' ', 0);


            for (decimal i = 0m; i <= 10; i++)
            {

                Console.Write(i + w);

                if ((i % 2) == 0)
                {

                    Console.Write("is even\n");

                }


                if ((i % 2) != 0)
                {

                    Console.Write("is odd\n");

                }

            }


        }
    }
}

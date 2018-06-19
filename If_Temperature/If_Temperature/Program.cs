using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace If_Temperature
{
    class Program
    {
        static void Main(string[] args)
        {

            decimal x;

            while (true)
            {
                Console.Write("Enter the Temperature:");
                x = Convert.ToDecimal(Console.ReadLine());

                if (x < 32)
                {

                    Console.WriteLine("It is frezzing out !");

                }

                else if (x < 50)
                {

                    Console.WriteLine("It is cold out!");

                }

                else if (x < 70)
                {

                    Console.WriteLine("It is mild out!");

                }

                else if (x < 90)
                {

                    Console.WriteLine("It is warm out!");


                }

                else
                {

                    Console.WriteLine("It is hot out!");

                }




                    Console.Write("Click to enter a new temperature.\n");
                    Console.ReadKey();

                

            }
        }
    }
}

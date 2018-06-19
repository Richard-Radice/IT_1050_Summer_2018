using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Addition_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {

            decimal x;
            decimal y;
            String w;
            char literal;
           

            Console.WriteLine("Press enter to start Addition Caclulator");
            Console.WriteLine();

            if (Console.ReadKey().Key == ConsoleKey.Enter)
            {
                for (int i = 0; i < 5000; i++)
                {

                    Console.Write("Enter the first value for addition: ");
                    x = Convert.ToDecimal(Console.ReadLine());

                    Console.Write("Enter the second value for addition: ");
                    y = Convert.ToDecimal(Console.ReadLine());

                    decimal sum = y + x;

                    Console.Write("\r");
                    Console.WriteLine("sum eqauls: " + sum);
                    Console.WriteLine();

                    if (i > 5)
                    {

                        Console.WriteLine("Would you like to continue?: y/n");
                        w = Console.ReadLine().ToLower();
                        Console.WriteLine();
                        literal = Convert.ToChar(w);


                        if (literal == 'n')
                        {

                            break;

                        }

                        if (literal == 'y')
                        {

                            i = 0;

                        }

                

                    }

                }
            }



            else
            {
                Console.WriteLine("\n");
                Console.WriteLine("Invalid Input\n");

            }
          
            Console.WriteLine("Thanks for using my addition calculator!\n");
            
        }
    }
}

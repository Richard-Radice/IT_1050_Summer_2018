using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Name_And_Greeting
{
    class Program
    {
        static void Main(string[] args)
        {

            string name;
            string greeting;
            string symbol;
            
            name = "Ronald";
            greeting = "Good Evening, ";
            symbol = "!";
            
            Console.Write(greeting + name + symbol + "\n" );

            Console.ReadKey();

        }
    }
}

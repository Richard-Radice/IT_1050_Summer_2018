using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_Math
{
    class Program
    {
        static void Main(string[] args)
        {

            MyMath math = new MyMath();
            Console.WriteLine(math.Add(9, 19));
            Console.WriteLine(math.Factorial(9));
            Console.WriteLine(math.Min(20, 20));
            Console.WriteLine(math.Multiply(19, 2));

        }
    }
}

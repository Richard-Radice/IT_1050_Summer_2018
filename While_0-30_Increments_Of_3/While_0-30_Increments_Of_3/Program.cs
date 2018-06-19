using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace While_0_30_Increments_Of_3
{
    class Program
    {
        static void Main(string[] args)
        {

            decimal x;
            x = 0m;

            while (x <= 30)
            {

                Console.WriteLine(x);
                x = x + 3;

            }

        }
    }
}

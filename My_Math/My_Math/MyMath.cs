using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_Math
{
    class MyMath
    {
        public int Add(int a, int b)
        {
            return a + b;
        }

        public int Factorial(int n)
        {
            int answer = 1;
            for (int i = 2; i <= n; i++)
                answer *= i;
            return answer;
        }

        public int Multiply(int a, int b)
        {
            return a * b;
        }

        public int Min(int a, int b) 
        {
            if (a < b)
            {
                return a;
            }


            else
            {
                return b;
            }
        }



    }
}

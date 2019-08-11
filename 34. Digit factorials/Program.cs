using Extras;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace _34.Digit_factorials
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            for (int i = 0; i < 40586; i++)
            {
                if (DigitFactorialSum(i) == i)
                {
                    sum += i;
                    Console.WriteLine(i);
                }
            }
            Console.WriteLine("\n" + sum);
            Console.Read();
        }

        static int DigitFactorialSum(int n)
        {
            int sum = 0;
            while (n > 0)
            {
                sum += (int)ExtraNumbers.Factorial(n % 10);
                n /= 10;
            }
            return sum;
        }
    }
}

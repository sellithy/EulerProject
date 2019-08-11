using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Largest_prime_factor
{
    class Program
    {
        static void Main(string[] args)
        {
            long number = 600851475142;
            for (int i = 2; i < number; i++)
            {
                if (number % i == 0)
                    number /= i;
            }
            Console.WriteLine(number);
            Console.Read();
        }
    }
}

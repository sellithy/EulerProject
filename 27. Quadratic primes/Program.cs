using Extras;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27.Quadratic_primes
{
    class Program
    {
        static void Main(string[] args)
        {
            int longest = 0;
            int product = 1;
            for (int i = -1000; i <= 1000; i++)
            {
                for (int j = -1000; j <= 1000; j++)
                {
                    int temp = LengthPrimes(i, j);
                    if (temp > longest)
                    {
                        longest = temp;
                        product = i * j;
                    }
                }
            }
            Console.WriteLine(product);
            Console.Read();
        }

        private static int LengthPrimes(int i, int j)
        {
            int counter = 0;
            while (ExtraNumbers.IsPrime(counter * counter + i * counter + j))
                counter++;

            return counter;
        }
    }
}
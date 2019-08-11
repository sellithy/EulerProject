using Extras;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _47.Distinct_primes_factors
{
    class Program
    {
        static bool[] primes = ExtraNumbers.Sieve(1000);
        static void Main(string[] args)
        {
            int i = 2;
            while (true)
            {
                if (ConsecutiveFactors(i, 4))
                {
                    Console.WriteLine($"{i} & {i + 1} & {i + 2} & {i + 3}");
                }
                i++;
            }
        }

        private static bool ConsecutiveFactors(int start, int noFactors)
        {
            for (int i = 0; i < noFactors; i++)
            {
                if (ExtraNumbers.PrimeFactors(start + i).Distinct().Count() != noFactors)
                    return false;
            }

            return true;
        }
    }
}
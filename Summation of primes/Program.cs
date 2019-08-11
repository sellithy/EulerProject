using Extras;
using System;
using System.Numerics;

namespace Summation_of_primes
{
    class Program
    {
        static void Main(string[] args)
        {
            int max = 2000000;
            bool[] primes = ExtraNumbers.Sieve(max);
            BigInteger sum = 0;
            for (int i = 0; i < primes.Length; i++)
            {
                if (!primes[i])
                    sum += i + 2;
            }
            Console.WriteLine(sum);
            Console.Read();
        }
    }
}

using Extras;
using System;
using System.Numerics;

namespace _35.Circular_primes
{
    class Program
    {
        static int max = 1000000;
        static bool[] primes = ExtraNumbers.Sieve(max);
        static void Main(string[] args)
        {
            int count = 0;
            for (int i = 2; i < max; i++)
                if (IsCircularPrime(i))
                    count++;
            Console.WriteLine(count);
            Console.ReadLine();
        }

        private static bool IsCircularPrime(int n)
        {
            string number = n.ToString();
            for (int i = 0; i < number.Length; i++)
            {
                if (primes[int.Parse(number) - 2])
                    return false;
                number = number[number.Length - 1] + number.Substring(0, number.Length - 1);
            }

            return true;
        }
    }
}
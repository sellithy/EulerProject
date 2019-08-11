using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace Extras
{
    public class ExtraNumbers
    {
        static bool[] primes = Sieve(1000);

        /// <summary>
        /// dont. please. this is a wrong implementation
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public static List<int> PrimeFactors(int number)
        {
            List<int> factors = new List<int>();

            for (int i = 0; i < primes.Length && i < number; i++)
            {
                if (!primes[i])
                    while (number % (i + 2) == 0)
                    {
                        factors.Add(i + 2);
                        number /= i + 2;
                    }
            }

            if(factors.Count == 0)
                factors.Add(number);

            return factors;
        }

        /// <summary>
        /// Sieves from 2 to max. Index 0 is two and false represents prime
        /// </summary>
        /// <param name="max">Number to sieve to. Included in array</param>
        /// <returns></returns>
        public static bool[] Sieve(int max)
        {
            bool[] numbers = new bool[max - 1]; //index 0 represents 2. false is prime
            for (int i = 0; i < numbers.Length; i++)
            {
                if (!numbers[i])
                {
                    for (int j = 2*i+2; j < numbers.Length; j += i+2)
                    {
                        numbers[j] = true;
                    }
                }
            }
            return numbers;
        }

        /// <summary>
        /// Finds the prime at the given position.
        /// </summary>
        /// <param name="cardinal">The position of the prime needed</param>
        /// <returns></returns>
        public static int PrimeAt(int cardinal)
        {
            List<int> primes = new List<int>() {2};

            int current = 2;
            while (primes.Count < cardinal)
            {
                bool isPrime = true;
                for (int i = 0; i < primes.Count; i++)
                    if (current % primes[i] == 0)
                    {
                        isPrime = false;
                        break;
                    }

                if (isPrime)
                    primes.Add(current);

                current++;
            }

            return primes.Last();
        }

        /// <summary>
        /// Finds the factors of a given number.
        /// 1 and the number itself are included in the begging
        /// and the end of the array respectivley.
        /// </summary>
        /// <param name="number">Number to find factors of</param>
        /// <returns></returns>
        public static SortedSet<int> Factors(int number)
        {
            SortedSet<int> factors = new SortedSet<int>();

            for (int i = 1; i <= Math.Ceiling(Math.Sqrt(number)); i++)
                if (number % i == 0)
                {
                    factors.Add(i);
                    factors.Add(number / i);
                }

            return factors;
        }

        public static bool IsPrime(int number)
        {
            if (number == 0 || number % 2 ==0) return false;
            for (int i = 3; i <= Math.Ceiling(Math.Sqrt(number)); i+=2)
                if (number % i == 0)
                    return false;

            return true;
        }

        /// <summary>
        /// Returns the product of all the numbers below and including max
        /// </summary>
        /// <param name="max">Number to find factorial of</param>
        /// <returns></returns>
        public static BigInteger Factorial(int n)
        {
            if (n == 1 || n == 0)
                return 1;
            if (n == 2) return 2;
            else return n * Factorial(n - 1);
        }

        public static int SumOfDigits(BigInteger number)
        {
            int sum = 0;
            foreach (char c in number.ToString())
                sum += int.Parse(c + "");
            return sum;
        }

        /// <summary>
        /// Gets the GCD of tw numbers
        /// pulled from stackoverflow
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static int GCD(int a, int b)
        {
            while (a != 0 && b != 0)
            {
                if (a > b)
                    a %= b;
                else
                    b %= a;
            }

            return a == 0 ? b : a;
        }

        public static List<string> AllPermutations(string letters)
        {
            if (letters.Length == 2)
                return new List<string> { letters, "" + letters[1] + letters[0] };

            List<string> all = new List<string>();

            for (int i = 0; i < letters.Length; i++)
            {
                char current = letters[i];
                List<string> sub = AllPermutations(letters.Remove(i, 1));

                for (int j = 0; j < sub.Count; j++)
                    sub[j] = current + sub[j];

                all.AddRange(sub);
            }

            return all;
        }
    }
}
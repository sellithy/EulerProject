using Extras;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _37.Truncatable_primes
{
    class Program
    {
        static readonly int Max = 1000000;
        static readonly bool[] Primes = ExtraNumbers.Sieve(Max);
        static void Main(string[] args)
        {
            int i = 20;
            int counter = 0;
            int sum = 0;
            while (counter < 11 && i < Max)
            {
                if (!Primes[i-2] && TruncatableLeftAndRight(i))
                {
                    counter++;
                    sum += i;
                }
                i++;
            }
            Console.WriteLine(counter == 11 ? $"sum = {sum}" : "Max not big enough");
            Console.ReadLine();
        }

        private static bool TruncatableLeftAndRight(int number)
        {
            string n = number.ToString();
            if (n[0] == '1' || n[n.Length - 1] == '1')
                return false;

            for (int i = 1; i < n.Length; i++)
            {
                int left = int.Parse(n.Substring(i));
                int right = int.Parse(n.Substring(0, n.Length - i));
                if (Primes[left - 2] || Primes[right - 2])
                    return false;
            }

            return true;
        }
    }
}
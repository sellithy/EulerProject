using Extras;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _46.Goldbach_s_other_conjecture
{
    class Program
    {
        static bool[] primes = ExtraNumbers.Sieve(1000000);
        static void Main(string[] args)
        {
            int i = 9;
            while (!(primes[i - 2] && !FollowsRule(i)))
                i += 2;

            Console.WriteLine(i);
            Console.Read();
        }

        private static bool FollowsRule(int i)
        {
            int j = 1;
            while (i > 2 * j * j)
            {
                if (!primes[(i - 2 * j * j) - 2])
                    return true;
                j++;
            }
            return false;
        }
    }
}
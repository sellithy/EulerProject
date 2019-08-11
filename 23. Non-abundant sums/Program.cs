using Extras;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace _23.Non_abundant_sums
{
    class Program
    {
        static void Main(string[] args)
        {
            int max = 28123;
            BigInteger sum = (max*(max+1))/2;
            List<int> abundants = new List<int>();
            SortedSet<int> abundantsSum = new SortedSet<int>();

            for (int i = 1; i < max; i++)
            {
                if (IsAbundant(i))
                    abundants.Add(i);
                else
                    for (int j = 0; j < abundants.Count; j++)
                        if (abundants.Contains(i - abundants[j]))
                        {
                            abundantsSum.Add(i);
                            break;
                        }
            }

            sum -= abundantsSum.Sum();

            Console.WriteLine(sum);
            Console.Read();
        }

        static bool IsAbundant(int number)
        {
            SortedSet<int> factors =  ExtraNumbers.Factors(number);

            int sum = 0;
            for (int i = 0; i < factors.Count - 1; i++)
                sum += factors.ElementAt(i);

            return sum > number;
        }
    }
}
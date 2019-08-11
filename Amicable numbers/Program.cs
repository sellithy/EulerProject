using Extras;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amicable_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int max = 10000;
            int[] factorsSum = new int[max-1];
            for (int i = 0; i < factorsSum.Length; i++)
            {
                SortedSet<int> tempFactors = ExtraNumbers.Factors(i + 2);
                for (int j = 0; j < tempFactors.Count - 1; j++)
                    factorsSum[i] += tempFactors.ElementAt(j);
            }

            int amicablesum = 0;
            for (int i = 0; i < factorsSum.Length; i++)
            {
                if(1 < factorsSum[i] && factorsSum[i] < max-2)
                    if (i+2 == factorsSum[factorsSum[i] - 2]  && factorsSum[i] != i+2)
                        amicablesum += i+2;
            }

            Console.WriteLine(amicablesum);
            Console.ReadLine();
        }
    }
}

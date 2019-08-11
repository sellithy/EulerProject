using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _31.Coin_sums
{
    class Program
    {
        static readonly int[] CoinValues = {1, 2, 5, 10, 20, 50, 100, 200};

        static void Main(string[] args)
        {
            Console.WriteLine(Combinations(200));
            Console.Read();
        }

        static int Combinations(int pences, int index)
        {
            if (pences < 0)
                return 0;

            if (pences == 0)
                return 1;

            int sum = 0;
            for (int i = index; i < CoinValues.Length; i++)
                sum += Combinations(pences - CoinValues[i], i);

            return sum;
        }

        static int Combinations(int pences)
        {
            return Combinations(pences, 0);
        }
    }
}
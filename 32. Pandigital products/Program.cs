using Extras;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _32.Pandigital_products
{
    class Program
    {
        static void Main(string[] args)
        {
            int max = int.MaxValue;
            SortedSet<int> pandigitals = new SortedSet<int>();
            for (int i = 0; i < 10000; i++)
            {
                if (IsPandigitalProducts(i))
                    pandigitals.Add(i);
            }
            Console.WriteLine(pandigitals.Sum());
            Console.Read();
        }

        private static bool IsPandigitalProducts(int n)
        {
            SortedSet<int> factors = ExtraNumbers.Factors(n);

            for (int i = 0; i < factors.Count/2; i++)
            {
                int product1 = factors.ElementAt(i);
                int product2 = factors.ElementAt(factors.Count - 1 - i);
                if (IsAllPandigital(n, product1, product2))
                    return true;
            }

            return false;
        }

        private static bool IsAllPandigital(int a, int b, int c)
        {
            string all = "" + a + b + c;
            all = String.Concat(all.OrderBy(d => d));
            return all.Equals("123456789");
        }
    }
}
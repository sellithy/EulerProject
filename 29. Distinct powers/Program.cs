using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _29.Distinct_powers
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedSet<double> powers = new SortedSet<double>();
            for (int i = 2; i <= 100; i++)
            {
                for (int j = 2; j <= 100; j++)
                {
                    powers.Add(Math.Pow(i, j));
                }
            }
            Console.WriteLine(powers.Count);
            Console.ReadLine();
        }
    }
}
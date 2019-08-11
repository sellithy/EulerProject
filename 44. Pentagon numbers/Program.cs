using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _44.Pentagon_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int n = 1; n <= 1000; n++)
                for (int k = 1; k <= 1000; k++)
                {
                    int j = n * (3 * n - 1) / 2;
                    int p = (n+k) * (3 * (n+k) - 1) / 2;
                     if (IsPentagonal(j + p) && IsPentagonal(p - j))
                        Console.WriteLine($"P{n} & P{n+k} work");
                }
            Console.WriteLine("done");
            Console.ReadLine();
        }

        static bool IsPentagonal(int number)
        {
            int n = 1;
            int pentagonal = n*(3*n - 1) / 2;
            while (pentagonal <= number)
            {
                if (number == pentagonal)
                    return true;
                pentagonal = ++n * (3 * n - 1) / 2;
            }

            return false;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _45.Triangular__pentagonal__and_hexagonal
{
    class Program
    {
        static void Main(string[] args)
        {
            long i = 143;
            bool found = false;
            while (!found)
                if (IsPentagonal(Hexagonal(++i)))
                    break;
            Console.WriteLine(Hexagonal(i));
            Console.Read();
        }

        static bool IsPentagonal(long n)
        {
            return ((1 + Math.Sqrt(1 + 24 * n)) / 6) % 1 == 0;
        }

        static long Hexagonal(long n) => n * (2 * n - 1);

    }
}
using System;
using Extras;

namespace Highly_divisible_triangular_number
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfFactors = 500;

            int foundFactors = 1;
            int counter = 1;
            int triangle = 1;
            while (foundFactors <= numberOfFactors)
            {
                triangle = TriangleAt(counter);
                foundFactors = ExtraNumbers.Factors(triangle).Count;
                counter++;
            }
            Console.WriteLine(triangle);
            Console.Read();
        }

        static int TriangleAt(int cardinal)
        {
            return (cardinal * (cardinal + 1)) / 2;
        }
    }
}

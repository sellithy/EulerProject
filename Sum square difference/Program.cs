using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum_square_difference
{
    class Program
    {
        static void Main(string[] args)
        {
            int max = 100;
            int squaresSum = 1;
            for (int i = 2; i <= max; i++)
                squaresSum += i * i;

            int sumSquared = (max * (max + 1)) / 2;
            sumSquared *= sumSquared;

            Console.WriteLine(sumSquared-squaresSum);
            Console.Read();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Special_Pythagorean_triplet
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i < 1000; i++)
            {
                for (int j = 0; j < 1000; j++)
                {
                    if (500000 == 1000 * (i + j) - i * j)
                        Console.WriteLine(i * j * (1000 - i - j));
                }
            }
            Console.Read();
        }
    }
}
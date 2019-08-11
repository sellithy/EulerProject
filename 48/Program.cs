using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _48.Self_powers
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger sum = 0;
            for (int i = 1; i <= 1000; i++)
            {
                sum += BigInteger.Pow(i, i);
            }
            Console.WriteLine(sum);
            Console.ReadLine();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace _25._1000_digit_Fibonacci_number
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger previous = 1;
            BigInteger current = 1;
            int index = 2;
            while (current.ToString().Length < 1000)
            {
                BigInteger temp = current;
                current += previous;
                previous = temp;
                index++;
            }
            Console.Write(index);
            Console.ReadLine();
        }
    }
}

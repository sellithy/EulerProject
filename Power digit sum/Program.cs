using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Power_digit_sum
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger power = new BigInteger(Math.Pow(2, 1000));
            string number = power.ToString();

            BigInteger sum = 0;
            foreach (char c in number)
                sum += int.Parse(c + "");

            Console.WriteLine(sum);
            Console.ReadLine();
        }
    }
}

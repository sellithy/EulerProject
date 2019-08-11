using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30.Digit_fifth_powers
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            for (int i = 2; i <= 194979; i++)
            {
                if (i == SumFifthPower(i))
                    sum += SumFifthPower(i);
            }
            Console.WriteLine(sum);
            Console.Read();
        }

        static int SumFifthPower(int n)
        {
            string number = n.ToString();
            int sum = 0;
            foreach (char c in number)
                sum += (int) Math.Pow(int.Parse(c + ""), 5); ;

            return sum;
        }
    }
}
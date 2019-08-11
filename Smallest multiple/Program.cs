using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smallest_multiple
{
    class Program
    {
        static void Main(string[] args)
        {
            int max = 20;
            int lcm = 2;
            for (int i = 2; i < max; i++)
                lcm = lcm * i / GCD(lcm, i);
            Console.WriteLine(lcm);
            Console.ReadLine();
        }

        static int LCM (int a, int b)
        {
            return (a * b )/ GCD(a,b);
        }

        static int GCD(int a, int b)
        {
            int tempA = a;
            int tempB = b;
            while (tempB != 0)
            {
                int temp = tempB;
                tempB = tempA % tempB;
                tempA = temp;
            }
            return tempA;
        }
    }
}
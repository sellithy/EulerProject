using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _36.Double_base_palindromes
{
    class Program
    {
        static void Main(string[] args)
        {
            int max = 1000000;
            int sum = 0;
            for (int i = 0; i < max; i++)
                if (IsPalindrom(i.ToString()) && IsPalindrom(Convert.ToString(i, 2)))
                    sum += i;
            Console.WriteLine(sum);
            Console.ReadLine();
        }

        public static bool IsPalindrom(string number)
        {
            for (int i = 0; i < number.Length / 2; i++)
            {
                if (number[i] != number[number.Length - 1 - i])
                    return false;
            }
            return true;
        }
    }
}
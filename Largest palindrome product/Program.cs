using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Largest_palindrome_product
{
    class Program
    {
        static void Main(string[] args)
        {
            int largest = 0;
            for (int i = 999; i > 0; i--)
            {
                for (int j = 999; j > 0; j--)
                {
                    int product = i * j;
                    if (IsPalindrom(product) && product > largest)
                        largest = product;
                }
            }
            Console.WriteLine(largest);
            Console.Read();
        }

        static bool IsPalindrom(int number)
        {
            string numberString = number + "";
            for (int i = 0; i < numberString.Length / 2; i++)
            {
                if (numberString[i] != numberString[numberString.Length - 1 - i])
                    return false;
            }
            return true;
        }
    }
}

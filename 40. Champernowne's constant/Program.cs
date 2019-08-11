using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _40.Champernowne_s_constant
{
    class Program
    {
        static void Main(string[] args)
        {
            int product = 1;
            for (int i = 2; i < 7; i++)
                product *= NumberAtIndex((int)Math.Pow(10, i)) - (int)'0';

            Console.WriteLine(product);
            Console.Read();
        }

        static char NumberAtIndex(int index)
        {   
            int counter = 1;
            int sumDigits = 0;
            while (true)
            {
                int numberOfDigits = counter * 9 * (int)Math.Pow(10, counter-1);
                if (index - numberOfDigits < 0)
                    break;
                index -= numberOfDigits;
                sumDigits += numberOfDigits;
                counter++;
            }

            int number = index / counter + (int)Math.Pow(10, counter - 1);
            index -= (index / counter) * counter;

            if (index == 0)
            {
                number--;
                index = number.ToString().Length;
            }

            return number.ToString()[index-1];
        }
    }
}
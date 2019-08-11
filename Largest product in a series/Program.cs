using System;
using System.IO;
using System.Numerics;

namespace Largest_product_in_a_series
{
    class Program
    {
        const string fileName = "1000-digit_number.txt";

        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(fileName);
            string number = sr.ReadToEnd();
            BigInteger product = 0;

            int length = 12;
            for (int i = 0; i < number.Length - length + 1; i++)
            {
                string sub = number.Substring(i, length);

                BigInteger testProduct = 1;
                foreach (char c in sub)
                    testProduct *= int.Parse(c + "");

                if (testProduct > product)
                    product = testProduct;
            }
            Console.WriteLine(product);
            Console.Read();
        }
    }
}
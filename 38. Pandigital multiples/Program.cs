using System;

namespace _38.Pandigital_multiples
{
    class Program
    {
        static void Main(string[] args)
        {
            int biggest = 0;
            for (int i = 9999; i > 0; i--)
            {
                string number = "";
                int counter = 1;
                while(number.Length < 9)
                {
                    number += (i * counter).ToString();
                    counter++;
                }
                if (IsPandigital(number) && int.Parse(number) > biggest)
                {
                    biggest = int.Parse(number);
                }
            }
            Console.WriteLine(biggest);
            Console.ReadLine();
        }

        static bool IsPandigital(string str)
        {
            if (str.Length != 9)
                return false;

            for (int i = 1; i < 10; i++)
                if (!str.Contains(i + ""))
                    return false;

            return true;
        }
    }
}
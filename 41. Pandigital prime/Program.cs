using Extras;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _41.Pandigital_prime
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> permutations = ExtraNumbers.AllPermutations("7654321");
            foreach (string s in permutations)
                if (ExtraNumbers.IsPrime(int.Parse(s)))
                {
                    Console.WriteLine(s);
                    break;
                }
            Console.ReadLine();
        }
    }
}
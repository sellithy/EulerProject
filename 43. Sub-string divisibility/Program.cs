using Extras;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _43.Sub_string_divisibility
{
    class Program
    {
        static void Main(string[] args)
        {
            long sum = 0;
            List<string> permutations = ExtraNumbers.AllPermutations("0123456789");
            foreach (string s in permutations)
                if(Divisibilities(s))
                    sum += long.Parse(s);
            Console.WriteLine(sum);
            Console.ReadLine();
        }

        static bool Divisibilities(string s)
        {
            if (int.Parse("" + s[1] + s[2] + s[3]) % 2 != 0)
                return false;

            if (int.Parse("" + s[2] + s[3] + s[4]) % 3 != 0)
                return false;

            if (int.Parse("" + s[3] + s[4] + s[5]) % 5 != 0)
                return false;

            if (int.Parse("" + s[4] + s[5] + s[6]) % 7 != 0)
                return false;

            if (int.Parse("" + s[5] + s[6] + s[7]) % 11 != 0)
                return false;

            if (int.Parse("" + s[6] + s[7] + s[8]) % 13 != 0)
                return false;

            if (int.Parse("" + s[7] + s[8] + s[9]) % 17 != 0)
                return false;

            return true;
        }
    }
}
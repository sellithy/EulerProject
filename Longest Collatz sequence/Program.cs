using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Longest_Collatz_sequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int max = 1000000;
            int record = 1;
            int recordNumber = 1;
            for (int i = 2; i < max; i++) {
                int testedCollatz = Collatz(i);
                if (testedCollatz > record)
                {
                    record = testedCollatz;
                    recordNumber = i;
                }
            }
            Console.WriteLine(recordNumber);
            Console.Read();
        }

        static int Collatz(long start)
        {
            if (start == 1)
                return 1;
            else if (start % 2 == 0)
                return 1 + Collatz(start / 2);
            else
                return 1 + Collatz(3 * start + 1);
        }
    }
}

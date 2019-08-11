using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10001st_prime
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(PrimeAt(10001));
            Console.ReadLine();
        }

        static int PrimeAt(int cardinal)
        {
            int[] primes = new int[cardinal];
            primes[0] = 2;

            int current = 2;
            int index = 1;
            while (index < cardinal)
            {
                bool isPrime = true;
                for (int i = 0; i < index; i++)
                    if (current % primes[i] == 0)
                    {
                        isPrime = false;
                        break;
                    }

                if (isPrime)
                {
                    primes[index] = current;
                    index++;
                }
                current++;
            }

            return primes[primes.Length - 1];
        }
    }
}

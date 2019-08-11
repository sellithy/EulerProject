using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Even_Fibonacci_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int previousFibonacci = 1;
            int currentFibonacci = 1;
            int sum = 0;
            while(currentFibonacci < 4000000)
            {
                int temp = currentFibonacci;
                if (currentFibonacci % 2 == 0)
                    sum += currentFibonacci;
                currentFibonacci += previousFibonacci;
                previousFibonacci = temp;
            }
            Console.WriteLine(sum);
            Console.Read();
        }
    }
}

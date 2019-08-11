using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26.Reciprocal_cycles
{
    class Program
    {
        static void Main(string[] args)
        {
            int max = 0;
            int longest = 1;
            for (int i = 2; i <= 1000; i++)
            {
                int l = length(i);
                if (l > max)
                {
                    max = l;
                    longest = i;
                }
            }

            Console.WriteLine($"{longest}: {max}");
            Console.ReadLine();
        }

        static int length(int r)
        {
            List<int> reminders = new List<int>();
            string expansion = "0." + 10/r;
            int reminder = (10 % r) * 10;
            reminders.Add(reminder);
            while (true)
            {
                int next = reminder / r;
                reminder = (reminder % r) * 10;
                expansion += next;
                if (reminders.Contains(reminder))
                    break;
                reminders.Add(reminder);
            }
            return expansion.Length - 3;
        }
    }
}
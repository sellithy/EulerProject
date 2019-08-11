using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _42.Coded_triangle_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader("words.txt");
            string[] words = sr.ReadToEnd().Split();

            int counter = 0;
            foreach (string s in words)
                if (IsTriangleWord(s))
                    counter++;
            Console.WriteLine(counter);
            Console.Read();
        }

        private static bool IsTriangleNumber(int i)
        {
            int triangle = 1;
            int n = 1;
            while (triangle <= i)
            {
                if (i == triangle)
                    return true;
                triangle = (int)(.5 * n * (n + 1));
                n++;
            }

            return false;
        }

        private static bool IsTriangleWord(string s)
        {
            int sum = 0;

            foreach (char c in s)
                sum += (int)c - (int)'A' + 1;

            return IsTriangleNumber(sum);
        }
    }
}
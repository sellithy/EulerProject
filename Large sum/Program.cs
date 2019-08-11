using System;
using System.Collections.Generic;
using System.IO;
using System.Numerics;

namespace Large_sum
{
    class Program
    {
        const string fileName = "100 50-digit numbers.txt";
        static void Main(string[] args)
        {
            string[] numbers = Parse();
            BigInteger sum = 0;
            foreach (string s in numbers)
                sum += BigInteger.Parse(s);
            string answer = sum.ToString().Substring(0, 10);
            Console.WriteLine(answer);
            Console.ReadLine();
        }

        static string[] Parse()
        {
            StreamReader sr = new StreamReader(fileName);
            List<string> numbers = new List<string>();

            while (!sr.EndOfStream)
                numbers.Add(sr.ReadLine());

            return numbers.ToArray();
        }
    }
}
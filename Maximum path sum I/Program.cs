using System;
using System.Collections.Generic;
using System.IO;

namespace Maximum_path_sum_I
{
    class Program
    {
        static readonly List<List<int>> Triangle = Parse();

        static void Main(string[] args)
        {
            for (int i = Triangle.Count; i > 1; i--)
            {
                List<int> previousLine = Triangle[i - 1];
                List<int> currentLine = Triangle[i - 2];
                for (int j = 0; j < currentLine.Count; j++)
                {
                    int bigger = previousLine[j] > previousLine[j + 1] ? previousLine[j] : previousLine[j + 1];
                    currentLine[j] += bigger;
                }
            }
            Console.WriteLine(Triangle[0][0]);
            Console.Read();
        }

        private static List<List<int>> Parse()
        {
            List< List<int>> triangle = new List<List<int>>();
            StreamReader sr = new StreamReader("Triangle.txt");

            while (!sr.EndOfStream)
            {
                List<int> line = new List<int>();
                foreach (string s in sr.ReadLine().Split())
                    line.Add(int.Parse(s));

                triangle.Add(line);
            }
            return triangle;
        }

    }
}
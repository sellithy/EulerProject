using Extras;
using System;
using System.IO;
using System.Collections.Generic;
using System.Numerics;

namespace _22.Names_scores
{
    class Program
    {
        static readonly string[] names = Parse();
        static readonly int[] scores = new int[names.Length];

        static void Main(string[] args)
        {
            Array.Sort(names);
            BigInteger sum = 0;
            for (int i = 0; i < names.Length; i++)
                sum += LetterSum(names[i]) * (i + 1);

            Console.WriteLine(sum);
            Console.ReadLine();
        }

        static int LetterSum(string word)
        {
            word = word.ToLower();

            int sum = 0;
            for (int i = 0; i < word.Length; i++)
                sum += word[i] - (int)'a' + 1;

            return sum;
        }

        static string[] Parse()
        {
            StreamReader sr = new StreamReader("Names.txt");
            
            return sr.ReadLine().Replace("\"", "").Split(new char[] { ',' });
        }
    }
}

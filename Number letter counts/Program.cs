using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Number_letter_counts
{
    class Program
    {
        static readonly Dictionary<int, string> numberNames = ParseNumbersNames();
        static readonly List<string> powers = ParsePowerOfThousand();

        static void Main()
        {
            for (BigInteger i = 1000000000; i < 1000000000000; i+= 100000000)
            { 
                Console.Write(NumberToName(i));
                Console.ReadLine();
            }
            Console.ReadLine();
        }

        static string NumberToName(BigInteger n)
        {
            string number = n + "";
            if (!numberNames.TryGetValue((int)n, out string numberName))
            {
                if (number.Length == 2)
                {
                    numberName = NumberToName(number[0] + "0") + " " + NumberToName(number[1] + "");
                }

                if (number.Length == 3)
                {
                    numberName = NumberToName(number[0] + "") + " hundred";
                    string tens = NumberToName(number.Substring(1, 2));
                    numberName += tens != null ? " and " + tens : "";
                }

                if (3 < number.Length && number.Length < 7)
                {
                    int splitIndex = number.Length - 3;
                    numberName = NumberToName(number.Substring(0, splitIndex)) + " thousand";
                    string hundreds = NumberToName(number.Substring(splitIndex, 3));
                    numberName += " " + hundreds;
                }

                if (6 < number.Length && number.Length < 10)
                {
                    int splitIndex = number.Length - 6;
                    numberName = NumberToName(number.Substring(0, splitIndex)) + " million";
                    string thousands = NumberToName(number.Substring(splitIndex, 6));
                    numberName += " " + thousands;
                }

                if (9 < number.Length && number.Length < 13)
                {

                    int splitIndex = number.Length - ((number.Length-1)/3)*3;
                    numberName = NumberToName(number.Substring(0, splitIndex)) + " billion";
                    string rest = " " + NumberToName(number.Substring(splitIndex, number.Length / 3));
                    numberName +=  rest;
                }
            }

            return numberName;
        }

        //helps gets rid of 0's
        static string NumberToName(string n)
        {
            return NumberToName(BigInteger.Parse(n));
        }

        private static Dictionary<int, string> ParseNumbersNames()
        {
            Dictionary<int, string> numberNames = new Dictionary<int, string>();
            StreamReader sr = new StreamReader("NumbersNames.txt");

            while (!sr.EndOfStream)
            {
                string[] tokens = sr.ReadLine().Split();
                numberNames.Add(int.Parse(tokens[0]+""), tokens[1]);
            }

            return numberNames;
        }

        private static List<string> ParsePowerOfThousand()
        {
            List<string> powers = new List<string>();
            StreamReader sr = new StreamReader("PowersOfThousand.txt");

            while (!sr.EndOfStream)
                powers.Add(sr.ReadLine());

            return powers;
        }
    }
}
using System;
using Extras;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
using System.Diagnostics;

namespace _24.Lexicographic_permutations
{
    class Program
    {
        static void Main(string[] args)
        {
            string letters = "987654321";
            List<string> arr = AllPermutations(letters);

            Console.WriteLine(string.Join("\n", arr));

            Console.ReadLine();
        }

        private static List<string> AllPermutations(string letters)
        {
            if (letters.Length == 2)
                return new List<string> { letters, "" + letters[1] + letters[0] };

            List<string> all = new List<string>();

            for (int i = 0; i < letters.Length; i++)
            {
                char current = letters[i];
                List<string> sub = AllPermutations(letters.Remove(i, 1));

                for (int j = 0; j < sub.Count; j++)
                    sub[j] = current + sub[j];

                all.AddRange(sub);
            }

            return all;
        }

        private static char[] NextPermutation(char[] perm)
        {
            int l = perm.Length - 1;
            if (perm[l] > perm[l - 1])
                swap(perm, l, l - 1);

            return perm;
        }

        private static void swap(char[] arr, int index1, int index2)
        {
            char temp = arr[index1];
            arr[index1] = arr[index2];
            arr[index2] = temp;
        }
    }
}
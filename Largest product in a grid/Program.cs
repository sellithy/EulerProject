using System;
using System.Collections.Generic;
using System.IO;
using System.Numerics;

namespace Largest_product_in_a_grid
{
    class Program
    {
        const string fileName = "NumberGrid.txt";
        static void Main(string[] args)
        {
            List<List<int>> numbers = Parse();

            BigInteger product = 0;
            // I will loop over all the nodes and use them as a starting point
            //Then check right,bottom-right, bttom, and bottom-left for products
            for (int i = 0; i < numbers.Count; i++)
            {
                BigInteger tempProduct = 1;
                for (int j = 0; j < numbers[i].Count; j++)
                {
                    //Multiplying with the three on the right
                    if(j < numbers[i].Count - 3)
                        tempProduct = numbers[i][j] * numbers[i][j+1] * numbers[i][j + 2] * numbers[i][j + 3];
                    if (tempProduct > product) product = tempProduct;

                    //Multiplying with the three on bottom-right
                    if (j < numbers[i].Count - 3 && i < numbers.Count - 3)
                        tempProduct = numbers[i][j] * numbers[i + 1][j + 1] * numbers[i + 2][j + 2] * numbers[i + 3][j + 3];
                    if (tempProduct > product) product = tempProduct;

                    //Multiplying with the three on the bottom
                    if (i < numbers.Count - 3)
                        tempProduct = numbers[i][j] * numbers[i + 1][j] * numbers[i + 2][j] * numbers[i + 3][j];
                    if (tempProduct > product) product = tempProduct;

                    //Multiplying with the three on the bottom-left
                    if (j > 2 && i < numbers.Count - 3)
                        tempProduct = numbers[i][j] * numbers[i + 1][j - 1] * numbers[i + 2][j - 2] * numbers[i + 3][j - 3];
                    if (tempProduct > product) product = tempProduct;
                }
            }
            Console.WriteLine(product);
            Console.Read();
        }

        static List<List<int>> Parse()
        {
            StreamReader sr = new StreamReader(fileName);
            List<List<int>> numbers = new List<List<int>>();
            while (!sr.EndOfStream)
            {
                string[] tokens = sr.ReadLine().Split();
                List<int> line = new List<int>();

                foreach (string s in tokens)
                    line.Add(int.Parse(s));

                numbers.Add(line);
            }
            return numbers;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _39.Integer_right_triangles
{
    class Program
    {
        static void Main(string[] args)
        {
            int max = 1000;
            int triangles = 0;
            int found = 0;
            for (int perimeter = 12; perimeter <= max; perimeter++)
            {
                int numberOfTriangles = 0;
                for (int x = 1; x < perimeter/2; x++)
                    for (int y = 1; y < perimeter/2; y++)
                        if (2 * perimeter * (x + y) == 2 * x * y + perimeter * perimeter)
                            numberOfTriangles++;

                if (numberOfTriangles > triangles)
                {
                    found = perimeter;
                    triangles = numberOfTriangles;
                }
            }
            Console.Write($"{found}: {triangles / 2}");
            Console.ReadLine();
        }
    }
}
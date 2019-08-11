using Extras;
using System;
using System.Numerics;

namespace Lattice_paths
{
    class Program
    {
        static void Main(string[] args)
        {
            int squareSize = 20;
            BigInteger[,] grid = new BigInteger[squareSize+1,squareSize+1];
            grid[0, 0] = 1;

            Point current = new Point(0, 0);
            while(!current.Equals(new Point(squareSize, squareSize + 2)))
            {
                if (current.x < grid.GetLength(0) && current.y < grid.GetLength(1))
                {
                    if (current.x > 0)
                        grid[current.x, current.y] += grid[current.x - 1, current.y];

                    if (current.y > 0)
                        grid[current.x, current.y] += grid[current.x, current.y - 1];
                }
                current = NextGridPoint(current);
            }

            Console.WriteLine(grid[squareSize, squareSize]);
            Console.Read();
        }

        static Point NextGridPoint(Point point)
        {
            int x = point.x - 1;
            int y = point.y + 1;
            if(x == -1)
            {
                x = point.y + 1;
                y = 0;
            }

            return new Point(x,y);
        }
    }
}
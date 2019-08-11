namespace Extras
{
    public class Point
    {
        public int x { get;}
        public int y { get;}

        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public bool Equals(Point p)
        {
            return p.x == x && p.y == y;
        }

        public Point NextGridPointOnDiagonal()
        {
            int x = this.x - 1;
            int y = this.y + 1;
            if (x == -1)
            {
                x = this.y + 1;
                y = 0;
            }

            return new Point(x, y);
        }
    }
}
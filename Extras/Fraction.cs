using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extras
{
    public class Fraction : IComparable<Fraction>
    {
        private readonly int Numerator;
        private readonly int Denominator;

        public Fraction(int numerator, int denominator)
        {
            if (denominator == 0)
                throw new DivideByZeroException("A fraction cant have zero in the denominator");

            if (denominator < 0)
            {
                denominator *= -1;
                numerator *= -1;
            }
            Numerator = numerator;
            Denominator = denominator;
        }

        public Fraction(string numerator, string denominator) : this(int.Parse(numerator), int.Parse(denominator))
        {
        }

        public Fraction Simplify()
        {
            int gcd = ExtraNumbers.GCD(Math.Abs(Numerator), Denominator);
            return new Fraction(Numerator / gcd, Denominator / gcd);
        }

        public Fraction Multiply(Fraction f)
        {
            return new Fraction(f.Numerator * Numerator, f.Denominator * Denominator);
        }

        public override string ToString()
        {
            return $"{Numerator}/{Denominator}";
        }

        public double Value()
        {
            return (double)Numerator / Denominator;
        }

        public int CompareTo(Fraction that)
        {
            return this.Value().CompareTo(that.Value());
        }
    }
}
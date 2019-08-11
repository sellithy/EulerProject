using System;
using Extras;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _33.Digit_cancelling_fractions
{
    class Program
    {
        static void Main(string[] args)
        {
            Fraction product = new Fraction(1,1);
            for (int i = 10; i < 100; i++)
            {
                for (int j = i + 1; j < 100; j++)
                {
                    Fraction f = new Fraction(i, j);
                    if(WierdSimplify(f))
                        product = product.Multiply(f).Simplify();
                }
            }
            Console.WriteLine(product);
            Console.ReadLine();
        }

        static bool WierdSimplify(Fraction f)
        {
            string[] tokens = f.ToString().Split(new char[] { '/' });
            string num = tokens[0];
            string den = tokens[1];

            for (int i = 1; i < 10; i++)
            {
                bool bothContain = num.Contains(i + "") && den.Contains(i + "");
                if (bothContain)
                {
                    string tempnum = num.Replace(i + "", "");
                    string tempden = den.Replace(i + "", "");
                    if (tempnum != "" && tempden != "" && tempden != "0") {
                        Fraction temp = new Fraction(tempnum, tempden);
                        if (f.CompareTo(temp) == 0)
                            return true;
                    }
                }
            }

            return false;
        }
    }
}
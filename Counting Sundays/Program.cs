using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Counting_Sundays
{
    class Program
    {
        static void Main(string[] args)
        {
            Date target = new Date(31, 12, 2000);
            Date checkedDay = new Date(7, 1, 1900);

            while (checkedDay.Compare(new Date(1, 1, 1901)) < 0)
                checkedDay = checkedDay.AddWeek();

            int sundays = 0;
            while(checkedDay.Compare(target) <= 0)
            {
                if (checkedDay.GetDay() == 1)
                    sundays++;
                checkedDay = checkedDay.AddWeek();
            }

            Console.WriteLine(sundays);
            Console.ReadLine();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Counting_Sundays
{
    class Date
    {
        private readonly int[] DaysInMonth = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
        readonly int Day, Month, Year;

        public Date(int day, int month, int year)
        {
            Day = day;
            Month = month;
            Year = year;
        }

        public int Days()
        {
            if (Month == 2)
                return DaysInMonth[1] + (Leap() ? 1 : 0);
            else
                return DaysInMonth[Month-1];
        }

        public bool Leap()
        {
            return Year % 400 == 0 || (Year % 4 == 0 && Year % 100 != 0);
        }

        /// <summary>
        /// Compares this date to he given
        /// If passed date is greater returns a negative number
        /// </summary>
        /// <param name="date"></param>
        /// <returns></returns>
        public int Compare(Date date)
        {
            if (date.Year != Year)
                return Year - date.Year;
            else if(date.Month != Month)
                return Month - date.Month;
            else
                return Day - date.Day;
        }

        public Date AddWeek()
        {
            int day = this.Day + 7;
            int month = this.Month;
            int year = this.Year;

            if (day > Days())
            {
                day -= Days();
                month++;
            }

            if (month > 12)
            {
                month = 1;
                year++;
            }

            return new Date(day, month, year);
        }

        public int GetDay()
        { 
            return Day;
        }

        public int GetMonth()
        {
            return Month;
        }

        public int GetYear()
        {
            return Year;
        }
    }
}
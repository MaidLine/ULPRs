using System;
using System.Globalization;
namespace ULPR_BV1
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dt;
            int a = int.Parse(Console.ReadLine()); //day
            int b = int.Parse(Console.ReadLine()); //month
            int c = int.Parse(Console.ReadLine()); //year
            string date = $"{c}, {b}, {a}";
            int countDaysOfEndOfYear;
            GregorianCalendar calendar = new GregorianCalendar();
            if (DateTime.TryParse(date, out dt))
            {
                Console.WriteLine(calendar.GetDayOfYear(dt));
                if (calendar.IsLeapYear(c))
                {
                    countDaysOfEndOfYear = 366 - calendar.GetDayOfYear(dt);

                }
                else
                {
                    countDaysOfEndOfYear = 365 - calendar.GetDayOfYear(dt);
                }
                Console.WriteLine(countDaysOfEndOfYear);
            }
            else
            {
                Console.WriteLine("Не корректная дата! ");
            }
        }
    }
}
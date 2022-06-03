using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ULPR_BV2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите день: ");
            int a = int.Parse(Console.ReadLine()); //day
            Console.Write("Введите месяц: ");
            int b = int.Parse(Console.ReadLine()); //month 
            Console.Write("Введите год: ");
            int c = int.Parse(Console.ReadLine()); //year
            var dateJ = new DateTime(c, b, a);
            Console.WriteLine($"По юлианскому календарю: {dateJ}");
            var dateG = dateJ.AddDays((c / 100) - ((c / 100) / 4) - 2);
            Console.WriteLine($"По григорианскому календарю: {dateG}");
        }
    }
}

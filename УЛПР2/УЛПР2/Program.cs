using System;
namespace УЛПР2
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            if (y < 1 & y > -1)
            {
                if (x < 1 & x > -1)
                {
                    Console.WriteLine("Принадлежит");
                }
                else
                {
                    Console.WriteLine("Не принадлежит");
                }
            }
            else
            {
                Console.WriteLine("Не принадлежит");
            }
        }
    }
}
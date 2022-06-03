using System;
namespace УЛПР6
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 100; i < 1000; i++)
            {
                if (i % 7 == 0)
                {
                    int sum = 0;
                    int i1 = i;
                    while (i1 != 0)
                    {
                        sum += i1 % 10;
                        i1 /= 10;
                    }
                    if (sum % 7 == 0)
                    {
                        Console.WriteLine(i);
                    }
                }
            }
        }
    }
}
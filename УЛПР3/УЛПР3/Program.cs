using System;
namespace УЛПР3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] arg = new int[n];
            int max = 0;
            for (int i = 0; i < n; i++)
            {
                arg[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < n; i++)
            {
                if (arg[i] > max)
                {
                    max = arg[i];
                }
            }
            Console.WriteLine(max);
        }
    }
}
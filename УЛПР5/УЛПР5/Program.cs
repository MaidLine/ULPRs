﻿using System;
namespace УЛПР5
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int k = 0;
            while (n != 0)
            {
                if (n % 10 == 3)
                {
                    k += 1;
                    
                }
                n /= 10;
            }
            Console.WriteLine(k);
        }
    }
}
﻿using System;
namespace УЛПР4
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            for (int i = 1; i <= N; i++)
            {
                double kv = Math.Pow(i, 2);
                Console.WriteLine(kv);
            }
        }
    }
}
﻿using System;
namespace ULPR1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int S = 2 * (a * b + a * c + b * c);
            Console.WriteLine(S);
        }
    }
}
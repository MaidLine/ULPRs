using System;

namespace ULPR_BV5
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] mas = new int[n];
            //int[] mas = {1, 2, 3, 4, 5 };
            for (int i = 0; i < n; i++)
            {
                mas[i] = int.Parse(Console.ReadLine());
            }
            //
            int[] mas1 = new int[n];
            Random rnd = new Random();
            List <int> usedI = new List <int>();
            for (int i = 0; i < mas.Length; i++)
            {
                int replaceableI;
                bool reRun = false;
                do
                {
                    reRun = false;
                    replaceableI = rnd.Next(0, mas.Length);
                    for (int j = 0; j < usedI.Count; j++)
                    {
                        if (replaceableI == usedI[j])
                        {
                            reRun = true;
                        }
                    }
                } 
                while (replaceableI == i | reRun == true);
                mas1[replaceableI] = mas[i];
                usedI.Add(replaceableI);
            }
            for (int i = 0; i < mas1.Length; i++)
            {
                Console.WriteLine(mas1[i]);
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.IO.IsolatedStorage;
using System.Linq;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> set = new HashSet<string>();

            int N = Convert.ToInt32(Console.ReadLine());
            int M = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < M; i++)
            {
                set.Add(Console.ReadLine());
            }

            for (int i = 0; i < N - 1; i++)
            {
                HashSet<string> set1 = new HashSet<string>();
                int K = Convert.ToInt32(Console.ReadLine());
                for (int j = 0; j < K; j++)
                {
                    set1.Add(Console.ReadLine());
                }
                set.IntersectWith(set1);
            }
            Console.WriteLine(set.Count());
        }
    }
}
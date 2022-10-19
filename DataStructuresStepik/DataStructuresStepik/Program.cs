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
            HashSet<string> french = new HashSet<string>();
            HashSet<string> german = new HashSet<string>();

            int N = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < N; i++)
            {
                french.Add(Console.ReadLine());
            }

            int M = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < M; i++)
            {
                german.Add(Console.ReadLine());
            }

            french.IntersectWith(german);

            Console.WriteLine((N + M - 2 * french.Count != 0) ? (N + M - 2 * french.Count): "NO");
        }
    }
}
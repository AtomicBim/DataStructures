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
            for (int i = 0; i < N; i++)
            {
                set.Add(Console.ReadLine());
            }

            int M = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < M; i++)
            {
                Console.WriteLine((set.Contains(Console.ReadLine())?"YES":"NO"));
            }
        }
    }
}
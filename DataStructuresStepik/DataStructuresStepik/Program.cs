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
            int N = Convert.ToInt32(Console.ReadLine());

            HashSet<string> set = new HashSet<string>();
            HashSet<string> newSet = new HashSet<string>();

            set.Add(Console.ReadLine());

            int sum = 0;

            for (int i = 1; i < N; i++)
            {
                string str = Console.ReadLine();
                if (set.Contains(str))
                {
                    newSet.Add(str);
                    sum++;
                }
                set.Add(str);
            }

            Console.WriteLine(sum += newSet.Count);
        }
    }
}
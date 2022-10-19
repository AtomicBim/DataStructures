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

            int n = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                set.Add(Console.ReadLine());
            }

            if (set.Contains(Console.ReadLine()))
            {
                Console.WriteLine("EXIST");
            }
            else
            {
                Console.WriteLine("OK");
            }
        }
    }
}
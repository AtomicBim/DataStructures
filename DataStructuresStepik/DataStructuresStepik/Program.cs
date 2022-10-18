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
            int n = Convert.ToInt32(Console.ReadLine());

            Stack<long> stack = new Stack<long>();
            List<long> list = new List<long>();
            List<long> res = new List<long>();
            long digit = 0;

            for (int i = 0; i < n; i++)
            {
                string data = Console.ReadLine();

                switch (data[0])
                {
                    case '+':
                        digit = Convert.ToInt64(data.Substring(1, data.Length - 1));
                        stack.Push(digit);
                        if (list.Count == 0)
                        {
                            list.Add(digit);
                        }
                        else
                        {
                            list.Add(list.Last() + digit);
                        }
                        break;

                    case '-':
                        res.Add(stack.Pop());
                        list.RemoveAt(list.Count - 1);
                        break;

                    case '?':
                        digit = Convert.ToInt64(data.Substring(1, data.Length - 1));
                        long peek = list.Last();
                        if (list.Count == 1 || digit == list.Count)
                        {
                            res.Add(peek);
                        }
                        else
                        {
                            res.Add(peek - list[list.Count - (int)digit - 1]);
                        }
                        break;
                }
            }
            foreach (var item in res)
            {
                Console.WriteLine(item);
            }
        }
    }
}
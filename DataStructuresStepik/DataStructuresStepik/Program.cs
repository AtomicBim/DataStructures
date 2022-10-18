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
            Queue<int> ints = new Queue<int>();

            while (true)
            {
                string[] input = Console.ReadLine().Split(' ');

                switch (input[0])
                {
                    case "enqueue":
                        ints.Enqueue(Convert.ToInt32(input[1]));
                        Console.WriteLine("ok");
                        break;

                    case "dequeue":
                        if (ints.Count == 0)
                        {
                            Console.WriteLine("error");
                        }
                        else
                        {
                            Console.WriteLine(ints.Dequeue());
                        }
                        break;

                    case "peek":
                        if (ints.Count == 0)
                        {
                            Console.WriteLine("error");
                        }
                        else
                        {
                            Console.WriteLine(ints.Peek());
                        }
                        break;

                    case "count":
                        Console.WriteLine(ints.Count());
                        break;

                    case "clear":
                        ints.Clear();
                        Console.WriteLine("ok");
                        break;

                    case "exit":
                        Console.WriteLine("bye");
                        return;
                }
            }
        }
    }
}
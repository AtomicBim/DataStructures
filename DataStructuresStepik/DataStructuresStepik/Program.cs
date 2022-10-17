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
            Stack<int> stack_1 = new Stack<int>();

            Stack<int> stack_2 = new Stack<int>();

            Stack<int> stack_3 = new Stack<int>();

            int n = Convert.ToInt32(Console.ReadLine());
            int[] list = Array.ConvertAll(Console.ReadLine().Trim().Split(' '), Convert.ToInt32);


            int res = 0;

            stack_2.Push(list[0]);
            //модификация исходного массива stack_1
            for (int i = n - 1; i >= 0; i--)
            {
                if (list[i] == stack_2.Peek())
                {
                    continue;
                }
                else
                {
                    stack_2.Push(list[i]);
                }
            }

            //исходный массив в стек stack_2
            for (int i = n - 1; i >= 0; i--)
            {
                stack_1.Push(list[i]);
            }

            int stack_2_count = stack_2.Count;
            int stack_2_item = 0;

            for (int i = 0; i < stack_2_count; i++)
            {
                int cnt = 0;
                if (stack_2.Count != 0)
                {
                    stack_2_item = stack_2.Pop();
                }
                else { break; }

                int stack_1_count = stack_1.Count;

                if (stack_1.Count != 0)
                {
                    for (int k = 0; k < stack_1_count; k++)
                    {
                        if (stack_2_item == stack_1.Peek())
                        {
                            stack_3.Push(stack_1.Pop());
                        }
                        else { break; }
                    }
                }

                foreach (var item in stack_3)
                {
                    if (stack_3.Count != 0)
                    {
                        if (stack_2_item == item)
                        {
                            cnt++;
                        }
                        else { break; }
                    }
                    else { break; }
                }

                if (cnt >= 3)
                {
                    int stack_3_count = stack_3.Count;
                    for (int j = 0; j < stack_3_count; j++)
                    {
                        if (stack_3.Count != 0)
                        {
                            if (stack_2_item == stack_3.Peek())
                            {
                                stack_3.Pop();
                                res++;
                            }
                        }
                        else { break; }
                    }
                }
            }
            Console.WriteLine(res);
        }
    }
}
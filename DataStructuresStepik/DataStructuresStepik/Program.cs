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
            string[] incomingData = Console.ReadLine().Trim().Split(' ');

            int N = Convert.ToInt32(incomingData[0]);//docks
            int K = Convert.ToInt32(incomingData[1]);//compartment
            int P = Convert.ToInt32(incomingData[2]);//maximum planted barrels

            //create stacks
            Stack<int>[] stacks = new Stack<int>[K];
            for (int i = 0; i < K; i++)
            {
                stacks[i] = new Stack<int>();
            }

            for (int i = 0; i < N; i++)
            {
                string[] internalData = Console.ReadLine().Trim().Split(' ');
                char procedure = Convert.ToChar(internalData[0]);
                int compartment = Convert.ToInt32(internalData[1]);
                int fuelType = Convert.ToInt32(internalData[0]);

                switch (procedure)
                {
                    case '+':
                        stacks[i].Push(compartment);

                        break;

                    case '-':


                        break;
                }
            }
        }
    }
}
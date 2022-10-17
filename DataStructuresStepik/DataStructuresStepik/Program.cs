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

            int barrelsQuantity = 0;
            int maxBarrelsQuantity = 0;

            //create compartment stacks
            Stack<int>[] stacks = new Stack<int>[K];
            for (int i = 0; i < K; i++)
            {
                stacks[i] = new Stack<int>();
            }

            for (int j = 0; j < N; j++)
            {
                string[] internalData = Console.ReadLine().Trim().Split(' ');

                char procedure = Convert.ToChar(internalData[0]);
                int compartment = Convert.ToInt32(internalData[1]);
                int fuelType = Convert.ToInt32(internalData[2]);

                switch (procedure)
                {
                    case '+':
                        stacks[compartment - 1].Push(fuelType);
                        barrelsQuantity++;
                        break;

                    case '-':
                        if (stacks[compartment - 1].Count == 0 || stacks[compartment - 1].Peek() != fuelType)
                        {
                            Console.WriteLine("Error");
                            return;
                        }
                        else
                        {
                            stacks[compartment - 1].Pop();
                            barrelsQuantity--;
                        }
                        break;
                }

                if (barrelsQuantity > maxBarrelsQuantity)
                {
                    maxBarrelsQuantity = barrelsQuantity;
                }

                if (barrelsQuantity > P)
                {
                    Console.WriteLine("Error");
                    break;
                }
            }
            if (barrelsQuantity != 0)
            {
                Console.WriteLine("Error");
                return;
            }
            Console.WriteLine(maxBarrelsQuantity);
        }
    }
}
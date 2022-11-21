using System.Collections.Generic;
using System;

namespace MyNamespace
{
    public class ThemeDictionary
    {

    }
    class Program
    {
        static void Main()
        {
            var N = Convert.ToInt32(Console.ReadLine());
            var digits = Array.ConvertAll(Console.ReadLine().Split(' '), Convert.ToInt32);
            var digitsDict = new Dictionary<int, string>();

            digitsDict.Add(digits[0], "");

            string res;
            for (int i = 1; i < 2 * N; i++)
            {
                if (!digitsDict.TryGetValue(digits[i], out res))
                {
                    digitsDict.Add(digits[i], "");
                }
            }

            foreach (var item in digitsDict)
            {
                int counter = 0;

                for (int i = 0; i < 2 * N; i++)
                {
                    if (item.Key == digits[i])
                    {
                        counter++;
                        if (counter == N)
                        {
                            Console.Write(item.Key);
                            return;
                        }
                    }
                }
            }
        }
    }
}
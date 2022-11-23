using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace MyNamespace
{
    class Program
    {
        static void Main()
        {
            var themeDict = new Dictionary<int, string>();
            var messagesNumber = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < messagesNumber; i++)
            {
                var messageIndex = Convert.ToInt32(Console.ReadLine());

                if (messageIndex == 0)
                {
                    var themeTopic = Console.ReadLine();
                    var themeMessage = Console.ReadLine();

                    themeDict.Add(i + 1, themeTopic);
                }
                else
                {
                    var answerMessage = Console.ReadLine();

                    foreach (var message in themeDict)
                    {
                        if (message.Key == messageIndex)
                        {
                            themeDict.Add(i + 1, message.Value);
                        }
                    }
                }
            }

            foreach (var item in themeDict)
            {
                Console.WriteLine(item.Key + " " + item.Value);
            }
            //Console.WriteLine(themeDict.GroupBy(x => x)
            //              .OrderByDescending(x => x.Count())
            //              .First().Key);
        }
    }
}
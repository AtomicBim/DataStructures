using System;
using System.Linq;
using System.Collections.Generic;


namespace MyNamespace
{
    class Program
    {
        static void Main()
        {
            var messagesList = new List<string>();
            var themeDict = new Dictionary<int, string>();
            var messagesNumber = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < messagesNumber; i++)
            {
                var messageIndex = Convert.ToInt32(Console.ReadLine());

                if (messageIndex == 0)
                {
                    var themeTopic = Console.ReadLine();
                    var themeMessage = Console.ReadLine();

                    messagesList.Add(themeTopic);
                    themeDict.Add(i + 1, themeTopic);
                }
                else
                {
                    var answerMessage = Console.ReadLine();

                    foreach (var message in themeDict)
                    {
                        if (message.Key == messageIndex)
                        {
                            messagesList.Add(message.Value);
                        }
                    }
                }
            }
            Console.WriteLine(messagesList.GroupBy(x => x)
                          .OrderByDescending(x => x.Count())
                          .First().Key);
        }
    }
}
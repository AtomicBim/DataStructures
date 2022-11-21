namespace MyNamespace
{
    public class ThemeDictionary
    {

    }
    class Program
    {
        static void Main()
        {
            var messagesDict = new Dictionary<int, Dictionary<int, string>>();
            var messagesNumber = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < messagesNumber; i++)
            {
                var messageIndex = Convert.ToInt32(Console.ReadLine());

                if (messageIndex == 0)
                {
                    var themeTopic = Console.ReadLine();
                    var themeMessage = Console.ReadLine();

                    var localDict = new Dictionary<int, string>();
                    localDict.Add(i + 1, themeTopic);
                    messagesDict.Add(i + 1, localDict);
                }
                else
                {
                    var answerMessage = Console.ReadLine();

                    foreach (var message in messagesDict)
                    {
                        if (message.Key == messageIndex)
                        {
                            var localDict = new Dictionary<int, string>();
                            foreach (var item in message.Value)
                            {
                                localDict.Add(messageIndex, item.Value);
                            }
                            messagesDict.Add(i + 1, localDict);
                        }
                    }
                }
            }
            Console.WriteLine("Finish");
        }
    }
}
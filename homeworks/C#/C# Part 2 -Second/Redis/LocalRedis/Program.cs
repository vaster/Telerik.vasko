using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ServiceStack.Redis;

namespace LocalRedis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            UserInterface.PrintWelcomeMessage();
            UserInterface.PrintAddWordMessage();
            UserInterface.PrintListAllWords();
            UserInterface.PrintFindTranslationByWord();
            UserInterface.PrintExitMessage();

            DictionaryEngine engine = new DictionaryEngine();

            CommandExecutor cmdExecutor = new CommandExecutor(engine);

            cmdExecutor.Execute();

        }
    }
}

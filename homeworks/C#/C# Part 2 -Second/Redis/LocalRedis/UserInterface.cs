using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocalRedis
{
    public static class UserInterface
    {
        public static void PrintWelcomeMessage()
        {
            Console.WriteLine("This is sample dictionary.");
        }

        public static void PrintExitMessage()
        {
            Console.WriteLine("Exit.");
        }

        public static void PrintAddWordMessage()
        {
            Console.WriteLine("1.Add 'word' and translation:");
        }

        public static void PrintListAllWords()
        {
            Console.WriteLine("2.List all words.");
        }

        public static void PrintFindTranslationByWord()
        {
            Console.WriteLine("3.Find translation of a word.");
        }
    }
}

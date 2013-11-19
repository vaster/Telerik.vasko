using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocalRedis
{
    public class CommandExecutor
    {
        private DictionaryEngine engine = null;

        public CommandExecutor(DictionaryEngine engine)
        {
            this.engine = engine;
        }

        public void Execute()
        {
            int choice = 0;
           
            Render render = null;

            do
            {
                Console.Write("Choice:");
                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Enter word:");
                        string word = Console.ReadLine();

                        Console.WriteLine("Enter translation:");
                        string translation = Console.ReadLine();

                        engine.AddWord(word, translation);

                        break;
                    case 2:
                        render = engine.ListWords();
                        render.Execute();
                        break;
                    case 3:
                        Console.WriteLine("Word to serach for:");
                        string wordToSearch = Console.ReadLine();
                        render = engine.FindWord(wordToSearch);
                        render.Execute();
                        break;
                }
            } while (choice <= 3);
        }
    }
}

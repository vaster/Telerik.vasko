using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using Wintellect.PowerCollections;

namespace Catalog
{
    [ExcludeFromCodeCoverage]
    public class CatalogOfFreeContent
    {
        public static void Main()
        {
            StringBuilder consoleOutput = new StringBuilder();
            Catalog catalog = new Catalog();
            ICommandExecutor commandExecutor = new CommandExecutor();
            List<ICommand> commandsToExecute = ContainCommands();

            foreach (ICommand command in commandsToExecute)
            {
                commandExecutor.ExecuteCommand(catalog, command, consoleOutput);
            }
            Console.Write(consoleOutput);
        }

        private static List<ICommand> ContainCommands()
        {
            List<ICommand> instructions = new List<ICommand>();
            bool end = false;

            do
            {
                string currentCommand = Console.ReadLine();
                end = (currentCommand.Trim() == "End");
                if (!end)
                {
                    instructions.Add(new Command(currentCommand));
                }
            }
            while (!end);

            return instructions;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Minesweeper
{
    public static class UserInputProccesser
    {
        // The 'CommandReader' is a bit more secuare than the older version.
        public static void PlayIntroduction()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("This is Minesweeper game.");
            Console.WriteLine("Commands to play:");
            Console.WriteLine("     1. 'Top': Shows top six results.");
            Console.WriteLine("     2. 'Restart': Starts new game.");
            Console.WriteLine("     3. 'Exit': Exit from game.");
            Console.WriteLine("     4.  Enter coords. Example: 1 1.");
            Console.ForegroundColor = ConsoleColor.Gray;
        }

        public static string CommandReader()
        {
            int row = 0;
            int col = 0;
            string command = string.Empty;
           
            Console.Write("Enter input: ");
            command = Console.ReadLine().Trim().ToLower();

            string[] commandCoordsHolder = command.Split(' ');

            if (commandCoordsHolder.Length == 2)
            {
                if ((int.TryParse(commandCoordsHolder[0].ToString(), out row) && int.TryParse(commandCoordsHolder[1].ToString(), out col)
                    && row <= Engine.BOARD_ROWS && col <= Engine.BOARD_COLS))
                {
                    return (row + " " + col);  
                }
            }

            if (commandCoordsHolder.Length == 1)
            {
                if (commandCoordsHolder[0] == "top" || commandCoordsHolder[0] == "restart" || commandCoordsHolder[0] == "exit")
                {
                    return commandCoordsHolder[0];
                }
            }

            return "invalid";
        }
    }
}

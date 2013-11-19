using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Minesweeper
{
    // 1.Code Refactored
    // 2.New OOP arhitecure
    // 3.Some StyleCop
    public class MinesweeperMainMethod
    {
        // Entry point of the game.
        static void Main(string[] args)
        {
            Engine gameEngine = new Engine();

            gameEngine.Start();
        }
    }
}

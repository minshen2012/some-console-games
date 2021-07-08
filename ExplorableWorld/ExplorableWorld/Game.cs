using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace ExplorableWorld
{
    class Game
    {
        public void Start()
        {

            /*SetCursorPosition(4, 2);
            Write("X");*/

            string[,] grid =
            {
                { "=", "=", "=", "=", "=", "=", "=" },
                { "=", " ", "=", " ", " ", " ", "X" },
                { "O", " ", "=", " ", "=", " ", "=" },
                { "=", " ", "=", " ", "=", " ", "=" },
                { "=", " ", " ", " ", "=", " ", "=" },
                { "=", "=", "=", "=", "=", "=", "=" },
            };
            World myWorld = new World(grid);
            myWorld.Draw();


            WriteLine("\n\nPress any key to exit...");
            ReadKey(true);
        }
    }
}

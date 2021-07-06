using System;
using System.Collections.Generic;
using System.Text;

namespace TriviaGame
{
    class Player
    {
        public string Name;
        public int Score;

        public Player(string playName)
        {
            Name = playName;
            Score = 0;
        }
    }
}

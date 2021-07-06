using System;
using System.Collections.Generic;
using System.Text;

using static System.Console;
namespace DiceGame
{
    class DiceG
    {
        private string GameName;
        private Random RandomGenerator;
        private int Score;
        private string UnknownRollGraphic = @"    +---------+
    | ?     ? |
    | ?  ?  ? |
    | ?     ? |
    +---------+";
        private string Roll1Graphic = @"    +---------+
    |         |
    |    o    |
    |         |
    +---------+";
        private string Roll2Graphic = @"    +---------+
    | o       |
    |         |
    |       o |
    +---------+";
        private string Roll3Graphic = @"    +---------+
    | o       |
    |    o    |
    |       o |
    +---------+";
        private string Roll4Graphic = @"    +---------+
    | o     o |
    |         |
    | o     o |
    +---------+";
        private string Roll5Graphic = @"    +---------+
    | o     o |
    |    o    |
    | o     o |
    +---------+";
        private string Roll6Graphic = @"    +---------+
    | o     o |
    | o     o |
    | o     o |
    +---------+";

        public DiceG()
        {
            //Initialize anything that we need to: 
            Score = 0;
            GameName = "Rolls R' Us";
            RandomGenerator = new Random();
        }

        public void Start()
        {
            BackgroundColor = ConsoleColor.White;
            ForegroundColor = ConsoleColor.Black;
            Clear();
            //Method that starts the game running.
            Title = GameName;
            WriteLine($"=== {GameName} ===");
            WriteLine(UnknownRollGraphic);
            WriteLine("\nLet's play a game of chance with dice.");
            WriteLine("\nInstructions:");
            WriteLine("\t> I will roll a die each round.");
            WriteLine("\t> You will guess if it is high or low.");
            WriteLine("\t> If you get it right, I'll give you a point");
            WriteLine("\nReady to play? (yes/no) ");

            string playResponse = ReadLine().Trim().ToLower();
            if (playResponse == "yes")
            {
                WriteLine("Great - let's play!");
                PlayRound();
            }
            else
            {
                WriteLine("Dang, okay - maybe another time");
            }

            WriteLine("Press any key to exit...");
            ReadKey();
        }
        private void PlayRound()
        {
            //Method that runs one round of rolling and guessing.
            Clear();
            WriteLine("I'm about to roll...");
            WriteLine(UnknownRollGraphic);
            WriteLine("Is it going to be low (1, 2, 3) or high (4, 5, 6)?");

            string response = ReadLine().Trim().ToLower();
            int roll = RandomGenerator.Next(1, 7);

            WriteLine();
            ForegroundColor = ConsoleColor.DarkMagenta;
            switch (roll)
            {
                case 1:
                    WriteLine(Roll1Graphic);
                    break;
                case 2:
                    WriteLine(Roll2Graphic);
                    break;
                case 3:
                    WriteLine(Roll3Graphic);
                    break;
                case 4:
                    WriteLine(Roll4Graphic);
                    break;
                case 5:
                    WriteLine(Roll5Graphic);
                    break;
                case 6:
                    WriteLine(Roll6Graphic);
                    break;
                default:
                    WriteLine("Uh oh... the roll broke");
                    break;
            }

            if (response == "high")
            {
                WriteLine("You guessed high...");
                if (roll <= 3)
                {
                    Lose();
                }
                else
                {
                    Win();
                }
            }
            else if(response == "low")
            {
                WriteLine("You guessed low...");
                if (roll <= 3)
                {
                    Win();
                }
                else
                {
                    Lose();
                }
            }
            else
            {
                WriteLine($"You guessed {response}. That's not valid. try again with 'high' or 'low'.");
            }
            AskToPlayAgain();
        }
        private void Win()
        {
            //Method that increments the score and lets the player know they won.
            Score += 1;
            ForegroundColor = ConsoleColor.DarkGreen;

            WriteLine("You win :)");
            WriteLine($"Score: {Score}");
        }
        private void Lose()
        {
            //Method that lets the player know they lost.
            ForegroundColor = ConsoleColor.DarkRed;

            WriteLine("You lose :(");
            WriteLine($"Score: {Score}");
        }
        private void AskToPlayAgain()
        {
            //Method that ask to play again
            ForegroundColor = ConsoleColor.Black;

            Write("Would you like to play another round? (yes/no) ");
            string playResponse = ReadLine().Trim().ToLower();
            if(playResponse == "yes")
            {
                PlayRound();
            }
            else
            {
                WriteLine("Had enouth? Okay see you later.");
            }

        }
    }
}

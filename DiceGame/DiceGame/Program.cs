using System;
using static System.Console;
namespace DiceGame
{
    class Program
    {
        static void Main(string[] args)
        {
            //Demos to do: 
            // - Random
            // - IF conditionals
            // - Switch statements

            Random myRandGenerator = new Random();
            int randNumber = myRandGenerator.Next(1, 7);
            WriteLine($"num {randNumber}");

            if (randNumber <= 3)
            {
                WriteLine("you got low");
            }
            else
            {
                WriteLine("you didn't get it");
            }

            WriteLine("Press any key to exit...");
            ReadKey();
        }
    }
}

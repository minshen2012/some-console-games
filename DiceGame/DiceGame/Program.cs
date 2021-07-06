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

            /*Random myRandGenerator = new Random();
            int randNumber = myRandGenerator.Next(1, 7);
            WriteLine($"num {randNumber}");

          
            WriteLine("Press any key to exit...");
            ReadKey();*/

            DiceG myGame = new DiceG();
            myGame.Start();
        }
    }
}

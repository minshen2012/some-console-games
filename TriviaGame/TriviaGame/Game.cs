using System;
using System.Collections.Generic;
using System.Text;

using static System.Console;
namespace TriviaGame
{
    class Game
    {
        private string GameTitleArt = @"
 _____    _       _         _____                 _   
|_   _|  (_)     (_)       |  _  |               | |  
  | |_ __ ___   ___  __ _  | | | |_   _  ___  ___| |_ 
  | | '__| \ \ / / |/ _` | | | | | | | |/ _ \/ __| __|
  | | |  | |\ V /| | (_| | \ \/' / |_| |  __/\__ \ |_ 
  \_/_|  |_| \_/ |_|\__,_|  \_/\_\\__,_|\___||___/\__|";
        private string GameTitle = "Trivia Quest";
        private string Description = "Battle your friends for the top score in silly trivia";
        private Player CurrentPlayer;
        private TriviaItem UnicornTrivia;
        private TriviaItem OctoTrivia;
        private TriviaItem BleachTrivia;

        public Game()
        {
            string unicornQuestion = "The National Animal of xxx is the Unicorn - true or false?";
            UnicornTrivia = new TriviaItem(unicornQuestion, "true");

            string octoQuestion = "An octopus can fit through any hole larger than its beak - true or false?";
            OctoTrivia = new TriviaItem(octoQuestion, "true");

            string bleachQuestion = "Bleach never expires - true or false?";
            BleachTrivia = new TriviaItem(bleachQuestion, "false");
        }

        public void Play()
        {
            Title = GameTitle;

            WriteLine(GameTitleArt);
            WriteLine($"Welcome to {GameTitle}!");
            WriteLine(Description);

            Write("\nWhat is your name: ");
            string playerName = ReadLine();
            CurrentPlayer = new Player(playerName);
            WriteLine($"Welcome to {GameTitle}, {CurrentPlayer.Name}");
            WriteLine($"Your starting score is {CurrentPlayer.Score}");

            WriteLine("\n~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            UnicornTrivia.AskQuestion();
            WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");

            WriteLine("\n~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            OctoTrivia.AskQuestion();
            WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");

            WriteLine("\n~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            BleachTrivia.AskQuestion();
            WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");

            WriteLine("\nPress any key to exit.");
            ReadKey();
        }
    }
}

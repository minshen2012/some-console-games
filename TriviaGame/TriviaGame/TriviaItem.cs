using System;
using System.Collections.Generic;
using System.Text;

using static System.Console;

namespace TriviaGame
{
    class TriviaItem
    {
        private string Question;
        private string Answer;

        public TriviaItem(string triviaQuestion, string triviaAnswer)
        {
            Question = triviaQuestion;
            Answer = triviaAnswer;
        }

        public void AskQuestion()
        {
            //TODO: dispaly the question, get a response, display correct answer
            WriteLine(Question);
            Write("What's your answer? ");
            string playAnswer = ReadLine();
            WriteLine($"You answered '{playAnswer}'.");
            WriteLine($"The correct answer was: {Answer}.");

        }
    }
}

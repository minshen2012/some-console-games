using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace VirtualPet
{
    class VirtualPet
    {
        //Field
        //public = access modifier
        public string FullName;
        public int Age;
        public string Species;
        public bool IsAwake;
        private int ExperiencePoints;

        //constructor
        public VirtualPet(string petName, int petAge, string petSpecies, bool petIsAwake)
        {
            //WriteLine("Pet being constructed");
            FullName = petName;
            Age = petAge;
            Species = petSpecies;
            IsAwake = petIsAwake;
        }

        //Method definition:
        public void Greet()
        {
            WriteLine($"My name is {FullName}, {Species}.");
            WriteLine($"I am {Age} years old.");
            WriteLine($"Is awake? {IsAwake}.");
        }

        public void Sleep()
        {
            IsAwake = false;
            WriteLine($"{FullName} is now snoring...Zzzzz");
        }

        public void Eat(string foodName)
        {
            WriteLine($"{FullName} is now eating {foodName}.");
        }
    }
}

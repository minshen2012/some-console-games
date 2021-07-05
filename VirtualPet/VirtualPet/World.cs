using System;
using static System.Console;
using System.Collections.Generic;
using System.Text;

namespace VirtualPet
{
    class World
    {
        public void Run()
        {
            Title = "=== Virtual Pet ===";
            //text ascii art
            WriteLine(@"
 __      ___      _               _   _____     _   
 \ \    / (_)    | |             | | |  __ \   | |  
  \ \  / / _ _ __| |_ _   _  __ _| | | |__) |__| |_ 
   \ \/ / | | '__| __| | | |/ _` | | |  ___/ _ \ __|
    \  /  | | |  | |_| |_| | (_| | | | |  |  __/ |_ 
     \/   |_|_|   \__|\__,_|\__,_|_| |_|   \___|\__|");

            WriteLine("Welcome to the pet simulator!");

            VirtualPet leoTheCat = new VirtualPet("Leo", 12, "Cat", true);

            WriteLine("> Pet 1");
            leoTheCat.Greet();
            leoTheCat.Eat("some dry food");
            WriteLine();

            VirtualPet juniorTheParrot = new VirtualPet("Junior", 50, "Parrot", false);

            WriteLine("> Pet 2");
            juniorTheParrot.Greet();
            juniorTheParrot.Sleep();
            WriteLine();

            VirtualPet callieTheunicorn = new VirtualPet("Callie", 250, "Unicorn", true);
            WriteLine("> Pet 3");
            callieTheunicorn.Greet();
            callieTheunicorn.Eat("rainbows");
            callieTheunicorn.Sleep();
            WriteLine();

            WriteLine("Press any key to exit...");
            ReadKey();
        }
        
    }
}

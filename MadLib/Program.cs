using System;

namespace MadLib
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                string Selection;
                string Quit = "To exit the program, press Q.";
                string Choices = "To proceed with a mad lib, make a selection... 1, 2, or 3 ? ";

                do
                {
                    Console.WriteLine(Quit);
                    Console.WriteLine(Choices);
                    Selection = Console.ReadLine().ToLower();

                    if (Selection == "1")
                    {
                        MadLibMFOY madLibMFOY = new MadLibMFOY();
                    }
                     else if (Selection == "2")
                    {
                        Regulate regulate = new Regulate();
                    }
                    else if (Selection == "3")
                    {
                        TurnBackTime turnBackTime = new TurnBackTime();
                    }
                }
                while (Selection != "q");
                {
                    return;
                }
            }
        }
    }
}
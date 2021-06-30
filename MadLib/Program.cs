using System;

namespace MadLib
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to my mad lib!");

            Console.WriteLine("Pick an option. 1, 2, or 3? ");
            var Selection = Console.ReadLine();
            int madLib = int.Parse(Selection);


            while (true)
            {
                if (madLib == 1)
                {
                    MadLibMFOY madLibMFOY = new MadLibMFOY();
                }

                else if (madLib == 2)
                {
                    Regulate regulate = new Regulate();
                }

                else if (madLib == 3)
                {
                    TurnBackTime turnBackTime = new TurnBackTime();
                }
                return;
            }
        }
    }
}

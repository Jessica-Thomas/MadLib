using System;

namespace MadLib
{
    class Program
    {
        static void Main(string[] args)
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

                    //Songs.MyFriendsOverYou();
                    //MyFriendsOverYou myFriendsOverYou = new();
                    
                }
                else if (Selection == "2")
                {
                    Songs.Regulate();
                    //Regulate regulate = new();
                }
                else if (Selection == "3")
                {
                    Songs.TurnBackTime();
                    //TurnBackTime turnBackTime = new();
                }
                else if (Selection == "q")
                {
                    Console.WriteLine("Hope you had fun. Peace out.");
                    break;
                }
            }
            while (Selection != "q");
            {
                return;
            }
        }
    }
}
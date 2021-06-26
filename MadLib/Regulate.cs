using System;

namespace MadLib
{
    public class Regulate
    {
        public Regulate()
        {
            Console.WriteLine("Please give me a plural noun:  ");
            string pluralNoun = Console.ReadLine();

            Console.WriteLine("Please give me a color:  ");
            string Color = Console.ReadLine();

            Console.WriteLine("Please give me another color:  ");
            string secondColor = Console.ReadLine();

            Console.WriteLine("Please give me a noun:  ");
            string Noun = Console.ReadLine();

            Console.WriteLine("Please give me a time of day:  ");
            string timeOfDay = Console.ReadLine();

            Console.WriteLine("Please give me a place:  ");
            string Place = Console.ReadLine();


            string madLibRegulators = pluralNoun + " , mount up... \n " +
                                            "It was a clear " + Color + " night, a clear " + secondColor + " moon. \n" +
                                            "Warren G was on the " + Noun + ", trying to consume  \n" +
                                            "Some skirts for the " + timeOfDay + ", so I can get some funk \n" +
                                            "Just rollin' in my ride, chillin' all alone  \n" +
                                            "Just hit the Eastside of the " + Place + " \n" +
                                            "On a mission trying to find Mr.Warren G.  \n";

            Console.WriteLine(madLibRegulators);

            string Regulators = "Here are the real lyrics-- Regulate by Nate Dogg and Warren G \n" +
                                            "Regulators, mount up... \n " +
                                            "It was a clear black night, a clear white moon. \n" +
                                            "Warren G was on the street, trying to consume  \n" +
                                            "Some skirts for the eve so I can get some funk \n" +
                                            "Just rollin' in my ride, chillin' all alone  \n" +
                                            "Just hit the Eastside of the  LBC  \n" +
                                            "On a mission trying to find Mr.Warren G.  \n";

            Console.WriteLine(Regulators);

        }
    }
}

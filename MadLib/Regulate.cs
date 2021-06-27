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
            string color = Console.ReadLine();

            Console.WriteLine("Please give me another color:  ");
            string secondColor = Console.ReadLine();

            Console.WriteLine("Please give me a noun:  ");
            string noun = Console.ReadLine();

            Console.WriteLine("Please give me a time of day:  ");
            string timeOfDay = Console.ReadLine();

            Console.WriteLine("Please give me a place:  ");
            string place = Console.ReadLine();


            string madLibRegulators = pluralNoun + " , mount up... \n " +
                                            "It was a clear " + color + " night, a clear " + secondColor + " moon. \n" +
                                            "Warren G was on the " + noun + ", trying to consume  \n" +
                                            "Some skirts for the " + timeOfDay + ", so I can get some funk \n" +
                                            "Just rollin' in my ride, chillin' all alone  \n" +
                                            "Just hit the Eastside of the " + place + " \n" +
                                            "On a mission trying to find Mr.Warren G.  \n";

            Console.WriteLine(madLibRegulators);

            string regulators = "Here are the real lyrics-- Regulate by Nate Dogg and Warren G \n" +
                                            "Regulators, mount up... \n " +
                                            "It was a clear black night, a clear white moon. \n" +
                                            "Warren G was on the street, trying to consume  \n" +
                                            "Some skirts for the eve so I can get some funk \n" +
                                            "Just rollin' in my ride, chillin' all alone  \n" +
                                            "Just hit the Eastside of the  LBC  \n" +
                                            "On a mission trying to find Mr.Warren G.  \n";

            Console.WriteLine(regulators);

        }
    }
}

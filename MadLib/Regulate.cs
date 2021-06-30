using System;

namespace MadLib
{
    public class Regulate
    {

        public Regulate()
        {
            //array for holding the parts of speech we need
            string[] PartsOfSpeech =
            {
                "a plural noun:  ",
                "a color:  ",
                "another color:  ",
                "a noun:  ",
                "a time of day:  ",
                "a place:  "
            };

            //array for holding user input
            string[] Words = { "", "", "", "", "", "" };

            //loop to iterate through each part of speech, take the user input and add it to a list
            for (int i = 0; i < Words.Length; i++)
            {
                Console.WriteLine("Please give me " + PartsOfSpeech[i]);
                Words[i] = Console.ReadLine();
            }

            string madLibRegulators = Words[0] + " , mount up... \n " +
                                            "It was a clear " + Words[1] + " night, a clear " + Words[2] + " moon. \n" +
                                            "Warren G was on the " + Words[3] + ", trying to consume  \n" +
                                            "Some skirts for the " + Words[4] + ", so I can get some funk \n" +
                                            "Just rollin' in my ride, chillin' all alone  \n" +
                                            "Just hit the Eastside of the " + Words[5] + " \n" +
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

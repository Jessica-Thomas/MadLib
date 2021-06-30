using System;
using System.Collections.Generic;


namespace MadLib
{
    public class Regulate
    {
        public Regulate()
        {
            //List for holding the parts of speech we need
            List<string> partsOfSpeech = new List<string>();
            partsOfSpeech.Add("a plural noun:  ");
            partsOfSpeech.Add("a color:  ");
            partsOfSpeech.Add("another color:  ");
            partsOfSpeech.Add("a noun:  ");
            partsOfSpeech.Add("a time of day:  ");
            partsOfSpeech.Add("a place:  ");

            //Array for holding user input
            string[] Words = { "", "", "", "", "", "" };

            //Loop to iterate through each part of speech, take the user input and add it to an array
            for (int i = 0; i < Words.Length; i++)
            {
                Console.WriteLine("Please give me " + partsOfSpeech[i]);
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
        }

        public static void RealLyricsRegulate()
            {
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

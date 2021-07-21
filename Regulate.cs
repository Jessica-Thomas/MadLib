using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace MadLib
{
    public class Regulate
    {
        public Regulate()
        {
            //Initialize empty array for holding user input
            string[] Words = new string[6];

            //List for holding the parts of speech we need
            //Adding in the parts of speech needed for this mad lib
            List<string> partsOfSpeech = new();
            partsOfSpeech.Add("a plural noun:  ");
            partsOfSpeech.Add("a color:  ");
            partsOfSpeech.Add("another color:  ");
            partsOfSpeech.Add("a noun:  ");
            partsOfSpeech.Add("a time of day:  ");
            partsOfSpeech.Add("a place:  ");

            //Concatenation and adding user input via indexing the array
            string madLib = Words[0] + " , mount up... \n" +
                            "It was a clear " + Words[1] + " night, a clear " + Words[2] + " moon. \n" +
                            "Warren G was on the " + Words[3] + ", trying to consume  \n" +
                            "Some skirts for the " + Words[4] + ", so I can get some funk \n" +
                            "Just rollin' in my ride, chillin' all alone  \n" +
                            "Just hit the Eastside of the " + Words[5] + " \n" +
                            "On a mission trying to find Mr.Warren G.  \n";

            string realLyrics = "Here are the real lyrics-- Regulate by Nate Dogg and Warren G \n" +
                                "Regulators, mount up... \n " +
                                "It was a clear black night, a clear white moon. \n" +
                                "Warren G was on the street, trying to consume  \n" +
                                "Some skirts for the eve so I can get some funk \n" +
                                "Just rollin' in my ride, chillin' all alone  \n" +
                                "Just hit the Eastside of the  LBC  \n" +
                                "On a mission trying to find Mr.Warren G.  \n";


            Input.GetInput getInput = new();
            Input.DisplayMadLib displayMadLib = new();
            Input.DisplayRealLyrics displayRealLyrics = new();

        }

    }
}

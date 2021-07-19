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

            //Regex for pattern matching to ensure user input is alpha and at least 2 characters long
            RegexOptions options = RegexOptions.IgnoreCase;
            Regex inputValidation = new Regex("[a-z]+", options);


            //Loop to iterate through each part of speech, take the user input and add it to an array
            for (int i = 0; i < Words.Length; i++)
            {
                Console.WriteLine("Please give me " + partsOfSpeech[i]);
                Words[i] = Console.ReadLine().ToUpper();

                //Uses regex to be sure we're getting a valid input before moving to the next prompt-- if input does not match pattern, continues to ask until we get a part of speech that matches
                while (!inputValidation.IsMatch(Words[i]))
                {
                    Console.WriteLine("Invalid input. Please try again. Give me " + partsOfSpeech[i]);
                    Words[i] = Console.ReadLine().ToUpper();
                }
            }

            //Concatenation and adding user input via indexing the array
            string madLibRegulators = Words[0] + " , mount up... \n" +
                                    "It was a clear " + Words[1] + " night, a clear " + Words[2] + " moon. \n" +
                                    "Warren G was on the " + Words[3] + ", trying to consume  \n" +
                                    "Some skirts for the " + Words[4] + ", so I can get some funk \n" +
                                    "Just rollin' in my ride, chillin' all alone  \n" +
                                    "Just hit the Eastside of the " + Words[5] + " \n" +
                                    "On a mission trying to find Mr.Warren G.  \n";

            //Writes completed MadLib to the console
            Console.WriteLine(madLibRegulators);  

            //If user inputs Y or yes, the actual song lyrics are written to the console. Anything else loops back to the main menu
            Console.WriteLine("Would you like to see the real lyics?  Y or N:  ");
            string realLyrics = Console.ReadLine().ToLower();

            string regulators = "Here are the real lyrics-- Regulate by Nate Dogg and Warren G \n" +
                                "Regulators, mount up... \n " +
                                "It was a clear black night, a clear white moon. \n" +
                                "Warren G was on the street, trying to consume  \n" +
                                "Some skirts for the eve so I can get some funk \n" +
                                "Just rollin' in my ride, chillin' all alone  \n" +
                                "Just hit the Eastside of the  LBC  \n" +
                                "On a mission trying to find Mr.Warren G.  \n";

            if (realLyrics is "y" or "yes")
            {
                Console.WriteLine(regulators);
            }
            else
            {
                return;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace MadLib
{
    public class Input
    {
        //Regex to ensure user input is alpha and at least 2 characters
        readonly Regex pattern = new("\b(?i)[a-z]{2,}\b");

        //Ask for user input-- pull from part of speech list, add response to same index in an array
        public static void GetInput(List<string> partsOfSpeech, string[] Words, int i)
        {
            Console.WriteLine("Please give me " + partsOfSpeech[i]);
            Words[i] = Console.ReadLine().ToUpper();
        }

        //When input is invalid, let user know and repeat request for part of speech
        public static void InvalidInput(List<string> partsOfSpeech, string[] Words, int i)
        {
            Console.WriteLine("Invalid input. Please try again. Give me " + partsOfSpeech[i]);
            Words[i] = Console.ReadLine().ToUpper();
        }

        //Writes real lyrics to the console if user inputs y
        public static void RealLyrics(string Lyrics)
        {
            Console.WriteLine("Would you like to see the real lyics?  Y or N:  ");
            string realLyrics = Console.ReadLine().ToLower();

            if (realLyrics is "y" or "yes")
            {
                Console.WriteLine(actualSong);
            }
            else
            {
                return;
            }

        }

    }
}
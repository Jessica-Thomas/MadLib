using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace MadLib
{
    public class Input
    {
        //Regex to ensure user input is alpha and at least 2 characters
        Regex pattern = new(pattern: @"(?i)[a-z]{2,}");

        //Ask for user input-- pull from part of speech list, add response to same index in an array
        static void GetInput(List<string> partsOfSpeech, string[] Words)
            {
                Console.WriteLine("Please give me " + partsOfSpeech[i]);
                Words[i] = Console.ReadLine().ToUpper();
            }

        //When input is invalid, let user know and repeat request for part of speech
        static void InvalidInput(List<string> partsOfSpeech, string[] Words, int i)
        {
            Console.WriteLine("Invalid input. Please try again. Give me " + partsOfSpeech[i]);
            Words[i] = Console.ReadLine().ToUpper();
        }

        //Writes real lyrics to the console if user inputs y
        static void RealLyrics(string Lyrics)
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
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace MadLib
{
    public class Input 
    {
        //Ask for user input-- pull from part of speech list, add response to same index in an array
        public static void GetInput(List<string> partsOfSpeech, string[] Words, int i)
        {
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

                Console.WriteLine(Songs.MyFriendsOverYou());
            }
        }


        //Writes real lyrics to the console if user inputs y
        public static void RealLyrics() 
        {
            Console.WriteLine("Would you like to see the real lyics?  Y or N:  ");
            string displayRealLyrics = Console.ReadLine().ToLower();
            string realLyrics;

            if (displayRealLyrics is "y" or "yes")
            {
                Console.WriteLine();
            }
            else
            {
                return;
            }

        
        }

        internal static void RealLyrics()
        {
            throw new NotImplementedException();
        }

        internal static void GetInput()
        {
            throw new NotImplementedException();
        }

    }
}

    
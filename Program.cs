using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

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
                    //List for holding the parts of speech we need
                    List<string> partsOfSpeech = new();

                    //Adding in the parts of speech needed for this mad lib
                    partsOfSpeech.Add("a body part:  ");
                    partsOfSpeech.Add("a plural noun:  ");
                    partsOfSpeech.Add("a verb:  ");
                    partsOfSpeech.Add("another verb:  ");

                    //Initialize empty array for holding user input
                    string[] Words = new string[4];

                    GatherWords(partsOfSpeech, Words);

                    //Concatenation and adding user input via indexing the Words array
                    string madLib = $"You were everything I wanted \nBut I, just can't finish what I've started \nThere's no room left here on my {Words[0]} \nIt was damaged long ago \nThough you swear that you are true \nI still pick my  {Words[1]}   over you \n(My {Words[1]}  over you) \nPlease tell me everything \nThat you think that I should {Words[2]} \nAbout all the plans you made \nWhen I was nowhere to be found \nAnd it's all right to forget \nThat we still {Words[3]} \nIt's just for fun, isn't it? \nIt's my fault that it fell apart \n'Cause maybe ('cause maybe) \nYou need this(you need this) \nAnd I didn't (and I didn't) \nMean to \nLead you on \nYou were everything I wanted \nBut I just can't finish what I've started \nThere's no room left here on my  {Words[0]} \nIt was damaged long ago \nThough you swear that you are true \nI still pick my {Words[1]} over you \n(My {Words[1]} over you) \n";


                    string realLyrics = "Here are the real lyrics-- My Friends Over You by New Found Glory \nYou were everything I wanted \nBut I, just can't finish what I've started \nThere's no room left here on my back \nIt was damaged long ago \nThough you swear that you are true \nI still pick my friends over you \n(My friends over you) \nPlease tell me everything \nThat you think that I should know \nAbout all the plans you made \nWhen I was nowhere to be found \nAnd it's all right to forget \nThat we still talk \nIt's just for fun, isn't it? \nIt's my fault that it fell apart \n'Cause maybe ('cause maybe) \nYou need this(you need this) \nAnd I didn't (and I didn't) \nMean to \nLead you on \nYou were everything I wanted \nBut I just can't finish what I've started \nThere's no room left here on my back \nIt was damaged long ago \nThough you swear that you are true \nI still pick my friends over you \n(My friends over you) \n";

                    ShowMadLib(madLib);
                    ShowRealLyrics(realLyrics);
                }
                else if (Selection == "2")
                {
                    //Turn Back Time Mad Lib
                    //List for holding the parts of speech we need
                    //Adding in the parts of speech needed for this mad lib
                    List<string> partsOfSpeech = new();
                    partsOfSpeech.Add("a verb:  ");
                    partsOfSpeech.Add("a plural noun:  ");
                    partsOfSpeech.Add("a noun:  ");
                    partsOfSpeech.Add("a verb:  ");
                    partsOfSpeech.Add("another verb:  ");
                    partsOfSpeech.Add("a plural noun:  ");

                    //Initialize empty array for holding user input
                    string[] Words = new string[6];
                    GatherWords(partsOfSpeech, Words);

                    //Concatenation and adding user input via indexing the Words array
                    string madLib = "If I could " + Words[0] + " back time \nIf I could find a way \nI'd take back those " + Words[1] + " that've hurt you and you'd stay \nI don't know why I did the things I did \nI don't know why I said the things I said \nPride's like a knife, it can cut deep inside \n" + Words[2] + " are like weapons, they " + Words[3] + " sometimes \nI didn't really mean to " + Words[4] + " you \nI didn't wanna see you go \nI know I made you cry, but baby \nIf I could  " + Words[0] + "  back time, if I could find a way \nI'd take back those " + Words[5] + " that've hurt you, you'd stay \nIf I could reach the stars, I'd give 'em all to you \nThen you'd love me, love me, like you used to do \nIf I could  " + Words[0] + "  back time \n";

                    string realLyrics = "Here are the real lyrics--If I Could Turn Back Time by Cher: \nIf I could turn back time \nIf I could find a way \nI'd take back those words that've hurt you and you'd stay \nI don't know why I did the things I did \nI don't know why I said the things I said \nPride's like a knife, it can cut deep inside \nWords are like weapons, they wound sometimes \nI didn't really mean to hurt you \nI didn't wanna see you go \nI know I made you cry, but baby \nIf I could turn back time, if I could find a way \nI'd take back those words that've hurt you, you'd stay \nIf I could reach the stars, I'd give 'em all to you \nThen you'd love me, love me, like you used to do \nIf I could turn back time \n";


                    ShowMadLib(madLib);
                    ShowRealLyrics(realLyrics);
                }
                else if (Selection == "3")
                {
                    //Regulate Mad Lib
                    //List for holding the parts of speech we need
                    //Adding in the parts of speech needed for this mad lib
                    List<string> partsOfSpeech = new();
                    partsOfSpeech.Add("a plural noun:  ");
                    partsOfSpeech.Add("a color:  ");
                    partsOfSpeech.Add("another color:  ");
                    partsOfSpeech.Add("a noun:  ");
                    partsOfSpeech.Add("a time of day:  ");
                    partsOfSpeech.Add("a place:  ");

                    //Initialize empty array for holding user input
                    string[] Words = new string[6];

                    GatherWords(partsOfSpeech, Words);

                    //Concatenation and adding user input via indexing the Words array
                    string madLib = Words[0] + " , mount up... \nIt was a clear " + Words[1] + " night, a clear " + Words[2] + " moon. \nWarren G was on the " + Words[3] + ", trying to consume  \nSome skirts for the " + Words[4] + ", so I can get some funk \nJust rollin' in my ride, chillin' all alone  \nJust hit the Eastside of the " + Words[5] + " \nOn a mission trying to find Mr.Warren G.  \n";

                    string realLyrics = "Here are the real lyrics-- Regulate by Nate Dogg and Warren G \nRegulators, mount up... \nIt was a clear black night, a clear white moon. \nWarren G was on the street, trying to consume  \nSome skirts for the eve so I can get some funk \nJust rollin' in my ride, chillin' all alone  \nJust hit the Eastside of the  LBC  \nOn a mission trying to find Mr.Warren G.  \n";

                    ShowMadLib(madLib);
                    ShowRealLyrics(realLyrics);

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


        //Ask for user input-- pull from part of speech list, add response to same index in an array
        public static void ShowMadLib(string madLib)
            {
                Console.WriteLine(madLib);
            }

        //Method for gathering user input, comparing 
        public static void GatherWords(List<string> partsOfSpeech, string[] Words)
        {
            //Regex for pattern matching to ensure user input is alpha and at least 2 characters long
            RegexOptions options = RegexOptions.IgnoreCase;
            Regex inputValidation = new Regex("^[a-z]{2,}$", options);

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
        }

        //Writes real lyrics to the console if user inputs y
        public static void ShowRealLyrics(string realLyrics)
        {
            Console.WriteLine("Would you like to see the real lyics?  Y or N:  ");
            string displayRealLyrics = Console.ReadLine().ToLower();
            if (displayRealLyrics is "y" or "yes")
            {
                Console.WriteLine(realLyrics);
            }
            else
            {
                return;
            }
        }

    }
}

using System;
using System.Collections.Generic;


namespace MadLib
{
    public class MadLibMFOY
    {
        public MadLibMFOY()
        {
            //List for holding the parts of speech we need
            List<string> partsOfSpeech = new List<string>();
            partsOfSpeech.Add("a body part:  ");
            partsOfSpeech.Add("a plural noun:  ");
            partsOfSpeech.Add("a verb:  ");
            partsOfSpeech.Add("another verb:  ");

            //Array for holding user input
            string[] Words = { "", "", "", "" };

            //Loop to iterate through each part of speech, take the user input and add it to a list
            for (int i = 0; i < Words.Length; i++)
            {
                Console.WriteLine("Please give me " + partsOfSpeech[i]);
                Words[i] = Console.ReadLine();
            }

            string myFriendsMadLib = "You were everything I wanted \n" +
                                                        "But I, just can't finish what I've started \n" +
                                                        "There's no room left here on my " + Words[0] + " \n" +
                                                        "It was damaged long ago \n" +
                                                        "Though you swear that you are true \n" +
                                                        "I still pick my  " + Words[1] + "   over you \n" +
                                                        "(My " + Words[1] + "  over you) \n" +
                                                        "Please tell me everything \n" +
                                                        "That you think that I should " + Words[2] + " \n" +
                                                       "About all the plans you made \n" +
                                                        "When I was nowhere to be found \n" +
                                                        "And it's all right to forget \n" +
                                                        "That we still " + Words[3] + " \n" +
                                                        "It's just for fun, isn't it? \n" +
                                                       "It's my fault that it fell apart \n" +
                                                        "'Cause maybe ('cause maybe) \n" +
                                                        "You need this(you need this) \n" +
                                                        "And I didn't (and I didn't) \n" +
                                                        "Mean to \n" +
                                                        "Lead you on \n" +
                                                        "You were everything I wanted \n" +
                                                        "But I just can't finish what I've started \n" +
                                                        "There's no room left here on my  " + Words[0] + " \n" +
                                                        "It was damaged long ago \n" +
                                                        "Though you swear that you are true \n" +
                                                        "I still pick my " + Words[1] + " over you \n" +
                                                        "(My " + Words[1] + " over you) \n";

            Console.WriteLine(myFriendsMadLib);
        }


        public static void RealLyricsMFOY()
        {
            string myFriendsOverYou = "Here are the real lyrics-- My Friends Over You by New Found Glory \n" +
                                                        "You were everything I wanted \n" +
                                                        "But I, just can't finish what I've started \n" +
                                                        "There's no room left here on my back \n" +
                                                        "It was damaged long ago \n" +
                                                        "Though you swear that you are true \n" +
                                                        "I still pick my friends over you \n" +
                                                        "(My friends over you) \n" +
                                                        "Please tell me everything \n" +
                                                        "That you think that I should know \n" +
                                                       "About all the plans you made \n" +
                                                        "When I was nowhere to be found \n" +
                                                        "And it's all right to forget \n" +
                                                        "That we still talk \n" +
                                                        "It's just for fun, isn't it? \n" +
                                                       "It's my fault that it fell apart \n" +
                                                        "'Cause maybe ('cause maybe) \n" +
                                                        "You need this(you need this) \n" +
                                                        "And I didn't (and I didn't) \n" +
                                                        "Mean to \n" +
                                                        "Lead you on \n" +
                                                        "You were everything I wanted \n" +
                                                        "But I just can't finish what I've started \n" +
                                                        "There's no room left here on my back \n" +
                                                        "It was damaged long ago \n" +
                                                        "Though you swear that you are true \n" +
                                                        "I still pick my friends over you \n" +
                                                        "(My friends over you) \n";

            Console.WriteLine(myFriendsOverYou);
        }
    }
}

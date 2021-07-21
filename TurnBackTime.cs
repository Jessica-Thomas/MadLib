using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace MadLib
{
    public class TurnBackTime
    {
        public TurnBackTime()
        {
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

            string madLib = "If I could " + Words[0] + " back time \n" +
                            "If I could find a way \n" +
                            "I'd take back those " + Words[1] + " that've hurt you and you'd stay \n" +
                            "I don't know why I did the things I did \n" +
                            "I don't know why I said the things I said \n" +
                            "Pride's like a knife, it can cut deep inside \n" +
                            Words[2] + " are like weapons, they " + Words[3] + " sometimes \n" +
                            "I didn't really mean to " + Words[4] + " you \n" +
                            "I didn't wanna see you go \n" +
                            "I know I made you cry, but baby \n" +
                            "If I could  " + Words[0] + "  back time, if I could find a way \n" +
                            "I'd take back those " + Words[5] + " that've hurt you, you'd stay \n" +
                            "If I could reach the stars, I'd give 'em all to you \n" +
                            "Then you'd love me, love me, like you used to do \n" +
                            "If I could  " + Words[0] + "  back time \n";

            string realLyrics = "Here are the real lyrics--If I Could Turn Back Time by Cher: \n" +
                                "If I could turn back time \n" +
                                "If I could find a way \n" +
                                "I'd take back those words that've hurt you and you'd stay \n" +
                                "I don't know why I did the things I did \n" +
                                "I don't know why I said the things I said \n" +
                                "Pride's like a knife, it can cut deep inside \n" +
                                "Words are like weapons, they wound sometimes \n" +
                                "I didn't really mean to hurt you \n" +
                                "I didn't wanna see you go \n" +
                                "I know I made you cry, but baby \n" +
                                "If I could turn back time, if I could find a way \n" +
                                "I'd take back those words that've hurt you, you'd stay \n" +
                                "If I could reach the stars, I'd give 'em all to you \n" +
                                "Then you'd love me, love me, like you used to do \n" +
                                "If I could turn back time \n";

            Input.GetInput getInput = new();
            Input.DisplayMadLib displayMadLib = new();
            Input.DisplayRealLyrics displayRealLyrics = new();
        }
    }
}

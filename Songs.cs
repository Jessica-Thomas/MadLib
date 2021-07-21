using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MadLib
{
    public class Songs
    {

            static void MyFriendsOverYou()
            {

                //List for holding the parts of speech we need
                //Adding in the parts of speech needed for this mad lib
                List<string> partsOfSpeech = new();
                partsOfSpeech.Add("a body part:  ");
                partsOfSpeech.Add("a plural noun:  ");
                partsOfSpeech.Add("a verb:  ");
                partsOfSpeech.Add("another verb:  ");

                //Initialize empty array for holding user input
                string[] Words = new string[4];


                string madLib = $"You were everything I wanted \nBut I, just can't finish what I've started \nThere's no room left here on my {Words[0]} \nIt was damaged long ago \nThough you swear that you are true \nI still pick my  {Words[1]}   over you \n(My {Words[1]}  over you) \nPlease tell me everything \nThat you think that I should {Words[2]} \nAbout all the plans you made \nWhen I was nowhere to be found \nAnd it's all right to forget \nThat we still {Words[3]} \nIt's just for fun, isn't it? \nIt's my fault that it fell apart \n'Cause maybe ('cause maybe) \nYou need this(you need this) \nAnd I didn't (and I didn't) \nMean to \nLead you on \nYou were everything I wanted \nBut I just can't finish what I've started \nThere's no room left here on my  {Words[0]} \nIt was damaged long ago \nThough you swear that you are true \nI still pick my {Words[1]} over you \n(My {Words[1]} over you) \n";


                string realLyrics = "Here are the real lyrics-- My Friends Over You by New Found Glory \n"
                                    + "You were everything I wanted \n"
                                    + "But I, just can't finish what I've started \n"
                                    + "There's no room left here on my back \n"
                                    + "It was damaged long ago \n"
                                    + "Though you swear that you are true \n"
                                    + "I still pick my friends over you \n"
                                    + "(My friends over you) \n"
                                    + "Please tell me everything \n"
                                    + "That you think that I should know \n"
                                    + "About all the plans you made \n"
                                    + "When I was nowhere to be found \n"
                                    + "And it's all right to forget \n"
                                    + "That we still talk \n"
                                    + "It's just for fun, isn't it? \n"
                                    + "It's my fault that it fell apart \n"
                                    + "'Cause maybe ('cause maybe) \n"
                                    + "You need this(you need this) \n"
                                    + "And I didn't (and I didn't) \n"
                                    + "Mean to \n"
                                    + "Lead you on \n"
                                    + "You were everything I wanted \n"
                                    + "But I just can't finish what I've started \n"
                                    + "There's no room left here on my back \n"
                                    + "It was damaged long ago \n"
                                    + "Though you swear that you are true \n"
                                    + "I still pick my friends over you \n"
                                    + "(My friends over you) \n";

            }


            static void TurnBackTime()
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

                //Concatenation and adding user input via indexing the array
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

            }


            static void Regulate()
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

            }

    }
}

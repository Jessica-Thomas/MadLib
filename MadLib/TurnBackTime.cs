using System;
namespace MadLib
{
    public class TurnBackTime
    {
        public TurnBackTime()
        {
            Console.WriteLine("Please give me a verb:  ");
            string verb = Console.ReadLine();

            Console.WriteLine("Please give me a plural noun:  ");
            string pluralNoun = Console.ReadLine();

            Console.WriteLine("Please give me a noun:  ");
            string noun = Console.ReadLine();

            Console.WriteLine("Please give me a verb:  ");
            string verb2 = Console.ReadLine();

            Console.WriteLine("Please give me a verb:  ");
            string verb3 = Console.ReadLine();

            Console.WriteLine("Please give me a plural noun:  ");
            string pluralNoun2 = Console.ReadLine();


            string timeMadLib = "If I could " + verb + " back time \n" +
                                              "If I could find a way \n" +
                                              "I'd take back those " + pluralNoun + " that've hurt you and you'd stay \n" +
                                              "I don't know why I did the things I did \n" +
                                              "I don't know why I said the things I said \n" +
                                              "Pride's like a knife, it can cut deep inside \n" +
                                              noun + " are like weapons, they " + verb2 + " sometimes \n" +
                                              "I didn't really mean to " + verb3 + " you \n" +
                                              "I didn't wanna see you go \n" +
                                              "I know I made you cry, but baby \n" +
                                              "If I could turn back time, if I could find a way \n" +
                                              "I'd take back those " + pluralNoun2 + " that've hurt you, you'd stay \n" +
                                              "If I could reach the stars, I'd give 'em all to you \n" +
                                              "Then you'd love me, love me, like you used to do \n" +
                                              "If I could turn back time \n";


            Console.WriteLine(timeMadLib);

            string turnBackTime = "Here are the real lyrics--If I Could Turn Back Time by Cher: \n" +
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


            Console.WriteLine(turnBackTime);

        }
    }
}

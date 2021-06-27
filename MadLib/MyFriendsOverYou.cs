using System;
namespace MadLib
{
    public class MyFriendsOverYou
    {

        public MyFriendsOverYou()
        {
            Console.WriteLine("Please give me a body part:  ");
            string bodyPart = Console.ReadLine();

            Console.WriteLine("Please give me a plural noun:  ");
            string pluralNoun = Console.ReadLine();

            Console.WriteLine("Please give me a verb:  ");
            string verb = Console.ReadLine();

            Console.WriteLine("Please give me a verb:  ");
            string verb2 = Console.ReadLine();

            string myFriendsMadLib = "You were everything I wanted \n" +
                                                        "But I, just can't finish what I've started \n" +
                                                        "There's no room left here on my " + bodyPart +" \n" +
                                                        "It was damaged long ago \n" +
                                                        "Though you swear that you are true \n" +
                                                        "I still pick my  " + pluralNoun + "   over you \n" +
                                                        "(My " + pluralNoun + "  over you) \n" +
                                                        "Please tell me everything \n" +
                                                        "That you think that I should " + verb +" \n" +
                                                       "About all the plans you made \n" +
                                                        "When I was nowhere to be found \n" +
                                                        "And it's all right to forget \n" +
                                                        "That we still " + verb2 +" \n" +
                                                        "It's just for fun, isn't it? \n" +
                                                       "It's my fault that it fell apart \n" +
                                                        "'Cause maybe ('cause maybe) \n" +
                                                        "You need this(you need this) \n" +
                                                        "And I didn't (and I didn't) \n" +
                                                        "Mean to \n" +
                                                        "Lead you on \n" +
                                                        "You were everything I wanted \n" +
                                                        "But I just can't finish what I've started \n" +
                                                        "There's no room left here on my  " + bodyPart + " \n" +
                                                        "It was damaged long ago \n" +
                                                        "Though you swear that you are true \n" +
                                                        "I still pick my " + pluralNoun + " over you \n" +
                                                        "(My " + pluralNoun + " over you) \n";

            Console.WriteLine(myFriendsMadLib);

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

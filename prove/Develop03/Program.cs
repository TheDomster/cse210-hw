// Showing Creativity and Exceeding Requirements:
// 1. Created 10 scripture mastery verses from each of the standard works, plus the Pearl of Great Price. 
//    Each book has both a single and double verse.
// 2. Improved process of hiding words so no words are hidden more than once.
// 3. If the user mistypes the word "quit", the program will let the user try again.
using System;
using System.Collections.Generic;

public class Program
{
    public static void Main(string[] args) // this is a method - start of the program (no attributes in Program)
    {
        // this is a behavior - list that holds the Seminary Scripture Mastery verses
        List<Scripture> scriptureLibrary = new List<Scripture>();

        // Old Testament - 1 Verse
        Reference ref1 = new Reference("Amos", 3, 7);
        Scripture mastery1 = new Scripture(ref1, "Surely the Lord God will do nothing, but he revealeth his secret unto his servants the prophets.");
        scriptureLibrary.Add(mastery1);

        // Old Testament - 2 Verses
        Reference ref2 = new Reference("Proverbs", 3, 5, 6);
        Scripture mastery2 = new Scripture(ref2, "Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths.");
        scriptureLibrary.Add(mastery2);

        // New Testament - 1 Verse
        Reference ref3 = new Reference("John", 3, 16);
        Scripture mastery3 = new Scripture(ref3, "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.");
        scriptureLibrary.Add(mastery3);

        // New Testament - 2 Verses
        Reference ref4 = new Reference("James", 1, 5, 6);
        Scripture mastery4 = new Scripture(ref4, "If any of you lack wisdom, let him ask of God, that giveth to all men liberally, and upbraideth not; and it shall be given him. But let him ask in faith, nothing wavering. For he that wavereth is like a wave of the sea driven with the wind and tossed.");
        scriptureLibrary.Add(mastery4);

        // Book of Mormon - 1 Verse
        Reference ref5 = new Reference("Mosiah", 2, 17);
        Scripture mastery5 = new Scripture(ref5, "And behold, I tell you these things that ye may learn wisdom; that ye may learn that when ye are in the service of your fellow beings ye are only in the service of your God.");
        scriptureLibrary.Add(mastery5);

        // Book of Mormon - 2 Verses
        Reference ref6 = new Reference("Moroni", 10, 4, 5);
        Scripture mastery6 = new Scripture(ref6, "And when ye shall receive these things, I would exhort you that ye would ask God, the Eternal Father, in the name of Christ, if these things are not true; and if ye shall ask with a sincere heart, with real intent, having faith in Christ, he will manifest the truth of it unto you, by the power of the Holy Ghost. And by the power of the Holy Ghost ye may know the truth of all things.");
        scriptureLibrary.Add(mastery6);

        // Doctrine and Covenants - 1 Verse
        Reference ref7 = new Reference("Doctrine and Covenants", 82, 10);
        Scripture mastery7 = new Scripture(ref7, "I, the Lord, am bound when ye do what I say; but when ye do not what I say, ye have no promise.");
        scriptureLibrary.Add(mastery7);

        // Doctrine and Covenants - 2 Verses
        Reference ref8 = new Reference("Doctrine and Covenants", 8, 2, 3);
        Scripture mastery8 = new Scripture(ref8, "Yea, behold, I will tell you in your mind and in your heart, by the Holy Ghost, which shall come upon you and which shall dwell in your heart. Now, behold, this is the spirit of revelation; behold, this is the spirit by which Moses brought the children of Israel through the Red Sea on dry ground.");
        scriptureLibrary.Add(mastery8);

        // Pearl of Great Price - 1 Verse
        Reference ref9 = new Reference("Moses", 7, 18);
        Scripture mastery9 = new Scripture(ref9, "And the Lord called his people Zion, because they were of one heart and one mind, and dwelt in righteousness; and there was no poor among them.");
        scriptureLibrary.Add(mastery9);

        // Pearl of Great Price - 2 Verses
        Reference ref10 = new Reference("Abraham", 3, 22, 23);
        Scripture mastery10 = new Scripture(ref10, "Now the Lord had shown unto me, Abraham, the intelligences that were organized before the world was; and among all these there were many of the noble and great ones; And God saw these souls that they were good, and he stood in the midst of them, and he said: These I will make my rulers; for he stood among those that were spirits, and he saw that they were good; and he said unto me: Abraham, thou art one of them; thou wast chosen before thou wast born.");
        scriptureLibrary.Add(mastery10);

        // Randomly pick one
        Random picker = new Random();
        int randomIndex = picker.Next(scriptureLibrary.Count);
        Scripture chosenScripture = scriptureLibrary[randomIndex];

        string userInput = "";
        bool isFinished = false;

        // Loop continues until user quits or all verses are hidden
        while (userInput != "quit" && userInput != "Quit" && userInput != "QUIT" && isFinished == false)
        {
            Console.Clear();
            Console.WriteLine(chosenScripture.DisplayScripture());
            Console.WriteLine();

            if (chosenScripture.AllWordsHidden() == true)
            {
                isFinished = true;
            }
            else
            {
                Console.WriteLine("Press enter to continue or type 'quit' to finish:");
                userInput = Console.ReadLine();

                // this is a behavior: checks if the user typed an incorrect word and lets them try again
                while (userInput != "" && userInput != "quit" && userInput != "Quit" && userInput != "QUIT")
                {
                    Console.WriteLine("You have typed the wrong word. Please press enter to continue or type 'quit' to finish:");
                    userInput = Console.ReadLine();
                }

                if (userInput == "")
                {
                    chosenScripture.HideRandomWords(3);
                }
            }
        }
    }
    
}
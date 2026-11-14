// Student: Dominic Emilio Clemence
// Class: CSE210 Section A3
// Assignment: Prove - Developer 2
// For creativity points I've done 3 things:
// 1. A user can either enter the number or word of the menu option
// 2. If the user enters "2 Display" before writing an entry a message reads "There are no entries yet"
// 3. I have added 3 additional prompt questions

using System;

public class Program {
    public static void Main(String[] args)
    {
        Console.WriteLine("Welcome to your Daily Journal!");

        Journal myJournal = new Journal(); // This creates a Journal Object

        PromptGenerator questionPicker = new PromptGenerator(); // This creates a PromptGenerator Object

        string selection = ""; // holds user's selection

        while (selection != "5" && selection != "Quit" && selection != "quit" && selection != "QUIT")
        {
            // This is the menu that'll be shown. It will be in a loop until "Quit" is chosen
            Console.WriteLine("Please select one of the following options:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Save");
            Console.WriteLine("4. Load");
            Console.WriteLine("5. Quit");

            Console.WriteLine("What is your preferred option? ");
            Console.Write("> ");
            selection = Console.ReadLine();

            if (selection == "1" || selection == "Write" || selection == "write" || selection == "WRITE")
            {
                Entry myEntry = new Entry(); // Entry Object.. Like a digital page

                DateTime currentDate = DateTime.Now;
                int month = currentDate.Month;
                int day = currentDate.Day;
                int year = currentDate.Year;
                myEntry._date = month + "/" + day + "/" + year;
                myEntry._question = questionPicker.GetRandomPrompt(); // asking for a random question within myEntry
                Console.WriteLine(myEntry._question);

                Console.Write("> ");
                myEntry._answer = Console.ReadLine(); // user's response
                myJournal.AddPost(myEntry); // putting the post in the journal
}
            else if (selection == "2" || selection == "Display" || selection == "display" || selection == "DISPLAY")
            {
                myJournal.ShowAll();
            }
            
            else if (selection == "3" || selection == "Save" || selection == "save" || selection == "SAVE")
            {
                Console.WriteLine("What is the filename?");
                string fileName = Console.ReadLine();
                myJournal.SaveJournal(fileName);
            }

            else if (selection == "4" || selection == "Load" || selection == "load" || selection == "LOAD")
            {
                Console.WriteLine("What is the filename?");
                string fileName = Console.ReadLine();
                myJournal.LoadJournal(fileName);
            }

            else if (selection == "5" || selection == "Quit" || selection == "quit" || selection == "QUIT")
            {
                Console.WriteLine("Thanks for writing in your journal today!");
            }
            
        }
    }
    
}
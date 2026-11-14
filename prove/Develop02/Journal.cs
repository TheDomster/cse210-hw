using System;
using System.Collections.Generic;
using System.IO; // Saving and Loading tools

public class Journal
{
    public List<Entry> _posts = new List<Entry>(); // This holds the entry pages

    public void AddPost(Entry myEntry) // Method to add the page to the _posts list
    {
        _posts.Add(myEntry);
    }

    public void ShowAll() // Shows all pages
    {
        if (_posts.Count == 0)
        {
            Console.WriteLine("You have not entered anything yet.");
        }
        else
        {
            foreach (Entry myEntry in _posts) // Loops through the pages on the list
            {
                myEntry.Show();
            }
        }
    }

        public void SaveJournal(string fileName) // Saves the pages to a file
    {
        using (StreamWriter writer = new StreamWriter(fileName)) // Opens the file
        {
            foreach (Entry myEntry in _posts)
            {
                writer.WriteLine(myEntry._date + "~~" + myEntry._question + "~~" + myEntry._answer);
            }
        }
        Console.WriteLine("Your journal posts have been saved!");
    }

        public void LoadJournal(string fileName) // Loads pages from a saved file
    {
        _posts.Clear(); // Clears old pages first
        string[] lines = File.ReadAllLines(fileName);

        foreach (string line in lines)
        {
            string[] pieces = line.Split("~~"); 

            Entry myEntry = new Entry();
            myEntry._date = pieces[0];
            myEntry._question = pieces[1];
            myEntry._answer = pieces[2];

            _posts.Add(myEntry);
        }

        ShowAll(); // Shows the pages
    }
}
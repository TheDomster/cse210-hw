using System;
using System.Collections.Generic;

public class ListingExercise : BaseActivity
{
    private List<string> _listingPrompts = new List<string>(); // This is an attribute that holds listing prompts
    private Random _randomGen = new Random(); // This is an attribute for picking a random prompt
    private int _responseCount; // This is an attribute that stores how many items the user entered

    public ListingExercise() // This is a constructor that sets up ListingExercise
        : base("Listing", "This helps you see the blessings in your life by listing them. ")
    {
        _responseCount = 0; // This is a behavior that resets _responseCount and loads the prompts

        _listingPrompts.Add("Who are people that you appreciate? ");
        _listingPrompts.Add("What are personal strengths of yours? ");
        _listingPrompts.Add("Who are people that you have helped this week? ");
        _listingPrompts.Add("When have you felt the Holy Ghost this month? ");
        _listingPrompts.Add("Who are some of your personal heroes? ");
        _listingPrompts.Add("What blessings have you received for obeying the commandments? ");
        _listingPrompts.Add("Name a few things you are grateful for. ");
        _listingPrompts.Add("What talents do you have? ");
    }

    public List<string> CollectResponses() // This is a method that gets items from the user
    {
        List<string> userItems = new List<string>();
        DateTime startTime = DateTime.Now;
        DateTime stopTime = startTime.AddSeconds(GetTotalSeconds());

        while (DateTime.Now < stopTime) // This is a behavior that saves each line with content until time ends
        {
            Console.Write("> ");
            string entry = Console.ReadLine();

            if (entry != "")
            {
                userItems.Add(entry);
            }
        }

        return userItems;
    }

    public string GetRandomPrompt() // This is a method that picks a random prompt
    {
        int promptIndex = _randomGen.Next(_listingPrompts.Count); // This is a behavior that returns one random prompt
        return _listingPrompts[promptIndex];
    }

    public void StartListing() // This is a method that runs the listing activity
    {
        ShowWelcomeMessage(); // This is a behavior that shows the prompt, gets responses, counts them, and ends

        Console.WriteLine("List as many as you can to the following prompt:");
        Console.WriteLine($" --- {GetRandomPrompt()} --- ");
        Console.Write("You may begin in: ");
        DisplayCountdown(5);
        Console.WriteLine();

        List<string> userResponses = CollectResponses();
        _responseCount = userResponses.Count;

        Console.WriteLine($"You listed {_responseCount} items!");

        ShowClosingMessage();
    }
}

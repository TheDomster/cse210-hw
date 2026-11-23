using System;
using System.Collections.Generic;
using System.Threading;

public class BaseActivity
{
    private int _totalSeconds; // This is an attribute for the session length
    private string _exerciseName; // This is an attribute for the activity name
    private string _activityDescription; // This is an attribute for the activity description

    public BaseActivity(string exerciseName, string activityDescription) // This is a constructor that sets up base activity info
    {
        _totalSeconds = 0; // This is a behavior that initializes the base attributes
        _exerciseName = exerciseName;
        _activityDescription = activityDescription;
    }

    public void DisplayCountdown(int totalSeconds) // This is a method that shows the countdown timer
    {
        for (int remaining = totalSeconds; remaining > 0; remaining--) // This is a behavior that counts down one second at a time
        {
            Console.Write(remaining);
            Thread.Sleep(1000); // 1000 milliseconds = 1 second
            Console.Write("\b \b");

            if (remaining >= 10)
            {
                Console.Write("\b \b"); // Moves back cursor for two digit numbers
            }
        }
    }

    public void DisplaySpinner(int durationSeconds) // This is a method that displays a spinning animation
    {
        List<string> animationSymbols = new List<string>(); // This is a behavior that cycles spinner symbols until time ends
        animationSymbols.Add("|");
        animationSymbols.Add("/");
        animationSymbols.Add("-");
        animationSymbols.Add("\\");

        DateTime startTime = DateTime.Now;
        DateTime stopTime = startTime.AddSeconds(durationSeconds);

        int position = 0;
        while (DateTime.Now < stopTime)
        {
            string currentChar = animationSymbols[position];
            Console.Write(currentChar);
            Thread.Sleep(250);
            Console.Write("\b \b");

            position++;
            if (position >= animationSymbols.Count)
            {
                position = 0;
            }
        }
    }

    public void ShowWelcomeMessage() // This is a method that shows the welcome message
    {
        Console.Clear(); // This is a behavior that prints the intro, saves the duration, and pauses
        Console.WriteLine($"Welcome to the {_exerciseName} Activity.");
        Console.WriteLine();
        Console.WriteLine(_activityDescription);
        Console.WriteLine();

        Console.Write("How long, in seconds, would you like for your session? ");
        string response = Console.ReadLine();
        _totalSeconds = int.Parse(response);

        Console.Clear();
        Console.WriteLine("Get ready...");
        DisplaySpinner(4);
        Console.WriteLine();
    }

    public void ShowClosingMessage() // This is a method that shows the closing message
    {
        Console.WriteLine(); // This is a behavior that congratulates the user and shows the completed time
        Console.WriteLine("Well done!!");
        DisplaySpinner(3);
        Console.WriteLine();
        Console.WriteLine($"You have completed a total of {_totalSeconds} seconds of the {_exerciseName} Activity.");
        DisplaySpinner(4);
    }

    public int GetTotalSeconds() // This is a method that returns the duration
    {
        return _totalSeconds; // This is a behavior that gets _totalSeconds
    }

    public string GetExerciseName() // This is a method that returns the activity name
    {
        return _exerciseName; // This is a behavior that gets _exerciseName
    }
}

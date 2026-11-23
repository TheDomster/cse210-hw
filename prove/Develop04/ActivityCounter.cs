using System;

public class ActivityCounter
{
    private int _listingCompleted; // This is an attribute that counts the listing activities
    private int _breathingCompleted; // This is an attribute that counts the breathing activities
    private int _reflectingCompleted; // This is an attribute that counts the reflecting activities

    public ActivityCounter() // This is a constructor that sets all counts to 0
    {
        _listingCompleted = 0; // This is a behavior that starts the counters
        _breathingCompleted = 0;
        _reflectingCompleted = 0;
    }

    public void PrintSummary() // This is a method that shows the activity log
    {
        Console.Clear(); // This is a behavior that calculates totals and shows the log
        Console.WriteLine("Activity Log");
        Console.WriteLine();

        int totalSessions = _breathingCompleted + _reflectingCompleted + _listingCompleted;

        if (totalSessions == 0)
        {
            Console.WriteLine("You have not completed any activities yet.");
        }
        else
        {
            Console.WriteLine($"Breathing Activity: {_breathingCompleted} time(s)");
            Console.WriteLine($"Reflecting Activity: {_reflectingCompleted} time(s)");
            Console.WriteLine($"Listing Activity: {_listingCompleted} time(s)");
            Console.WriteLine();
            Console.WriteLine($"Total activities completed: {totalSessions}");
        }

        Console.WriteLine();
        Console.Write("Press enter to return to the menu ");
        Console.ReadLine();
    }

    public void TrackActivity(string exerciseName) // This is a method that records a completed activity
    {
        if (exerciseName == "Breathing") // This is a behavior that adds 1 to the matching counter
        {
            _breathingCompleted++;
        }
        else if (exerciseName == "Reflecting")
        {
            _reflectingCompleted++;
        }
        else if (exerciseName == "Listing")
        {
            _listingCompleted++;
        }
    }
}
// For the Creativity or Stretch Challenge I have:
// Added an ActivityCounter class to record how many times each activity was performed

using System;

public class Program
{
    public static void Main(string[] args) // This is a method that starts the program
    {
        string menuOption = ""; // This is a behavior that creates the menu
        ActivityCounter activityCounter = new ActivityCounter(); // This is a behavior that logs completed activities

        while (menuOption != "5") // This is a behavior that loops the menu until the user quits
        {
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Breathing activity");
            Console.WriteLine("  2. Reflecting activity");
            Console.WriteLine("  3. Listing activity");
            Console.WriteLine("  4. View activity log");
            Console.WriteLine("  5. Quit");
            Console.Write("Select a choice from the menu: ");

            menuOption = Console.ReadLine();

            if (menuOption == "1") // This is a behavior that runs and records the breathing activity
            {
                BreathingExercise breathActivity = new BreathingExercise();
                breathActivity.StartBreathing();
                activityCounter.TrackActivity(breathActivity.GetExerciseName());
            }

            else if (menuOption == "2") // This is a behavior that runs and logs the reflecting activity
            {
                ReflectingExercise reflectActivity = new ReflectingExercise();
                reflectActivity.StartReflecting();
                activityCounter.TrackActivity(reflectActivity.GetExerciseName());
            }

            else if (menuOption == "3") // This is a behavior that runs and records the listing activity
            {
                ListingExercise listActivity = new ListingExercise();
                listActivity.StartListing();
                activityCounter.TrackActivity(listActivity.GetExerciseName());
            }

            else if (menuOption == "4") // This is a behavior that shows the activity log
            {
                activityCounter.PrintSummary();
            }

            else if (menuOption != "5") // This is a behavior that manages incorrect menu choices
            {
                Console.WriteLine("That is an incorrect choice. Please choose a number from 1 to 5. ");
                Console.Write("Press enter to continue. ");
                Console.ReadLine();
            }
        }
    }
}
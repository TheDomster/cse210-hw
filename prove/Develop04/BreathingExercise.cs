using System;

public class BreathingExercise : BaseActivity
{
    public void StartBreathing() // This is a method that runs the breathing activity
    {
        ShowWelcomeMessage(); // This is a behavior that starts the activity

        DateTime startTime = DateTime.Now;
        DateTime stopTime = startTime.AddSeconds(GetTotalSeconds());

        while (DateTime.Now < stopTime) // This is a behavior that goes between breathing in and out until the set time is completed
        {
            Console.WriteLine();
            Console.Write("Breathe in.....");
            DisplayCountdown(4);
            Console.WriteLine();

            if (DateTime.Now < stopTime) // This is a behavior that checks time before exhaling
            {
                Console.Write("Now breathe out.....");
                DisplayCountdown(6);
                Console.WriteLine();
            }
        }

        ShowClosingMessage(); // This is a behavior that ends the activity
    }

    public BreathingExercise() // This constructor sends name and description to BaseActivity
        : base("Breathing", "This will help you relax by guiding your breathing in and out slowly. Relax and enjoy the moment. You may close your eyes. Let's begin. ")
    {
    }
}

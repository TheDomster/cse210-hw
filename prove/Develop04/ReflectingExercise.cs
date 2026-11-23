using System;
using System.Collections.Generic;

public class ReflectingExercise : BaseActivity
{
    private Random _randomGen = new Random(); // This is an attribute to pick random prompts and questions
    private List<string> _reflectionQuestions = new List<string>(); // This is an attribute that holds reflection questions
    private List<string> _reflectionPrompts = new List<string>(); // This is an attribute that holds reflection prompts

    public ReflectingExercise() // This is a constructor that sets up ReflectingExercise
        : base("Reflecting", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.")
    {
        _reflectionQuestions.Add("Why was this experience meaningful to you?"); // This is a behavior that loads the questions
        _reflectionQuestions.Add("Have you ever done anything like this before?");
        _reflectionQuestions.Add("How did you get started?");
        _reflectionQuestions.Add("How did you feel when it was complete?");
        _reflectionQuestions.Add("What made this time different than other times when you were not as successful?");
        _reflectionQuestions.Add("What is your favorite thing about this experience?");
        _reflectionQuestions.Add("What could you learn from this experience that applies to other situations?");
        _reflectionQuestions.Add("What did you learn about yourself through this experience?");
        _reflectionQuestions.Add("How can you keep this experience in mind in the future?");

        _reflectionPrompts.Add("Think of a time when you stood up for someone else."); // This is a behavior that loads the prompts
        _reflectionPrompts.Add("Think of a time when you did something really difficult.");
        _reflectionPrompts.Add("Think of a time when you helped someone in need.");
        _reflectionPrompts.Add("Think of a time when you did something truly selfless.");
        _reflectionPrompts.Add("Think of a time when you secretly helped someone.");
        _reflectionPrompts.Add("Think of a time when you felt proud of yourself.");
        _reflectionPrompts.Add("Think of a time when you were kind to an animal");
    }

    public string SelectRandomQuestion() // This is a method that picks a random question
    {
        int questionIndex = _randomGen.Next(_reflectionQuestions.Count); // This is a behavior that returns one random question
        return _reflectionQuestions[questionIndex];
    }

    public string SelectRandomPrompt() // This is a method that picks a random prompt
    {
        int promptIndex = _randomGen.Next(_reflectionPrompts.Count); // This is a behavior that returns one random prompt
        return _reflectionPrompts[promptIndex];
    }

    public void AskReflectionQuestions() // This is a method that shows questions until time runs out
    {
        DateTime startTime = DateTime.Now;
        DateTime stopTime = startTime.AddSeconds(GetTotalSeconds());

        while (DateTime.Now < stopTime) // This is a behavior that displays random questions with a spinner
        {
            string currentQuestion = SelectRandomQuestion();
            Console.Write($"> {currentQuestion} ");
            DisplaySpinner(10);
            Console.WriteLine();
        }
    }

    public void ShowPrompt() // This is a method that shows a random prompt
    {
        Console.WriteLine("Consider the following moment in your life: "); // This is a behavior that prints the prompt and waits for Enter to be pressed
        Console.WriteLine();
        Console.WriteLine($" --- {SelectRandomPrompt()} --- ");
        Console.WriteLine();
        Console.WriteLine("When something comes to mind, press enter to continue. ");
        Console.ReadLine();
    }

    public void StartReflecting() // This is a method that runs the reflecting activity
    {
        ShowWelcomeMessage(); // This is a behavior that runs the prompt, countdown, questions, and ending
        ShowPrompt();

        Console.WriteLine();
        Console.WriteLine("Now think about the following questions related to this experience. ");
        Console.Write("You may begin in: ");
        DisplayCountdown(5);

        Console.Clear();
        AskReflectionQuestions();

        ShowClosingMessage();
    }
}

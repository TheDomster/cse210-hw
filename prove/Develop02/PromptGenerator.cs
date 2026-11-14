using System;
using System.Collections.Generic; // This is for lists

public class PromptGenerator
{
    public List<string> _questions = new List<string>();

    public string GetRandomPrompt()
    {
        if (_questions.Count == 0)
        {
            _questions.Add("Who was the most interesting person I interacted with today? ");
            _questions.Add("What was the best part of my day? ");
            _questions.Add("How did I see the hand of the Lord in my life today? ");
            _questions.Add("What was the strongest emotion I felt today? ");
            _questions.Add("If I had one thing I could do over today, what would it be? ");
            _questions.Add("Have you done any good in the world today? ");
            _questions.Add("When was the last time you exercised?");
            _questions.Add("What was your favorite talk from the last General Conference?");
        }

        Random picker = new Random();
        int randomNumber = picker.Next(_questions.Count);
        return _questions[randomNumber];

    }
       
}



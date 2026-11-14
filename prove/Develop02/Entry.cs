using System;

public class Entry
{
    public string _date;
    public string _question;
    public string _answer;

    public void Show()
    {
        Console.WriteLine("Date: " + _date + " - Prompt: " + _question);
        Console.WriteLine(_answer);
        Console.WriteLine();
    }
}
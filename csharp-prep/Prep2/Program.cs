// Student: Dominic Emilio Clemence
// Class: CSE210 Section A3
// Assignment: C# Prep 2

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What grade percentage do you have? ");
        string answer = Console.ReadLine();
        int percent = int.Parse(answer);

        string letter = "";

        if (percent >= 90)
        {
            letter = "A";
        }
        else if (percent >= 80)
        {
            letter = "B";
        }
        else if (percent >= 70)
        {
            letter = "C";
        }
        else if (percent >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        Console.WriteLine($"Your final grade is: {letter}");
        
        if (percent >= 70)
        {
            Console.WriteLine("You have passed!");
        }
        else
        {
            Console.WriteLine("Keep trying!");
        }
    }
}
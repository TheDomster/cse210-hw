using System;

public class Word
{
    private string _wordText; // this is an attribute
    private bool _hiddenWord; // this is an attribute

    public Word(string wordText) // constructor starts
    {
        _wordText = wordText;
        _hiddenWord = false; // this is a behavior - makes the words visible at start
    }

    public void Hide() // method
    {
        _hiddenWord = true; // this is a behavior - the word is hidden
    }

    public void Show() // this is a method
    {
        _hiddenWord = false; // this is a behavior - makes the word visible again
    }

    public bool IsHidden() // this is a method - DO NOT USE CAMEL CASE HERE!
    {
        return _hiddenWord; // behavior - checks if hidden
    }

    public string DisplayWord() // this is a method
    {
        if (_hiddenWord == true) // this is a behavior - word is hidden so show underscores
        {
            string hiddenText = "";
            for (int i = 0; i < _wordText.Length; i++)
            {
                hiddenText = hiddenText + "_";
            }
            return hiddenText;
        }
        else
        {
            return _wordText;
        }
    }
}
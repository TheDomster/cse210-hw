using System;
using System.Collections.Generic;

public class Scripture
{
    private Reference _verseReference; // this is an attribute
    private List<Word> _verseWords = new List<Word>(); // this is an attribute - contains the list of words

    public Scripture(Reference verseReference, string verseText) // this is a constructor
    {
        _verseReference = verseReference;
        string[] pieces = verseText.Split(" "); // this is a behavior - splits the verse into separate words

        foreach (string piece in pieces)
        {
            Word eachWord = new Word(piece);
            _verseWords.Add(eachWord);
        }
    }

    public string DisplayScripture() // this is a method
    {
        string fullPassage = _verseReference.DisplayReference() + " "; // this is a behavior - puts it all together
        foreach (Word eachWord in _verseWords)
        {
            fullPassage = fullPassage + eachWord.DisplayWord() + " ";
        }
        return fullPassage;
    }

    public void HideRandomWords(int numberToHide) // this is a method
    {
        Random picker = new Random();

        for (int i = 0; i < numberToHide; i++) // this is a behavior - picks random unhidden words to hide
        {
            List<Word> visibleWords = new List<Word>();
            foreach (Word eachWord in _verseWords)
            {
                if (eachWord.IsHidden() == false)
                {
                    visibleWords.Add(eachWord);
                }
            }

            if (visibleWords.Count > 0)
            {
                int randomNumber = picker.Next(visibleWords.Count);
                visibleWords[randomNumber].Hide();
            }

        }
    }

    public bool AllWordsHidden() // method
    {
        foreach (Word eachWord in _verseWords) // this is a behavior - checks if all words are hidden
        {
            if (eachWord.IsHidden() == false)
            {
                return false;
            }
        }
        return true;

    }
    
}
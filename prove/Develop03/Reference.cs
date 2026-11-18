using System;

public class Reference
{
    private string _bookName; // this is an attribute
    private int _chapterNumber; // this is attribute
    private int _startVerse; // this is an attribute
    private int _endVerse; // this is an attribute

    public Reference(string bookName, int chapterNumber, int startVerse) // this is the constructor for single verse
    {
        _bookName = bookName; // behavior - sets single verse info
        _chapterNumber = chapterNumber;
        _startVerse = startVerse;
        _endVerse = 0;
    }

    public Reference(string bookName, int chapterNumber, int startVerse, int endVerse) // this is the constructor for multiple verses
    {
        _bookName = bookName; // this is a behavior - sets verse span
        _chapterNumber = chapterNumber;
        _startVerse = startVerse;
        _endVerse = endVerse;
    }

    public string DisplayReference() // this is a method
    {
        if (_endVerse == 0) // this is a behavior - puts it all together
        {
            return _bookName + " " + _chapterNumber + ":" + _startVerse;
        }
        else
        {
            return _bookName + " " + _chapterNumber + ":" + _startVerse + "-" + _endVerse;
        }
    }
}
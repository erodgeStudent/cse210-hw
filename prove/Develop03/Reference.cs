using System;

public class Reference
{
    //-----------ATTRIBUTES
    private string _book ;
    private int _chapter ;
    private int _begVerse ;
    private int _endVerse ;

    //-----------CONSTRUCTORS
    public Reference()
    {
        _book = "John";
        _chapter = 3;
        _begVerse = 5;
        _endVerse = 6;
    }

    public Reference(string book, int chapter, int begVerse)
    {
        _book = book;
        _chapter = chapter;
        _begVerse = begVerse;
    }

    public Reference(string book, int chapter, int begVerse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _begVerse = begVerse;
        _endVerse = endVerse; 
    }

    //-----------GETTERS and SETTERS

    public string GetReferenceString()
    {
        return $"{_book} {_chapter}:{_begVerse} ";
    }

    public string GetReferenceWithEndVal()
    {
        return $"{_book} {_chapter}:{_begVerse}-{_endVerse} ";
    }

}